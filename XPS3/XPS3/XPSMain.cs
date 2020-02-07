using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPS3
{
    public partial class XPSMain : Form
    {
        public XPSMain()
        {
            InitializeComponent();

            pbxLogoApache.Image = Properties.Resources.apache;
            pbxLogoMySQL.Image = Properties.Resources.mysql;
            pbxLogoFileZilla.Image = Properties.Resources.filezilla;
            pbxLogoMercury.Image = Properties.Resources.mercury;
            pbxLogoTomcat.Image = Properties.Resources.tomcat;

        }

        #region ========== MainPage ========== 

        private void btnStartServices_Click(object sender, EventArgs e)
        {

        }

        private void btnStopServices_Click(object sender, EventArgs e)
        {

        }

        private void btnSeletProject_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {

        }

        private void btnHotSwitchP1_Click(object sender, EventArgs e)
        {

        }

        private void btnHotSwitchP2_Click(object sender, EventArgs e)
        {

        }

        private void btnHotSwitchP3_Click(object sender, EventArgs e)
        {

        }

        private void btnHotSwitchP4_Click(object sender, EventArgs e)
        {

        }

        private void btnHotSwitchP5_Click(object sender, EventArgs e)
        {

        }

        private void btnHotSwitchP6_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void pbxSetAA_Paint(object sender, PaintEventArgs e)
            => e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

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

        private void pbxLogoApache_Click(object sender, EventArgs e)
        {

        }

        private void pbxLogoMySQL_Click(object sender, EventArgs e)
        {

        }

        private void pbxLogoFileZilla_Click(object sender, EventArgs e)
        {

        }

        private void pbxLogoMercury_Click(object sender, EventArgs e)
        {

        }

        private void pbxLogoTomcat_Click(object sender, EventArgs e)
        {

        }

        private void btnApacheConfig_Click(object sender, EventArgs e)
        {
            cmsApacheConfig.Show(btnApacheConfig, 32,0);
        }

        private void btnMySQLConfig_Click(object sender, EventArgs e)
        {
            cmsMySQLConfig.Show(btnMySQLConfig, 32, 0);
        }

        private void btnFileZillaConfig_Click(object sender, EventArgs e)
        {
            cmsFileZillaConfig.Show(btnFileZillaConfig, 32, 0);
        }

        private void btnMercuryConfig_Click(object sender, EventArgs e)
        {
            cmsMercuryConfig.Show(btnMercuryConfig, 32, 0);
        }

        private void btnTomcatConfig_Click(object sender, EventArgs e)
        {
            cmsTomcatConfig.Show(btnTomcatConfig, 32, 0);
        }

        private void btnSelectXamppInstallPath_Click(object sender, EventArgs e)
        {
            if(fbdFolderSelector.ShowDialog() == DialogResult.OK)
            {
                txbXamppInstallPath.Text = fbdFolderSelector.SelectedPath;
            }
        }

        private void btnSelectDefaultEditor_Click(object sender, EventArgs e)
        {
            if(ofdFileSelector.ShowDialog() == DialogResult.OK)
            {
                txbDefaultEditorPath.Text = ofdFileSelector.FileName;
            }
        }
    }
}
