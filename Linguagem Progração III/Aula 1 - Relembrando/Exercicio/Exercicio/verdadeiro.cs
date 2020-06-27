using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class verdadeiro : Form
    {
        public verdadeiro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void rdbBrasil_CheckedChanged(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);

            if (idade => 16)
            {

                lblResultado.Text = "votar";

            }
            else
            {

                lblResultado.Text = "não vota";
            
            }

        }
    }
}
