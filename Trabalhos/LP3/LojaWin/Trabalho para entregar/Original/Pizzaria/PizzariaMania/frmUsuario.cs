using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using Pizzaria.BLL;
using Pizzaria.Modelos;

namespace PizzariaMania
{
    public partial class frmUsuario : MetroForm
    {
        UsuariosBLL objUsuario = new UsuariosBLL();
        ModelosUsuarios usuarios = new ModelosUsuarios();
        string mensagem = "";
        string diretorio = "";

        

        public frmUsuario()
        {
            InitializeComponent();
        }

        private void frmUsuario_Load(object sender, EventArgs e)
        {
            pbxAltFotoRemover.Visible = false;
            pbxAltFoto.Visible = true;
            lblAviso.Visible = false;
           
            ListarUsuario();
            tcSelecao.SelectedTab = tbVisao;

            txtAltFuncao.ReadOnly = true;
            txtAltSenha.ReadOnly = true;
            txtAltSenhaTest.ReadOnly = true;
            txtAltUsuario.ReadOnly = true;
            bntAdicionar.Enabled = false;
            bntRemoverFoto.Enabled = false;

            if (Globais.tipoAcessoLogi == "Comum")
            {
                bntExcluirConta.Visible = false;
                bntAlterar1.Visible = false;
                lblAviso.Visible = true;
                rbtAdm.Enabled = false;
          
                    
            }

            string strData, strDia, strMes, strAno;
            strDia = DateTime.Now.Day.ToString("00");
            strMes = DateTime.Now.Month.ToString("00");
            strAno = DateTime.Now.Year.ToString("0000");
            strData = strDia + " / " + strMes + " / " + strAno + " | ";
            lblData.Text = strData;
            lblEquipamento.Text = Environment.MachineName;

            lblNome.Text = Globais.strUsuario;
            lblVerificar.Text = Globais.tipoAcessoLogi;
          
            // Configuração do timer
            // A propriedade Enabled habilita o timer.
            timer1.Enabled = true;
            // A propriedade Interval determina o intervalo de tempo em milissegundos
            // 1000 ms = 1 s
            timer1.Interval = 1000;
        }



        public void FormataGrid()
        {
            try
            {

                dgvUsuario.Columns[0].HeaderText = "Código";
                dgvUsuario.Columns[0].Width = 120;
                dgvUsuario.Columns[1].HeaderText = "Nome Usuario";
                dgvUsuario.Columns[1].Width = 120;
                dgvUsuario.Columns[2].HeaderText = "Função";
                dgvUsuario.Columns[2].Width = 120;
                dgvUsuario.Columns[3].HeaderText = "Senha";
                dgvUsuario.Columns[3].Width = 120;
                dgvUsuario.Columns[4].HeaderText = "Tipo de acesso";
                dgvUsuario.Columns[4].Width = 120;
                dgvUsuario.Columns[5].HeaderText = "Foto";
                dgvUsuario.Columns[5].Width = 120;

            }
            catch
            {
                lblTesteID.Text = "";
                txtAltUsuario.Clear();
                txtAltFuncao.Clear();
                txtAltSenhaTest.Clear();
                txtAltSenha.Clear();

            }


        }

