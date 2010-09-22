using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using KTransliter.Epub;
using KTransliter.mp3;

namespace KTransliter
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            try
            {
               

                Control _control = (sender as Control);
                FileTypeBase _processor = null;

                if (ConfirmAction(_control.Tag.ToString()))
                {
                    txtLog.Text += "Processing " + _control.Tag.ToString() + " files:\n\n";
                    txtLog.Refresh();
                    Application.DoEvents();

                    switch (_control.Name)
                    {
                        case "btnProcessEPub":
                            _processor = new EPub();
                           
                            break;
                        case "btnProcessMP3":
                            _processor = new MP3();
                            break;
                        default:
                            return;
                    }
                    _processor.ProcessFolder(txtDirSource.Text, chkSubfolders.Checked, chkTra.Checked, txtLog);
                    txtLog.Text += "\n\n";
                    txtLog.Refresh();
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n" + "=================" + ex.ToString());
            }

        }



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            dlgSourceDir.ShowDialog();
            txtDirSource.Text = dlgSourceDir.SelectedPath;
        }

        private void btnBrowse_Click_1(object sender, EventArgs e)
        {
            dlgSourceDir.ShowDialog();
            txtDirSource.Text = dlgSourceDir.SelectedPath;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            this.Text = "KTransliter (" + this.GetType().Assembly.GetName().Version.ToString()  + ")";
        }

        private bool ConfirmAction(string fileType)
        {
            string _confirmationMessage = "This action will translit all metadata information";
            if (chkTra.Checked) _confirmationMessage += " and file names";
            _confirmationMessage += " of all " + fileType + " files in  " + txtDirSource.Text + " folder";
            if (chkSubfolders.Checked) _confirmationMessage += " and subfolders";
            _confirmationMessage += ".\n\nTHE CHANGES CANNOT BE ROLLED BACK!\n";
            _confirmationMessage += "\nAre you sure?";

            return (MessageBox.Show(_confirmationMessage, "Confirm Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes ? true : false);

        }

        private void frmMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            About _frmAbout = new About();
            _frmAbout.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About _frmAbout = new About();
            _frmAbout.ShowDialog();
        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            About _frmAbout = new About();
            _frmAbout.ShowDialog();
        }

        private void mnuHomePage_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://code.google.com/p/ktransliter/");
        }

        private void mnuSupport_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://groups.google.com/group/ktransliter-support-forum");
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSettings _frmSettings = new frmSettings();
            _frmSettings.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        

    }
}
