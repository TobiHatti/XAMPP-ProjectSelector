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
        private readonly string XPSDataFile = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\XPS3\xpsdat.db";
        private readonly string ConString = $@"URI=file:{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\XPS3\xpsdat.db";
        private SQLiteConnection connection = null;
        private SQLiteCommand cmd = null;

        private string defaultEditor = "notepad.exe";
        private string xamppInstallPath = null;

        private bool disableOnCheckChangeUpdate = true;

        private volatile Process[] processes;
        private Thread processThread = null;

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
            InitializeComponent();

            processThread = new Thread(UpdateProcessThreads);
            processThread.Start();

            disableOnCheckChangeUpdate = true;
            SetServiceImages();
            CreateDBCon();
            LoadDBDataToForm();
            disableOnCheckChangeUpdate = false;
        }

        private void XPSMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (connection.State == ConnectionState.Open) connection.Close();
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
                cmd.CommandText = @"CREATE TABLE ""Settings"" (""ID"" INTEGER PRIMARY KEY AUTOINCREMENT, ""Key"" TEXT UNIQUE, ""Value"" TEXT);";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE ""Log"" (""ID"" INTEGER PRIMARY KEY AUTOINCREMENT, ""ProjectID"" INTEGER, ""SelectedDate"" TEXT)";
                cmd.ExecuteNonQuery();
                cmd.CommandText = @"CREATE TABLE ""Projects"" (""ID"" INTEGER PRIMARY KEY AUTOINCREMENT, ""Name""  TEXT, ""Description""   TEXT, ""RootDirectory"" TEXT, ""Image"" BLOB);";
                cmd.ExecuteNonQuery();
            }

            connection.Close();
        }

        private void SettingsPoke(string pKey, object pValue)
        {
            connection.Open();
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
            connection.Close();
        }

        private object SettingsPeek(string pKey, object pDefaultValue = null)
        {
            connection.Open();
            cmd.CommandText = $@"SELECT Value FROM Settings WHERE Key = ""{pKey}""";
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

        private void btnStartServices_Click(object sender, EventArgs e)
        {
            if (chbServiceApache.Switched) AttemptStartService("Apache", "apache_start.bat", XPSProcess.Apache);
            if (chbServiceMySQL.Switched) AttemptStartService("MySQL", "mysql_start.bat", XPSProcess.MySQL);
            if (chbServiceFileZilla.Switched) AttemptStartService("FileZilla", "filezilla_start.bat", XPSProcess.FileZilla);
            if (chbServiceMercury.Switched) AttemptStartService("Mercury", "mercury_start.bat", XPSProcess.Mercury);
            if (chbServiceTomcat.Switched) AttemptStartService("Tomcat", "tomcat_start.bat", XPSProcess.Tomcat);
        }

        private void btnStopServices_Click(object sender, EventArgs e)
        {
            AttemptStartService("Apache", "apache_stop.bat", XPSProcess.Apache, true);
            AttemptStartService("MySQL", "mysql_stop.bat", XPSProcess.MySQL, true);
            AttemptStartService("FileZilla", "filezilla_stop.bat", XPSProcess.FileZilla, true);
            AttemptStartService("Mercury", "mercury_stop.bat", XPSProcess.Mercury, true);
            AttemptStartService("Tomcat", "tomcat_stop.bat", XPSProcess.Tomcat, true);
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

       private void UpdateProcessThreads()
        {
            while(true)
            {
                processes = Process.GetProcesses();
                Thread.Sleep(1000);
            }
        }

        private void tmrCheckServiceStatus_Tick(object sender, EventArgs e)
        {
            pbxApacheStatus.BackColor = IsProcessOpen(XPSProcess.Apache) ? Color.Lime : Color.Red;
            pbxMySQLStatus.BackColor = IsProcessOpen(XPSProcess.MySQL) ? Color.Lime : Color.Red;
            pbxFileZillaStatus.BackColor = IsProcessOpen(XPSProcess.FileZilla) ? Color.Lime : Color.Red;
            pbxMercuryStatus.BackColor = IsProcessOpen(XPSProcess.Mercury) ? Color.Lime : Color.Red;
            pbxTomcatStatus.BackColor = IsProcessOpen(XPSProcess.Tomcat) ? Color.Lime : Color.Red;

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
            if (!disableOnCheckChangeUpdate)
            {
                SettingsPoke("ServiceStatusApache", chbServiceApache.Switched);
                SettingsPoke("ServiceStatusMySQL", chbServiceMySQL.Switched);
                SettingsPoke("ServiceStatusFileZilla", chbServiceFileZilla.Switched);
                SettingsPoke("ServiceStatusMercury", chbServiceMercury.Switched);
                SettingsPoke("ServiceStatusTomcat", chbServiceTomcat.Switched);
            }
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

        #endregion

        
    }
}
