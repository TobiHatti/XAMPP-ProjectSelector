using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XAMPP_Project_Switcher
{
    public partial class AddProjectEntry : Form
    {
        public AddProjectEntry()
        {
            InitializeComponent();
        }

        private string folderName;

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.NewProjectName = txbProjectName.Text;
            Properties.Settings.Default.NewProjectFolder = txbProjectFolder.Text;

            if (Properties.Settings.Default.NewProjectName != "" && Properties.Settings.Default.NewProjectFolder != "")
            {
                this.Close();
            }
            else MessageBox.Show("Please fill out all fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void btnSelectProjectFolder_Click(object sender, EventArgs e)
        {
            fdbFolderBrowser.SelectedPath = Properties.Settings.Default.xamppPath + @"\htdocs\";
            DialogResult result = fdbFolderBrowser.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fdbFolderBrowser.SelectedPath))
            {
                folderName = fdbFolderBrowser.SelectedPath.Split('\\').Last();
                txbProjectFolder.Text = folderName;
            }
        }
    }
}
