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

namespace XPS3
{
    public partial class XPSAddProject : Form
    {
        public string ProjectTitle { get; set; } = null;
        public string ProjectDescription { get; set; } = null;
        public string ProjectRoot { get; set; } = null;
        public string ProjectImage { get; set; } = null;

        public bool DefOpApache { get; set; } = false;
        public bool DefOpMySQL { get; set; } = false;
        public bool DefOpFileZilla { get; set; } = false;
        public bool DefOpMercury { get; set; } = false;
        public bool DefOpTomcat { get; set; } = false;


        public XPSAddProject()
        {
            InitializeComponent();
        }

        private void btnBrowseRootFolder_Click(object sender, EventArgs e)
        {
            if(fbdProjectRoot.ShowDialog() == DialogResult.OK)
                txtProjectRoot.Text = fbdProjectRoot.SelectedPath;
        }

        private void btnBrowseThumbnail_Click(object sender, EventArgs e)
        {
            if (ofdOpenThumbnail.ShowDialog() == DialogResult.OK)
            {
                pbxThumbnailPreview.Image = Image.FromFile(ofdOpenThumbnail.FileName);

                using (Image image = Image.FromFile(ofdOpenThumbnail.FileName))
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        image.Save(ms, image.RawFormat);
                        ProjectImage = Convert.ToBase64String(ms.ToArray());
                    }
                }
            }
                
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure that you want to cancel?", "Cancel", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            ProjectTitle = txtProjectTitle.Text;
            ProjectDescription = rtbProjectDescription.Text;
            ProjectRoot = txtProjectRoot.Text;

            DefOpApache = chbDefOpApache.Switched;
            DefOpMySQL = chbDefOpMySQL.Switched;
            DefOpFileZilla = chbDefOpFileZilla.Switched;
            DefOpMercury = chbDefOpMercury.Switched;
            DefOpTomcat = chbDefOpTomcat.Switched;

            if (string.IsNullOrEmpty(ProjectTitle)) MessageBox.Show("Please enter a Name for your Project!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (string.IsNullOrEmpty(ProjectRoot)) MessageBox.Show("Please select the Root-Folder of your project", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
