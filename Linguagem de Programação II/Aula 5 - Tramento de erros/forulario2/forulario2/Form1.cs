using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forulario2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("incluindo", "Produto incluido");
        }

        private void bntAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja alterar", "Alteração", MessageBoxButtons.YesNo);
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Excluir", "Produtos", MessageBoxButtons.YesNo);
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
            // ou Close();
        }

        private void bntVoltar_Click(object sender, EventArgs e)
        {
            FormInicial voltar = new FormInicial();
            voltar.ShowDialog();
        }

        

       
    }
}
