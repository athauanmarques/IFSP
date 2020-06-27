namespace Revisão___Aula_2
{
    partial class Caluladora
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bntsoma = new System.Windows.Forms.Button();
            this.bntSub = new System.Windows.Forms.Button();
            this.bntDiv = new System.Windows.Forms.Button();
            this.bntMult = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtValor1
            // 
            this.txtValor1.Location = new System.Drawing.Point(111, 43);
            this.txtValor1.Name = "txtValor1";
            this.txtValor1.Size = new System.Drawing.Size(67, 20);
            this.txtValor1.TabIndex = 0;
            // 
            // txtValor2
            // 
            this.txtValor2.Location = new System.Drawing.Point(111, 80);
            this.txtValor2.Name = "txtValor2";
            this.txtValor2.Size = new System.Drawing.Size(67, 20);
            this.txtValor2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Valor 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Valor 2 :";
            // 
            // bntsoma
            // 
            this.bntsoma.Location = new System.Drawing.Point(74, 116);
            this.bntsoma.Name = "bntsoma";
            this.bntsoma.Size = new System.Drawing.Size(31, 25);
            this.bntsoma.TabIndex = 5;
            this.bntsoma.Text = "+";
            this.bntsoma.UseVisualStyleBackColor = true;
            this.bntsoma.Click += new System.EventHandler(this.bntsoma_Click);
            // 
            // bntSub
            // 
            this.bntSub.Location = new System.Drawing.Point(111, 116);
            this.bntSub.Name = "bntSub";
            this.bntSub.Size = new System.Drawing.Size(31, 25);
            this.bntSub.TabIndex = 6;
            this.bntSub.Text = "-";
            this.bntSub.UseVisualStyleBackColor = true;
            this.bntSub.Click += new System.EventHandler(this.bntSub_Click);
            // 
            // bntDiv
            // 
            this.bntDiv.Location = new System.Drawing.Point(148, 116);
            this.bntDiv.Name = "bntDiv";
            this.bntDiv.Size = new System.Drawing.Size(31, 25);
            this.bntDiv.TabIndex = 7;
            this.bntDiv.Text = "/";
            this.bntDiv.UseVisualStyleBackColor = true;
            this.bntDiv.Click += new System.EventHandler(this.bntDiv_Click);
            // 
            // bntMult
            // 
            this.bntMult.Location = new System.Drawing.Point(185, 116);
            this.bntMult.Name = "bntMult";
            this.bntMult.Size = new System.Drawing.Size(31, 25);
            this.bntMult.TabIndex = 8;
            this.bntMult.Text = "*";
            this.bntMult.UseVisualStyleBackColor = true;
            this.bntMult.Click += new System.EventHandler(this.bntMult_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(124, 172);
            this.txtResult.Name = "txtResult";
            this.txtResult.ReadOnly = true;
            this.txtResult.Size = new System.Drawing.Size(39, 20);
            this.txtResult.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(121, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Resultado:";
            // 
            // Caluladora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 274);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.bntMult);
            this.Controls.Add(this.bntDiv);
            this.Controls.Add(this.bntSub);
            this.Controls.Add(this.bntsoma);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtValor2);
            this.Controls.Add(this.txtValor1);
            this.Name = "Caluladora";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtValor1;
        private System.Windows.Forms.TextBox txtValor2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bntsoma;
        private System.Windows.Forms.Button bntSub;
        private System.Windows.Forms.Button bntDiv;
        private System.Windows.Forms.Button bntMult;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label label3;
    }
}

