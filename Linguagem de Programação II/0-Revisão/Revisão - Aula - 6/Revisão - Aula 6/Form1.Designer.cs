namespace Revisão___Aula_6
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
            this.txt0 = new System.Windows.Forms.TextBox();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txtMaior = new System.Windows.Forms.TextBox();
            this.txtMenor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.bntMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt0
            // 
            this.txt0.Location = new System.Drawing.Point(39, 42);
            this.txt0.Name = "txt0";
            this.txt0.Size = new System.Drawing.Size(33, 20);
            this.txt0.TabIndex = 0;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(78, 42);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(33, 20);
            this.txt1.TabIndex = 1;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(117, 42);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(33, 20);
            this.txt2.TabIndex = 2;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(234, 42);
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(33, 20);
            this.txt5.TabIndex = 5;
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(195, 42);
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(33, 20);
            this.txt4.TabIndex = 4;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(156, 42);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(33, 20);
            this.txt3.TabIndex = 3;
            // 
            // txtMaior
            // 
            this.txtMaior.Location = new System.Drawing.Point(117, 92);
            this.txtMaior.Name = "txtMaior";
            this.txtMaior.Size = new System.Drawing.Size(100, 20);
            this.txtMaior.TabIndex = 6;
            // 
            // txtMenor
            // 
            this.txtMenor.Location = new System.Drawing.Point(117, 129);
            this.txtMenor.Name = "txtMenor";
            this.txtMenor.Size = new System.Drawing.Size(100, 20);
            this.txtMenor.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Maior preço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Menor preço:";
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(297, 44);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 10;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(297, 135);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 25);
            this.bntSair.TabIndex = 12;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            // 
            // bntMostrar
            // 
            this.bntMostrar.Location = new System.Drawing.Point(297, 90);
            this.bntMostrar.Name = "bntMostrar";
            this.bntMostrar.Size = new System.Drawing.Size(75, 23);
            this.bntMostrar.TabIndex = 11;
            this.bntMostrar.Text = "Mostrar";
            this.bntMostrar.UseVisualStyleBackColor = true;
            this.bntMostrar.Click += new System.EventHandler(this.bntMostrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 200);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntMostrar);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMenor);
            this.Controls.Add(this.txtMaior);
            this.Controls.Add(this.txt5);
            this.Controls.Add(this.txt4);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.txt0);
            this.Name = "Form1";
            this.Text = "Vetor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt0;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txtMaior;
        private System.Windows.Forms.TextBox txtMenor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Button bntMostrar;
    }
}

