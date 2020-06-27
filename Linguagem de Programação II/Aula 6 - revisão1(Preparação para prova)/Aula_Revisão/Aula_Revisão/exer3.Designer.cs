namespace Aula_Revisão
{
    partial class exer3
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
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtParcelas = new System.Windows.Forms.TextBox();
            this.txtPrestencaoResult = new System.Windows.Forms.TextBox();
            this.txtJurosResult = new System.Windows.Forms.TextBox();
            this.txtTaxaJuros = new System.Windows.Forms.TextBox();
            this.txtPrecoFinal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.ccbProduto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(179, 66);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 1;
            // 
            // txtParcelas
            // 
            this.txtParcelas.Location = new System.Drawing.Point(179, 92);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(100, 20);
            this.txtParcelas.TabIndex = 2;
            // 
            // txtPrestencaoResult
            // 
            this.txtPrestencaoResult.Enabled = false;
            this.txtPrestencaoResult.Location = new System.Drawing.Point(179, 183);
            this.txtPrestencaoResult.Name = "txtPrestencaoResult";
            this.txtPrestencaoResult.ReadOnly = true;
            this.txtPrestencaoResult.Size = new System.Drawing.Size(100, 20);
            this.txtPrestencaoResult.TabIndex = 5;
            // 
            // txtJurosResult
            // 
            this.txtJurosResult.Enabled = false;
            this.txtJurosResult.Location = new System.Drawing.Point(179, 157);
            this.txtJurosResult.Name = "txtJurosResult";
            this.txtJurosResult.ReadOnly = true;
            this.txtJurosResult.Size = new System.Drawing.Size(100, 20);
            this.txtJurosResult.TabIndex = 4;
            // 
            // txtTaxaJuros
            // 
            this.txtTaxaJuros.Location = new System.Drawing.Point(179, 118);
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaJuros.TabIndex = 3;
            // 
            // txtPrecoFinal
            // 
            this.txtPrecoFinal.Enabled = false;
            this.txtPrecoFinal.Location = new System.Drawing.Point(179, 209);
            this.txtPrecoFinal.Name = "txtPrecoFinal";
            this.txtPrecoFinal.ReadOnly = true;
            this.txtPrecoFinal.Size = new System.Drawing.Size(100, 20);
            this.txtPrecoFinal.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Produto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nªde parcelas:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Taxa de juros(%):";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(72, 216);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(63, 13);
            this.label.TabIndex = 13;
            this.label.Text = "Preço Final:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(72, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor Prestenção:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Juros:";
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(63, 260);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(75, 23);
            this.bntCalcular.TabIndex = 14;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(179, 259);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 15;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(296, 259);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 16;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // ccbProduto
            // 
            this.ccbProduto.FormattingEnabled = true;
            this.ccbProduto.Location = new System.Drawing.Point(179, 37);
            this.ccbProduto.Name = "ccbProduto";
            this.ccbProduto.Size = new System.Drawing.Size(121, 21);
            this.ccbProduto.TabIndex = 17;
            this.ccbProduto.Text = "Selecione";
            // 
            // exer3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 308);
            this.Controls.Add(this.ccbProduto);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecoFinal);
            this.Controls.Add(this.txtPrestencaoResult);
            this.Controls.Add(this.txtJurosResult);
            this.Controls.Add(this.txtTaxaJuros);
            this.Controls.Add(this.txtParcelas);
            this.Controls.Add(this.txtPreco);
            this.Name = "exer3";
            this.Text = "exer3";
            this.Load += new System.EventHandler(this.exer3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.TextBox txtPrestencaoResult;
        private System.Windows.Forms.TextBox txtJurosResult;
        private System.Windows.Forms.TextBox txtTaxaJuros;
        private System.Windows.Forms.TextBox txtPrecoFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.ComboBox ccbProduto;
    }
}