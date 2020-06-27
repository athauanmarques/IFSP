using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula_Revisão
{
    public partial class inicial : Form
    {
        public inicial()
        {
            InitializeComponent();
        }

        private void bntExe1_Click(object sender, EventArgs e)
        {
            frmProdutos exercio1 = new frmProdutos();
            exercio1.ShowDialog();
        }

        private void bntFim_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntExer2_Click(object sender, EventArgs e)
        {
            exer2 exer2 = new exer2();
            exer2.ShowDialog();
        }

        private void bntExer3_Click(object sender, EventArgs e)
        {
            exer3 exer3 = new exer3();
            exer3.ShowDialog();
        }

        

        
    }
}
