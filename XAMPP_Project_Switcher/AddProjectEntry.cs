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

            this.Close();
        }

        private void btnSelectProjectFolder_Click(object sender, EventArgs e)
        {
            DialogResult result = fdbFolderBrowser.ShowDialog();

            if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fdbFolderBrowser.SelectedPath))
            {
                folderName = fdbFolderBrowser.SelectedPath.Split('\\').Last();
                txbProjectFolder.Text = folderName;
            }
        }
    }
}
