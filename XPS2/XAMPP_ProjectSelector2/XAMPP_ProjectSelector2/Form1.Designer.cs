namespace XAMPP_ProjectSelector2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabMain = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.cbxSavedProjects = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.btnManageProject = new MetroFramework.Controls.MetroTile();
            this.btnSelectProject = new MetroFramework.Controls.MetroTile();
            this.btnDeleteProject = new MetroFramework.Controls.MetroTile();
            this.btnHotSwitchP5 = new MetroFramework.Controls.MetroTile();
            this.btnHotSwitchP4 = new MetroFramework.Controls.MetroTile();
            this.btnHotSwitchP3 = new MetroFramework.Controls.MetroTile();
            this.btnHotSwitchP2 = new MetroFramework.Controls.MetroTile();
            this.btnHotSwitchP1 = new MetroFramework.Controls.MetroTile();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.btnToggleAllServicesOff = new MetroFramework.Controls.MetroTile();
            this.btnToggleAllServicesOn = new MetroFramework.Controls.MetroTile();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.chbServiceMySQL = new MetroFramework.Controls.MetroToggle();
            this.chbServiceFileZilla = new MetroFramework.Controls.MetroToggle();
            this.chbServiceMercury = new MetroFramework.Controls.MetroToggle();
            this.chbServiceTomcat = new MetroFramework.Controls.MetroToggle();
            this.chbServiceApache = new MetroFramework.Controls.MetroToggle();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.btnSelectRootDirectory = new MetroFramework.Controls.MetroButton();
            this.lblProjectRootPath = new MetroFramework.Controls.MetroLabel();
            this.txbProjectDescription = new MetroFramework.Controls.MetroTextBox();
            this.txbProjectTitle = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.btnCancel = new MetroFramework.Controls.MetroTile();
            this.btnSaveProject = new MetroFramework.Controls.MetroTile();
            this.btnAddNewProject = new MetroFramework.Controls.MetroTile();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.btnSelectInstallPath = new MetroFramework.Controls.MetroButton();
            this.lblXamppInstallPath = new MetroFramework.Controls.MetroLabel();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.btnStartServices = new MetroFramework.Controls.MetroTile();
            this.btnStopServices = new MetroFramework.Controls.MetroTile();
            this.lblClose = new MetroFramework.Controls.MetroLabel();
            this.lblMinimize = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.fbdInstallPath = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdRootPath = new System.Windows.Forms.FolderBrowserDialog();
            this.nicNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.tabMain.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.metroTabPage1);
            this.tabMain.Controls.Add(this.metroTabPage3);
            this.tabMain.Controls.Add(this.metroTabPage2);
            this.tabMain.Controls.Add(this.metroTabPage4);
            this.tabMain.Location = new System.Drawing.Point(1, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(400, 370);
            this.tabMain.TabIndex = 4;
            this.tabMain.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel15);
            this.metroTabPage1.Controls.Add(this.cbxSavedProjects);
            this.metroTabPage1.Controls.Add(this.metroLabel11);
            this.metroTabPage1.Controls.Add(this.metroLabel10);
            this.metroTabPage1.Controls.Add(this.btnManageProject);
            this.metroTabPage1.Controls.Add(this.btnSelectProject);
            this.metroTabPage1.Controls.Add(this.btnDeleteProject);
            this.metroTabPage1.Controls.Add(this.btnHotSwitchP5);
            this.metroTabPage1.Controls.Add(this.btnHotSwitchP4);
            this.metroTabPage1.Controls.Add(this.btnHotSwitchP3);
            this.metroTabPage1.Controls.Add(this.btnHotSwitchP2);
            this.metroTabPage1.Controls.Add(this.btnHotSwitchP1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(392, 328);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Projects";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.Location = new System.Drawing.Point(5, 17);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(142, 19);
            this.metroLabel15.TabIndex = 7;
            this.metroLabel15.Text = "Selected Project: None";
            // 
            // cbxSavedProjects
            // 
            this.cbxSavedProjects.FormattingEnabled = true;
            this.cbxSavedProjects.ItemHeight = 23;
            this.cbxSavedProjects.Location = new System.Drawing.Point(5, 187);
            this.cbxSavedProjects.Name = "cbxSavedProjects";
            this.cbxSavedProjects.Size = new System.Drawing.Size(384, 29);
            this.cbxSavedProjects.TabIndex = 6;
            this.cbxSavedProjects.UseSelectable = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(7, 165);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(101, 19);
            this.metroLabel11.TabIndex = 2;
            this.metroLabel11.Text = "Browse Projects";
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(5, 52);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(159, 19);
            this.metroLabel10.TabIndex = 2;
            this.metroLabel10.Text = "Recently Opened Projects";
            // 
            // btnManageProject
            // 
            this.btnManageProject.ActiveControl = null;
            this.btnManageProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnManageProject.Location = new System.Drawing.Point(199, 221);
            this.btnManageProject.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageProject.Name = "btnManageProject";
            this.btnManageProject.Size = new System.Drawing.Size(190, 65);
            this.btnManageProject.TabIndex = 5;
            this.btnManageProject.Text = "Manage Selected Project";
            this.btnManageProject.UseSelectable = true;
            this.btnManageProject.Click += new System.EventHandler(this.BtnManageProject_Click);
            // 
            // btnSelectProject
            // 
            this.btnSelectProject.ActiveControl = null;
            this.btnSelectProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectProject.Location = new System.Drawing.Point(5, 221);
            this.btnSelectProject.Margin = new System.Windows.Forms.Padding(0);
            this.btnSelectProject.Name = "btnSelectProject";
            this.btnSelectProject.Size = new System.Drawing.Size(190, 108);
            this.btnSelectProject.TabIndex = 5;
            this.btnSelectProject.Text = "Select Project";
            this.btnSelectProject.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectProject.UseSelectable = true;
            this.btnSelectProject.Click += new System.EventHandler(this.BtnSelectProject_Click);
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.ActiveControl = null;
            this.btnDeleteProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteProject.Location = new System.Drawing.Point(199, 289);
            this.btnDeleteProject.Margin = new System.Windows.Forms.Padding(0);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(190, 39);
            this.btnDeleteProject.TabIndex = 5;
            this.btnDeleteProject.Text = "Delete Selected Project";
            this.btnDeleteProject.UseSelectable = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.BtnDeleteProject_Click);
            // 
            // btnHotSwitchP5
            // 
            this.btnHotSwitchP5.ActiveControl = null;
            this.btnHotSwitchP5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHotSwitchP5.BackColor = System.Drawing.Color.White;
            this.btnHotSwitchP5.Location = new System.Drawing.Point(285, 120);
            this.btnHotSwitchP5.Margin = new System.Windows.Forms.Padding(0);
            this.btnHotSwitchP5.Name = "btnHotSwitchP5";
            this.btnHotSwitchP5.Size = new System.Drawing.Size(103, 39);
            this.btnHotSwitchP5.TabIndex = 5;
            this.btnHotSwitchP5.Text = "Project 5";
            this.btnHotSwitchP5.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnHotSwitchP5.UseSelectable = true;
            // 
            // btnHotSwitchP4
            // 
            this.btnHotSwitchP4.ActiveControl = null;
            this.btnHotSwitchP4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHotSwitchP4.BackColor = System.Drawing.Color.White;
            this.btnHotSwitchP4.Location = new System.Drawing.Point(154, 120);
            this.btnHotSwitchP4.Margin = new System.Windows.Forms.Padding(0);
            this.btnHotSwitchP4.Name = "btnHotSwitchP4";
            this.btnHotSwitchP4.Size = new System.Drawing.Size(126, 39);
            this.btnHotSwitchP4.TabIndex = 5;
            this.btnHotSwitchP4.Text = "Project 4";
            this.btnHotSwitchP4.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnHotSwitchP4.UseSelectable = true;
            // 
            // btnHotSwitchP3
            // 
            this.btnHotSwitchP3.ActiveControl = null;
            this.btnHotSwitchP3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHotSwitchP3.BackColor = System.Drawing.Color.White;
            this.btnHotSwitchP3.Location = new System.Drawing.Point(5, 120);
            this.btnHotSwitchP3.Margin = new System.Windows.Forms.Padding(0);
            this.btnHotSwitchP3.Name = "btnHotSwitchP3";
            this.btnHotSwitchP3.Size = new System.Drawing.Size(145, 39);
            this.btnHotSwitchP3.TabIndex = 5;
            this.btnHotSwitchP3.Text = "Project 3";
            this.btnHotSwitchP3.UseSelectable = true;
            // 
            // btnHotSwitchP2
            // 
            this.btnHotSwitchP2.ActiveControl = null;
            this.btnHotSwitchP2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHotSwitchP2.BackColor = System.Drawing.Color.White;
            this.btnHotSwitchP2.Location = new System.Drawing.Point(199, 77);
            this.btnHotSwitchP2.Margin = new System.Windows.Forms.Padding(0);
            this.btnHotSwitchP2.Name = "btnHotSwitchP2";
            this.btnHotSwitchP2.Size = new System.Drawing.Size(189, 39);
            this.btnHotSwitchP2.TabIndex = 5;
            this.btnHotSwitchP2.Text = "Project 2";
            this.btnHotSwitchP2.UseSelectable = true;
            // 
            // btnHotSwitchP1
            // 
            this.btnHotSwitchP1.ActiveControl = null;
            this.btnHotSwitchP1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHotSwitchP1.BackColor = System.Drawing.Color.White;
            this.btnHotSwitchP1.Location = new System.Drawing.Point(5, 77);
            this.btnHotSwitchP1.Margin = new System.Windows.Forms.Padding(0);
            this.btnHotSwitchP1.Name = "btnHotSwitchP1";
            this.btnHotSwitchP1.Size = new System.Drawing.Size(190, 39);
            this.btnHotSwitchP1.TabIndex = 5;
            this.btnHotSwitchP1.Text = "Project 1";
            this.btnHotSwitchP1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnHotSwitchP1.UseSelectable = true;
            this.btnHotSwitchP1.Click += new System.EventHandler(this.BtnHotSwitchP1_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.metroLabel7);
            this.metroTabPage3.Controls.Add(this.metroLabel6);
            this.metroTabPage3.Controls.Add(this.btnToggleAllServicesOff);
            this.metroTabPage3.Controls.Add(this.btnToggleAllServicesOn);
            this.metroTabPage3.Controls.Add(this.metroLabel5);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.metroLabel2);
            this.metroTabPage3.Controls.Add(this.metroLabel1);
            this.metroTabPage3.Controls.Add(this.chbServiceMySQL);
            this.metroTabPage3.Controls.Add(this.chbServiceFileZilla);
            this.metroTabPage3.Controls.Add(this.chbServiceMercury);
            this.metroTabPage3.Controls.Add(this.chbServiceTomcat);
            this.metroTabPage3.Controls.Add(this.chbServiceApache);
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 10;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Size = new System.Drawing.Size(392, 328);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "Services";
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(78, 125);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(94, 19);
            this.metroLabel7.TabIndex = 10;
            this.metroLabel7.Text = "Other Services";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(83, 10);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(89, 19);
            this.metroLabel6.TabIndex = 10;
            this.metroLabel6.Text = "Main Services";
            // 
            // btnToggleAllServicesOff
            // 
            this.btnToggleAllServicesOff.ActiveControl = null;
            this.btnToggleAllServicesOff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleAllServicesOff.Location = new System.Drawing.Point(199, 284);
            this.btnToggleAllServicesOff.Name = "btnToggleAllServicesOff";
            this.btnToggleAllServicesOff.Size = new System.Drawing.Size(190, 48);
            this.btnToggleAllServicesOff.TabIndex = 9;
            this.btnToggleAllServicesOff.Text = "Toggle All Off";
            this.btnToggleAllServicesOff.UseSelectable = true;
            this.btnToggleAllServicesOff.Click += new System.EventHandler(this.BtnToggleAllServicesOff_Click);
            // 
            // btnToggleAllServicesOn
            // 
            this.btnToggleAllServicesOn.ActiveControl = null;
            this.btnToggleAllServicesOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnToggleAllServicesOn.Location = new System.Drawing.Point(5, 283);
            this.btnToggleAllServicesOn.Name = "btnToggleAllServicesOn";
            this.btnToggleAllServicesOn.Size = new System.Drawing.Size(190, 48);
            this.btnToggleAllServicesOn.TabIndex = 8;
            this.btnToggleAllServicesOn.Text = "Toggle All On";
            this.btnToggleAllServicesOn.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnToggleAllServicesOn.UseSelectable = true;
            this.btnToggleAllServicesOn.Click += new System.EventHandler(this.BtnToggleAllServicesOn_Click);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(202, 246);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(51, 19);
            this.metroLabel5.TabIndex = 7;
            this.metroLabel5.Text = "Tomcat";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(202, 200);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(58, 19);
            this.metroLabel4.TabIndex = 7;
            this.metroLabel4.Text = "Mercury";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(202, 154);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 7;
            this.metroLabel3.Text = "FileZilla";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.BackColor = System.Drawing.SystemColors.Control;
            this.metroLabel2.Location = new System.Drawing.Point(201, 87);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(51, 19);
            this.metroLabel2.TabIndex = 7;
            this.metroLabel2.Text = "MySQL";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(202, 41);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(53, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Apache";
            // 
            // chbServiceMySQL
            // 
            this.chbServiceMySQL.AutoSize = true;
            this.chbServiceMySQL.Checked = true;
            this.chbServiceMySQL.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbServiceMySQL.Location = new System.Drawing.Point(115, 87);
            this.chbServiceMySQL.Name = "chbServiceMySQL";
            this.chbServiceMySQL.Size = new System.Drawing.Size(80, 17);
            this.chbServiceMySQL.TabIndex = 6;
            this.chbServiceMySQL.Text = "An";
            this.chbServiceMySQL.UseSelectable = true;
            this.chbServiceMySQL.Click += new System.EventHandler(this.ChbServiceMySQL_Click);
            // 
            // chbServiceFileZilla
            // 
            this.chbServiceFileZilla.AutoSize = true;
            this.chbServiceFileZilla.Location = new System.Drawing.Point(115, 156);
            this.chbServiceFileZilla.Name = "chbServiceFileZilla";
            this.chbServiceFileZilla.Size = new System.Drawing.Size(80, 17);
            this.chbServiceFileZilla.TabIndex = 5;
            this.chbServiceFileZilla.Text = "Aus";
            this.chbServiceFileZilla.UseSelectable = true;
            this.chbServiceFileZilla.Click += new System.EventHandler(this.ChbServiceFileZilla_Click);
            // 
            // chbServiceMercury
            // 
            this.chbServiceMercury.AutoSize = true;
            this.chbServiceMercury.Location = new System.Drawing.Point(115, 202);
            this.chbServiceMercury.Name = "chbServiceMercury";
            this.chbServiceMercury.Size = new System.Drawing.Size(80, 17);
            this.chbServiceMercury.TabIndex = 4;
            this.chbServiceMercury.Text = "Aus";
            this.chbServiceMercury.UseSelectable = true;
            this.chbServiceMercury.Click += new System.EventHandler(this.ChbServiceMercury_Click);
            // 
            // chbServiceTomcat
            // 
            this.chbServiceTomcat.AutoSize = true;
            this.chbServiceTomcat.Location = new System.Drawing.Point(115, 248);
            this.chbServiceTomcat.Name = "chbServiceTomcat";
            this.chbServiceTomcat.Size = new System.Drawing.Size(80, 17);
            this.chbServiceTomcat.TabIndex = 3;
            this.chbServiceTomcat.Text = "Aus";
            this.chbServiceTomcat.UseSelectable = true;
            this.chbServiceTomcat.Click += new System.EventHandler(this.ChbServiceTomcat_Click);
            // 
            // chbServiceApache
            // 
            this.chbServiceApache.AutoSize = true;
            this.chbServiceApache.Checked = true;
            this.chbServiceApache.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chbServiceApache.Location = new System.Drawing.Point(115, 41);
            this.chbServiceApache.Name = "chbServiceApache";
            this.chbServiceApache.Size = new System.Drawing.Size(80, 17);
            this.chbServiceApache.TabIndex = 2;
            this.chbServiceApache.Text = "An";
            this.chbServiceApache.UseSelectable = true;
            this.chbServiceApache.Click += new System.EventHandler(this.ChbServiceApache_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.btnSelectRootDirectory);
            this.metroTabPage2.Controls.Add(this.lblProjectRootPath);
            this.metroTabPage2.Controls.Add(this.txbProjectDescription);
            this.metroTabPage2.Controls.Add(this.txbProjectTitle);
            this.metroTabPage2.Controls.Add(this.metroLabel14);
            this.metroTabPage2.Controls.Add(this.metroLabel13);
            this.metroTabPage2.Controls.Add(this.metroLabel12);
            this.metroTabPage2.Controls.Add(this.btnCancel);
            this.metroTabPage2.Controls.Add(this.btnSaveProject);
            this.metroTabPage2.Controls.Add(this.btnAddNewProject);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(392, 328);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "Manager";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // btnSelectRootDirectory
            // 
            this.btnSelectRootDirectory.Enabled = false;
            this.btnSelectRootDirectory.Location = new System.Drawing.Point(5, 290);
            this.btnSelectRootDirectory.Name = "btnSelectRootDirectory";
            this.btnSelectRootDirectory.Size = new System.Drawing.Size(177, 23);
            this.btnSelectRootDirectory.TabIndex = 9;
            this.btnSelectRootDirectory.Text = "Select Path";
            this.btnSelectRootDirectory.UseSelectable = true;
            this.btnSelectRootDirectory.Click += new System.EventHandler(this.BtnSelectRootDirectory_Click);
            // 
            // lblProjectRootPath
            // 
            this.lblProjectRootPath.Location = new System.Drawing.Point(5, 268);
            this.lblProjectRootPath.Name = "lblProjectRootPath";
            this.lblProjectRootPath.Size = new System.Drawing.Size(190, 19);
            this.lblProjectRootPath.TabIndex = 8;
            this.lblProjectRootPath.Text = "No Path Set";
            // 
            // txbProjectDescription
            // 
            // 
            // 
            // 
            this.txbProjectDescription.CustomButton.Image = null;
            this.txbProjectDescription.CustomButton.Location = new System.Drawing.Point(313, 1);
            this.txbProjectDescription.CustomButton.Name = "";
            this.txbProjectDescription.CustomButton.Size = new System.Drawing.Size(69, 69);
            this.txbProjectDescription.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbProjectDescription.CustomButton.TabIndex = 1;
            this.txbProjectDescription.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbProjectDescription.CustomButton.UseSelectable = true;
            this.txbProjectDescription.CustomButton.Visible = false;
            this.txbProjectDescription.Enabled = false;
            this.txbProjectDescription.Lines = new string[] {
        "Your Project Description"};
            this.txbProjectDescription.Location = new System.Drawing.Point(5, 157);
            this.txbProjectDescription.MaxLength = 32767;
            this.txbProjectDescription.Multiline = true;
            this.txbProjectDescription.Name = "txbProjectDescription";
            this.txbProjectDescription.PasswordChar = '\0';
            this.txbProjectDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbProjectDescription.SelectedText = "";
            this.txbProjectDescription.SelectionLength = 0;
            this.txbProjectDescription.SelectionStart = 0;
            this.txbProjectDescription.ShortcutsEnabled = true;
            this.txbProjectDescription.Size = new System.Drawing.Size(383, 71);
            this.txbProjectDescription.TabIndex = 7;
            this.txbProjectDescription.Text = "Your Project Description";
            this.txbProjectDescription.UseSelectable = true;
            this.txbProjectDescription.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbProjectDescription.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txbProjectTitle
            // 
            // 
            // 
            // 
            this.txbProjectTitle.CustomButton.Image = null;
            this.txbProjectTitle.CustomButton.Location = new System.Drawing.Point(361, 1);
            this.txbProjectTitle.CustomButton.Name = "";
            this.txbProjectTitle.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txbProjectTitle.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbProjectTitle.CustomButton.TabIndex = 1;
            this.txbProjectTitle.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbProjectTitle.CustomButton.UseSelectable = true;
            this.txbProjectTitle.CustomButton.Visible = false;
            this.txbProjectTitle.Enabled = false;
            this.txbProjectTitle.Lines = new string[] {
        "Your Project Name"};
            this.txbProjectTitle.Location = new System.Drawing.Point(5, 102);
            this.txbProjectTitle.MaxLength = 32767;
            this.txbProjectTitle.Name = "txbProjectTitle";
            this.txbProjectTitle.PasswordChar = '\0';
            this.txbProjectTitle.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbProjectTitle.SelectedText = "";
            this.txbProjectTitle.SelectionLength = 0;
            this.txbProjectTitle.SelectionStart = 0;
            this.txbProjectTitle.ShortcutsEnabled = true;
            this.txbProjectTitle.Size = new System.Drawing.Size(383, 23);
            this.txbProjectTitle.TabIndex = 7;
            this.txbProjectTitle.Text = "Your Project Name";
            this.txbProjectTitle.UseSelectable = true;
            this.txbProjectTitle.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txbProjectTitle.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.Location = new System.Drawing.Point(7, 249);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(143, 19);
            this.metroLabel14.TabIndex = 6;
            this.metroLabel14.Text = "Project Root Directory:";
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(5, 135);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(119, 19);
            this.metroLabel13.TabIndex = 6;
            this.metroLabel13.Text = "Project Description";
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(5, 80);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(90, 19);
            this.metroLabel12.TabIndex = 6;
            this.metroLabel12.Text = "Project Name";
            // 
            // btnCancel
            // 
            this.btnCancel.ActiveControl = null;
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(199, 251);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(190, 38);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseSelectable = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnSaveProject
            // 
            this.btnSaveProject.ActiveControl = null;
            this.btnSaveProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveProject.BackColor = System.Drawing.Color.White;
            this.btnSaveProject.Enabled = false;
            this.btnSaveProject.Location = new System.Drawing.Point(199, 293);
            this.btnSaveProject.Margin = new System.Windows.Forms.Padding(0);
            this.btnSaveProject.Name = "btnSaveProject";
            this.btnSaveProject.Size = new System.Drawing.Size(190, 38);
            this.btnSaveProject.TabIndex = 5;
            this.btnSaveProject.Text = "Save Project";
            this.btnSaveProject.UseSelectable = true;
            this.btnSaveProject.Click += new System.EventHandler(this.BtnSaveProject_Click);
            // 
            // btnAddNewProject
            // 
            this.btnAddNewProject.ActiveControl = null;
            this.btnAddNewProject.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddNewProject.BackColor = System.Drawing.Color.White;
            this.btnAddNewProject.Location = new System.Drawing.Point(6, 17);
            this.btnAddNewProject.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddNewProject.Name = "btnAddNewProject";
            this.btnAddNewProject.Size = new System.Drawing.Size(383, 48);
            this.btnAddNewProject.TabIndex = 5;
            this.btnAddNewProject.Text = "Add New Project";
            this.btnAddNewProject.UseSelectable = true;
            this.btnAddNewProject.Click += new System.EventHandler(this.BtnAddNewProject_Click);
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.btnSelectInstallPath);
            this.metroTabPage4.Controls.Add(this.lblXamppInstallPath);
            this.metroTabPage4.Controls.Add(this.metroLabel9);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 10;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Size = new System.Drawing.Size(392, 328);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "Settings";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            // 
            // btnSelectInstallPath
            // 
            this.btnSelectInstallPath.Location = new System.Drawing.Point(18, 63);
            this.btnSelectInstallPath.Name = "btnSelectInstallPath";
            this.btnSelectInstallPath.Size = new System.Drawing.Size(177, 23);
            this.btnSelectInstallPath.TabIndex = 4;
            this.btnSelectInstallPath.Text = "Select Path";
            this.btnSelectInstallPath.UseSelectable = true;
            this.btnSelectInstallPath.Click += new System.EventHandler(this.BtnSelectInstallPath_Click);
            // 
            // lblXamppInstallPath
            // 
            this.lblXamppInstallPath.AutoSize = true;
            this.lblXamppInstallPath.Location = new System.Drawing.Point(18, 41);
            this.lblXamppInstallPath.Name = "lblXamppInstallPath";
            this.lblXamppInstallPath.Size = new System.Drawing.Size(78, 19);
            this.lblXamppInstallPath.TabIndex = 3;
            this.lblXamppInstallPath.Text = "No Path Set";
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(18, 18);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(151, 19);
            this.metroLabel9.TabIndex = 2;
            this.metroLabel9.Text = "XAMPP Installation Path:";
            // 
            // btnStartServices
            // 
            this.btnStartServices.ActiveControl = null;
            this.btnStartServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStartServices.BackColor = System.Drawing.Color.White;
            this.btnStartServices.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStartServices.Location = new System.Drawing.Point(10, 392);
            this.btnStartServices.Margin = new System.Windows.Forms.Padding(0);
            this.btnStartServices.Name = "btnStartServices";
            this.btnStartServices.Size = new System.Drawing.Size(190, 52);
            this.btnStartServices.TabIndex = 5;
            this.btnStartServices.Text = "Start Services";
            this.btnStartServices.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnStartServices.UseSelectable = true;
            this.btnStartServices.Click += new System.EventHandler(this.BtnStartServices_Click);
            // 
            // btnStopServices
            // 
            this.btnStopServices.ActiveControl = null;
            this.btnStopServices.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStopServices.Location = new System.Drawing.Point(204, 392);
            this.btnStopServices.Margin = new System.Windows.Forms.Padding(0);
            this.btnStopServices.Name = "btnStopServices";
            this.btnStopServices.Size = new System.Drawing.Size(190, 52);
            this.btnStopServices.TabIndex = 5;
            this.btnStopServices.Text = "Stop Services";
            this.btnStopServices.UseSelectable = true;
            this.btnStopServices.Click += new System.EventHandler(this.BtnStopServices_Click);
            // 
            // lblClose
            // 
            this.lblClose.AutoSize = true;
            this.lblClose.Location = new System.Drawing.Point(381, 0);
            this.lblClose.Name = "lblClose";
            this.lblClose.Size = new System.Drawing.Size(20, 19);
            this.lblClose.TabIndex = 6;
            this.lblClose.Text = "✕";
            this.lblClose.Click += new System.EventHandler(this.LblClose_Click);
            // 
            // lblMinimize
            // 
            this.lblMinimize.AutoSize = true;
            this.lblMinimize.Location = new System.Drawing.Point(352, 0);
            this.lblMinimize.Name = "lblMinimize";
            this.lblMinimize.Size = new System.Drawing.Size(23, 19);
            this.lblMinimize.TabIndex = 6;
            this.lblMinimize.Text = "＿";
            this.lblMinimize.Click += new System.EventHandler(this.LblMinimize_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(1, 0);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(227, 19);
            this.metroLabel8.TabIndex = 7;
            this.metroLabel8.Text = "XAMPP Project Selector - Version 2.0";
            // 
            // nicNotify
            // 
            this.nicNotify.Text = "XAMPP Project Selector";
            this.nicNotify.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(402, 453);
            this.Controls.Add(this.metroLabel8);
            this.Controls.Add(this.lblMinimize);
            this.Controls.Add(this.lblClose);
            this.Controls.Add(this.btnStopServices);
            this.Controls.Add(this.btnStartServices);
            this.Controls.Add(this.tabMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Project Selector";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.tabMain.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroTabControl tabMain;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private MetroFramework.Controls.MetroTabPage metroTabPage3;
        private MetroFramework.Controls.MetroToggle chbServiceMySQL;
        private MetroFramework.Controls.MetroToggle chbServiceFileZilla;
        private MetroFramework.Controls.MetroToggle chbServiceMercury;
        private MetroFramework.Controls.MetroToggle chbServiceTomcat;
        private MetroFramework.Controls.MetroToggle chbServiceApache;
        private MetroFramework.Controls.MetroTabPage metroTabPage4;
        private MetroFramework.Controls.MetroTile btnStartServices;
        private MetroFramework.Controls.MetroTile btnStopServices;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTile btnToggleAllServicesOff;
        private MetroFramework.Controls.MetroTile btnToggleAllServicesOn;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel lblClose;
        private MetroFramework.Controls.MetroLabel lblMinimize;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnSelectInstallPath;
        private MetroFramework.Controls.MetroLabel lblXamppInstallPath;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private System.Windows.Forms.FolderBrowserDialog fbdInstallPath;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroTile btnHotSwitchP4;
        private MetroFramework.Controls.MetroTile btnHotSwitchP3;
        private MetroFramework.Controls.MetroTile btnHotSwitchP2;
        private MetroFramework.Controls.MetroTile btnHotSwitchP1;
        private MetroFramework.Controls.MetroTile btnHotSwitchP5;
        private MetroFramework.Controls.MetroTile btnManageProject;
        private MetroFramework.Controls.MetroTile btnSelectProject;
        private MetroFramework.Controls.MetroTile btnDeleteProject;
        private MetroFramework.Controls.MetroLabel metroLabel11;
        private MetroFramework.Controls.MetroComboBox cbxSavedProjects;
        private MetroFramework.Controls.MetroTile btnAddNewProject;
        private MetroFramework.Controls.MetroButton btnSelectRootDirectory;
        private MetroFramework.Controls.MetroLabel lblProjectRootPath;
        private MetroFramework.Controls.MetroTextBox txbProjectDescription;
        private MetroFramework.Controls.MetroTextBox txbProjectTitle;
        private MetroFramework.Controls.MetroLabel metroLabel14;
        private MetroFramework.Controls.MetroLabel metroLabel13;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroTile btnSaveProject;
        private MetroFramework.Controls.MetroTile btnCancel;
        private System.Windows.Forms.FolderBrowserDialog fbdRootPath;
        private MetroFramework.Controls.MetroLabel metroLabel15;
        private System.Windows.Forms.NotifyIcon nicNotify;
    }
}

