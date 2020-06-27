namespace Revisão1
{
    partial class Form2
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
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtSite = new System.Windows.Forms.TextBox();
            this.lblCurso = new System.Windows.Forms.Label();
            this.lblSite = new System.Windows.Forms.Label();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lblCursoMostra = new System.Windows.Forms.Label();
            this.lblSiteMostrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(79, 44);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(118, 20);
            this.txtCurso.TabIndex = 0;
            // 
            // txtSite
            // 
            this.txtSite.Location = new System.Drawing.Point(79, 84);
            this.txtSite.Name = "txtSite";
            this.txtSite.Size = new System.Drawing.Size(115, 20);
            this.txtSite.TabIndex = 1;
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Location = new System.Drawing.Point(76, 28);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(34, 13);
            this.lblCurso.TabIndex = 2;
            this.lblCurso.Text = "Cruso";
            // 
            // lblSite
            // 
            this.lblSite.AutoSize = true;
            this.lblSite.Location = new System.Drawing.Point(76, 67);
            this.lblSite.Name = "lblSite";
            this.lblSite.Size = new System.Drawing.Size(25, 13);
            this.lblSite.TabIndex = 3;
            this.lblSite.Text = "Site";
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(66, 110);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(144, 27);
            this.btnMostrar.TabIndex = 4;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // lblCursoMostra
            // 
            this.lblCursoMostra.AutoSize = true;
            this.lblCursoMostra.Location = new System.Drawing.Point(25, 186);
            this.lblCursoMostra.Name = "lblCursoMostra";
            this.lblCursoMostra.Size = new System.Drawing.Size(40, 13);
            this.lblCursoMostra.TabIndex = 5;
            this.lblCursoMostra.Text = "Curso: ";
            // 
            // lblSiteMostrar
            // 
            this.lblSiteMostrar.AutoSize = true;
            this.lblSiteMostrar.Location = new System.Drawing.Point(25, 220);
            this.lblSiteMostrar.Name = "lblSiteMostrar";
            this.lblSiteMostrar.Size = new System.Drawing.Size(31, 13);
            this.lblSiteMostrar.TabIndex = 6;
            this.lblSiteMostrar.Text = "Site: ";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblSiteMostrar);
            this.Controls.Add(this.lblCursoMostra);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.lblSite);
            this.Controls.Add(this.lblCurso);
            this.Controls.Add(this.txtSite);
            this.Controls.Add(this.txtCurso);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtSite;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Label lblSite;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lblCursoMostra;
        private System.Windows.Forms.Label lblSiteMostrar;
    }
}