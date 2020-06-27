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
    public partial class Caluladora : Form
    {
        public Caluladora()
        {
            InitializeComponent();
        }

        private void bntsoma_Click(object sender, EventArgs e)
        {
            double v1, v2, total;

            v1 = Convert.ToDouble(txtValor1.Text);
            v2 = Convert.ToDouble(txtValor2.Text);

            total = v1 + v2;

            txtResult.Text = string.Format("{0:F2}", total);
            //não se esqueça dessa sintaxe
        }

        private void bntSub_Click(object sender, EventArgs e)
        {

            double v1, v2, total;

            v1 = Convert.ToDouble(txtValor1.Text);
            v2 = Convert.ToDouble(txtValor2.Text);

            total = v1 - v2;

            txtResult.Text = total.ToString();
        }

        private void bntDiv_Click(object sender, EventArgs e)
        {
            double v1, v2, total;

            v1 = Convert.ToDouble(txtValor1.Text);
            v2 = Convert.ToDouble(txtValor2.Text);

            total = v1 / v2;

            txtResult.Text = total.ToString();
        }

        private void bntMult_Click(object sender, EventArgs e)
        {
            double v1, v2, total;

            v1 = Convert.ToDouble(txtValor1.Text);
            v2 = Convert.ToDouble(txtValor2.Text);

            total = v1 * v2;

            txtResult.Text = total.ToString();
        }
    }
}
