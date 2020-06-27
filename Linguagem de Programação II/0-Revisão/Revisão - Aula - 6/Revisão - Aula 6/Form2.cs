using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula_6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            double qtsTotalTinta, TotalGasto;
            double qtsTinta = Convert.ToDouble(txtEntradaQts.Text);

            if (rbtJuca.Checked)
            {

                qtsTotalTinta = 145 / qtsTinta;
                TotalGasto = 90 * qtsTotalTinta;
                txtTotalQts.Text = Convert.ToString(qtsTotalTinta);
                txtTotalgGasto.Text = Convert.ToString(TotalGasto);

            }

            if (rbtTuca.Checked)

            {

                qtsTotalTinta = 180 / qtsTinta;
                TotalGasto = 145 * qtsTotalTinta;
                txtTotalQts.Text = Convert.ToString(qtsTotalTinta);
                txtTotalgGasto.Text = Convert.ToString(TotalGasto);

            
            
            
            }




        }
    }
}
