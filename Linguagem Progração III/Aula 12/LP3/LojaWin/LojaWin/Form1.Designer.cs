namespace LojaWin
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.opcSair = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuCadastros = new System.Windows.Forms.ToolStripMenuItem();
            this.opcClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.opcProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.opcVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.opcItens = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.opcUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRelatorios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuFerramentas = new System.Windows.Forms.ToolStripMenuItem();
            this.opcCalculadora = new System.Windows.Forms.ToolStripMenuItem();
            this.opcCalendario = new System.Windows.Forms.ToolStripMenuItem();
            this.opcBloco = new System.Windows.Forms.ToolStripMenuItem();
            this.opcInternet = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnClientes = new System.Windows.Forms.ToolStripButton();
            this.btnProdutos = new System.Windows.Forms.ToolStripButton();
            this.btnVendas = new System.Windows.Forms.ToolStripButton();
            this.btnItens = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUsuarios = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCalculadora = new System.Windows.Forms.ToolStripButton();
            this.btnCalendario = new System.Windows.Forms.ToolStripButton();
            this.btnBloco = new System.Windows.Forms.ToolStripButton();
            this.btnInternet = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEquipamento = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.opcFichaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuArquivo,
            this.mnuCadastros,
            this.mnuRelatorios,
            this.mnuFerramentas,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(944, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuArquivo
            // 
            this.mnuArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcSair});
            this.mnuArquivo.Name = "mnuArquivo";
            this.mnuArquivo.Size = new System.Drawing.Size(61, 20);
            this.mnuArquivo.Text = "&Arquivo";
            // 
            // opcSair
            // 
            this.opcSair.Image = ((System.Drawing.Image)(resources.GetObject("opcSair.Image")));
            this.opcSair.ImageTransparentColor = System.Drawing.Color.Fuchsia;
            this.opcSair.Name = "opcSair";
            this.opcSair.Size = new System.Drawing.Size(93, 22);
            this.opcSair.Text = "Sair";
            this.opcSair.Click += new System.EventHandler(this.opcSair_Click);
            // 
            // mnuCadastros
            // 
            this.mnuCadastros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcClientes,
            this.opcProdutos,
            this.opcVendas,
            this.opcItens,
            this.toolStripMenuItem1,
            this.opcUsuarios});
            this.mnuCadastros.Name = "mnuCadastros";
            this.mnuCadastros.Size = new System.Drawing.Size(71, 20);
            this.mnuCadastros.Text = "&Cadastros";
            // 
            // opcClientes
            // 
            this.opcClientes.Image = ((System.Drawing.Image)(resources.GetObject("opcClientes.Image")));
            this.opcClientes.ImageTransparentColor = System.Drawing.Color.Red;
            this.opcClientes.Name = "opcClientes";
            this.opcClientes.Size = new System.Drawing.Size(156, 22);
            this.opcClientes.Text = "Clientes";
            this.opcClientes.Click += new System.EventHandler(this.opcClientes_Click);
            // 
            // opcProdutos
            // 
            this.opcProdutos.Image = ((System.Drawing.Image)(resources.GetObject("opcProdutos.Image")));
            this.opcProdutos.Name = "opcProdutos";
            this.opcProdutos.Size = new System.Drawing.Size(156, 22);
            this.opcProdutos.Text = "Produtos";
            this.opcProdutos.Click += new System.EventHandler(this.opcProdutos_Click);
            // 
            // opcVendas
            // 
            this.opcVendas.Image = ((System.Drawing.Image)(resources.GetObject("opcVendas.Image")));
            this.opcVendas.Name = "opcVendas";
            this.opcVendas.Size = new System.Drawing.Size(156, 22);
            this.opcVendas.Text = "Vendas";
            this.opcVendas.Click += new System.EventHandler(this.opcVendas_Click);
            // 
            // opcItens
            // 
            this.opcItens.Image = ((System.Drawing.Image)(resources.GetObject("opcItens.Image")));
            this.opcItens.ImageTransparentColor = System.Drawing.Color.Yellow;
            this.opcItens.Name = "opcItens";
            this.opcItens.Size = new System.Drawing.Size(156, 22);
            this.opcItens.Text = "Itens de Vendas";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // opcUsuarios
            // 
            this.opcUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("opcUsuarios.Image")));
            this.opcUsuarios.Name = "opcUsuarios";
            this.opcUsuarios.Size = new System.Drawing.Size(156, 22);
            this.opcUsuarios.Text = "Usuários";
            this.opcUsuarios.Click += new System.EventHandler(this.opcUsuarios_Click);
            // 
            // mnuRelatorios
            // 
            this.mnuRelatorios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcFichaCliente});
            this.mnuRelatorios.Name = "mnuRelatorios";
            this.mnuRelatorios.Size = new System.Drawing.Size(71, 20);
            this.mnuRelatorios.Text = "&Relatórios";
            // 
            // mnuFerramentas
            // 
            this.mnuFerramentas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opcCalculadora,
            this.opcCalendario,
            this.opcBloco,
            this.opcInternet});
            this.mnuFerramentas.Name = "mnuFerramentas";
            this.mnuFerramentas.Size = new System.Drawing.Size(84, 20);
            this.mnuFerramentas.Text = "&Ferramentas";
            // 
            // opcCalculadora
            // 
            this.opcCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("opcCalculadora.Image")));
            this.opcCalculadora.ImageTransparentColor = System.Drawing.Color.Red;
            this.opcCalculadora.Name = "opcCalculadora";
            this.opcCalculadora.Size = new System.Drawing.Size(154, 22);
            this.opcCalculadora.Text = "Calculadora";
            this.opcCalculadora.Click += new System.EventHandler(this.opcCalculadora_Click);
            // 
            // opcCalendario
            // 
            this.opcCalendario.Image = ((System.Drawing.Image)(resources.GetObject("opcCalendario.Image")));
            this.opcCalendario.ImageTransparentColor = System.Drawing.Color.Red;
            this.opcCalendario.Name = "opcCalendario";
            this.opcCalendario.Size = new System.Drawing.Size(154, 22);
            this.opcCalendario.Text = "Calendário";
            this.opcCalendario.Click += new System.EventHandler(this.opcCalendario_Click);
            // 
            // opcBloco
            // 
            this.opcBloco.Image = ((System.Drawing.Image)(resources.GetObject("opcBloco.Image")));
            this.opcBloco.ImageTransparentColor = System.Drawing.Color.Red;
            this.opcBloco.Name = "opcBloco";
            this.opcBloco.Size = new System.Drawing.Size(154, 22);
            this.opcBloco.Text = "Bloco de Notas";
            this.opcBloco.Click += new System.EventHandler(this.opcBloco_Click);
            // 
            // opcInternet
            // 
            this.opcInternet.Image = ((System.Drawing.Image)(resources.GetObject("opcInternet.Image")));
            this.opcInternet.Name = "opcInternet";
            this.opcInternet.Size = new System.Drawing.Size(154, 22);
            this.opcInternet.Text = "Internet";
            this.opcInternet.Click += new System.EventHandler(this.opcInternet_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sobreToolStripMenuItem});
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "A&juda";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sobreToolStripMenuItem.Image")));
            this.sobreToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Red;
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(104, 22);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnClientes,
            this.btnProdutos,
            this.btnVendas,
            this.btnItens,
            this.toolStripSeparator1,
            this.btnUsuarios,
            this.toolStripSeparator2,
            this.btnCalculadora,
            this.btnCalendario,
            this.btnBloco,
            this.btnInternet,
            this.toolStripSeparator3,
            this.btnSair});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(944, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnClientes
            // 
            this.btnClientes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnClientes.Image = ((System.Drawing.Image)(resources.GetObject("btnClientes.Image")));
            this.btnClientes.ImageTransparentColor = System.Drawing.Color.Red;
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(23, 22);
            this.btnClientes.Text = "Clientes";
            this.btnClientes.Click += new System.EventHandler(this.opcClientes_Click);
            // 
            // btnProdutos
            // 
            this.btnProdutos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnProdutos.Image = ((System.Drawing.Image)(resources.GetObject("btnProdutos.Image")));
            this.btnProdutos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProdutos.Name = "btnProdutos";
            this.btnProdutos.Size = new System.Drawing.Size(23, 22);
            this.btnProdutos.Text = "Produtos";
            this.btnProdutos.Click += new System.EventHandler(this.opcProdutos_Click);
            // 
            // btnVendas
            // 
            this.btnVendas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnVendas.Image = ((System.Drawing.Image)(resources.GetObject("btnVendas.Image")));
            this.btnVendas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnVendas.Name = "btnVendas";
            this.btnVendas.Size = new System.Drawing.Size(23, 22);
            this.btnVendas.Text = "Vendas";
            this.btnVendas.Click += new System.EventHandler(this.opcVendas_Click);
            // 
            // btnItens
            // 
            this.btnItens.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnItens.Image = ((System.Drawing.Image)(resources.GetObject("btnItens.Image")));
            this.btnItens.ImageTransparentColor = System.Drawing.Color.Yellow;
            this.btnItens.Name = "btnItens";
            this.btnItens.Size = new System.Drawing.Size(23, 22);
            this.btnItens.Text = "Itens de Vendas";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageTransparentColor = System.Drawing.Color.White;
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(23, 22);
            this.btnUsuarios.Text = "Usuários";
            this.btnUsuarios.Click += new System.EventHandler(this.opcUsuarios_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCalculadora
            // 
            this.btnCalculadora.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCalculadora.Image = ((System.Drawing.Image)(resources.GetObject("btnCalculadora.Image")));
            this.btnCalculadora.ImageTransparentColor = System.Drawing.Color.Red;
            this.btnCalculadora.Name = "btnCalculadora";
            this.btnCalculadora.Size = new System.Drawing.Size(23, 22);
            this.btnCalculadora.Text = "Calculadora";
            this.btnCalculadora.Click += new System.EventHandler(this.opcCalculadora_Click);
            // 
            // btnCalendario
            // 
            this.btnCalendario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCalendario.Image = ((System.Drawing.Image)(resources.GetObject("btnCalendario.Image")));
            this.btnCalendario.ImageTransparentColor = System.Drawing.Color.Red;
            this.btnCalendario.Name = "btnCalendario";
            this.btnCalendario.Size = new System.Drawing.Size(23, 22);
            this.btnCalendario.Text = "Calendário";
            this.btnCalendario.Click += new System.EventHandler(this.opcCalendario_Click);
            // 
            // btnBloco
            // 
            this.btnBloco.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBloco.Image = ((System.Drawing.Image)(resources.GetObject("btnBloco.Image")));
            this.btnBloco.ImageTransparentColor = System.Drawing.Color.Red;
            this.btnBloco.Name = "btnBloco";
            this.btnBloco.Size = new System.Drawing.Size(23, 22);
            this.btnBloco.Text = "Bloco de Notas";
            this.btnBloco.Click += new System.EventHandler(this.opcBloco_Click);
            // 
            // btnInternet
            // 
            this.btnInternet.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnInternet.Image = ((System.Drawing.Image)(resources.GetObject("btnInternet.Image")));
            this.btnInternet.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInternet.Name = "btnInternet";
            this.btnInternet.Size = new System.Drawing.Size(23, 22);
            this.btnInternet.Text = "Internet";
            this.btnInternet.Click += new System.EventHandler(this.opcInternet_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // btnSair
            // 
            this.btnSair.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(23, 22);
            this.btnSair.Text = "Sair";
            this.btnSair.Click += new System.EventHandler(this.opcSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblData,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.lblHora,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.lblEquipamento,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 470);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(944, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(34, 17);
            this.toolStripStatusLabel1.Text = "Data:";
            // 
            // lblData
            // 
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(77, 17);
            this.lblData.Text = "dd/mm/aaaa";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel2.Text = " | ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(36, 17);
            this.toolStripStatusLabel3.Text = "Hora:";
            // 
            // lblHora
            // 
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(59, 17);
            this.lblHora.Text = "hh:mm:ss";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel4.Text = " | ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(81, 17);
            this.toolStripStatusLabel5.Text = "Equipamento:";
            // 
            // lblEquipamento
            // 
            this.lblEquipamento.Name = "lblEquipamento";
            this.lblEquipamento.Size = new System.Drawing.Size(20, 17);
            this.lblEquipamento.Text = "pc";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel6.Text = " | ";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel7.Text = "Usuário:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(38, 17);
            this.lblUsuario.Text = "nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(245, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sistema de Controle de Vendas";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(355, 187);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(252, 187);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // opcFichaCliente
            // 
            this.opcFichaCliente.Image = ((System.Drawing.Image)(resources.GetObject("opcFichaCliente.Image")));
            this.opcFichaCliente.Name = "opcFichaCliente";
            this.opcFichaCliente.Size = new System.Drawing.Size(159, 22);
            this.opcFichaCliente.Text = "Ficha do Cliente";
            this.opcFichaCliente.Click += new System.EventHandler(this.opcFichaCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 492);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Vendas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuArquivo;
        private System.Windows.Forms.ToolStripMenuItem opcSair;
        private System.Windows.Forms.ToolStripMenuItem mnuCadastros;
        private System.Windows.Forms.ToolStripMenuItem opcClientes;
        private System.Windows.Forms.ToolStripMenuItem opcProdutos;
        private System.Windows.Forms.ToolStripMenuItem opcVendas;
        private System.Windows.Forms.ToolStripMenuItem opcItens;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem opcUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuRelatorios;
        private System.Windows.Forms.ToolStripMenuItem mnuFerramentas;
        private System.Windows.Forms.ToolStripMenuItem opcCalculadora;
        private System.Windows.Forms.ToolStripMenuItem opcCalendario;
        private System.Windows.Forms.ToolStripMenuItem opcBloco;
        private System.Windows.Forms.ToolStripMenuItem opcInternet;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnClientes;
        private System.Windows.Forms.ToolStripButton btnProdutos;
        private System.Windows.Forms.ToolStripButton btnVendas;
        private System.Windows.Forms.ToolStripButton btnItens;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnUsuarios;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnCalculadora;
        private System.Windows.Forms.ToolStripButton btnCalendario;
        private System.Windows.Forms.ToolStripButton btnBloco;
        private System.Windows.Forms.ToolStripButton btnInternet;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel lblHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel lblEquipamento;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem opcFichaCliente;
    }
}

