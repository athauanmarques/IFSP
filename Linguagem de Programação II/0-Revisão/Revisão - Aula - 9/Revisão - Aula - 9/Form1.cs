using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula___9
{
    public partial class Form1 : Form
    {
        Cliente c = new Cliente();
        Fisica f = new Fisica();
        public Form1()
        {
            InitializeComponent();
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                f.Cod = Convert.ToInt32(txtCodigo.Text);
                f.Cpf = Convert.ToDouble(txtCpf.Text);
                f.Nome = txtNome.Text;
                f.Incluir();
                lblStatus.Text = f.Status;
            }
            catch
            {
                MessageBox.Show("Digite o valor correspondente", "Erro");
            }
        }


        private void bntExcluir_Click(object sender, EventArgs e)
        {
            c.Cod = Convert.ToInt32(txtCodigo.Text);
            c.Excluir();
            lblStatus.Text = c.Status;
        }

       
    }
}
