using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        Usuarios u = new Usuarios();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtCodigo.Text);
            string nome = txtNome.Text;

            u.Buscar(cod);
            lblStatus.Text = u.Status;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtCodigo.Text);
            string nome = txtNome.Text;

            u.Buscar(nome);
            lblStatus.Text = u.Status;
        }

        private void btnIcluir_Click(object sender, EventArgs e)
        {
            u.Codigo = Convert.ToInt32(txtCodigo.Text);
            u.Nome = txtNome.Text;
            lblStatus.Text = "Status: Incluindo ";
        }
    }
}
