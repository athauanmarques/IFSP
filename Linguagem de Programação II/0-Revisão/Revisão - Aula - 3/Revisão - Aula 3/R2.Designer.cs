namespace Revisão___Aula_3
{
    partial class R2
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
            this.txtSite = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDomi = new System.Windows.Forms.Label();
            this.lblstatus = new System.Windows.Forms.Label();
            this.bntResult = new System.Windows.Forms.Button();
            this.lblTamanho = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(71, 58);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(124, 20);
            this.txtSite.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Informe o teu E-mail:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(30, 150);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome:";
            // 
            // lblDomi
            // 
            this.lblDomi.AutoSize = true;
            this.lblDomi.Location = new System.Drawing.Point(30, 183);
            this.lblDomi.Name = "lblDomi";
            this.lblDomi.Size = new System.Drawing.Size(45, 13);
            this.lblDomi.TabIndex = 3;
            this.lblDomi.Text = "Dominio";
            // 
            // lblstatus
            // 
            this.lblstatus.AutoSize = true;
            this.lblstatus.Location = new System.Drawing.Point(30, 213);
            this.lblstatus.Name = "lblstatus";
            this.lblstatus.Size = new System.Drawing.Size(40, 13);
            this.lblstatus.TabIndex = 4;
            this.lblstatus.Text = "Status:";
            // 
            // bntResult
            // 
            this.bntResult.Location = new System.Drawing.Point(91, 94);
            this.bntResult.Name = "bntResult";
            this.bntResult.Size = new System.Drawing.Size(75, 23);
            this.bntResult.TabIndex = 5;
            this.bntResult.Text = "Resultado";
            this.bntResult.UseVisualStyleBackColor = true;
            this.bntResult.Click += new System.EventHandler(this.bntResult_Click);
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(215, 65);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(0, 13);
            this.lblTamanho.TabIndex = 6;
            // 
            // R2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblTamanho);
            this.Controls.Add(this.bntResult);
            this.Controls.Add(this.lblstatus);
            this.Controls.Add(this.lblDomi);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSite);
            this.Name = "R2";
            this.Text = "Seu Site";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDomi;
        private System.Windows.Forms.Label lblstatus;
        private System.Windows.Forms.Button bntResult;
        private System.Windows.Forms.Label lblTamanho;
    }
}