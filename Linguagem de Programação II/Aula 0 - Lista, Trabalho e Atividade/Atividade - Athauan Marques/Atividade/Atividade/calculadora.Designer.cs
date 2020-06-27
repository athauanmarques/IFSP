namespace Atividade
{
    partial class calculadora
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtSoma = new System.Windows.Forms.RadioButton();
            this.rbtSubtracao = new System.Windows.Forms.RadioButton();
            this.rbtMult = new System.Windows.Forms.RadioButton();
            this.rbtDivisao = new System.Windows.Forms.RadioButton();
            this.rbtResto = new System.Windows.Forms.RadioButton();
            this.rbtPonten = new System.Windows.Forms.RadioButton();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.bntSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(46, 64);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(65, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(157, 64);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(65, 20);
            this.txtNumero2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(43, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(154, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero 2:";
            // 
            // rbtSoma
            // 
            this.rbtSoma.AutoSize = true;
            this.rbtSoma.Location = new System.Drawing.Point(17, 9);
            this.rbtSoma.Name = "rbtSoma";
            this.rbtSoma.Size = new System.Drawing.Size(67, 17);
            this.rbtSoma.TabIndex = 4;
            this.rbtSoma.TabStop = true;
            this.rbtSoma.Text = "Soma (+)";
            this.rbtSoma.UseVisualStyleBackColor = true;
            // 
            // rbtSubtracao
            // 
            this.rbtSubtracao.AutoSize = true;
            this.rbtSubtracao.Location = new System.Drawing.Point(17, 32);
            this.rbtSubtracao.Name = "rbtSubtracao";
            this.rbtSubtracao.Size = new System.Drawing.Size(83, 17);
            this.rbtSubtracao.TabIndex = 5;
            this.rbtSubtracao.TabStop = true;
            this.rbtSubtracao.Text = "Subtração(-)";
            this.rbtSubtracao.UseVisualStyleBackColor = true;
            // 
            // rbtMult
            // 
            this.rbtMult.AutoSize = true;
            this.rbtMult.Location = new System.Drawing.Point(17, 55);
            this.rbtMult.Name = "rbtMult";
            this.rbtMult.Size = new System.Drawing.Size(100, 17);
            this.rbtMult.TabIndex = 7;
            this.rbtMult.TabStop = true;
            this.rbtMult.Text = "Multiplicação (*)";
            this.rbtMult.UseVisualStyleBackColor = true;
            // 
            // rbtDivisao
            // 
            this.rbtDivisao.AutoSize = true;
            this.rbtDivisao.Location = new System.Drawing.Point(17, 78);
            this.rbtDivisao.Name = "rbtDivisao";
            this.rbtDivisao.Size = new System.Drawing.Size(74, 17);
            this.rbtDivisao.TabIndex = 6;
            this.rbtDivisao.TabStop = true;
            this.rbtDivisao.Text = "Divisão (/)";
            this.rbtDivisao.UseVisualStyleBackColor = true;
            // 
            // rbtResto
            // 
            this.rbtResto.AutoSize = true;
            this.rbtResto.Location = new System.Drawing.Point(17, 101);
            this.rbtResto.Name = "rbtResto";
            this.rbtResto.Size = new System.Drawing.Size(70, 17);
            this.rbtResto.TabIndex = 9;
            this.rbtResto.TabStop = true;
            this.rbtResto.Text = "Resto (%)";
            this.rbtResto.UseVisualStyleBackColor = true;
            // 
            // rbtPonten
            // 
            this.rbtPonten.AutoSize = true;
            this.rbtPonten.Location = new System.Drawing.Point(17, 124);
            this.rbtPonten.Name = "rbtPonten";
            this.rbtPonten.Size = new System.Drawing.Size(85, 17);
            this.rbtPonten.TabIndex = 8;
            this.rbtPonten.TabStop = true;
            this.rbtPonten.Text = "Potenciação";
            this.rbtPonten.UseVisualStyleBackColor = true;
            // 
            // bntCalcular
            // 
            this.bntCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCalcular.Location = new System.Drawing.Point(185, 116);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(63, 40);
            this.bntCalcular.TabIndex = 10;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLimpar.Location = new System.Drawing.Point(185, 173);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(63, 40);
            this.bntLimpar.TabIndex = 11;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(37, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Cursor = System.Windows.Forms.Cursors.No;
            this.txtResultado.Location = new System.Drawing.Point(110, 266);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(86, 20);
            this.txtResultado.TabIndex = 13;
            // 
            // bntSair
            // 
            this.bntSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSair.Location = new System.Drawing.Point(233, 269);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(63, 40);
            this.bntSair.TabIndex = 14;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtResto);
            this.groupBox1.Controls.Add(this.rbtPonten);
            this.groupBox1.Controls.Add(this.rbtMult);
            this.groupBox1.Controls.Add(this.rbtDivisao);
            this.groupBox1.Controls.Add(this.rbtSubtracao);
            this.groupBox1.Controls.Add(this.rbtSoma);
            this.groupBox1.Location = new System.Drawing.Point(29, 95);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(128, 156);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atividade.Properties.Resources._4;
            this.ClientSize = new System.Drawing.Size(308, 321);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "calculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "calculadora";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtSoma;
        private System.Windows.Forms.RadioButton rbtSubtracao;
        private System.Windows.Forms.RadioButton rbtMult;
        private System.Windows.Forms.RadioButton rbtDivisao;
        private System.Windows.Forms.RadioButton rbtResto;
        private System.Windows.Forms.RadioButton rbtPonten;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}