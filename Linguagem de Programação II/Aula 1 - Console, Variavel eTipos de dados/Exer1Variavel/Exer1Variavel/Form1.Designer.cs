namespace WindowsFormsApplication1
{
    partial class frmInclusao
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
            this.lblMens = new System.Windows.Forms.Label();
            this.bntMostrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMens
            // 
            this.lblMens.AutoSize = true;
            this.lblMens.Location = new System.Drawing.Point(35, 144);
            this.lblMens.Name = "lblMens";
            this.lblMens.Size = new System.Drawing.Size(0, 13);
            this.lblMens.TabIndex = 0;
            // 
            // bntMostrar
            // 
            this.bntMostrar.Location = new System.Drawing.Point(83, 28);
            this.bntMostrar.Name = "bntMostrar";
            this.bntMostrar.Size = new System.Drawing.Size(89, 71);
            this.bntMostrar.TabIndex = 1;
            this.bntMostrar.Text = "Mostrar";
            this.bntMostrar.UseVisualStyleBackColor = true;
            this.bntMostrar.Click += new System.EventHandler(this.bntMostrar_Click);
            // 
            // frmInclusao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bntMostrar);
            this.Controls.Add(this.lblMens);
            this.Name = "frmInclusao";
            this.Text = "Inclusão de curso";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMens;
        private System.Windows.Forms.Button bntMostrar;
    }
}

