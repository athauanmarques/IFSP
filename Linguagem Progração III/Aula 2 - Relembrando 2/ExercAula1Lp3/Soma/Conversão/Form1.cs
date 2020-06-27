using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Conversão
{
    public partial class Conversão : Form
    {
        public Conversão()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Text = "";
            txtNum2.Text = "";
            txtResult.Text = "";
            txtNum1.Focus();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            int n1;
            int n2;
            n1 = Convert.ToInt32(txtNum1.Text);
            n2 = Convert.ToInt32(txtNum2.Text);
            txtResult.Text = (n1 + n2).ToString(); 
        }
    }
}
