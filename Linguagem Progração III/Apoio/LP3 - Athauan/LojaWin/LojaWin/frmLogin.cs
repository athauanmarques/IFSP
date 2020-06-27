using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaWin.Modelos;
using LoginWin.BLL;

namespace LojaWin
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void bntOk_Click(object sender, EventArgs e)
        {
            bool resposta = false;

            //incrementar o contador
            Globais.intContador++;

            //crianção da instancia do objeto usuário da classe modelo usário
            ModeloUsuarios usuarios = new ModeloUsuarios();

            //transporta dado para o form
            usuariosBll objUsuariosBll = new usuariosBll();

            if (txtUsuario.Text == "" || txtSenha.Text == "")
            {

                MessageBox.Show("Campos em Branco! Por favor insere as informações necessária para obte o acesso");
            }
            else if (txtUsuario.Text.Trim().Length < 6 || txtSenha.Text.Trim().Length > 10)
            {
                MessageBox.Show("A senha deverá 6 e no máximop 10 caracteres");
            }
            else 
            {
                // passando informações (nome e senha) para classe modelo
                usuarios.Nome = txtUsuario.Text;
                usuarios.Senha = txtSenha.Text;
                Globais.strUsuario = txtUsuario.Text;
                resposta = objUsuariosBll.Login(usuarios); // 

            }

            if (resposta == true)
            { 
            
                this.Hide(); // oculta formulário Login - é mesma cois se colocar frmlogin.Hide(); -- this. faz referencia do form

                Form1 objForm1 = new Form1();    //criando uma instância do form1
                objForm1.Show();
                
            }
            else if (resposta == false)
            {

                this.Text = "Login - Tentativa " + Globais.intContador;

                lblMensagem.Text = " Login Inválido! Tente novamente!";

                txtUsuario.Clear();
                txtSenha.Clear();
                txtUsuario.Focus();
            }

            if (Globais.intContador > 3)
            {
                this.Hide();
                MessageBox.Show("Você ultrapassou o limite de tentativa de longi, por favor comunique-se ao seu surporte técnico");
                this.Close();
            }
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
