namespace Exercicio
{
    partial class matrix
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
            this.bntInserir = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bntInserir
            // 
            this.bntInserir.Location = new System.Drawing.Point(327, 101);
            this.bntInserir.Name = "bntInserir";
            this.bntInserir.Size = new System.Drawing.Size(75, 23);
            this.bntInserir.TabIndex = 2;
            this.bntInserir.Text = "Inserir";
            this.bntInserir.UseVisualStyleBackColor = true;
            this.bntInserir.Click += new System.EventHandler(this.bntInserir_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(43, 155);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(40, 13);
            this.lblResultado.TabIndex = 3;
            this.lblResultado.Text = "Status:";
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(46, 384);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 5;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(46, 350);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 6;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(46, 104);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(57, 20);
            this.txtN1.TabIndex = 7;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(146, 104);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(53, 20);
            this.txtN2.TabIndex = 8;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(231, 104);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(61, 20);
            this.txtKm.TabIndex = 9;
            // 
            // matrix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 451);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.bntInserir);
            this.Name = "matrix";
            this.Text = "matrix";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntInserir;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtKm;
    }
}