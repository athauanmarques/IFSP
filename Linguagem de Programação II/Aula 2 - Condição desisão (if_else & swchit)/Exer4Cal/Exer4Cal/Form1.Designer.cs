namespace WindowsFormsApplication1
{
    partial class Calculadora
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
            this.txtValor1 = new System.Windows.Forms.TextBox();
            this.txtValor2 = new System.Windows.Forms.TextBox();
            this.bntSoma = new System.Windows.Forms.Button();
            this.bntDividir = new System.Windows.Forms.Button();
            this.bntSub = new System.Windows.Forms.Button();
            this.bntMult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(66, 57);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(58, 20);
            this.txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(70, 96);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(56, 20);
            this.txtValor2.TabIndex = 1;
            // 
            // bntSoma
            // 
            this.bntSoma.Location = new System.Drawing.Point(40, 138);
            this.bntSoma.Name = "bntSoma";
            this.bntSoma.Size = new System.Drawing.Size(24, 21);
            this.bntSoma.TabIndex = 2;
            this.bntSoma.Text = "+";
            this.bntSoma.UseVisualStyleBackColor = true;
            this.bntSoma.Click += new System.EventHandler(this.bntSoma_Click);
            // 
            // bntDividir
            // 
            this.bntDividir.Location = new System.Drawing.Point(100, 138);
            this.bntDividir.Name = "bntDividir";
            this.bntDividir.Size = new System.Drawing.Size(24, 21);
            this.bntDividir.TabIndex = 3;
            this.bntDividir.Text = "/";
            this.bntDividir.UseVisualStyleBackColor = true;
            this.bntDividir.Click += new System.EventHandler(this.bntDividir_Click);
            // 
            // bntSub
            // 
            this.bntSub.Location = new System.Drawing.Point(70, 138);
            this.bntSub.Name = "bntSub";
            this.bntSub.Size = new System.Drawing.Size(24, 21);
            this.bntSub.TabIndex = 4;
            this.bntSub.Text = "-";
            this.bntSub.UseVisualStyleBackColor = true;
            this.bntSub.Click += new System.EventHandler(this.bntSub_Click);
            // 
            // bntMult
            // 
            this.bntMult.Location = new System.Drawing.Point(130, 138);
            this.bntMult.Name = "bntMult";
            this.bntMult.Size = new System.Drawing.Size(24, 21);
            this.bntMult.TabIndex = 5;
            this.bntMult.Text = "*";
            this.bntMult.UseVisualStyleBackColor = true;
            this.bntMult.Click += new System.EventHandler(this.bntMult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Valor 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Valor 2:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(64, 199);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 8;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntMult);
            this.Controls.Add(this.bntSub);
            this.Controls.Add(this.bntDividir);
            this.Controls.Add(this.bntSoma);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "Calculadora";
            this.Text = "Calculador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Button bntSoma;
        private System.Windows.Forms.Button bntDividir;
        private System.Windows.Forms.Button bntSub;
        private System.Windows.Forms.Button bntMult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
    }
}

