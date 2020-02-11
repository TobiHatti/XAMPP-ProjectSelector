namespace XPS3
{
    partial class XPSMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XPSMain));
            this.tctTabMenu = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabProjects = new MetroSet_UI.Child.MetroSetTabPage();
            this.btnHotSwitchP6 = new MetroSet_UI.Controls.MetroSetTile();
            this.btnHotSwitchP5 = new MetroSet_UI.Controls.MetroSetTile();
            this.btnHotSwitchP4 = new MetroSet_UI.Controls.MetroSetTile();
            this.btnHotSwitchP1 = new MetroSet_UI.Controls.MetroSetTile();
            this.btnHotSwitchP3 = new MetroSet_UI.Controls.MetroSetTile();
            this.metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            this.btnHotSwitchP2 = new MetroSet_UI.Controls.MetroSetTile();
            this.lblSelectedProject = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.cbxSavedProjects = new MetroSet_UI.Controls.MetroSetComboBox();
            this.btnEditSelectedProject = new MetroSet_UI.Controls.MetroSetTile();
            this.btnDeleteSelectedProject = new MetroSet_UI.Controls.MetroSetTile();
            this.btnSeletProject = new MetroSet_UI.Controls.MetroSetTile();
            this.tabServices = new MetroSet_UI.Child.MetroSetTabPage();
            this.btnStartStopTomcat = new MetroSet_UI.Controls.MetroSetButton();
            this.btnStartStopMercury = new MetroSet_UI.Controls.MetroSetButton();
            this.btnStartStopFileZilla = new MetroSet_UI.Controls.MetroSetButton();
            this.btnStartStopMySQL = new MetroSet_UI.Controls.MetroSetButton();
            this.btnStartStopApache = new MetroSet_UI.Controls.MetroSetButton();
            this.pbxTomcatStatus = new System.Windows.Forms.PictureBox();
            this.pbxMercuryStatus = new System.Windows.Forms.PictureBox();
            this.pbxFileZillaStatus = new System.Windows.Forms.PictureBox();
            this.pbxMySQLStatus = new System.Windows.Forms.PictureBox();
            this.pbxApacheStatus = new System.Windows.Forms.PictureBox();
            this.btnTomcatConfig = new MetroSet_UI.Controls.MetroDefaultSetButton();
            this.btnMercuryConfig = new MetroSet_UI.Controls.MetroDefaultSetButton();
            this.btnFileZillaConfig = new MetroSet_UI.Controls.MetroDefaultSetButton();
            this.btnMySQLConfig = new MetroSet_UI.Controls.MetroDefaultSetButton();
            this.btnApacheConfig = new MetroSet_UI.Controls.MetroDefaultSetButton();
            this.btnDisableAllServices = new MetroSet_UI.Controls.MetroSetTile();
            this.btnEnableAllServices = new MetroSet_UI.Controls.MetroSetTile();
            this.pbxLogoTomcat = new System.Windows.Forms.PictureBox();
            this.pbxLogoMercury = new System.Windows.Forms.PictureBox();
            this.pbxLogoFileZilla = new System.Windows.Forms.PictureBox();
            this.pbxLogoMySQL = new System.Windows.Forms.PictureBox();
            this.pbxLogoApache = new System.Windows.Forms.PictureBox();
            this.metroSetDivider5 = new MetroSet_UI.Controls.MetroSetDivider();
            this.metroSetLabel10 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel9 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.chbServiceTomcat = new MetroSet_UI.Controls.MetroSetSwitch();
            this.chbServiceFileZilla = new MetroSet_UI.Controls.MetroSetSwitch();
            this.chbServiceMercury = new MetroSet_UI.Controls.MetroSetSwitch();
            this.chbServiceMySQL = new MetroSet_UI.Controls.MetroSetSwitch();
            this.chbServiceApache = new MetroSet_UI.Controls.MetroSetSwitch();
            this.metroSetLabel4 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            this.tabManager = new MetroSet_UI.Child.MetroSetTabPage();
            this.btnEditProject = new MetroSet_UI.Controls.MetroSetButton();
            this.btnDeleteProject = new MetroSet_UI.Controls.MetroSetButton();
            this.btnImportConfig = new MetroSet_UI.Controls.MetroSetButton();
            this.btnExportConfig = new MetroSet_UI.Controls.MetroSetButton();
            this.btnAddNewProject = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetDivider9 = new MetroSet_UI.Controls.MetroSetDivider();
            this.metroSetDivider3 = new MetroSet_UI.Controls.MetroSetDivider();
            this.tabSettings = new MetroSet_UI.Child.MetroSetTabPage();
            this.metroSetLabel19 = new MetroSet_UI.Controls.MetroSetLabel();
            this.chbAutostartTomcat = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.chbAutostartMercury = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.chbAutostartFileZilla = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.chbAutostartMySQL = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.chbAutostartApache = new MetroSet_UI.Controls.MetroSetCheckBox();
            this.btnSelectDefaultEditor = new MetroSet_UI.Controls.MetroSetButton();
            this.btnSelectXamppInstallPath = new MetroSet_UI.Controls.MetroSetButton();
            this.txbDefaultEditorPath = new MetroSet_UI.Controls.MetroSetTextBox();
            this.txbXamppInstallPath = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel18 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel17 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel16 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetDivider8 = new MetroSet_UI.Controls.MetroSetDivider();
            this.metroSetDivider7 = new MetroSet_UI.Controls.MetroSetDivider();
            this.metroSetDivider6 = new MetroSet_UI.Controls.MetroSetDivider();
            this.metroSetDivider4 = new MetroSet_UI.Controls.MetroSetDivider();
            this.btnStopServices = new MetroSet_UI.Controls.MetroSetTile();
            this.btnStartServices = new MetroSet_UI.Controls.MetroSetTile();
            this.btnStartServicesColor = new MetroSet_UI.Controls.MetroSetTile();
            this.btnStopServicesColor = new MetroSet_UI.Controls.MetroSetTile();
            this.cmsApacheConfig = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            this.tsmApacheConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmApacheSSLConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tslApacheXamppConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tslPhpConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tslPhpMyAdminConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tslBrowseApache = new System.Windows.Forms.ToolStripMenuItem();
            this.tslBrowsePhp = new System.Windows.Forms.ToolStripMenuItem();
            this.tslBrowsePhpMyAdmin = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tslLogApacheAccess = new System.Windows.Forms.ToolStripMenuItem();
            this.tslLogApacheError = new System.Windows.Forms.ToolStripMenuItem();
            this.tslLogPhpError = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.tslLogBrowseApache = new System.Windows.Forms.ToolStripMenuItem();
            this.tslLogBrowsePHP = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMySQLConfig = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            this.tslMySQLConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tslBrowseMySQL = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tslLogMysqlError = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.tslLogBrowseMySQL = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsFileZillaConfig = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            this.tslFileZillaConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tslBrowseFileZilla = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsMercuryConfig = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            this.tslMercuryConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tslBrowseMercury = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.logsToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tslLogBrowseMercury = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsTomcatConfig = new MetroSet_UI.Controls.MetroSetContextMenuStrip();
            this.tslTomcatConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.tslTomcatUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.tslTomcatWeb = new System.Windows.Forms.ToolStripMenuItem();
            this.tslTomcatContext = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tslBrowseTomcat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.logsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tslLogBrowseTomcat = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdFileSelector = new System.Windows.Forms.OpenFileDialog();
            this.fbdFolderSelector = new System.Windows.Forms.FolderBrowserDialog();
            this.tmrCheckServiceStatus = new System.Windows.Forms.Timer(this.components);
            this.lbcProjectList = new MetroSet_UI.Controls.MetroSetListBox();
            this.tctTabMenu.SuspendLayout();
            this.tabProjects.SuspendLayout();
            this.tabServices.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxTomcatStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMercuryStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFileZillaStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMySQLStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxApacheStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoTomcat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoMercury)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoFileZilla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoMySQL)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoApache)).BeginInit();
            this.tabManager.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.cmsApacheConfig.SuspendLayout();
            this.cmsMySQLConfig.SuspendLayout();
            this.cmsFileZillaConfig.SuspendLayout();
            this.cmsMercuryConfig.SuspendLayout();
            this.cmsTomcatConfig.SuspendLayout();
            this.SuspendLayout();
            // 
            // tctTabMenu
            // 
            this.tctTabMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tctTabMenu.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.tctTabMenu.AnimateTime = 400;
            this.tctTabMenu.Controls.Add(this.tabProjects);
            this.tctTabMenu.Controls.Add(this.tabServices);
            this.tctTabMenu.Controls.Add(this.tabManager);
            this.tctTabMenu.Controls.Add(this.tabSettings);
            this.tctTabMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tctTabMenu.ItemSize = new System.Drawing.Size(100, 38);
            this.tctTabMenu.Location = new System.Drawing.Point(12, 12);
            this.tctTabMenu.Name = "tctTabMenu";
            this.tctTabMenu.SelectedIndex = 2;
            this.tctTabMenu.Size = new System.Drawing.Size(315, 393);
            this.tctTabMenu.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tctTabMenu.Speed = 20;
            this.tctTabMenu.Style = MetroSet_UI.Design.Style.Light;
            this.tctTabMenu.StyleManager = null;
            this.tctTabMenu.TabIndex = 2;
            this.tctTabMenu.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.tctTabMenu.ThemeAuthor = "Narwin";
            this.tctTabMenu.ThemeName = "MetroLite";
            this.tctTabMenu.UseAnimation = true;
            // 
            // tabProjects
            // 
            this.tabProjects.BaseColor = System.Drawing.Color.White;
            this.tabProjects.Controls.Add(this.btnHotSwitchP6);
            this.tabProjects.Controls.Add(this.btnHotSwitchP5);
            this.tabProjects.Controls.Add(this.btnHotSwitchP4);
            this.tabProjects.Controls.Add(this.btnHotSwitchP1);
            this.tabProjects.Controls.Add(this.btnHotSwitchP3);
            this.tabProjects.Controls.Add(this.metroSetDivider1);
            this.tabProjects.Controls.Add(this.btnHotSwitchP2);
            this.tabProjects.Controls.Add(this.lblSelectedProject);
            this.tabProjects.Controls.Add(this.metroSetLabel3);
            this.tabProjects.Controls.Add(this.metroSetLabel1);
            this.tabProjects.Controls.Add(this.cbxSavedProjects);
            this.tabProjects.Controls.Add(this.btnEditSelectedProject);
            this.tabProjects.Controls.Add(this.btnDeleteSelectedProject);
            this.tabProjects.Controls.Add(this.btnSeletProject);
            this.tabProjects.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabProjects.ImageIndex = 0;
            this.tabProjects.ImageKey = null;
            this.tabProjects.Location = new System.Drawing.Point(4, 42);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Size = new System.Drawing.Size(307, 347);
            this.tabProjects.Style = MetroSet_UI.Design.Style.Light;
            this.tabProjects.StyleManager = null;
            this.tabProjects.TabIndex = 0;
            this.tabProjects.Text = "Projects";
            this.tabProjects.ThemeAuthor = "Narwin";
            this.tabProjects.ThemeName = "MetroLite";
            this.tabProjects.ToolTipText = null;
            // 
            // btnHotSwitchP6
            // 
            this.btnHotSwitchP6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotSwitchP6.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnHotSwitchP6.DisabledBorderColor = System.Drawing.Color.Gray;
            this.btnHotSwitchP6.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHotSwitchP6.Enabled = false;
            this.btnHotSwitchP6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHotSwitchP6.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnHotSwitchP6.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnHotSwitchP6.HoverTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP6.Location = new System.Drawing.Point(166, 174);
            this.btnHotSwitchP6.Name = "btnHotSwitchP6";
            this.btnHotSwitchP6.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnHotSwitchP6.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnHotSwitchP6.NormalTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP6.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnHotSwitchP6.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnHotSwitchP6.PressTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP6.Size = new System.Drawing.Size(141, 31);
            this.btnHotSwitchP6.Style = MetroSet_UI.Design.Style.Custom;
            this.btnHotSwitchP6.StyleManager = null;
            this.btnHotSwitchP6.TabIndex = 9;
            this.btnHotSwitchP6.Text = "Recent 6";
            this.btnHotSwitchP6.ThemeAuthor = "Narwin";
            this.btnHotSwitchP6.ThemeName = "MetroDark";
            this.btnHotSwitchP6.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.btnHotSwitchP6.Click += new System.EventHandler(this.btnHotSwitchP6_Click);
            // 
            // btnHotSwitchP5
            // 
            this.btnHotSwitchP5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotSwitchP5.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnHotSwitchP5.DisabledBorderColor = System.Drawing.Color.Gray;
            this.btnHotSwitchP5.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHotSwitchP5.Enabled = false;
            this.btnHotSwitchP5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHotSwitchP5.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnHotSwitchP5.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnHotSwitchP5.HoverTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP5.Location = new System.Drawing.Point(0, 174);
            this.btnHotSwitchP5.Name = "btnHotSwitchP5";
            this.btnHotSwitchP5.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnHotSwitchP5.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnHotSwitchP5.NormalTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP5.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnHotSwitchP5.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnHotSwitchP5.PressTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP5.Size = new System.Drawing.Size(160, 31);
            this.btnHotSwitchP5.Style = MetroSet_UI.Design.Style.Custom;
            this.btnHotSwitchP5.StyleManager = null;
            this.btnHotSwitchP5.TabIndex = 9;
            this.btnHotSwitchP5.Text = "Recent 5";
            this.btnHotSwitchP5.ThemeAuthor = "Narwin";
            this.btnHotSwitchP5.ThemeName = "MetroDark";
            this.btnHotSwitchP5.TileAlign = MetroSet_UI.Enums.TileAlign.TopRight;
            this.btnHotSwitchP5.Click += new System.EventHandler(this.btnHotSwitchP5_Click);
            // 
            // btnHotSwitchP4
            // 
            this.btnHotSwitchP4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotSwitchP4.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnHotSwitchP4.DisabledBorderColor = System.Drawing.Color.Gray;
            this.btnHotSwitchP4.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHotSwitchP4.Enabled = false;
            this.btnHotSwitchP4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHotSwitchP4.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnHotSwitchP4.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnHotSwitchP4.HoverTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP4.Location = new System.Drawing.Point(132, 132);
            this.btnHotSwitchP4.Name = "btnHotSwitchP4";
            this.btnHotSwitchP4.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnHotSwitchP4.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnHotSwitchP4.NormalTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP4.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnHotSwitchP4.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnHotSwitchP4.PressTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP4.Size = new System.Drawing.Size(175, 36);
            this.btnHotSwitchP4.Style = MetroSet_UI.Design.Style.Custom;
            this.btnHotSwitchP4.StyleManager = null;
            this.btnHotSwitchP4.TabIndex = 8;
            this.btnHotSwitchP4.Text = "Recent 4";
            this.btnHotSwitchP4.ThemeAuthor = "Narwin";
            this.btnHotSwitchP4.ThemeName = "MetroDark";
            this.btnHotSwitchP4.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.btnHotSwitchP4.Click += new System.EventHandler(this.btnHotSwitchP4_Click);
            // 
            // btnHotSwitchP1
            // 
            this.btnHotSwitchP1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotSwitchP1.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnHotSwitchP1.DisabledBorderColor = System.Drawing.Color.Gray;
            this.btnHotSwitchP1.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHotSwitchP1.Enabled = false;
            this.btnHotSwitchP1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHotSwitchP1.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnHotSwitchP1.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnHotSwitchP1.HoverTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP1.Location = new System.Drawing.Point(0, 64);
            this.btnHotSwitchP1.Name = "btnHotSwitchP1";
            this.btnHotSwitchP1.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnHotSwitchP1.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnHotSwitchP1.NormalTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP1.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnHotSwitchP1.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnHotSwitchP1.PressTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP1.Size = new System.Drawing.Size(126, 34);
            this.btnHotSwitchP1.Style = MetroSet_UI.Design.Style.Custom;
            this.btnHotSwitchP1.StyleManager = null;
            this.btnHotSwitchP1.TabIndex = 7;
            this.btnHotSwitchP1.Text = "Recent 1";
            this.btnHotSwitchP1.ThemeAuthor = "Narwin";
            this.btnHotSwitchP1.ThemeName = "MetroDark";
            this.btnHotSwitchP1.TileAlign = MetroSet_UI.Enums.TileAlign.TopRight;
            this.btnHotSwitchP1.Click += new System.EventHandler(this.btnHotSwitchP1_Click);
            // 
            // btnHotSwitchP3
            // 
            this.btnHotSwitchP3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotSwitchP3.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnHotSwitchP3.DisabledBorderColor = System.Drawing.Color.Gray;
            this.btnHotSwitchP3.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHotSwitchP3.Enabled = false;
            this.btnHotSwitchP3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHotSwitchP3.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnHotSwitchP3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnHotSwitchP3.HoverTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP3.Location = new System.Drawing.Point(132, 64);
            this.btnHotSwitchP3.Name = "btnHotSwitchP3";
            this.btnHotSwitchP3.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnHotSwitchP3.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnHotSwitchP3.NormalTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP3.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnHotSwitchP3.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnHotSwitchP3.PressTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP3.Size = new System.Drawing.Size(175, 61);
            this.btnHotSwitchP3.Style = MetroSet_UI.Design.Style.Custom;
            this.btnHotSwitchP3.StyleManager = null;
            this.btnHotSwitchP3.TabIndex = 6;
            this.btnHotSwitchP3.Text = "Recent 3";
            this.btnHotSwitchP3.ThemeAuthor = "Narwin";
            this.btnHotSwitchP3.ThemeName = "MetroDark";
            this.btnHotSwitchP3.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.btnHotSwitchP3.Click += new System.EventHandler(this.btnHotSwitchP3_Click);
            // 
            // metroSetDivider1
            // 
            this.metroSetDivider1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetDivider1.Location = new System.Drawing.Point(0, 31);
            this.metroSetDivider1.Name = "metroSetDivider1";
            this.metroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider1.Size = new System.Drawing.Size(311, 4);
            this.metroSetDivider1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetDivider1.StyleManager = null;
            this.metroSetDivider1.TabIndex = 5;
            this.metroSetDivider1.Text = "metroSetDivider1";
            this.metroSetDivider1.ThemeAuthor = "Narwin";
            this.metroSetDivider1.ThemeName = "MetroDark";
            this.metroSetDivider1.Thickness = 1;
            // 
            // btnHotSwitchP2
            // 
            this.btnHotSwitchP2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotSwitchP2.DisabledBackColor = System.Drawing.Color.Gray;
            this.btnHotSwitchP2.DisabledBorderColor = System.Drawing.Color.Gray;
            this.btnHotSwitchP2.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnHotSwitchP2.Enabled = false;
            this.btnHotSwitchP2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnHotSwitchP2.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnHotSwitchP2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnHotSwitchP2.HoverTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP2.Location = new System.Drawing.Point(0, 104);
            this.btnHotSwitchP2.Name = "btnHotSwitchP2";
            this.btnHotSwitchP2.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnHotSwitchP2.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnHotSwitchP2.NormalTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP2.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnHotSwitchP2.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnHotSwitchP2.PressTextColor = System.Drawing.Color.White;
            this.btnHotSwitchP2.Size = new System.Drawing.Size(126, 64);
            this.btnHotSwitchP2.Style = MetroSet_UI.Design.Style.Custom;
            this.btnHotSwitchP2.StyleManager = null;
            this.btnHotSwitchP2.TabIndex = 4;
            this.btnHotSwitchP2.Text = "Recent 2";
            this.btnHotSwitchP2.ThemeAuthor = "Narwin";
            this.btnHotSwitchP2.ThemeName = "MetroDark";
            this.btnHotSwitchP2.TileAlign = MetroSet_UI.Enums.TileAlign.TopRight;
            this.btnHotSwitchP2.Click += new System.EventHandler(this.btnHotSwitchP2_Click);
            // 
            // lblSelectedProject
            // 
            this.lblSelectedProject.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSelectedProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectedProject.Location = new System.Drawing.Point(0, 9);
            this.lblSelectedProject.Name = "lblSelectedProject";
            this.lblSelectedProject.Size = new System.Drawing.Size(307, 23);
            this.lblSelectedProject.Style = MetroSet_UI.Design.Style.Light;
            this.lblSelectedProject.StyleManager = null;
            this.lblSelectedProject.TabIndex = 3;
            this.lblSelectedProject.Text = "Selected Project: None";
            this.lblSelectedProject.ThemeAuthor = "Narwin";
            this.lblSelectedProject.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.Location = new System.Drawing.Point(0, 38);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(307, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 2;
            this.metroSetLabel3.Text = "Recently Opened Projects:";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.Location = new System.Drawing.Point(0, 210);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(307, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 2;
            this.metroSetLabel1.Text = "Browse Projects:";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // cbxSavedProjects
            // 
            this.cbxSavedProjects.AllowDrop = true;
            this.cbxSavedProjects.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxSavedProjects.BackColor = System.Drawing.Color.Transparent;
            this.cbxSavedProjects.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.cbxSavedProjects.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.cbxSavedProjects.CausesValidation = false;
            this.cbxSavedProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbxSavedProjects.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.cbxSavedProjects.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.cbxSavedProjects.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.cbxSavedProjects.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxSavedProjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSavedProjects.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbxSavedProjects.FormattingEnabled = true;
            this.cbxSavedProjects.ItemHeight = 20;
            this.cbxSavedProjects.Location = new System.Drawing.Point(0, 234);
            this.cbxSavedProjects.Name = "cbxSavedProjects";
            this.cbxSavedProjects.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.cbxSavedProjects.SelectedItemForeColor = System.Drawing.Color.White;
            this.cbxSavedProjects.Size = new System.Drawing.Size(307, 26);
            this.cbxSavedProjects.Style = MetroSet_UI.Design.Style.Light;
            this.cbxSavedProjects.StyleManager = null;
            this.cbxSavedProjects.TabIndex = 1;
            this.cbxSavedProjects.ThemeAuthor = "Narwin";
            this.cbxSavedProjects.ThemeName = "MetroLite";
            // 
            // btnEditSelectedProject
            // 
            this.btnEditSelectedProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditSelectedProject.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEditSelectedProject.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnEditSelectedProject.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnEditSelectedProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditSelectedProject.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEditSelectedProject.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEditSelectedProject.HoverTextColor = System.Drawing.Color.White;
            this.btnEditSelectedProject.Location = new System.Drawing.Point(156, 266);
            this.btnEditSelectedProject.Name = "btnEditSelectedProject";
            this.btnEditSelectedProject.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditSelectedProject.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditSelectedProject.NormalTextColor = System.Drawing.Color.White;
            this.btnEditSelectedProject.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnEditSelectedProject.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnEditSelectedProject.PressTextColor = System.Drawing.Color.White;
            this.btnEditSelectedProject.Size = new System.Drawing.Size(151, 36);
            this.btnEditSelectedProject.Style = MetroSet_UI.Design.Style.Custom;
            this.btnEditSelectedProject.StyleManager = null;
            this.btnEditSelectedProject.TabIndex = 0;
            this.btnEditSelectedProject.Text = "Edit Selected Project";
            this.btnEditSelectedProject.ThemeAuthor = "Narwin";
            this.btnEditSelectedProject.ThemeName = "MetroLite";
            this.btnEditSelectedProject.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
            this.btnEditSelectedProject.Click += new System.EventHandler(this.btnEditProject_Click);
            // 
            // btnDeleteSelectedProject
            // 
            this.btnDeleteSelectedProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteSelectedProject.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDeleteSelectedProject.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnDeleteSelectedProject.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnDeleteSelectedProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteSelectedProject.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDeleteSelectedProject.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDeleteSelectedProject.HoverTextColor = System.Drawing.Color.White;
            this.btnDeleteSelectedProject.Location = new System.Drawing.Point(156, 308);
            this.btnDeleteSelectedProject.Name = "btnDeleteSelectedProject";
            this.btnDeleteSelectedProject.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteSelectedProject.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteSelectedProject.NormalTextColor = System.Drawing.Color.White;
            this.btnDeleteSelectedProject.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDeleteSelectedProject.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDeleteSelectedProject.PressTextColor = System.Drawing.Color.White;
            this.btnDeleteSelectedProject.Size = new System.Drawing.Size(151, 36);
            this.btnDeleteSelectedProject.Style = MetroSet_UI.Design.Style.Custom;
            this.btnDeleteSelectedProject.StyleManager = null;
            this.btnDeleteSelectedProject.TabIndex = 0;
            this.btnDeleteSelectedProject.Text = "Delete Selected Project";
            this.btnDeleteSelectedProject.ThemeAuthor = "Narwin";
            this.btnDeleteSelectedProject.ThemeName = "MetroLite";
            this.btnDeleteSelectedProject.TileAlign = MetroSet_UI.Enums.TileAlign.Topleft;
            this.btnDeleteSelectedProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // btnSeletProject
            // 
            this.btnSeletProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeletProject.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnSeletProject.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnSeletProject.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnSeletProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSeletProject.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSeletProject.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSeletProject.HoverTextColor = System.Drawing.Color.White;
            this.btnSeletProject.Location = new System.Drawing.Point(0, 266);
            this.btnSeletProject.Name = "btnSeletProject";
            this.btnSeletProject.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSeletProject.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSeletProject.NormalTextColor = System.Drawing.Color.White;
            this.btnSeletProject.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSeletProject.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSeletProject.PressTextColor = System.Drawing.Color.White;
            this.btnSeletProject.Size = new System.Drawing.Size(150, 78);
            this.btnSeletProject.Style = MetroSet_UI.Design.Style.Custom;
            this.btnSeletProject.StyleManager = null;
            this.btnSeletProject.TabIndex = 0;
            this.btnSeletProject.Text = "Select Project";
            this.btnSeletProject.ThemeAuthor = "Narwin";
            this.btnSeletProject.ThemeName = "MetroLite";
            this.btnSeletProject.TileAlign = MetroSet_UI.Enums.TileAlign.TopRight;
            this.btnSeletProject.Click += new System.EventHandler(this.btnSeletProject_Click);
            // 
            // tabServices
            // 
            this.tabServices.BaseColor = System.Drawing.Color.White;
            this.tabServices.Controls.Add(this.btnStartStopTomcat);
            this.tabServices.Controls.Add(this.btnStartStopMercury);
            this.tabServices.Controls.Add(this.btnStartStopFileZilla);
            this.tabServices.Controls.Add(this.btnStartStopMySQL);
            this.tabServices.Controls.Add(this.btnStartStopApache);
            this.tabServices.Controls.Add(this.pbxTomcatStatus);
            this.tabServices.Controls.Add(this.pbxMercuryStatus);
            this.tabServices.Controls.Add(this.pbxFileZillaStatus);
            this.tabServices.Controls.Add(this.pbxMySQLStatus);
            this.tabServices.Controls.Add(this.pbxApacheStatus);
            this.tabServices.Controls.Add(this.btnTomcatConfig);
            this.tabServices.Controls.Add(this.btnMercuryConfig);
            this.tabServices.Controls.Add(this.btnFileZillaConfig);
            this.tabServices.Controls.Add(this.btnMySQLConfig);
            this.tabServices.Controls.Add(this.btnApacheConfig);
            this.tabServices.Controls.Add(this.btnDisableAllServices);
            this.tabServices.Controls.Add(this.btnEnableAllServices);
            this.tabServices.Controls.Add(this.pbxLogoTomcat);
            this.tabServices.Controls.Add(this.pbxLogoMercury);
            this.tabServices.Controls.Add(this.pbxLogoFileZilla);
            this.tabServices.Controls.Add(this.pbxLogoMySQL);
            this.tabServices.Controls.Add(this.pbxLogoApache);
            this.tabServices.Controls.Add(this.metroSetDivider5);
            this.tabServices.Controls.Add(this.metroSetLabel10);
            this.tabServices.Controls.Add(this.metroSetLabel9);
            this.tabServices.Controls.Add(this.metroSetLabel8);
            this.tabServices.Controls.Add(this.metroSetLabel7);
            this.tabServices.Controls.Add(this.metroSetLabel2);
            this.tabServices.Controls.Add(this.chbServiceTomcat);
            this.tabServices.Controls.Add(this.chbServiceFileZilla);
            this.tabServices.Controls.Add(this.chbServiceMercury);
            this.tabServices.Controls.Add(this.chbServiceMySQL);
            this.tabServices.Controls.Add(this.chbServiceApache);
            this.tabServices.Controls.Add(this.metroSetLabel4);
            this.tabServices.Controls.Add(this.metroSetDivider2);
            this.tabServices.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabServices.ImageIndex = 0;
            this.tabServices.ImageKey = null;
            this.tabServices.Location = new System.Drawing.Point(4, 42);
            this.tabServices.Name = "tabServices";
            this.tabServices.Size = new System.Drawing.Size(307, 347);
            this.tabServices.Style = MetroSet_UI.Design.Style.Light;
            this.tabServices.StyleManager = null;
            this.tabServices.TabIndex = 1;
            this.tabServices.Text = "Services";
            this.tabServices.ThemeAuthor = "Narwin";
            this.tabServices.ThemeName = "MetroLite";
            this.tabServices.ToolTipText = null;
            // 
            // btnStartStopTomcat
            // 
            this.btnStartStopTomcat.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopTomcat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopTomcat.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnStartStopTomcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStartStopTomcat.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStartStopTomcat.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStartStopTomcat.HoverTextColor = System.Drawing.Color.White;
            this.btnStartStopTomcat.Location = new System.Drawing.Point(191, 245);
            this.btnStartStopTomcat.Name = "btnStartStopTomcat";
            this.btnStartStopTomcat.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopTomcat.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopTomcat.NormalTextColor = System.Drawing.Color.White;
            this.btnStartStopTomcat.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStartStopTomcat.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStartStopTomcat.PressTextColor = System.Drawing.Color.White;
            this.btnStartStopTomcat.Size = new System.Drawing.Size(75, 23);
            this.btnStartStopTomcat.Style = MetroSet_UI.Design.Style.Light;
            this.btnStartStopTomcat.StyleManager = null;
            this.btnStartStopTomcat.TabIndex = 21;
            this.btnStartStopTomcat.Text = "Start";
            this.btnStartStopTomcat.ThemeAuthor = "Narwin";
            this.btnStartStopTomcat.ThemeName = "MetroLite";
            this.btnStartStopTomcat.Click += new System.EventHandler(this.btnStartStopTomcat_Click);
            // 
            // btnStartStopMercury
            // 
            this.btnStartStopMercury.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopMercury.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopMercury.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnStartStopMercury.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStartStopMercury.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStartStopMercury.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStartStopMercury.HoverTextColor = System.Drawing.Color.White;
            this.btnStartStopMercury.Location = new System.Drawing.Point(191, 199);
            this.btnStartStopMercury.Name = "btnStartStopMercury";
            this.btnStartStopMercury.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopMercury.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopMercury.NormalTextColor = System.Drawing.Color.White;
            this.btnStartStopMercury.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStartStopMercury.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStartStopMercury.PressTextColor = System.Drawing.Color.White;
            this.btnStartStopMercury.Size = new System.Drawing.Size(75, 23);
            this.btnStartStopMercury.Style = MetroSet_UI.Design.Style.Light;
            this.btnStartStopMercury.StyleManager = null;
            this.btnStartStopMercury.TabIndex = 21;
            this.btnStartStopMercury.Text = "Start";
            this.btnStartStopMercury.ThemeAuthor = "Narwin";
            this.btnStartStopMercury.ThemeName = "MetroLite";
            this.btnStartStopMercury.Click += new System.EventHandler(this.btnStartStopMercury_Click);
            // 
            // btnStartStopFileZilla
            // 
            this.btnStartStopFileZilla.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopFileZilla.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopFileZilla.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnStartStopFileZilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStartStopFileZilla.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStartStopFileZilla.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStartStopFileZilla.HoverTextColor = System.Drawing.Color.White;
            this.btnStartStopFileZilla.Location = new System.Drawing.Point(191, 153);
            this.btnStartStopFileZilla.Name = "btnStartStopFileZilla";
            this.btnStartStopFileZilla.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopFileZilla.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopFileZilla.NormalTextColor = System.Drawing.Color.White;
            this.btnStartStopFileZilla.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStartStopFileZilla.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStartStopFileZilla.PressTextColor = System.Drawing.Color.White;
            this.btnStartStopFileZilla.Size = new System.Drawing.Size(75, 23);
            this.btnStartStopFileZilla.Style = MetroSet_UI.Design.Style.Light;
            this.btnStartStopFileZilla.StyleManager = null;
            this.btnStartStopFileZilla.TabIndex = 21;
            this.btnStartStopFileZilla.Text = "Start";
            this.btnStartStopFileZilla.ThemeAuthor = "Narwin";
            this.btnStartStopFileZilla.ThemeName = "MetroLite";
            this.btnStartStopFileZilla.Click += new System.EventHandler(this.btnStartStopFileZilla_Click);
            // 
            // btnStartStopMySQL
            // 
            this.btnStartStopMySQL.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopMySQL.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopMySQL.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnStartStopMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStartStopMySQL.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStartStopMySQL.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStartStopMySQL.HoverTextColor = System.Drawing.Color.White;
            this.btnStartStopMySQL.Location = new System.Drawing.Point(191, 96);
            this.btnStartStopMySQL.Name = "btnStartStopMySQL";
            this.btnStartStopMySQL.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopMySQL.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopMySQL.NormalTextColor = System.Drawing.Color.White;
            this.btnStartStopMySQL.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStartStopMySQL.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStartStopMySQL.PressTextColor = System.Drawing.Color.White;
            this.btnStartStopMySQL.Size = new System.Drawing.Size(75, 23);
            this.btnStartStopMySQL.Style = MetroSet_UI.Design.Style.Light;
            this.btnStartStopMySQL.StyleManager = null;
            this.btnStartStopMySQL.TabIndex = 21;
            this.btnStartStopMySQL.Text = "Start";
            this.btnStartStopMySQL.ThemeAuthor = "Narwin";
            this.btnStartStopMySQL.ThemeName = "MetroLite";
            this.btnStartStopMySQL.Click += new System.EventHandler(this.btnStartStopMySQL_Click);
            // 
            // btnStartStopApache
            // 
            this.btnStartStopApache.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopApache.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopApache.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnStartStopApache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStartStopApache.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStartStopApache.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStartStopApache.HoverTextColor = System.Drawing.Color.White;
            this.btnStartStopApache.Location = new System.Drawing.Point(191, 52);
            this.btnStartStopApache.Name = "btnStartStopApache";
            this.btnStartStopApache.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopApache.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartStopApache.NormalTextColor = System.Drawing.Color.White;
            this.btnStartStopApache.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStartStopApache.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStartStopApache.PressTextColor = System.Drawing.Color.White;
            this.btnStartStopApache.Size = new System.Drawing.Size(75, 23);
            this.btnStartStopApache.Style = MetroSet_UI.Design.Style.Light;
            this.btnStartStopApache.StyleManager = null;
            this.btnStartStopApache.TabIndex = 21;
            this.btnStartStopApache.Text = "Start";
            this.btnStartStopApache.ThemeAuthor = "Narwin";
            this.btnStartStopApache.ThemeName = "MetroLite";
            this.btnStartStopApache.Click += new System.EventHandler(this.btnStartStopApache_Click);
            // 
            // pbxTomcatStatus
            // 
            this.pbxTomcatStatus.BackColor = System.Drawing.Color.Red;
            this.pbxTomcatStatus.Location = new System.Drawing.Point(107, 245);
            this.pbxTomcatStatus.Name = "pbxTomcatStatus";
            this.pbxTomcatStatus.Size = new System.Drawing.Size(10, 22);
            this.pbxTomcatStatus.TabIndex = 20;
            this.pbxTomcatStatus.TabStop = false;
            // 
            // pbxMercuryStatus
            // 
            this.pbxMercuryStatus.BackColor = System.Drawing.Color.Red;
            this.pbxMercuryStatus.Location = new System.Drawing.Point(107, 199);
            this.pbxMercuryStatus.Name = "pbxMercuryStatus";
            this.pbxMercuryStatus.Size = new System.Drawing.Size(10, 22);
            this.pbxMercuryStatus.TabIndex = 20;
            this.pbxMercuryStatus.TabStop = false;
            // 
            // pbxFileZillaStatus
            // 
            this.pbxFileZillaStatus.BackColor = System.Drawing.Color.Red;
            this.pbxFileZillaStatus.Location = new System.Drawing.Point(107, 153);
            this.pbxFileZillaStatus.Name = "pbxFileZillaStatus";
            this.pbxFileZillaStatus.Size = new System.Drawing.Size(10, 22);
            this.pbxFileZillaStatus.TabIndex = 20;
            this.pbxFileZillaStatus.TabStop = false;
            // 
            // pbxMySQLStatus
            // 
            this.pbxMySQLStatus.BackColor = System.Drawing.Color.Red;
            this.pbxMySQLStatus.Location = new System.Drawing.Point(107, 97);
            this.pbxMySQLStatus.Name = "pbxMySQLStatus";
            this.pbxMySQLStatus.Size = new System.Drawing.Size(10, 22);
            this.pbxMySQLStatus.TabIndex = 20;
            this.pbxMySQLStatus.TabStop = false;
            // 
            // pbxApacheStatus
            // 
            this.pbxApacheStatus.BackColor = System.Drawing.Color.Red;
            this.pbxApacheStatus.Location = new System.Drawing.Point(107, 51);
            this.pbxApacheStatus.Name = "pbxApacheStatus";
            this.pbxApacheStatus.Size = new System.Drawing.Size(10, 22);
            this.pbxApacheStatus.TabIndex = 20;
            this.pbxApacheStatus.TabStop = false;
            // 
            // btnTomcatConfig
            // 
            this.btnTomcatConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTomcatConfig.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTomcatConfig.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnTomcatConfig.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnTomcatConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnTomcatConfig.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnTomcatConfig.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnTomcatConfig.HoverTextColor = System.Drawing.Color.White;
            this.btnTomcatConfig.Location = new System.Drawing.Point(272, 245);
            this.btnTomcatConfig.Name = "btnTomcatConfig";
            this.btnTomcatConfig.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnTomcatConfig.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnTomcatConfig.NormalTextColor = System.Drawing.Color.Black;
            this.btnTomcatConfig.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnTomcatConfig.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnTomcatConfig.PressTextColor = System.Drawing.Color.White;
            this.btnTomcatConfig.Size = new System.Drawing.Size(33, 22);
            this.btnTomcatConfig.Style = MetroSet_UI.Design.Style.Light;
            this.btnTomcatConfig.StyleManager = null;
            this.btnTomcatConfig.TabIndex = 19;
            this.btnTomcatConfig.Text = "✍";
            this.btnTomcatConfig.ThemeAuthor = "Narwin";
            this.btnTomcatConfig.ThemeName = "MetroLite";
            this.btnTomcatConfig.Click += new System.EventHandler(this.btnTomcatConfig_Click);
            // 
            // btnMercuryConfig
            // 
            this.btnMercuryConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMercuryConfig.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMercuryConfig.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnMercuryConfig.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnMercuryConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMercuryConfig.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnMercuryConfig.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnMercuryConfig.HoverTextColor = System.Drawing.Color.White;
            this.btnMercuryConfig.Location = new System.Drawing.Point(272, 199);
            this.btnMercuryConfig.Name = "btnMercuryConfig";
            this.btnMercuryConfig.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMercuryConfig.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnMercuryConfig.NormalTextColor = System.Drawing.Color.Black;
            this.btnMercuryConfig.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMercuryConfig.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMercuryConfig.PressTextColor = System.Drawing.Color.White;
            this.btnMercuryConfig.Size = new System.Drawing.Size(33, 22);
            this.btnMercuryConfig.Style = MetroSet_UI.Design.Style.Light;
            this.btnMercuryConfig.StyleManager = null;
            this.btnMercuryConfig.TabIndex = 19;
            this.btnMercuryConfig.Text = "✍";
            this.btnMercuryConfig.ThemeAuthor = "Narwin";
            this.btnMercuryConfig.ThemeName = "MetroLite";
            this.btnMercuryConfig.Click += new System.EventHandler(this.btnMercuryConfig_Click);
            // 
            // btnFileZillaConfig
            // 
            this.btnFileZillaConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileZillaConfig.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFileZillaConfig.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnFileZillaConfig.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnFileZillaConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnFileZillaConfig.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnFileZillaConfig.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnFileZillaConfig.HoverTextColor = System.Drawing.Color.White;
            this.btnFileZillaConfig.Location = new System.Drawing.Point(272, 153);
            this.btnFileZillaConfig.Name = "btnFileZillaConfig";
            this.btnFileZillaConfig.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnFileZillaConfig.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnFileZillaConfig.NormalTextColor = System.Drawing.Color.Black;
            this.btnFileZillaConfig.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnFileZillaConfig.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnFileZillaConfig.PressTextColor = System.Drawing.Color.White;
            this.btnFileZillaConfig.Size = new System.Drawing.Size(33, 22);
            this.btnFileZillaConfig.Style = MetroSet_UI.Design.Style.Light;
            this.btnFileZillaConfig.StyleManager = null;
            this.btnFileZillaConfig.TabIndex = 19;
            this.btnFileZillaConfig.Text = "✍";
            this.btnFileZillaConfig.ThemeAuthor = "Narwin";
            this.btnFileZillaConfig.ThemeName = "MetroLite";
            this.btnFileZillaConfig.Click += new System.EventHandler(this.btnFileZillaConfig_Click);
            // 
            // btnMySQLConfig
            // 
            this.btnMySQLConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMySQLConfig.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMySQLConfig.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnMySQLConfig.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnMySQLConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.btnMySQLConfig.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnMySQLConfig.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnMySQLConfig.HoverTextColor = System.Drawing.Color.White;
            this.btnMySQLConfig.Location = new System.Drawing.Point(272, 97);
            this.btnMySQLConfig.Name = "btnMySQLConfig";
            this.btnMySQLConfig.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnMySQLConfig.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnMySQLConfig.NormalTextColor = System.Drawing.Color.Black;
            this.btnMySQLConfig.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMySQLConfig.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMySQLConfig.PressTextColor = System.Drawing.Color.White;
            this.btnMySQLConfig.Size = new System.Drawing.Size(33, 22);
            this.btnMySQLConfig.Style = MetroSet_UI.Design.Style.Light;
            this.btnMySQLConfig.StyleManager = null;
            this.btnMySQLConfig.TabIndex = 19;
            this.btnMySQLConfig.Text = "✍";
            this.btnMySQLConfig.ThemeAuthor = "Narwin";
            this.btnMySQLConfig.ThemeName = "MetroLite";
            this.btnMySQLConfig.Click += new System.EventHandler(this.btnMySQLConfig_Click);
            // 
            // btnApacheConfig
            // 
            this.btnApacheConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnApacheConfig.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnApacheConfig.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnApacheConfig.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnApacheConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApacheConfig.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnApacheConfig.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnApacheConfig.HoverTextColor = System.Drawing.Color.White;
            this.btnApacheConfig.Location = new System.Drawing.Point(272, 52);
            this.btnApacheConfig.Name = "btnApacheConfig";
            this.btnApacheConfig.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnApacheConfig.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.btnApacheConfig.NormalTextColor = System.Drawing.Color.Black;
            this.btnApacheConfig.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnApacheConfig.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnApacheConfig.PressTextColor = System.Drawing.Color.White;
            this.btnApacheConfig.Size = new System.Drawing.Size(32, 22);
            this.btnApacheConfig.Style = MetroSet_UI.Design.Style.Light;
            this.btnApacheConfig.StyleManager = null;
            this.btnApacheConfig.TabIndex = 19;
            this.btnApacheConfig.Text = "✍";
            this.btnApacheConfig.ThemeAuthor = "Narwin";
            this.btnApacheConfig.ThemeName = "MetroLite";
            this.btnApacheConfig.Click += new System.EventHandler(this.btnApacheConfig_Click);
            // 
            // btnDisableAllServices
            // 
            this.btnDisableAllServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDisableAllServices.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnDisableAllServices.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnDisableAllServices.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnDisableAllServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDisableAllServices.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDisableAllServices.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDisableAllServices.HoverTextColor = System.Drawing.Color.White;
            this.btnDisableAllServices.Location = new System.Drawing.Point(156, 296);
            this.btnDisableAllServices.Name = "btnDisableAllServices";
            this.btnDisableAllServices.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDisableAllServices.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDisableAllServices.NormalTextColor = System.Drawing.Color.White;
            this.btnDisableAllServices.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDisableAllServices.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDisableAllServices.PressTextColor = System.Drawing.Color.White;
            this.btnDisableAllServices.Size = new System.Drawing.Size(104, 34);
            this.btnDisableAllServices.Style = MetroSet_UI.Design.Style.Custom;
            this.btnDisableAllServices.StyleManager = null;
            this.btnDisableAllServices.TabIndex = 17;
            this.btnDisableAllServices.Text = "Toggle All Off";
            this.btnDisableAllServices.ThemeAuthor = "Narwin";
            this.btnDisableAllServices.ThemeName = "MetroLite";
            this.btnDisableAllServices.TileAlign = MetroSet_UI.Enums.TileAlign.BottomRight;
            this.btnDisableAllServices.Click += new System.EventHandler(this.btnDisableAllServices_Click);
            // 
            // btnEnableAllServices
            // 
            this.btnEnableAllServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEnableAllServices.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnEnableAllServices.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnEnableAllServices.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnEnableAllServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEnableAllServices.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEnableAllServices.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEnableAllServices.HoverTextColor = System.Drawing.Color.White;
            this.btnEnableAllServices.Location = new System.Drawing.Point(46, 296);
            this.btnEnableAllServices.Name = "btnEnableAllServices";
            this.btnEnableAllServices.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEnableAllServices.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEnableAllServices.NormalTextColor = System.Drawing.Color.White;
            this.btnEnableAllServices.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnEnableAllServices.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnEnableAllServices.PressTextColor = System.Drawing.Color.White;
            this.btnEnableAllServices.Size = new System.Drawing.Size(104, 34);
            this.btnEnableAllServices.Style = MetroSet_UI.Design.Style.Custom;
            this.btnEnableAllServices.StyleManager = null;
            this.btnEnableAllServices.TabIndex = 17;
            this.btnEnableAllServices.Text = "Toggle All On";
            this.btnEnableAllServices.ThemeAuthor = "Narwin";
            this.btnEnableAllServices.ThemeName = "MetroLite";
            this.btnEnableAllServices.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.btnEnableAllServices.Click += new System.EventHandler(this.btnEnableAllServices_Click);
            // 
            // pbxLogoTomcat
            // 
            this.pbxLogoTomcat.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogoTomcat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLogoTomcat.Location = new System.Drawing.Point(3, 236);
            this.pbxLogoTomcat.Name = "pbxLogoTomcat";
            this.pbxLogoTomcat.Size = new System.Drawing.Size(40, 40);
            this.pbxLogoTomcat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoTomcat.TabIndex = 16;
            this.pbxLogoTomcat.TabStop = false;
            this.pbxLogoTomcat.Click += new System.EventHandler(this.pbxLogoTomcat_Click);
            this.pbxLogoTomcat.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxSetAA_Paint);
            // 
            // pbxLogoMercury
            // 
            this.pbxLogoMercury.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogoMercury.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLogoMercury.Location = new System.Drawing.Point(3, 190);
            this.pbxLogoMercury.Name = "pbxLogoMercury";
            this.pbxLogoMercury.Size = new System.Drawing.Size(40, 40);
            this.pbxLogoMercury.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoMercury.TabIndex = 16;
            this.pbxLogoMercury.TabStop = false;
            this.pbxLogoMercury.Click += new System.EventHandler(this.pbxLogoMercury_Click);
            this.pbxLogoMercury.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxSetAA_Paint);
            // 
            // pbxLogoFileZilla
            // 
            this.pbxLogoFileZilla.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogoFileZilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLogoFileZilla.Location = new System.Drawing.Point(3, 144);
            this.pbxLogoFileZilla.Name = "pbxLogoFileZilla";
            this.pbxLogoFileZilla.Size = new System.Drawing.Size(40, 40);
            this.pbxLogoFileZilla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoFileZilla.TabIndex = 16;
            this.pbxLogoFileZilla.TabStop = false;
            this.pbxLogoFileZilla.Click += new System.EventHandler(this.pbxLogoFileZilla_Click);
            this.pbxLogoFileZilla.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxSetAA_Paint);
            // 
            // pbxLogoMySQL
            // 
            this.pbxLogoMySQL.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogoMySQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLogoMySQL.Location = new System.Drawing.Point(3, 88);
            this.pbxLogoMySQL.Name = "pbxLogoMySQL";
            this.pbxLogoMySQL.Size = new System.Drawing.Size(40, 40);
            this.pbxLogoMySQL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoMySQL.TabIndex = 16;
            this.pbxLogoMySQL.TabStop = false;
            this.pbxLogoMySQL.Click += new System.EventHandler(this.pbxLogoMySQL_Click);
            this.pbxLogoMySQL.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxSetAA_Paint);
            // 
            // pbxLogoApache
            // 
            this.pbxLogoApache.BackColor = System.Drawing.Color.Transparent;
            this.pbxLogoApache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbxLogoApache.InitialImage = global::XPS3.Properties.Resources.apache;
            this.pbxLogoApache.Location = new System.Drawing.Point(3, 42);
            this.pbxLogoApache.Name = "pbxLogoApache";
            this.pbxLogoApache.Size = new System.Drawing.Size(40, 40);
            this.pbxLogoApache.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoApache.TabIndex = 16;
            this.pbxLogoApache.TabStop = false;
            this.pbxLogoApache.Click += new System.EventHandler(this.pbxLogoApache_Click);
            this.pbxLogoApache.Paint += new System.Windows.Forms.PaintEventHandler(this.pbxSetAA_Paint);
            // 
            // metroSetDivider5
            // 
            this.metroSetDivider5.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetDivider5.Location = new System.Drawing.Point(-4, 134);
            this.metroSetDivider5.Name = "metroSetDivider5";
            this.metroSetDivider5.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider5.Size = new System.Drawing.Size(311, 4);
            this.metroSetDivider5.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetDivider5.StyleManager = null;
            this.metroSetDivider5.TabIndex = 15;
            this.metroSetDivider5.Text = "metroSetDivider5";
            this.metroSetDivider5.ThemeAuthor = "Narwin";
            this.metroSetDivider5.ThemeName = "MetroDark";
            this.metroSetDivider5.Thickness = 1;
            // 
            // metroSetLabel10
            // 
            this.metroSetLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel10.Location = new System.Drawing.Point(123, 245);
            this.metroSetLabel10.Name = "metroSetLabel10";
            this.metroSetLabel10.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel10.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel10.StyleManager = null;
            this.metroSetLabel10.TabIndex = 14;
            this.metroSetLabel10.Text = "Tomcat";
            this.metroSetLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel10.ThemeAuthor = "Narwin";
            this.metroSetLabel10.ThemeName = "MetroLite";
            // 
            // metroSetLabel9
            // 
            this.metroSetLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel9.Location = new System.Drawing.Point(123, 199);
            this.metroSetLabel9.Name = "metroSetLabel9";
            this.metroSetLabel9.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel9.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel9.StyleManager = null;
            this.metroSetLabel9.TabIndex = 14;
            this.metroSetLabel9.Text = "Mercury";
            this.metroSetLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel9.ThemeAuthor = "Narwin";
            this.metroSetLabel9.ThemeName = "MetroLite";
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel8.Location = new System.Drawing.Point(123, 153);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel8.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 14;
            this.metroSetLabel8.Text = "FileZilla";
            this.metroSetLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroLite";
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel7.Location = new System.Drawing.Point(123, 97);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 14;
            this.metroSetLabel7.Text = "MySQL";
            this.metroSetLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.Location = new System.Drawing.Point(123, 51);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 14;
            this.metroSetLabel2.Text = "Apache";
            this.metroSetLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // chbServiceTomcat
            // 
            this.chbServiceTomcat.BackColor = System.Drawing.Color.Transparent;
            this.chbServiceTomcat.BackgroundColor = System.Drawing.Color.Empty;
            this.chbServiceTomcat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.chbServiceTomcat.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbServiceTomcat.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbServiceTomcat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbServiceTomcat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbServiceTomcat.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbServiceTomcat.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbServiceTomcat.Location = new System.Drawing.Point(49, 245);
            this.chbServiceTomcat.Name = "chbServiceTomcat";
            this.chbServiceTomcat.Size = new System.Drawing.Size(58, 22);
            this.chbServiceTomcat.Style = MetroSet_UI.Design.Style.Light;
            this.chbServiceTomcat.StyleManager = null;
            this.chbServiceTomcat.Switched = false;
            this.chbServiceTomcat.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chbServiceTomcat.TabIndex = 13;
            this.chbServiceTomcat.Text = "metroSetSwitch6";
            this.chbServiceTomcat.ThemeAuthor = "Narwin";
            this.chbServiceTomcat.ThemeName = "MetroLite";
            this.chbServiceTomcat.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chbServiceTomcat.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.UpdateSelectedServices);
            // 
            // chbServiceFileZilla
            // 
            this.chbServiceFileZilla.BackColor = System.Drawing.Color.Transparent;
            this.chbServiceFileZilla.BackgroundColor = System.Drawing.Color.Empty;
            this.chbServiceFileZilla.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.chbServiceFileZilla.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbServiceFileZilla.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbServiceFileZilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbServiceFileZilla.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbServiceFileZilla.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbServiceFileZilla.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbServiceFileZilla.Location = new System.Drawing.Point(49, 153);
            this.chbServiceFileZilla.Name = "chbServiceFileZilla";
            this.chbServiceFileZilla.Size = new System.Drawing.Size(58, 22);
            this.chbServiceFileZilla.Style = MetroSet_UI.Design.Style.Light;
            this.chbServiceFileZilla.StyleManager = null;
            this.chbServiceFileZilla.Switched = false;
            this.chbServiceFileZilla.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chbServiceFileZilla.TabIndex = 12;
            this.chbServiceFileZilla.Text = "metroSetSwitch5";
            this.chbServiceFileZilla.ThemeAuthor = "Narwin";
            this.chbServiceFileZilla.ThemeName = "MetroLite";
            this.chbServiceFileZilla.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chbServiceFileZilla.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.UpdateSelectedServices);
            // 
            // chbServiceMercury
            // 
            this.chbServiceMercury.BackColor = System.Drawing.Color.Transparent;
            this.chbServiceMercury.BackgroundColor = System.Drawing.Color.Empty;
            this.chbServiceMercury.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.chbServiceMercury.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbServiceMercury.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbServiceMercury.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbServiceMercury.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbServiceMercury.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbServiceMercury.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbServiceMercury.Location = new System.Drawing.Point(49, 199);
            this.chbServiceMercury.Name = "chbServiceMercury";
            this.chbServiceMercury.Size = new System.Drawing.Size(58, 22);
            this.chbServiceMercury.Style = MetroSet_UI.Design.Style.Light;
            this.chbServiceMercury.StyleManager = null;
            this.chbServiceMercury.Switched = false;
            this.chbServiceMercury.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chbServiceMercury.TabIndex = 11;
            this.chbServiceMercury.Text = "metroSetSwitch4";
            this.chbServiceMercury.ThemeAuthor = "Narwin";
            this.chbServiceMercury.ThemeName = "MetroLite";
            this.chbServiceMercury.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chbServiceMercury.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.UpdateSelectedServices);
            // 
            // chbServiceMySQL
            // 
            this.chbServiceMySQL.BackColor = System.Drawing.Color.Transparent;
            this.chbServiceMySQL.BackgroundColor = System.Drawing.Color.Empty;
            this.chbServiceMySQL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.chbServiceMySQL.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbServiceMySQL.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbServiceMySQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbServiceMySQL.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbServiceMySQL.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbServiceMySQL.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbServiceMySQL.Location = new System.Drawing.Point(49, 97);
            this.chbServiceMySQL.Name = "chbServiceMySQL";
            this.chbServiceMySQL.Size = new System.Drawing.Size(58, 22);
            this.chbServiceMySQL.Style = MetroSet_UI.Design.Style.Light;
            this.chbServiceMySQL.StyleManager = null;
            this.chbServiceMySQL.Switched = false;
            this.chbServiceMySQL.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chbServiceMySQL.TabIndex = 10;
            this.chbServiceMySQL.Text = "metroSetSwitch3";
            this.chbServiceMySQL.ThemeAuthor = "Narwin";
            this.chbServiceMySQL.ThemeName = "MetroLite";
            this.chbServiceMySQL.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chbServiceMySQL.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.UpdateSelectedServices);
            // 
            // chbServiceApache
            // 
            this.chbServiceApache.BackColor = System.Drawing.Color.Transparent;
            this.chbServiceApache.BackgroundColor = System.Drawing.Color.Empty;
            this.chbServiceApache.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.chbServiceApache.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbServiceApache.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbServiceApache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbServiceApache.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbServiceApache.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbServiceApache.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbServiceApache.Location = new System.Drawing.Point(49, 51);
            this.chbServiceApache.Name = "chbServiceApache";
            this.chbServiceApache.Size = new System.Drawing.Size(58, 22);
            this.chbServiceApache.Style = MetroSet_UI.Design.Style.Light;
            this.chbServiceApache.StyleManager = null;
            this.chbServiceApache.Switched = false;
            this.chbServiceApache.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chbServiceApache.TabIndex = 8;
            this.chbServiceApache.Text = "metroSetSwitch1";
            this.chbServiceApache.ThemeAuthor = "Narwin";
            this.chbServiceApache.ThemeName = "MetroLite";
            this.chbServiceApache.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chbServiceApache.SwitchedChanged += new MetroSet_UI.Controls.MetroSetSwitch.SwitchedChangedEventHandler(this.UpdateSelectedServices);
            // 
            // metroSetLabel4
            // 
            this.metroSetLabel4.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel4.Location = new System.Drawing.Point(0, 9);
            this.metroSetLabel4.Name = "metroSetLabel4";
            this.metroSetLabel4.Size = new System.Drawing.Size(207, 23);
            this.metroSetLabel4.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel4.StyleManager = null;
            this.metroSetLabel4.TabIndex = 7;
            this.metroSetLabel4.Text = "Services";
            this.metroSetLabel4.ThemeAuthor = "Narwin";
            this.metroSetLabel4.ThemeName = "MetroLite";
            // 
            // metroSetDivider2
            // 
            this.metroSetDivider2.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetDivider2.Location = new System.Drawing.Point(0, 31);
            this.metroSetDivider2.Name = "metroSetDivider2";
            this.metroSetDivider2.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider2.Size = new System.Drawing.Size(311, 4);
            this.metroSetDivider2.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetDivider2.StyleManager = null;
            this.metroSetDivider2.TabIndex = 6;
            this.metroSetDivider2.Text = "metroSetDivider2";
            this.metroSetDivider2.ThemeAuthor = "Narwin";
            this.metroSetDivider2.ThemeName = "MetroDark";
            this.metroSetDivider2.Thickness = 1;
            // 
            // tabManager
            // 
            this.tabManager.BaseColor = System.Drawing.Color.White;
            this.tabManager.Controls.Add(this.lbcProjectList);
            this.tabManager.Controls.Add(this.btnEditProject);
            this.tabManager.Controls.Add(this.btnDeleteProject);
            this.tabManager.Controls.Add(this.btnImportConfig);
            this.tabManager.Controls.Add(this.btnExportConfig);
            this.tabManager.Controls.Add(this.btnAddNewProject);
            this.tabManager.Controls.Add(this.metroSetLabel5);
            this.tabManager.Controls.Add(this.metroSetDivider9);
            this.tabManager.Controls.Add(this.metroSetDivider3);
            this.tabManager.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabManager.ImageIndex = 0;
            this.tabManager.ImageKey = null;
            this.tabManager.Location = new System.Drawing.Point(4, 42);
            this.tabManager.Name = "tabManager";
            this.tabManager.Size = new System.Drawing.Size(307, 347);
            this.tabManager.Style = MetroSet_UI.Design.Style.Light;
            this.tabManager.StyleManager = null;
            this.tabManager.TabIndex = 2;
            this.tabManager.Text = "Manager";
            this.tabManager.ThemeAuthor = "Narwin";
            this.tabManager.ThemeName = "MetroLite";
            this.tabManager.ToolTipText = null;
            // 
            // btnEditProject
            // 
            this.btnEditProject.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditProject.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditProject.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnEditProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEditProject.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEditProject.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnEditProject.HoverTextColor = System.Drawing.Color.White;
            this.btnEditProject.Location = new System.Drawing.Point(0, 269);
            this.btnEditProject.Name = "btnEditProject";
            this.btnEditProject.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditProject.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnEditProject.NormalTextColor = System.Drawing.Color.White;
            this.btnEditProject.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnEditProject.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnEditProject.PressTextColor = System.Drawing.Color.White;
            this.btnEditProject.Size = new System.Drawing.Size(151, 31);
            this.btnEditProject.Style = MetroSet_UI.Design.Style.Custom;
            this.btnEditProject.StyleManager = null;
            this.btnEditProject.TabIndex = 10;
            this.btnEditProject.Text = "Edit";
            this.btnEditProject.ThemeAuthor = "Narwin";
            this.btnEditProject.ThemeName = "MetroLite";
            this.btnEditProject.Click += new System.EventHandler(this.btnEditProject_Click_1);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteProject.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteProject.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnDeleteProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnDeleteProject.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDeleteProject.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnDeleteProject.HoverTextColor = System.Drawing.Color.White;
            this.btnDeleteProject.Location = new System.Drawing.Point(156, 269);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteProject.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnDeleteProject.NormalTextColor = System.Drawing.Color.White;
            this.btnDeleteProject.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDeleteProject.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnDeleteProject.PressTextColor = System.Drawing.Color.White;
            this.btnDeleteProject.Size = new System.Drawing.Size(151, 31);
            this.btnDeleteProject.Style = MetroSet_UI.Design.Style.Custom;
            this.btnDeleteProject.StyleManager = null;
            this.btnDeleteProject.TabIndex = 10;
            this.btnDeleteProject.Text = "Delete";
            this.btnDeleteProject.ThemeAuthor = "Narwin";
            this.btnDeleteProject.ThemeName = "MetroLite";
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click_1);
            // 
            // btnImportConfig
            // 
            this.btnImportConfig.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnImportConfig.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnImportConfig.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnImportConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnImportConfig.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnImportConfig.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnImportConfig.HoverTextColor = System.Drawing.Color.White;
            this.btnImportConfig.Location = new System.Drawing.Point(156, 316);
            this.btnImportConfig.Name = "btnImportConfig";
            this.btnImportConfig.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnImportConfig.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnImportConfig.NormalTextColor = System.Drawing.Color.White;
            this.btnImportConfig.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnImportConfig.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnImportConfig.PressTextColor = System.Drawing.Color.White;
            this.btnImportConfig.Size = new System.Drawing.Size(151, 31);
            this.btnImportConfig.Style = MetroSet_UI.Design.Style.Custom;
            this.btnImportConfig.StyleManager = null;
            this.btnImportConfig.TabIndex = 10;
            this.btnImportConfig.Text = "Import Config";
            this.btnImportConfig.ThemeAuthor = "Narwin";
            this.btnImportConfig.ThemeName = "MetroLite";
            this.btnImportConfig.Click += new System.EventHandler(this.btnImportConfig_Click);
            // 
            // btnExportConfig
            // 
            this.btnExportConfig.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExportConfig.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExportConfig.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnExportConfig.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExportConfig.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnExportConfig.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnExportConfig.HoverTextColor = System.Drawing.Color.White;
            this.btnExportConfig.Location = new System.Drawing.Point(0, 316);
            this.btnExportConfig.Name = "btnExportConfig";
            this.btnExportConfig.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExportConfig.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnExportConfig.NormalTextColor = System.Drawing.Color.White;
            this.btnExportConfig.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnExportConfig.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnExportConfig.PressTextColor = System.Drawing.Color.White;
            this.btnExportConfig.Size = new System.Drawing.Size(151, 31);
            this.btnExportConfig.Style = MetroSet_UI.Design.Style.Custom;
            this.btnExportConfig.StyleManager = null;
            this.btnExportConfig.TabIndex = 10;
            this.btnExportConfig.Text = "Export Config";
            this.btnExportConfig.ThemeAuthor = "Narwin";
            this.btnExportConfig.ThemeName = "MetroLite";
            this.btnExportConfig.Click += new System.EventHandler(this.btnExportConfig_Click);
            // 
            // btnAddNewProject
            // 
            this.btnAddNewProject.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddNewProject.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddNewProject.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnAddNewProject.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAddNewProject.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddNewProject.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnAddNewProject.HoverTextColor = System.Drawing.Color.White;
            this.btnAddNewProject.Location = new System.Drawing.Point(0, 41);
            this.btnAddNewProject.Name = "btnAddNewProject";
            this.btnAddNewProject.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddNewProject.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnAddNewProject.NormalTextColor = System.Drawing.Color.White;
            this.btnAddNewProject.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddNewProject.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnAddNewProject.PressTextColor = System.Drawing.Color.White;
            this.btnAddNewProject.Size = new System.Drawing.Size(307, 45);
            this.btnAddNewProject.Style = MetroSet_UI.Design.Style.Custom;
            this.btnAddNewProject.StyleManager = null;
            this.btnAddNewProject.TabIndex = 9;
            this.btnAddNewProject.Text = "Add New Project";
            this.btnAddNewProject.ThemeAuthor = "Narwin";
            this.btnAddNewProject.ThemeName = "MetroLite";
            this.btnAddNewProject.Click += new System.EventHandler(this.btnAddNewProject_Click);
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel5.Location = new System.Drawing.Point(0, 9);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(307, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 8;
            this.metroSetLabel5.Text = "Manager";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetDivider9
            // 
            this.metroSetDivider9.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetDivider9.Location = new System.Drawing.Point(-4, 306);
            this.metroSetDivider9.Name = "metroSetDivider9";
            this.metroSetDivider9.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider9.Size = new System.Drawing.Size(311, 4);
            this.metroSetDivider9.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetDivider9.StyleManager = null;
            this.metroSetDivider9.TabIndex = 7;
            this.metroSetDivider9.Text = "metroSetDivider3";
            this.metroSetDivider9.ThemeAuthor = "Narwin";
            this.metroSetDivider9.ThemeName = "MetroDark";
            this.metroSetDivider9.Thickness = 1;
            // 
            // metroSetDivider3
            // 
            this.metroSetDivider3.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetDivider3.Location = new System.Drawing.Point(0, 31);
            this.metroSetDivider3.Name = "metroSetDivider3";
            this.metroSetDivider3.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider3.Size = new System.Drawing.Size(311, 4);
            this.metroSetDivider3.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetDivider3.StyleManager = null;
            this.metroSetDivider3.TabIndex = 7;
            this.metroSetDivider3.Text = "metroSetDivider3";
            this.metroSetDivider3.ThemeAuthor = "Narwin";
            this.metroSetDivider3.ThemeName = "MetroDark";
            this.metroSetDivider3.Thickness = 1;
            // 
            // tabSettings
            // 
            this.tabSettings.BaseColor = System.Drawing.Color.White;
            this.tabSettings.Controls.Add(this.metroSetLabel19);
            this.tabSettings.Controls.Add(this.chbAutostartTomcat);
            this.tabSettings.Controls.Add(this.chbAutostartMercury);
            this.tabSettings.Controls.Add(this.chbAutostartFileZilla);
            this.tabSettings.Controls.Add(this.chbAutostartMySQL);
            this.tabSettings.Controls.Add(this.chbAutostartApache);
            this.tabSettings.Controls.Add(this.btnSelectDefaultEditor);
            this.tabSettings.Controls.Add(this.btnSelectXamppInstallPath);
            this.tabSettings.Controls.Add(this.txbDefaultEditorPath);
            this.tabSettings.Controls.Add(this.txbXamppInstallPath);
            this.tabSettings.Controls.Add(this.metroSetLabel18);
            this.tabSettings.Controls.Add(this.metroSetLabel17);
            this.tabSettings.Controls.Add(this.metroSetLabel16);
            this.tabSettings.Controls.Add(this.metroSetLabel6);
            this.tabSettings.Controls.Add(this.metroSetDivider8);
            this.tabSettings.Controls.Add(this.metroSetDivider7);
            this.tabSettings.Controls.Add(this.metroSetDivider6);
            this.tabSettings.Controls.Add(this.metroSetDivider4);
            this.tabSettings.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabSettings.ImageIndex = 0;
            this.tabSettings.ImageKey = null;
            this.tabSettings.Location = new System.Drawing.Point(4, 42);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(307, 347);
            this.tabSettings.Style = MetroSet_UI.Design.Style.Light;
            this.tabSettings.StyleManager = null;
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.ThemeAuthor = "Narwin";
            this.tabSettings.ThemeName = "MetroLite";
            this.tabSettings.ToolTipText = null;
            // 
            // metroSetLabel19
            // 
            this.metroSetLabel19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel19.Location = new System.Drawing.Point(0, 317);
            this.metroSetLabel19.Name = "metroSetLabel19";
            this.metroSetLabel19.Size = new System.Drawing.Size(307, 34);
            this.metroSetLabel19.Style = MetroSet_UI.Design.Style.Custom;
            this.metroSetLabel19.StyleManager = null;
            this.metroSetLabel19.TabIndex = 15;
            this.metroSetLabel19.Text = "© 2020 Endix Development. All images used as well as XAMPP itself belong to their" +
    " corresponding company or organisation.";
            this.metroSetLabel19.ThemeAuthor = "Narwin";
            this.metroSetLabel19.ThemeName = "MetroLite";
            // 
            // chbAutostartTomcat
            // 
            this.chbAutostartTomcat.BackColor = System.Drawing.Color.Transparent;
            this.chbAutostartTomcat.BackgroundColor = System.Drawing.Color.White;
            this.chbAutostartTomcat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chbAutostartTomcat.Checked = false;
            this.chbAutostartTomcat.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbAutostartTomcat.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbAutostartTomcat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbAutostartTomcat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbAutostartTomcat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbAutostartTomcat.Location = new System.Drawing.Point(137, 284);
            this.chbAutostartTomcat.Name = "chbAutostartTomcat";
            this.chbAutostartTomcat.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.chbAutostartTomcat.Size = new System.Drawing.Size(75, 16);
            this.chbAutostartTomcat.Style = MetroSet_UI.Design.Style.Light;
            this.chbAutostartTomcat.StyleManager = null;
            this.chbAutostartTomcat.TabIndex = 14;
            this.chbAutostartTomcat.Text = "Tomcat";
            this.chbAutostartTomcat.ThemeAuthor = "Narwin";
            this.chbAutostartTomcat.ThemeName = "MetroLite";
            this.chbAutostartTomcat.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.UpdateAutostartService);
            // 
            // chbAutostartMercury
            // 
            this.chbAutostartMercury.BackColor = System.Drawing.Color.Transparent;
            this.chbAutostartMercury.BackgroundColor = System.Drawing.Color.White;
            this.chbAutostartMercury.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chbAutostartMercury.Checked = false;
            this.chbAutostartMercury.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbAutostartMercury.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbAutostartMercury.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbAutostartMercury.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbAutostartMercury.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbAutostartMercury.Location = new System.Drawing.Point(137, 260);
            this.chbAutostartMercury.Name = "chbAutostartMercury";
            this.chbAutostartMercury.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.chbAutostartMercury.Size = new System.Drawing.Size(75, 16);
            this.chbAutostartMercury.Style = MetroSet_UI.Design.Style.Light;
            this.chbAutostartMercury.StyleManager = null;
            this.chbAutostartMercury.TabIndex = 14;
            this.chbAutostartMercury.Text = "Mercury";
            this.chbAutostartMercury.ThemeAuthor = "Narwin";
            this.chbAutostartMercury.ThemeName = "MetroLite";
            this.chbAutostartMercury.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.UpdateAutostartService);
            // 
            // chbAutostartFileZilla
            // 
            this.chbAutostartFileZilla.BackColor = System.Drawing.Color.Transparent;
            this.chbAutostartFileZilla.BackgroundColor = System.Drawing.Color.White;
            this.chbAutostartFileZilla.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chbAutostartFileZilla.Checked = false;
            this.chbAutostartFileZilla.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbAutostartFileZilla.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbAutostartFileZilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbAutostartFileZilla.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbAutostartFileZilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbAutostartFileZilla.Location = new System.Drawing.Point(137, 236);
            this.chbAutostartFileZilla.Name = "chbAutostartFileZilla";
            this.chbAutostartFileZilla.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.chbAutostartFileZilla.Size = new System.Drawing.Size(75, 16);
            this.chbAutostartFileZilla.Style = MetroSet_UI.Design.Style.Light;
            this.chbAutostartFileZilla.StyleManager = null;
            this.chbAutostartFileZilla.TabIndex = 14;
            this.chbAutostartFileZilla.Text = "FileZilla";
            this.chbAutostartFileZilla.ThemeAuthor = "Narwin";
            this.chbAutostartFileZilla.ThemeName = "MetroLite";
            this.chbAutostartFileZilla.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.UpdateAutostartService);
            // 
            // chbAutostartMySQL
            // 
            this.chbAutostartMySQL.BackColor = System.Drawing.Color.Transparent;
            this.chbAutostartMySQL.BackgroundColor = System.Drawing.Color.White;
            this.chbAutostartMySQL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chbAutostartMySQL.Checked = false;
            this.chbAutostartMySQL.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbAutostartMySQL.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbAutostartMySQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbAutostartMySQL.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbAutostartMySQL.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbAutostartMySQL.Location = new System.Drawing.Point(137, 212);
            this.chbAutostartMySQL.Name = "chbAutostartMySQL";
            this.chbAutostartMySQL.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.chbAutostartMySQL.Size = new System.Drawing.Size(75, 16);
            this.chbAutostartMySQL.Style = MetroSet_UI.Design.Style.Light;
            this.chbAutostartMySQL.StyleManager = null;
            this.chbAutostartMySQL.TabIndex = 14;
            this.chbAutostartMySQL.Text = "MySQL";
            this.chbAutostartMySQL.ThemeAuthor = "Narwin";
            this.chbAutostartMySQL.ThemeName = "MetroLite";
            this.chbAutostartMySQL.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.UpdateAutostartService);
            // 
            // chbAutostartApache
            // 
            this.chbAutostartApache.BackColor = System.Drawing.Color.Transparent;
            this.chbAutostartApache.BackgroundColor = System.Drawing.Color.White;
            this.chbAutostartApache.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.chbAutostartApache.Checked = false;
            this.chbAutostartApache.CheckSignColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbAutostartApache.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbAutostartApache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbAutostartApache.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbAutostartApache.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.chbAutostartApache.Location = new System.Drawing.Point(137, 188);
            this.chbAutostartApache.Name = "chbAutostartApache";
            this.chbAutostartApache.SignStyle = MetroSet_UI.Enums.SignStyle.Sign;
            this.chbAutostartApache.Size = new System.Drawing.Size(75, 16);
            this.chbAutostartApache.Style = MetroSet_UI.Design.Style.Light;
            this.chbAutostartApache.StyleManager = null;
            this.chbAutostartApache.TabIndex = 14;
            this.chbAutostartApache.Text = "Apache";
            this.chbAutostartApache.ThemeAuthor = "Narwin";
            this.chbAutostartApache.ThemeName = "MetroLite";
            this.chbAutostartApache.CheckedChanged += new MetroSet_UI.Controls.MetroSetCheckBox.CheckedChangedEventHandler(this.UpdateAutostartService);
            // 
            // btnSelectDefaultEditor
            // 
            this.btnSelectDefaultEditor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSelectDefaultEditor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSelectDefaultEditor.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSelectDefaultEditor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSelectDefaultEditor.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSelectDefaultEditor.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSelectDefaultEditor.HoverTextColor = System.Drawing.Color.White;
            this.btnSelectDefaultEditor.Location = new System.Drawing.Point(274, 141);
            this.btnSelectDefaultEditor.Name = "btnSelectDefaultEditor";
            this.btnSelectDefaultEditor.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSelectDefaultEditor.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSelectDefaultEditor.NormalTextColor = System.Drawing.Color.White;
            this.btnSelectDefaultEditor.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSelectDefaultEditor.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSelectDefaultEditor.PressTextColor = System.Drawing.Color.White;
            this.btnSelectDefaultEditor.Size = new System.Drawing.Size(30, 29);
            this.btnSelectDefaultEditor.Style = MetroSet_UI.Design.Style.Light;
            this.btnSelectDefaultEditor.StyleManager = null;
            this.btnSelectDefaultEditor.TabIndex = 13;
            this.btnSelectDefaultEditor.Text = "...";
            this.btnSelectDefaultEditor.ThemeAuthor = "Narwin";
            this.btnSelectDefaultEditor.ThemeName = "MetroLite";
            this.btnSelectDefaultEditor.Click += new System.EventHandler(this.btnSelectDefaultEditor_Click);
            // 
            // btnSelectXamppInstallPath
            // 
            this.btnSelectXamppInstallPath.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSelectXamppInstallPath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSelectXamppInstallPath.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSelectXamppInstallPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSelectXamppInstallPath.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSelectXamppInstallPath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSelectXamppInstallPath.HoverTextColor = System.Drawing.Color.White;
            this.btnSelectXamppInstallPath.Location = new System.Drawing.Point(274, 68);
            this.btnSelectXamppInstallPath.Name = "btnSelectXamppInstallPath";
            this.btnSelectXamppInstallPath.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSelectXamppInstallPath.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSelectXamppInstallPath.NormalTextColor = System.Drawing.Color.White;
            this.btnSelectXamppInstallPath.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSelectXamppInstallPath.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSelectXamppInstallPath.PressTextColor = System.Drawing.Color.White;
            this.btnSelectXamppInstallPath.Size = new System.Drawing.Size(30, 29);
            this.btnSelectXamppInstallPath.Style = MetroSet_UI.Design.Style.Custom;
            this.btnSelectXamppInstallPath.StyleManager = null;
            this.btnSelectXamppInstallPath.TabIndex = 13;
            this.btnSelectXamppInstallPath.Text = "...";
            this.btnSelectXamppInstallPath.ThemeAuthor = "Narwin";
            this.btnSelectXamppInstallPath.ThemeName = "MetroLite";
            this.btnSelectXamppInstallPath.Click += new System.EventHandler(this.btnSelectXamppInstallPath_Click);
            // 
            // txbDefaultEditorPath
            // 
            this.txbDefaultEditorPath.AutoCompleteCustomSource = null;
            this.txbDefaultEditorPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbDefaultEditorPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbDefaultEditorPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbDefaultEditorPath.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbDefaultEditorPath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbDefaultEditorPath.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbDefaultEditorPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbDefaultEditorPath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbDefaultEditorPath.Image = null;
            this.txbDefaultEditorPath.Lines = null;
            this.txbDefaultEditorPath.Location = new System.Drawing.Point(0, 141);
            this.txbDefaultEditorPath.MaxLength = 32767;
            this.txbDefaultEditorPath.Multiline = false;
            this.txbDefaultEditorPath.Name = "txbDefaultEditorPath";
            this.txbDefaultEditorPath.ReadOnly = true;
            this.txbDefaultEditorPath.Size = new System.Drawing.Size(268, 29);
            this.txbDefaultEditorPath.Style = MetroSet_UI.Design.Style.Light;
            this.txbDefaultEditorPath.StyleManager = null;
            this.txbDefaultEditorPath.TabIndex = 12;
            this.txbDefaultEditorPath.Text = "notepad.exe";
            this.txbDefaultEditorPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbDefaultEditorPath.ThemeAuthor = "Narwin";
            this.txbDefaultEditorPath.ThemeName = "MetroLite";
            this.txbDefaultEditorPath.UseSystemPasswordChar = false;
            this.txbDefaultEditorPath.WatermarkText = "";
            // 
            // txbXamppInstallPath
            // 
            this.txbXamppInstallPath.AutoCompleteCustomSource = null;
            this.txbXamppInstallPath.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txbXamppInstallPath.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txbXamppInstallPath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbXamppInstallPath.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txbXamppInstallPath.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txbXamppInstallPath.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txbXamppInstallPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txbXamppInstallPath.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txbXamppInstallPath.Image = null;
            this.txbXamppInstallPath.Lines = null;
            this.txbXamppInstallPath.Location = new System.Drawing.Point(0, 68);
            this.txbXamppInstallPath.MaxLength = 32767;
            this.txbXamppInstallPath.Multiline = false;
            this.txbXamppInstallPath.Name = "txbXamppInstallPath";
            this.txbXamppInstallPath.ReadOnly = true;
            this.txbXamppInstallPath.Size = new System.Drawing.Size(268, 29);
            this.txbXamppInstallPath.Style = MetroSet_UI.Design.Style.Light;
            this.txbXamppInstallPath.StyleManager = null;
            this.txbXamppInstallPath.TabIndex = 12;
            this.txbXamppInstallPath.Text = "C:\\...";
            this.txbXamppInstallPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txbXamppInstallPath.ThemeAuthor = "Narwin";
            this.txbXamppInstallPath.ThemeName = "MetroLite";
            this.txbXamppInstallPath.UseSystemPasswordChar = false;
            this.txbXamppInstallPath.WatermarkText = "";
            // 
            // metroSetLabel18
            // 
            this.metroSetLabel18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel18.Location = new System.Drawing.Point(0, 188);
            this.metroSetLabel18.Name = "metroSetLabel18";
            this.metroSetLabel18.Size = new System.Drawing.Size(131, 23);
            this.metroSetLabel18.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel18.StyleManager = null;
            this.metroSetLabel18.TabIndex = 11;
            this.metroSetLabel18.Text = "Autostart Services:";
            this.metroSetLabel18.ThemeAuthor = "Narwin";
            this.metroSetLabel18.ThemeName = "MetroLite";
            // 
            // metroSetLabel17
            // 
            this.metroSetLabel17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel17.Location = new System.Drawing.Point(0, 42);
            this.metroSetLabel17.Name = "metroSetLabel17";
            this.metroSetLabel17.Size = new System.Drawing.Size(169, 23);
            this.metroSetLabel17.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel17.StyleManager = null;
            this.metroSetLabel17.TabIndex = 10;
            this.metroSetLabel17.Text = "XAMPP Installation Path:";
            this.metroSetLabel17.ThemeAuthor = "Narwin";
            this.metroSetLabel17.ThemeName = "MetroLite";
            // 
            // metroSetLabel16
            // 
            this.metroSetLabel16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel16.Location = new System.Drawing.Point(0, 115);
            this.metroSetLabel16.Name = "metroSetLabel16";
            this.metroSetLabel16.Size = new System.Drawing.Size(169, 23);
            this.metroSetLabel16.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel16.StyleManager = null;
            this.metroSetLabel16.TabIndex = 9;
            this.metroSetLabel16.Text = "Default Text-Editor:";
            this.metroSetLabel16.ThemeAuthor = "Narwin";
            this.metroSetLabel16.ThemeName = "MetroLite";
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metroSetLabel6.Location = new System.Drawing.Point(0, 9);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(307, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 8;
            this.metroSetLabel6.Text = "Settings";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // metroSetDivider8
            // 
            this.metroSetDivider8.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetDivider8.Location = new System.Drawing.Point(0, 306);
            this.metroSetDivider8.Name = "metroSetDivider8";
            this.metroSetDivider8.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider8.Size = new System.Drawing.Size(311, 4);
            this.metroSetDivider8.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetDivider8.StyleManager = null;
            this.metroSetDivider8.TabIndex = 7;
            this.metroSetDivider8.Text = "metroSetDivider4";
            this.metroSetDivider8.ThemeAuthor = "Narwin";
            this.metroSetDivider8.ThemeName = "MetroDark";
            this.metroSetDivider8.Thickness = 1;
            // 
            // metroSetDivider7
            // 
            this.metroSetDivider7.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetDivider7.Location = new System.Drawing.Point(-4, 178);
            this.metroSetDivider7.Name = "metroSetDivider7";
            this.metroSetDivider7.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider7.Size = new System.Drawing.Size(311, 4);
            this.metroSetDivider7.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetDivider7.StyleManager = null;
            this.metroSetDivider7.TabIndex = 7;
            this.metroSetDivider7.Text = "metroSetDivider4";
            this.metroSetDivider7.ThemeAuthor = "Narwin";
            this.metroSetDivider7.ThemeName = "MetroDark";
            this.metroSetDivider7.Thickness = 1;
            // 
            // metroSetDivider6
            // 
            this.metroSetDivider6.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetDivider6.Location = new System.Drawing.Point(-4, 105);
            this.metroSetDivider6.Name = "metroSetDivider6";
            this.metroSetDivider6.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider6.Size = new System.Drawing.Size(311, 4);
            this.metroSetDivider6.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetDivider6.StyleManager = null;
            this.metroSetDivider6.TabIndex = 7;
            this.metroSetDivider6.Text = "metroSetDivider4";
            this.metroSetDivider6.ThemeAuthor = "Narwin";
            this.metroSetDivider6.ThemeName = "MetroDark";
            this.metroSetDivider6.Thickness = 1;
            // 
            // metroSetDivider4
            // 
            this.metroSetDivider4.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetDivider4.Location = new System.Drawing.Point(0, 31);
            this.metroSetDivider4.Name = "metroSetDivider4";
            this.metroSetDivider4.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider4.Size = new System.Drawing.Size(311, 4);
            this.metroSetDivider4.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetDivider4.StyleManager = null;
            this.metroSetDivider4.TabIndex = 7;
            this.metroSetDivider4.Text = "metroSetDivider4";
            this.metroSetDivider4.ThemeAuthor = "Narwin";
            this.metroSetDivider4.ThemeName = "MetroDark";
            this.metroSetDivider4.Thickness = 1;
            // 
            // btnStopServices
            // 
            this.btnStopServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStopServices.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnStopServices.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnStopServices.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnStopServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStopServices.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStopServices.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStopServices.HoverTextColor = System.Drawing.Color.White;
            this.btnStopServices.Location = new System.Drawing.Point(172, 411);
            this.btnStopServices.Name = "btnStopServices";
            this.btnStopServices.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStopServices.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStopServices.NormalTextColor = System.Drawing.Color.White;
            this.btnStopServices.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStopServices.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStopServices.PressTextColor = System.Drawing.Color.White;
            this.btnStopServices.Size = new System.Drawing.Size(155, 38);
            this.btnStopServices.Style = MetroSet_UI.Design.Style.Custom;
            this.btnStopServices.StyleManager = null;
            this.btnStopServices.TabIndex = 0;
            this.btnStopServices.Text = "Stop Services";
            this.btnStopServices.ThemeAuthor = "Narwin";
            this.btnStopServices.ThemeName = "MetroDark";
            this.btnStopServices.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.btnStopServices.Click += new System.EventHandler(this.btnStopServices_Click);
            // 
            // btnStartServices
            // 
            this.btnStartServices.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartServices.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnStartServices.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnStartServices.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnStartServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStartServices.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStartServices.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnStartServices.HoverTextColor = System.Drawing.Color.White;
            this.btnStartServices.Location = new System.Drawing.Point(12, 411);
            this.btnStartServices.Name = "btnStartServices";
            this.btnStartServices.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartServices.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartServices.NormalTextColor = System.Drawing.Color.White;
            this.btnStartServices.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStartServices.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnStartServices.PressTextColor = System.Drawing.Color.White;
            this.btnStartServices.Size = new System.Drawing.Size(155, 38);
            this.btnStartServices.Style = MetroSet_UI.Design.Style.Custom;
            this.btnStartServices.StyleManager = null;
            this.btnStartServices.TabIndex = 0;
            this.btnStartServices.Text = "Start Services";
            this.btnStartServices.ThemeAuthor = "Narwin";
            this.btnStartServices.ThemeName = "MetroDark";
            this.btnStartServices.TileAlign = MetroSet_UI.Enums.TileAlign.BottomRight;
            this.btnStartServices.Click += new System.EventHandler(this.btnStartServices_Click);
            // 
            // btnStartServicesColor
            // 
            this.btnStartServicesColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStartServicesColor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStartServicesColor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnStartServicesColor.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnStartServicesColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStartServicesColor.HoverBorderColor = System.Drawing.Color.Lime;
            this.btnStartServicesColor.HoverColor = System.Drawing.Color.Lime;
            this.btnStartServicesColor.HoverTextColor = System.Drawing.Color.White;
            this.btnStartServicesColor.Location = new System.Drawing.Point(12, 411);
            this.btnStartServicesColor.Name = "btnStartServicesColor";
            this.btnStartServicesColor.NormalBorderColor = System.Drawing.Color.Lime;
            this.btnStartServicesColor.NormalColor = System.Drawing.Color.Lime;
            this.btnStartServicesColor.NormalTextColor = System.Drawing.Color.White;
            this.btnStartServicesColor.PressBorderColor = System.Drawing.Color.Lime;
            this.btnStartServicesColor.PressColor = System.Drawing.Color.Lime;
            this.btnStartServicesColor.PressTextColor = System.Drawing.Color.White;
            this.btnStartServicesColor.Size = new System.Drawing.Size(25, 38);
            this.btnStartServicesColor.Style = MetroSet_UI.Design.Style.Custom;
            this.btnStartServicesColor.StyleManager = null;
            this.btnStartServicesColor.TabIndex = 0;
            this.btnStartServicesColor.ThemeAuthor = "Narwin";
            this.btnStartServicesColor.ThemeName = "MetroLite";
            this.btnStartServicesColor.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.btnStartServicesColor.Click += new System.EventHandler(this.btnStartServices_Click);
            // 
            // btnStopServicesColor
            // 
            this.btnStopServicesColor.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStopServicesColor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStopServicesColor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnStopServicesColor.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnStopServicesColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStopServicesColor.HoverBorderColor = System.Drawing.Color.Red;
            this.btnStopServicesColor.HoverColor = System.Drawing.Color.Red;
            this.btnStopServicesColor.HoverTextColor = System.Drawing.Color.White;
            this.btnStopServicesColor.Location = new System.Drawing.Point(302, 411);
            this.btnStopServicesColor.Name = "btnStopServicesColor";
            this.btnStopServicesColor.NormalBorderColor = System.Drawing.Color.Red;
            this.btnStopServicesColor.NormalColor = System.Drawing.Color.Red;
            this.btnStopServicesColor.NormalTextColor = System.Drawing.Color.White;
            this.btnStopServicesColor.PressBorderColor = System.Drawing.Color.Red;
            this.btnStopServicesColor.PressColor = System.Drawing.Color.Red;
            this.btnStopServicesColor.PressTextColor = System.Drawing.Color.White;
            this.btnStopServicesColor.Size = new System.Drawing.Size(25, 38);
            this.btnStopServicesColor.Style = MetroSet_UI.Design.Style.Custom;
            this.btnStopServicesColor.StyleManager = null;
            this.btnStopServicesColor.TabIndex = 0;
            this.btnStopServicesColor.ThemeAuthor = "Narwin";
            this.btnStopServicesColor.ThemeName = "MetroLite";
            this.btnStopServicesColor.TileAlign = MetroSet_UI.Enums.TileAlign.BottmLeft;
            this.btnStopServicesColor.Click += new System.EventHandler(this.btnStopServices_Click);
            // 
            // cmsApacheConfig
            // 
            this.cmsApacheConfig.BackColor = System.Drawing.SystemColors.Control;
            this.cmsApacheConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmApacheConfig,
            this.tsmApacheSSLConfig,
            this.tslApacheXamppConfig,
            this.tslPhpConfig,
            this.tslPhpMyAdminConfig,
            this.toolStripSeparator1,
            this.tslBrowseApache,
            this.tslBrowsePhp,
            this.tslBrowsePhpMyAdmin,
            this.toolStripSeparator6,
            this.toolStripMenuItem1});
            this.cmsApacheConfig.Name = "cmsApacheConfig";
            this.cmsApacheConfig.Size = new System.Drawing.Size(227, 214);
            this.cmsApacheConfig.Style = MetroSet_UI.Design.Style.Custom;
            this.cmsApacheConfig.StyleManager = null;
            this.cmsApacheConfig.ThemeAuthor = "Narwin";
            this.cmsApacheConfig.ThemeName = "MetroLite";
            // 
            // tsmApacheConfig
            // 
            this.tsmApacheConfig.BackColor = System.Drawing.SystemColors.Control;
            this.tsmApacheConfig.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsmApacheConfig.ForeColor = System.Drawing.Color.Black;
            this.tsmApacheConfig.Name = "tsmApacheConfig";
            this.tsmApacheConfig.Size = new System.Drawing.Size(226, 22);
            this.tsmApacheConfig.Text = "Apache (httpd.conf)";
            this.tsmApacheConfig.Click += new System.EventHandler(this.tsmApacheConfig_Click);
            // 
            // tsmApacheSSLConfig
            // 
            this.tsmApacheSSLConfig.ForeColor = System.Drawing.Color.Black;
            this.tsmApacheSSLConfig.Name = "tsmApacheSSLConfig";
            this.tsmApacheSSLConfig.Size = new System.Drawing.Size(226, 22);
            this.tsmApacheSSLConfig.Text = "Apache (httpd-ssl.conf)";
            this.tsmApacheSSLConfig.Click += new System.EventHandler(this.tsmApacheSSLConfig_Click);
            // 
            // tslApacheXamppConfig
            // 
            this.tslApacheXamppConfig.ForeColor = System.Drawing.Color.Black;
            this.tslApacheXamppConfig.Name = "tslApacheXamppConfig";
            this.tslApacheXamppConfig.Size = new System.Drawing.Size(226, 22);
            this.tslApacheXamppConfig.Text = "Apache (httpd-xampp.conf)";
            this.tslApacheXamppConfig.Click += new System.EventHandler(this.tslApacheXamppConfig_Click);
            // 
            // tslPhpConfig
            // 
            this.tslPhpConfig.ForeColor = System.Drawing.Color.Black;
            this.tslPhpConfig.Name = "tslPhpConfig";
            this.tslPhpConfig.Size = new System.Drawing.Size(226, 22);
            this.tslPhpConfig.Text = "PHP (php.ini)";
            this.tslPhpConfig.Click += new System.EventHandler(this.tslPhpConfig_Click);
            // 
            // tslPhpMyAdminConfig
            // 
            this.tslPhpMyAdminConfig.ForeColor = System.Drawing.Color.Black;
            this.tslPhpMyAdminConfig.Name = "tslPhpMyAdminConfig";
            this.tslPhpMyAdminConfig.Size = new System.Drawing.Size(226, 22);
            this.tslPhpMyAdminConfig.Text = "phpMyAdmin (php.inc.conf)";
            this.tslPhpMyAdminConfig.Click += new System.EventHandler(this.tslPhpMyAdminConfig_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(223, 6);
            // 
            // tslBrowseApache
            // 
            this.tslBrowseApache.ForeColor = System.Drawing.Color.Black;
            this.tslBrowseApache.Name = "tslBrowseApache";
            this.tslBrowseApache.Size = new System.Drawing.Size(226, 22);
            this.tslBrowseApache.Text = "<Browse> [Apache]";
            this.tslBrowseApache.Click += new System.EventHandler(this.tslBrowseApache_Click);
            // 
            // tslBrowsePhp
            // 
            this.tslBrowsePhp.ForeColor = System.Drawing.Color.Black;
            this.tslBrowsePhp.Name = "tslBrowsePhp";
            this.tslBrowsePhp.Size = new System.Drawing.Size(226, 22);
            this.tslBrowsePhp.Text = "<Browse> [PHP]";
            this.tslBrowsePhp.Click += new System.EventHandler(this.tslBrowsePhp_Click);
            // 
            // tslBrowsePhpMyAdmin
            // 
            this.tslBrowsePhpMyAdmin.ForeColor = System.Drawing.Color.Black;
            this.tslBrowsePhpMyAdmin.Name = "tslBrowsePhpMyAdmin";
            this.tslBrowsePhpMyAdmin.Size = new System.Drawing.Size(226, 22);
            this.tslBrowsePhpMyAdmin.Text = "<Browse> [phpMyAdmin]";
            this.tslBrowsePhpMyAdmin.Click += new System.EventHandler(this.tslBrowsePhpMyAdmin_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(223, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLogApacheAccess,
            this.tslLogApacheError,
            this.tslLogPhpError,
            this.toolStripSeparator7,
            this.tslLogBrowseApache,
            this.tslLogBrowsePHP});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(226, 22);
            this.toolStripMenuItem1.Text = "Logs";
            // 
            // tslLogApacheAccess
            // 
            this.tslLogApacheAccess.Name = "tslLogApacheAccess";
            this.tslLogApacheAccess.Size = new System.Drawing.Size(181, 22);
            this.tslLogApacheAccess.Text = "Apache (access.log)";
            this.tslLogApacheAccess.Click += new System.EventHandler(this.tslLogApacheAccess_Click);
            // 
            // tslLogApacheError
            // 
            this.tslLogApacheError.Name = "tslLogApacheError";
            this.tslLogApacheError.Size = new System.Drawing.Size(181, 22);
            this.tslLogApacheError.Text = "Apache (error.log)";
            this.tslLogApacheError.Click += new System.EventHandler(this.tslLogApacheError_Click);
            // 
            // tslLogPhpError
            // 
            this.tslLogPhpError.Name = "tslLogPhpError";
            this.tslLogPhpError.Size = new System.Drawing.Size(181, 22);
            this.tslLogPhpError.Text = "PHP (php_error_log)";
            this.tslLogPhpError.Click += new System.EventHandler(this.tslLogPhpError_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(178, 6);
            // 
            // tslLogBrowseApache
            // 
            this.tslLogBrowseApache.Name = "tslLogBrowseApache";
            this.tslLogBrowseApache.Size = new System.Drawing.Size(181, 22);
            this.tslLogBrowseApache.Text = "<Browse> [Aoache]";
            this.tslLogBrowseApache.Click += new System.EventHandler(this.tslLogBrowseApache_Click);
            // 
            // tslLogBrowsePHP
            // 
            this.tslLogBrowsePHP.Name = "tslLogBrowsePHP";
            this.tslLogBrowsePHP.Size = new System.Drawing.Size(181, 22);
            this.tslLogBrowsePHP.Text = "<Browse> [PHP]";
            this.tslLogBrowsePHP.Click += new System.EventHandler(this.tslLogBrowsePHP_Click);
            // 
            // cmsMySQLConfig
            // 
            this.cmsMySQLConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslMySQLConfig,
            this.toolStripSeparator2,
            this.tslBrowseMySQL,
            this.toolStripSeparator8,
            this.logsToolStripMenuItem});
            this.cmsMySQLConfig.Name = "cmsMySQLConfig";
            this.cmsMySQLConfig.Size = new System.Drawing.Size(129, 82);
            this.cmsMySQLConfig.Style = MetroSet_UI.Design.Style.Custom;
            this.cmsMySQLConfig.StyleManager = null;
            this.cmsMySQLConfig.ThemeAuthor = "Narwin";
            this.cmsMySQLConfig.ThemeName = "MetroLite";
            // 
            // tslMySQLConfig
            // 
            this.tslMySQLConfig.Name = "tslMySQLConfig";
            this.tslMySQLConfig.Size = new System.Drawing.Size(128, 22);
            this.tslMySQLConfig.Text = "my.ini";
            this.tslMySQLConfig.Click += new System.EventHandler(this.tslMySQLConfig_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(125, 6);
            // 
            // tslBrowseMySQL
            // 
            this.tslBrowseMySQL.Name = "tslBrowseMySQL";
            this.tslBrowseMySQL.Size = new System.Drawing.Size(128, 22);
            this.tslBrowseMySQL.Text = "<Browse>";
            this.tslBrowseMySQL.Click += new System.EventHandler(this.tslBrowseMySQL_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(125, 6);
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLogMysqlError,
            this.toolStripSeparator9,
            this.tslLogBrowseMySQL});
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(128, 22);
            this.logsToolStripMenuItem.Text = "Logs";
            // 
            // tslLogMysqlError
            // 
            this.tslLogMysqlError.Name = "tslLogMysqlError";
            this.tslLogMysqlError.Size = new System.Drawing.Size(156, 22);
            this.tslLogMysqlError.Text = "mysql_error.log";
            this.tslLogMysqlError.Click += new System.EventHandler(this.tslLogMysqlError_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(153, 6);
            // 
            // tslLogBrowseMySQL
            // 
            this.tslLogBrowseMySQL.Name = "tslLogBrowseMySQL";
            this.tslLogBrowseMySQL.Size = new System.Drawing.Size(156, 22);
            this.tslLogBrowseMySQL.Text = "<Browse>";
            this.tslLogBrowseMySQL.Click += new System.EventHandler(this.tslLogBrowseMySQL_Click);
            // 
            // cmsFileZillaConfig
            // 
            this.cmsFileZillaConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslFileZillaConfig,
            this.toolStripSeparator3,
            this.tslBrowseFileZilla});
            this.cmsFileZillaConfig.Name = "cmsFileZillaConfig";
            this.cmsFileZillaConfig.Size = new System.Drawing.Size(173, 54);
            this.cmsFileZillaConfig.Style = MetroSet_UI.Design.Style.Custom;
            this.cmsFileZillaConfig.StyleManager = null;
            this.cmsFileZillaConfig.ThemeAuthor = "Narwin";
            this.cmsFileZillaConfig.ThemeName = "MetroLite";
            // 
            // tslFileZillaConfig
            // 
            this.tslFileZillaConfig.Name = "tslFileZillaConfig";
            this.tslFileZillaConfig.Size = new System.Drawing.Size(172, 22);
            this.tslFileZillaConfig.Text = "FileZilla Server.xml";
            this.tslFileZillaConfig.Click += new System.EventHandler(this.tslFileZillaConfig_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(169, 6);
            // 
            // tslBrowseFileZilla
            // 
            this.tslBrowseFileZilla.Name = "tslBrowseFileZilla";
            this.tslBrowseFileZilla.Size = new System.Drawing.Size(172, 22);
            this.tslBrowseFileZilla.Text = "<Browse>";
            this.tslBrowseFileZilla.Click += new System.EventHandler(this.tslBrowseFileZilla_Click);
            // 
            // cmsMercuryConfig
            // 
            this.cmsMercuryConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslMercuryConfig,
            this.toolStripSeparator4,
            this.tslBrowseMercury,
            this.toolStripSeparator11,
            this.logsToolStripMenuItem2});
            this.cmsMercuryConfig.Name = "cmsMercuryConfig";
            this.cmsMercuryConfig.Size = new System.Drawing.Size(135, 82);
            this.cmsMercuryConfig.Style = MetroSet_UI.Design.Style.Custom;
            this.cmsMercuryConfig.StyleManager = null;
            this.cmsMercuryConfig.ThemeAuthor = "Narwin";
            this.cmsMercuryConfig.ThemeName = "MetroLite";
            // 
            // tslMercuryConfig
            // 
            this.tslMercuryConfig.Name = "tslMercuryConfig";
            this.tslMercuryConfig.Size = new System.Drawing.Size(134, 22);
            this.tslMercuryConfig.Text = "mercury.ini";
            this.tslMercuryConfig.Click += new System.EventHandler(this.tslMercuryConfig_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(131, 6);
            // 
            // tslBrowseMercury
            // 
            this.tslBrowseMercury.Name = "tslBrowseMercury";
            this.tslBrowseMercury.Size = new System.Drawing.Size(134, 22);
            this.tslBrowseMercury.Text = "<Browse>";
            this.tslBrowseMercury.Click += new System.EventHandler(this.tslBrowseMercury_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(131, 6);
            // 
            // logsToolStripMenuItem2
            // 
            this.logsToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLogBrowseMercury});
            this.logsToolStripMenuItem2.Name = "logsToolStripMenuItem2";
            this.logsToolStripMenuItem2.Size = new System.Drawing.Size(134, 22);
            this.logsToolStripMenuItem2.Text = "Logs";
            // 
            // tslLogBrowseMercury
            // 
            this.tslLogBrowseMercury.Name = "tslLogBrowseMercury";
            this.tslLogBrowseMercury.Size = new System.Drawing.Size(128, 22);
            this.tslLogBrowseMercury.Text = "<Browse>";
            this.tslLogBrowseMercury.Click += new System.EventHandler(this.tslLogBrowseMercury_Click);
            // 
            // cmsTomcatConfig
            // 
            this.cmsTomcatConfig.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslTomcatConfig,
            this.tslTomcatUsers,
            this.tslTomcatWeb,
            this.tslTomcatContext,
            this.toolStripSeparator5,
            this.tslBrowseTomcat,
            this.toolStripSeparator10,
            this.logsToolStripMenuItem1});
            this.cmsTomcatConfig.Name = "cmsTomcatConfig";
            this.cmsTomcatConfig.Size = new System.Drawing.Size(168, 148);
            this.cmsTomcatConfig.Style = MetroSet_UI.Design.Style.Custom;
            this.cmsTomcatConfig.StyleManager = null;
            this.cmsTomcatConfig.ThemeAuthor = "Narwin";
            this.cmsTomcatConfig.ThemeName = "MetroLite";
            // 
            // tslTomcatConfig
            // 
            this.tslTomcatConfig.Name = "tslTomcatConfig";
            this.tslTomcatConfig.Size = new System.Drawing.Size(167, 22);
            this.tslTomcatConfig.Text = "server.xml";
            this.tslTomcatConfig.Click += new System.EventHandler(this.tslTomcatConfig_Click);
            // 
            // tslTomcatUsers
            // 
            this.tslTomcatUsers.Name = "tslTomcatUsers";
            this.tslTomcatUsers.Size = new System.Drawing.Size(167, 22);
            this.tslTomcatUsers.Text = "tomcat-users.xml";
            this.tslTomcatUsers.Click += new System.EventHandler(this.tslTomcatUsers_Click);
            // 
            // tslTomcatWeb
            // 
            this.tslTomcatWeb.Name = "tslTomcatWeb";
            this.tslTomcatWeb.Size = new System.Drawing.Size(167, 22);
            this.tslTomcatWeb.Text = "web.xml";
            this.tslTomcatWeb.Click += new System.EventHandler(this.tslTomcatWeb_Click);
            // 
            // tslTomcatContext
            // 
            this.tslTomcatContext.Name = "tslTomcatContext";
            this.tslTomcatContext.Size = new System.Drawing.Size(167, 22);
            this.tslTomcatContext.Text = "context.xml";
            this.tslTomcatContext.Click += new System.EventHandler(this.tslTomcatContext_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(164, 6);
            // 
            // tslBrowseTomcat
            // 
            this.tslBrowseTomcat.Name = "tslBrowseTomcat";
            this.tslBrowseTomcat.Size = new System.Drawing.Size(167, 22);
            this.tslBrowseTomcat.Text = "<Browse>";
            this.tslBrowseTomcat.Click += new System.EventHandler(this.tslBrowseTomcat_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(164, 6);
            // 
            // logsToolStripMenuItem1
            // 
            this.logsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tslLogBrowseTomcat});
            this.logsToolStripMenuItem1.Name = "logsToolStripMenuItem1";
            this.logsToolStripMenuItem1.Size = new System.Drawing.Size(167, 22);
            this.logsToolStripMenuItem1.Text = "Logs";
            // 
            // tslLogBrowseTomcat
            // 
            this.tslLogBrowseTomcat.Name = "tslLogBrowseTomcat";
            this.tslLogBrowseTomcat.Size = new System.Drawing.Size(128, 22);
            this.tslLogBrowseTomcat.Text = "<Browse>";
            this.tslLogBrowseTomcat.Click += new System.EventHandler(this.tslLogBrowseTomcat_Click);
            // 
            // ofdFileSelector
            // 
            this.ofdFileSelector.DefaultExt = "exe";
            this.ofdFileSelector.Filter = "Executables|*.exe|All Files|*.*";
            this.ofdFileSelector.InitialDirectory = "C:\\";
            this.ofdFileSelector.Title = "Select your prefered default editor";
            // 
            // fbdFolderSelector
            // 
            this.fbdFolderSelector.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.fbdFolderSelector.SelectedPath = "C:\\";
            this.fbdFolderSelector.ShowNewFolderButton = false;
            // 
            // tmrCheckServiceStatus
            // 
            this.tmrCheckServiceStatus.Enabled = true;
            this.tmrCheckServiceStatus.Interval = 2000;
            this.tmrCheckServiceStatus.Tick += new System.EventHandler(this.tmrCheckServiceStatus_Tick);
            // 
            // lbcProjectList
            // 
            this.lbcProjectList.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbcProjectList.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbcProjectList.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lbcProjectList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbcProjectList.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.lbcProjectList.HoveredItemColor = System.Drawing.Color.DimGray;
            this.lbcProjectList.ItemHeight = 30;
            this.lbcProjectList.Location = new System.Drawing.Point(0, 92);
            this.lbcProjectList.MultiSelect = false;
            this.lbcProjectList.Name = "lbcProjectList";
            this.lbcProjectList.SelectedIndex = -1;
            this.lbcProjectList.SelectedItem = null;
            this.lbcProjectList.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lbcProjectList.SelectedItemColor = System.Drawing.Color.White;
            this.lbcProjectList.SelectedValue = null;
            this.lbcProjectList.ShowBorder = false;
            this.lbcProjectList.ShowScrollBar = false;
            this.lbcProjectList.Size = new System.Drawing.Size(307, 171);
            this.lbcProjectList.Style = MetroSet_UI.Design.Style.Dark;
            this.lbcProjectList.StyleManager = null;
            this.lbcProjectList.TabIndex = 12;
            this.lbcProjectList.ThemeAuthor = "Narwin";
            this.lbcProjectList.ThemeName = "MetroDark";
            // 
            // XPSMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 461);
            this.Controls.Add(this.btnStopServicesColor);
            this.Controls.Add(this.btnStartServicesColor);
            this.Controls.Add(this.btnStartServices);
            this.Controls.Add(this.btnStopServices);
            this.Controls.Add(this.tctTabMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "XPSMain";
            this.Text = "XAMPP Project Selector - XPS3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.XPSMain_FormClosing);
            this.Load += new System.EventHandler(this.XPSMain_Load);
            this.tctTabMenu.ResumeLayout(false);
            this.tabProjects.ResumeLayout(false);
            this.tabServices.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbxTomcatStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMercuryStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFileZillaStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMySQLStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxApacheStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoTomcat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoMercury)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoFileZilla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoMySQL)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoApache)).EndInit();
            this.tabManager.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.cmsApacheConfig.ResumeLayout(false);
            this.cmsMySQLConfig.ResumeLayout(false);
            this.cmsFileZillaConfig.ResumeLayout(false);
            this.cmsMercuryConfig.ResumeLayout(false);
            this.cmsTomcatConfig.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetTabControl tctTabMenu;
        private MetroSet_UI.Child.MetroSetTabPage tabProjects;
        private MetroSet_UI.Child.MetroSetTabPage tabServices;
        private MetroSet_UI.Child.MetroSetTabPage tabManager;
        private MetroSet_UI.Child.MetroSetTabPage tabSettings;
        private MetroSet_UI.Controls.MetroSetTile btnStopServices;
        private MetroSet_UI.Controls.MetroSetTile btnStartServices;
        private MetroSet_UI.Controls.MetroSetTile btnStartServicesColor;
        private MetroSet_UI.Controls.MetroSetTile btnStopServicesColor;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private MetroSet_UI.Controls.MetroSetTile btnHotSwitchP2;
        private MetroSet_UI.Controls.MetroSetLabel lblSelectedProject;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetComboBox cbxSavedProjects;
        private MetroSet_UI.Controls.MetroSetTile btnEditSelectedProject;
        private MetroSet_UI.Controls.MetroSetTile btnDeleteSelectedProject;
        private MetroSet_UI.Controls.MetroSetTile btnSeletProject;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel4;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider4;
        private MetroSet_UI.Controls.MetroSetTile btnHotSwitchP6;
        private MetroSet_UI.Controls.MetroSetTile btnHotSwitchP5;
        private MetroSet_UI.Controls.MetroSetTile btnHotSwitchP4;
        private MetroSet_UI.Controls.MetroSetTile btnHotSwitchP1;
        private MetroSet_UI.Controls.MetroSetTile btnHotSwitchP3;
        private System.Windows.Forms.PictureBox pbxLogoTomcat;
        private System.Windows.Forms.PictureBox pbxLogoMercury;
        private System.Windows.Forms.PictureBox pbxLogoFileZilla;
        private System.Windows.Forms.PictureBox pbxLogoMySQL;
        private System.Windows.Forms.PictureBox pbxLogoApache;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider5;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel10;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel9;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetSwitch chbServiceTomcat;
        private MetroSet_UI.Controls.MetroSetSwitch chbServiceFileZilla;
        private MetroSet_UI.Controls.MetroSetSwitch chbServiceMercury;
        private MetroSet_UI.Controls.MetroSetSwitch chbServiceMySQL;
        private MetroSet_UI.Controls.MetroSetSwitch chbServiceApache;
        private MetroSet_UI.Controls.MetroSetTile btnDisableAllServices;
        private MetroSet_UI.Controls.MetroSetTile btnEnableAllServices;
        private MetroSet_UI.Controls.MetroDefaultSetButton btnTomcatConfig;
        private MetroSet_UI.Controls.MetroDefaultSetButton btnMercuryConfig;
        private MetroSet_UI.Controls.MetroDefaultSetButton btnFileZillaConfig;
        private MetroSet_UI.Controls.MetroDefaultSetButton btnMySQLConfig;
        private MetroSet_UI.Controls.MetroDefaultSetButton btnApacheConfig;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip cmsApacheConfig;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip cmsMySQLConfig;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip cmsFileZillaConfig;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip cmsMercuryConfig;
        private MetroSet_UI.Controls.MetroSetContextMenuStrip cmsTomcatConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmApacheConfig;
        private System.Windows.Forms.ToolStripMenuItem tsmApacheSSLConfig;
        private System.Windows.Forms.ToolStripMenuItem tslApacheXamppConfig;
        private System.Windows.Forms.ToolStripMenuItem tslPhpConfig;
        private System.Windows.Forms.ToolStripMenuItem tslPhpMyAdminConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tslBrowseApache;
        private System.Windows.Forms.ToolStripMenuItem tslBrowsePhp;
        private System.Windows.Forms.ToolStripMenuItem tslBrowsePhpMyAdmin;
        private System.Windows.Forms.ToolStripMenuItem tslMySQLConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem tslBrowseMySQL;
        private System.Windows.Forms.ToolStripMenuItem tslFileZillaConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tslBrowseFileZilla;
        private System.Windows.Forms.ToolStripMenuItem tslMercuryConfig;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tslBrowseMercury;
        private System.Windows.Forms.ToolStripMenuItem tslTomcatConfig;
        private System.Windows.Forms.ToolStripMenuItem tslTomcatUsers;
        private System.Windows.Forms.ToolStripMenuItem tslTomcatWeb;
        private System.Windows.Forms.ToolStripMenuItem tslTomcatContext;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem tslBrowseTomcat;
        private MetroSet_UI.Controls.MetroSetCheckBox chbAutostartTomcat;
        private MetroSet_UI.Controls.MetroSetCheckBox chbAutostartMercury;
        private MetroSet_UI.Controls.MetroSetCheckBox chbAutostartFileZilla;
        private MetroSet_UI.Controls.MetroSetCheckBox chbAutostartMySQL;
        private MetroSet_UI.Controls.MetroSetCheckBox chbAutostartApache;
        private MetroSet_UI.Controls.MetroSetButton btnSelectDefaultEditor;
        private MetroSet_UI.Controls.MetroSetButton btnSelectXamppInstallPath;
        private MetroSet_UI.Controls.MetroSetTextBox txbDefaultEditorPath;
        private MetroSet_UI.Controls.MetroSetTextBox txbXamppInstallPath;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel18;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel17;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel16;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider7;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider6;
        private System.Windows.Forms.OpenFileDialog ofdFileSelector;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderSelector;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel19;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider8;
        private MetroSet_UI.Controls.MetroSetButton btnAddNewProject;
        private MetroSet_UI.Controls.MetroSetButton btnImportConfig;
        private MetroSet_UI.Controls.MetroSetButton btnExportConfig;
        private MetroSet_UI.Controls.MetroSetButton btnEditProject;
        private MetroSet_UI.Controls.MetroSetButton btnDeleteProject;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider9;
        private System.Windows.Forms.PictureBox pbxTomcatStatus;
        private System.Windows.Forms.PictureBox pbxMercuryStatus;
        private System.Windows.Forms.PictureBox pbxFileZillaStatus;
        private System.Windows.Forms.PictureBox pbxMySQLStatus;
        private System.Windows.Forms.PictureBox pbxApacheStatus;
        private System.Windows.Forms.Timer tmrCheckServiceStatus;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tslLogApacheAccess;
        private System.Windows.Forms.ToolStripMenuItem tslLogApacheError;
        private System.Windows.Forms.ToolStripMenuItem tslLogPhpError;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem tslLogBrowseApache;
        private System.Windows.Forms.ToolStripMenuItem tslLogBrowsePHP;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tslLogMysqlError;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripMenuItem tslLogBrowseMySQL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem tslLogBrowseMercury;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tslLogBrowseTomcat;
        private MetroSet_UI.Controls.MetroSetButton btnStartStopTomcat;
        private MetroSet_UI.Controls.MetroSetButton btnStartStopMercury;
        private MetroSet_UI.Controls.MetroSetButton btnStartStopFileZilla;
        private MetroSet_UI.Controls.MetroSetButton btnStartStopMySQL;
        private MetroSet_UI.Controls.MetroSetButton btnStartStopApache;
        private MetroSet_UI.Controls.MetroSetListBox lbcProjectList;
    }
}

