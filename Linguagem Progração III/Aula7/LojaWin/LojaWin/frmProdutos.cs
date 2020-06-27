using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaWin.Modelos;
using LojaWin.Bll;

namespace LojaWin
{
    public partial class frmProdutos : Form
    {

        ProdutosBLL objProdutoBLL = new ProdutosBLL();
        ModelosProdutos produto = new ModelosProdutos();

        public frmProdutos()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            FormataGrid();
        }

        private void FormataGrid()
        {
            try
            {
                dgvProdutos.Columns[0].HeaderText = "IdProduto";
                dgvProdutos.Columns[0].Width = 60;
                dgvProdutos.Columns[1].HeaderText = "Produto";
                dgvProdutos.Columns[1].Width = 200;
                dgvProdutos.Columns[2].HeaderText = "Preco";
                dgvProdutos.Columns[2].Width = 200;
                dgvProdutos.Columns[3].HeaderText = "Estoque";
                dgvProdutos.Columns[3].Width = 100;
            }
            catch
            {
                lblIdProduto.Text = "";
                txtProduto.Text = "";
                txtPreco.Text = "";
                txtEstoque.Text = "";
            }
        }

        private void AtualizaGrid()
        {
            try
            {
                string filtro = txtPesquisar.Text;
                dgvProdutos.DataSource = objProdutoBLL.Listagem(filtro);
            }
            catch
            {
                lblIdProduto.Text = "";
                txtProduto.Text = "";
                txtPreco.Text = "";
                txtEstoque.Text = "";
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {

            try
            {
                produto.Produto = txtProduto.Text;
                produto.Preco = decimal.Parse(txtPreco.Text);
                produto.Estoque = Convert.ToInt32(txtEstoque.Text);
                objProdutoBLL.Inserir(produto);
                lblMensagem.Text = objProdutoBLL.Mensagem;
                AtualizaGrid();
            }
            catch
            {
                lblMensagem.Text = objProdutoBLL.Mensagem;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                produto.IdProdutos = int.Parse(lblIdProduto.Text);
                produto.Produto = txtProduto.Text;
                produto.Preco = decimal.Parse(txtPreco.Text);
                produto.Estoque = Convert.ToInt32(txtEstoque.Text);
                objProdutoBLL.Alterar(produto);
                lblMensagem.Text = objProdutoBLL.Mensagem;
                AtualizaGrid();
            }
            catch
            {
                lblMensagem.Text = objProdutoBLL.Mensagem;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool resposta;
            if (lblIdProduto.Text.Length == 0)
            {

                lblMensagem.Text = "UIm produto de ser selecionado para exclusão";
            }
            else
            {

                try
                {
                    produto.IdProdutos = int.Parse(lblIdProduto.Text);
                    resposta = objProdutoBLL.Excluir(produto);
                    lblMensagem.Text = objProdutoBLL.Mensagem;
                    AtualizaGrid();

                    if (resposta == true)
                    {

                        lblMensagem.Text = objProdutoBLL.Mensagem;
                    }
                    else
                    {

                        lblMensagem.Text = "Deu B.O na exclusão";
                    
                    }
                }
                catch
                {
                    lblIdProduto.Text = "";
                    txtProduto.Text = "";
                    txtPreco.Text = "";
                    txtEstoque.Text = "";
                }
            
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblIdProduto.Text = "";
            txtProduto.Text = "";
            txtPreco.Text = "";
            txtEstoque.Text = "";
        }

        private void bntProdutosEmFalta_Click(object sender, EventArgs e)
        {
            try 
            {
                dgvProdutos.DataSource = objProdutoBLL.produtosListagemEmFalta();
            
            }
            catch 
            {
                lblIdProduto.Text = "";
                txtProduto.Text = "";
                txtPreco.Text = "";
                txtEstoque.Text = "";
            
            } 
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdProduto.Text = dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtProduto.Text = dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtPreco.Text = dgvProdutos[2, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtEstoque.Text = dgvProdutos[3, dgvProdutos.CurrentRow.Index].Value.ToString();
        }




    }
}
