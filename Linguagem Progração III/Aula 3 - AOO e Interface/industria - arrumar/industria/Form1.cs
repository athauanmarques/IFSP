using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace industria
{
    public partial class bntAlterar : Form
    {
        Produto p = new Produto();
        Produto2 p2 = new Produto2();

        public bntAlterar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        int codigo = Convert.ToInt32(txtCod.Text), preco = Convert.ToInt32(txtPreco.Text);
        string produtos = txtPro.Text, status = lblStatus.Text;
        double estoque = Convert.ToDouble(txtEstoque.Text);

        
            // jogando valores da classe Produto o "p" é instanciando do Produto
        p.Codigo = codigo;
        p.Preco = preco;
        p.Produtos = produtos;
        p.Estoque = estoque;
        p.AlterarStatus();
        lblStatus.Text = p.Status;

       
         
        
        }

        private void bntAlterar_Load(object sender, EventArgs e)
        {

        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txtCod.Text), preco = Convert.ToInt32(txtPreco.Text);
            string produtos = txtPro.Text;
            double estoque = Convert.ToDouble(txtEstoque.Text);

            p2.Codigo = codigo;
            p2.Preco = preco;
            p2.Produtos = produtos;
            p2.Estoque = estoque;
            p2.Excluir();
            lblStatus.Text = p2.Status;

        }
    }
}
