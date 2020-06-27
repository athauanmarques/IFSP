using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Pizzaria.BLL;
using Pizzaria.Modelos;

namespace PizzariaMania
{
    public partial class frmNovoCadastro : Form
    {
       string mensagem = "";
        ModelosUsuarios usuarios = new ModelosUsuarios();
        UsuariosBLL objUsuarios = new UsuariosBLL();
        string diretorio = "Sem foto";
        public frmNovoCadastro()
        {
            InitializeComponent();
        }

        private void frmNovoCadastro_Load(object sender, EventArgs e)
        {
            timer1.Start();
            this.Opacity = 0.1;
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            timer1.Start();
            this.Opacity = 0.1;
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

        private void bntEntrar_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();

                if(rbtAdm.Checked == true && rbtComum.Checked == false)
                    {
                      if (txtSenha.Text != txtSenhaConf.Text)
                      {

                    txtSenha.Clear();
                    txtSenhaConf.Clear();
                    errorProvider1.SetError(txtSenha, "Campo se encontra senha diferente!");
                    MessageBox.Show("As senhas estão diferente, por favor digite novamente.");
                    txtSenha.Focus();

                     }
                      else if (txtUsuario.Text.Trim().Length == 0)
                      {
                          errorProvider1.SetError(txtUsuario, "Campo usuário vazio");
                          MessageBox.Show("Por gentileza informe o nome de usuário para ser cadastrado.", "Campo de usuário vazia!");
                          txtUsuario.Focus();
                      }
                      else if (txtUsuario.Text.Trim().Length <= 5)
                      {
                          errorProvider1.SetError(txtUsuario, "Campo usuário inválido");
                          MessageBox.Show("O nome usuário deve conter mais que 5 caraceteres.", "Campo de usuário vazia!");
                          txtUsuario.Focus();
                      }
                      else if (txtSenha.Text.Trim().Length == 0 || txtSenhaConf.Text.Trim().Length == 0)
                      {

                          txtSenha.Clear();
                          txtSenhaConf.Clear();
                          errorProvider1.SetError(txtSenha, "Campo senha vazio");
                          MessageBox.Show("Por gentileza informe a senha para ser cadastrado.", "Campo de senha vazia");
                          txtSenha.Focus();

                      }
                      else if (txtSenha.Text.Trim().Length > 12 || txtSenhaConf.Text.Trim().Length > 12 || txtSenha.Text.Trim().Length < 6 || txtSenhaConf.Text.Trim().Length < 6)
                      {

                          txtSenha.Clear();
                          txtSenhaConf.Clear();
                          errorProvider1.SetError(txtSenha, "Campo senha inválido");
                          MessageBox.Show("Senha muito curta demais ou muito longa.\nSão permetido entre 6 a 12 caracteres.", "Campo de senha inválido");
                          txtSenha.Focus();

                      }

                      else
                      {
                          usuarios.TipoAcesso = "Administrador";
                          errorProvider1.Clear();
                          usuarios.Senha = txtSenha.Text;
                          usuarios.Foto = diretorio;
                          usuarios.Usuario = txtUsuario.Text;
                          usuarios.Funcao = txtFuncao.Text;
                          objUsuarios.CadastrarUsuarios(usuarios);
                          MessageBox.Show("Cadastro efetuado com sucesso" + mensagem);
                          this.Close();
                          if (txtFuncao.Text.Trim().Length == 0)
                          {
                              MessageBox.Show("O campo foi inserido como'função não declado' no seu cadastro, ok.", "Campo função se encontra vazio");
                          }
                      }
                 }


                else if (rbtAdm.Checked == false && rbtComum.Checked == true)
                {
                    if (txtSenha.Text != txtSenhaConf.Text)
                    {

                        txtSenha.Clear();
                        txtSenhaConf.Clear();
                        errorProvider1.SetError(txtSenha, "Campo se encontra senhas diferentes!");
                        MessageBox.Show("As senhas estão diferente, por favor digite novamente.","Senha diferentes.");
                        txtSenha.Focus();

                    }
                    else if (txtUsuario.Text.Trim().Length == 0)
                    {
                        errorProvider1.SetError(txtUsuario, "Campo usuário vazio");
                        MessageBox.Show("Por gentileza informe o nome de usuário para ser cadastrado.", "Campo de usuário vazia!");
                        txtUsuario.Focus();
                    }
                    else if (txtUsuario.Text.Trim().Length <= 5)
                    {
                        errorProvider1.SetError(txtUsuario, "Campo usuário inválido");
                        MessageBox.Show("O nome usuário deve conter mais que 5 caraceteres.", "Campo de usuário vazia!");
                        txtUsuario.Focus();
                    }
                    else if (txtSenha.Text.Trim().Length == 0 || txtSenhaConf.Text.Trim().Length == 0)
                    {

                        txtSenha.Clear();
                        txtSenhaConf.Clear();
                        errorProvider1.SetError(txtSenha, "Campo senha vazio");
                        MessageBox.Show("Por gentileza informe a senha para ser cadastrado.", "Campo de senha vazia");
                        txtSenha.Focus();

                    }

                    else if (txtSenha.Text.Trim().Length > 12 || txtSenhaConf.Text.Trim().Length > 12 || txtSenha.Text.Trim().Length < 6 || txtSenhaConf.Text.Trim().Length < 6)
                    {

                        txtSenha.Clear();
                        txtSenhaConf.Clear();
                        errorProvider1.SetError(txtSenha, "Campo senha inválido");
                        MessageBox.Show("Só são permitido apenas 6 á 12 caracteres.", "Campo de senha inválido");
                        txtSenha.Focus();

                    }
                   
                    else
                    {
                    usuarios.TipoAcesso = "Comum";
                    errorProvider1.Clear();
                    usuarios.Senha = txtSenha.Text;
                    usuarios.Foto = diretorio;
                    usuarios.Usuario = txtUsuario.Text;
                    usuarios.Funcao = txtFuncao.Text;
                    objUsuarios.CadastrarUsuarios(usuarios);
                    MessageBox.Show("Cadastro efetuado com sucesso","Parabéns");
                    this.Close();
                    if (txtFuncao.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("O campo foi inserido como'função não declado' no seu cadastro, ok.", "Campo função se encontra vazio");
                    }

                    }
                }
                else
                {

                    MessageBox.Show("Por favor selecione o tipo de usuário.","Selecione o Tipo de acesso.");
                    errorProvider1.SetError(metroLabel8, "Campo acesso vazio");

                }
               

            }
            catch
            {

                MessageBox.Show("Ocorreu um erro");
            }

        }

