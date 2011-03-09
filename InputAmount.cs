using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KTransliter
{
    public partial class frmInputAmount : Form
    {
        public frmInputAmount()
        {
            InitializeComponent();
        }

        public string Amount
        {
            get { return txtAmount.Text; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            decimal _amount;
            if (!Decimal.TryParse(txtAmount.Text, out _amount))
            {
                MessageBox.Show("Invalid Amount", "Invalid Amount", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtAmount.Text = "-1";
            this.Close();
        }


    }
}
