namespace Aula_Revisão
{
    partial class inicial
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
            this.bntExe1 = new System.Windows.Forms.Button();
            this.bntExer2 = new System.Windows.Forms.Button();
            this.bntExer3 = new System.Windows.Forms.Button();
            this.bntFim = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntExe1
            // 
            this.bntExe1.Location = new System.Drawing.Point(28, 81);
            this.bntExe1.Name = "bntExe1";
            this.bntExe1.Size = new System.Drawing.Size(75, 23);
            this.bntExe1.TabIndex = 0;
            this.bntExe1.Text = "Exercício 1";
            this.bntExe1.UseVisualStyleBackColor = true;
            this.bntExe1.Click += new System.EventHandler(this.bntExe1_Click);
            // 
            // bntExer2
            // 
            this.bntExer2.Location = new System.Drawing.Point(91, 110);
            this.bntExer2.Name = "bntExer2";
            this.bntExer2.Size = new System.Drawing.Size(75, 23);
            this.bntExer2.TabIndex = 1;
            this.bntExer2.Text = "Exercício 2";
            this.bntExer2.UseVisualStyleBackColor = true;
            this.bntExer2.Click += new System.EventHandler(this.bntExer2_Click);
            // 
            // bntExer3
            // 
            this.bntExer3.Location = new System.Drawing.Point(157, 139);
            this.bntExer3.Name = "bntExer3";
            this.bntExer3.Size = new System.Drawing.Size(75, 23);
            this.bntExer3.TabIndex = 2;
            this.bntExer3.Text = "Exercício 3";
            this.bntExer3.UseVisualStyleBackColor = true;
            this.bntExer3.Click += new System.EventHandler(this.bntExer3_Click);
            // 
            // bntFim
            // 
            this.bntFim.Location = new System.Drawing.Point(56, 203);
            this.bntFim.Name = "bntFim";
            this.bntFim.Size = new System.Drawing.Size(141, 23);
            this.bntFim.TabIndex = 3;
            this.bntFim.Text = "Fim";
            this.bntFim.UseVisualStyleBackColor = true;
            this.bntFim.Click += new System.EventHandler(this.bntFim_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Wide Latin", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "Exercicios de Fixação:";
            // 
            // inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(270, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bntFim);
            this.Controls.Add(this.bntExer3);
            this.Controls.Add(this.bntExer2);
            this.Controls.Add(this.bntExe1);
            this.Name = "inicial";
            this.Text = "inicial";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntExe1;
        private System.Windows.Forms.Button bntExer2;
        private System.Windows.Forms.Button bntExer3;
        private System.Windows.Forms.Button bntFim;
        private System.Windows.Forms.Label label1;
    }
}