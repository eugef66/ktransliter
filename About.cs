using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;

using System.Reflection;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.IO;

namespace KTransliter
{
    partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Text = String.Format("About {0} {0}", AssemblyTitle);
            this.labelProductName.Text = AssemblyProduct;
            this.labelVersion.Text = String.Format("Version {0} {0}", AssemblyVersion);
            this.labelCopyright.Text = AssemblyCopyright;
            this.labelCompanyName.Text = AssemblyCompany;
            this.textBoxDescription.Text = AssemblyDescription;
            cmbAmount.SelectedIndex = 0;
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "&";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "&";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "&";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "&";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void About_Load(object sender, EventArgs e)
        {

        }

        private void btnDonate_Click(object sender, EventArgs e)
        {
            string _Amount="";

            if (cmbAmount.SelectedItem.ToString() == "Other")
            {

                frmInputAmount _inputAmount = new frmInputAmount();
                _inputAmount.ShowDialog(this);
                _Amount = _inputAmount.Amount;
             //_Amount = 
            }
            else
            {
                _Amount = cmbAmount.SelectedItem.ToString();
            }

            decimal _amount;

            if (Decimal.TryParse(_Amount, out _amount) && _amount>0)
            {

                string _url = "https://www.paypal.com/cgi-bin/webscr?";
                _url += "cmd=_donations&business=eugef66@gmail.com";
                _url += "&lc=US";
                _url += "&amount=" + _Amount.Replace("$", "") + ".00";
                _url += "&currency_code=USD";
                _url += "&no_note=0";
                _url += "&item_name=KTransliter Development and Support";
                _url += "&cn=Thank you for your donnation";
                _url += "&no_shipping=1";
                _url += "&currency_code=USD";
                _url += "&bn=PP%2dDonationsBF%3abtn_donateCC_LG%2egif%3aNonHosted";

                System.Diagnostics.Process.Start(_url);

                MessageBox.Show("Thank you for your donation!!!!", "Thank you for your donation!!!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (_amount > 0)
            {
                this.Close();
            }


        }

        private void cmbAmount_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
