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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            bool resposta = false;

            // Incrementa o contador de tentativas
            Globais.intContador++;

            // Criação da instancia do objeto usuario da classe ModeloUsuarios
            ModeloUsuarios usuario = new ModeloUsuarios();

            // Instancia do objeto da camada Bll que transporta os dados 
            // do formulario.
            UsuariosBll objUsuariosBll = new UsuariosBll();
            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Campos em branco! Entre com os dados para o Login!");
            }
            else if (txtSenha.Text.Trim().Length < 6 || txtSenha.Text.Trim().Length > 10)
            {
                MessageBox.Show("A senha deverá ter no mínimo 6 e máximo 10 caracteres!");
            }
            else
            {
                // Objeto usuario recebe dados do formulário Login
                usuario.Nome = txtUsuario.Text;
                usuario.Senha = txtSenha.Text;
                Globais.strUsuario = txtUsuario.Text;
                // O método Login da camada Bll retorna valor boleano para
                // autenticar ou não o usuário
                resposta = objUsuariosBll.Login(usuario);
            }
            if (resposta == true)
            {
                // Oculta o formulário Login
                this.Hide();

                // Cria uma instância do formulário Form1
                Form1 objForm1 = new Form1();
                objForm1.Show();
            }
            else if (resposta == false)
            {
                this.Text = "Login - Tentativa " + Globais.intContador;

                lblMensagem.Text = "Login Inválido! Tente Novamente!";

                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }
            if (Globais.intContador > 3)
            {
                MessageBox.Show("Você ultrapassou o limite de tentativas de Login! Contate o suporte!");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
