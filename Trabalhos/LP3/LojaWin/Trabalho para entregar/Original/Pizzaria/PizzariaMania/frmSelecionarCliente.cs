using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Pizzaria.Modelos;
using Pizzaria.BLL;

namespace PizzariaMania
{
    public partial class frmSelecionarCliente : MetroForm
    {
        public frmSelecionarCliente()
        {
            InitializeComponent();
        }
        ClientesBLL objClientes = new ClientesBLL();
        private void FormataGrid()
        {

           
                dgvClientes.Columns[0].HeaderText = "Código";
                dgvClientes.Columns[0].Width = 120;
                dgvClientes.Columns[1].HeaderText = "Nome";
                dgvClientes.Columns[1].Width = 120;
                dgvClientes.Columns[2].HeaderText = "Endereco";
                dgvClientes.Columns[2].Width = 120;
                dgvClientes.Columns[3].HeaderText = "Telefone";
                dgvClientes.Columns[3].Width = 120;
                dgvClientes.Columns[4].HeaderText = "Cidade";
                dgvClientes.Columns[4].Width = 120;
                dgvClientes.Columns[5].HeaderText = "UF";
                dgvClientes.Columns[5].Width = 80;
                dgvClientes.Columns[6].HeaderText = "Referencias";
                dgvClientes.Columns[6].Width = 160;

            
            

        }

        private void Listar()
        {
            

            Globais.nomeProcura = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
            Globais.telefoneProcura = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
        

        }
        private void ListarDGV()
        {

            string filtro = "";

            try
            {

                dgvClientes.DataSource = objClientes.Listragem(filtro);

            }
            catch
            {
                MessageBox.Show("Não foi possível a conexão com o banco de dados!", "Erro");

            }

            finally
            {
                FormataGrid();
            }

        }


        private void frmSelecionarCliente_Load(object sender, EventArgs e)
        {
            ListarDGV();
        }
        int listaId;
        private void bntSelecionar_Click(object sender, EventArgs e)
        {
            Globais.nomeProcura = Convert.ToString(lbl1.Text);
            Globais.telefoneProcura = Convert.ToString(lbl3.Text);
            Globais.idCliente = Convert.ToInt32(listaId);
            this.Close();
        }
        
        private void dgvClientes_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            Listar();
            
            lbl1.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
            lbl3.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
            listaId = Convert.ToInt32(dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString());
        }
    }
}
