namespace Venda
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
            this.cbbProduto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbVista = new System.Windows.Forms.RadioButton();
            this.rbtPrazo = new System.Windows.Forms.RadioButton();
            this.lblFinal = new System.Windows.Forms.Label();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.nudParcelas = new System.Windows.Forms.NumericUpDown();
            this.txtTaxa = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorParcela = new System.Windows.Forms.TextBox();
            this.txtJuros = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.bntCalVista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbbProduto
            // 
            this.cbbProduto.FormattingEnabled = true;
            this.cbbProduto.Location = new System.Drawing.Point(134, 25);
            this.cbbProduto.Name = "cbbProduto";
            this.cbbProduto.Size = new System.Drawing.Size(95, 21);
            this.cbbProduto.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Quantidade";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Location = new System.Drawing.Point(91, 75);
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(78, 20);
            this.nudQuantidade.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione o produto";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(91, 120);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(78, 20);
            this.txtPreco.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Preço";
            // 
            // rdbVista
            // 
            this.rdbVista.AutoSize = true;
            this.rdbVista.Location = new System.Drawing.Point(7, 13);
            this.rdbVista.Name = "rdbVista";
            this.rdbVista.Size = new System.Drawing.Size(58, 17);
            this.rdbVista.TabIndex = 6;
            this.rdbVista.TabStop = true;
            this.rdbVista.Text = "A Vista";
            this.rdbVista.UseVisualStyleBackColor = true;
            this.rdbVista.CheckedChanged += new System.EventHandler(this.rdbVista_CheckedChanged);
            // 
            // rbtPrazo
            // 
            this.rbtPrazo.AutoSize = true;
            this.rbtPrazo.Location = new System.Drawing.Point(109, 13);
            this.rbtPrazo.Name = "rbtPrazo";
            this.rbtPrazo.Size = new System.Drawing.Size(62, 17);
            this.rbtPrazo.TabIndex = 7;
            this.rbtPrazo.TabStop = true;
            this.rbtPrazo.Text = "A Prazo";
            this.rbtPrazo.UseVisualStyleBackColor = true;
            this.rbtPrazo.CheckedChanged += new System.EventHandler(this.rbtPrazo_CheckedChanged);
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Location = new System.Drawing.Point(26, 225);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(56, 13);
            this.lblFinal.TabIndex = 8;
            this.lblFinal.Text = "Valor Final";
            // 
            // txtFinal
            // 
            this.txtFinal.Enabled = false;
            this.txtFinal.Location = new System.Drawing.Point(91, 225);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.ReadOnly = true;
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 9;
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(340, 28);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 10;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(340, 67);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 11;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // nudParcelas
            // 
            this.nudParcelas.Location = new System.Drawing.Point(8, 13);
            this.nudParcelas.Name = "nudParcelas";
            this.nudParcelas.Size = new System.Drawing.Size(43, 20);
            this.nudParcelas.TabIndex = 12;
            // 
            // txtTaxa
            // 
            this.txtTaxa.Location = new System.Drawing.Point(119, 12);
            this.txtTaxa.Name = "txtTaxa";
            this.txtTaxa.Size = new System.Drawing.Size(44, 20);
            this.txtTaxa.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(71, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Taxa(%)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Valor Parcela";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Juros";
            // 
            // txtValorParcela
            // 
            this.txtValorParcela.Enabled = false;
            this.txtValorParcela.Location = new System.Drawing.Point(81, 47);
            this.txtValorParcela.Name = "txtValorParcela";
            this.txtValorParcela.ReadOnly = true;
            this.txtValorParcela.Size = new System.Drawing.Size(78, 20);
            this.txtValorParcela.TabIndex = 17;
            // 
            // txtJuros
            // 
            this.txtJuros.Enabled = false;
            this.txtJuros.Location = new System.Drawing.Point(81, 75);
            this.txtJuros.Name = "txtJuros";
            this.txtJuros.ReadOnly = true;
            this.txtJuros.Size = new System.Drawing.Size(78, 20);
            this.txtJuros.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtPrazo);
            this.groupBox1.Controls.Add(this.rdbVista);
            this.groupBox1.Location = new System.Drawing.Point(22, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 43);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Venda";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bntCalcular);
            this.groupBox2.Controls.Add(this.txtJuros);
            this.groupBox2.Controls.Add(this.txtValorParcela);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtTaxa);
            this.groupBox2.Controls.Add(this.nudParcelas);
            this.groupBox2.Location = new System.Drawing.Point(340, 137);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(245, 108);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quantidade de Parcelas";
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(169, 32);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(57, 54);
            this.bntCalcular.TabIndex = 21;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // bntCalVista
            // 
            this.bntCalVista.Location = new System.Drawing.Point(213, 220);
            this.bntCalVista.Name = "bntCalVista";
            this.bntCalVista.Size = new System.Drawing.Size(72, 23);
            this.bntCalVista.TabIndex = 21;
            this.bntCalVista.Text = "Calcular";
            this.bntCalVista.UseVisualStyleBackColor = true;
            this.bntCalVista.Click += new System.EventHandler(this.bntCalVista_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 283);
            this.Controls.Add(this.bntCalVista);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbProduto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudParcelas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbVista;
        private System.Windows.Forms.RadioButton rbtPrazo;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.NumericUpDown nudParcelas;
        private System.Windows.Forms.TextBox txtTaxa;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorParcela;
        private System.Windows.Forms.TextBox txtJuros;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Button bntCalVista;
    }
}

