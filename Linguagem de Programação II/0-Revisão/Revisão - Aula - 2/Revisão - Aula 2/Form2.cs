using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula_2
{
    public partial class media : Form
    {
        public media()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(txtPri.Text);
            double v2 = Convert.ToDouble(txtSeg.Text);
            double v3 = Convert.ToDouble(TxtTer.Text);
            double v4 = Convert.ToDouble(txtQua.Text);

            double total = (v1 + v2 + v3 + v4)/ 4;

            lblResult.Text = "Resultado: " + total.ToString();



        }
    }
}
