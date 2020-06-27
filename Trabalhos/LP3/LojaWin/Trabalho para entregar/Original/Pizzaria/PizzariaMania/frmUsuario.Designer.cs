namespace PizzariaMania
{
    partial class frmUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tcSelecao = new MetroFramework.Controls.MetroTabControl();
            this.tbVisao = new MetroFramework.Controls.MetroTabPage();
            this.lblEquipamento = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.lblHora = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.lblData = new MetroFramework.Controls.MetroLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.lblVerificar = new MetroFramework.Controls.MetroLabel();
            this.pbxFoto = new System.Windows.Forms.PictureBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.lblFunção = new MetroFramework.Controls.MetroLabel();
            this.lbl = new MetroFramework.Controls.MetroLabel();
            this.tbAlterar = new MetroFramework.Controls.MetroTabPage();
            this.pbxAltFotoRemover = new System.Windows.Forms.PictureBox();
            this.lblTesteID = new System.Windows.Forms.Label();
            this.lblTipoAcesso = new MetroFramework.Controls.MetroLabel();
            this.rbtComum = new MetroFramework.Controls.MetroRadioButton();
            this.rbtAdm = new MetroFramework.Controls.MetroRadioButton();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.bntAlteraUsuario = new MetroFramework.Controls.MetroTile();
            this.txtAltSenha = new MetroFramework.Controls.MetroTextBox();
            this.txtAltSenhaTest = new MetroFramework.Controls.MetroTextBox();
            this.txtAltFuncao = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.txtAltUsuario = new MetroFramework.Controls.MetroTextBox();
            this.bntAdicionar = new MetroFramework.Controls.MetroButton();
            this.bntRemoverFoto = new MetroFramework.Controls.MetroButton();
            this.pbxAltFoto = new System.Windows.Forms.PictureBox();
            this.tbContas = new MetroFramework.Controls.MetroTabPage();
            this.lblAviso = new MetroFramework.Controls.MetroLabel();
            this.bntAtualizar = new MetroFramework.Controls.MetroTile();
            this.bntAlterar1 = new MetroFramework.Controls.MetroTile();
            this.dgvUsuario = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.bntExcluirConta = new MetroFramework.Controls.MetroTile();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcSelecao.SuspendLayout();
            this.tbVisao.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).BeginInit();
            this.tbAlterar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltFotoRemover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltFoto)).BeginInit();
            this.tbContas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(20, 545);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(516, 81);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(20, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(516, 81);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tcSelecao
            // 
            this.tcSelecao.Controls.Add(this.tbVisao);
            this.tcSelecao.Controls.Add(this.tbAlterar);
            this.tcSelecao.Controls.Add(this.tbContas);
            this.tcSelecao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcSelecao.Location = new System.Drawing.Point(20, 141);
            this.tcSelecao.Name = "tcSelecao";
            this.tcSelecao.SelectedIndex = 1;
            this.tcSelecao.Size = new System.Drawing.Size(516, 404);
            this.tcSelecao.Style = MetroFramework.MetroColorStyle.Red;
            this.tcSelecao.TabIndex = 26;
            this.tcSelecao.UseSelectable = true;
            // 
            // tbVisao
            // 
            this.tbVisao.Controls.Add(this.lblEquipamento);
            this.tbVisao.Controls.Add(this.metroLabel12);
            this.tbVisao.Controls.Add(this.lblHora);
            this.tbVisao.Controls.Add(this.metroLabel10);
            this.tbVisao.Controls.Add(this.lblData);
            this.tbVisao.Controls.Add(this.groupBox1);
            this.tbVisao.Controls.Add(this.lbl);
            this.tbVisao.HorizontalScrollbarBarColor = true;
            this.tbVisao.HorizontalScrollbarHighlightOnWheel = false;
            this.tbVisao.HorizontalScrollbarSize = 10;
            this.tbVisao.Location = new System.Drawing.Point(4, 38);
            this.tbVisao.Name = "tbVisao";
            this.tbVisao.Size = new System.Drawing.Size(508, 362);
            this.tbVisao.TabIndex = 2;
            this.tbVisao.Text = "Visão Geral da Conta";
            this.tbVisao.VerticalScrollbarBarColor = true;
            this.tbVisao.VerticalScrollbarHighlightOnWheel = false;
            this.tbVisao.VerticalScrollbarSize = 10;
            this.tbVisao.Click += new System.EventHandler(this.metroTabPage3_Click);
            // 
            // lblEquipamento
            // 
            this.lblEquipamento.AutoSize = true;
            this.lblEquipamento.Location = new System.Drawing.Point(380, 308);
            this.lblEquipamento.Name = "lblEquipamento";
            this.lblEquipamento.Size = new System.Drawing.Size(27, 19);
            this.lblEquipamento.TabIndex = 35;
            this.lblEquipamento.Text = "pc ";
            this.lblEquipamento.Click += new System.EventHandler(this.lblEquipamento_Click);
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(167, 308);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(52, 19);
            this.metroLabel12.TabIndex = 34;
            this.metroLabel12.Text = " | Hora:";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(216, 308);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(63, 19);
            this.lblHora.TabIndex = 33;
            this.lblHora.Text = "hh:mm:ss";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(282, 308);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(105, 19);
            this.metroLabel10.TabIndex = 32;
            this.metroLabel10.Text = " | Equipamento: ";
            this.metroLabel10.Click += new System.EventHandler(this.metroLabel10_Click);
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(87, 308);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(91, 19);
            this.lblData.TabIndex = 31;
            this.lblData.Text = "dd/mm/aaaa ";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.metroLabel5);
            this.groupBox1.Controls.Add(this.lblVerificar);
            this.groupBox1.Controls.Add(this.pbxFoto);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.lblFunção);
            this.groupBox1.Location = new System.Drawing.Point(44, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(431, 277);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sua Conta";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(141, 194);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(56, 19);
            this.metroLabel5.TabIndex = 33;
            this.metroLabel5.Text = "Usuário:";
            // 
            // lblVerificar
            // 
            this.lblVerificar.AutoSize = true;
            this.lblVerificar.Location = new System.Drawing.Point(215, 213);
            this.lblVerificar.Name = "lblVerificar";
            this.lblVerificar.Size = new System.Drawing.Size(49, 19);
            this.lblVerificar.TabIndex = 32;
            this.lblVerificar.Text = "Acesso";
            // 
            // pbxFoto
            // 
            this.pbxFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbxFoto.Image")));
            this.pbxFoto.Location = new System.Drawing.Point(134, 34);
            this.pbxFoto.Name = "pbxFoto";
            this.pbxFoto.Size = new System.Drawing.Size(145, 145);
            this.pbxFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxFoto.TabIndex = 30;
            this.pbxFoto.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(202, 194);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(46, 19);
            this.lblNome.TabIndex = 26;
            this.lblNome.Text = "Nome";
            this.lblNome.Click += new System.EventHandler(this.lblNome_Click);
            // 
            // lblFunção
            // 
            this.lblFunção.AutoSize = true;
            this.lblFunção.Location = new System.Drawing.Point(114, 213);
            this.lblFunção.Name = "lblFunção";
            this.lblFunção.Size = new System.Drawing.Size(101, 19);
            this.lblFunção.TabIndex = 28;
            this.lblFunção.Text = "Tipo de Acesso:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(51, 308);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(43, 19);
            this.lbl.TabIndex = 27;
            this.lbl.Text = "Data: ";
            // 
            // tbAlterar
            // 
            this.tbAlterar.Controls.Add(this.pbxAltFotoRemover);
            this.tbAlterar.Controls.Add(this.lblTesteID);
            this.tbAlterar.Controls.Add(this.lblTipoAcesso);
            this.tbAlterar.Controls.Add(this.rbtComum);
            this.tbAlterar.Controls.Add(this.rbtAdm);
            this.tbAlterar.Controls.Add(this.metroLabel7);
            this.tbAlterar.Controls.Add(this.bntAlteraUsuario);
            this.tbAlterar.Controls.Add(this.txtAltSenha);
            this.tbAlterar.Controls.Add(this.txtAltSenhaTest);
            this.tbAlterar.Controls.Add(this.txtAltFuncao);
            this.tbAlterar.Controls.Add(this.metroLabel6);
            this.tbAlterar.Controls.Add(this.metroLabel4);
            this.tbAlterar.Controls.Add(this.metroLabel3);
            this.tbAlterar.Controls.Add(this.metroLabel2);
            this.tbAlterar.Controls.Add(this.txtAltUsuario);
            this.tbAlterar.Controls.Add(this.bntAdicionar);
            this.tbAlterar.Controls.Add(this.bntRemoverFoto);
            this.tbAlterar.Controls.Add(this.pbxAltFoto);
            this.tbAlterar.HorizontalScrollbarBarColor = true;
            this.tbAlterar.HorizontalScrollbarHighlightOnWheel = false;
            this.tbAlterar.HorizontalScrollbarSize = 10;
            this.tbAlterar.Location = new System.Drawing.Point(4, 38);
            this.tbAlterar.Name = "tbAlterar";
            this.tbAlterar.Size = new System.Drawing.Size(508, 362);
            this.tbAlterar.Style = MetroFramework.MetroColorStyle.Red;
            this.tbAlterar.TabIndex = 0;
            this.tbAlterar.Text = "Alterar Conta";
            this.tbAlterar.VerticalScrollbarBarColor = true;
            this.tbAlterar.VerticalScrollbarHighlightOnWheel = false;
            this.tbAlterar.VerticalScrollbarSize = 10;
            // 
            // pbxAltFotoRemover
            // 
            this.pbxAltFotoRemover.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAltFotoRemover.Location = new System.Drawing.Point(25, 44);
            this.pbxAltFotoRemover.Name = "pbxAltFotoRemover";
            this.pbxAltFotoRemover.Size = new System.Drawing.Size(218, 114);
            this.pbxAltFotoRemover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAltFotoRemover.TabIndex = 44;
            this.pbxAltFotoRemover.TabStop = false;
            this.pbxAltFotoRemover.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // lblTesteID
            // 
            this.lblTesteID.AutoSize = true;
            this.lblTesteID.Location = new System.Drawing.Point(53, 253);
            this.lblTesteID.Name = "lblTesteID";
            this.lblTesteID.Size = new System.Drawing.Size(13, 13);
            this.lblTesteID.TabIndex = 43;
            this.lblTesteID.Text = "0";
            this.lblTesteID.Visible = false;
            // 
            // lblTipoAcesso
            // 
            this.lblTipoAcesso.AutoSize = true;
            this.lblTipoAcesso.Location = new System.Drawing.Point(345, 230);
            this.lblTipoAcesso.Name = "lblTipoAcesso";
            this.lblTipoAcesso.Size = new System.Drawing.Size(96, 19);
            this.lblTipoAcesso.TabIndex = 42;
            this.lblTipoAcesso.Text = "Tipo de acesso";
            // 
            // rbtComum
            // 
            this.rbtComum.AutoSize = true;
            this.rbtComum.Location = new System.Drawing.Point(420, 252);
            this.rbtComum.Name = "rbtComum";
            this.rbtComum.Size = new System.Drawing.Size(67, 15);
            this.rbtComum.TabIndex = 41;
            this.rbtComum.Text = "Comum";
            this.rbtComum.UseSelectable = true;
            // 
            // rbtAdm
            // 
            this.rbtAdm.AutoSize = true;
            this.rbtAdm.Location = new System.Drawing.Point(278, 252);
            this.rbtAdm.Name = "rbtAdm";
            this.rbtAdm.Size = new System.Drawing.Size(99, 15);
            this.rbtAdm.TabIndex = 40;
            this.rbtAdm.Text = "Administrador";
            this.rbtAdm.UseSelectable = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(67, 22);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(126, 19);
            this.metroLabel7.TabIndex = 39;
            this.metroLabel7.Text = "Selecione a sua foto";
            // 
            // bntAlteraUsuario
            // 
            this.bntAlteraUsuario.ActiveControl = null;
            this.bntAlteraUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAlteraUsuario.Location = new System.Drawing.Point(25, 289);
            this.bntAlteraUsuario.Name = "bntAlteraUsuario";
            this.bntAlteraUsuario.Size = new System.Drawing.Size(462, 55);
            this.bntAlteraUsuario.Style = MetroFramework.MetroColorStyle.Red;
            this.bntAlteraUsuario.TabIndex = 38;
            this.bntAlteraUsuario.Text = "Alterar";
            this.bntAlteraUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntAlteraUsuario.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bntAlteraUsuario.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.bntAlteraUsuario.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular;
            this.bntAlteraUsuario.UseSelectable = true;
            this.bntAlteraUsuario.Click += new System.EventHandler(this.bntAlteraUsuario_Click_1);
            // 
            // txtAltSenha
            // 
            this.txtAltSenha.Lines = new string[0];
            this.txtAltSenha.Location = new System.Drawing.Point(282, 188);
            this.txtAltSenha.MaxLength = 32767;
            this.txtAltSenha.Name = "txtAltSenha";
            this.txtAltSenha.PasswordChar = '*';
            this.txtAltSenha.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAltSenha.SelectedText = "";
            this.txtAltSenha.Size = new System.Drawing.Size(223, 23);
            this.txtAltSenha.TabIndex = 36;
            this.txtAltSenha.UseSelectable = true;
            // 
            // txtAltSenhaTest
            // 
            this.txtAltSenhaTest.Lines = new string[0];
            this.txtAltSenhaTest.Location = new System.Drawing.Point(285, 140);
            this.txtAltSenhaTest.MaxLength = 32767;
            this.txtAltSenhaTest.Name = "txtAltSenhaTest";
            this.txtAltSenhaTest.PasswordChar = '\0';
            this.txtAltSenhaTest.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAltSenhaTest.SelectedText = "";
            this.txtAltSenhaTest.Size = new System.Drawing.Size(220, 23);
            this.txtAltSenhaTest.TabIndex = 35;
            this.txtAltSenhaTest.UseSelectable = true;
            // 
            // txtAltFuncao
            // 
            this.txtAltFuncao.Lines = new string[0];
            this.txtAltFuncao.Location = new System.Drawing.Point(285, 92);
            this.txtAltFuncao.MaxLength = 32767;
            this.txtAltFuncao.Name = "txtAltFuncao";
            this.txtAltFuncao.PasswordChar = '\0';
            this.txtAltFuncao.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAltFuncao.SelectedText = "";
            this.txtAltFuncao.Size = new System.Drawing.Size(220, 23);
            this.txtAltFuncao.TabIndex = 34;
            this.txtAltFuncao.UseSelectable = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(338, 166);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(103, 19);
            this.metroLabel6.TabIndex = 32;
            this.metroLabel6.Text = "Confirma Senha";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(363, 118);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 31;
            this.metroLabel4.Text = "Senha";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(365, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 29;
            this.metroLabel3.Text = "Função";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(363, 22);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(53, 19);
            this.metroLabel2.TabIndex = 28;
            this.metroLabel2.Text = "Usuário";
            // 
            // txtAltUsuario
            // 
            this.txtAltUsuario.Lines = new string[0];
            this.txtAltUsuario.Location = new System.Drawing.Point(285, 44);
            this.txtAltUsuario.MaxLength = 32767;
            this.txtAltUsuario.Name = "txtAltUsuario";
            this.txtAltUsuario.PasswordChar = '\0';
            this.txtAltUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAltUsuario.SelectedText = "";
            this.txtAltUsuario.Size = new System.Drawing.Size(220, 23);
            this.txtAltUsuario.TabIndex = 27;
            this.txtAltUsuario.UseSelectable = true;
            // 
            // bntAdicionar
            // 
            this.bntAdicionar.Location = new System.Drawing.Point(25, 164);
            this.bntAdicionar.Name = "bntAdicionar";
            this.bntAdicionar.Size = new System.Drawing.Size(107, 64);
            this.bntAdicionar.TabIndex = 26;
            this.bntAdicionar.Text = "Adicionar";
            this.bntAdicionar.UseSelectable = true;
            this.bntAdicionar.Click += new System.EventHandler(this.bntAdicionar_Click);
            // 
            // bntRemoverFoto
            // 
            this.bntRemoverFoto.Location = new System.Drawing.Point(138, 164);
            this.bntRemoverFoto.Name = "bntRemoverFoto";
            this.bntRemoverFoto.Size = new System.Drawing.Size(105, 64);
            this.bntRemoverFoto.TabIndex = 25;
            this.bntRemoverFoto.Text = "Remover";
            this.bntRemoverFoto.UseSelectable = true;
            this.bntRemoverFoto.Click += new System.EventHandler(this.bntRemoverFoto_Click);
            // 
            // pbxAltFoto
            // 
            this.pbxAltFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbxAltFoto.Location = new System.Drawing.Point(25, 44);
            this.pbxAltFoto.Name = "pbxAltFoto";
            this.pbxAltFoto.Size = new System.Drawing.Size(218, 114);
            this.pbxAltFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxAltFoto.TabIndex = 24;
            this.pbxAltFoto.TabStop = false;
            // 
            // tbContas
            // 
            this.tbContas.Controls.Add(this.lblAviso);
            this.tbContas.Controls.Add(this.bntAtualizar);
            this.tbContas.Controls.Add(this.bntAlterar1);
            this.tbContas.Controls.Add(this.dgvUsuario);
            this.tbContas.Controls.Add(this.metroLabel1);
            this.tbContas.Controls.Add(this.bntExcluirConta);
            this.tbContas.HorizontalScrollbarBarColor = true;
            this.tbContas.HorizontalScrollbarHighlightOnWheel = false;
            this.tbContas.HorizontalScrollbarSize = 10;
            this.tbContas.Location = new System.Drawing.Point(4, 38);
            this.tbContas.Name = "tbContas";
            this.tbContas.Size = new System.Drawing.Size(508, 362);
            this.tbContas.TabIndex = 1;
            this.tbContas.Text = "Selecionar contas";
            this.tbContas.VerticalScrollbarBarColor = true;
            this.tbContas.VerticalScrollbarHighlightOnWheel = false;
            this.tbContas.VerticalScrollbarSize = 10;
            this.tbContas.Click += new System.EventHandler(this.metroTabPage2_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.AutoSize = true;
            this.lblAviso.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblAviso.Location = new System.Drawing.Point(64, 329);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(367, 19);
            this.lblAviso.TabIndex = 76;
            this.lblAviso.Text = "Você só tem permissão de alterar apenas a sua conta.";
            // 
            // bntAtualizar
            // 
            this.bntAtualizar.ActiveControl = null;
            this.bntAtualizar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntAtualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAtualizar.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.bntAtualizar.Location = new System.Drawing.Point(68, 302);
            this.bntAtualizar.Name = "bntAtualizar";
            this.bntAtualizar.Size = new System.Drawing.Size(363, 24);
            this.bntAtualizar.Style = MetroFramework.MetroColorStyle.Red;
            this.bntAtualizar.TabIndex = 75;
            this.bntAtualizar.Text = "Atualizar";
            this.bntAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntAtualizar.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bntAtualizar.UseSelectable = true;
            this.bntAtualizar.Click += new System.EventHandler(this.bntAtualizar_Click);
            // 
            // bntAlterar1
            // 
            this.bntAlterar1.ActiveControl = null;
            this.bntAlterar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntAlterar1.Location = new System.Drawing.Point(68, 238);
            this.bntAlterar1.Name = "bntAlterar1";
            this.bntAlterar1.Size = new System.Drawing.Size(178, 58);
            this.bntAlterar1.Style = MetroFramework.MetroColorStyle.Silver;
            this.bntAlterar1.TabIndex = 74;
            this.bntAlterar1.Text = "Alterar";
            this.bntAlterar1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntAlterar1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bntAlterar1.UseSelectable = true;
            this.bntAlterar1.Click += new System.EventHandler(this.bntAlterar1_Click);
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToOrderColumns = true;
            this.dgvUsuario.AllowUserToResizeRows = false;
            this.dgvUsuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvUsuario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuario.EnableHeadersVisualStyles = false;
            this.dgvUsuario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvUsuario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvUsuario.Location = new System.Drawing.Point(54, 33);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(17)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(19)))), ((int)(((byte)(73)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvUsuario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuario.Size = new System.Drawing.Size(428, 174);
            this.dgvUsuario.Style = MetroFramework.MetroColorStyle.Red;
            this.dgvUsuario.TabIndex = 73;
            this.dgvUsuario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellClick);
            this.dgvUsuario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellContentClick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(183, 11);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(112, 19);
            this.metroLabel1.TabIndex = 41;
            this.metroLabel1.Text = "Exibição de conta";
            // 
            // bntExcluirConta
            // 
            this.bntExcluirConta.ActiveControl = null;
            this.bntExcluirConta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntExcluirConta.Location = new System.Drawing.Point(252, 238);
            this.bntExcluirConta.Name = "bntExcluirConta";
            this.bntExcluirConta.Size = new System.Drawing.Size(179, 58);
            this.bntExcluirConta.Style = MetroFramework.MetroColorStyle.Red;
            this.bntExcluirConta.TabIndex = 39;
            this.bntExcluirConta.Text = "Excluir";
            this.bntExcluirConta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bntExcluirConta.Theme = MetroFramework.MetroThemeStyle.Light;
            this.bntExcluirConta.UseSelectable = true;
            this.bntExcluirConta.Click += new System.EventHandler(this.bntExcluirConta_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 646);
            this.Controls.Add(this.tcSelecao);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmUsuario";
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "Perfil";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcSelecao.ResumeLayout(false);
            this.tbVisao.ResumeLayout(false);
            this.tbVisao.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxFoto)).EndInit();
            this.tbAlterar.ResumeLayout(false);
            this.tbAlterar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltFotoRemover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxAltFoto)).EndInit();
            this.tbContas.ResumeLayout(false);
            this.tbContas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroTabControl tcSelecao;
        private MetroFramework.Controls.MetroTabPage tbAlterar;
        private MetroFramework.Controls.MetroLabel lblTipoAcesso;
        private MetroFramework.Controls.MetroRadioButton rbtComum;
        private MetroFramework.Controls.MetroRadioButton rbtAdm;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTile bntAlteraUsuario;
        private MetroFramework.Controls.MetroTextBox txtAltSenha;
        private MetroFramework.Controls.MetroTextBox txtAltSenhaTest;
        private MetroFramework.Controls.MetroTextBox txtAltFuncao;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox txtAltUsuario;
        private MetroFramework.Controls.MetroButton bntAdicionar;
        private MetroFramework.Controls.MetroButton bntRemoverFoto;
        private System.Windows.Forms.PictureBox pbxAltFoto;
        private MetroFramework.Controls.MetroTabPage tbContas;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTile bntExcluirConta;
        private MetroFramework.Controls.MetroTabPage tbVisao;
        private MetroFramework.Controls.MetroGrid dgvUsuario;
        private System.Windows.Forms.Label lblTesteID;
        private MetroFramework.Controls.MetroLabel lblFunção;
        private MetroFramework.Controls.MetroLabel lbl;
        private MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pbxFoto;
        private System.Windows.Forms.OpenFileDialog ofd;
        private MetroFramework.Controls.MetroTile bntAlterar1;
        private System.Windows.Forms.Timer timer1;
        private MetroFramework.Controls.MetroLabel lblData;
        private MetroFramework.Controls.MetroLabel lblEquipamento;
        private MetroFramework.Controls.MetroLabel metroLabel12;
        private MetroFramework.Controls.MetroLabel lblHora;
        private MetroFramework.Controls.MetroLabel metroLabel10;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel lblVerificar;
        private MetroFramework.Controls.MetroTile bntAtualizar;
        private System.Windows.Forms.PictureBox pbxAltFotoRemover;
        private MetroFramework.Controls.MetroLabel lblAviso;
    }
}