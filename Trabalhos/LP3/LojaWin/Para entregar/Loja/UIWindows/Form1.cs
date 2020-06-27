using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UIWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Deseja realmente sair?";

            string textoBarra = "Sair";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            result = MessageBox.Show(mensagem, textoBarra, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientesForm obj = new ClientesForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosForm obj = new ProdutosForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void vendasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VendasForm obj = new VendasForm();
            obj.MdiParent = this;
            obj.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string mensagem = "Programa \"Loja.Net\"\n\nVersão: 1.0.0.1.10\n\n" +
                              "Desenvolvido para a matéria de LP3\npara o segundo semestre de 2014.\n\n" +
                              "Desenvolvedores:\n\nHenrique de Almeida Sanches      136261-5\n" +
                                                  "João Paulo Del Vecchio de Lima   136263-1\n" +
                                                  "Luiz Gustavo Schevenin                 126283-1";

            string textoBarra = "Sobre";

            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result;

            result = MessageBox.Show(mensagem, textoBarra, buttons);
        }

        private void produtosEmFaltaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProdutosEmFaltaForm obj = new ProdutosEmFaltaForm();
            obj.MdiParent = this;
            obj.Show();
        }
    }
}
