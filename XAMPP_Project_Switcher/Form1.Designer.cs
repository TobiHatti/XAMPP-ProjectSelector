namespace XAMPP_Project_Switcher
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
            this.cbxEntries = new System.Windows.Forms.ComboBox();
            this.btnNewEntry = new System.Windows.Forms.Button();
            this.btnSetProject = new System.Windows.Forms.Button();
            this.txbXAMPPDirectory = new System.Windows.Forms.TextBox();
            this.btnSelectXAMPPDirectory = new System.Windows.Forms.Button();
            this.fbdFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDeleteProject = new System.Windows.Forms.Button();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxEntries
            // 
            this.cbxEntries.FormattingEnabled = true;
            this.cbxEntries.Location = new System.Drawing.Point(12, 116);
            this.cbxEntries.Name = "cbxEntries";
            this.cbxEntries.Size = new System.Drawing.Size(276, 21);
            this.cbxEntries.TabIndex = 0;
            // 
            // btnNewEntry
            // 
            this.btnNewEntry.Location = new System.Drawing.Point(76, 12);
            this.btnNewEntry.Name = "btnNewEntry";
            this.btnNewEntry.Size = new System.Drawing.Size(212, 23);
            this.btnNewEntry.TabIndex = 1;
            this.btnNewEntry.Text = "Add New Project Directory";
            this.btnNewEntry.UseVisualStyleBackColor = true;
            this.btnNewEntry.Click += new System.EventHandler(this.btnNewEntry_Click);
            // 
            // btnSetProject
            // 
            this.btnSetProject.Location = new System.Drawing.Point(12, 143);
            this.btnSetProject.Name = "btnSetProject";
            this.btnSetProject.Size = new System.Drawing.Size(276, 43);
            this.btnSetProject.TabIndex = 2;
            this.btnSetProject.Text = "Set Project Directory";
            this.btnSetProject.UseVisualStyleBackColor = true;
            this.btnSetProject.Click += new System.EventHandler(this.btnSetProject_Click);
            // 
            // txbXAMPPDirectory
            // 
            this.txbXAMPPDirectory.Location = new System.Drawing.Point(12, 89);
            this.txbXAMPPDirectory.Name = "txbXAMPPDirectory";
            this.txbXAMPPDirectory.ReadOnly = true;
            this.txbXAMPPDirectory.Size = new System.Drawing.Size(238, 20);
            this.txbXAMPPDirectory.TabIndex = 3;
            // 
            // btnSelectXAMPPDirectory
            // 
            this.btnSelectXAMPPDirectory.Location = new System.Drawing.Point(256, 87);
            this.btnSelectXAMPPDirectory.Name = "btnSelectXAMPPDirectory";
            this.btnSelectXAMPPDirectory.Size = new System.Drawing.Size(32, 23);
            this.btnSelectXAMPPDirectory.TabIndex = 4;
            this.btnSelectXAMPPDirectory.Text = "...";
            this.btnSelectXAMPPDirectory.UseVisualStyleBackColor = true;
            this.btnSelectXAMPPDirectory.Click += new System.EventHandler(this.btnSelectXAMPPDirectory_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Select Path to XAMPP folder";
            // 
            // btnDeleteProject
            // 
            this.btnDeleteProject.Location = new System.Drawing.Point(76, 41);
            this.btnDeleteProject.Name = "btnDeleteProject";
            this.btnDeleteProject.Size = new System.Drawing.Size(212, 23);
            this.btnDeleteProject.TabIndex = 6;
            this.btnDeleteProject.Text = "Delete Selected Project";
            this.btnDeleteProject.UseVisualStyleBackColor = true;
            this.btnDeleteProject.Click += new System.EventHandler(this.btnDeleteProject_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::XAMPP_Project_Switcher.Properties.Resources.xamppProjectSelector;
            this.pbxLogo.InitialImage = global::XAMPP_Project_Switcher.Properties.Resources.xamppProjectSelector;
            this.pbxLogo.Location = new System.Drawing.Point(12, 12);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(58, 52);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 7;
            this.pbxLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 198);
            this.Controls.Add(this.pbxLogo);
            this.Controls.Add(this.btnDeleteProject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSelectXAMPPDirectory);
            this.Controls.Add(this.txbXAMPPDirectory);
            this.Controls.Add(this.btnSetProject);
            this.Controls.Add(this.btnNewEntry);
            this.Controls.Add(this.cbxEntries);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "XAMPP Project Selector";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxEntries;
        private System.Windows.Forms.Button btnNewEntry;
        private System.Windows.Forms.Button btnSetProject;
        private System.Windows.Forms.TextBox txbXAMPPDirectory;
        private System.Windows.Forms.Button btnSelectXAMPPDirectory;
        private System.Windows.Forms.FolderBrowserDialog fbdFolderBrowser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDeleteProject;
        private System.Windows.Forms.PictureBox pbxLogo;
    }
}

