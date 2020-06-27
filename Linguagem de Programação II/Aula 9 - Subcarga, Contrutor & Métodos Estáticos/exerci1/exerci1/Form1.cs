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
    public partial class Form1 : Form
    {
        Usuario usuClass = new Usuario();

        public Form1()
        {
            InitializeComponent();
        }

        private void bntCodigo_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtCodigo.Text);
            string nome = txtNome.Text;


            usuClass.Buscar(cod); // nome da classe, metodo(nomeAtributo)
            lblResultado.Text = usuClass.Status; // nome da Clase.nomeDoVariavel que utilizar

        }

        private void bntNome_Click(object sender, EventArgs e)
        {
            int cod = Convert.ToInt32(txtCodigo.Text);
            string nome = txtNome.Text;

            usuClass.Buscar(nome);
            lblResultado.Text = usuClass.Status;
        }
    }
}
