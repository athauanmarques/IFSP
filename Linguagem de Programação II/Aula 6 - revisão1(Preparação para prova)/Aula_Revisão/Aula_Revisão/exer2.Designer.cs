namespace Aula_Revisão
{
    partial class exer2
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
            this.txtQtsEntrada = new System.Windows.Forms.TextBox();
            this.txtQtsResult = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.rdbJuca = new System.Windows.Forms.RadioButton();
            this.rdbTuca = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtQtsEntrada
            // 
            this.txtQtsEntrada.Location = new System.Drawing.Point(216, 29);
            this.txtQtsEntrada.Name = "txtQtsEntrada";
            this.txtQtsEntrada.Size = new System.Drawing.Size(100, 20);
            this.txtQtsEntrada.TabIndex = 0;
            // 
            // txtQtsResult
            // 
            this.txtQtsResult.Enabled = false;
            this.txtQtsResult.Location = new System.Drawing.Point(183, 20);
            this.txtQtsResult.Name = "txtQtsResult";
            this.txtQtsResult.ReadOnly = true;
            this.txtQtsResult.Size = new System.Drawing.Size(65, 20);
            this.txtQtsResult.TabIndex = 1;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(183, 60);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(65, 20);
            this.txtTotal.TabIndex = 2;
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(336, 123);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(75, 23);
            this.bntCalcular.TabIndex = 3;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(336, 152);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 4;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(336, 181);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 5;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // rdbJuca
            // 
            this.rdbJuca.AutoSize = true;
            this.rdbJuca.Location = new System.Drawing.Point(13, 15);
            this.rdbJuca.Name = "rdbJuca";
            this.rdbJuca.Size = new System.Drawing.Size(179, 17);
            this.rdbJuca.TabIndex = 6;
            this.rdbJuca.TabStop = true;
            this.rdbJuca.Text = "Juca Tinta (Rendimento 145 m2)";
            this.rdbJuca.UseVisualStyleBackColor = true;
            // 
            // rdbTuca
            // 
            this.rdbTuca.AutoSize = true;
            this.rdbTuca.Location = new System.Drawing.Point(228, 15);
            this.rdbTuca.Name = "rdbTuca";
            this.rdbTuca.Size = new System.Drawing.Size(181, 17);
            this.rdbTuca.TabIndex = 7;
            this.rdbTuca.TabStop = true;
            this.rdbTuca.Text = "Tuca Tinta (Rendimento 180 m2)";
            this.rdbTuca.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Quantidade de Tinta:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Total Gasto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Quantidade a ser Pintada (m2):";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbTuca);
            this.groupBox1.Controls.Add(this.rdbJuca);
            this.groupBox1.Location = new System.Drawing.Point(12, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(456, 44);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a Tinta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtTotal);
            this.groupBox2.Controls.Add(this.txtQtsResult);
            this.groupBox2.Location = new System.Drawing.Point(25, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(269, 102);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rsultado";
            // 
            // exer2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(480, 271);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.txtQtsEntrada);
            this.Name = "exer2";
            this.Text = "exercicio 2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtQtsEntrada;
        private System.Windows.Forms.TextBox txtQtsResult;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.RadioButton rdbJuca;
        private System.Windows.Forms.RadioButton rdbTuca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}