﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Loja.BLL;
using Loja.DAL;
using Loja.Modelos;

namespace UIWindows
{
    public partial class ProdutosForm : Form
    {
        public ProdutosForm()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        {
            // Comunicação com a Camada BLL
            ProdutosBLL obj = new ProdutosBLL();
            produtosDataGridView.DataSource = obj.Listagem("");

            // Atualizando os objetos TextBox
            codigoTextBox.Text = produtosDataGridView[0, produtosDataGridView.CurrentRow.Index].Value.ToString();
            nomeTextBox.Text = produtosDataGridView[1, produtosDataGridView.CurrentRow.Index].Value.ToString();
            precoTextBox.Text = produtosDataGridView[2, produtosDataGridView.CurrentRow.Index].Value.ToString();
            estoqueTextBox.Text = produtosDataGridView[3, produtosDataGridView.CurrentRow.Index].Value.ToString();
        }

        private void ProdutosForm_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            nomeTextBox.Focus();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            codigoTextBox.Text = "";
            nomeTextBox.Text = "";
            precoTextBox.Text = "";
            estoqueTextBox.Text = "";
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {
            if (incluirButton.Text == "Novo Produto")
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                nomeTextBox.ReadOnly = false;
                precoTextBox.Text = "";
                precoTextBox.ReadOnly = false;
                estoqueTextBox.Text = "";
                estoqueTextBox.ReadOnly = false;
                nomeTextBox.Focus();
                incluirButton.Text = "Incluir Produto";
                alterarButton.Text = "Alterar Produto";
            }
            else
            {
                try
                {
                    ProdutoInformation produto = new ProdutoInformation();

                    produto.Nome = nomeTextBox.Text;
                    produto.Preco = Convert.ToDecimal(precoTextBox.Text);
                    produto.Estoque = Convert.ToInt32(estoqueTextBox.Text);

                    ProdutosBLL obj = new ProdutosBLL();
                    obj.Incluir(produto);
                    MessageBox.Show("O produto foi incluído com sucesso!");
                    codigoTextBox.Text = Convert.ToString(produto.Codigo);

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

                incluirButton.Text = "Novo Produto";
                nomeTextBox.ReadOnly = true;
                precoTextBox.ReadOnly = true;
                estoqueTextBox.ReadOnly = true;

                AtualizaGrid();
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text == "")
            {
                MessageBox.Show("Um produto precisa ser selecionado para alteração.");
                nomeTextBox.ReadOnly = true;
                precoTextBox.ReadOnly = true;
                estoqueTextBox.ReadOnly = true;
                incluirButton.Text = "Novo Produto";
            }
            else
            {
                if (alterarButton.Text == "Alterar Produto")
                {

                    nomeTextBox.ReadOnly = false;
                    precoTextBox.ReadOnly = false;
                    estoqueTextBox.ReadOnly = false;
                    alterarButton.Text = "Salvar alteração";
                    incluirButton.Text = "Novo Produto";

                }
                else
                {
                    try
                    {
                        ProdutoInformation produto = new ProdutoInformation();

                        produto.Codigo = int.Parse(codigoTextBox.Text);
                        produto.Nome = nomeTextBox.Text;
                        produto.Preco = Convert.ToDecimal(precoTextBox.Text);
                        produto.Estoque = Convert.ToInt32(estoqueTextBox.Text);

                        ProdutosBLL obj = new ProdutosBLL();
                        obj.Alterar(produto);
                        MessageBox.Show("O produto foi atualizado com sucesso!");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }

                    alterarButton.Text = "Alterar Produto";
                    nomeTextBox.ReadOnly = true;
                    precoTextBox.ReadOnly = true;
                    estoqueTextBox.ReadOnly = true;

                    AtualizaGrid();
                }
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um produto deve ser selecionado antes da exclusão.");
                nomeTextBox.ReadOnly = true;
                precoTextBox.ReadOnly = true;
                estoqueTextBox.ReadOnly = true;
                incluirButton.Text = "Novo Produto";
                alterarButton.Text = "Alterar Produto";
            }
            else
            {
                nomeTextBox.ReadOnly = true;
                precoTextBox.ReadOnly = true;
                estoqueTextBox.ReadOnly = true;
                incluirButton.Text = "Novo Produto";
                alterarButton.Text = "Alterar Produto";

                string mensagem = "Deseja realmente excluir o produto " + nomeTextBox.Text + " ?";

                string textoBarra = "Confirmar exclusão";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(mensagem, textoBarra, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        int codigo = Convert.ToInt32(codigoTextBox.Text);
                        ProdutosBLL obj = new ProdutosBLL();
                        obj.Excluir(codigo);
                        MessageBox.Show("O produto foi excluído com sucesso!");
                        AtualizaGrid();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);

                    }
                }
            }
        }


        

        private void btFiltro_Click(object sender, EventArgs e)
        {
            // Comunicação com a Camada BLL
            ProdutosBLL obj = new ProdutosBLL();
            produtosDataGridView.DataSource = obj.Listagem(txtFiltro.Text);

            // Atualizando os objetos TextBox
            try
            {
                codigoTextBox.Text = produtosDataGridView[0, produtosDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = produtosDataGridView[1, produtosDataGridView.CurrentRow.Index].Value.ToString();
                precoTextBox.Text = produtosDataGridView[2, produtosDataGridView.CurrentRow.Index].Value.ToString();
                estoqueTextBox.Text = produtosDataGridView[3, produtosDataGridView.CurrentRow.Index].Value.ToString();
                txtFiltro.Text = "";
                txtFiltro.Focus();
            }
            catch
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                precoTextBox.Text = "";
                estoqueTextBox.Text = "";
                txtFiltro.Text = "";
                txtFiltro.Focus();
            }


        }

        private void produtosDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeTextBox.ReadOnly = true;
            precoTextBox.ReadOnly = true;
            estoqueTextBox.ReadOnly = true;
            incluirButton.Text = "Novo Produto";
            alterarButton.Text = "Alterar Produto";

            // Atualizando os objetos TextBox
            codigoTextBox.Text = produtosDataGridView[0, produtosDataGridView.CurrentRow.Index].Value.ToString();
            nomeTextBox.Text = produtosDataGridView[1, produtosDataGridView.CurrentRow.Index].Value.ToString();
            precoTextBox.Text = produtosDataGridView[2, produtosDataGridView.CurrentRow.Index].Value.ToString();
            estoqueTextBox.Text = produtosDataGridView[3, produtosDataGridView.CurrentRow.Index].Value.ToString();
        }

    }
}