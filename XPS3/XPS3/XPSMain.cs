﻿using MetroSet_UI.Controls;
using MetroSet_UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPS3
{
   
    public partial class XPSMain : Form
    {
        private bool allowExit = false;

        private readonly string XPSDataFile = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\XPS3\xpsdat.db";
        private readonly string ConString = $@"URI=file:{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\XPS3\xpsdat.db";
        private SQLiteConnection connection = null;
        private SQLiteCommand cmd = null;

        private string defaultEditor = "notepad.exe";
        private string xamppInstallPath = null;

        private bool disableOnCheckChangeUpdate = true;

        private volatile Process[] processes;

        private int[] projectHotswapIDs = new int[6];
        private int currentlyActiveProjectID = -1;

        private enum XPSProcess
        {
            Apache,
            MySQL,
            FileZilla,
            Mercury,
            Tomcat
        }

        public XPSMain()
        {
            try
            {
                InitializeComponent();

                processes = Process.GetProcesses();

                nicNotify.Icon = Properties.Resources.xamppPS;

                disableOnCheckChangeUpdate = true;
                SetServiceImages();
                CreateDBCon();
                LoadDBDataToForm();
                disableOnCheckChangeUpdate = false;

                
            }
            catch(Exception ex)
            {
                MessageBox.Show($"An error occured whilst starting the Program (E01). \r\n\r\n\r\n{ex.Message}", "Startup-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XPSMain_Load(object sender, EventArgs e)
        {
            try
            {
                SelectRecentProject();
                RunAutostart();
                UpdateProjectLists();
                UpdateRecentList();
                bgwServiceMonitor.RunWorkerAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured whilst starting the Program (E02). \r\n\r\n\r\n{ex.Message}", "Startup-Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void XPSMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!allowExit)
            {
                e.Cancel = true;
                this.WindowState = FormWindowState.Minimized;

                nicNotify.BalloonTipTitle = "XPS3 is still running!";
                nicNotify.BalloonTipText = $"Right-click the XPS3-icon in your system-tray for more options.";
                nicNotify.BalloonTipIcon = ToolTipIcon.Info;
                nicNotify.ShowBalloonTip(100);
            }

        }

        private void RunAutostart()
        {
            if (chbAutostartApache.Checked) StartServiceRoutine(XPSProcess.Apache);
            if (chbAutostartMySQL.Checked) StartServiceRoutine(XPSProcess.MySQL);
            if (chbAutostartFileZilla.Checked) StartServiceRoutine(XPSProcess.FileZilla);
            if (chbAutostartMercury.Checked) StartServiceRoutine(XPSProcess.Mercury);
            if (chbAutostartTomcat.Checked) StartServiceRoutine(XPSProcess.Tomcat);
        }

        private void CreateDBCon()
        {
            bool fileExitst = true;

            // Check if the db-file already exists, Create and set up the DB if it doesn't exist yet

            if (!File.Exists(XPSDataFile))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(XPSDataFile));
                fileExitst = false;
            }

            // Open the connection to the DB
            connection = new SQLiteConnection(ConString);
            connection.Open();

            // Set up db (only on first execution)
            cmd = new SQLiteCommand(connection);
            if (!fileExitst)
            {
                cmd.CommandText = @"CREATE TABLE 'Settings' ('ID' INTEGER PRIMARY KEY AUTOINCREMENT, 'Key' TEXT UNIQUE, 'Value' TEXT);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE 'Log' ('ID' INTEGER PRIMARY KEY AUTOINCREMENT, 'ProjectID' INTEGER, 'SelectedDate' TEXT)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE 'Projects' ( 'ID' INTEGER PRIMARY KEY AUTOINCREMENT, 'Name' TEXT, 'Description' TEXT, 'RootDirectory' TEXT, 'Image' TEXT, 'ApacheEnabled' TEXT, 'MySQLEnabled' TEXT, 'FileZillaEnabled'  TEXT, 'MercuryEnabled' TEXT, 'TomcatEnabled' TEXT);";
                cmd.ExecuteNonQuery();

                cmd.CommandText = "INSERT INTO Projects (Name, Description, RootDirectory, Image, ApacheEnabled, MySQLEnabled, FileZillaEnabled, MercuryEnabled, TomcatEnabled) VALUES " +
                        $"('Default Project','Default Project','C:\\xampp','','False','False','False','False','False')";
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        private void SettingsPoke(string pKey, object pValue)
        {
            connection.Open();
            cmd.CommandText = $@"SELECT COUNT(*) FROM Settings WHERE Key = '{pKey}'"; ;
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
            {
                // New entry
                cmd.CommandText = $@"INSERT INTO Settings (Key, Value) VALUES ('{pKey}', '{pValue}')";
                cmd.ExecuteNonQuery();
            }
            else
            {
                // Update entry
                cmd.CommandText = $@"UPDATE Settings SET Value = '{pValue}' WHERE Key = '{pKey}'";
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }

        private object SettingsPeek(string pKey, object pDefaultValue = null)
        {
            connection.Open();
            cmd.CommandText = $@"SELECT Value FROM Settings WHERE Key = '{pKey}'";
            object result = cmd.ExecuteScalar();
            connection.Close();
            if (result == null && pDefaultValue != null) return pDefaultValue;
            else return result;

        }

        private void LoadDBDataToForm()
        {
            // Services-Tab
            chbServiceApache.Switched = Convert.ToBoolean(SettingsPeek("ServiceStatusApache", true));
            chbServiceMySQL.Switched = Convert.ToBoolean(SettingsPeek("ServiceStatusMySQL", true));
            chbServiceFileZilla.Switched = Convert.ToBoolean(SettingsPeek("ServiceStatusFileZilla", false));
            chbServiceMercury.Switched = Convert.ToBoolean(SettingsPeek("ServiceStatusMercury", false));
            chbServiceTomcat.Switched = Convert.ToBoolean(SettingsPeek("ServiceStatusTomcat", false));

            // Settings-Tab
            xamppInstallPath = Convert.ToString(SettingsPeek("XAMPPInstall", @"C:\xampp"));
            defaultEditor = Convert.ToString(SettingsPeek("DefaultEditor", @"notepad.exe"));

            txbXamppInstallPath.Text = xamppInstallPath;
            txbDefaultEditorPath.Text = defaultEditor;

            chbAutostartApache.Checked = Convert.ToBoolean(SettingsPeek("AutostartApache", false));
            chbAutostartMySQL.Checked = Convert.ToBoolean(SettingsPeek("AutostartMySQL", false));
            chbAutostartFileZilla.Checked = Convert.ToBoolean(SettingsPeek("AutostartFileZilla", false));
            chbAutostartMercury.Checked = Convert.ToBoolean(SettingsPeek("AutostartMercury", false));
            chbAutostartTomcat.Checked = Convert.ToBoolean(SettingsPeek("AutostartTomcat", false));

            rbnAutostartAfterSwitchTrue.Checked = Convert.ToBoolean(SettingsPeek("AutostartAfterSwitch", true));
            rbnAutostartAfterSwitchFalse.Checked = !Convert.ToBoolean(SettingsPeek("AutostartAfterSwitch", true));
        }

        private void LaunchInEditor(string pRelativePathToFile)
        {
            if (!(Directory.Exists(xamppInstallPath) && File.Exists(Path.Combine(xamppInstallPath, "xampp-control.exe")) && Directory.Exists(Path.Combine(xamppInstallPath, "htdocs"))))
            {
                MessageBox.Show("Your XAMPP-Installation-Path is not valid! Please check if you have selected the correct folder in the \"Settings\"-Tab", "Wrong XAMPP-Folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            Process.Start(defaultEditor, Path.Combine(xamppInstallPath, pRelativePathToFile));
        }

        private void OpenFolder(string pRelativePathToFolder)
        {
            if (!(Directory.Exists(xamppInstallPath) && File.Exists(Path.Combine(xamppInstallPath, "xampp-control.exe")) && Directory.Exists(Path.Combine(xamppInstallPath, "htdocs"))))
            {
                MessageBox.Show("Your XAMPP-Installation-Path is not valid! Please check if you have selected the correct folder in the \"Settings\"-Tab", "Wrong XAMPP-Folder", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            ProcessStartInfo startInfo = new ProcessStartInfo
            {
                Arguments = Path.Combine(xamppInstallPath, pRelativePathToFolder),
                FileName = "explorer.exe"
            };

            Process.Start(startInfo);
        }

        #region ========== Main Page ========== 

        #region ---------- Start / Stop Services ----------

        private void StartServiceRoutine(XPSProcess pProcess)
        {
            switch(pProcess)
            {
                case XPSProcess.Apache:
                    startAtmptApache = true;
                    pbxApacheStatus.BackColor = Color.Orange;
                    pbxApacheStatus.Invalidate();
                    AttemptStartService("Apache", "apache_start.bat", XPSProcess.Apache);
                    break;
                case XPSProcess.MySQL:
                    startAtmptMySQL = true;
                    pbxMySQLStatus.BackColor = Color.Orange;
                    pbxMySQLStatus.Invalidate();
                    AttemptStartService("MySQL", "mysql_start.bat", XPSProcess.MySQL);
                    break;
                case XPSProcess.FileZilla:
                    startAtmptFileZilla = true;
                    pbxFileZillaStatus.BackColor = Color.Orange;
                    pbxFileZillaStatus.Invalidate();
                    AttemptStartService("FileZilla", "filezilla_start.bat", XPSProcess.FileZilla);
                    break;
                case XPSProcess.Mercury:
                    startAtmptMercury = true;
                    pbxMercuryStatus.BackColor = Color.Orange;
                    pbxMercuryStatus.Invalidate();
                    AttemptStartService("Mercury", "mercury_start.bat", XPSProcess.Mercury);
                    break;
                case XPSProcess.Tomcat:
                    startAtmptTomcat = true;
                    pbxTomcatStatus.BackColor = Color.Orange;
                    pbxTomcatStatus.Invalidate();
                    AttemptStartService("Tomcat", "tomcat_start.bat", XPSProcess.Tomcat);
                    break;
            }
        }

        private void StopServiceRoutine(XPSProcess pProcess)
        {
            switch (pProcess)
            {
                case XPSProcess.Apache:
                    stopAtmptApache = true;
                    pbxApacheStatus.BackColor = Color.Orange;
                    pbxApacheStatus.Invalidate();
                    AttemptStartService("Apache", "apache_stop.bat", XPSProcess.Apache, true);
                    break;
                case XPSProcess.MySQL:
                    stopAtmptMySQL = true;
                    pbxMySQLStatus.BackColor = Color.Orange;
                    pbxMySQLStatus.Invalidate();
                    AttemptStartService("MySQL", "mysql_stop.bat", XPSProcess.MySQL, true);
                    break;
                case XPSProcess.FileZilla:
                    stopAtmptFileZilla = true;
                    pbxFileZillaStatus.BackColor = Color.Orange;
                    pbxFileZillaStatus.Invalidate();
                    AttemptStartService("FileZilla", "filezilla_stop.bat", XPSProcess.FileZilla, true);
                    break;
                case XPSProcess.Mercury:
                    stopAtmptMercury = true;
                    pbxMercuryStatus.BackColor = Color.Orange;
                    pbxMercuryStatus.Invalidate();
                    AttemptStartService("Mercury", "mercury_stop.bat", XPSProcess.Mercury, true);
                    break;
                case XPSProcess.Tomcat:
                    stopAtmptTomcat = true;
                    pbxTomcatStatus.BackColor = Color.Orange;
                    pbxTomcatStatus.Invalidate();
                    AttemptStartService("Tomcat", "tomcat_stop.bat", XPSProcess.Tomcat, true);
                    break;
            }
        }

        private void btnStartServices_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attempting to start services...", "Starting Services", MessageBoxButtons.OK, MessageBoxIcon.Information);
            if (chbServiceApache.Switched) StartServiceRoutine(XPSProcess.Apache);
            if (chbServiceMySQL.Switched) StartServiceRoutine(XPSProcess.MySQL);
            if (chbServiceFileZilla.Switched) StartServiceRoutine(XPSProcess.FileZilla);
            if (chbServiceMercury.Switched) StartServiceRoutine(XPSProcess.Mercury);
            if (chbServiceTomcat.Switched) StartServiceRoutine(XPSProcess.Tomcat);
        }

        private void btnStopServices_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Attempting to stop services...", "Stop Services", MessageBoxButtons.OK, MessageBoxIcon.Information);
            StopServiceRoutine(XPSProcess.Apache);
            StopServiceRoutine(XPSProcess.MySQL);
            StopServiceRoutine(XPSProcess.FileZilla);
            StopServiceRoutine(XPSProcess.Mercury);
            StopServiceRoutine(XPSProcess.Tomcat);
        }

        private bool IsProcessOpen(XPSProcess pProcess)
        {
            string name = null;

            switch(pProcess)
            {
                case XPSProcess.Apache: name = "httpd"; break;
                case XPSProcess.MySQL: name = "mysqld"; break;
                case XPSProcess.FileZilla: name = "FileZillaServer"; break;
                case XPSProcess.Mercury: name = "mercury"; break;
                case XPSProcess.Tomcat: name = "catalina"; break;
            }

            lock (processes)
            {
                foreach (Process clsProcess in processes)
                {
                    if (clsProcess.ProcessName.Contains(name))
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        private void UpdateRecentList()
        {
            for (int i = 0; i < projectHotswapIDs.Length; i++) projectHotswapIDs[i] = -1;

            connection.Open();
            // Doesn't work because of the implementation in SQLite, cannot order by newest date.
            // cmd.CommandText = "SELECT * FROM (SELECT * FROM Log ORDER BY SelectedDate DESC) GROUP BY ProjectID";
            cmd.CommandText = "SELECT * FROM Log ORDER BY SelectedDate DESC";
            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                int i = 0;
                while(reader.Read())
                {
                    bool idFound = false;

                    for (int k = 0; k < projectHotswapIDs.Length; k++)
                        if (projectHotswapIDs[k] == Convert.ToInt32(reader["ProjectID"]))
                            idFound = true;

                    if(!idFound)
                        projectHotswapIDs[i++] = Convert.ToInt32(reader["ProjectID"]);
                }
                    
            }
            connection.Close();

            for(int i = 0; i < projectHotswapIDs.Length; i++)
            {
                Control currentTile = this.Controls.Find($"btnHotSwitchP{i+1}", true)[0];
                if (projectHotswapIDs[i] != -1)
                {
                    currentTile.Font = new Font(currentTile.Font, FontStyle.Regular);
                    currentTile.Enabled = true;
                    connection.Open();
                    cmd.CommandText = $"SELECT Name FROM Projects WHERE ID = {projectHotswapIDs[i]}";
                    currentTile.Text = Convert.ToString(cmd.ExecuteScalar());
                    connection.Close();
                }
                else
                {
                    currentTile.Font = new Font(currentTile.Font, FontStyle.Italic);
                    currentTile.Text = "No Recent Projects.";
                    currentTile.Enabled = false;
                }

                
                currentTile.Refresh();
                currentTile.Update();
            }
        }

        private void SelectRecentProject()
        {
            int recentOption = 0;

            connection.Open();
            cmd.CommandText = "SELECT COUNT(*) FROM Log";
            int logCount = Convert.ToInt32(cmd.ExecuteScalar());
            connection.Close();

            if(logCount != 0)
            {
                connection.Open();
                cmd.CommandText = "SELECT ProjectID FROM Log ORDER BY SelectedDate DESC LIMIT 1";
                recentOption = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
            }
            else
            {
                connection.Open();
                cmd.CommandText = "SELECT ID FROM Projects ORDER BY ID ASC LIMIT 1";
                recentOption = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
            }

            SelectProjectOption(recentOption);
        }



        private void tmrCheckServiceStatus_Tick(object sender, EventArgs e)
        {
            pbxApacheStatus.Invalidate();
            pbxMySQLStatus.Invalidate();
            pbxFileZillaStatus.Invalidate();
            pbxMercuryStatus.Invalidate();
            pbxTomcatStatus.Invalidate();
        }

        private void AttemptStartService(string pProcessClearName, string pProcessFile, XPSProcess pProcessType, bool pForceShutdownMode = false)
        {
            bool processRunning = IsProcessOpen(pProcessType);

            if ((!processRunning && !pForceShutdownMode) || (processRunning && pForceShutdownMode))
            {
                try
                {
                    Process batchProcess;
                    ProcessStartInfo processInfo = new ProcessStartInfo(Path.Combine(xamppInstallPath, pProcessFile))
                    {
                        UseShellExecute = false,
                        WindowStyle = ProcessWindowStyle.Hidden,
                        RedirectStandardOutput = false,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    };
                    batchProcess = Process.Start(processInfo);

                }
                catch
                {
                    if(pForceShutdownMode) MessageBox.Show($"An error occured whilst trying to stop {pProcessClearName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else MessageBox.Show($"An error occured whilst trying to start {pProcessClearName}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region ---------- Edit / Select / Delete Projects ----------

        private void btnSeletProject_Click(object sender, EventArgs e)
        {
            SelectProjectOption(Convert.ToInt32(cbxSavedProjects.SelectedValue));
        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {
            EditProject(Convert.ToInt32(cbxSavedProjects.SelectedValue));
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            DeleteProject(Convert.ToInt32(cbxSavedProjects.SelectedValue));
        }

        private void SelectProjectOption(int pProjectID)
        {
       
            foreach(DataRowView item in cbxSavedProjects.Items)
            {
                if (Convert.ToInt32(item.Row.ItemArray[0]) == pProjectID) cbxSavedProjects.SelectedValue = pProjectID;
            }

            //StopServiceRoutine(XPSProcess.Apache);

            currentlyActiveProjectID = pProjectID;

            string projectName = "";
            string projectPath = "";

            bool startApache = false;
            bool startMySQL = false;
            bool startFileZilla = false;
            bool startMercury = false;
            bool startTomcat = false;

            // Load Project-Data from DB
            connection.Open();
            cmd.CommandText = $"SELECT * FROM Projects WHERE ID = {pProjectID}";
            using(SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while(reader.Read())
                {
                    projectName = reader["Name"].ToString();
                    projectPath = reader["RootDirectory"].ToString();

                    startApache = Convert.ToBoolean(reader["ApacheEnabled"]);
                    startMySQL = Convert.ToBoolean(reader["MySQLEnabled"]);
                    startFileZilla = Convert.ToBoolean(reader["FileZillaEnabled"]);
                    startMercury = Convert.ToBoolean(reader["MercuryEnabled"]);
                    startTomcat = Convert.ToBoolean(reader["TomcatEnabled"]);
                }
            }
            connection.Close();

            // Set up Project (1) - Set Apache Config
            lblSelectedProject.Text = $"Selected Project: {projectName}";
            string line;
            string oldConfigFile = Path.Combine(xamppInstallPath, @"apache\conf\httpd.conf");
            string newConfigFile = Path.Combine(xamppInstallPath, @"apache\conf\httpd-tmp.conf");
            try
            {
                using (StreamReader sr = new StreamReader(oldConfigFile))
                {
                    using (StreamWriter sw = new StreamWriter(newConfigFile))
                    {
                        while ((line = sr.ReadLine()) != null)
                        {
                            if (line.StartsWith("DocumentRoot"))
                            {
                                sw.WriteLine($@"DocumentRoot ""{projectPath.Replace('\\', '/')}""");
                                sw.WriteLine($@"<Directory ""{projectPath.Replace('\\', '/')}"">");
                                sr.ReadLine();
                            }
                            else sw.WriteLine(line);
                        }
                        sw.Close();
                    }
                    sr.Close();
                }
                File.Delete(oldConfigFile);
                File.Move(newConfigFile, oldConfigFile);
            }
            catch
            {
                MessageBox.Show("An error occured whilst trying to select and set up the project. Please try again later.", "Could not select Project", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Set up Project (2) - Select default services
            chbServiceApache.Switched = startApache;
            chbServiceMySQL.Switched = startMySQL;
            chbServiceFileZilla.Switched = startFileZilla;
            chbServiceMercury.Switched = startMercury;
            chbServiceTomcat.Switched = startTomcat;

            // Set up Project (3) - Start services if flag is set
            if(rbnAutostartAfterSwitchTrue.Checked)
            {
                if (chbServiceApache.Switched) StartServiceRoutine(XPSProcess.Apache);
                if (chbServiceMySQL.Switched) StartServiceRoutine(XPSProcess.MySQL);
                if (chbServiceFileZilla.Switched) StartServiceRoutine(XPSProcess.FileZilla);
                if (chbServiceMercury.Switched) StartServiceRoutine(XPSProcess.Mercury);
                if (chbServiceTomcat.Switched) StartServiceRoutine(XPSProcess.Tomcat);
            }

            // Add Log-Entry
            connection.Open();
            cmd.CommandText = $"INSERT INTO Log (ProjectID, SelectedDate) VALUES ('{pProjectID}','{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}')";
            cmd.ExecuteNonQuery();
            connection.Close();

        }

        #endregion

        #region ---------- HotSwap Projects ----------

        private void btnHotSwitchP1_Click(object sender, EventArgs e) => SelectProjectOption(projectHotswapIDs[0]);
        private void btnHotSwitchP2_Click(object sender, EventArgs e) => SelectProjectOption(projectHotswapIDs[1]);
        private void btnHotSwitchP3_Click(object sender, EventArgs e) => SelectProjectOption(projectHotswapIDs[2]);
        private void btnHotSwitchP4_Click(object sender, EventArgs e) => SelectProjectOption(projectHotswapIDs[3]);
        private void btnHotSwitchP5_Click(object sender, EventArgs e) => SelectProjectOption(projectHotswapIDs[4]);
        private void btnHotSwitchP6_Click(object sender, EventArgs e) => SelectProjectOption(projectHotswapIDs[5]);

        #endregion

        #endregion

        #region ========== Services Page ==========

        private void SetServiceImages()
        {
            pbxLogoApache.Image = Properties.Resources.apache;
            pbxLogoMySQL.Image = Properties.Resources.mysql;
            pbxLogoFileZilla.Image = Properties.Resources.filezilla;
            pbxLogoMercury.Image = Properties.Resources.mercury;
            pbxLogoTomcat.Image = Properties.Resources.tomcat;
        }

        private void UpdateSelectedServices(object sender)
        {
            if (!disableOnCheckChangeUpdate)
            {
                SettingsPoke("ServiceStatusApache", chbServiceApache.Switched);
                SettingsPoke("ServiceStatusMySQL", chbServiceMySQL.Switched);
                SettingsPoke("ServiceStatusFileZilla", chbServiceFileZilla.Switched);
                SettingsPoke("ServiceStatusMercury", chbServiceMercury.Switched);
                SettingsPoke("ServiceStatusTomcat", chbServiceTomcat.Switched);
            }
        }

        #region ---------- Start / Stop Single ----------

        private void btnStartStopApache_Click(object sender, EventArgs e)
        {
            if(IsProcessOpen(XPSProcess.Apache)) StopServiceRoutine(XPSProcess.Apache);
            else StartServiceRoutine(XPSProcess.Apache);
        }

        private void btnStartStopMySQL_Click(object sender, EventArgs e)
        {
            if (IsProcessOpen(XPSProcess.MySQL)) StopServiceRoutine(XPSProcess.MySQL);
            else StartServiceRoutine(XPSProcess.MySQL);
        }

        private void btnStartStopFileZilla_Click(object sender, EventArgs e)
        {
            if (IsProcessOpen(XPSProcess.FileZilla)) StopServiceRoutine(XPSProcess.FileZilla);
            else StartServiceRoutine(XPSProcess.FileZilla);
        }

        private void btnStartStopMercury_Click(object sender, EventArgs e)
        {
            if (IsProcessOpen(XPSProcess.Mercury)) StopServiceRoutine(XPSProcess.Mercury);
            else StartServiceRoutine(XPSProcess.Mercury);
        }

        private void btnStartStopTomcat_Click(object sender, EventArgs e)
        {
            if (IsProcessOpen(XPSProcess.Tomcat)) StopServiceRoutine(XPSProcess.Tomcat);
            else StartServiceRoutine(XPSProcess.Tomcat);
        }

        #endregion

        #region ---------- Enable / Disable all ----------

        private void btnEnableAllServices_Click(object sender, EventArgs e)
        {
            chbServiceApache.Switched = true;
            chbServiceMySQL.Switched = true;
            chbServiceFileZilla.Switched = true;
            chbServiceMercury.Switched = true;
            chbServiceTomcat.Switched = true;
        }

        private void btnDisableAllServices_Click(object sender, EventArgs e)
        {
            chbServiceApache.Switched = false;
            chbServiceMySQL.Switched = false;
            chbServiceFileZilla.Switched = false;
            chbServiceMercury.Switched = false;
            chbServiceTomcat.Switched = false;
        }

        #endregion

        #region ---------- Admin-Btn / Picturebox ---------- 

        private void pbxSetAA_Paint(object sender, PaintEventArgs e) => e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        private void pbxLogoApache_Click(object sender, EventArgs e) => Process.Start("http://localhost/");
        private void pbxLogoMySQL_Click(object sender, EventArgs e) => Process.Start("http://localhost/phpmyadmin/");
        private void pbxLogoFileZilla_Click(object sender, EventArgs e) => Process.Start(Path.Combine(xamppInstallPath, @"FileZillaFTP\FileZilla Server Interface.exe"));
        private void pbxLogoMercury_Click(object sender, EventArgs e) => Process.Start(Path.Combine(xamppInstallPath, @"MercuryMail\mercury.exe"));
        private void pbxLogoTomcat_Click(object sender, EventArgs e)
        {
            // Launch TODO
        }

        #endregion

        #region ---------- Open Context-Menu ----------

        private void btnApacheConfig_Click(object sender, EventArgs e) => cmsApacheConfig.Show(btnApacheConfig, 32,0);
        private void btnMySQLConfig_Click(object sender, EventArgs e) => cmsMySQLConfig.Show(btnMySQLConfig, 32, 0);
        private void btnFileZillaConfig_Click(object sender, EventArgs e) => cmsFileZillaConfig.Show(btnFileZillaConfig, 32, 0);
        private void btnMercuryConfig_Click(object sender, EventArgs e) => cmsMercuryConfig.Show(btnMercuryConfig, 32, 0);
        private void btnTomcatConfig_Click(object sender, EventArgs e) => cmsTomcatConfig.Show(btnTomcatConfig, 32, 0);

        #endregion

        #region ---------- Context-Menu Options ----------

        private void tsmApacheConfig_Click(object sender, EventArgs e) => LaunchInEditor(@"apache\conf\httpd.conf");
        private void tsmApacheSSLConfig_Click(object sender, EventArgs e) => LaunchInEditor(@"apache\conf\extra\httpd-ssl.conf");
        private void tslApacheXamppConfig_Click(object sender, EventArgs e) => LaunchInEditor(@"apache\conf\extra\httpd-xampp.conf");
        private void tslPhpConfig_Click(object sender, EventArgs e) => LaunchInEditor(@"php\php.ini");
        private void tslPhpMyAdminConfig_Click(object sender, EventArgs e) => LaunchInEditor(@"phpMyAdmin\config.inc.php");
        private void tslBrowseApache_Click(object sender, EventArgs e) => OpenFolder(@"apache");
        private void tslBrowsePhp_Click(object sender, EventArgs e) => OpenFolder(@"php");
        private void tslBrowsePhpMyAdmin_Click(object sender, EventArgs e) => OpenFolder(@"phpMyAdmin");
        private void tslTomcatConfig_Click(object sender, EventArgs e) => LaunchInEditor(@"tomcat\conf\server.xml");
        private void tslTomcatUsers_Click(object sender, EventArgs e) => LaunchInEditor(@"tomcat\conf\tomcat-users.xml");
        private void tslTomcatWeb_Click(object sender, EventArgs e) => LaunchInEditor(@"tomcat\conf\web.xml");
        private void tslTomcatContext_Click(object sender, EventArgs e) => LaunchInEditor(@"tomcat\conf\context.xml");
        private void tslBrowseTomcat_Click(object sender, EventArgs e) => OpenFolder(@"Tomcat\conf");
        private void tslMercuryConfig_Click(object sender, EventArgs e) => LaunchInEditor(@"MercuryMail\MERCURY.INI");
        private void tslBrowseMercury_Click(object sender, EventArgs e) => OpenFolder(@"MercuryMail");
        private void tslMySQLConfig_Click(object sender, EventArgs e) => LaunchInEditor(@"mysql\bin\my.ini");
        private void tslBrowseMySQL_Click(object sender, EventArgs e) => OpenFolder(@"mysql");
        private void tslFileZillaConfig_Click(object sender, EventArgs e) => LaunchInEditor(@"FileZillaFTP\FileZilla Server.xml");
        private void tslBrowseFileZilla_Click(object sender, EventArgs e) => OpenFolder(@"FileZillaFTP");
        private void tslLogApacheAccess_Click(object sender, EventArgs e) => LaunchInEditor(@"apache\logs\access.log");
        private void tslLogApacheError_Click(object sender, EventArgs e) => LaunchInEditor(@"apache\logs\error.log");
        private void tslLogPhpError_Click(object sender, EventArgs e) => LaunchInEditor(@"php\logs\php_error_log");
        private void tslLogBrowseApache_Click(object sender, EventArgs e) => OpenFolder(@"apache\logs");
        private void tslLogBrowsePHP_Click(object sender, EventArgs e) => OpenFolder(@"php\logs");
        private void tslLogMysqlError_Click(object sender, EventArgs e) => LaunchInEditor(@"mysql\data\mysql_error.log");
        private void tslLogBrowseMySQL_Click(object sender, EventArgs e) => OpenFolder(@"mysql\data");
        private void tslLogBrowseTomcat_Click(object sender, EventArgs e) => OpenFolder(@"MercuryMail\LOGS");
        private void tslLogBrowseMercury_Click(object sender, EventArgs e) => OpenFolder(@"tomcat\logs");

        #endregion

        #endregion

        #region ========== Manage Page ==========

        #region ---------- Add / Edit / Delete Projects ----------

        private void btnAddNewProject_Click(object sender, EventArgs e)
        {
            using (XPSAddProject addForm = new XPSAddProject())
            {
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    // Add new project to DB
                    connection.Open();
                    cmd.CommandText = "INSERT INTO Projects (Name, Description, RootDirectory, Image, ApacheEnabled, MySQLEnabled, FileZillaEnabled, MercuryEnabled, TomcatEnabled) VALUES " +
                        $"('{addForm.ProjectTitle.ToString()}','{addForm.ProjectDescription.ToString()}','{addForm.ProjectRoot.ToString()}','{Convert.ToString(addForm.ProjectImage)}'," +
                        $"'{addForm.DefOpApache.ToString()}','{addForm.DefOpMySQL.ToString()}','{addForm.DefOpFileZilla.ToString()}','{addForm.DefOpMercury.ToString()}','{addForm.DefOpTomcat.ToString()}')";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Project Successfully Added!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateProjectLists();
                }
            }
        }

        private void UpdateProjectLists()
        {
            cbxSavedProjects.DataSource = null;
            cbxSavedProjects.Items.Clear();

            dgvProjectList.Columns.Clear();
            dgvProjectList.Rows.Clear();
            dgvProjectList.Columns.Add("ID", "ID");
            dgvProjectList.Columns.Add("Name", "Name");
            dgvProjectList.Columns.Add("ProjectRoot", "Project Root");

            dgvProjectList.Columns[0].Visible = false;
            dgvProjectList.Columns[1].Width = 125;
            dgvProjectList.Columns[2].Width = 180;

            
            DataTable dtProjects = new DataTable();
            dtProjects.Columns.Add("ID", typeof(int));
            dtProjects.Columns.Add("Name", typeof(string));

            connection.Open();
            cmd.CommandText = "SELECT * FROM Projects";

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Main Page
                    dtProjects.Rows.Add(new string[] { reader["ID"].ToString(), reader["Name"].ToString() });

                    // Manager Page
                    dgvProjectList.Rows.Add(new string[] { reader["ID"].ToString(), reader["Name"].ToString(), reader["RootDirectory"].ToString() });
                }
            }
            connection.Close();
           
            cbxSavedProjects.DisplayMember = "Name";
            cbxSavedProjects.ValueMember = "ID";
            cbxSavedProjects.DataSource = dtProjects;            
        }

        private void btnEditProject_Click_1(object sender, EventArgs e)
        {
            EditProject(Convert.ToInt32(dgvProjectList.Rows[dgvProjectList.SelectedRows[0].Index].Cells[0].Value));
        }

        private void btnDeleteProject_Click_1(object sender, EventArgs e)
        {
            DeleteProject(Convert.ToInt32(dgvProjectList.Rows[dgvProjectList.SelectedRows[0].Index].Cells[0].Value));
        }

        private void dgvProjectList_DoubleClick(object sender, EventArgs e)
        {
            EditProject(Convert.ToInt32(dgvProjectList.Rows[dgvProjectList.SelectedRows[0].Index].Cells[0].Value));
        }

        private void DeleteProject(int pProjectID)
        {
            if (currentlyActiveProjectID != pProjectID)
            {
                if (MessageBox.Show("Are you sure that you want to delete this project?", "Delete Project", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    connection.Open();
                    cmd.CommandText = $"DELETE FROM Projects WHERE ID = {pProjectID}";
                    cmd.ExecuteNonQuery();
                    cmd.CommandText = $"DELETE FROM Log WHERE ProjectID = {pProjectID}";
                    cmd.ExecuteNonQuery();
                    connection.Close();

                    MessageBox.Show("Project Deleted!", "Delete Project", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateProjectLists();
                }
            }
            else MessageBox.Show("You can not delete a Project if it is currently selected!", "Can Not Delete Project", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void EditProject(int pProjectID)
        {
            using (XPSAddProject editForm = new XPSAddProject())
            {
                editForm.EditMode = true;
                connection.Open();
                cmd.CommandText = $"SELECT * FROM Projects WHERE ID = {pProjectID}";
                using (SQLiteDataReader reader = cmd.ExecuteReader())
                { 
                    while (reader.Read())
                    {
                        editForm.ProjectTitle = reader["Name"].ToString();
                        editForm.ProjectDescription = reader["Description"].ToString();
                        editForm.ProjectRoot = reader["RootDirectory"].ToString();
                        editForm.ProjectImage = Convert.ToString(reader["Image"]);

                        editForm.DefOpApache = Convert.ToBoolean(reader["ApacheEnabled"]);
                        editForm.DefOpMySQL = Convert.ToBoolean(reader["MySQLEnabled"]);
                        editForm.DefOpFileZilla = Convert.ToBoolean(reader["FileZillaEnabled"]);
                        editForm.DefOpMercury = Convert.ToBoolean(reader["MercuryEnabled"]);
                        editForm.DefOpTomcat = Convert.ToBoolean(reader["TomcatEnabled"]);
                    }
                }
                connection.Close();

                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    // Update DB
                    connection.Open();
                    cmd.CommandText = $"UPDATE Projects SET Name = '{editForm.ProjectTitle.ToString()}', Description = '{editForm.ProjectDescription.ToString()}', RootDirectory = '{editForm.ProjectRoot.ToString()}', Image = '{Convert.ToString(editForm.ProjectImage)}', " +
                        $"ApacheEnabled = '{editForm.DefOpApache.ToString()}', MySQLEnabled = '{editForm.DefOpMySQL.ToString()}', FileZillaEnabled = '{editForm.DefOpFileZilla.ToString()}', MercuryEnabled = '{editForm.DefOpMercury.ToString()}', TomcatEnabled = '{editForm.DefOpTomcat.ToString()}' " +
                        $"WHERE ID = {pProjectID}";
                    cmd.ExecuteNonQuery();
                    connection.Close();
                    MessageBox.Show("Project Successfully Updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    UpdateProjectLists();
                }

            }
        }

        #endregion

        #region ---------- Import / Export Config ----------

        private void btnExportConfig_Click(object sender, EventArgs e)
        {

        }

        private void btnImportConfig_Click(object sender, EventArgs e)
        {

        }

        #endregion 

        #endregion

        #region ========== Settings Page ==========

        private void btnSelectXamppInstallPath_Click(object sender, EventArgs e)
        {
            if (fbdFolderSelector.ShowDialog() == DialogResult.OK)
            {
                // Check if the path is valid:
                if (!(Directory.Exists(fbdFolderSelector.SelectedPath) && File.Exists(Path.Combine(fbdFolderSelector.SelectedPath, "xampp-control.exe")) && Directory.Exists(Path.Combine(fbdFolderSelector.SelectedPath, "htdocs"))))
                {
                    DialogResult warningDRes = MessageBox.Show(@"Your XAMPP-Installation-Path is not valid!" + Environment.NewLine +
                                        @"The default installation-location is ""C:\xampp""." + Environment.NewLine +
                                        @"The correct folder usually contains the ""xampp-control.exe""." + Environment.NewLine + Environment.NewLine +
                                        @"Do you want to continue with the currently selected folder?", "Wrong XAMPP-Folder", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);

                    if (warningDRes == DialogResult.Yes)
                    {
                        txbXamppInstallPath.Text = fbdFolderSelector.SelectedPath;
                        xamppInstallPath = fbdFolderSelector.SelectedPath;
                        SettingsPoke("XAMPPInstall", fbdFolderSelector.SelectedPath);
                    }
                }
                else
                {
                    txbXamppInstallPath.Text = fbdFolderSelector.SelectedPath;
                    xamppInstallPath = fbdFolderSelector.SelectedPath;
                    SettingsPoke("XAMPPInstall", fbdFolderSelector.SelectedPath);
                }
            }
        }

        private void btnSelectDefaultEditor_Click(object sender, EventArgs e)
        {
            if (ofdFileSelector.ShowDialog() == DialogResult.OK)
            {
                txbDefaultEditorPath.Text = ofdFileSelector.FileName;
                defaultEditor = ofdFileSelector.FileName;
                SettingsPoke("DefaultEditor", ofdFileSelector.FileName);
            }
        }

        private void UpdateAutostartService(object sender)
        {
            if (!disableOnCheckChangeUpdate)
            {
                SettingsPoke("AutostartApache", chbAutostartApache.Checked);
                SettingsPoke("AutostartMySQL", chbAutostartMySQL.Checked);
                SettingsPoke("AutostartFileZille", chbAutostartFileZilla.Checked);
                SettingsPoke("AutostartMercury", chbAutostartMercury.Checked);
                SettingsPoke("AutostartTomcat", chbAutostartTomcat.Checked);
            }
        }

        private void UpdateAutostartAfterSwitch(object sender)
        {
            if (!disableOnCheckChangeUpdate)
            {
                SettingsPoke("AutostartAfterSwitch", rbnAutostartAfterSwitchTrue.Checked);
            }
        }

        #endregion

        private void XPSMain_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                Hide();
                nicNotify.Visible = true;
            }
        }

        private void nicNotify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            nicNotify.Visible = false;
        }

        private void closeXPS3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            allowExit = true;
            if (connection.State == ConnectionState.Open) connection.Close();
            if (bgwServiceMonitor.WorkerSupportsCancellation) bgwServiceMonitor.CancelAsync();
            Application.Exit();
        }

        private void openXPS3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Show();
            this.WindowState = FormWindowState.Normal;
            nicNotify.Visible = false;
        }

        private void startServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (chbServiceApache.Switched) StartServiceRoutine(XPSProcess.Apache);
            if (chbServiceMySQL.Switched) StartServiceRoutine(XPSProcess.MySQL);
            if (chbServiceFileZilla.Switched) StartServiceRoutine(XPSProcess.FileZilla);
            if (chbServiceMercury.Switched) StartServiceRoutine(XPSProcess.Mercury);
            if (chbServiceTomcat.Switched) StartServiceRoutine(XPSProcess.Tomcat);
        }

        private void stopServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StopServiceRoutine(XPSProcess.Apache);
            StopServiceRoutine(XPSProcess.MySQL);
            StopServiceRoutine(XPSProcess.FileZilla);
            StopServiceRoutine(XPSProcess.Mercury);
            StopServiceRoutine(XPSProcess.Tomcat);
        }

        private const int maxStartAttempts = 50;
        private const int continuousSuccesses = 10;

        private int startTriesApache = 0;
        private int startTriesMySQL = 0;
        private int startTriesFileZilla = 0;
        private int startTriesMercury = 0;
        private int startTriesTomcat = 0;

        private int startCSTriesApache = 0;
        private int startCSTriesMySQL = 0;
        private int startCSTriesFileZilla = 0;
        private int startCSTriesMercury = 0;
        private int startCSTriesTomcat = 0;

        private bool startAtmptApache = false;
        private bool startAtmptMySQL = false;
        private bool startAtmptFileZilla = false;
        private bool startAtmptMercury = false;
        private bool startAtmptTomcat = false;

        private int stopTriesApache = 0;
        private int stopTriesMySQL = 0;
        private int stopTriesFileZilla = 0;
        private int stopTriesMercury = 0;
        private int stopTriesTomcat = 0;

        private int stopCSTriesApache = 0;
        private int stopCSTriesMySQL = 0;
        private int stopCSTriesFileZilla = 0;
        private int stopCSTriesMercury = 0;
        private int stopCSTriesTomcat = 0;

        private bool stopAtmptApache = false;
        private bool stopAtmptMySQL = false;
        private bool stopAtmptFileZilla = false;
        private bool stopAtmptMercury = false;
        private bool stopAtmptTomcat = false;

        private void bgwServiceMonitor_DoWork(object sender, DoWorkEventArgs e)
        {
            while(true)
            {
                processes = Process.GetProcesses();

                if (bgwServiceMonitor.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                    StartMonitor(ref startAtmptApache, ref startTriesApache, ref startCSTriesApache, XPSProcess.Apache, pbxApacheStatus, btnStartStopApache);
                    StartMonitor(ref startAtmptMySQL, ref startTriesMySQL, ref startCSTriesMySQL, XPSProcess.MySQL, pbxMySQLStatus, btnStartStopMySQL);
                    StartMonitor(ref startAtmptFileZilla, ref startTriesFileZilla, ref startCSTriesFileZilla, XPSProcess.FileZilla, pbxFileZillaStatus, btnStartStopFileZilla);
                    StartMonitor(ref startAtmptMercury, ref startTriesMercury, ref startCSTriesMercury, XPSProcess.Mercury, pbxMercuryStatus, btnStartStopMercury);
                    StartMonitor(ref startAtmptTomcat, ref startTriesTomcat, ref startCSTriesTomcat, XPSProcess.Tomcat, pbxTomcatStatus, btnStartStopTomcat);

                processes = Process.GetProcesses();

                if (bgwServiceMonitor.CancellationPending)
                {
                    e.Cancel = true;
                    return;
                }

                    StopMonitor(ref stopAtmptApache, ref stopTriesApache, ref stopCSTriesApache, XPSProcess.Apache, pbxApacheStatus, btnStartStopApache);
                    StopMonitor(ref stopAtmptMySQL, ref stopTriesMySQL, ref stopCSTriesMySQL, XPSProcess.MySQL, pbxMySQLStatus, btnStartStopMySQL);
                    StopMonitor(ref stopAtmptFileZilla, ref stopTriesFileZilla, ref stopCSTriesFileZilla, XPSProcess.FileZilla, pbxFileZillaStatus, btnStartStopFileZilla);
                    StopMonitor(ref stopAtmptMercury, ref stopTriesMercury, ref stopCSTriesMercury, XPSProcess.Mercury, pbxMercuryStatus, btnStartStopMercury);
                    StopMonitor(ref stopAtmptTomcat, ref stopTriesTomcat, ref stopCSTriesTomcat, XPSProcess.Tomcat, pbxTomcatStatus, btnStartStopTomcat);

                Thread.Sleep(100);
            }
        }


        private void ShowBalloon(string title, string message, ToolTipIcon icon, int duration)
        {
            nicNotify.BalloonTipTitle = title;
            nicNotify.BalloonTipText = message;
            nicNotify.BalloonTipIcon = icon;
            nicNotify.ShowBalloonTip(duration);
        }

        private void StartMonitor(ref bool startAtmpt, ref int startAttempts, ref int continuousSuccessAttempts, XPSProcess process, PictureBox statusBox, MetroSetButton statusButton)
        {
            if (startAtmpt)
            {
                if (startAttempts < maxStartAttempts)
                {
                    if (IsProcessOpen(process))
                    {
                        startAttempts = 0;
                        continuousSuccessAttempts++;

                        if (continuousSuccessAttempts >= continuousSuccesses)
                        {
                            ShowBalloon("Services started", $"Successfully started {process}.", ToolTipIcon.Info, 100);
                            statusBox.BackColor = Color.Lime;
                            statusBox.Invalidate();
                            statusButton.Text = "Stop";
                            startAtmpt = false;
                            startAttempts = 0;
                            continuousSuccessAttempts = 0;
                        }
                    }
                    else continuousSuccessAttempts = 0;
                    startAttempts++;
                }
                else
                {
                    ShowBalloon("Startup failed", $"{process} could not be started. \r\nReason: Timeout.\r\n\r\nOpen the XAMPP control-panel for more information.", ToolTipIcon.Error, 100);
                    statusBox.BackColor = Color.Red;
                    statusBox.Invalidate();
                    statusButton.Text = "Start";
                    startAtmpt = false;
                    startAttempts = 0;
                }
            }
        }

        private void StopMonitor(ref bool stopAtmpt, ref int stopAttempts, ref int continuousSuccessAttempts, XPSProcess process, PictureBox statusBox, MetroSetButton statusButton)
        {
            if (stopAtmpt)
            {
                if (stopAttempts < maxStartAttempts)
                {
                    if (!IsProcessOpen(process))
                    {
                        stopAttempts = 0;
                        continuousSuccessAttempts++;

                        if (continuousSuccessAttempts >= continuousSuccesses)
                        {
                            ShowBalloon("Services stopped", $"Successfully stopped {process}.", ToolTipIcon.Info, 100);
                            statusBox.BackColor = Color.Red;
                            statusBox.Invalidate();
                            statusButton.Text = "Start";
                            stopAtmpt = false;
                            stopAttempts = 0;
                            continuousSuccessAttempts = 0;
                        }
                    }
                    else continuousSuccessAttempts = 0;
                    stopAttempts++;
                }
                else
                {
                    ShowBalloon("Stop failed", $"{process} could not be stopped. \r\nReason: Timeout.\r\n\r\nOpen the XAMPP control-panel for more information.", ToolTipIcon.Error, 100);
                    statusBox.BackColor = Color.Lime;
                    statusBox.Invalidate();
                    statusButton.Text = "Stop";
                    stopAtmpt = false;
                    stopAttempts = 0;
                }
            }
        }
    }
}
