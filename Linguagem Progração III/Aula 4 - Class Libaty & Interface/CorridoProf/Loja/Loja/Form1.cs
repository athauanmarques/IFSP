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

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            Usuario us = new Usuario();
            us.Codigo = Convert.ToInt32(txtCod.Text);
            us.Nome = txtNome.Text;
            us.Incluir();

            lblStatus.Text = us.Status;
        }
    }
}
