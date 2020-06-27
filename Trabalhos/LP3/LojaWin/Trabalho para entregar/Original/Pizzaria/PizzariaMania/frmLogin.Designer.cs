namespace PizzariaMania
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bntEntrar = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bntCancelar = new MetroFramework.Controls.MetroButton();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.bntNovoCadastro = new MetroFramework.Controls.MetroButton();
            this.bntSair = new MetroFramework.Controls.MetroButton();
            this.ptbPizza = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUsuarioL = new MetroFramework.Controls.MetroTextBox();
            this.txtSenhaL = new MetroFramework.Controls.MetroTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblMensagem = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(272, 81);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 618);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(272, 81);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // bntEntrar
            // 
            this.bntEntrar.ActiveControl = null;
            this.bntEntrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntEntrar.Location = new System.Drawing.Point(46, 444);
            this.bntEntrar.Name = "bntEntrar";
            this.bntEntrar.Size = new System.Drawing.Size(178, 49);
            this.bntEntrar.Style = MetroFramework.MetroColorStyle.Red;
            this.bntEntrar.TabIndex = 3;
            this.bntEntrar.Text = "Entrar";
            this.bntEntrar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntEntrar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bntEntrar.UseSelectable = true;
            this.bntEntrar.Click += new System.EventHandler(this.bntEntrar_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(108, 336);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "Usuário";
            // 
            // bntCancelar
            // 
            this.bntCancelar.Location = new System.Drawing.Point(46, 499);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(86, 42);
            this.bntCancelar.TabIndex = 5;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseSelectable = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(108, 384);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(46, 19);
            this.metroLabel2.TabIndex = 6;
            this.metroLabel2.Text = "Senha";
            // 
            // bntNovoCadastro
            // 
            this.bntNovoCadastro.Location = new System.Drawing.Point(46, 547);
            this.bntNovoCadastro.Name = "bntNovoCadastro";
            this.bntNovoCadastro.Size = new System.Drawing.Size(179, 24);
            this.bntNovoCadastro.TabIndex = 7;
            this.bntNovoCadastro.Text = "Novo Cadastro";
            this.bntNovoCadastro.UseSelectable = true;
            this.bntNovoCadastro.Click += new System.EventHandler(this.bntNovoCadastro_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(136, 499);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(89, 42);
            this.bntSair.TabIndex = 6;
            this.bntSair.Text = "Sair";
            this.bntSair.UseSelectable = true;
            this.bntSair.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // ptbPizza
            // 
            this.ptbPizza.Image = ((System.Drawing.Image)(resources.GetObject("ptbPizza.Image")));
            this.ptbPizza.Location = new System.Drawing.Point(66, 184);
            this.ptbPizza.Name = "ptbPizza";
            this.ptbPizza.Size = new System.Drawing.Size(147, 128);
            this.ptbPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPizza.TabIndex = 12;
            this.ptbPizza.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(26, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 43);
            this.label1.TabIndex = 13;
            this.label1.Text = "PizzariaMania";
            // 
            // txtUsuarioL
            // 
            this.txtUsuarioL.Lines = new string[0];
            this.txtUsuarioL.Location = new System.Drawing.Point(46, 358);
            this.txtUsuarioL.MaxLength = 32767;
            this.txtUsuarioL.Name = "txtUsuarioL";
            this.txtUsuarioL.PasswordChar = '\0';
            this.txtUsuarioL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtUsuarioL.SelectedText = "";
            this.txtUsuarioL.Size = new System.Drawing.Size(179, 23);
            this.txtUsuarioL.TabIndex = 0;
            this.txtUsuarioL.UseSelectable = true;
            // 
            // txtSenhaL
            // 
            this.txtSenhaL.Lines = new string[0];
            this.txtSenhaL.Location = new System.Drawing.Point(46, 406);
            this.txtSenhaL.MaxLength = 12;
            this.txtSenhaL.Name = "txtSenhaL";
            this.txtSenhaL.PasswordChar = '*';
            this.txtSenhaL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSenhaL.SelectedText = "";
            this.txtSenhaL.Size = new System.Drawing.Size(178, 23);
            this.txtSenhaL.TabIndex = 1;
            this.txtSenhaL.UseSelectable = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblMensagem
            // 
            this.lblMensagem.AutoSize = true;
            this.lblMensagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensagem.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMensagem.Location = new System.Drawing.Point(43, 599);
            this.lblMensagem.Name = "lblMensagem";
            this.lblMensagem.Size = new System.Drawing.Size(199, 16);
            this.lblMensagem.TabIndex = 22;
            this.lblMensagem.Text = "Login inválido - Tentativa: 0";
            this.lblMensagem.Leave += new System.EventHandler(this.lblMensagem_Leave);
            // 
            // frmLogin
            // 
            this.AcceptButton = this.bntEntrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(272, 699);
            this.Controls.Add(this.lblMensagem);
            this.Controls.Add(this.txtUsuarioL);
            this.Controls.Add(this.txtSenhaL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbPizza);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntNovoCadastro);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.bntEntrar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Ivory;
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private MetroFramework.Controls.MetroTile bntEntrar;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton bntCancelar;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroButton bntNovoCadastro;
        private MetroFramework.Controls.MetroButton bntSair;
        private System.Windows.Forms.PictureBox ptbPizza;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox txtUsuarioL;
        private MetroFramework.Controls.MetroTextBox txtSenhaL;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblMensagem;
    }
}

