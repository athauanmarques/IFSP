namespace Atividade
{
    partial class consumo
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtInicial = new System.Windows.Forms.TextBox();
            this.txtfinal = new System.Windows.Forms.TextBox();
            this.txtDistanciaResult = new System.Windows.Forms.TextBox();
            this.txtConsumo = new System.Windows.Forms.TextBox();
            this.txtGastoResult = new System.Windows.Forms.TextBox();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kilomentragem Inicial:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(41, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Kilomentragem Final:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(41, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(175, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Consumo do combustivél (em litros):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(41, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Gasto de combustivél percorrido (Km):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(41, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Distância percorrida (Km):";
            // 
            // txtInicial
            // 
            this.txtInicial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtInicial.Location = new System.Drawing.Point(254, 37);
            this.txtInicial.Name = "txtInicial";
            this.txtInicial.Size = new System.Drawing.Size(112, 20);
            this.txtInicial.TabIndex = 0;
            // 
            // txtfinal
            // 
            this.txtfinal.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtfinal.Location = new System.Drawing.Point(254, 64);
            this.txtfinal.Name = "txtfinal";
            this.txtfinal.Size = new System.Drawing.Size(112, 20);
            this.txtfinal.TabIndex = 1;
            // 
            // txtDistanciaResult
            // 
            this.txtDistanciaResult.Cursor = System.Windows.Forms.Cursors.No;
            this.txtDistanciaResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtDistanciaResult.Location = new System.Drawing.Point(254, 122);
            this.txtDistanciaResult.Name = "txtDistanciaResult";
            this.txtDistanciaResult.ReadOnly = true;
            this.txtDistanciaResult.Size = new System.Drawing.Size(112, 20);
            this.txtDistanciaResult.TabIndex = 30;
            // 
            // txtConsumo
            // 
            this.txtConsumo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtConsumo.Location = new System.Drawing.Point(254, 95);
            this.txtConsumo.Name = "txtConsumo";
            this.txtConsumo.Size = new System.Drawing.Size(112, 20);
            this.txtConsumo.TabIndex = 2;
            // 
            // txtGastoResult
            // 
            this.txtGastoResult.Cursor = System.Windows.Forms.Cursors.No;
            this.txtGastoResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtGastoResult.Location = new System.Drawing.Point(254, 151);
            this.txtGastoResult.Name = "txtGastoResult";
            this.txtGastoResult.ReadOnly = true;
            this.txtGastoResult.Size = new System.Drawing.Size(112, 20);
            this.txtGastoResult.TabIndex = 30;
            // 
            // bntLimpar
            // 
            this.bntLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLimpar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntLimpar.Location = new System.Drawing.Point(57, 198);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 4;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = false;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntCalcular
            // 
            this.bntCalcular.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bntCalcular.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntCalcular.Location = new System.Drawing.Point(179, 217);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(75, 23);
            this.bntCalcular.TabIndex = 3;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = false;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // bntSair
            // 
            this.bntSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bntSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSair.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bntSair.Location = new System.Drawing.Point(309, 246);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 5;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = false;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // consumo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atividade.Properties.Resources._3;
            this.ClientSize = new System.Drawing.Size(420, 307);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.txtGastoResult);
            this.Controls.Add(this.txtDistanciaResult);
            this.Controls.Add(this.txtConsumo);
            this.Controls.Add(this.txtfinal);
            this.Controls.Add(this.txtInicial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "consumo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consumo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtInicial;
        private System.Windows.Forms.TextBox txtfinal;
        private System.Windows.Forms.TextBox txtDistanciaResult;
        private System.Windows.Forms.TextBox txtConsumo;
        private System.Windows.Forms.TextBox txtGastoResult;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Button bntSair;
    }
}