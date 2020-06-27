using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelos;
using AcessaDados;
using RegraNegocio;

namespace ExemploCamadas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             AtualizaGrid();
        }

        //visualiza dados da tabela Cliente
        private void AtualizaGrid()
        {
            ClienteBLL obj = new ClienteBLL();
            dgvClientes.DataSource = obj.Listagem();
            //Format();
        }

        //visualiza dados filtrados no txtFiltro
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ClienteBLL obj = new ClienteBLL();
            dgvClientes.DataSource = obj.Listagem(txtFiltro.Text);
            
            Limpa();
            txtFiltro.Focus();
        }

        public void Limpa()
        {
            txtCod.Text = " ";
            txtCliente.Text = " ";
            txtEnd.Text = " ";
            txtTel.Text = " ";
            txtFiltro.Text = "";
         }               

        private void btnInserir_Click(object sender, EventArgs e)
        {
            InfoCliente ic = new InfoCliente();
            ic.Cliente = txtCliente.Text;
            ic.Telefone = txtTel.Text;
            ic.Endereco = txtEnd.Text;

            /*
            string cliente;
            string telefone;
            string endereco;

            cliente = "'";
            cliente += txtCliente.Text;
            cliente += "'";

            telefone = "'";
            telefone += txtTel.Text;
            telefone += "'";

            endereco = "'";
            endereco += txtEnd.Text;
            endereco += "'";
            */
            
            ClienteBLL obj = new ClienteBLL();

            lblStatus.Text = obj.Inserir(ic);

            AtualizaGrid();
            Limpa();
            txtCliente.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            string cliente;
            string telefone;
            string end;
            int id;

            cliente = txtCliente.Text;
            telefone = txtTel.Text;
            end = txtEnd.Text;
            id = Convert.ToInt32(txtCod.Text);

            ClienteBLL obj = new ClienteBLL();
            lblStatus.Text = obj.Alterar(id, cliente, telefone, end);
            AtualizaGrid();
            Limpa();
        }

        //evento CellClick do DataGridView para selecionar um registro e visualizar nos TextBox
        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtCod.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
                txtCliente.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
                txtTel.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
                txtEnd.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                txtCod.Text = " ";
                txtCliente.Text = " ";
                txtEnd.Text = " ";
                txtTel.Text = " ";
            }       
        }

        //Excluir dados
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id;

            id = Convert.ToInt32(txtCod.Text.ToString());

            if (MessageBox.Show("Deseja Realmente Excluir?", "Warning", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
            {
                ClienteBLL obj = new ClienteBLL();
                lblStatus.Text = obj.Excluir(id);
                AtualizaGrid();
                Limpa();
            }
            else
            {
                MessageBox.Show("Operação cancelada...", "Warning");
            }
        }

        //Formatar DataGridView
        private void Format()
        {
            dgvClientes.Columns[0].Width = 50;
            dgvClientes.Columns[1].Width = 150;
            dgvClientes.Columns[2].Width = 80;
            //tamanho do DataGridView
            dgvClientes.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvClientes.ScrollBars = ScrollBars.Vertical;
            //visualize com e sem o comando abaixo
            dgvClientes.RowHeadersVisible = false;
        }
    }
}
