using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Loja.BLL;
using Loja.Modelos;


namespace Loja.UIWindows
{
    public partial class ProdutoForm : Form
    {
        public ProdutoForm()
        {
            InitializeComponent();
        }
        public void AtualizaGridP()
        {
            // Comunicação com a Camada BLL
            ProdutosBLL obj = new ProdutosBLL();
            produtoDataGridView.DataSource = obj.ListagemP();
            // Atualizando os objetos TextBox
            codigoPTextBox.Text = produtoDataGridView[0,
            produtoDataGridView.CurrentRow.Index].Value.ToString();
            nomePTextBox.Text = produtoDataGridView[1,
            produtoDataGridView.CurrentRow.Index].Value.ToString();
            precoTextBox.Text = produtoDataGridView[2,
            produtoDataGridView.CurrentRow.Index].Value.ToString();
            estoqueTextBox.Text = produtoDataGridView[3,
            produtoDataGridView.CurrentRow.Index].Value.ToString();
        }
        private void ProdutoForm_Load(object sender, EventArgs e)
        {
            AtualizaGridP();
            nomePTextBox.Focus();
        }

        

        

        
        

        private void btnLimparP_Click(object sender, EventArgs e)
        {
            codigoPTextBox.Text = "";
            nomePTextBox.Text = "";
            precoTextBox.Text = "";
            estoqueTextBox.Text = "";
        }

        private void btnIncluirP_Click(object sender, EventArgs e)
        {
            try
            {
                ProdutoInformation produto = new ProdutoInformation();
                produto.Nome = nomePTextBox.Text;
                produto.Preco = Convert.ToDecimal(precoTextBox.Text);
                produto.Estoque = Convert.ToInt32(estoqueTextBox.Text);
                ProdutosBLL obj = new ProdutosBLL();
                obj.IncluirP(produto);
                MessageBox.Show("O produto foi incluído com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        private void btnAlterarP_Click(object sender, EventArgs e)
        {
            /*- Dê um duplo clique no botão Alterar para codificarmos o evento click;
            - Dentro do evento clique do botão Alterar, copie e cole o código abaixo:*/
            if (codigoPTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um produto deve ser selecionado para alteração.");
            }
            else
                try
                {
                    ProdutoInformation produto = new ProdutoInformation();
                    produto.Codigo = int.Parse(codigoPTextBox.Text);
                    produto.Nome = nomePTextBox.Text;
                    produto.Preco = Convert.ToDecimal(precoTextBox.Text);
                    produto.Estoque = Convert.ToInt32(estoqueTextBox.Text);
                    ProdutosBLL obj = new ProdutosBLL();
                    obj.AlterarP(produto);
                    MessageBox.Show("O produto foi alterado com sucesso!");
                    AtualizaGridP();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
        }

        private void btnExcluirP_Click(object sender, EventArgs e)
        {
            if (codigoPTextBox.Text.Length == 0)
            {
                MessageBox.Show("Insira um código de produto para excluir.");
            }
            else
                try
                {

                    ProdutosBLL obj = new ProdutosBLL();
                    obj.ExcluirP(int.Parse(codigoPTextBox.Text));
                    MessageBox.Show("O produto foi excluído com sucesso!");
                    AtualizaGridP();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
        }

       

        

        
    }
}
