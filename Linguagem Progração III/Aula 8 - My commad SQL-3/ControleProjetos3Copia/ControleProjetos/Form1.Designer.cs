namespace ControleProjetos
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
            this.bntCadastro = new System.Windows.Forms.Button();
            this.btnCadContato = new System.Windows.Forms.Button();
            this.btnCadControle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntCadastro
            // 
            this.bntCadastro.Location = new System.Drawing.Point(27, 26);
            this.bntCadastro.Name = "bntCadastro";
            this.bntCadastro.Size = new System.Drawing.Size(134, 23);
            this.bntCadastro.TabIndex = 0;
            this.bntCadastro.Text = "Cadastro de empresa";
            this.bntCadastro.UseVisualStyleBackColor = true;
            this.bntCadastro.Click += new System.EventHandler(this.bntCadastro_Click);
            // 
            // btnCadContato
            // 
            this.btnCadContato.Location = new System.Drawing.Point(27, 65);
            this.btnCadContato.Name = "btnCadContato";
            this.btnCadContato.Size = new System.Drawing.Size(134, 23);
            this.btnCadContato.TabIndex = 1;
            this.btnCadContato.Text = "Cadastro  de Contato";
            this.btnCadContato.UseVisualStyleBackColor = true;
            this.btnCadContato.Click += new System.EventHandler(this.btnCadContato_Click);
            // 
            // btnCadControle
            // 
            this.btnCadControle.Location = new System.Drawing.Point(27, 105);
            this.btnCadControle.Name = "btnCadControle";
            this.btnCadControle.Size = new System.Drawing.Size(134, 23);
            this.btnCadControle.TabIndex = 2;
            this.btnCadControle.Text = "Cadastro de Controle";
            this.btnCadControle.UseVisualStyleBackColor = true;
            this.btnCadControle.Click += new System.EventHandler(this.btnCadControle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(210, 154);
            this.Controls.Add(this.btnCadControle);
            this.Controls.Add(this.btnCadContato);
            this.Controls.Add(this.bntCadastro);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntCadastro;
        private System.Windows.Forms.Button btnCadContato;
        private System.Windows.Forms.Button btnCadControle;
    }
}

