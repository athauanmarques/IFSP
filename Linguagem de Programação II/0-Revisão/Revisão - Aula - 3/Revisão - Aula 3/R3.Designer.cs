namespace Revisão___Aula_3
{
    partial class R3
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblStatus1 = new System.Windows.Forms.Label();
            this.lblStatus2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMens1 = new System.Windows.Forms.TextBox();
            this.txtMens2 = new System.Windows.Forms.TextBox();
            this.bntVerf2 = new System.Windows.Forms.Button();
            this.bntVer1 = new System.Windows.Forms.Button();
            this.lblTam = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite uma mensagem;";
            // 
            // lblStatus1
            // 
            this.lblStatus1.AutoSize = true;
            this.lblStatus1.Location = new System.Drawing.Point(23, 90);
            this.lblStatus1.Name = "lblStatus1";
            this.lblStatus1.Size = new System.Drawing.Size(40, 13);
            this.lblStatus1.TabIndex = 1;
            this.lblStatus1.Text = "Status:";
            // 
            // lblStatus2
            // 
            this.lblStatus2.AutoSize = true;
            this.lblStatus2.Location = new System.Drawing.Point(23, 228);
            this.lblStatus2.Name = "lblStatus2";
            this.lblStatus2.Size = new System.Drawing.Size(40, 13);
            this.lblStatus2.TabIndex = 3;
            this.lblStatus2.Text = "Status:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Digite uma mensagem;";
            // 
            // txtMens1
            // 
            this.txtMens1.Location = new System.Drawing.Point(154, 39);
            this.txtMens1.Name = "txtMens1";
            this.txtMens1.Size = new System.Drawing.Size(212, 20);
            this.txtMens1.TabIndex = 4;
            // 
            // txtMens2
            // 
            this.txtMens2.Location = new System.Drawing.Point(154, 171);
            this.txtMens2.Name = "txtMens2";
            this.txtMens2.Size = new System.Drawing.Size(212, 20);
            this.txtMens2.TabIndex = 5;
            // 
            // bntVerf2
            // 
            this.bntVerf2.Location = new System.Drawing.Point(395, 166);
            this.bntVerf2.Name = "bntVerf2";
            this.bntVerf2.Size = new System.Drawing.Size(104, 33);
            this.bntVerf2.TabIndex = 7;
            this.bntVerf2.Text = "Verificar";
            this.bntVerf2.UseVisualStyleBackColor = true;
            this.bntVerf2.Click += new System.EventHandler(this.bntVerf2_Click);
            // 
            // bntVer1
            // 
            this.bntVer1.Location = new System.Drawing.Point(395, 32);
            this.bntVer1.Name = "bntVer1";
            this.bntVer1.Size = new System.Drawing.Size(104, 33);
            this.bntVer1.TabIndex = 8;
            this.bntVer1.Text = "Verificar";
            this.bntVer1.UseVisualStyleBackColor = true;
            this.bntVer1.Click += new System.EventHandler(this.bntVer1_Click);
            // 
            // lblTam
            // 
            this.lblTam.AutoSize = true;
            this.lblTam.Location = new System.Drawing.Point(211, 138);
            this.lblTam.Name = "lblTam";
            this.lblTam.Size = new System.Drawing.Size(0, 13);
            this.lblTam.TabIndex = 9;
            // 
            // R3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 261);
            this.Controls.Add(this.lblTam);
            this.Controls.Add(this.bntVer1);
            this.Controls.Add(this.bntVerf2);
            this.Controls.Add(this.txtMens2);
            this.Controls.Add(this.txtMens1);
            this.Controls.Add(this.lblStatus2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblStatus1);
            this.Controls.Add(this.label1);
            this.Name = "R3";
            this.Text = "String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStatus1;
        private System.Windows.Forms.Label lblStatus2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMens1;
        private System.Windows.Forms.TextBox txtMens2;
        private System.Windows.Forms.Button bntVerf2;
        private System.Windows.Forms.Button bntVer1;
        private System.Windows.Forms.Label lblTam;
    }
}