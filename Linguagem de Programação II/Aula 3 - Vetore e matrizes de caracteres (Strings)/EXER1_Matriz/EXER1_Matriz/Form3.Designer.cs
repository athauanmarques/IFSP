namespace EXER1_Matriz
{
    partial class Form3
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
            this.lblLetra = new System.Windows.Forms.Label();
            this.lblStatusL = new System.Windows.Forms.Label();
            this.lblStatusC = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLetraUsa = new System.Windows.Forms.TextBox();
            this.txtCaracUsa = new System.Windows.Forms.TextBox();
            this.btnVerificaL = new System.Windows.Forms.Button();
            this.bntVerificaC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLetra
            // 
            this.lblLetra.AutoSize = true;
            this.lblLetra.Location = new System.Drawing.Point(42, 48);
            this.lblLetra.Name = "lblLetra";
            this.lblLetra.Size = new System.Drawing.Size(83, 13);
            this.lblLetra.TabIndex = 0;
            this.lblLetra.Text = "Digite uma letra:";
            // 
            // lblStatusL
            // 
            this.lblStatusL.AutoSize = true;
            this.lblStatusL.Location = new System.Drawing.Point(42, 81);
            this.lblStatusL.Name = "lblStatusL";
            this.lblStatusL.Size = new System.Drawing.Size(40, 13);
            this.lblStatusL.TabIndex = 1;
            this.lblStatusL.Text = "Status:";
            // 
            // lblStatusC
            // 
            this.lblStatusC.AutoSize = true;
            this.lblStatusC.Location = new System.Drawing.Point(42, 187);
            this.lblStatusC.Name = "lblStatusC";
            this.lblStatusC.Size = new System.Drawing.Size(40, 13);
            this.lblStatusC.TabIndex = 3;
            this.lblStatusC.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Digite uma caracter:";
            // 
            // txtLetraUsa
            // 
            this.txtLetraUsa.Location = new System.Drawing.Point(177, 47);
            this.txtLetraUsa.Name = "txtLetraUsa";
            this.txtLetraUsa.Size = new System.Drawing.Size(97, 20);
            this.txtLetraUsa.TabIndex = 4;
            // 
            // txtCaracUsa
            // 
            this.txtCaracUsa.Location = new System.Drawing.Point(177, 148);
            this.txtCaracUsa.Name = "txtCaracUsa";
            this.txtCaracUsa.Size = new System.Drawing.Size(97, 20);
            this.txtCaracUsa.TabIndex = 7;
            // 
            // btnVerificaL
            // 
            this.btnVerificaL.Location = new System.Drawing.Point(368, 28);
            this.btnVerificaL.Name = "btnVerificaL";
            this.btnVerificaL.Size = new System.Drawing.Size(84, 66);
            this.btnVerificaL.TabIndex = 8;
            this.btnVerificaL.Text = "Verificar";
            this.btnVerificaL.UseVisualStyleBackColor = true;
            this.btnVerificaL.Click += new System.EventHandler(this.btnVerificaL_Click);
            // 
            // bntVerificaC
            // 
            this.bntVerificaC.Location = new System.Drawing.Point(368, 134);
            this.bntVerificaC.Name = "bntVerificaC";
            this.bntVerificaC.Size = new System.Drawing.Size(84, 66);
            this.bntVerificaC.TabIndex = 9;
            this.bntVerificaC.Text = "Verificar";
            this.bntVerificaC.UseVisualStyleBackColor = true;
            this.bntVerificaC.Click += new System.EventHandler(this.bntVerificaC_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 262);
            this.Controls.Add(this.bntVerificaC);
            this.Controls.Add(this.btnVerificaL);
            this.Controls.Add(this.txtCaracUsa);
            this.Controls.Add(this.txtLetraUsa);
            this.Controls.Add(this.lblStatusC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStatusL);
            this.Controls.Add(this.lblLetra);
            this.Name = "Form3";
            this.Text = "Decisão - string";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLetra;
        private System.Windows.Forms.Label lblStatusL;
        private System.Windows.Forms.Label lblStatusC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLetraUsa;
        private System.Windows.Forms.TextBox txtCaracUsa;
        private System.Windows.Forms.Button btnVerificaL;
        private System.Windows.Forms.Button bntVerificaC;
    }
}