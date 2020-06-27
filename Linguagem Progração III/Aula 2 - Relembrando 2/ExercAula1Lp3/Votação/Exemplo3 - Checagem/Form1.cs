using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exemplo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            int idade = Convert.ToInt32(txtIdade.Text);

            if ((rbBrasileira.Checked) && (idade > 16))
            {
                label2.Text = "Eleitor pode votar!";
            }
            else
            {
                label2.Text = "Eleitor não pode votar";
            }

        }
    }
}
