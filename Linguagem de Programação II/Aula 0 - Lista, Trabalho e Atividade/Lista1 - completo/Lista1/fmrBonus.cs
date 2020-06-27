using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lista1
{
    public partial class fmrBonus : Form
    {
        public fmrBonus()
        {
            InitializeComponent();
        }

        private void bntBonus_Click(object sender, EventArgs e)
        {
            double nFilho = Convert.ToDouble(txtFilho.Text), result,
                   anosServiço = Convert.ToDouble(txtServiço.Text);

            result = (nFilho * 20) + (anosServiço * 10);

            lblResult.Text = Convert.ToString("Resultado: " + result + " R$");
                   

        }
    }
}
