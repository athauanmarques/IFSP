namespace CalculadoraSimples
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
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpTudo = new System.Windows.Forms.Button();
            this.btnLimpResult = new System.Windows.Forms.Button();
            this.txtRes = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.btnResto = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(120, 199);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 44;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // btnLimpTudo
            // 
            this.btnLimpTudo.Location = new System.Drawing.Point(6, 199);
            this.btnLimpTudo.Name = "btnLimpTudo";
            this.btnLimpTudo.Size = new System.Drawing.Size(96, 23);
            this.btnLimpTudo.TabIndex = 43;
            this.btnLimpTudo.Text = "Limpa Tudo";
            this.btnLimpTudo.UseVisualStyleBackColor = true;
            // 
            // btnLimpResult
            // 
            this.btnLimpResult.Location = new System.Drawing.Point(6, 172);
            this.btnLimpResult.Name = "btnLimpResult";
            this.btnLimpResult.Size = new System.Drawing.Size(96, 21);
            this.btnLimpResult.TabIndex = 42;
            this.btnLimpResult.Text = "Limpa Resultado";
            this.btnLimpResult.UseVisualStyleBackColor = true;
            // 
            // txtRes
            // 
            this.txtRes.Location = new System.Drawing.Point(81, 137);
            this.txtRes.Name = "txtRes";
            this.txtRes.ReadOnly = true;
            this.txtRes.Size = new System.Drawing.Size(100, 20);
            this.txtRes.TabIndex = 41;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(81, 67);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(103, 20);
            this.txtNum2.TabIndex = 40;
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(81, 39);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(103, 20);
            this.txtNum1.TabIndex = 39;
            // 
            // btnResto
            // 
            this.btnResto.Location = new System.Drawing.Point(157, 94);
            this.btnResto.Name = "btnResto";
            this.btnResto.Size = new System.Drawing.Size(38, 23);
            this.btnResto.TabIndex = 38;
            this.btnResto.Text = "resto";
            this.btnResto.UseVisualStyleBackColor = true;
            this.btnResto.Click += new System.EventHandler(this.btnResto_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(123, 94);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(28, 23);
            this.btnDiv.TabIndex = 37;
            this.btnDiv.Text = "/";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.btnDiv_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(88, 93);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(29, 23);
            this.btnMult.TabIndex = 36;
            this.btnMult.Text = "*";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(51, 93);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(31, 23);
            this.btnSub.TabIndex = 35;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(11, 94);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(34, 23);
            this.btnSoma.TabIndex = 34;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Resultado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Numero2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Numero1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Calculos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 246);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpTudo);
            this.Controls.Add(this.btnLimpResult);
            this.Controls.Add(this.txtRes);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.btnResto);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpTudo;
        private System.Windows.Forms.Button btnLimpResult;
        private System.Windows.Forms.TextBox txtRes;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.Button btnResto;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

