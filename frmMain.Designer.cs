namespace KTransliter
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnClose = new System.Windows.Forms.Button();
            this.chkTra = new System.Windows.Forms.CheckBox();
            this.btnProcessEPub = new System.Windows.Forms.Button();
            this.dlgSourceDir = new System.Windows.Forms.FolderBrowserDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.chkSubfolders = new System.Windows.Forms.CheckBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirSource = new System.Windows.Forms.TextBox();
            this.txtLog = new System.Windows.Forms.RichTextBox();
            this.btnProcessMP3 = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.mnuMain = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHomePage = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCheckForUpdates = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(442, 84);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(95, 22);
            this.btnClose.TabIndex = 17;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chkTra
            // 
            this.chkTra.AutoSize = true;
            this.chkTra.Location = new System.Drawing.Point(206, 55);
            this.chkTra.Name = "chkTra";
            this.chkTra.Size = new System.Drawing.Size(115, 17);
            this.chkTra.TabIndex = 16;
            this.chkTra.Text = "Translit File Names";
            this.chkTra.UseVisualStyleBackColor = true;
            // 
            // btnProcessEPub
            // 
            this.btnProcessEPub.Location = new System.Drawing.Point(443, 26);
            this.btnProcessEPub.Name = "btnProcessEPub";
            this.btnProcessEPub.Size = new System.Drawing.Size(94, 22);
            this.btnProcessEPub.TabIndex = 15;
            this.btnProcessEPub.Tag = "epub";
            this.btnProcessEPub.Text = "Process EPubs";
            this.btnProcessEPub.UseVisualStyleBackColor = true;
            this.btnProcessEPub.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // dlgSourceDir
            // 
            this.dlgSourceDir.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.dlgSourceDir.ShowNewFolderButton = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Log:";
            // 
            // chkSubfolders
            // 
            this.chkSubfolders.AutoSize = true;
            this.chkSubfolders.Checked = true;
            this.chkSubfolders.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkSubfolders.Location = new System.Drawing.Point(86, 56);
            this.chkSubfolders.Name = "chkSubfolders";
            this.chkSubfolders.Size = new System.Drawing.Size(114, 17);
            this.chkSubfolders.TabIndex = 12;
            this.chkSubfolders.Text = "Include Subfolders";
            this.chkSubfolders.UseVisualStyleBackColor = true;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(413, 26);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(24, 22);
            this.btnBrowse.TabIndex = 11;
            this.btnBrowse.Text = "...";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Source Folder:";
            // 
            // txtDirSource
            // 
            this.txtDirSource.Location = new System.Drawing.Point(86, 29);
            this.txtDirSource.Name = "txtDirSource";
            this.txtDirSource.Size = new System.Drawing.Size(321, 20);
            this.txtDirSource.TabIndex = 9;
            // 
            // txtLog
            // 
            this.txtLog.Location = new System.Drawing.Point(86, 141);
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(451, 196);
            this.txtLog.TabIndex = 18;
            this.txtLog.Text = "";
            // 
            // btnProcessMP3
            // 
            this.btnProcessMP3.Location = new System.Drawing.Point(443, 55);
            this.btnProcessMP3.Name = "btnProcessMP3";
            this.btnProcessMP3.Size = new System.Drawing.Size(94, 22);
            this.btnProcessMP3.TabIndex = 19;
            this.btnProcessMP3.Tag = "mp3";
            this.btnProcessMP3.Text = "Process MP3s";
            this.btnProcessMP3.UseVisualStyleBackColor = true;
            this.btnProcessMP3.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(443, 113);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(95, 22);
            this.btnAbout.TabIndex = 20;
            this.btnAbout.Text = "About...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // mnuMain
            // 
            this.mnuMain.BackColor = System.Drawing.SystemColors.Control;
            this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mnuMain.Location = new System.Drawing.Point(0, 0);
            this.mnuMain.Name = "mnuMain";
            this.mnuMain.Size = new System.Drawing.Size(554, 24);
            this.mnuMain.TabIndex = 21;
            this.mnuMain.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripSeparator1,
            this.mnuClose});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(170, 22);
            this.toolStripMenuItem1.Text = "&Settings...";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(167, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F10)));
            this.mnuClose.Size = new System.Drawing.Size(170, 22);
            this.mnuClose.Text = "&Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuHelp,
            this.toolStripSeparator3,
            this.mnuHomePage,
            this.mnuSupport,
            this.mnuCheckForUpdates,
            this.toolStripSeparator2,
            this.mnuAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // mnuHomePage
            // 
            this.mnuHomePage.Name = "mnuHomePage";
            this.mnuHomePage.Size = new System.Drawing.Size(188, 22);
            this.mnuHomePage.Text = "Home &Page...";
            this.mnuHomePage.Click += new System.EventHandler(this.mnuHomePage_Click);
            // 
            // mnuSupport
            // 
            this.mnuSupport.Name = "mnuSupport";
            this.mnuSupport.Size = new System.Drawing.Size(188, 22);
            this.mnuSupport.Text = "&Support...";
            this.mnuSupport.Click += new System.EventHandler(this.mnuSupport_Click);
            // 
            // mnuCheckForUpdates
            // 
            this.mnuCheckForUpdates.Enabled = false;
            this.mnuCheckForUpdates.Name = "mnuCheckForUpdates";
            this.mnuCheckForUpdates.Size = new System.Drawing.Size(188, 22);
            this.mnuCheckForUpdates.Text = "Check For Updates...";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(185, 6);
            // 
            // mnuAbout
            // 
            this.mnuAbout.Name = "mnuAbout";
            this.mnuAbout.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.mnuAbout.Size = new System.Drawing.Size(188, 22);
            this.mnuAbout.Text = "&About...";
            this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
            // 
            // mnuHelp
            // 
            this.mnuHelp.Name = "mnuHelp";
            this.mnuHelp.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.mnuHelp.Size = new System.Drawing.Size(188, 22);
            this.mnuHelp.Text = "Online &Help...";
            this.mnuHelp.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(185, 6);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(554, 347);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnProcessMP3);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.chkTra);
            this.Controls.Add(this.btnProcessEPub);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chkSubfolders);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDirSource);
            this.Controls.Add(this.mnuMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.mnuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KTransliter";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.frmMain_HelpButtonClicked);
            this.mnuMain.ResumeLayout(false);
            this.mnuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkTra;
        private System.Windows.Forms.Button btnProcessEPub;
        private System.Windows.Forms.FolderBrowserDialog dlgSourceDir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkSubfolders;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirSource;
        private System.Windows.Forms.RichTextBox txtLog;
        private System.Windows.Forms.Button btnProcessMP3;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuHomePage;
        private System.Windows.Forms.ToolStripMenuItem mnuSupport;
        private System.Windows.Forms.ToolStripMenuItem mnuCheckForUpdates;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuAbout;
        private System.Windows.Forms.ToolStripMenuItem mnuHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

