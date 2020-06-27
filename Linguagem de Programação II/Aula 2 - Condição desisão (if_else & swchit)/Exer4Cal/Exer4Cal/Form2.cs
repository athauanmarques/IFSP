using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMostra_Click(object sender, EventArgs e)
        {
            double bimestre1 = 0, bimestre2 = 0, bimestre3 = 0, bimestre4 = 0, total = 0;

            bimestre1 = Convert.ToDouble(txtPri.Text);
            bimestre2 = Convert.ToDouble(txtSeg.Text);
            bimestre3 = Convert.ToDouble(txtTer.Text);
            bimestre4 = Convert.ToDouble(txtQua.Text);

            total = (bimestre1 + bimestre2 + bimestre3 + bimestre4) / 4;

            lblResultado.Text = "O resultado é: " + total.ToString();


        }
    }
}
