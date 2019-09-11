namespace XAMPP_Project_Switcher
{
    partial class AddProjectEntry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProjectEntry));
            this.label1 = new System.Windows.Forms.Label();
            this.txbProjectName = new System.Windows.Forms.TextBox();
            this.btnSelectProjectFolder = new System.Windows.Forms.Button();
            this.txbProjectFolder = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddProject = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.fdbFolderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txbProjectName
            // 
            resources.ApplyResources(this.txbProjectName, "txbProjectName");
            this.txbProjectName.Name = "txbProjectName";
            // 
            // btnSelectProjectFolder
            // 
            resources.ApplyResources(this.btnSelectProjectFolder, "btnSelectProjectFolder");
            this.btnSelectProjectFolder.Name = "btnSelectProjectFolder";
            this.btnSelectProjectFolder.UseVisualStyleBackColor = true;
            this.btnSelectProjectFolder.Click += new System.EventHandler(this.btnSelectProjectFolder_Click);
            // 
            // txbProjectFolder
            // 
            resources.ApplyResources(this.txbProjectFolder, "txbProjectFolder");
            this.txbProjectFolder.Name = "txbProjectFolder";
            this.txbProjectFolder.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnAddProject
            // 
            resources.ApplyResources(this.btnAddProject, "btnAddProject");
            this.btnAddProject.Name = "btnAddProject";
            this.btnAddProject.UseVisualStyleBackColor = true;
            this.btnAddProject.Click += new System.EventHandler(this.btnAddProject_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            resources.ApplyResources(this.btnCancel, "btnCancel");
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // fdbFolderBrowser
            // 
            resources.ApplyResources(this.fdbFolderBrowser, "fdbFolderBrowser");
            this.fdbFolderBrowser.ShowNewFolderButton = false;
            // 
            // AddProjectEntry
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAddProject);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbProjectFolder);
            this.Controls.Add(this.btnSelectProjectFolder);
            this.Controls.Add(this.txbProjectName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProjectEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbProjectName;
        private System.Windows.Forms.Button btnSelectProjectFolder;
        private System.Windows.Forms.TextBox txbProjectFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddProject;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.FolderBrowserDialog fdbFolderBrowser;
    }
}