using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exemploSubClass
{
    public partial class Form1 : Form
    {
        Cliente c = new Cliente();
        Fisica f = new Fisica();

        public Form1()
        {
            InitializeComponent();
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            c.Cod = Convert.ToInt32(txtCodigo.Text); 
            // Pegar o que o usuario digitou, e converter para variavel já existente dentro do metodo c.Cod
            c.Excluir();
            // metodo excluir
            lblStatus.Text = c.Status; 
 // Tem chama o metodo que é Status não atributo (pois é uma Herança e não parametro pois é void)
            
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            f.Cod = Convert.ToInt32(txtCodigo.Text);
            f.Nome = txtNome.Text;
            f.Cpf = Convert.ToInt32(txtCpf.Text);
            f.Incluir();
            lblStatus.Text = f.Status;
        }
    }
}
