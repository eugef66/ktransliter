namespace KTransliter
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.tabSettings = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpEPUB = new System.Windows.Forms.GroupBox();
            this.chkEPUBPublisher = new System.Windows.Forms.CheckBox();
            this.chkEPUBSubject = new System.Windows.Forms.CheckBox();
            this.chkEPUBContributor = new System.Windows.Forms.CheckBox();
            this.chkEPUBCreator = new System.Windows.Forms.CheckBox();
            this.chkEPUBIdentifier = new System.Windows.Forms.CheckBox();
            this.chkEPUBLanguage = new System.Windows.Forms.CheckBox();
            this.chkEPUBTitle = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpMP3 = new System.Windows.Forms.GroupBox();
            this.chkMP3Title = new System.Windows.Forms.CheckBox();
            this.chkMP3Performers = new System.Windows.Forms.CheckBox();
            this.chkMP3Grouping = new System.Windows.Forms.CheckBox();
            this.chkMP3Genres = new System.Windows.Forms.CheckBox();
            this.chkMP3Copyright = new System.Windows.Forms.CheckBox();
            this.chkMP3Conductor = new System.Windows.Forms.CheckBox();
            this.chkMP3Composers = new System.Windows.Forms.CheckBox();
            this.chkMP3Comment = new System.Windows.Forms.CheckBox();
            this.chkMP3Artists = new System.Windows.Forms.CheckBox();
            this.chkMP3AlbumArtists = new System.Windows.Forms.CheckBox();
            this.chkMP3Album = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox12 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.tabSettings.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpEPUB.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpMP3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.tabPage1);
            this.tabSettings.Controls.Add(this.tabPage2);
            this.tabSettings.Location = new System.Drawing.Point(2, 12);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.SelectedIndex = 0;
            this.tabSettings.Size = new System.Drawing.Size(220, 313);
            this.tabSettings.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.grpEPUB);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(212, 287);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "EPUB";
            // 
            // grpEPUB
            // 
            this.grpEPUB.Controls.Add(this.chkEPUBPublisher);
            this.grpEPUB.Controls.Add(this.chkEPUBSubject);
            this.grpEPUB.Controls.Add(this.chkEPUBContributor);
            this.grpEPUB.Controls.Add(this.chkEPUBCreator);
            this.grpEPUB.Controls.Add(this.chkEPUBIdentifier);
            this.grpEPUB.Controls.Add(this.chkEPUBLanguage);
            this.grpEPUB.Controls.Add(this.chkEPUBTitle);
            this.grpEPUB.Location = new System.Drawing.Point(3, 3);
            this.grpEPUB.Name = "grpEPUB";
            this.grpEPUB.Size = new System.Drawing.Size(200, 278);
            this.grpEPUB.TabIndex = 0;
            this.grpEPUB.TabStop = false;
            this.grpEPUB.Text = "Modify following metadata";
            // 
            // chkEPUBPublisher
            // 
            this.chkEPUBPublisher.AutoSize = true;
            this.chkEPUBPublisher.Location = new System.Drawing.Point(7, 158);
            this.chkEPUBPublisher.Name = "chkEPUBPublisher";
            this.chkEPUBPublisher.Size = new System.Drawing.Size(69, 17);
            this.chkEPUBPublisher.TabIndex = 6;
            this.chkEPUBPublisher.Text = "Publisher";
            this.chkEPUBPublisher.UseVisualStyleBackColor = true;
            // 
            // chkEPUBSubject
            // 
            this.chkEPUBSubject.AutoSize = true;
            this.chkEPUBSubject.Location = new System.Drawing.Point(7, 135);
            this.chkEPUBSubject.Name = "chkEPUBSubject";
            this.chkEPUBSubject.Size = new System.Drawing.Size(62, 17);
            this.chkEPUBSubject.TabIndex = 5;
            this.chkEPUBSubject.Text = "Subject";
            this.chkEPUBSubject.UseVisualStyleBackColor = true;
            // 
            // chkEPUBContributor
            // 
            this.chkEPUBContributor.AutoSize = true;
            this.chkEPUBContributor.Location = new System.Drawing.Point(6, 112);
            this.chkEPUBContributor.Name = "chkEPUBContributor";
            this.chkEPUBContributor.Size = new System.Drawing.Size(77, 17);
            this.chkEPUBContributor.TabIndex = 4;
            this.chkEPUBContributor.Text = "Contributor";
            this.chkEPUBContributor.UseVisualStyleBackColor = true;
            // 
            // chkEPUBCreator
            // 
            this.chkEPUBCreator.AutoSize = true;
            this.chkEPUBCreator.Location = new System.Drawing.Point(6, 89);
            this.chkEPUBCreator.Name = "chkEPUBCreator";
            this.chkEPUBCreator.Size = new System.Drawing.Size(60, 17);
            this.chkEPUBCreator.TabIndex = 3;
            this.chkEPUBCreator.Text = "Creator";
            this.chkEPUBCreator.UseVisualStyleBackColor = true;
            // 
            // chkEPUBIdentifier
            // 
            this.chkEPUBIdentifier.AutoSize = true;
            this.chkEPUBIdentifier.Location = new System.Drawing.Point(7, 66);
            this.chkEPUBIdentifier.Name = "chkEPUBIdentifier";
            this.chkEPUBIdentifier.Size = new System.Drawing.Size(66, 17);
            this.chkEPUBIdentifier.TabIndex = 2;
            this.chkEPUBIdentifier.Text = "Identifier";
            this.chkEPUBIdentifier.UseVisualStyleBackColor = true;
            this.chkEPUBIdentifier.CheckedChanged += new System.EventHandler(this.chkIdentifier_CheckedChanged);
            // 
            // chkEPUBLanguage
            // 
            this.chkEPUBLanguage.AutoSize = true;
            this.chkEPUBLanguage.Location = new System.Drawing.Point(7, 43);
            this.chkEPUBLanguage.Name = "chkEPUBLanguage";
            this.chkEPUBLanguage.Size = new System.Drawing.Size(74, 17);
            this.chkEPUBLanguage.TabIndex = 1;
            this.chkEPUBLanguage.Text = "Language";
            this.chkEPUBLanguage.UseVisualStyleBackColor = true;
            // 
            // chkEPUBTitle
            // 
            this.chkEPUBTitle.AutoSize = true;
            this.chkEPUBTitle.Location = new System.Drawing.Point(7, 20);
            this.chkEPUBTitle.Name = "chkEPUBTitle";
            this.chkEPUBTitle.Size = new System.Drawing.Size(46, 17);
            this.chkEPUBTitle.TabIndex = 0;
            this.chkEPUBTitle.Text = "Title";
            this.chkEPUBTitle.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.grpMP3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(212, 287);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "MP3";
            // 
            // grpMP3
            // 
            this.grpMP3.Controls.Add(this.chkMP3Title);
            this.grpMP3.Controls.Add(this.chkMP3Performers);
            this.grpMP3.Controls.Add(this.chkMP3Grouping);
            this.grpMP3.Controls.Add(this.chkMP3Genres);
            this.grpMP3.Controls.Add(this.chkMP3Copyright);
            this.grpMP3.Controls.Add(this.chkMP3Conductor);
            this.grpMP3.Controls.Add(this.chkMP3Composers);
            this.grpMP3.Controls.Add(this.chkMP3Comment);
            this.grpMP3.Controls.Add(this.chkMP3Artists);
            this.grpMP3.Controls.Add(this.chkMP3AlbumArtists);
            this.grpMP3.Controls.Add(this.chkMP3Album);
            this.grpMP3.Location = new System.Drawing.Point(3, 3);
            this.grpMP3.Name = "grpMP3";
            this.grpMP3.Size = new System.Drawing.Size(200, 277);
            this.grpMP3.TabIndex = 1;
            this.grpMP3.TabStop = false;
            this.grpMP3.Text = "Modify following metadata";
            // 
            // chkMP3Title
            // 
            this.chkMP3Title.AutoSize = true;
            this.chkMP3Title.Location = new System.Drawing.Point(6, 249);
            this.chkMP3Title.Name = "chkMP3Title";
            this.chkMP3Title.Size = new System.Drawing.Size(46, 17);
            this.chkMP3Title.TabIndex = 10;
            this.chkMP3Title.Text = "Title";
            this.chkMP3Title.UseVisualStyleBackColor = true;
            // 
            // chkMP3Performers
            // 
            this.chkMP3Performers.AutoSize = true;
            this.chkMP3Performers.Location = new System.Drawing.Point(7, 226);
            this.chkMP3Performers.Name = "chkMP3Performers";
            this.chkMP3Performers.Size = new System.Drawing.Size(76, 17);
            this.chkMP3Performers.TabIndex = 9;
            this.chkMP3Performers.Text = "Performers";
            this.chkMP3Performers.UseVisualStyleBackColor = true;
            // 
            // chkMP3Grouping
            // 
            this.chkMP3Grouping.AutoSize = true;
            this.chkMP3Grouping.Location = new System.Drawing.Point(7, 203);
            this.chkMP3Grouping.Name = "chkMP3Grouping";
            this.chkMP3Grouping.Size = new System.Drawing.Size(69, 17);
            this.chkMP3Grouping.TabIndex = 8;
            this.chkMP3Grouping.Text = "Grouping";
            this.chkMP3Grouping.UseVisualStyleBackColor = true;
            // 
            // chkMP3Genres
            // 
            this.chkMP3Genres.AutoSize = true;
            this.chkMP3Genres.Location = new System.Drawing.Point(7, 180);
            this.chkMP3Genres.Name = "chkMP3Genres";
            this.chkMP3Genres.Size = new System.Drawing.Size(60, 17);
            this.chkMP3Genres.TabIndex = 7;
            this.chkMP3Genres.Text = "Genres";
            this.chkMP3Genres.UseVisualStyleBackColor = true;
            // 
            // chkMP3Copyright
            // 
            this.chkMP3Copyright.AutoSize = true;
            this.chkMP3Copyright.Location = new System.Drawing.Point(7, 158);
            this.chkMP3Copyright.Name = "chkMP3Copyright";
            this.chkMP3Copyright.Size = new System.Drawing.Size(70, 17);
            this.chkMP3Copyright.TabIndex = 6;
            this.chkMP3Copyright.Text = "Copyright";
            this.chkMP3Copyright.UseVisualStyleBackColor = true;
            // 
            // chkMP3Conductor
            // 
            this.chkMP3Conductor.AutoSize = true;
            this.chkMP3Conductor.Location = new System.Drawing.Point(7, 135);
            this.chkMP3Conductor.Name = "chkMP3Conductor";
            this.chkMP3Conductor.Size = new System.Drawing.Size(75, 17);
            this.chkMP3Conductor.TabIndex = 5;
            this.chkMP3Conductor.Text = "Conductor";
            this.chkMP3Conductor.UseVisualStyleBackColor = true;
            // 
            // chkMP3Composers
            // 
            this.chkMP3Composers.AutoSize = true;
            this.chkMP3Composers.Location = new System.Drawing.Point(6, 112);
            this.chkMP3Composers.Name = "chkMP3Composers";
            this.chkMP3Composers.Size = new System.Drawing.Size(78, 17);
            this.chkMP3Composers.TabIndex = 4;
            this.chkMP3Composers.Text = "Composers";
            this.chkMP3Composers.UseVisualStyleBackColor = true;
            // 
            // chkMP3Comment
            // 
            this.chkMP3Comment.AutoSize = true;
            this.chkMP3Comment.Location = new System.Drawing.Point(6, 89);
            this.chkMP3Comment.Name = "chkMP3Comment";
            this.chkMP3Comment.Size = new System.Drawing.Size(70, 17);
            this.chkMP3Comment.TabIndex = 3;
            this.chkMP3Comment.Text = "Comment";
            this.chkMP3Comment.UseVisualStyleBackColor = true;
            // 
            // chkMP3Artists
            // 
            this.chkMP3Artists.AutoSize = true;
            this.chkMP3Artists.Location = new System.Drawing.Point(7, 66);
            this.chkMP3Artists.Name = "chkMP3Artists";
            this.chkMP3Artists.Size = new System.Drawing.Size(54, 17);
            this.chkMP3Artists.TabIndex = 2;
            this.chkMP3Artists.Text = "Artists";
            this.chkMP3Artists.UseVisualStyleBackColor = true;
            // 
            // chkMP3AlbumArtists
            // 
            this.chkMP3AlbumArtists.AutoSize = true;
            this.chkMP3AlbumArtists.Location = new System.Drawing.Point(7, 43);
            this.chkMP3AlbumArtists.Name = "chkMP3AlbumArtists";
            this.chkMP3AlbumArtists.Size = new System.Drawing.Size(86, 17);
            this.chkMP3AlbumArtists.TabIndex = 1;
            this.chkMP3AlbumArtists.Text = "Album Artists";
            this.chkMP3AlbumArtists.UseVisualStyleBackColor = true;
            // 
            // chkMP3Album
            // 
            this.chkMP3Album.AutoSize = true;
            this.chkMP3Album.Location = new System.Drawing.Point(7, 20);
            this.chkMP3Album.Name = "chkMP3Album";
            this.chkMP3Album.Size = new System.Drawing.Size(55, 17);
            this.chkMP3Album.TabIndex = 0;
            this.chkMP3Album.Text = "Album";
            this.chkMP3Album.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(7, 158);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(80, 17);
            this.checkBox8.TabIndex = 6;
            this.checkBox8.Text = "checkBox7";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(7, 135);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(80, 17);
            this.checkBox9.TabIndex = 5;
            this.checkBox9.Text = "checkBox6";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(6, 112);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(80, 17);
            this.checkBox10.TabIndex = 4;
            this.checkBox10.Text = "checkBox5";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(6, 89);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(80, 17);
            this.checkBox11.TabIndex = 3;
            this.checkBox11.Text = "checkBox4";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox12
            // 
            this.checkBox12.AutoSize = true;
            this.checkBox12.Location = new System.Drawing.Point(7, 66);
            this.checkBox12.Name = "checkBox12";
            this.checkBox12.Size = new System.Drawing.Size(80, 17);
            this.checkBox12.TabIndex = 2;
            this.checkBox12.Text = "checkBox3";
            this.checkBox12.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(7, 43);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(80, 17);
            this.checkBox13.TabIndex = 1;
            this.checkBox13.Text = "checkBox2";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(7, 20);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(80, 17);
            this.checkBox14.TabIndex = 0;
            this.checkBox14.Text = "checkBox1";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(14, 331);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(69, 24);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(140, 331);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(69, 24);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(226, 365);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.tabSettings);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.tabSettings.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpEPUB.ResumeLayout(false);
            this.grpEPUB.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpMP3.ResumeLayout(false);
            this.grpMP3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabSettings;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpEPUB;
        private System.Windows.Forms.CheckBox chkEPUBPublisher;
        private System.Windows.Forms.CheckBox chkEPUBSubject;
        private System.Windows.Forms.CheckBox chkEPUBContributor;
        private System.Windows.Forms.CheckBox chkEPUBCreator;
        private System.Windows.Forms.CheckBox chkEPUBIdentifier;
        private System.Windows.Forms.CheckBox chkEPUBLanguage;
        private System.Windows.Forms.CheckBox chkEPUBTitle;
        private System.Windows.Forms.GroupBox grpMP3;
        private System.Windows.Forms.CheckBox chkMP3Copyright;
        private System.Windows.Forms.CheckBox chkMP3Conductor;
        private System.Windows.Forms.CheckBox chkMP3Composers;
        private System.Windows.Forms.CheckBox chkMP3Comment;
        private System.Windows.Forms.CheckBox chkMP3Artists;
        private System.Windows.Forms.CheckBox chkMP3AlbumArtists;
        private System.Windows.Forms.CheckBox chkMP3Album;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox12;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox chkMP3Title;
        private System.Windows.Forms.CheckBox chkMP3Performers;
        private System.Windows.Forms.CheckBox chkMP3Grouping;
        private System.Windows.Forms.CheckBox chkMP3Genres;
    }
}