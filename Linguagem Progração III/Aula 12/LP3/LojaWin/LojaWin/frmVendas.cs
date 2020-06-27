using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaWin.Bll;
using LojaWin.Modelos;

namespace LojaWin
{
    public partial class frmVendas : Form
    {
        // Objeto da classe Bll
        VendasBll objVendasBll = new VendasBll();

        // Objetos para gerenciar os vículos entre as tabelas do banco
        ModeloVendas objVendas = new ModeloVendas();
        ModeloItensVendas objItens = new ModeloItensVendas();
        ModeloProdutos objProdutos = new ModeloProdutos();
        ModeloClientes objClientes = new ModeloClientes();
        ClientesBll objClientesBll = new ClientesBll();
        ProdutosBll objProdutosBll = new ProdutosBll();
        string filtro = "";

        int idCliente, idProduto;

        public frmVendas()
        {
            InitializeComponent();
        }

        private void frmVendas_Load(object sender, EventArgs e)
        {
            // Carregando a tabela Clientes no comboBox cboClientes
            cboClientes.DataSource = objVendasBll.ListaClientes;
            // Resgatando a chave primária da tabela clientes no comboBox
            cboClientes.ValueMember = "idcliente";
            // Exibindo o campo nome da tabela clientes.
            cboClientes.DisplayMember = "nome";
            cboProdutos.DataSource = objVendasBll.ListaProdutos;
            cboProdutos.ValueMember = "idproduto";
            cboProdutos.DisplayMember = "produto";
            // Não exbindo nenhum item na carga dos comboBoxes.
            cboClientes.SelectedIndex = -1;
            cboProdutos.SelectedIndex = -1;
            // Atualizando os comboBoxes
            cboClientes.Refresh();
            cboProdutos.Refresh();
            dgvVendas.DataSource = objVendasBll.ListarVendas();
            FormatarGrid();
        }

        private void FormatarGrid()
        {
            dgvVendas.Columns[0].HeaderText = "IdVenda";
            dgvVendas.Columns[0].Width = 60;
            dgvVendas.Columns[1].HeaderText = "Cliente";
            dgvVendas.Columns[1].Width = 150;
            dgvVendas.Columns[2].HeaderText = "Data";
            dgvVendas.Columns[2].Width = 80;
            dgvVendas.Columns[3].HeaderText = "Produto";
            dgvVendas.Columns[3].Width = 150;
            dgvVendas.Columns[4].HeaderText = "Preço";
            dgvVendas.Columns[4].Width = 60;
            dgvVendas.Columns[5].HeaderText = "Quant.";
            dgvVendas.Columns[5].Width = 40;
            dgvVendas.Columns[6].HeaderText = "Total";
            dgvVendas.Columns[6].Width = 60;
            dgvVendas.Columns[7].HeaderText = "Estoque";
            dgvVendas.Columns[7].Width = 60;
        }

        private void btnVenda_Click(object sender, EventArgs e)
        {
            try
            {
                int idProduto;
                // São necessários o idcliente e a data para realizar a
                // inserção de dados na tabela vendas e atualizar estoque
                // na tabela produtos.
                objVendas.Idcliente = (int)cboClientes.SelectedValue;
                objVendas.Data = DateTime.Now;
                // São necessários o idproduto, valor_produto e quantidade
                // para inserção de dados na tabela itens_venda e atualizar
                // o valor da venda.
                objItens.Idproduto = (int)cboProdutos.SelectedValue;
                // Este idProduto será lançado em objProdutosBll para resgatar
                // o preço do produto.
                idProduto = (int)cboProdutos.SelectedValue;
                objItens.ValorProduto = objProdutosBll.Preco(idProduto);
                objItens.Quantidade = (int)nudQuantidade.Value;
                lblPreco.Text = objProdutosBll.Preco(idProduto).ToString("#,##0.00");
                // Inserindo dados da venda
                objVendasBll.inserir(objVendas, objItens);
                // Resgatando o valor da venda
                lblIdVenda.Text = objVendas.Idvenda.ToString();
                // Inserindo dados na tabela itens_venda e atualizando o valor da venda.
                objVendasBll.InserirItensVenda(objVendas, objItens);
                // Exibindo o total da venda
                lblTotalVenda.Text = objVendasBll.MostrarValorVenda(objVendas).ToString("#,##0.00");
                dgvVendas.DataSource = objVendasBll.ListarVendas();
                FormatarGrid();
            }
            catch
            {
                MessageBox.Show("Não foi possível realizar a venda!","Erro");
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboProdutos_SelectedIndexChanged(object sender, EventArgs e)
        {
            cboProdutos.Refresh();
        }
    }
}
