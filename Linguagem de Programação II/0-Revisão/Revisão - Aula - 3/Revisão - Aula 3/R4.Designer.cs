namespace Revisão___Aula_3
{
    partial class R4
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
            this.txtLetra = new System.Windows.Forms.TextBox();
            this.bntMaius = new System.Windows.Forms.Button();
            this.bntMini = new System.Windows.Forms.Button();
            this.bntContar = new System.Windows.Forms.Button();
            this.bntReplace = new System.Windows.Forms.Button();
            this.bntSub = new System.Windows.Forms.Button();
            this.lblMaiuscula = new System.Windows.Forms.Label();
            this.lblMinuscula = new System.Windows.Forms.Label();
            this.lblQuant = new System.Windows.Forms.Label();
            this.lblReplace = new System.Windows.Forms.Label();
            this.lblSub = new System.Windows.Forms.Label();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtLetra
            // 
            this.txtLetra.Location = new System.Drawing.Point(70, 39);
            this.txtLetra.Name = "txtLetra";
            this.txtLetra.Size = new System.Drawing.Size(252, 20);
            this.txtLetra.TabIndex = 0;
            // 
            // bntMaius
            // 
            this.bntMaius.Location = new System.Drawing.Point(70, 78);
            this.bntMaius.Name = "bntMaius";
            this.bntMaius.Size = new System.Drawing.Size(75, 23);
            this.bntMaius.TabIndex = 1;
            this.bntMaius.Text = "Maiuscula";
            this.bntMaius.UseVisualStyleBackColor = true;
            this.bntMaius.Click += new System.EventHandler(this.bntMaius_Click);
            // 
            // bntMini
            // 
            this.bntMini.Location = new System.Drawing.Point(70, 118);
            this.bntMini.Name = "bntMini";
            this.bntMini.Size = new System.Drawing.Size(75, 23);
            this.bntMini.TabIndex = 2;
            this.bntMini.Text = "Minuscula";
            this.bntMini.UseVisualStyleBackColor = true;
            this.bntMini.Click += new System.EventHandler(this.bntMini_Click);
            // 
            // bntContar
            // 
            this.bntContar.Location = new System.Drawing.Point(70, 164);
            this.bntContar.Name = "bntContar";
            this.bntContar.Size = new System.Drawing.Size(75, 23);
            this.bntContar.TabIndex = 4;
            this.bntContar.Text = "Quantidade";
            this.bntContar.UseVisualStyleBackColor = true;
            this.bntContar.Click += new System.EventHandler(this.bntContar_Click);
            // 
            // bntReplace
            // 
            this.bntReplace.Location = new System.Drawing.Point(70, 204);
            this.bntReplace.Name = "bntReplace";
            this.bntReplace.Size = new System.Drawing.Size(75, 23);
            this.bntReplace.TabIndex = 3;
            this.bntReplace.Text = "Replace";
            this.bntReplace.UseVisualStyleBackColor = true;
            this.bntReplace.Click += new System.EventHandler(this.bntReplace_Click);
            // 
            // bntSub
            // 
            this.bntSub.Location = new System.Drawing.Point(70, 248);
            this.bntSub.Name = "bntSub";
            this.bntSub.Size = new System.Drawing.Size(75, 23);
            this.bntSub.TabIndex = 5;
            this.bntSub.Text = "Substring";
            this.bntSub.UseVisualStyleBackColor = true;
            this.bntSub.Click += new System.EventHandler(this.bntSub_Click);
            // 
            // lblMaiuscula
            // 
            this.lblMaiuscula.AutoSize = true;
            this.lblMaiuscula.Location = new System.Drawing.Point(183, 83);
            this.lblMaiuscula.Name = "lblMaiuscula";
            this.lblMaiuscula.Size = new System.Drawing.Size(0, 13);
            this.lblMaiuscula.TabIndex = 6;
            // 
            // lblMinuscula
            // 
            this.lblMinuscula.AutoSize = true;
            this.lblMinuscula.Location = new System.Drawing.Point(183, 123);
            this.lblMinuscula.Name = "lblMinuscula";
            this.lblMinuscula.Size = new System.Drawing.Size(0, 13);
            this.lblMinuscula.TabIndex = 7;
            // 
            // lblQuant
            // 
            this.lblQuant.AutoSize = true;
            this.lblQuant.Location = new System.Drawing.Point(183, 164);
            this.lblQuant.Name = "lblQuant";
            this.lblQuant.Size = new System.Drawing.Size(0, 13);
            this.lblQuant.TabIndex = 9;
            // 
            // lblReplace
            // 
            this.lblReplace.AutoSize = true;
            this.lblReplace.Location = new System.Drawing.Point(183, 209);
            this.lblReplace.Name = "lblReplace";
            this.lblReplace.Size = new System.Drawing.Size(0, 13);
            this.lblReplace.TabIndex = 8;
            // 
            // lblSub
            // 
            this.lblSub.AutoSize = true;
            this.lblSub.Location = new System.Drawing.Point(183, 253);
            this.lblSub.Name = "lblSub";
            this.lblSub.Size = new System.Drawing.Size(0, 13);
            this.lblSub.TabIndex = 10;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(340, 247);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 11;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 294);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.lblSub);
            this.Controls.Add(this.lblQuant);
            this.Controls.Add(this.lblReplace);
            this.Controls.Add(this.lblMinuscula);
            this.Controls.Add(this.lblMaiuscula);
            this.Controls.Add(this.bntSub);
            this.Controls.Add(this.bntContar);
            this.Controls.Add(this.bntReplace);
            this.Controls.Add(this.bntMini);
            this.Controls.Add(this.bntMaius);
            this.Controls.Add(this.txtLetra);
            this.Name = "Form4";
            this.Text = "String 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLetra;
        private System.Windows.Forms.Button bntMaius;
        private System.Windows.Forms.Button bntMini;
        private System.Windows.Forms.Button bntContar;
        private System.Windows.Forms.Button bntReplace;
        private System.Windows.Forms.Button bntSub;
        private System.Windows.Forms.Label lblMaiuscula;
        private System.Windows.Forms.Label lblMinuscula;
        private System.Windows.Forms.Label lblQuant;
        private System.Windows.Forms.Label lblReplace;
        private System.Windows.Forms.Label lblSub;
        private System.Windows.Forms.Button bntSair;
    }
}