namespace EXER1_Matriz
{
    partial class strings_exer
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
            this.bntMaisculo = new System.Windows.Forms.Button();
            this.bntMinus = new System.Windows.Forms.Button();
            this.bntContaL = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.bntSubstring = new System.Windows.Forms.Button();
            this.bntReplace = new System.Windows.Forms.Button();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.lblStatus4 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntMaisculo
            // 
            this.bntMaisculo.Location = new System.Drawing.Point(28, 80);
            this.bntMaisculo.Name = "bntMaisculo";
            this.bntMaisculo.Size = new System.Drawing.Size(75, 23);
            this.bntMaisculo.TabIndex = 0;
            this.bntMaisculo.Text = "Maiusculo";
            this.bntMaisculo.UseVisualStyleBackColor = true;
            this.bntMaisculo.Click += new System.EventHandler(this.bntMaisculo_Click);
            // 
            // bntMinus
            // 
            this.bntMinus.Location = new System.Drawing.Point(28, 109);
            this.bntMinus.Name = "bntMinus";
            this.bntMinus.Size = new System.Drawing.Size(75, 23);
            this.bntMinus.TabIndex = 1;
            this.bntMinus.Text = "Minusculo";
            this.bntMinus.UseVisualStyleBackColor = true;
            this.bntMinus.Click += new System.EventHandler(this.bntMinus_Click);
            // 
            // bntContaL
            // 
            this.bntContaL.Location = new System.Drawing.Point(28, 138);
            this.bntContaL.Name = "bntContaL";
            this.bntContaL.Size = new System.Drawing.Size(75, 23);
            this.bntContaL.TabIndex = 3;
            this.bntContaL.Text = "Conta Letra";
            this.bntContaL.UseVisualStyleBackColor = true;
            this.bntContaL.Click += new System.EventHandler(this.bntContaL_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(212, 227);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // bntSubstring
            // 
            this.bntSubstring.Location = new System.Drawing.Point(109, 167);
            this.bntSubstring.Name = "bntSubstring";
            this.bntSubstring.Size = new System.Drawing.Size(75, 23);
            this.bntSubstring.TabIndex = 5;
            this.bntSubstring.Text = "Substring";
            this.bntSubstring.UseVisualStyleBackColor = true;
            this.bntSubstring.Click += new System.EventHandler(this.bntSubstring_Click);
            // 
            // bntReplace
            // 
            this.bntReplace.Location = new System.Drawing.Point(28, 167);
            this.bntReplace.Name = "bntReplace";
            this.bntReplace.Size = new System.Drawing.Size(75, 23);
            this.bntReplace.TabIndex = 4;
            this.bntReplace.Text = "Replace";
            this.bntReplace.UseVisualStyleBackColor = true;
            this.bntReplace.Click += new System.EventHandler(this.bntReplace_Click);
            // 
            // lblStatus1
            // 
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.Location = new System.Drawing.Point(127, 85);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(49, 13);
            this.lblStatus1.TabIndex = 6;
            this.lblStatus1.Text = "Status 1:";
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Location = new System.Drawing.Point(127, 114);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(49, 13);
            this.lblStatus2.TabIndex = 7;
            this.lblStatus2.Text = "Status 2:";
            // 
            // lblStatus4
            // 
            this.lblStatus4.AutoSize = true;
            this.lblStatus4.Location = new System.Drawing.Point(127, 143);
            this.lblStatus4.Name = "lblStatus4";
            this.lblStatus4.Size = new System.Drawing.Size(49, 13);
            this.lblStatus4.TabIndex = 8;
            this.lblStatus4.Text = "Status 4:";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(19, 28);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(245, 20);
            this.txtTexto.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 275);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "OBS: Replace só vai ser trocado por \"p\" e \"g\"";
            // 
            // strings_exer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 307);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.lblStatus4);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.lblStatus1);
            this.Controls.Add(this.bntSubstring);
            this.Controls.Add(this.bntReplace);
            this.Controls.Add(this.bntContaL);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.bntMinus);
            this.Controls.Add(this.bntMaisculo);
            this.Name = "strings_exer";
            this.Text = "strings_exer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntMaisculo;
        private System.Windows.Forms.Button bntMinus;
        private System.Windows.Forms.Button bntContaL;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button bntSubstring;
        private System.Windows.Forms.Button bntReplace;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Label lblStatus4;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.Label label1;
    }
}