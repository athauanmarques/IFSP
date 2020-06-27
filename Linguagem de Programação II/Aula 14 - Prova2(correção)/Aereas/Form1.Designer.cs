namespace Aereas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDistancia = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPassagem = new System.Windows.Forms.Label();
            this.cboOrigem = new System.Windows.Forms.ComboBox();
            this.cboDestino = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbPrimeiraClasse = new System.Windows.Forms.RadioButton();
            this.rdbExecutiva = new System.Windows.Forms.RadioButton();
            this.rdbEconomica = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Origem:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Destino:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(210, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Distância entre Cidades (Km):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Preço por Km:";
            // 
            // lblDistancia
            // 
            this.lblDistancia.BackColor = System.Drawing.SystemColors.Control;
            this.lblDistancia.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDistancia.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistancia.ForeColor = System.Drawing.Color.Navy;
            this.lblDistancia.Location = new System.Drawing.Point(228, 114);
            this.lblDistancia.Name = "lblDistancia";
            this.lblDistancia.Size = new System.Drawing.Size(96, 28);
            this.lblDistancia.TabIndex = 4;
            this.lblDistancia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreco
            // 
            this.lblPreco.BackColor = System.Drawing.SystemColors.Control;
            this.lblPreco.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPreco.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.ForeColor = System.Drawing.Color.Red;
            this.lblPreco.Location = new System.Drawing.Point(198, 152);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(126, 29);
            this.lblPreco.TabIndex = 5;
            this.lblPreco.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Valor da Passagem:";
            // 
            // lblPassagem
            // 
            this.lblPassagem.BackColor = System.Drawing.SystemColors.Control;
            this.lblPassagem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPassagem.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassagem.ForeColor = System.Drawing.Color.Red;
            this.lblPassagem.Location = new System.Drawing.Point(198, 379);
            this.lblPassagem.Name = "lblPassagem";
            this.lblPassagem.Size = new System.Drawing.Size(126, 30);
            this.lblPassagem.TabIndex = 7;
            this.lblPassagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cboOrigem
            // 
            this.cboOrigem.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboOrigem.FormattingEnabled = true;
            this.cboOrigem.Location = new System.Drawing.Point(164, 14);
            this.cboOrigem.Name = "cboOrigem";
            this.cboOrigem.Size = new System.Drawing.Size(161, 23);
            this.cboOrigem.TabIndex = 8;
            // 
            // cboDestino
            // 
            this.cboDestino.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDestino.FormattingEnabled = true;
            this.cboDestino.Location = new System.Drawing.Point(164, 60);
            this.cboDestino.Name = "cboDestino";
            this.cboDestino.Size = new System.Drawing.Size(161, 23);
            this.cboDestino.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.rdbPrimeiraClasse);
            this.groupBox1.Controls.Add(this.rdbExecutiva);
            this.groupBox1.Controls.Add(this.rdbEconomica);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 196);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(159, 156);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Classes";
            // 
            // rdbPrimeiraClasse
            // 
            this.rdbPrimeiraClasse.AutoSize = true;
            this.rdbPrimeiraClasse.Location = new System.Drawing.Point(15, 116);
            this.rdbPrimeiraClasse.Name = "rdbPrimeiraClasse";
            this.rdbPrimeiraClasse.Size = new System.Drawing.Size(130, 19);
            this.rdbPrimeiraClasse.TabIndex = 2;
            this.rdbPrimeiraClasse.TabStop = true;
            this.rdbPrimeiraClasse.Text = "Primeira Classe";
            this.rdbPrimeiraClasse.UseVisualStyleBackColor = true;
            // 
            // rdbExecutiva
            // 
            this.rdbExecutiva.AutoSize = true;
            this.rdbExecutiva.Location = new System.Drawing.Point(15, 71);
            this.rdbExecutiva.Name = "rdbExecutiva";
            this.rdbExecutiva.Size = new System.Drawing.Size(88, 19);
            this.rdbExecutiva.TabIndex = 1;
            this.rdbExecutiva.TabStop = true;
            this.rdbExecutiva.Text = "Executiva";
            this.rdbExecutiva.UseVisualStyleBackColor = true;
            // 
            // rdbEconomica
            // 
            this.rdbEconomica.AutoSize = true;
            this.rdbEconomica.Location = new System.Drawing.Point(15, 31);
            this.rdbEconomica.Name = "rdbEconomica";
            this.rdbEconomica.Size = new System.Drawing.Size(88, 19);
            this.rdbEconomica.TabIndex = 0;
            this.rdbEconomica.TabStop = true;
            this.rdbEconomica.Text = "Econômica";
            this.rdbEconomica.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.Control;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(228, 195);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(60, 45);
            this.btnCalcular.TabIndex = 11;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(228, 254);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(60, 45);
            this.btnLimpar.TabIndex = 12;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.Control;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(228, 316);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(60, 45);
            this.btnSair.TabIndex = 13;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(340, 429);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cboDestino);
            this.Controls.Add(this.cboOrigem);
            this.Controls.Add(this.lblPassagem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblDistancia);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Passagem Aérea";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDistancia;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblPassagem;
        private System.Windows.Forms.ComboBox cboOrigem;
        private System.Windows.Forms.ComboBox cboDestino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbPrimeiraClasse;
        private System.Windows.Forms.RadioButton rdbExecutiva;
        private System.Windows.Forms.RadioButton rdbEconomica;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}

