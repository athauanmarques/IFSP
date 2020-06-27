namespace PizzariaMania
{
    partial class frmNovoCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNovoCadastro));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.rbtComum = new MetroFramework.Controls.MetroRadioButton();
            this.rbtAdm = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.bntCadastrar = new MetroFramework.Controls.MetroTile();
            this.bntCancelar = new MetroFramework.Controls.MetroButton();
            this.txtSenhaConf = new MetroFramework.Controls.MetroTextBox();
            this.txtSenha = new MetroFramework.Controls.MetroTextBox();
            this.txtFuncao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtUsuario = new MetroFramework.Controls.MetroTextBox();
            this.bntAdicionarFoto = new MetroFramework.Controls.MetroButton();
            this.bntRemoverFoto = new MetroFramework.Controls.MetroButton();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 81);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 618);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 81);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(9, 95);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(125, 25);
            this.metroLabel1.TabIndex = 24;
            this.metroLabel1.Text = "Novo Cadastro";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(0, 81);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(272, 537);
            this.metroTabControl1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabControl1.TabIndex = 25;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.rbtComum);
            this.metroTabPage1.Controls.Add(this.rbtAdm);
            this.metroTabPage1.Controls.Add(this.metroLabel7);
            this.metroTabPage1.Controls.Add(this.bntCadastrar);
            this.metroTabPage1.Controls.Add(this.bntCancelar);
            this.metroTabPage1.Controls.Add(this.txtSenhaConf);
            this.metroTabPage1.Controls.Add(this.txtSenha);
            this.metroTabPage1.Controls.Add(this.txtFuncao);
            this.metroTabPage1.Controls.Add(this.metroLabel6);
            this.metroTabPage1.Controls.Add(this.metroLabel4);
            this.metroTabPage1.Controls.Add(this.metroLabel3);
            this.metroTabPage1.Controls.Add(this.metroLabel2);
            this.metroTabPage1.Controls.Add(this.txtUsuario);
            this.metroTabPage1.Controls.Add(this.bntAdicionarFoto);
            this.metroTabPage1.Controls.Add(this.bntRemoverFoto);
            this.metroTabPage1.Controls.Add(this.pbxFoto);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(264, 495);
            this.metroTabPage1.Style = MetroFramework.MetroColorStyle.Red;
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "Novo Cadastro";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(81, 379);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(96, 19);
            this.metroLabel8.TabIndex = 42;
            this.metroLabel8.Text = "Tipo de acesso";
            // 
            // rbtComum
            // 
            this.rbtComum.AutoSize = true;
            this.rbtComum.Location = new System.Drawing.Point(163, 401);
            this.rbtComum.Name = "rbtComum";
            this.rbtComum.Size = new System.Drawing.Size(67, 15);
            this.rbtComum.TabIndex = 41;
            this.rbtComum.Text = "Comum";
            this.rbtComum.UseSelectable = true;
            // 
            // rbtAdm
            // 
            this.rbtAdm.AutoSize = true;
            this.rbtAdm.Location = new System.Drawing.Point(21, 401);
            this.rbtAdm.Name = "rbtAdm";
            this.rbtAdm.Size = new System.Drawing.Size(99, 15);
            this.rbtAdm.TabIndex = 40;
            this.rbtAdm.Text = "Administrador";
            this.rbtAdm.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(67, 5);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(126, 19);
            this.metroLabel7.TabIndex = 39;
            this.metroLabel7.Text = "Selecione a sua foto";
            // 
            // bntCadastrar
            // 
            this.bntCadastrar.ActiveControl = null;
            this.bntCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCadastrar.Location = new System.Drawing.Point(136, 431);
            this.bntCadastrar.Name = "bntCadastrar";
            this.bntCadastrar.Size = new System.Drawing.Size(107, 61);
            this.bntCadastrar.Style = MetroFramework.MetroColorStyle.Red;
            this.bntCadastrar.TabIndex = 38;
            this.bntCadastrar.Text = "Cadastrar";
            this.bntCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntCadastrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bntCadastrar.UseSelectable = true;
            this.bntCadastrar.Click += new System.EventHandler(this.bntEntrar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(23, 431);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(107, 61);
            this.bntCancelar.TabIndex = 37;
            this.bntCancelar.Text = "Cancelar e Voltar";
            this.bntCancelar.UseSelectable = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // txtSenhaConf
            // 
            this.txtSenhaConf.Lines = new string[0];
            this.txtSenhaConf.Location = new System.Drawing.Point(25, 352);
            this.txtSenhaConf.MaxLength = 32767;
            this.txtSenhaConf.Name = "txtSenhaConf";
            this.txtSenhaConf.PasswordChar = '*';
            this.txtSenhaConf.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenhaConf.SelectedText = "";
            this.txtSenhaConf.Size = new System.Drawing.Size(220, 23);
            this.txtSenhaConf.TabIndex = 36;
            this.txtSenhaConf.UseSelectable = true;
            // 
            // txtSenha
            // 
            this.txtSenha.Lines = new string[0];
            this.txtSenha.Location = new System.Drawing.Point(25, 304);
            this.txtSenha.MaxLength = 32767;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '\0';
            this.txtSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenha.SelectedText = "";
            this.txtSenha.Size = new System.Drawing.Size(220, 23);
            this.txtSenha.TabIndex = 35;
            this.txtSenha.UseSelectable = true;
            // 
            // txtFuncao
            // 
            this.txtFuncao.Lines = new string[0];
            this.txtFuncao.Location = new System.Drawing.Point(21, 256);
            this.txtFuncao.MaxLength = 32767;
            this.txtFuncao.Name = "txtFuncao";
            this.txtFuncao.PasswordChar = '\0';
            this.txtFuncao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFuncao.SelectedText = "";
            this.txtFuncao.Size = new System.Drawing.Size(224, 23);
            this.txtFuncao.TabIndex = 33;
            this.txtFuncao.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(81, 330);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(103, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Confirma Senha";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(103, 282);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Senha";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(103, 234);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Função";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(103, 186);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Usuário";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Lines = new string[0];
            this.txtUsuario.Location = new System.Drawing.Point(25, 208);
            this.txtUsuario.MaxLength = 32767;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.PasswordChar = '\0';
            this.txtUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuario.SelectedText = "";
            this.txtUsuario.Size = new System.Drawing.Size(220, 23);
            this.txtUsuario.TabIndex = 27;
            this.txtUsuario.UseSelectable = true;
            // 
            // bntAdicionarFoto
            // 
            this.bntAdicionarFoto.Location = new System.Drawing.Point(25, 147);
            this.bntAdicionarFoto.Name = "bntAdicionarFoto";
            this.bntAdicionarFoto.Size = new System.Drawing.Size(107, 32);
            this.bntAdicionarFoto.TabIndex = 26;
            this.bntAdicionarFoto.Text = "Adicionar";
            this.bntAdicionarFoto.UseSelectable = true;
            this.bntAdicionarFoto.Click += new System.EventHandler(this.b_Click);
            // 
            // bntRemoverFoto
            // 
            this.bntRemoverFoto.Location = new System.Drawing.Point(138, 147);
            this.bntRemoverFoto.Name = "bntRemoverFoto";
            this.bntRemoverFoto.Size = new System.Drawing.Size(105, 32);
            this.bntRemoverFoto.TabIndex = 25;
            this.bntRemoverFoto.Text = "Remover";
            this.bntRemoverFoto.UseSelectable = true;
            this.bntRemoverFoto.Click += new System.EventHandler(this.bntRemoverFoto_Click);
            // 
            // pbxFoto
            // 
            this.pbxFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxFoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pbxFoto.ErrorImage")));
            this.pbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto.Image")));
            this.pbxFoto.Location = new System.Drawing.Point(25, 27);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(218, 114);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbxFoto.TabIndex = 24;
            this.pbxFoto.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // frmNovoCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(272, 699);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNovoCadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmNovoCadastro";
            this.Load += new System.EventHandler(this.frmNovoCadastro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile bntCadastrar;
        private MetroFramework.Controls.MetroButton bntCancelar;
        private MetroFramework.Controls.MetroTextBox txtSenhaConf;
        private MetroFramework.Controls.MetroTextBox txtSenha;
        private MetroFramework.Controls.MetroTextBox txtFuncao;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtUsuario;
        private MetroFramework.Controls.MetroButton bntAdicionarFoto;
        private MetroFramework.Controls.MetroButton bntRemoverFoto;
        private System.Windows.Forms.PictureBox pbxFoto;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroRadioButton rbtComum;
        private MetroFramework.Controls.MetroRadioButton rbtAdm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.OpenFileDialog ofd;

    }
}