        private void ListarUsuario()
        {

            //Globais.strUsuario;
            string pfiltro = "";

            try
            {
                dgvUsuario.DataSource = objUsuario.Listragem(pfiltro);
                
                
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

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage3_Click(object sender, EventArgs e)
        {

        }

        private void metroTabPage2_Click(object sender, EventArgs e)
        {

        }

        private void bntExcluirConta_Click(object sender, EventArgs e)
        {
            ListarUsuario();
            bool resposta = false;
            DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir esta conta\n" + txtAltUsuario.Text + " ?", "Excluir conta.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {

                if (lblTesteID.Text.Length == 0)
                {
                    MessageBox.Show("Um cliente deve ser selecionado para excluir!");
                }
                else
                {
                    usuarios.IdUsuarios = Convert.ToInt32(lblTesteID.Text);
                    resposta = objUsuario.Excluir_Conta(usuarios);
                    if (resposta == true)
                    {
                        mensagem = objUsuario.Mensagem;
                        MessageBox.Show("A conta do número: " + lblTesteID.Text + " foi removido com sucesso.");
                    }
                    else
                    {
                        MessageBox.Show("A conta não pode ser removido.");
                    }
                }
            }

            ListarUsuario();
        }




        private void dgvUsuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pbxAltFotoRemover.Visible = false;
            pbxAltFoto.Visible = true;
            txtAltFuncao.ReadOnly = false;
            txtAltSenha.ReadOnly = false;
            txtAltSenhaTest.ReadOnly = false;
            txtAltUsuario.ReadOnly = false;
            bntAdicionar.Enabled = true;
            bntRemoverFoto.Enabled = true;

           
                lblTesteID.Text = dgvUsuario[0, dgvUsuario.CurrentRow.Index].Value.ToString();
                txtAltFuncao.Text = dgvUsuario[2, dgvUsuario.CurrentRow.Index].Value.ToString();

                txtAltUsuario.Text = dgvUsuario[1, dgvUsuario.CurrentRow.Index].Value.ToString();
                txtAltSenha.Text = dgvUsuario[3, dgvUsuario.CurrentRow.Index].Value.ToString();
                txtAltSenhaTest.Text = dgvUsuario[3, dgvUsuario.CurrentRow.Index].Value.ToString();
                string endereco = dgvUsuario[5, dgvUsuario.CurrentRow.Index].Value.ToString();
                string acesso = dgvUsuario[4, dgvUsuario.CurrentRow.Index].Value.ToString();


                if (acesso == "Administrador")
                {

                    rbtAdm.Checked = true;
                }
                else
                {

                    rbtComum.Checked = true;
                }

                pbxAltFoto.ImageLocation = @endereco;
            
        }

        private void bntAlteraUsuario_Click(object sender, EventArgs e)
        {

            string caminhoFoto = pbxAltFoto.ImageLocation;
            usuarios.Funcao = txtAltFuncao.Text;
            usuarios.Foto = caminhoFoto;
            usuarios.Senha = txtAltSenha.Text;
            usuarios.Usuario = txtAltUsuario.Text;
            usuarios.IdUsuarios = Convert.ToInt32(lblTesteID.Text);



        }

        private void bntAlteraUsuario_Click_1(object sender, EventArgs e)
        {
            ListarUsuario();
            if (txtAltSenha.Text != txtAltSenhaTest.Text)
            {

                MessageBox.Show("As senhas tem ser o mesmo.");
                txtAltSenhaTest.Clear();
                txtAltSenha.Clear();
                txtAltSenha.Focus();
            }
             
            else if (txtAltFuncao.Text.Trim().Length == 0 && txtAltSenha.Text.Trim().Length == 0 && txtAltSenhaTest.Text.Trim().Length == 0 &&
                txtAltUsuario.Text.Trim().Length == 0)
            {

                MessageBox.Show("Por gentileza selecione o usuário na opção 'Selecionar Contas'", "Conta não selecionada.");
            }
            else if (txtAltUsuario.Text.Trim().Length == 0)
            {

                MessageBox.Show("Por favor informe o nome de usuário.", "Campo usuário se encontra vazio.");
            }
            else if (txtAltUsuario.Text != Globais.strUsuario)
            {
                if (Globais.tipoAcessoLogi == "Comum")
                {
                    MessageBox.Show("Acesso negado: você não pode altera conta que não seja a sua.", "Alterar conta aviso!.");
                }
                else 
                { 
                 if (rbtAdm.Checked == true)
               {
                usuarios.IdUsuarios = int.Parse(lblTesteID.Text);
                usuarios.Funcao = txtAltFuncao.Text;
                usuarios.Senha = txtAltSenha.Text;
                usuarios.Usuario = txtAltUsuario.Text;
                usuarios.Foto = pbxAltFoto.ImageLocation;
                usuarios.TipoAcesso = "Administrador";
                mensagem = objUsuario.AlterarUsuario(usuarios);
                MessageBox.Show("Alteração concluido com sucesso.\n" + mensagem, "Alteração usuário");
                if (txtAltUsuario.Text == Globais.strUsuario)
                {
                    Globais.tipoAcessoLogi = "Administrador";
                }
            }
            else if (rbtComum.Checked == true)
            {
                usuarios.IdUsuarios = Convert.ToInt32(lblTesteID.Text);
                usuarios.Funcao = txtAltFuncao.Text;
                usuarios.Senha = txtAltSenha.Text;
                usuarios.Usuario = txtAltUsuario.Text;
                usuarios.Foto = pbxAltFoto.ImageLocation;
                usuarios.TipoAcesso = "Comum";
                objUsuario.AlterarUsuario(usuarios);
                MessageBox.Show("Alteração concluido com sucesso.");
                if (txtAltUsuario.Text == Globais.strUsuario)
                {
                    Globais.tipoAcessoLogi = "Comum";
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione o tipo de acesso");
            }
                }

            }


            else if (rbtAdm.Checked == true)
            {
                usuarios.IdUsuarios = int.Parse(lblTesteID.Text);
                usuarios.Funcao = txtAltFuncao.Text;
                usuarios.Senha = txtAltSenha.Text;
                usuarios.Usuario = txtAltUsuario.Text;
                usuarios.Foto = pbxAltFoto.ImageLocation;
                usuarios.TipoAcesso = "Administrador";
                mensagem = objUsuario.AlterarUsuario(usuarios);
                MessageBox.Show("Alteração concluido com sucesso.\n" + mensagem, "Alteração usuário");
                if (txtAltUsuario.Text == Globais.strUsuario)
                {
                    Globais.tipoAcessoLogi = "Administrador";
                }
            }
            else if (rbtComum.Checked == true)
            {
                usuarios.IdUsuarios = Convert.ToInt32(lblTesteID.Text);
                usuarios.Funcao = txtAltFuncao.Text;
                usuarios.Senha = txtAltSenha.Text;
                usuarios.Usuario = txtAltUsuario.Text;
                usuarios.Foto = pbxAltFoto.ImageLocation;
                usuarios.TipoAcesso = "Comum";
                objUsuario.AlterarUsuario(usuarios);
                MessageBox.Show("Alteração concluido com sucesso.");
                if (txtAltUsuario.Text == Globais.strUsuario)
                {
                    Globais.tipoAcessoLogi = "Comum";
                }
            }
            else
            {
                MessageBox.Show("Por favor selecione o tipo de acesso");
            }
            ListarUsuario();
        }

        private void bntAdicionar_Click(object sender, EventArgs e)
        {
            pbxAltFotoRemover.Visible = false;
            pbxAltFoto.Visible = true;
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
                    pbxAltFoto.Text = arquivo;
                    diretorio = Convert.ToString(pbxAltFoto.Text);
               
                    //formatando a foto
                    Image Imagem = Image.FromFile(arquivo);
                    pbxAltFoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    pbxAltFoto.Image = Imagem;
                }

            }


        }

        private void bntAlterar1_Click(object sender, EventArgs e)
        {
            ListarUsuario();
            tcSelecao.SelectedTab = tbAlterar;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string strRelogio, strHora, strMinuto, strSegundo;
            strHora = DateTime.Now.Hour.ToString("00");
            strMinuto = DateTime.Now.Minute.ToString("00");
            strSegundo = DateTime.Now.Second.ToString("00");
            strRelogio = strHora + " : " + strMinuto + " : " + strSegundo;
            lblHora.Text = strRelogio;
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel14_Click(object sender, EventArgs e)
        {

        }

        private void lblEquipamento_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void lblHora_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bntAtualizar_Click(object sender, EventArgs e)
        {
            ListarUsuario();
        }

        private void bntRemoverFoto_Click(object sender, EventArgs e)
        {
            pbxAltFoto.ImageLocation = "";
            pbxAltFotoRemover.Visible = true;
            pbxAltFoto.Visible = false;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void dgvUsuario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }


    }


    
}
