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
using System.Xml;
using System.Xml.Schema;

namespace UIWindows
{     
    public partial class ClientesForm : Form
    {
        public ClientesForm()
        {
            InitializeComponent();
        }

        public void AtualizaGrid()
        {
            // Comunicação com a Camada BLL
            ClientesBLL obj = new ClientesBLL();
            clientesDataGridView.DataSource = obj.Listagem(txtFiltro.Text);
    
            // Atualizando os objetos TextBox
            try
            {
                codigoTextBox.Text = clientesDataGridView[0, clientesDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = clientesDataGridView[1, clientesDataGridView.CurrentRow.Index].Value.ToString();
                emailTextBox.Text = clientesDataGridView[2, clientesDataGridView.CurrentRow.Index].Value.ToString();
                telefoneTextBox.Text = clientesDataGridView[3, clientesDataGridView.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                emailTextBox.Text = "";
                telefoneTextBox.Text = "";
            }
            
        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {            
            AtualizaGrid();
            nomeTextBox.Focus();
        }

        private void limparButton_Click(object sender, EventArgs e)
        {            
            codigoTextBox.Text = "";
            nomeTextBox.Text = "";
            emailTextBox.Text = "";
            telefoneTextBox.Text = "";
        }

        private void incluirButton_Click(object sender, EventArgs e)
        {

            if (incluirButton.Text == "Novo Cliente")
            {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                nomeTextBox.ReadOnly = false;
                emailTextBox.Text = "";
                emailTextBox.ReadOnly = false;
                telefoneTextBox.Text = "";
                telefoneTextBox.ReadOnly = false;
                nomeTextBox.Focus();
                incluirButton.Text = "Incluir Cliente";
                alterarButton.Text = "Alterar Cliente";
            }
            else
            {
                try
                {
                    ClienteInformation cliente = new ClienteInformation();
                    cliente.Nome = nomeTextBox.Text;
                    cliente.Email = emailTextBox.Text;
                    cliente.Telefone = telefoneTextBox.Text;


                    ClientesBLL obj = new ClientesBLL();
                    obj.Incluir(cliente);
                    MessageBox.Show("O cliente foi incluído com sucesso!");
                    codigoTextBox.Text = Convert.ToString(cliente.Codigo);
                    AtualizaGrid();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }

                incluirButton.Text = "Novo Cliente"; 
                nomeTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                telefoneTextBox.ReadOnly = true;
            }
        }

        private void alterarButton_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado para alteração.");
                nomeTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                telefoneTextBox.ReadOnly = true;
                incluirButton.Text = "Novo Cliente";
            }
            else
            {
                if (alterarButton.Text == "Alterar Cliente")
                {

                    nomeTextBox.ReadOnly = false;
                    emailTextBox.ReadOnly = false;
                    telefoneTextBox.ReadOnly = false;
                    alterarButton.Text = "Salvar alteração";
                    incluirButton.Text = "Novo Cliente";

                }
                else
                {


                    try
                    {
                        ClienteInformation cliente = new ClienteInformation();
                        cliente.Codigo = int.Parse(codigoTextBox.Text);
                        cliente.Nome = nomeTextBox.Text;
                        cliente.Email = emailTextBox.Text;
                        cliente.Telefone = telefoneTextBox.Text;


                        ClientesBLL obj = new ClientesBLL();
                        obj.Alterar(cliente);
                        MessageBox.Show("O cliente foi alterado com sucesso!");
                        AtualizaGrid();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex.Message);
                    }

                    alterarButton.Text = "Alterar Cliente";
                    nomeTextBox.ReadOnly = true;
                    emailTextBox.ReadOnly = true;
                    telefoneTextBox.ReadOnly = true;
                }
            }
        }

        private void excluirButton_Click(object sender, EventArgs e)
        {
            if (codigoTextBox.Text.Length == 0)
            {
                MessageBox.Show("Um cliente deve ser selecionado antes da exclusão.");
                nomeTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                telefoneTextBox.ReadOnly = true;
                incluirButton.Text = "Novo Cliente";
                alterarButton.Text = "Alterar Cliente";
            }
            else
            {
                nomeTextBox.ReadOnly = true;
                emailTextBox.ReadOnly = true;
                telefoneTextBox.ReadOnly = true;
                incluirButton.Text = "Novo Cliente";
                alterarButton.Text = "Alterar Cliente";

                string mensagem = "Deseja realmente excluir o cliente " + nomeTextBox.Text + " ?";

                string textoBarra = "Confirmar exclusão";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                result = MessageBox.Show(mensagem, textoBarra, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    try
                    {
                        int codigo = Convert.ToInt32(codigoTextBox.Text);
                        ClientesBLL obj = new ClientesBLL();
                        obj.Excluir(codigo);
                        MessageBox.Show("O cliente foi excluído com sucesso!");
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
            ClientesBLL obj = new ClientesBLL();
            clientesDataGridView.DataSource = obj.Listagem(txtFiltro.Text);
            
            // Atualizando os objetos TextBox
            try {
                codigoTextBox.Text =  clientesDataGridView[0, clientesDataGridView.CurrentRow.Index].Value.ToString();
                nomeTextBox.Text = clientesDataGridView[1, clientesDataGridView.CurrentRow.Index].Value.ToString(); ;
                emailTextBox.Text = clientesDataGridView[2, clientesDataGridView.CurrentRow.Index].Value.ToString(); ;
                telefoneTextBox.Text = clientesDataGridView[3, clientesDataGridView.CurrentRow.Index].Value.ToString(); ;
                txtFiltro.Text = "";
                txtFiltro.Focus();
            }
            catch {
                codigoTextBox.Text = "";
                nomeTextBox.Text = "";
                emailTextBox.Text = "";
                telefoneTextBox.Text = "";
                txtFiltro.Text = "";
                txtFiltro.Focus();
            }

        }

        private void clientesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nomeTextBox.ReadOnly = true;
            emailTextBox.ReadOnly = true;
            telefoneTextBox.ReadOnly = true;
            incluirButton.Text = "Novo Cliente";
            alterarButton.Text = "Alterar Cliente";

            // Atualizando os objetos TextBox
            codigoTextBox.Text = clientesDataGridView[0, clientesDataGridView.CurrentRow.Index].Value.ToString();
            nomeTextBox.Text = clientesDataGridView[1, clientesDataGridView.CurrentRow.Index].Value.ToString();
            emailTextBox.Text = clientesDataGridView[2, clientesDataGridView.CurrentRow.Index].Value.ToString();
            telefoneTextBox.Text = clientesDataGridView[3, clientesDataGridView.CurrentRow.Index].Value.ToString();


        }

    }
}
