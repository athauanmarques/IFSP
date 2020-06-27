using System;
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
    public partial class VendasForm : Form
    {
        public VendasForm()
        {
            InitializeComponent();
        }

        private void VendasForm_Load(object sender, EventArgs e)
        {
            VendasBLL obj = new VendasBLL();
            clienteComboBox.DataSource = obj.ListaDeClientes;
            produtoComboBox.DataSource = obj.ListaDeProdutos;
            
            ;
        }

        private void incluirVendaButton_Click(object sender, EventArgs e)
        {
            // quantidade é obrigatório
            if (quantidadeTextBox.Text.Trim().Length == 0)
            {
                MessageBox.Show("Informe a quantidade.");
            }
            else
            {
                try
                {
                    VendaInformation venda = new VendaInformation();
                    venda.Quantidade = int.Parse(quantidadeTextBox.Text);
                    venda.CodigoCliente = (int)clienteComboBox.SelectedValue;
                    venda.CodigoProduto = (int)produtoComboBox.SelectedValue;

                    VendasBLL obj = new VendasBLL();
                    obj.Incluir(venda);
                    MessageBox.Show("A venda foi realizada com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

     


    }
}