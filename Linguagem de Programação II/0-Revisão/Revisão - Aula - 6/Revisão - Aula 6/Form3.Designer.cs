namespace Revisão___Aula_6
{
    partial class Form3
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
            this.txtTaxaJuros = new System.Windows.Forms.TextBox();
            this.txtJurosTotal = new System.Windows.Forms.TextBox();
            this.txtPrestacao = new System.Windows.Forms.TextBox();
            this.txtFinalPreco = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bntCalular = new System.Windows.Forms.Button();
            this.cbbProduto = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(171, 74);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(100, 20);
            this.txtPreco.TabIndex = 1;
            // 
            // txtParcelas
            // 
            this.txtParcelas.Location = new System.Drawing.Point(171, 101);
            this.txtParcelas.Name = "txtParcelas";
            this.txtParcelas.Size = new System.Drawing.Size(100, 20);
            this.txtParcelas.TabIndex = 2;
            // 
            // txtTaxaJuros
            // 
            this.txtTaxaJuros.Location = new System.Drawing.Point(171, 128);
            this.txtTaxaJuros.Name = "txtTaxaJuros";
            this.txtTaxaJuros.Size = new System.Drawing.Size(100, 20);
            this.txtTaxaJuros.TabIndex = 3;
            // 
            // txtJurosTotal
            // 
            this.txtJurosTotal.Enabled = false;
            this.txtJurosTotal.Location = new System.Drawing.Point(171, 175);
            this.txtJurosTotal.Name = "txtJurosTotal";
            this.txtJurosTotal.ReadOnly = true;
            this.txtJurosTotal.Size = new System.Drawing.Size(100, 20);
            this.txtJurosTotal.TabIndex = 4;
            // 
            // txtPrestacao
            // 
            this.txtPrestacao.Enabled = false;
            this.txtPrestacao.Location = new System.Drawing.Point(171, 202);
            this.txtPrestacao.Name = "txtPrestacao";
            this.txtPrestacao.ReadOnly = true;
            this.txtPrestacao.Size = new System.Drawing.Size(100, 20);
            this.txtPrestacao.TabIndex = 5;
            // 
            // txtFinalPreco
            // 
            this.txtFinalPreco.Enabled = false;
            this.txtFinalPreco.Location = new System.Drawing.Point(171, 229);
            this.txtFinalPreco.Name = "txtFinalPreco";
            this.txtFinalPreco.ReadOnly = true;
            this.txtFinalPreco.Size = new System.Drawing.Size(100, 20);
            this.txtFinalPreco.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Produto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Preço";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nªparcelas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Taxa de juros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Juros";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(58, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Valor prestação";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(58, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Preço final";
            // 
            // bntCalular
            // 
            this.bntCalular.Location = new System.Drawing.Point(244, 275);
            this.bntCalular.Name = "bntCalular";
            this.bntCalular.Size = new System.Drawing.Size(75, 23);
            this.bntCalular.TabIndex = 14;
            this.bntCalular.Text = "button1";
            this.bntCalular.UseVisualStyleBackColor = true;
            this.bntCalular.Click += new System.EventHandler(this.bntCalular_Click);
            // 
            // cbbProduto
            // 
            this.cbbProduto.FormattingEnabled = true;
            this.cbbProduto.Location = new System.Drawing.Point(171, 45);
            this.cbbProduto.Name = "cbbProduto";
            this.cbbProduto.Size = new System.Drawing.Size(121, 21);
            this.cbbProduto.TabIndex = 15;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 339);
            this.Controls.Add(this.cbbProduto);
            this.Controls.Add(this.bntCalular);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFinalPreco);
            this.Controls.Add(this.txtPrestacao);
            this.Controls.Add(this.txtJurosTotal);
            this.Controls.Add(this.txtTaxaJuros);
            this.Controls.Add(this.txtParcelas);
            this.Controls.Add(this.txtPreco);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtParcelas;
        private System.Windows.Forms.TextBox txtTaxaJuros;
        private System.Windows.Forms.TextBox txtJurosTotal;
        private System.Windows.Forms.TextBox txtPrestacao;
        private System.Windows.Forms.TextBox txtFinalPreco;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bntCalular;
        private System.Windows.Forms.ComboBox cbbProduto;

    }
}