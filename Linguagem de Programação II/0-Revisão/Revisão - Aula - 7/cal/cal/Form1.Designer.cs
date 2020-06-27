namespace cal
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
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.txtNumero2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntSoma = new System.Windows.Forms.Button();
            this.bntSubtracao = new System.Windows.Forms.Button();
            this.bntDivisao = new System.Windows.Forms.Button();
            this.bntMultiplicacao = new System.Windows.Forms.Button();
            this.bntPotenciacao = new System.Windows.Forms.Button();
            this.bntResto = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(124, 32);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(153, 20);
            this.txtNumero1.TabIndex = 0;
            // 
            // txtNumero2
            // 
            this.txtNumero2.Location = new System.Drawing.Point(124, 58);
            this.txtNumero2.Name = "txtNumero2";
            this.txtNumero2.Size = new System.Drawing.Size(153, 20);
            this.txtNumero2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Numero1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Numero2:";
            // 
            // bntSoma
            // 
            this.bntSoma.Location = new System.Drawing.Point(49, 104);
            this.bntSoma.Name = "bntSoma";
            this.bntSoma.Size = new System.Drawing.Size(34, 23);
            this.bntSoma.TabIndex = 4;
            this.bntSoma.Text = "+";
            this.bntSoma.UseVisualStyleBackColor = true;
            this.bntSoma.Click += new System.EventHandler(this.bntSoma_Click);
            // 
            // bntSubtracao
            // 
            this.bntSubtracao.Location = new System.Drawing.Point(88, 105);
            this.bntSubtracao.Name = "bntSubtracao";
            this.bntSubtracao.Size = new System.Drawing.Size(34, 23);
            this.bntSubtracao.TabIndex = 5;
            this.bntSubtracao.Text = "-";
            this.bntSubtracao.UseVisualStyleBackColor = true;
            this.bntSubtracao.Click += new System.EventHandler(this.bntSubtracao_Click);
            // 
            // bntDivisao
            // 
            this.bntDivisao.Location = new System.Drawing.Point(167, 106);
            this.bntDivisao.Name = "bntDivisao";
            this.bntDivisao.Size = new System.Drawing.Size(34, 23);
            this.bntDivisao.TabIndex = 7;
            this.bntDivisao.Text = "/";
            this.bntDivisao.UseVisualStyleBackColor = true;
            this.bntDivisao.Click += new System.EventHandler(this.bntDivisao_Click);
            // 
            // bntMultiplicacao
            // 
            this.bntMultiplicacao.Location = new System.Drawing.Point(128, 105);
            this.bntMultiplicacao.Name = "bntMultiplicacao";
            this.bntMultiplicacao.Size = new System.Drawing.Size(34, 23);
            this.bntMultiplicacao.TabIndex = 6;
            this.bntMultiplicacao.Text = "*";
            this.bntMultiplicacao.UseVisualStyleBackColor = true;
            this.bntMultiplicacao.Click += new System.EventHandler(this.bntMultiplicacao_Click);
            // 
            // bntPotenciacao
            // 
            this.bntPotenciacao.Location = new System.Drawing.Point(246, 106);
            this.bntPotenciacao.Name = "bntPotenciacao";
            this.bntPotenciacao.Size = new System.Drawing.Size(79, 23);
            this.bntPotenciacao.TabIndex = 9;
            this.bntPotenciacao.Text = "potenciação";
            this.bntPotenciacao.UseVisualStyleBackColor = true;
            this.bntPotenciacao.Click += new System.EventHandler(this.bntPotenciacao_Click);
            // 
            // bntResto
            // 
            this.bntResto.Location = new System.Drawing.Point(207, 105);
            this.bntResto.Name = "bntResto";
            this.bntResto.Size = new System.Drawing.Size(34, 23);
            this.bntResto.TabIndex = 8;
            this.bntResto.Text = "%";
            this.bntResto.UseVisualStyleBackColor = true;
            this.bntResto.Click += new System.EventHandler(this.bntResto_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Resultado";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(124, 135);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(153, 20);
            this.txtResultado.TabIndex = 10;
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(38, 186);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 13;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(231, 186);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 14;
            this.bntSair.Text = "sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 221);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.bntPotenciacao);
            this.Controls.Add(this.bntResto);
            this.Controls.Add(this.bntDivisao);
            this.Controls.Add(this.bntMultiplicacao);
            this.Controls.Add(this.bntSubtracao);
            this.Controls.Add(this.bntSoma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero1;
        private System.Windows.Forms.TextBox txtNumero2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntSoma;
        private System.Windows.Forms.Button bntSubtracao;
        private System.Windows.Forms.Button bntDivisao;
        private System.Windows.Forms.Button bntMultiplicacao;
        private System.Windows.Forms.Button bntPotenciacao;
        private System.Windows.Forms.Button bntResto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
    }
}

