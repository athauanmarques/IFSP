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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bntMedia2_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, total;

            n1 = Convert.ToDouble(txtNota1.Text);
            n2 = Convert.ToDouble(txtNota2.Text);
            n3 = Convert.ToDouble(txtNota3.Text);
            n4 = Convert.ToDouble(txtNota4.Text);

            total = (n1 + (n2 * n2) + (n3 * n3) + (n4 * n4) / 10);

            lblResult2.Text = " Resultado: " + total.ToString();

        }

        private void bntMedia1_Click(object sender, EventArgs e)
        {

            double n1, n2, n3, n4, total;

            n1 = Convert.ToDouble(txtNota1.Text);
            n2 = Convert.ToDouble(txtNota2.Text);
            n3 = Convert.ToDouble(txtNota3.Text);
            n4 = Convert.ToDouble(txtNota4.Text);

            total = (n1 + n2 + n3 + n4 /4);

            lblResult1.Text = " Resultado: " + total.ToString();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

    }
}
