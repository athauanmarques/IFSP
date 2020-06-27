namespace ExemploCamadas
{
    partial class Conexao
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
            this.btnConecta = new System.Windows.Forms.Button();
            this.btnDesconecta = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnConecta
            // 
            this.btnConecta.Location = new System.Drawing.Point(16, 23);
            this.btnConecta.Name = "btnConecta";
            this.btnConecta.Size = new System.Drawing.Size(75, 23);
            this.btnConecta.TabIndex = 0;
            this.btnConecta.Text = "Conectar";
            this.btnConecta.UseVisualStyleBackColor = true;
            this.btnConecta.Click += new System.EventHandler(this.btnConecta_Click);
            // 
            // btnDesconecta
            // 
            this.btnDesconecta.Location = new System.Drawing.Point(130, 23);
            this.btnDesconecta.Name = "btnDesconecta";
            this.btnDesconecta.Size = new System.Drawing.Size(75, 23);
            this.btnDesconecta.TabIndex = 1;
            this.btnDesconecta.Text = "Desconectar";
            this.btnDesconecta.UseVisualStyleBackColor = true;
            this.btnDesconecta.Click += new System.EventHandler(this.btnDesconecta_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(23, 71);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(43, 13);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "Status: ";
            // 
            // Conexao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 105);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.btnDesconecta);
            this.Controls.Add(this.btnConecta);
            this.Name = "Conexao";
            this.Text = "Conexao";
            this.Load += new System.EventHandler(this.Conexao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConecta;
        private System.Windows.Forms.Button btnDesconecta;
        private System.Windows.Forms.Label lblStatus;
    }
}