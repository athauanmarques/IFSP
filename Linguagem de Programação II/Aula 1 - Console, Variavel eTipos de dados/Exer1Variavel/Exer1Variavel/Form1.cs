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
    public partial class frmInclusao : Form
    {
        public frmInclusao()
        {
            InitializeComponent();
        }

        private void bntMostrar_Click(object sender, EventArgs e)
        {
            string curso = "Ads";
            int horas = 30;
            double preco = 100.00;

            lblMens.Text = "Nome do Curso: " + curso + "\n" + "Horas: " + horas + "\n" + "Preço: " + preco;


            /*
             Outra sintaxe:
             * 
             * lblMens.Text = "Nome do Curso: " 
                + curso 
                + "\n" 
                + "Horas: " 
                + horas 
                + "\n" 
                + "Preço: " 
                + preco;
        }
             
             
             
             */
        }
    }
}
