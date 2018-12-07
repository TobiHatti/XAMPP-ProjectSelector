using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XAMPP_Project_Switcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txbXAMPPDirectory.Text = Properties.Settings.Default.xamppPath;
            ReloadProjectList();
        }

        private void btnSelectXAMPPDirectory_Click(object sender, EventArgs e)
        {
            DialogResult result = fbdFolderBrowser.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbdFolderBrowser.SelectedPath))
            {
                Properties.Settings.Default.xamppPath = fbdFolderBrowser.SelectedPath;
                Properties.Settings.Default.Save();

                txbXAMPPDirectory.Text = Properties.Settings.Default.xamppPath;

                
            }
        }

        private void btnNewEntry_Click(object sender, EventArgs e)
        {
            AddProjectEntry addPE = new AddProjectEntry();
            addPE.ShowDialog();

            Properties.Settings.Default.Projects += Properties.Settings.Default.NewProjectName + "|||" + Properties.Settings.Default.NewProjectFolder + "#!!#";
            Properties.Settings.Default.NewProjectFolder = "";
            Properties.Settings.Default.NewProjectName = "";
            Properties.Settings.Default.Save();

            ReloadProjectList();
        }

        private void ReloadProjectList()
        {
            cbxEntries.DataSource = null;

            DataTable dt = new DataTable();
            dt.Columns.Add("DisplayName");
            dt.Columns.Add("FolderName");


            string[] projects = Properties.Settings.Default.Projects.Split(new string[] { "#!!#" }, StringSplitOptions.None);

            foreach(string projectParts in projects)
            {
                DataRow dr = dt.NewRow();
                string[] projectSingles = projectParts.Split(new string[] { "|||" }, StringSplitOptions.None);
                if (projectSingles.Length == 2)
                {
                    dr["DisplayName"] = projectSingles[0];
                    dr["FolderName"] = projectSingles[1];
                    dt.Rows.Add(dr);
                }
            }

            cbxEntries.Items.Clear();
            cbxEntries.ValueMember = "FolderName";
            cbxEntries.DisplayMember = "DisplayName";
            cbxEntries.DataSource = dt;
        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {
            string projectName = cbxEntries.GetItemText(cbxEntries.SelectedItem);
            string projectFolder = cbxEntries.SelectedValue.ToString();

            Properties.Settings.Default.Projects = Properties.Settings.Default.Projects.Replace(projectName + "|||" + projectFolder + "#!!#","");
            Properties.Settings.Default.Save();

            ReloadProjectList();
        }

        private void btnSetProject_Click(object sender, EventArgs e)
        {
            string httpdConfPath = Properties.Settings.Default.xamppPath + @"\apache\conf\httpd.conf";
            string projectPath = Properties.Settings.Default.xamppPath + @"\htdocs\" + cbxEntries.SelectedValue.ToString();
            string line;

            StreamReader sr = new StreamReader(httpdConfPath);
            StreamWriter sw = new StreamWriter(httpdConfPath + "temp");

            while((line = sr.ReadLine())!=null)
            {
                if(line.StartsWith("DocumentRoot"))
                {
                    sw.WriteLine("DocumentRoot \"{0}\"", projectPath.Replace('\\','/'));
                    sw.WriteLine("<Directory \"{0}\">", projectPath.Replace('\\', '/'));
                    sr.ReadLine();
                }
                else sw.WriteLine(line);
            }

            sw.Close();
            sr.Close();

            File.Delete(httpdConfPath);
            File.Move(httpdConfPath+"temp", httpdConfPath);

            MessageBox.Show("Project selection successful!\r\n\r\nPlease restart Apache in the XAMPP Controll Panel.","Success",MessageBoxButtons.OK);
        }
    }
}
