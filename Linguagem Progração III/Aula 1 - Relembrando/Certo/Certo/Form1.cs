using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Certo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rdbBrasil_CheckedChanged(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);

            if (idade >= 16)
            {

                lblRes.Text = "pode votar";
            
            }

            else
            {
            
                lblRes.Text = "não pode votar";
            
            }
        }

        private void rdbGringo_CheckedChanged(object sender, EventArgs e)
        {
            

                lblRes.Text = "não pode votar";

            
        }
    }
}
