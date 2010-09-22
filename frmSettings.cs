using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace KTransliter
{
    public partial class frmSettings : Form
    {

        public frmSettings()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void LoadSettings()
        {

            string _keyName = "";
            bool _value = false;
                        
            // Load Epub Checkboxes
            foreach (Control _checkBox in grpEPUB.Controls)
            {
                
                if (_checkBox.GetType() == typeof(CheckBox))
                {
                    _keyName = _checkBox.Name.Replace("chkEPUB","");

                    Boolean.TryParse(Program.EPUBSettings.GetConfigKey(_keyName, false).Value,out _value);

                    (_checkBox as CheckBox).Checked = _value;



                }
            }


            // Load MP3 Checkboxes
            foreach (Control _checkBox in grpMP3.Controls)
            {
                
                if (_checkBox.GetType() == typeof(CheckBox))
                {
                    _keyName = _checkBox.Name.Replace("chkMP3", "");

                    Boolean.TryParse(Program.MP3Settings.GetConfigKey(_keyName, false).Value, out _value);

                    (_checkBox as CheckBox).Checked = _value;



                }
            }


            






        }
        private void SaveSettings()
        {
            XmlDocument _Settings = new XmlDocument();
            _Settings.Load("ktanc2e.ksf");

            // Process EPUBS

            XmlNode _node = null;
            string _element = "";
            string _xpath = "";
            foreach (Control _checkBox in grpEPUB.Controls)
            {

                if (_checkBox.GetType() == typeof(CheckBox))
                {
                    _element = _checkBox.Name.Replace("chkEPUB","").ToLower();
                    _xpath = @"EPUB/METADATA/add[@key='" + _element + "']";
                    _node = _Settings.DocumentElement.SelectSingleNode(_xpath);
                    _node.Attributes["value"].Value = (_checkBox as CheckBox).Checked.ToString().ToLower();

                }
            }


            // Process MP3s

            foreach (Control _checkBox in grpMP3.Controls)
            {

                if (_checkBox.GetType() == typeof(CheckBox))
                {
                    _element = _checkBox.Name.Replace("chkMP3", "").ToLower();
                    _xpath = @"MP3/METADATA/add[@key='" + _element + "']";
                    _node = _Settings.DocumentElement.SelectSingleNode(_xpath);
                    _node.Attributes["value"].Value = (_checkBox as CheckBox).Checked.ToString().ToLower();


                }
            }

            //Save configuration xml
            //Write modified XmlDocument into MemoryStream
            XmlWriterSettings _xmSet = new XmlWriterSettings();
            _xmSet.Indent = true;
            _xmSet.ConformanceLevel = ConformanceLevel.Auto;
            _xmSet.OmitXmlDeclaration = false;

            XmlWriter _xwrite = XmlWriter.Create("ktanc2e.ksf", _xmSet);
            _Settings.Save(_xwrite);
            _xwrite.Flush();
            _xwrite.Close();
            Program.LoadSettings();
        }

        private void chkIdentifier_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }



    }
}
