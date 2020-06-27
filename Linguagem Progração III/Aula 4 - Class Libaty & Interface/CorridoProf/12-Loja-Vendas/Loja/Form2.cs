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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /* obs.: 
         * digitação de preço com virgula
         * arrumar tabulação
         * utilizar string com mascara na classe --> preco.ToString("0.00")
         * 
         */

        //instanciando a classe
        produtos p = new produtos();

        private void btnIcluir_Click(object sender, EventArgs e)
        {
            //atribuindo valores para a classe
            p.Codigo = Convert.ToInt32(txtCodigo.Text);
            p.Produto = txtProduto.Text;
            p.Estoque = Convert.ToInt32(txtEstoque.Text);
            p.Preco = Convert.ToDouble(txtPreco.Text);

            p.Incluir();        

            //obtendo valores da classe
            lblStatus.Text = p.Status;
        }

        private void btnAltera_Click(object sender, EventArgs e)
        {
            //atribuindo valores para a classe
            p.Codigo = Convert.ToInt32(txtCodigo.Text);
            p.Produto = txtProduto.Text;
            p.Estoque = Convert.ToInt32(txtEstoque.Text);
            p.Preco = Convert.ToDouble(txtPreco.Text);

            p.Alterar();

            //obtendo valores da classe
            lblStatus.Text = p.Status;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //atribuindo valores para a classe
            p.Codigo = Convert.ToInt32(txtCodigo.Text);
            p.Produto = txtProduto.Text;
            p.Estoque = Convert.ToInt32(txtEstoque.Text);
            p.Preco = Convert.ToDouble(txtPreco.Text);

            p.Excluir();

            //obtendo valores da classe
            lblStatus.Text = p.Status;
        }

    }
}
