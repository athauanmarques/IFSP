namespace PizzariaMania
{
    partial class frmAjuda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAjuda));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtMensagem = new MetroFramework.Controls.MetroTextBox();
            this.listNotificacao = new System.Windows.Forms.ListBox();
            this.bntEnviar = new MetroFramework.Controls.MetroButton();
            this.htmlPanel2 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.bntPedidos = new MetroFramework.Controls.MetroTile();
            this.bntCadastro = new MetroFramework.Controls.MetroTile();
            this.bntRelatorios = new MetroFramework.Controls.MetroTile();
            this.lblResultado = new MetroFramework.Controls.MetroLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.metroTile9 = new MetroFramework.Controls.MetroTile();
            this.metroTile8 = new MetroFramework.Controls.MetroTile();
            this.metroTile7 = new MetroFramework.Controls.MetroTile();
            this.htmlPanel3 = new MetroFramework.Drawing.Html.HtmlPanel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 244);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(246, 267);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 169);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(299, 38);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Olá, estou vendo que você esta com dificuldade...\r\nPois bem o que posso ser útil?" +
                "";
            this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(419, 29);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(93, 76);
            this.metroButton1.TabIndex = 15;
            this.metroButton1.Text = "Limpar Caixa \r\nde \r\nmensagem";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(363, 505);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(74, 19);
            this.metroLabel3.TabIndex = 14;
            this.metroLabel3.Text = "Mensagem";
            // 
            // txtMensagem
            // 
            this.txtMensagem.Lines = new string[0];
            this.txtMensagem.Location = new System.Drawing.Point(30, 217);
            this.txtMensagem.MaxLength = 32767;
            this.txtMensagem.Name = "txtMensagem";
            this.txtMensagem.PasswordChar = '\0';
            this.txtMensagem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtMensagem.SelectedText = "";
            this.txtMensagem.Size = new System.Drawing.Size(382, 23);
            this.txtMensagem.TabIndex = 13;
            this.txtMensagem.UseSelectable = true;
            // 
            // listNotificacao
            // 
            this.listNotificacao.FormattingEnabled = true;
            this.listNotificacao.Items.AddRange(new object[] {
            "Chefinho diz: Eai vamos trocar algumas ideas?"});
            this.listNotificacao.Location = new System.Drawing.Point(31, 29);
            this.listNotificacao.Name = "listNotificacao";
            this.listNotificacao.Size = new System.Drawing.Size(382, 160);
            this.listNotificacao.TabIndex = 12;
            this.listNotificacao.SelectedIndexChanged += new System.EventHandler(this.listNotificacao_SelectedIndexChanged);
            // 
            // bntEnviar
            // 
            this.bntEnviar.Location = new System.Drawing.Point(418, 217);
            this.bntEnviar.Name = "bntEnviar";
            this.bntEnviar.Size = new System.Drawing.Size(94, 23);
            this.bntEnviar.TabIndex = 10;
            this.bntEnviar.Text = "Enviar";
            this.bntEnviar.UseSelectable = true;
            this.bntEnviar.Click += new System.EventHandler(this.bntEnviar_Click);
            // 
            // htmlPanel2
            // 
            this.htmlPanel2.AutoScroll = true;
            this.htmlPanel2.AutoScrollMinSize = new System.Drawing.Size(177, 18);
            this.htmlPanel2.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel2.Location = new System.Drawing.Point(22, 19);
            this.htmlPanel2.Name = "htmlPanel2";
            this.htmlPanel2.Size = new System.Drawing.Size(177, 32);
            this.htmlPanel2.TabIndex = 2;
            this.htmlPanel2.Text = "Dúvidas sobre:";
            // 
            // bntPedidos
            // 
            this.bntPedidos.ActiveControl = null;
            this.bntPedidos.Location = new System.Drawing.Point(190, 57);
            this.bntPedidos.Name = "bntPedidos";
            this.bntPedidos.Size = new System.Drawing.Size(102, 42);
            this.bntPedidos.Style = MetroFramework.MetroColorStyle.Red;
            this.bntPedidos.TabIndex = 3;
            this.bntPedidos.Text = "Pedidos";
            this.bntPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntPedidos.UseSelectable = true;
            this.bntPedidos.Click += new System.EventHandler(this.bntPedidos_Click);
            // 
            // bntCadastro
            // 
            this.bntCadastro.ActiveControl = null;
            this.bntCadastro.Location = new System.Drawing.Point(49, 57);
            this.bntCadastro.Name = "bntCadastro";
            this.bntCadastro.Size = new System.Drawing.Size(102, 42);
            this.bntCadastro.Style = MetroFramework.MetroColorStyle.Green;
            this.bntCadastro.TabIndex = 4;
            this.bntCadastro.Text = "Cadastro";
            this.bntCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntCadastro.UseSelectable = true;
            this.bntCadastro.Click += new System.EventHandler(this.bntCadastro_Click);
            // 
            // bntRelatorios
            // 
            this.bntRelatorios.ActiveControl = null;
            this.bntRelatorios.Location = new System.Drawing.Point(337, 57);
            this.bntRelatorios.Name = "bntRelatorios";
            this.bntRelatorios.Size = new System.Drawing.Size(102, 42);
            this.bntRelatorios.Style = MetroFramework.MetroColorStyle.Silver;
            this.bntRelatorios.TabIndex = 5;
            this.bntRelatorios.Text = "Relatórios";
            this.bntRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntRelatorios.UseSelectable = true;
            this.bntRelatorios.Click += new System.EventHandler(this.bntRelatorios_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(10, 114);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(69, 19);
            this.lblResultado.TabIndex = 16;
            this.lblResultado.Text = "Resultado:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.htmlPanel2);
            this.groupBox2.Controls.Add(this.lblResultado);
            this.groupBox2.Controls.Add(this.bntPedidos);
            this.groupBox2.Controls.Add(this.bntCadastro);
            this.groupBox2.Controls.Add(this.bntRelatorios);
            this.groupBox2.Location = new System.Drawing.Point(332, 108);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(533, 171);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opção de dúvidas";
            // 
            // metroTile9
            // 
            this.metroTile9.ActiveControl = null;
            this.metroTile9.Location = new System.Drawing.Point(642, -115);
            this.metroTile9.Name = "metroTile9";
            this.metroTile9.Size = new System.Drawing.Size(102, 42);
            this.metroTile9.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile9.TabIndex = 5;
            this.metroTile9.Text = "Cadastro";
            this.metroTile9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile9.UseSelectable = true;
            // 
            // metroTile8
            // 
            this.metroTile8.ActiveControl = null;
            this.metroTile8.Location = new System.Drawing.Point(354, -115);
            this.metroTile8.Name = "metroTile8";
            this.metroTile8.Size = new System.Drawing.Size(102, 42);
            this.metroTile8.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile8.TabIndex = 4;
            this.metroTile8.Text = "Cadastro";
            this.metroTile8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile8.UseSelectable = true;
            // 
            // metroTile7
            // 
            this.metroTile7.ActiveControl = null;
            this.metroTile7.Location = new System.Drawing.Point(495, -115);
            this.metroTile7.Name = "metroTile7";
            this.metroTile7.Size = new System.Drawing.Size(102, 42);
            this.metroTile7.Style = MetroFramework.MetroColorStyle.Green;
            this.metroTile7.TabIndex = 3;
            this.metroTile7.Text = "Cadastro";
            this.metroTile7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile7.UseSelectable = true;
            // 
            // htmlPanel3
            // 
            this.htmlPanel3.AutoScroll = true;
            this.htmlPanel3.AutoScrollMinSize = new System.Drawing.Size(177, 18);
            this.htmlPanel3.BackColor = System.Drawing.SystemColors.Window;
            this.htmlPanel3.Location = new System.Drawing.Point(327, -153);
            this.htmlPanel3.Name = "htmlPanel3";
            this.htmlPanel3.Size = new System.Drawing.Size(177, 32);
            this.htmlPanel3.TabIndex = 2;
            this.htmlPanel3.Text = "Dúvidas sobre:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(315, -58);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 19);
            this.metroLabel5.TabIndex = 16;
            this.metroLabel5.Text = "REsultado:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.htmlPanel3);
            this.groupBox1.Controls.Add(this.metroButton1);
            this.groupBox1.Controls.Add(this.metroTile7);
            this.groupBox1.Controls.Add(this.metroTile8);
            this.groupBox1.Controls.Add(this.txtMensagem);
            this.groupBox1.Controls.Add(this.metroTile9);
            this.groupBox1.Controls.Add(this.listNotificacao);
            this.groupBox1.Controls.Add(this.bntEnviar);
            this.groupBox1.Location = new System.Drawing.Point(332, 303);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 262);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chat com Chefinho";
            // 
            // frmAjuda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 607);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.pictureBox1);
            this.MaximizeBox = false;
            this.Name = "frmAjuda";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Ajuda";
            this.Load += new System.EventHandler(this.frmAjuda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtMensagem;
        private System.Windows.Forms.ListBox listNotificacao;
        private MetroFramework.Controls.MetroButton bntEnviar;
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel2;
        private MetroFramework.Controls.MetroTile bntPedidos;
        private MetroFramework.Controls.MetroTile bntCadastro;
        private MetroFramework.Controls.MetroTile bntRelatorios;
        private MetroFramework.Controls.MetroLabel lblResultado;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTile metroTile9;
        private MetroFramework.Controls.MetroTile metroTile8;
        private MetroFramework.Controls.MetroTile metroTile7;
        private MetroFramework.Drawing.Html.HtmlPanel htmlPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}