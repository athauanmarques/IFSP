using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXER1_Matriz
{
    public partial class strings_exer : Form
    {
        public strings_exer()
        {
            InitializeComponent();
        }

        private void bntMaisculo_Click(object sender, EventArgs e)
        {
            lblStatus1.Text = txtTexto.Text.ToUpper();// transforma em as lestra em maiúsculo
        }

        private void bntMinus_Click(object sender, EventArgs e)
        {
            lblStatus2.Text = txtTexto.Text.ToLower(); // transforma as letras em minúsculo
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close(); // fecha o aplicativo
            /*
             Outra sintaxe
             
             Close()
             Application.Exit();
             
             */
        }

        private void bntContaL_Click(object sender, EventArgs e)
        {
            lblStatus4.Text = " ";
            lblStatus4.Text = Convert.ToString(txtTexto.Text.Length);
        }

        private void bntReplace_Click(object sender, EventArgs e)
        {
            lblStatus4.Text = txtTexto.Text.Replace("p","g"); // troca as posições
        }

        private void bntSubstring_Click(object sender, EventArgs e)
        {
            lblStatus4.Text = txtTexto.Text.Substring(5,3);

            //vai conta qts caracteres neste caso vai rejeitar 5 letras, e vai aparece 3 letras, e vai rejeitar o resto
        }

    }      
}
