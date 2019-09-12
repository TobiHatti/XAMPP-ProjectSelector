using EndevFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XAMPP_ProjectSelector2
{

    public partial class Form1 : Form
    {
        private BindingManager bm = new BindingManager();
        private string iniFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"XAMPP Project Selector\xamppPS.ini");
        private string projectsFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"XAMPP Project Selector\projects.ini");
        private string hotListFile = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), @"XAMPP Project Selector\hotlist.ini");
        private bool nextSaveIsEdit = false;

        private ProjectList projectInfos = new ProjectList();
        private ProjectInfo selectedProject;

        private ProjectList hotList = new ProjectList();

        public Form1()
        {
            InitializeComponent();

            // Projects
            //bm.AddBinding(btnHotSwitchP1, "Text", typeof(string), "Hot_P1", true);
            //bm.AddBinding(btnHotSwitchP2, "Text", typeof(string), "Hot_P2", true);
            //bm.AddBinding(btnHotSwitchP3, "Text", typeof(string), "Hot_P3", true);
            //bm.AddBinding(btnHotSwitchP4, "Text", typeof(string), "Hot_P4", true);
            //bm.AddBinding(btnHotSwitchP5, "Text", typeof(string), "Hot_P5", true);

            // Services
            bm.AddBinding(chbServiceApache, "Checked", typeof(bool), "Service_Apache");
            bm.AddBinding(chbServiceMySQL, "Checked", typeof(bool), "Service_MySQL");
            bm.AddBinding(chbServiceFileZilla, "Checked", typeof(bool), "Service_FileZilla");
            bm.AddBinding(chbServiceMercury, "Checked", typeof(bool), "Service_Mercury");
            bm.AddBinding(chbServiceTomcat, "Checked", typeof(bool), "Service_Tomcat");

            // Settings
            bm.AddBinding(lblXamppInstallPath, "Text", typeof(string), "XAMPP_Install_Path");

            bm.LoadBinding(iniFile);
            bm.FillBindings();

            if (btnHotSwitchP1.Text == "") btnHotSwitchP1.Text = "Project 1";
            if (btnHotSwitchP2.Text == "") btnHotSwitchP2.Text = "Project 2";
            if (btnHotSwitchP3.Text == "") btnHotSwitchP3.Text = "Project 3";
            if (btnHotSwitchP4.Text == "") btnHotSwitchP4.Text = "Project 4";
            if (btnHotSwitchP5.Text == "") btnHotSwitchP5.Text = "Project 5";

            projectInfos.LoadFromFile(projectsFile);
            hotList.LoadFromFile(hotListFile);

            cbxSavedProjects.DisplayMember = "ProjectName";
            cbxSavedProjects.ValueMember = "ProjectRoot";
            cbxSavedProjects.DataSource = projectInfos.GetList;

            // Fill hotlist
            if (hotList.Count >= 1)
            {
                btnHotSwitchP1.Enabled = true;
                btnHotSwitchP1.Text = hotList[0].ProjectName;
            }
            else btnHotSwitchP1.Enabled = false;

            if (hotList.Count >= 2)
            {
                btnHotSwitchP2.Enabled = true;
                btnHotSwitchP2.Text = hotList[1].ProjectName;
            }
            else btnHotSwitchP2.Enabled = false;

            if (hotList.Count >= 3)
            {
                btnHotSwitchP3.Enabled = true;
                btnHotSwitchP3.Text = hotList[2].ProjectName;
            }
            else btnHotSwitchP3.Enabled = false;

            if (hotList.Count >= 4)
            {
                btnHotSwitchP4.Enabled = true;
                btnHotSwitchP4.Text = hotList[3].ProjectName;
            }
            else btnHotSwitchP4.Enabled = false;

            if (hotList.Count >= 5)
            {
                btnHotSwitchP5.Enabled = true;
                btnHotSwitchP5.Text = hotList[4].ProjectName;
            }
            else btnHotSwitchP5.Enabled = false;

        }

        private void SaveData()
        {
            bm.SaveBindings(iniFile);
            projectInfos.SaveToFile(projectsFile);
            hotList.SaveToFile(hotListFile);
        }

        private void LblClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LblMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Form1_MouseDown(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private const int CS_DROPSHADOW = 0x20000;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void BtnSelectInstallPath_Click(object sender, EventArgs e)
        {
            if (fbdInstallPath.ShowDialog() == DialogResult.OK)
            {
                lblXamppInstallPath.Text = fbdInstallPath.SelectedPath;

                SaveData();
            }
        }

        private void BtnStartServices_Click(object sender, EventArgs e)
        {
            int serviceCtr = 0;
            int errorCtr = 0;
            ProcessStartInfo processInfo;
            Process batchProcess;
            if (Directory.Exists(lblXamppInstallPath.Text))
            {
                if (chbServiceApache.Checked)
                {
                    try
                    {
                        processInfo = new ProcessStartInfo(Path.Combine(lblXamppInstallPath.Text, "apache_start.bat"))
                        {
                            UseShellExecute = false,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            RedirectStandardOutput = false,
                            RedirectStandardError = true,
                        };
                        processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        processInfo.CreateNoWindow = true;
                        batchProcess = Process.Start(processInfo);
                        serviceCtr++;
                    }
                    catch { errorCtr++; }
                }
                if (chbServiceMySQL.Checked)
                {
                    try
                    {
                        processInfo = new ProcessStartInfo(Path.Combine(lblXamppInstallPath.Text, "mysql_start.bat"))
                        {
                            UseShellExecute = false,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            RedirectStandardOutput = false,
                            RedirectStandardError = true,
                        };
                        processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        processInfo.CreateNoWindow = true;
                        batchProcess = Process.Start(processInfo);
                        serviceCtr++;
                    }
                    catch { errorCtr++; }
                }
                if (chbServiceTomcat.Checked)
                {
                    try
                    {
                        processInfo = new ProcessStartInfo(Path.Combine(lblXamppInstallPath.Text, "catalina_start.bat"))
                        {
                            UseShellExecute = false,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            RedirectStandardOutput = false,
                            RedirectStandardError = true,
                        };
                        processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        processInfo.CreateNoWindow = true;
                        batchProcess = Process.Start(processInfo);
                        serviceCtr++;
                    }
                    catch { errorCtr++; }
                }
                if (chbServiceMercury.Checked)
                {
                    try
                    {
                        processInfo = new ProcessStartInfo(Path.Combine(lblXamppInstallPath.Text, "mercury_start.bat"))
                        {
                            UseShellExecute = false,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            RedirectStandardOutput = false,
                            RedirectStandardError = true,
                        };
                        processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        processInfo.CreateNoWindow = true;
                        batchProcess = Process.Start(processInfo);
                        serviceCtr++;
                    }
                    catch { errorCtr++; }
                }
                if (chbServiceFileZilla.Checked)
                {
                    try
                    {
                        processInfo = new ProcessStartInfo(Path.Combine(lblXamppInstallPath.Text, "filezilla_start.bat"))
                        {
                            UseShellExecute = false,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            RedirectStandardOutput = false,
                            RedirectStandardError = true,
                        };
                        processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        processInfo.CreateNoWindow = true;
                        batchProcess = Process.Start(processInfo);
                        serviceCtr++;
                    }
                    catch { errorCtr++; }
                }
            }
            else MessageBox.Show("The XAMPP-Install path is not valid! Set the corret Path in Settings > XAMPP Installation Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            nicNotify.Icon = Properties.Resources.xamppPS;
            nicNotify.BalloonTipTitle = "Services started";

            string errorMsg = "";
            if (errorCtr > 0)
            {
                errorMsg = $"{errorCtr} Services failed.\r\n";
                nicNotify.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else
            {
                errorMsg = ""; ;
                nicNotify.BalloonTipIcon = ToolTipIcon.Info;
            }

            nicNotify.BalloonTipText = $"Successfully started {serviceCtr} services.\r\n{errorMsg}Click here to open the control-panel.";

            nicNotify.Visible = true;
            nicNotify.ShowBalloonTip(100);

        }

        private void BtnStopServices_Click(object sender, EventArgs e)
        {
            int serviceCtr = 0;
            int errorCtr = 0;
            ProcessStartInfo processInfo;
            Process batchProcess;

            if (Directory.Exists(lblXamppInstallPath.Text))
            {
                if (chbServiceApache.Checked)
                {

                    try
                    {
                        processInfo = new ProcessStartInfo(Path.Combine(lblXamppInstallPath.Text, "apache_stop.bat"))
                        {
                            UseShellExecute = false,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            RedirectStandardOutput = false,
                            RedirectStandardError = true,
                        };
                        processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        processInfo.CreateNoWindow = true;
                        batchProcess = Process.Start(processInfo);
                        serviceCtr++;
                    }
                    catch { errorCtr++; }

                }
                if (chbServiceMySQL.Checked)
                {

                    try
                    {
                        processInfo = new ProcessStartInfo(Path.Combine(lblXamppInstallPath.Text, "mysql_stop.bat"))
                        {
                            UseShellExecute = false,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            RedirectStandardOutput = false,
                            RedirectStandardError = true,
                        };
                        processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        processInfo.CreateNoWindow = true;
                        batchProcess = Process.Start(processInfo);
                        serviceCtr++;
                    }
                    catch { errorCtr++; }
                }
                if (chbServiceTomcat.Checked)
                {
                    try
                    {
                        processInfo = new ProcessStartInfo(Path.Combine(lblXamppInstallPath.Text, "catalina_stop.bat"))
                        {
                            UseShellExecute = false,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            RedirectStandardOutput = false,
                            RedirectStandardError = true,
                        };
                        processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        processInfo.CreateNoWindow = true;
                        batchProcess = Process.Start(processInfo);
                        serviceCtr++;
                    }
                    catch { errorCtr++; }
                }
                if (chbServiceMercury.Checked)
                {
                    try
                    {
                        processInfo = new ProcessStartInfo(Path.Combine(lblXamppInstallPath.Text, "mercury_stop.bat"))
                        {
                            UseShellExecute = false,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            RedirectStandardOutput = false,
                            RedirectStandardError = true,
                        };
                        processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        processInfo.CreateNoWindow = true;
                        batchProcess = Process.Start(processInfo);
                        serviceCtr++;
                    }
                    catch { errorCtr++; }
                }
                if (chbServiceFileZilla.Checked)
                {
                    try
                    {
                        processInfo = new ProcessStartInfo(Path.Combine(lblXamppInstallPath.Text, "filezilla_stop.bat"))
                        {
                            UseShellExecute = false,
                            WindowStyle = ProcessWindowStyle.Hidden,
                            RedirectStandardOutput = false,
                            RedirectStandardError = true,
                        };
                        processInfo.WindowStyle = ProcessWindowStyle.Hidden;
                        processInfo.CreateNoWindow = true;
                        batchProcess = Process.Start(processInfo);
                        serviceCtr++;
                    }
                    catch { errorCtr++; }
                }
            }
            else MessageBox.Show("The XAMPP-Install path is not valid! Set the corret Path in Settings > XAMPP Installation Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            nicNotify.Icon = Properties.Resources.xamppPS;
            nicNotify.BalloonTipTitle = "Services stopped";

            string errorMsg = "";
            if (errorCtr > 0)
            {
                errorMsg = $"{errorCtr} Services failed.\r\n";
                nicNotify.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else
            {
                errorMsg = ""; ;
                nicNotify.BalloonTipIcon = ToolTipIcon.Info;
            }

            nicNotify.BalloonTipText = $"Successfully stopped {serviceCtr} services.\r\n{errorMsg}Click here to open the control-panel.";


            nicNotify.Visible = true;
            nicNotify.ShowBalloonTip(100);
        }

        private void BtnAddNewProject_Click(object sender, EventArgs e)
        {
            txbProjectTitle.Text = "Your Project Title";
            txbProjectDescription.Text = "Your Project Description";
            lblProjectRootPath.Text = "No Path Set";

            btnAddNewProject.Enabled = false;
            txbProjectTitle.Enabled = true;
            txbProjectDescription.Enabled = true;
            btnSelectRootDirectory.Enabled = true;
            btnSaveProject.Enabled = true;
            btnCancel.Enabled = true;

            nextSaveIsEdit = false;
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to cancel?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnAddNewProject.Enabled = true;
                txbProjectTitle.Enabled = false;
                txbProjectDescription.Enabled = false;
                btnSelectRootDirectory.Enabled = false;
                btnSaveProject.Enabled = false;
                btnCancel.Enabled = false;

                nextSaveIsEdit = false;
            }
        }

        private void BtnSaveProject_Click(object sender, EventArgs e)
        {
            btnAddNewProject.Enabled = true;
            txbProjectTitle.Enabled = false;
            txbProjectDescription.Enabled = false;
            btnSelectRootDirectory.Enabled = false;
            btnSaveProject.Enabled = false;
            btnCancel.Enabled = false;

            if (nextSaveIsEdit)
            {
                // Remove old entry
                projectInfos.RemoveAt(cbxSavedProjects.SelectedIndex);

                // Add new entry
                projectInfos.Add(new ProjectInfo(txbProjectTitle.Text, txbProjectDescription.Text, lblProjectRootPath.Text));
            }
            else projectInfos.Add(new ProjectInfo(txbProjectTitle.Text, txbProjectDescription.Text, lblProjectRootPath.Text));

            cbxSavedProjects.DataSource = null;
            cbxSavedProjects.Items.Clear();
            cbxSavedProjects.DisplayMember = "ProjectName";
            cbxSavedProjects.ValueMember = "ProjectRoot";
            cbxSavedProjects.DataSource = projectInfos.GetList;

            nextSaveIsEdit = false;

            MessageBox.Show("Project successfully added!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            tabMain.SelectTab(0);
            cbxSavedProjects.SelectedIndex = projectInfos.Count - 1;

            SaveData();
        }

        private void BtnSelectRootDirectory_Click(object sender, EventArgs e)
        {
            if (fbdRootPath.ShowDialog() == DialogResult.OK)
            {
                lblProjectRootPath.Text = fbdRootPath.SelectedPath;
            }
        }

        private void BtnManageProject_Click(object sender, EventArgs e)
        {
            tabMain.SelectTab(2);

            nextSaveIsEdit = true;

            btnAddNewProject.Enabled = false;
            txbProjectTitle.Enabled = true;
            txbProjectDescription.Enabled = true;
            btnSelectRootDirectory.Enabled = true;
            btnSaveProject.Enabled = true;
            btnCancel.Enabled = true;

            foreach (ProjectInfo pi in projectInfos.GetList)
                if (pi.ProjectRoot == cbxSavedProjects.SelectedValue.ToString())
                {
                    txbProjectTitle.Text = pi.ProjectName;
                    txbProjectDescription.Text = pi.ProjectDescription;
                    lblProjectRootPath.Text = pi.ProjectRoot;
                }
        }

        private void BtnDeleteProject_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Would you really like to remove this project?", "Remove Project", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                projectInfos.RemoveAt(cbxSavedProjects.SelectedIndex);

                cbxSavedProjects.DataSource = null;
                cbxSavedProjects.Items.Clear();
                cbxSavedProjects.DisplayMember = "ProjectName";
                cbxSavedProjects.ValueMember = "ProjectRoot";
                cbxSavedProjects.DataSource = projectInfos.GetList;

                SaveData();
            }
        }

        private void BtnSelectProject_Click(object sender, EventArgs e)
        {
            try
            {

                SelectProject(projectInfos[cbxSavedProjects.SelectedIndex]);
                SaveData();
            }
            catch
            {
                MessageBox.Show($"An error occured whilst trying to select the project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SelectProject(ProjectInfo pIngo)
        {
            try
            {

                bool projectInHotList = false;
                int projectIndex = -1;
                ProjectInfo piTmp;
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        if (hotList[i].ToString() == pIngo.ToString())
                        {
                            projectInHotList = true;
                            projectIndex = i;
                        }
                    }
                    catch { }
                }

                if (!projectInHotList) hotList.GetList.Insert(0, pIngo);
                if (projectInHotList)
                {
                    piTmp = hotList[projectIndex];
                    hotList.RemoveAt(projectIndex);
                    hotList.GetList.Insert(0, piTmp);
                }




                //selectedProject = projectInfos[cbxSavedProjects.SelectedIndex];
                selectedProject = pIngo;

                string httpdConfPath = Path.Combine(lblXamppInstallPath.Text, @"apache\conf\httpd.conf");

                string projectPath = selectedProject.ProjectRoot;

                string line;

                StreamReader sr = new StreamReader(httpdConfPath);
                StreamWriter sw = new StreamWriter(httpdConfPath + "temp");

                while ((line = sr.ReadLine()) != null)
                {
                    if (line.StartsWith("DocumentRoot"))
                    {
                        sw.WriteLine("DocumentRoot \"{0}\"", projectPath.Replace('\\', '/'));
                        sw.WriteLine("<Directory \"{0}\">", projectPath.Replace('\\', '/'));
                        sr.ReadLine();
                    }
                    else sw.WriteLine(line);
                }

                sw.Close();
                sr.Close();

                File.Delete(httpdConfPath);
                File.Move(httpdConfPath + "temp", httpdConfPath);

                MessageBox.Show($"Project {selectedProject.ProjectName} selected!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show($"Could not select Project! Check your Project root path and make sure the XAMPP install path is correct!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnToggleAllServicesOn_Click(object sender, EventArgs e)
        {
            chbServiceApache.Checked = true;
            chbServiceMySQL.Checked = true;
            chbServiceFileZilla.Checked = true;
            chbServiceTomcat.Checked = true;
            chbServiceMercury.Checked = true;

            SaveData();
        }

        private void BtnToggleAllServicesOff_Click(object sender, EventArgs e)
        {
            chbServiceApache.Checked = false;
            chbServiceMySQL.Checked = false;
            chbServiceFileZilla.Checked = false;
            chbServiceTomcat.Checked = false;
            chbServiceMercury.Checked = false;

            SaveData();
        }

        private void ChbServiceApache_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void ChbServiceMySQL_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void ChbServiceFileZilla_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void ChbServiceMercury_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        private void ChbServiceTomcat_Click(object sender, EventArgs e)
        {
            SaveData();
        }


        private void BtnHotSwitchP1_Click(object sender, EventArgs e)
        {
            try
            {
                SelectProject(hotList[0]);
            }
            catch
            {
                MessageBox.Show($"An error occured whilst trying to select the project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHotSwitchP2_Click(object sender, EventArgs e)
        {
            try
            {
                SelectProject(hotList[1]);
            }
            catch
            {
                MessageBox.Show($"An error occured whilst trying to select the project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void BtnHotSwitchP3_Click(object sender, EventArgs e)
        {
            try
            {
                SelectProject(hotList[2]);
            }
            catch
            {
                MessageBox.Show($"An error occured whilst trying to select the project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHotSwitchP4_Click(object sender, EventArgs e)
        {
            try
            {
                SelectProject(hotList[3]);
            }
            catch
            {
                MessageBox.Show($"An error occured whilst trying to select the project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnHotSwitchP5_Click(object sender, EventArgs e)
        {
            try
            {
                SelectProject(hotList[4]);
            }
            catch
            {
                MessageBox.Show($"An error occured whilst trying to select the project!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
