using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace loja
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            Usuario use = new Usuario();

            int cod = Convert.ToInt32(txtCodigo.Text);
            string nome = txtCodigo.Text;

            use.Codigo = cod;
            use.Nome = nome;

            lblStatus.Text = use.Status;


        }
    }
}
