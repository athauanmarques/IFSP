namespace Decisão
{
    partial class reajuste
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
            this.txtSal = new System.Windows.Forms.TextBox();
            this.cbbSalario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblImposto = new System.Windows.Forms.Label();
            this.lblAumento = new System.Windows.Forms.Label();
            this.lblNovoSal = new System.Windows.Forms.Label();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSal
            // 
            this.txtSal.Location = new System.Drawing.Point(35, 37);
            this.txtSal.Name = "txtSal";
            this.txtSal.Size = new System.Drawing.Size(104, 20);
            this.txtSal.TabIndex = 0;
            // 
            // cbbSalario
            // 
            this.cbbSalario.FormattingEnabled = true;
            this.cbbSalario.Items.AddRange(new object[] {
            "Salario",
            "Imposto",
            "Aumento"});
            this.cbbSalario.Location = new System.Drawing.Point(35, 91);
            this.cbbSalario.Name = "cbbSalario";
            this.cbbSalario.Size = new System.Drawing.Size(121, 21);
            this.cbbSalario.TabIndex = 1;
            this.cbbSalario.SelectedIndexChanged += new System.EventHandler(this.cbbSalario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informe o seu salário:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selecione a opção abaixo:";
            // 
            // lblImposto
            // 
            this.lblImposto.AutoSize = true;
            this.lblImposto.Location = new System.Drawing.Point(32, 145);
            this.lblImposto.Name = "lblImposto";
            this.lblImposto.Size = new System.Drawing.Size(47, 13);
            this.lblImposto.TabIndex = 5;
            this.lblImposto.Text = "Imposto:";
            // 
            // lblAumento
            // 
            this.lblAumento.AutoSize = true;
            this.lblAumento.Location = new System.Drawing.Point(32, 187);
            this.lblAumento.Name = "lblAumento";
            this.lblAumento.Size = new System.Drawing.Size(52, 13);
            this.lblAumento.TabIndex = 4;
            this.lblAumento.Text = "Aumento:";
            // 
            // lblNovoSal
            // 
            this.lblNovoSal.AutoSize = true;
            this.lblNovoSal.Location = new System.Drawing.Point(32, 222);
            this.lblNovoSal.Name = "lblNovoSal";
            this.lblNovoSal.Size = new System.Drawing.Size(71, 13);
            this.lblNovoSal.TabIndex = 7;
            this.lblNovoSal.Text = "Novo Salário:";
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(198, 35);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 8;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(198, 91);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 9;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // reajuste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 261);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.lblNovoSal);
            this.Controls.Add(this.lblImposto);
            this.Controls.Add(this.lblAumento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbSalario);
            this.Controls.Add(this.txtSal);
            this.Name = "reajuste";
            this.Text = "Reajuste de Salário";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSal;
        private System.Windows.Forms.ComboBox cbbSalario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblImposto;
        private System.Windows.Forms.Label lblAumento;
        private System.Windows.Forms.Label lblNovoSal;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
    }
}

