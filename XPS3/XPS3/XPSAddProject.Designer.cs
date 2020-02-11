namespace XPS3
{
    partial class XPSAddProject
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(XPSAddProject));
            this.txtProjectTitle = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.lblFormTitle = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetDivider2 = new MetroSet_UI.Controls.MetroSetDivider();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetDivider1 = new MetroSet_UI.Controls.MetroSetDivider();
            this.chbDefOpApache = new MetroSet_UI.Controls.MetroSetSwitch();
            this.chbDefOpMySQL = new MetroSet_UI.Controls.MetroSetSwitch();
            this.chbDefOpFileZilla = new MetroSet_UI.Controls.MetroSetSwitch();
            this.chbDefOpMercury = new MetroSet_UI.Controls.MetroSetSwitch();
            this.chbDefOpTomcat = new MetroSet_UI.Controls.MetroSetSwitch();
            this.metroSetLabel10 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel9 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel8 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel7 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel5 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetDivider3 = new MetroSet_UI.Controls.MetroSetDivider();
            this.metroSetDivider4 = new MetroSet_UI.Controls.MetroSetDivider();
            this.pbxThumbnailPreview = new System.Windows.Forms.PictureBox();
            this.metroSetLabel6 = new MetroSet_UI.Controls.MetroSetLabel();
            this.btnBrowseThumbnail = new MetroSet_UI.Controls.MetroSetButton();
            this.btnSubmit = new MetroSet_UI.Controls.MetroSetButton();
            this.btnCancel = new MetroSet_UI.Controls.MetroSetButton();
            this.metroSetLabel11 = new MetroSet_UI.Controls.MetroSetLabel();
            this.txtProjectRoot = new MetroSet_UI.Controls.MetroSetTextBox();
            this.btnBrowseRootFolder = new MetroSet_UI.Controls.MetroSetButton();
            this.fbdProjectRoot = new System.Windows.Forms.FolderBrowserDialog();
            this.ofdOpenThumbnail = new System.Windows.Forms.OpenFileDialog();
            this.rtbProjectDescription = new MetroSet_UI.Controls.MetroSetTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumbnailPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // txtProjectTitle
            // 
            this.txtProjectTitle.AutoCompleteCustomSource = null;
            this.txtProjectTitle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtProjectTitle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtProjectTitle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtProjectTitle.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtProjectTitle.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtProjectTitle.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtProjectTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProjectTitle.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtProjectTitle.Image = null;
            this.txtProjectTitle.Lines = null;
            this.txtProjectTitle.Location = new System.Drawing.Point(12, 64);
            this.txtProjectTitle.MaxLength = 32767;
            this.txtProjectTitle.Multiline = false;
            this.txtProjectTitle.Name = "txtProjectTitle";
            this.txtProjectTitle.ReadOnly = false;
            this.txtProjectTitle.Size = new System.Drawing.Size(325, 30);
            this.txtProjectTitle.Style = MetroSet_UI.Design.Style.Light;
            this.txtProjectTitle.StyleManager = null;
            this.txtProjectTitle.TabIndex = 0;
            this.txtProjectTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProjectTitle.ThemeAuthor = "Narwin";
            this.txtProjectTitle.ThemeName = "MetroLite";
            this.txtProjectTitle.UseSystemPasswordChar = false;
            this.txtProjectTitle.WatermarkText = "";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel1.Location = new System.Drawing.Point(12, 38);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(115, 23);
            this.metroSetLabel1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 1;
            this.metroSetLabel1.Text = "Project Name: *";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblFormTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormTitle.Location = new System.Drawing.Point(12, 9);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(207, 23);
            this.lblFormTitle.Style = MetroSet_UI.Design.Style.Light;
            this.lblFormTitle.StyleManager = null;
            this.lblFormTitle.TabIndex = 9;
            this.lblFormTitle.Text = "Add New Project";
            this.lblFormTitle.ThemeAuthor = "Narwin";
            this.lblFormTitle.ThemeName = "MetroLite";
            // 
            // metroSetDivider2
            // 
            this.metroSetDivider2.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetDivider2.Location = new System.Drawing.Point(12, 31);
            this.metroSetDivider2.Name = "metroSetDivider2";
            this.metroSetDivider2.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider2.Size = new System.Drawing.Size(325, 4);
            this.metroSetDivider2.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetDivider2.StyleManager = null;
            this.metroSetDivider2.TabIndex = 8;
            this.metroSetDivider2.Text = "metroSetDivider2";
            this.metroSetDivider2.ThemeAuthor = "Narwin";
            this.metroSetDivider2.ThemeName = "MetroDark";
            this.metroSetDivider2.Thickness = 1;
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel2.Location = new System.Drawing.Point(12, 97);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(134, 23);
            this.metroSetLabel2.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 1;
            this.metroSetLabel2.Text = "Project Description:";
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetDivider1
            // 
            this.metroSetDivider1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetDivider1.Location = new System.Drawing.Point(12, 267);
            this.metroSetDivider1.Name = "metroSetDivider1";
            this.metroSetDivider1.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider1.Size = new System.Drawing.Size(325, 4);
            this.metroSetDivider1.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetDivider1.StyleManager = null;
            this.metroSetDivider1.TabIndex = 8;
            this.metroSetDivider1.Text = "metroSetDivider2";
            this.metroSetDivider1.ThemeAuthor = "Narwin";
            this.metroSetDivider1.ThemeName = "MetroDark";
            this.metroSetDivider1.Thickness = 1;
            // 
            // chbDefOpApache
            // 
            this.chbDefOpApache.BackColor = System.Drawing.Color.Transparent;
            this.chbDefOpApache.BackgroundColor = System.Drawing.Color.Empty;
            this.chbDefOpApache.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.chbDefOpApache.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbDefOpApache.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbDefOpApache.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbDefOpApache.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbDefOpApache.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbDefOpApache.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbDefOpApache.Location = new System.Drawing.Point(94, 297);
            this.chbDefOpApache.Name = "chbDefOpApache";
            this.chbDefOpApache.Size = new System.Drawing.Size(58, 22);
            this.chbDefOpApache.Style = MetroSet_UI.Design.Style.Light;
            this.chbDefOpApache.StyleManager = null;
            this.chbDefOpApache.Switched = false;
            this.chbDefOpApache.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chbDefOpApache.TabIndex = 11;
            this.chbDefOpApache.Text = "metroSetSwitch1";
            this.chbDefOpApache.ThemeAuthor = "Narwin";
            this.chbDefOpApache.ThemeName = "MetroLite";
            this.chbDefOpApache.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // chbDefOpMySQL
            // 
            this.chbDefOpMySQL.BackColor = System.Drawing.Color.Transparent;
            this.chbDefOpMySQL.BackgroundColor = System.Drawing.Color.Empty;
            this.chbDefOpMySQL.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.chbDefOpMySQL.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbDefOpMySQL.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbDefOpMySQL.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbDefOpMySQL.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbDefOpMySQL.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbDefOpMySQL.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbDefOpMySQL.Location = new System.Drawing.Point(94, 325);
            this.chbDefOpMySQL.Name = "chbDefOpMySQL";
            this.chbDefOpMySQL.Size = new System.Drawing.Size(58, 22);
            this.chbDefOpMySQL.Style = MetroSet_UI.Design.Style.Light;
            this.chbDefOpMySQL.StyleManager = null;
            this.chbDefOpMySQL.Switched = false;
            this.chbDefOpMySQL.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chbDefOpMySQL.TabIndex = 11;
            this.chbDefOpMySQL.Text = "metroSetSwitch1";
            this.chbDefOpMySQL.ThemeAuthor = "Narwin";
            this.chbDefOpMySQL.ThemeName = "MetroLite";
            this.chbDefOpMySQL.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // chbDefOpFileZilla
            // 
            this.chbDefOpFileZilla.BackColor = System.Drawing.Color.Transparent;
            this.chbDefOpFileZilla.BackgroundColor = System.Drawing.Color.Empty;
            this.chbDefOpFileZilla.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.chbDefOpFileZilla.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbDefOpFileZilla.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbDefOpFileZilla.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbDefOpFileZilla.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbDefOpFileZilla.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbDefOpFileZilla.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbDefOpFileZilla.Location = new System.Drawing.Point(94, 353);
            this.chbDefOpFileZilla.Name = "chbDefOpFileZilla";
            this.chbDefOpFileZilla.Size = new System.Drawing.Size(58, 22);
            this.chbDefOpFileZilla.Style = MetroSet_UI.Design.Style.Light;
            this.chbDefOpFileZilla.StyleManager = null;
            this.chbDefOpFileZilla.Switched = false;
            this.chbDefOpFileZilla.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chbDefOpFileZilla.TabIndex = 11;
            this.chbDefOpFileZilla.Text = "metroSetSwitch1";
            this.chbDefOpFileZilla.ThemeAuthor = "Narwin";
            this.chbDefOpFileZilla.ThemeName = "MetroLite";
            this.chbDefOpFileZilla.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // chbDefOpMercury
            // 
            this.chbDefOpMercury.BackColor = System.Drawing.Color.Transparent;
            this.chbDefOpMercury.BackgroundColor = System.Drawing.Color.Empty;
            this.chbDefOpMercury.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.chbDefOpMercury.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbDefOpMercury.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbDefOpMercury.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbDefOpMercury.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbDefOpMercury.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbDefOpMercury.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbDefOpMercury.Location = new System.Drawing.Point(94, 381);
            this.chbDefOpMercury.Name = "chbDefOpMercury";
            this.chbDefOpMercury.Size = new System.Drawing.Size(58, 22);
            this.chbDefOpMercury.Style = MetroSet_UI.Design.Style.Light;
            this.chbDefOpMercury.StyleManager = null;
            this.chbDefOpMercury.Switched = false;
            this.chbDefOpMercury.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chbDefOpMercury.TabIndex = 11;
            this.chbDefOpMercury.Text = "metroSetSwitch1";
            this.chbDefOpMercury.ThemeAuthor = "Narwin";
            this.chbDefOpMercury.ThemeName = "MetroLite";
            this.chbDefOpMercury.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // chbDefOpTomcat
            // 
            this.chbDefOpTomcat.BackColor = System.Drawing.Color.Transparent;
            this.chbDefOpTomcat.BackgroundColor = System.Drawing.Color.Empty;
            this.chbDefOpTomcat.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(159)))), ((int)(((byte)(147)))));
            this.chbDefOpTomcat.CheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbDefOpTomcat.CheckState = MetroSet_UI.Enums.CheckState.Unchecked;
            this.chbDefOpTomcat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chbDefOpTomcat.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbDefOpTomcat.DisabledCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.chbDefOpTomcat.DisabledUnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))), ((int)(((byte)(205)))));
            this.chbDefOpTomcat.Location = new System.Drawing.Point(94, 409);
            this.chbDefOpTomcat.Name = "chbDefOpTomcat";
            this.chbDefOpTomcat.Size = new System.Drawing.Size(58, 22);
            this.chbDefOpTomcat.Style = MetroSet_UI.Design.Style.Light;
            this.chbDefOpTomcat.StyleManager = null;
            this.chbDefOpTomcat.Switched = false;
            this.chbDefOpTomcat.SymbolColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(92)))), ((int)(((byte)(92)))));
            this.chbDefOpTomcat.TabIndex = 11;
            this.chbDefOpTomcat.Text = "metroSetSwitch1";
            this.chbDefOpTomcat.ThemeAuthor = "Narwin";
            this.chbDefOpTomcat.ThemeName = "MetroLite";
            this.chbDefOpTomcat.UnCheckColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            // 
            // metroSetLabel10
            // 
            this.metroSetLabel10.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel10.Location = new System.Drawing.Point(12, 409);
            this.metroSetLabel10.Name = "metroSetLabel10";
            this.metroSetLabel10.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel10.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel10.StyleManager = null;
            this.metroSetLabel10.TabIndex = 15;
            this.metroSetLabel10.Text = "Tomcat";
            this.metroSetLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel10.ThemeAuthor = "Narwin";
            this.metroSetLabel10.ThemeName = "MetroLite";
            // 
            // metroSetLabel9
            // 
            this.metroSetLabel9.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel9.Location = new System.Drawing.Point(12, 381);
            this.metroSetLabel9.Name = "metroSetLabel9";
            this.metroSetLabel9.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel9.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel9.StyleManager = null;
            this.metroSetLabel9.TabIndex = 16;
            this.metroSetLabel9.Text = "Mercury";
            this.metroSetLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel9.ThemeAuthor = "Narwin";
            this.metroSetLabel9.ThemeName = "MetroLite";
            // 
            // metroSetLabel8
            // 
            this.metroSetLabel8.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel8.Location = new System.Drawing.Point(12, 353);
            this.metroSetLabel8.Name = "metroSetLabel8";
            this.metroSetLabel8.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel8.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel8.StyleManager = null;
            this.metroSetLabel8.TabIndex = 17;
            this.metroSetLabel8.Text = "FileZilla";
            this.metroSetLabel8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel8.ThemeAuthor = "Narwin";
            this.metroSetLabel8.ThemeName = "MetroLite";
            // 
            // metroSetLabel7
            // 
            this.metroSetLabel7.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel7.Location = new System.Drawing.Point(12, 325);
            this.metroSetLabel7.Name = "metroSetLabel7";
            this.metroSetLabel7.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel7.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel7.StyleManager = null;
            this.metroSetLabel7.TabIndex = 18;
            this.metroSetLabel7.Text = "MySQL";
            this.metroSetLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel7.ThemeAuthor = "Narwin";
            this.metroSetLabel7.ThemeName = "MetroLite";
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel3.Location = new System.Drawing.Point(12, 297);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(62, 23);
            this.metroSetLabel3.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 19;
            this.metroSetLabel3.Text = "Apache";
            this.metroSetLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // metroSetLabel5
            // 
            this.metroSetLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel5.Location = new System.Drawing.Point(12, 274);
            this.metroSetLabel5.Name = "metroSetLabel5";
            this.metroSetLabel5.Size = new System.Drawing.Size(134, 23);
            this.metroSetLabel5.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel5.StyleManager = null;
            this.metroSetLabel5.TabIndex = 1;
            this.metroSetLabel5.Text = "Default Services:";
            this.metroSetLabel5.ThemeAuthor = "Narwin";
            this.metroSetLabel5.ThemeName = "MetroLite";
            // 
            // metroSetDivider3
            // 
            this.metroSetDivider3.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetDivider3.Location = new System.Drawing.Point(12, 435);
            this.metroSetDivider3.Name = "metroSetDivider3";
            this.metroSetDivider3.Orientation = MetroSet_UI.Enums.DividerStyle.Horizontal;
            this.metroSetDivider3.Size = new System.Drawing.Size(325, 4);
            this.metroSetDivider3.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetDivider3.StyleManager = null;
            this.metroSetDivider3.TabIndex = 8;
            this.metroSetDivider3.Text = "metroSetDivider2";
            this.metroSetDivider3.ThemeAuthor = "Narwin";
            this.metroSetDivider3.ThemeName = "MetroDark";
            this.metroSetDivider3.Thickness = 1;
            // 
            // metroSetDivider4
            // 
            this.metroSetDivider4.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetDivider4.Location = new System.Drawing.Point(172, 274);
            this.metroSetDivider4.Name = "metroSetDivider4";
            this.metroSetDivider4.Orientation = MetroSet_UI.Enums.DividerStyle.Vertical;
            this.metroSetDivider4.Size = new System.Drawing.Size(4, 158);
            this.metroSetDivider4.Style = MetroSet_UI.Design.Style.Dark;
            this.metroSetDivider4.StyleManager = null;
            this.metroSetDivider4.TabIndex = 20;
            this.metroSetDivider4.Text = "metroSetDivider2";
            this.metroSetDivider4.ThemeAuthor = "Narwin";
            this.metroSetDivider4.ThemeName = "MetroDark";
            this.metroSetDivider4.Thickness = 1;
            // 
            // pbxThumbnailPreview
            // 
            this.pbxThumbnailPreview.Location = new System.Drawing.Point(182, 329);
            this.pbxThumbnailPreview.Name = "pbxThumbnailPreview";
            this.pbxThumbnailPreview.Size = new System.Drawing.Size(155, 100);
            this.pbxThumbnailPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxThumbnailPreview.TabIndex = 21;
            this.pbxThumbnailPreview.TabStop = false;
            // 
            // metroSetLabel6
            // 
            this.metroSetLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel6.Location = new System.Drawing.Point(182, 274);
            this.metroSetLabel6.Name = "metroSetLabel6";
            this.metroSetLabel6.Size = new System.Drawing.Size(139, 23);
            this.metroSetLabel6.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel6.StyleManager = null;
            this.metroSetLabel6.TabIndex = 1;
            this.metroSetLabel6.Text = "Project Thumbnail:";
            this.metroSetLabel6.ThemeAuthor = "Narwin";
            this.metroSetLabel6.ThemeName = "MetroLite";
            // 
            // btnBrowseThumbnail
            // 
            this.btnBrowseThumbnail.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBrowseThumbnail.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBrowseThumbnail.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnBrowseThumbnail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBrowseThumbnail.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBrowseThumbnail.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBrowseThumbnail.HoverTextColor = System.Drawing.Color.White;
            this.btnBrowseThumbnail.Location = new System.Drawing.Point(182, 300);
            this.btnBrowseThumbnail.Name = "btnBrowseThumbnail";
            this.btnBrowseThumbnail.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBrowseThumbnail.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBrowseThumbnail.NormalTextColor = System.Drawing.Color.White;
            this.btnBrowseThumbnail.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBrowseThumbnail.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBrowseThumbnail.PressTextColor = System.Drawing.Color.White;
            this.btnBrowseThumbnail.Size = new System.Drawing.Size(155, 23);
            this.btnBrowseThumbnail.Style = MetroSet_UI.Design.Style.Light;
            this.btnBrowseThumbnail.StyleManager = null;
            this.btnBrowseThumbnail.TabIndex = 22;
            this.btnBrowseThumbnail.Text = "Browse...";
            this.btnBrowseThumbnail.ThemeAuthor = "Narwin";
            this.btnBrowseThumbnail.ThemeName = "MetroLite";
            this.btnBrowseThumbnail.Click += new System.EventHandler(this.btnBrowseThumbnail_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSubmit.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSubmit.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSubmit.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSubmit.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnSubmit.HoverTextColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(240, 445);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSubmit.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnSubmit.NormalTextColor = System.Drawing.Color.White;
            this.btnSubmit.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSubmit.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnSubmit.PressTextColor = System.Drawing.Color.White;
            this.btnSubmit.Size = new System.Drawing.Size(97, 23);
            this.btnSubmit.Style = MetroSet_UI.Design.Style.Light;
            this.btnSubmit.StyleManager = null;
            this.btnSubmit.TabIndex = 23;
            this.btnSubmit.Text = "Add Project";
            this.btnSubmit.ThemeAuthor = "Narwin";
            this.btnSubmit.ThemeName = "MetroLite";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCancel.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnCancel.HoverTextColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 445);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnCancel.NormalTextColor = System.Drawing.Color.White;
            this.btnCancel.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancel.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnCancel.PressTextColor = System.Drawing.Color.White;
            this.btnCancel.Size = new System.Drawing.Size(97, 23);
            this.btnCancel.Style = MetroSet_UI.Design.Style.Light;
            this.btnCancel.StyleManager = null;
            this.btnCancel.TabIndex = 23;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.ThemeAuthor = "Narwin";
            this.btnCancel.ThemeName = "MetroLite";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // metroSetLabel11
            // 
            this.metroSetLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.metroSetLabel11.Location = new System.Drawing.Point(12, 205);
            this.metroSetLabel11.Name = "metroSetLabel11";
            this.metroSetLabel11.Size = new System.Drawing.Size(152, 23);
            this.metroSetLabel11.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetLabel11.StyleManager = null;
            this.metroSetLabel11.TabIndex = 1;
            this.metroSetLabel11.Text = "Project Root Folder: *";
            this.metroSetLabel11.ThemeAuthor = "Narwin";
            this.metroSetLabel11.ThemeName = "MetroLite";
            // 
            // txtProjectRoot
            // 
            this.txtProjectRoot.AutoCompleteCustomSource = null;
            this.txtProjectRoot.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtProjectRoot.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtProjectRoot.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtProjectRoot.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.txtProjectRoot.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.txtProjectRoot.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.txtProjectRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtProjectRoot.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.txtProjectRoot.Image = null;
            this.txtProjectRoot.Lines = null;
            this.txtProjectRoot.Location = new System.Drawing.Point(12, 231);
            this.txtProjectRoot.MaxLength = 32767;
            this.txtProjectRoot.Multiline = false;
            this.txtProjectRoot.Name = "txtProjectRoot";
            this.txtProjectRoot.ReadOnly = true;
            this.txtProjectRoot.Size = new System.Drawing.Size(282, 30);
            this.txtProjectRoot.Style = MetroSet_UI.Design.Style.Light;
            this.txtProjectRoot.StyleManager = null;
            this.txtProjectRoot.TabIndex = 0;
            this.txtProjectRoot.Text = "C:\\...";
            this.txtProjectRoot.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtProjectRoot.ThemeAuthor = "Narwin";
            this.txtProjectRoot.ThemeName = "MetroLite";
            this.txtProjectRoot.UseSystemPasswordChar = false;
            this.txtProjectRoot.WatermarkText = "";
            // 
            // btnBrowseRootFolder
            // 
            this.btnBrowseRootFolder.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBrowseRootFolder.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBrowseRootFolder.DisabledForeColor = System.Drawing.Color.Gray;
            this.btnBrowseRootFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBrowseRootFolder.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBrowseRootFolder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.btnBrowseRootFolder.HoverTextColor = System.Drawing.Color.White;
            this.btnBrowseRootFolder.Location = new System.Drawing.Point(300, 231);
            this.btnBrowseRootFolder.Name = "btnBrowseRootFolder";
            this.btnBrowseRootFolder.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBrowseRootFolder.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnBrowseRootFolder.NormalTextColor = System.Drawing.Color.White;
            this.btnBrowseRootFolder.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBrowseRootFolder.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.btnBrowseRootFolder.PressTextColor = System.Drawing.Color.White;
            this.btnBrowseRootFolder.Size = new System.Drawing.Size(37, 30);
            this.btnBrowseRootFolder.Style = MetroSet_UI.Design.Style.Light;
            this.btnBrowseRootFolder.StyleManager = null;
            this.btnBrowseRootFolder.TabIndex = 23;
            this.btnBrowseRootFolder.Text = "...";
            this.btnBrowseRootFolder.ThemeAuthor = "Narwin";
            this.btnBrowseRootFolder.ThemeName = "MetroLite";
            this.btnBrowseRootFolder.Click += new System.EventHandler(this.btnBrowseRootFolder_Click);
            // 
            // ofdOpenThumbnail
            // 
            this.ofdOpenThumbnail.FileName = "openFileDialog1";
            // 
            // rtbProjectDescription
            // 
            this.rtbProjectDescription.AutoCompleteCustomSource = null;
            this.rtbProjectDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.rtbProjectDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.rtbProjectDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rtbProjectDescription.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.rtbProjectDescription.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.rtbProjectDescription.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.rtbProjectDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rtbProjectDescription.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.rtbProjectDescription.Image = null;
            this.rtbProjectDescription.Lines = null;
            this.rtbProjectDescription.Location = new System.Drawing.Point(12, 123);
            this.rtbProjectDescription.MaxLength = 32767;
            this.rtbProjectDescription.Multiline = true;
            this.rtbProjectDescription.Name = "rtbProjectDescription";
            this.rtbProjectDescription.ReadOnly = false;
            this.rtbProjectDescription.Size = new System.Drawing.Size(325, 79);
            this.rtbProjectDescription.Style = MetroSet_UI.Design.Style.Light;
            this.rtbProjectDescription.StyleManager = null;
            this.rtbProjectDescription.TabIndex = 24;
            this.rtbProjectDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.rtbProjectDescription.ThemeAuthor = "Narwin";
            this.rtbProjectDescription.ThemeName = "MetroLite";
            this.rtbProjectDescription.UseSystemPasswordChar = false;
            this.rtbProjectDescription.WatermarkText = "";
            // 
            // XPSAddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(349, 477);
            this.Controls.Add(this.rtbProjectDescription);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBrowseRootFolder);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnBrowseThumbnail);
            this.Controls.Add(this.pbxThumbnailPreview);
            this.Controls.Add(this.metroSetDivider4);
            this.Controls.Add(this.metroSetLabel10);
            this.Controls.Add(this.metroSetLabel9);
            this.Controls.Add(this.metroSetLabel8);
            this.Controls.Add(this.metroSetLabel7);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.chbDefOpTomcat);
            this.Controls.Add(this.chbDefOpMercury);
            this.Controls.Add(this.chbDefOpFileZilla);
            this.Controls.Add(this.chbDefOpMySQL);
            this.Controls.Add(this.chbDefOpApache);
            this.Controls.Add(this.lblFormTitle);
            this.Controls.Add(this.metroSetDivider3);
            this.Controls.Add(this.metroSetDivider1);
            this.Controls.Add(this.metroSetDivider2);
            this.Controls.Add(this.metroSetLabel6);
            this.Controls.Add(this.metroSetLabel5);
            this.Controls.Add(this.metroSetLabel11);
            this.Controls.Add(this.metroSetLabel2);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.txtProjectRoot);
            this.Controls.Add(this.txtProjectTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "XPSAddProject";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "XPS3 - Add Project";
            this.Load += new System.EventHandler(this.XPSAddProject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxThumbnailPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetTextBox txtProjectTitle;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetLabel lblFormTitle;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider1;
        private MetroSet_UI.Controls.MetroSetSwitch chbDefOpApache;
        private MetroSet_UI.Controls.MetroSetSwitch chbDefOpMySQL;
        private MetroSet_UI.Controls.MetroSetSwitch chbDefOpFileZilla;
        private MetroSet_UI.Controls.MetroSetSwitch chbDefOpMercury;
        private MetroSet_UI.Controls.MetroSetSwitch chbDefOpTomcat;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel10;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel9;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel8;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel7;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel5;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider3;
        private MetroSet_UI.Controls.MetroSetDivider metroSetDivider4;
        private System.Windows.Forms.PictureBox pbxThumbnailPreview;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel6;
        private MetroSet_UI.Controls.MetroSetButton btnBrowseThumbnail;
        private MetroSet_UI.Controls.MetroSetButton btnSubmit;
        private MetroSet_UI.Controls.MetroSetButton btnCancel;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel11;
        private MetroSet_UI.Controls.MetroSetTextBox txtProjectRoot;
        private MetroSet_UI.Controls.MetroSetButton btnBrowseRootFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdProjectRoot;
        private System.Windows.Forms.OpenFileDialog ofdOpenThumbnail;
        private MetroSet_UI.Controls.MetroSetTextBox rtbProjectDescription;
    }
}