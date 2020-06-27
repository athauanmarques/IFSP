namespace exemplo1
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt6 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.nMexer1 = new System.Windows.Forms.Label();
            this.nMexer2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.rbtChefe = new System.Windows.Forms.RadioButton();
            this.rbtComissao = new System.Windows.Forms.RadioButton();
            this.rbtProducao = new System.Windows.Forms.RadioButton();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(143, 22);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Location = new System.Drawing.Point(143, 63);
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(100, 20);
            this.txtSobrenome.TabIndex = 1;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(152, 205);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 2;
            // 
            // txt6
            // 
            this.txt6.Location = new System.Drawing.Point(152, 323);
            this.txt6.Name = "txt6";
            this.txt6.Size = new System.Drawing.Size(100, 20);
            this.txt6.TabIndex = 5;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(152, 281);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(100, 20);
            this.txt5.TabIndex = 4;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(152, 240);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(100, 20);
            this.txt4.TabIndex = 3;
            // 
            // nMexer1
            // 
            this.nMexer1.AutoSize = true;
            this.nMexer1.Location = new System.Drawing.Point(76, 29);
            this.nMexer1.Name = "nMexer1";
            this.nMexer1.Size = new System.Drawing.Size(38, 13);
            this.nMexer1.TabIndex = 6;
            this.nMexer1.Text = "Nome:";
            // 
            // nMexer2
            // 
            this.nMexer2.AutoSize = true;
            this.nMexer2.Location = new System.Drawing.Point(76, 70);
            this.nMexer2.Name = "nMexer2";
            this.nMexer2.Size = new System.Drawing.Size(64, 13);
            this.nMexer2.TabIndex = 7;
            this.nMexer2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "label4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "label5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "label6";
            // 
            // rbtChefe
            // 
            this.rbtChefe.AutoSize = true;
            this.rbtChefe.Location = new System.Drawing.Point(17, 19);
            this.rbtChefe.Name = "rbtChefe";
            this.rbtChefe.Size = new System.Drawing.Size(53, 17);
            this.rbtChefe.TabIndex = 12;
            this.rbtChefe.TabStop = true;
            this.rbtChefe.Text = "Chefe";
            this.rbtChefe.UseVisualStyleBackColor = true;
            this.rbtChefe.CheckedChanged += new System.EventHandler(this.rbtChefe_CheckedChanged);
            // 
            // rbtComissao
            // 
            this.rbtComissao.AutoSize = true;
            this.rbtComissao.Location = new System.Drawing.Point(107, 19);
            this.rbtComissao.Name = "rbtComissao";
            this.rbtComissao.Size = new System.Drawing.Size(109, 17);
            this.rbtComissao.TabIndex = 13;
            this.rbtComissao.TabStop = true;
            this.rbtComissao.Text = "Comissão Vendas";
            this.rbtComissao.UseVisualStyleBackColor = true;
            this.rbtComissao.CheckedChanged += new System.EventHandler(this.rbtComissao_CheckedChanged);
            // 
            // rbtProducao
            // 
            this.rbtProducao.AutoSize = true;
            this.rbtProducao.Location = new System.Drawing.Point(255, 19);
            this.rbtProducao.Name = "rbtProducao";
            this.rbtProducao.Size = new System.Drawing.Size(71, 17);
            this.rbtProducao.TabIndex = 14;
            this.rbtProducao.TabStop = true;
            this.rbtProducao.Text = "Produção";
            this.rbtProducao.UseVisualStyleBackColor = true;
            this.rbtProducao.CheckedChanged += new System.EventHandler(this.rbtProducao_CheckedChanged);
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(292, 65);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(75, 23);
            this.bntCalcular.TabIndex = 15;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(292, 238);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 16;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(292, 275);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 17;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtProducao);
            this.groupBox1.Controls.Add(this.rbtComissao);
            this.groupBox1.Controls.Add(this.rbtChefe);
            this.groupBox1.Location = new System.Drawing.Point(27, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 45);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Escolha o tipo de trabalhador";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 375);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nMexer2);
            this.Controls.Add(this.nMexer1);
            this.Controls.Add(this.txt6);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txtSobrenome);
            this.Controls.Add(this.txtNome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt6;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label nMexer1;
        private System.Windows.Forms.Label nMexer2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rbtChefe;
        private System.Windows.Forms.RadioButton rbtComissao;
        private System.Windows.Forms.RadioButton rbtProducao;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

