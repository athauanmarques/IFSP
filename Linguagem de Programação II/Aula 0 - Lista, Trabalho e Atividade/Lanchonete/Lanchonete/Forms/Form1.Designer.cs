namespace Lanchonete
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtTotalDoPedido = new System.Windows.Forms.TextBox();
            this.txtCaixa = new System.Windows.Forms.TextBox();
            this.grpCardapio = new System.Windows.Forms.GroupBox();
            this.txtValorItem = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtQtdDoItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCardapio = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpPedido = new System.Windows.Forms.GroupBox();
            this.pnlFecharPedido = new System.Windows.Forms.Panel();
            this.btnConcluirPedido = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTroco = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.rdbFecharPedido = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lstPedido = new System.Windows.Forms.ListBox();
            this.btnAdicionarProduto = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMsg = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.grpCardapio.SuspendLayout();
            this.grpPedido.SuspendLayout();
            this.pnlFecharPedido.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Total do pedido:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(320, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Caixa";
            // 
            // txtTotalDoPedido
            // 
            this.txtTotalDoPedido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTotalDoPedido.Enabled = false;
            this.txtTotalDoPedido.Location = new System.Drawing.Point(23, 288);
            this.txtTotalDoPedido.Name = "txtTotalDoPedido";
            this.txtTotalDoPedido.Size = new System.Drawing.Size(157, 20);
            this.txtTotalDoPedido.TabIndex = 0;
            // 
            // txtCaixa
            // 
            this.txtCaixa.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCaixa.Enabled = false;
            this.txtCaixa.Location = new System.Drawing.Point(313, 28);
            this.txtCaixa.Name = "txtCaixa";
            this.txtCaixa.Size = new System.Drawing.Size(100, 20);
            this.txtCaixa.TabIndex = 0;
            // 
            // grpCardapio
            // 
            this.grpCardapio.Controls.Add(this.txtValorItem);
            this.grpCardapio.Controls.Add(this.label6);
            this.grpCardapio.Controls.Add(this.txtQtdDoItem);
            this.grpCardapio.Controls.Add(this.label1);
            this.grpCardapio.Controls.Add(this.lstCardapio);
            this.grpCardapio.Controls.Add(this.label5);
            this.grpCardapio.Controls.Add(this.label11);
            this.grpCardapio.Controls.Add(this.label3);
            this.grpCardapio.Controls.Add(this.label2);
            this.grpCardapio.Location = new System.Drawing.Point(16, 12);
            this.grpCardapio.Name = "grpCardapio";
            this.grpCardapio.Size = new System.Drawing.Size(290, 326);
            this.grpCardapio.TabIndex = 0;
            this.grpCardapio.TabStop = false;
            this.grpCardapio.Text = "Cardápio";
            // 
            // txtValorItem
            // 
            this.txtValorItem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtValorItem.Enabled = false;
            this.txtValorItem.Location = new System.Drawing.Point(178, 295);
            this.txtValorItem.Name = "txtValorItem";
            this.txtValorItem.Size = new System.Drawing.Size(100, 20);
            this.txtValorItem.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor do Item:";
            // 
            // txtQtdDoItem
            // 
            this.txtQtdDoItem.Location = new System.Drawing.Point(178, 269);
            this.txtQtdDoItem.Name = "txtQtdDoItem";
            this.txtQtdDoItem.Size = new System.Drawing.Size(100, 20);
            this.txtQtdDoItem.TabIndex = 2;
            this.txtQtdDoItem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdDoItem_KeyPress);
            this.txtQtdDoItem.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQtdDoItem_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Entre com a quantidade do item:";
            // 
            // lstCardapio
            // 
            this.lstCardapio.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstCardapio.FormattingEnabled = true;
            this.lstCardapio.ItemHeight = 14;
            this.lstCardapio.Location = new System.Drawing.Point(15, 60);
            this.lstCardapio.Name = "lstCardapio";
            this.lstCardapio.Size = new System.Drawing.Size(263, 186);
            this.lstCardapio.TabIndex = 1;
            this.lstCardapio.SelectedIndexChanged += new System.EventHandler(this.lstCardapio_SelectedIndexChanged);
            this.lstCardapio.DoubleClick += new System.EventHandler(this.lstCardapio_DoubleClick);
            this.lstCardapio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lstCardapio_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(198, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Preço";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(73, 43);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Descrição";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione o item para entrar com o pedido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(320, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Adicionar produto";
            // 
            // grpPedido
            // 
            this.grpPedido.Controls.Add(this.pnlFecharPedido);
            this.grpPedido.Controls.Add(this.rdbFecharPedido);
            this.grpPedido.Controls.Add(this.label9);
            this.grpPedido.Controls.Add(this.label10);
            this.grpPedido.Controls.Add(this.lstPedido);
            this.grpPedido.Controls.Add(this.label7);
            this.grpPedido.Controls.Add(this.txtTotalDoPedido);
            this.grpPedido.Location = new System.Drawing.Point(428, 12);
            this.grpPedido.Name = "grpPedido";
            this.grpPedido.Size = new System.Drawing.Size(330, 388);
            this.grpPedido.TabIndex = 4;
            this.grpPedido.TabStop = false;
            this.grpPedido.Text = "Pedido";
            // 
            // pnlFecharPedido
            // 
            this.pnlFecharPedido.Controls.Add(this.btnConcluirPedido);
            this.pnlFecharPedido.Controls.Add(this.label13);
            this.pnlFecharPedido.Controls.Add(this.txtTroco);
            this.pnlFecharPedido.Controls.Add(this.label12);
            this.pnlFecharPedido.Controls.Add(this.txtPagamento);
            this.pnlFecharPedido.Location = new System.Drawing.Point(6, 315);
            this.pnlFecharPedido.Name = "pnlFecharPedido";
            this.pnlFecharPedido.Size = new System.Drawing.Size(318, 64);
            this.pnlFecharPedido.TabIndex = 0;
            this.pnlFecharPedido.Visible = false;
            // 
            // btnConcluirPedido
            // 
            this.btnConcluirPedido.Location = new System.Drawing.Point(191, 17);
            this.btnConcluirPedido.Name = "btnConcluirPedido";
            this.btnConcluirPedido.Size = new System.Drawing.Size(109, 32);
            this.btnConcluirPedido.TabIndex = 6;
            this.btnConcluirPedido.Text = "Concluir Pedido";
            this.btnConcluirPedido.UseVisualStyleBackColor = true;
            this.btnConcluirPedido.Click += new System.EventHandler(this.btnConcluirPedido_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 18;
            this.label13.Text = "Troco:";
            // 
            // txtTroco
            // 
            this.txtTroco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTroco.Enabled = false;
            this.txtTroco.Location = new System.Drawing.Point(84, 40);
            this.txtTroco.Name = "txtTroco";
            this.txtTroco.Size = new System.Drawing.Size(90, 20);
            this.txtTroco.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 16;
            this.label12.Text = "Pagamento:";
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(84, 14);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(90, 20);
            this.txtPagamento.TabIndex = 5;
            this.txtPagamento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.aceitarApenasValoresReais);
            this.txtPagamento.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPagamento_KeyUp);
            // 
            // rdbFecharPedido
            // 
            this.rdbFecharPedido.AutoSize = true;
            this.rdbFecharPedido.Location = new System.Drawing.Point(213, 288);
            this.rdbFecharPedido.Name = "rdbFecharPedido";
            this.rdbFecharPedido.Size = new System.Drawing.Size(93, 17);
            this.rdbFecharPedido.TabIndex = 4;
            this.rdbFecharPedido.TabStop = true;
            this.rdbFecharPedido.Text = "Fechar pedido";
            this.rdbFecharPedido.UseVisualStyleBackColor = true;
            this.rdbFecharPedido.CheckedChanged += new System.EventHandler(this.rdbFecharPedido_CheckedChanged);
            this.rdbFecharPedido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.rdbFecharPedido_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(183, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Quantidade";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(20, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 9;
            this.label10.Text = "Descrição";
            // 
            // lstPedido
            // 
            this.lstPedido.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPedido.FormattingEnabled = true;
            this.lstPedido.ItemHeight = 14;
            this.lstPedido.Location = new System.Drawing.Point(23, 43);
            this.lstPedido.Name = "lstPedido";
            this.lstPedido.Size = new System.Drawing.Size(283, 214);
            this.lstPedido.TabIndex = 0;
            this.lstPedido.TabStop = false;
            // 
            // btnAdicionarProduto
            // 
            this.btnAdicionarProduto.Location = new System.Drawing.Point(320, 125);
            this.btnAdicionarProduto.Name = "btnAdicionarProduto";
            this.btnAdicionarProduto.Size = new System.Drawing.Size(90, 30);
            this.btnAdicionarProduto.TabIndex = 3;
            this.btnAdicionarProduto.Text = ">>";
            this.btnAdicionarProduto.UseVisualStyleBackColor = true;
            this.btnAdicionarProduto.Click += new System.EventHandler(this.btnAdicionarProduto_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(320, 306);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(90, 32);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMsg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(770, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMsg
            // 
            this.lblMsg.ForeColor = System.Drawing.Color.Red;
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 17);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(320, 268);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(90, 32);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Lanchonete.Properties.Resources.Sem_título1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(770, 435);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.grpPedido);
            this.Controls.Add(this.grpCardapio);
            this.Controls.Add(this.txtCaixa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAdicionarProduto);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lanchonete";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpCardapio.ResumeLayout(false);
            this.grpCardapio.PerformLayout();
            this.grpPedido.ResumeLayout(false);
            this.grpPedido.PerformLayout();
            this.pnlFecharPedido.ResumeLayout(false);
            this.pnlFecharPedido.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtTotalDoPedido;
        private System.Windows.Forms.TextBox txtCaixa;
        private System.Windows.Forms.GroupBox grpCardapio;
        private System.Windows.Forms.TextBox txtQtdDoItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstCardapio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpPedido;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtValorItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdicionarProduto;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMsg;
        private System.Windows.Forms.RadioButton rdbFecharPedido;
        private System.Windows.Forms.Panel pnlFecharPedido;
        private System.Windows.Forms.Button btnConcluirPedido;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTroco;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.Button btnLimpar;

    }
}

