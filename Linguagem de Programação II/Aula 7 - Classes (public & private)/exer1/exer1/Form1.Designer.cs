namespace exer1
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
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtMensalidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rdnDoutorado = new System.Windows.Forms.RadioButton();
            this.rdbMestrado = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResul = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bntCalular = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(113, 30);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(197, 20);
            this.txtCurso.TabIndex = 0;
            // 
            // txtMensalidade
            // 
            this.txtMensalidade.Location = new System.Drawing.Point(193, 77);
            this.txtMensalidade.Name = "txtMensalidade";
            this.txtMensalidade.Size = new System.Drawing.Size(117, 20);
            this.txtMensalidade.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Curso:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mensalidade Graduação:";
            // 
            // rdnDoutorado
            // 
            this.rdnDoutorado.AutoSize = true;
            this.rdnDoutorado.Location = new System.Drawing.Point(16, 25);
            this.rdnDoutorado.Name = "rdnDoutorado";
            this.rdnDoutorado.Size = new System.Drawing.Size(75, 17);
            this.rdnDoutorado.TabIndex = 2;
            this.rdnDoutorado.TabStop = true;
            this.rdnDoutorado.Text = "Doutorado";
            this.rdnDoutorado.UseVisualStyleBackColor = true;
            // 
            // rdbMestrado
            // 
            this.rdbMestrado.AutoSize = true;
            this.rdbMestrado.Location = new System.Drawing.Point(108, 25);
            this.rdbMestrado.Name = "rdbMestrado";
            this.rdbMestrado.Size = new System.Drawing.Size(69, 17);
            this.rdbMestrado.TabIndex = 3;
            this.rdbMestrado.TabStop = true;
            this.rdbMestrado.Text = "Mestrado";
            this.rdbMestrado.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mensalidade::";
            // 
            // txtResul
            // 
            this.txtResul.Enabled = false;
            this.txtResul.Location = new System.Drawing.Point(156, 251);
            this.txtResul.Name = "txtResul";
            this.txtResul.ReadOnly = true;
            this.txtResul.Size = new System.Drawing.Size(135, 20);
            this.txtResul.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMestrado);
            this.groupBox1.Controls.Add(this.rdnDoutorado);
            this.groupBox1.Location = new System.Drawing.Point(67, 152);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 64);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mesalidade Pôs-Graduado";
            // 
            // bntCalular
            // 
            this.bntCalular.Location = new System.Drawing.Point(36, 304);
            this.bntCalular.Name = "bntCalular";
            this.bntCalular.Size = new System.Drawing.Size(75, 23);
            this.bntCalular.TabIndex = 4;
            this.bntCalular.Text = "Calcular";
            this.bntCalular.UseVisualStyleBackColor = true;
            this.bntCalular.Click += new System.EventHandler(this.bntCalular_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(129, 304);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 5;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(216, 304);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 6;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 342);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntCalular);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtResul);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMensalidade);
            this.Controls.Add(this.txtCurso);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtMensalidade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdnDoutorado;
        private System.Windows.Forms.RadioButton rdbMestrado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResul;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntCalular;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
    }
}

