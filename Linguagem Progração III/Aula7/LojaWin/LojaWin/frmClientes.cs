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
    public partial class frmClientes : Form
    {
        ModeloClientes cliente = new ModeloClientes();
        ClientesBll objClientesBll = new ClientesBll();
        string mensagem;

        public frmClientes()
        {
            InitializeComponent();
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            FormataGrid();
        }

        private void FormataGrid()
        {
            try
            {
                dgvClientes.Columns[0].HeaderText = "IdCliente";
                dgvClientes.Columns[0].Width = 60;
                dgvClientes.Columns[1].HeaderText = "Cliente";
                dgvClientes.Columns[1].Width = 200;
                dgvClientes.Columns[2].HeaderText = "e-mail";
                dgvClientes.Columns[2].Width = 200;
                dgvClientes.Columns[3].HeaderText = "Telefone";
                dgvClientes.Columns[3].Width = 100;
            }
            catch
            {
                lblIdCliente.Text = "";
                txtCliente.Text = "";
                txtEmail.Text = "";
                mskTelefone.Text = "";
            }
        }

        private void AtualizaGrid()
        {
            try
            {
                string filtro = txtPesquisar.Text;
                dgvClientes.DataSource = objClientesBll.listagem(filtro);
            }
            catch
            {
                lblIdCliente.Text = "";
                txtCliente.Text = "";
                txtEmail.Text = "";
                mskTelefone.Text = "";
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.Nome = txtCliente.Text;
                cliente.Email = txtEmail.Text;
                cliente.Telefone = mskTelefone.Text;
                mensagem = objClientesBll.incluir(cliente);
                lblIdCliente.Text = cliente.IdCliente.ToString();
                lblMensagem.Text = mensagem;
                AtualizaGrid();
            }
            catch
            {
                lblMensagem.Text = objClientesBll.Mensagem;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.IdCliente = int.Parse(lblIdCliente.Text);
                cliente.Nome = txtCliente.Text;
                cliente.Email = txtEmail.Text;
                cliente.Telefone = mskTelefone.Text;
                mensagem = objClientesBll.alterar(cliente);
                lblMensagem.Text = objClientesBll.Mensagem;
                AtualizaGrid();
            }
            catch
            {
                lblMensagem.Text = objClientesBll.Mensagem;
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool resposta = false;
            if (lblIdCliente.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado para excluir!");
            }
            else
            {
                cliente.IdCliente = int.Parse(lblIdCliente.Text);
                resposta = objClientesBll.excluir(cliente);
                if (resposta == true)
                {
                    mensagem = objClientesBll.Mensagem;
                    lblMensagem.Text = mensagem;
                }
                else
                {
                    lblMensagem.Text = objClientesBll.Mensagem;
                }
            }
            AtualizaGrid();
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdCliente.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
            txtCliente.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
            txtEmail.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
            mskTelefone.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblIdCliente.Text = "";
            txtCliente.Text = "";
            txtEmail.Text = "";
            mskTelefone.Text = "";
            txtPesquisar.Text = "";
            lblMensagem.Text = "";
            AtualizaGrid();
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
