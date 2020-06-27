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
    public partial class frmUsuarios : Form
    {
        // Objeto usuario coletará os dados da interface gráfica
        ModeloUsuarios usuario = new ModeloUsuarios();
        // O objeto objUsuariosBll, transportará o objeto usuario à camada de regra de negócios.
        UsuariosBll objUsuariosBll = new UsuariosBll();

        public frmUsuarios()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Campo em Branco!Entre com o nome do usuário!");
                txtUsuario.Focus();
            }
            else if (txtSenha.Text == "")
            {
                MessageBox.Show("Campo em Branco!Entre com a senha do usuário!");
                txtSenha.Focus();
            }
            else
            {
                usuario.Nome = txtUsuario.Text;
                usuario.Senha = txtSenha.Text;
                lblMensagem.Text = objUsuariosBll.Incluir(usuario);
                lblIdUsuario.Text = usuario.IdUsuario.ToString();
                ListaUsuarios();
            }
        }

        private void ListaUsuarios()
        {
            string filtro = "";
            try
            {
                dgvUsuarios.DataSource = objUsuariosBll.Listagem(filtro);
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

        private void FormataGrid()
        {
            try
            {
                // Cabeçalho idUsuario
                dgvUsuarios.Columns[0].HeaderText = "IdUsuário";
                // Lagura da coluna do grid
                dgvUsuarios.Columns[0].Width = 60;
                dgvUsuarios.Columns[1].HeaderText = "Usuário";
                dgvUsuarios.Columns[1].Width = 120;
                dgvUsuarios.Columns.Remove("senha");
            }
            catch
            {
                lblIdUsuario.Text = "";
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            ListaUsuarios();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                usuario.IdUsuario = int.Parse(lblIdUsuario.Text);
                usuario.Nome = txtUsuario.Text;
                usuario.Senha = txtSenha.Text;
                lblMensagem.Text = objUsuariosBll.Alterar(usuario);
                ListaUsuarios();
            }
            catch
            {
                lblMensagem.Text = "";
                txtUsuario.Text = "";
                txtSenha.Text = "";
            }
            finally
            {
                FormataGrid();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            bool resposta = false;
            if (lblIdUsuario.Text == "")
            {
                lblMensagem.Text = "Selecione o usuário antes de excluí-lo!";
            }
            else
            {
                try
                {
                    usuario.IdUsuario = int.Parse(lblIdUsuario.Text);
                    resposta = objUsuariosBll.Excluir(usuario);
                    if (resposta == true)
                    {
                        lblMensagem.Text = objUsuariosBll.Mensagem;
                        ListaUsuarios();
                    }
                    else
                    {
                        lblMensagem.Text = "O usuario não podeser excluído!"; 
                    }
                }
                catch
                {
                    lblIdUsuario.Text = "";
                    txtUsuario.Text = "";
                    txtSenha.Text = "";
                }
            }
        }

        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdUsuario.Text = dgvUsuarios[0, dgvUsuarios.CurrentRow.Index].Value.ToString();
            txtUsuario.Text = dgvUsuarios[1, dgvUsuarios.CurrentRow.Index].Value.ToString();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblIdUsuario.Text = "";
            txtUsuario.Text = "";
            txtSenha.Text = "";
            lblMensagem.Text = "";
            txtPesquisar.Text = "";
            ListaUsuarios();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = txtPesquisar.Text;
            try
            {
                dgvUsuarios.DataSource = objUsuariosBll.Listagem(filtro);
                FormataGrid();
                lblIdUsuario.Text = dgvUsuarios[0, dgvUsuarios.CurrentRow.Index].Value.ToString();
                txtUsuario.Text = dgvUsuarios[1, dgvUsuarios.CurrentRow.Index].Value.ToString();
            }
            catch
            {
                lblIdUsuario.Text = "";
                txtUsuario.Text = "";
                txtSenha.Text = "";
                lblMensagem.Text = "";
                txtPesquisar.Text = "";
            }
        }
    }
}
