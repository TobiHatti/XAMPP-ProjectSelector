using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XPS3
{
    public partial class XPSMain : Form
    {
        private readonly string XPSDataFile =   $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\XPS3\xpsdat.db";
        private readonly string ConString =     $@"URI=file:{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\XPS3\xpsdat.db";
        private SQLiteConnection connection = null;
        private SQLiteCommand cmd = null;

        public XPSMain()
        {
            InitializeComponent();

            SetServiceImages();
            CreateDBCon();
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
            if(!fileExitst)
            {
                cmd.CommandText = @"CREATE TABLE ""Settings"" (""ID"" INTEGER PRIMARY KEY AUTOINCREMENT, ""Key"" TEXT UNIQUE, ""Value"" TEXT);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE ""Log"" (""ID"" INTEGER PRIMARY KEY AUTOINCREMENT, ""ProjectID"" INTEGER, ""SelectedDate"" TEXT)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE ""Projects"" (""ID"" INTEGER PRIMARY KEY AUTOINCREMENT, ""Name""  TEXT, ""Description""   TEXT, ""RootDirectory"" TEXT, ""Image"" BLOB);";
                cmd.ExecuteNonQuery();
            }
        }

        private void SettingsPoke(string pKey, object pValue)
        {
            cmd.CommandText = $@"SELECT COUNT(*) FROM Settings WHERE Key = ""{pKey}"""; ;
            if (Convert.ToInt32(cmd.ExecuteScalar()) == 0)
            {
                // New entry
                cmd.CommandText = $@"INSERT INTO Settings (Key, Value) VALUES (""{pKey}"", ""{pValue}"")";
                cmd.ExecuteNonQuery();
            }
            else
            {
                // Update entry
                cmd.CommandText = $@"UPDATE Settings SET Value = ""{pValue}"" WHERE Key = ""{pKey}""";
                cmd.ExecuteNonQuery();
            }
        }

        private object SettingsPeek(string pKey)
        {
            cmd.CommandText = $@"SELECT Value FROM Settings WHERE Key = ""{pKey}""";
            return cmd.ExecuteScalar();
        }

        private void XPSMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            connection.Close();
        }

        #region ========== Main Page ========== 

        #region ---------- Start / Stop Services ----------

        private void btnStartServices_Click(object sender, EventArgs e)
        {

        }

        private void btnStopServices_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region ---------- Edit / Select / Delete Projects ----------

        private void btnSeletProject_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProject_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteProject_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region ---------- HotSwap Projects ----------

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
            
        }

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

        #endregion

        #region ---------- Open Contect-Menu ----------

        private void btnApacheConfig_Click(object sender, EventArgs e) => cmsApacheConfig.Show(btnApacheConfig, 32,0);
        private void btnMySQLConfig_Click(object sender, EventArgs e) => cmsMySQLConfig.Show(btnMySQLConfig, 32, 0);
        private void btnFileZillaConfig_Click(object sender, EventArgs e) => cmsFileZillaConfig.Show(btnFileZillaConfig, 32, 0);
        private void btnMercuryConfig_Click(object sender, EventArgs e) => cmsMercuryConfig.Show(btnMercuryConfig, 32, 0);
        private void btnTomcatConfig_Click(object sender, EventArgs e) => cmsTomcatConfig.Show(btnTomcatConfig, 32, 0);

        #endregion

        #region ---------- Context-Menu Options ----------

        private void tsmApacheConfig_Click(object sender, EventArgs e)
        {

        }

        private void tsmApacheSSLConfig_Click(object sender, EventArgs e)
        {

        }

        private void tslApacheXamppConfig_Click(object sender, EventArgs e)
        {

        }

        private void tslPhpConfig_Click(object sender, EventArgs e)
        {

        }

        private void tslPhpMyAdminConfig_Click(object sender, EventArgs e)
        {

        }

        private void tslBrowseApache_Click(object sender, EventArgs e)
        {

        }

        private void tslBrowsePhp_Click(object sender, EventArgs e)
        {

        }

        private void tslBrowsePhpMyAdmin_Click(object sender, EventArgs e)
        {

        }

        private void tslTomcatConfig_Click(object sender, EventArgs e)
        {

        }

        private void tslTomcatUsers_Click(object sender, EventArgs e)
        {

        }

        private void tslTomcatWeb_Click(object sender, EventArgs e)
        {

        }

        private void tslTomcatContext_Click(object sender, EventArgs e)
        {

        }

        private void tslBrowseTomcat_Click(object sender, EventArgs e)
        {

        }

        private void tslMercuryConfig_Click(object sender, EventArgs e)
        {

        }

        private void tslBrowseMercury_Click(object sender, EventArgs e)
        {

        }

        private void tslMySQLConfig_Click(object sender, EventArgs e)
        {

        }

        private void tslBrowseMySQL_Click(object sender, EventArgs e)
        {

        }

        private void tslFileZillaConfig_Click(object sender, EventArgs e)
        {

        }

        private void tslBrowseFileZilla_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #endregion

        #region ========== Manage Page ==========

        #region ---------- Add / Edit / Delete Projects ----------

        private void btnAddNewProject_Click(object sender, EventArgs e)
        {

        }

        private void btnEditProject_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDeleteProject_Click_1(object sender, EventArgs e)
        {

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
                txbXamppInstallPath.Text = fbdFolderSelector.SelectedPath;
            }
        }

        private void btnSelectDefaultEditor_Click(object sender, EventArgs e)
        {
            if (ofdFileSelector.ShowDialog() == DialogResult.OK)
            {
                txbDefaultEditorPath.Text = ofdFileSelector.FileName;
            }
        }

        private void UpdateAutostartService(object sender)
        {

        }



        #endregion
    }
}
