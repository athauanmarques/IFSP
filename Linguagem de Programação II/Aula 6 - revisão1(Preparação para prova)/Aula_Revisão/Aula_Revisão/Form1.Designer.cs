namespace Aula_Revisão
{
    partial class frmProdutos
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
            this.bntCalcular = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.txtMaiorPreco = new System.Windows.Forms.TextBox();
            this.txtMenorPreco = new System.Windows.Forms.TextBox();
            this.txtEntrada0 = new System.Windows.Forms.TextBox();
            this.txtEntrada1 = new System.Windows.Forms.TextBox();
            this.txtEntrada2 = new System.Windows.Forms.TextBox();
            this.txtEntrada5 = new System.Windows.Forms.TextBox();
            this.txtEntrada4 = new System.Windows.Forms.TextBox();
            this.txtEntrada3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(352, 49);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(75, 23);
            this.bntCalcular.TabIndex = 0;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(352, 98);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 1;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(352, 146);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 2;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // txtMaiorPreco
            // 
            this.txtMaiorPreco.Location = new System.Drawing.Point(157, 101);
            this.txtMaiorPreco.Name = "txtMaiorPreco";
            this.txtMaiorPreco.ReadOnly = true;
            this.txtMaiorPreco.Size = new System.Drawing.Size(100, 20);
            this.txtMaiorPreco.TabIndex = 3;
            // 
            // txtMenorPreco
            // 
            this.txtMenorPreco.Location = new System.Drawing.Point(157, 130);
            this.txtMenorPreco.Name = "txtMenorPreco";
            this.txtMenorPreco.ReadOnly = true;
            this.txtMenorPreco.Size = new System.Drawing.Size(100, 20);
            this.txtMenorPreco.TabIndex = 4;
            // 
            // txtEntrada0
            // 
            this.txtEntrada0.Location = new System.Drawing.Point(73, 49);
            this.txtEntrada0.Name = "txtEntrada0";
            this.txtEntrada0.Size = new System.Drawing.Size(36, 20);
            this.txtEntrada0.TabIndex = 5;
            // 
            // txtEntrada1
            // 
            this.txtEntrada1.Location = new System.Drawing.Point(115, 49);
            this.txtEntrada1.Name = "txtEntrada1";
            this.txtEntrada1.Size = new System.Drawing.Size(36, 20);
            this.txtEntrada1.TabIndex = 6;
            // 
            // txtEntrada2
            // 
            this.txtEntrada2.Location = new System.Drawing.Point(157, 49);
            this.txtEntrada2.Name = "txtEntrada2";
            this.txtEntrada2.Size = new System.Drawing.Size(36, 20);
            this.txtEntrada2.TabIndex = 7;
            // 
            // txtEntrada5
            // 
            this.txtEntrada5.Location = new System.Drawing.Point(282, 49);
            this.txtEntrada5.Name = "txtEntrada5";
            this.txtEntrada5.Size = new System.Drawing.Size(36, 20);
            this.txtEntrada5.TabIndex = 10;
            // 
            // txtEntrada4
            // 
            this.txtEntrada4.Location = new System.Drawing.Point(240, 49);
            this.txtEntrada4.Name = "txtEntrada4";
            this.txtEntrada4.Size = new System.Drawing.Size(36, 20);
            this.txtEntrada4.TabIndex = 9;
            // 
            // txtEntrada3
            // 
            this.txtEntrada3.Location = new System.Drawing.Point(198, 49);
            this.txtEntrada3.Name = "txtEntrada3";
            this.txtEntrada3.Size = new System.Drawing.Size(36, 20);
            this.txtEntrada3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(81, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Maior preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(81, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Menor preço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(73, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Entra com o preço de seis produtos:";
            // 
            // frmProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(490, 204);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtEntrada5);
            this.Controls.Add(this.txtEntrada4);
            this.Controls.Add(this.txtEntrada3);
            this.Controls.Add(this.txtEntrada2);
            this.Controls.Add(this.txtEntrada1);
            this.Controls.Add(this.txtEntrada0);
            this.Controls.Add(this.txtMenorPreco);
            this.Controls.Add(this.txtMaiorPreco);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntCalcular);
            this.Name = "frmProdutos";
            this.Text = "Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.TextBox txtMaiorPreco;
        private System.Windows.Forms.TextBox txtMenorPreco;
        private System.Windows.Forms.TextBox txtEntrada0;
        private System.Windows.Forms.TextBox txtEntrada1;
        private System.Windows.Forms.TextBox txtEntrada2;
        private System.Windows.Forms.TextBox txtEntrada5;
        private System.Windows.Forms.TextBox txtEntrada4;
        private System.Windows.Forms.TextBox txtEntrada3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