        private void b_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.ofd.Multiselect = true; // abilitando a seleção de foto
            this.ofd.Title = "Seleciona Foto";

            //filtra para exibir somente arquivos de imagens
            ofd.Filter = "Images (*.BMP;*.JPG;*.GIF,*.PNG,*.TIFF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIFF|" + "All files (*.*)|*.*";
            ofd.CheckFileExists = true;
            ofd.CheckPathExists = true;
            ofd.FilterIndex = 2;
            ofd.RestoreDirectory = true;
            ofd.ReadOnlyChecked = true;
            ofd.ShowReadOnly = true;
            DialogResult dr = this.ofd.ShowDialog();

            if (dr == System.Windows.Forms.DialogResult.OK)
            {

                // Le os arquivos selecionados 
                foreach (String arquivo in ofd.FileNames)
                {
                    pbxFoto.Text = arquivo;
                    diretorio = Convert.ToString(pbxFoto.Text);
                    //testa
                    pbxFoto.Text = diretorio;

                    //formatando a foto
                    Image Imagem = Image.FromFile(arquivo);
                    pbxFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbxFoto.Image = Imagem;
                }


            }
        }

        private void bntRemoverFoto_Click(object sender, EventArgs e)
        {
            pbxFoto.ImageLocation = @"";
        }
    }
}
