namespace Decisão
{
    partial class repetição
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
            this.bntFor = new System.Windows.Forms.Button();
            this.bntWhile = new System.Windows.Forms.Button();
            this.bntDoWhile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxTexto = new System.Windows.Forms.RichTextBox();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntFor
            // 
            this.bntFor.Location = new System.Drawing.Point(28, 62);
            this.bntFor.Name = "bntFor";
            this.bntFor.Size = new System.Drawing.Size(75, 23);
            this.bntFor.TabIndex = 0;
            this.bntFor.Text = "For";
            this.bntFor.UseVisualStyleBackColor = true;
            this.bntFor.Click += new System.EventHandler(this.bntFor_Click);
            // 
            // bntWhile
            // 
            this.bntWhile.Location = new System.Drawing.Point(139, 62);
            this.bntWhile.Name = "bntWhile";
            this.bntWhile.Size = new System.Drawing.Size(75, 23);
            this.bntWhile.TabIndex = 1;
            this.bntWhile.Text = "While";
            this.bntWhile.UseVisualStyleBackColor = true;
            this.bntWhile.Click += new System.EventHandler(this.bntWhile_Click);
            // 
            // bntDoWhile
            // 
            this.bntDoWhile.Location = new System.Drawing.Point(252, 62);
            this.bntDoWhile.Name = "bntDoWhile";
            this.bntDoWhile.Size = new System.Drawing.Size(75, 23);
            this.bntDoWhile.TabIndex = 2;
            this.bntDoWhile.Text = "Do..While";
            this.bntDoWhile.UseVisualStyleBackColor = true;
            this.bntDoWhile.Click += new System.EventHandler(this.bntDoWhile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero inicial (0 a 90):";
            // 
            // rtxTexto
            // 
            this.rtxTexto.Location = new System.Drawing.Point(54, 104);
            this.rtxTexto.Name = "rtxTexto";
            this.rtxTexto.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rtxTexto.Size = new System.Drawing.Size(250, 137);
            this.rtxTexto.TabIndex = 4;
            this.rtxTexto.Text = "";
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(324, 110);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 5;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(159, 22);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(54, 20);
            this.txtNum.TabIndex = 6;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(324, 202);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 7;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // repetição
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 261);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.rtxTexto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntDoWhile);
            this.Controls.Add(this.bntWhile);
            this.Controls.Add(this.bntFor);
            this.Name = "repetição";
            this.Text = "repetição";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntFor;
        private System.Windows.Forms.Button bntWhile;
        private System.Windows.Forms.Button bntDoWhile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxTexto;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button bntSair;
    }
}