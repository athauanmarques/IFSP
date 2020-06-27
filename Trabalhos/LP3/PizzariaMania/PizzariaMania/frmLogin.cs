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
using Pizzaria.BLL;
using Pizzaria.Modelos;


namespace PizzariaMania
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            lblMensagem.Visible = false;
            timer1.Start();
            this.Opacity = 0.1;
           
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bntNovoCadastro_Click(object sender, EventArgs e)
        {
           
            frmNovoCadastro novo = new frmNovoCadastro();
            novo.ShowDialog();
        }

        private void bntEntrar_Click(object sender, EventArgs e)
        {

            bool resposta = false;

            // Incrementa o contador de tentativas
            Globais.intContador++;

            // Criação da instancia do objeto usuario da classe ModeloUsuarios
            ModelosUsuarios usuario = new ModelosUsuarios();

            // Instancia do objeto da camada Bll que transporta os dados 
            // do formulario.
            UsuariosBLL objUsuariosBll = new UsuariosBLL();
            if (txtUsuarioL.Text == "" || txtSenhaL.Text == "")
            {
                
                MessageBox.Show("Campos em branco! Entre com os dados para o Login!");
               
                txtUsuarioL.Focus();

            }
            else if (txtSenhaL.Text.Trim().Length < 6 || txtSenhaL.Text.Trim().Length > 10)
            {
                MessageBox.Show("A senha deverá ter no mínimo 6 e máximo 10 caracteres!");
                txtUsuarioL.Focus();
            }
            else
            {
                
                // Objeto usuario recebe dados do formulário Login
                usuario.Usuario = txtUsuarioL.Text;
                usuario.Senha = txtSenhaL.Text;
                Globais.strUsuario = txtUsuarioL.Text;

                // O método Login da camada Bll retorna valor boleano para
                //// autenticar ou não o usuário
                resposta = objUsuariosBll.Login(usuario);
            }
            if (resposta == true)
            {

                this.Hide(); //oculta o form

                frmMenu me = new frmMenu();
                me.ShowDialog();
                this.Close();
            }
             else if (resposta == false)
            {
                this.Text = "Login inválido - Tentativa: " + Globais.intContador;
                lblMensagem.Visible = true;
                lblMensagem.Text = this.Text;
                MessageBox.Show("Login Inválido! Tente Novamente!");

                txtUsuarioL.Clear();
                txtSenhaL.Clear();
                txtUsuarioL.Focus();
            }
            if (Globais.intContador > 2)
            {
                lblMensagem.Visible = false;
                MessageBox.Show("Você ultrapassou o limite de tentativas de Login!\n                Por motivo de segurança o aplicativo sera encerrado.");
                this.Close();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.050;
            }
            else
            {
                timer1.Stop();

            }
        }

        private void lblMensagem_Leave(object sender, EventArgs e)
        {
          
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            txtSenhaL.Clear();
            txtUsuarioL.Clear();
            txtUsuarioL.Focus();
        }
    }
}
