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
        ProdutosBll objProdutosBll = new ProdutosBll();
        ModeloProdutos produto = new ModeloProdutos();

        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            FormataGrid();
        }

        private void AtualizaGrid()
        {
            try
            {
                string filtro = txtPesquisar.Text;
                dgvProdutos.DataSource = objProdutosBll.listarProdutos(filtro);
            }
            catch
            {
                Limpar();
            }
        }

        private void FormataGrid()
        {
            try
            {
                dgvProdutos.Columns[0].HeaderText = "Id Produto";
                dgvProdutos.Columns[0].Width = 80;
                dgvProdutos.Columns[1].HeaderText = "Produto";
                dgvProdutos.Columns[1].Width = 230;
                dgvProdutos.Columns[2].HeaderText = "Preço";
                dgvProdutos.Columns[2].Width = 180;
                dgvProdutos.Columns[3].HeaderText = "Estoque";
                dgvProdutos.Columns[3].Width = 180;
            }
            catch
            {
                Limpar();
            }
        }

        private void Limpar()
        {
            lblIdProduto.Text = "";
            txtProduto.Text = "";
            txtPreco.Text = "";
            txtEstoque.Text = "";
            txtPesquisar.Text = "";
            lblMensagem.Text = "";
            txtProduto.Focus();
            AtualizaGrid();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                produto.Produto = txtProduto.Text;
                produto.Preco = decimal.Parse(txtPreco.Text);
                produto.Estoque = int.Parse(txtEstoque.Text);
                objProdutosBll.inserir(produto);
                lblMensagem.Text = objProdutosBll.Mensagem;
                AtualizaGrid();
            }
            catch
            {
                lblMensagem.Text = "Não foi possível inserir o produto!";
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                produto.Idproduto = int.Parse(lblIdProduto.Text);
                produto.Produto = txtProduto.Text;
                produto.Preco = decimal.Parse(txtPreco.Text);
                produto.Estoque = int.Parse(txtEstoque.Text);
                objProdutosBll.alterar(produto);
                lblMensagem.Text = objProdutosBll.Mensagem;
                AtualizaGrid();
            }
            catch
            {
                lblMensagem.Text = "Não foi possível alterar o produto!";
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool resposta = false;
            if (lblIdProduto.Text.Length == 0)
            {
                lblMensagem.Text = "Um produto deve ser selecionadoparaexclusão";
            }
            else
            {
                try
                {
                    produto.Idproduto = int.Parse(lblIdProduto.Text);
                    resposta = objProdutosBll.excluir(produto);
                    AtualizaGrid();
                    if (resposta == true)
                    {
                        lblMensagem.Text = objProdutosBll.Mensagem;
                    }
                    else
                    {
                        lblMensagem.Text = "O produto não pode ser excluido!";
                    }
                }
                catch
                {
                    Limpar();
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnProdutosEmFalta_Click(object sender, EventArgs e)
        {
            try
            {
                dgvProdutos.DataSource = objProdutosBll.ListaProdutosEmFalta();
            }
            catch
            {
                Limpar();
            }
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdProduto.Text = dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtProduto.Text = dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtPreco.Text = dgvProdutos[2, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtEstoque.Text = dgvProdutos[3, dgvProdutos.CurrentRow.Index].Value.ToString();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            AtualizaGrid();
        }
    }
}
