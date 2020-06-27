using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIcluir_Click(object sender, EventArgs e)
        {
            //instanciando a classe
            usuarios c = new usuarios();
            
            //atribuindo valores para a classe
            c.Codigo = Convert.ToInt32(txtCodigo.Text);
            c.Nome = txtNome.Text;
            c.Incluir();

            //obtendo valores da classe
            lblStatus.Text = c.Status;


        }
    }
}
