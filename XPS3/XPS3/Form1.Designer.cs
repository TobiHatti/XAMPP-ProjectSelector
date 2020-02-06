namespace XPS3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.metroSetTabControl1 = new MetroSet_UI.Controls.MetroSetTabControl();
            this.tabProjects = new MetroSet_UI.Child.MetroSetTabPage();
            this.tabServices = new MetroSet_UI.Child.MetroSetTabPage();
            this.tabManager = new MetroSet_UI.Child.MetroSetTabPage();
            this.tabSettings = new MetroSet_UI.Child.MetroSetTabPage();
            this.btnStopServices = new MetroSet_UI.Controls.MetroSetTile();
            this.btnStartServices = new MetroSet_UI.Controls.MetroSetTile();
            this.btnStartServicesColor = new MetroSet_UI.Controls.MetroSetTile();
            this.btnStopServicesColor = new MetroSet_UI.Controls.MetroSetTile();
            this.metroSetTabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroSetTabControl1
            // 
            this.metroSetTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetTabControl1.AnimateEasingType = MetroSet_UI.Enums.EasingType.CubeOut;
            this.metroSetTabControl1.AnimateTime = 400;
            this.metroSetTabControl1.Controls.Add(this.tabProjects);
            this.metroSetTabControl1.Controls.Add(this.tabServices);
            this.metroSetTabControl1.Controls.Add(this.tabManager);
            this.metroSetTabControl1.Controls.Add(this.tabSettings);
            this.metroSetTabControl1.Cursor = System.Windows.Forms.Cursors.Default;
            this.metroSetTabControl1.ItemSize = new System.Drawing.Size(100, 38);
            this.metroSetTabControl1.Location = new System.Drawing.Point(12, 12);
            this.metroSetTabControl1.Name = "metroSetTabControl1";
            this.metroSetTabControl1.SelectedIndex = 0;
            this.metroSetTabControl1.Size = new System.Drawing.Size(315, 393);
            this.metroSetTabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.metroSetTabControl1.Speed = 20;
            this.metroSetTabControl1.Style = MetroSet_UI.Design.Style.Light;
            this.metroSetTabControl1.StyleManager = null;
            this.metroSetTabControl1.TabIndex = 2;
            this.metroSetTabControl1.TabStyle = MetroSet_UI.Enums.TabStyle.Style1;
            this.metroSetTabControl1.ThemeAuthor = "Narwin";
            this.metroSetTabControl1.ThemeName = "MetroLite";
            this.metroSetTabControl1.UseAnimation = true;
            // 
            // tabProjects
            // 
            this.tabProjects.BaseColor = System.Drawing.Color.White;
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
            // tabServices
            // 
            this.tabServices.BaseColor = System.Drawing.Color.White;
            this.tabServices.ImageIndex = 0;
            this.tabServices.ImageKey = null;
            this.tabServices.Location = new System.Drawing.Point(4, 42);
            this.tabServices.Name = "tabServices";
            this.tabServices.Size = new System.Drawing.Size(314, 391);
            this.tabServices.Style = MetroSet_UI.Design.Style.Light;
            this.tabServices.StyleManager = null;
            this.tabServices.TabIndex = 1;
            this.tabServices.Text = "Services";
            this.tabServices.ThemeAuthor = "Narwin";
            this.tabServices.ThemeName = "MetroLite";
            this.tabServices.ToolTipText = null;
            // 
            // tabManager
            // 
            this.tabManager.BaseColor = System.Drawing.Color.White;
            this.tabManager.ImageIndex = 0;
            this.tabManager.ImageKey = null;
            this.tabManager.Location = new System.Drawing.Point(4, 42);
            this.tabManager.Name = "tabManager";
            this.tabManager.Size = new System.Drawing.Size(314, 391);
            this.tabManager.Style = MetroSet_UI.Design.Style.Light;
            this.tabManager.StyleManager = null;
            this.tabManager.TabIndex = 2;
            this.tabManager.Text = "Manager";
            this.tabManager.ThemeAuthor = "Narwin";
            this.tabManager.ThemeName = "MetroLite";
            this.tabManager.ToolTipText = null;
            // 
            // tabSettings
            // 
            this.tabSettings.BaseColor = System.Drawing.Color.White;
            this.tabSettings.ImageIndex = 0;
            this.tabSettings.ImageKey = null;
            this.tabSettings.Location = new System.Drawing.Point(4, 42);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(314, 391);
            this.tabSettings.Style = MetroSet_UI.Design.Style.Light;
            this.tabSettings.StyleManager = null;
            this.tabSettings.TabIndex = 3;
            this.tabSettings.Text = "Settings";
            this.tabSettings.ThemeAuthor = "Narwin";
            this.tabSettings.ThemeName = "MetroLite";
            this.tabSettings.ToolTipText = null;
            // 
            // btnStopServices
            // 
            this.btnStopServices.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnStopServices.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnStopServices.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnStopServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStopServices.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnStopServices.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStopServices.HoverTextColor = System.Drawing.Color.White;
            this.btnStopServices.Location = new System.Drawing.Point(174, 411);
            this.btnStopServices.Name = "btnStopServices";
            this.btnStopServices.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStopServices.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStopServices.NormalTextColor = System.Drawing.Color.White;
            this.btnStopServices.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnStopServices.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStopServices.PressTextColor = System.Drawing.Color.White;
            this.btnStopServices.Size = new System.Drawing.Size(153, 38);
            this.btnStopServices.Style = MetroSet_UI.Design.Style.Dark;
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
            this.btnStartServices.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.btnStartServices.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnStartServices.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.btnStartServices.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStartServices.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.btnStartServices.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartServices.HoverTextColor = System.Drawing.Color.White;
            this.btnStartServices.Location = new System.Drawing.Point(16, 411);
            this.btnStartServices.Name = "btnStartServices";
            this.btnStartServices.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartServices.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartServices.NormalTextColor = System.Drawing.Color.White;
            this.btnStartServices.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnStartServices.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.btnStartServices.PressTextColor = System.Drawing.Color.White;
            this.btnStartServices.Size = new System.Drawing.Size(152, 38);
            this.btnStartServices.Style = MetroSet_UI.Design.Style.Dark;
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
            this.btnStartServicesColor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStartServicesColor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnStartServicesColor.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnStartServicesColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStartServicesColor.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.btnStartServicesColor.HoverColor = System.Drawing.Color.Lime;
            this.btnStartServicesColor.HoverTextColor = System.Drawing.Color.White;
            this.btnStartServicesColor.Location = new System.Drawing.Point(16, 411);
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
            this.btnStopServicesColor.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.btnStopServicesColor.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.btnStopServicesColor.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.btnStopServicesColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnStopServicesColor.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(339, 461);
            this.Controls.Add(this.btnStopServicesColor);
            this.Controls.Add(this.btnStartServicesColor);
            this.Controls.Add(this.btnStartServices);
            this.Controls.Add(this.btnStopServices);
            this.Controls.Add(this.metroSetTabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "XAMPP Project Selector - XPS3";
            this.metroSetTabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private MetroSet_UI.Controls.MetroSetTabControl metroSetTabControl1;
        private MetroSet_UI.Child.MetroSetTabPage tabProjects;
        private MetroSet_UI.Child.MetroSetTabPage tabServices;
        private MetroSet_UI.Child.MetroSetTabPage tabManager;
        private MetroSet_UI.Child.MetroSetTabPage tabSettings;
        private MetroSet_UI.Controls.MetroSetTile btnStopServices;
        private MetroSet_UI.Controls.MetroSetTile btnStartServices;
        private MetroSet_UI.Controls.MetroSetTile btnStartServicesColor;
        private MetroSet_UI.Controls.MetroSetTile btnStopServicesColor;
    }
}

