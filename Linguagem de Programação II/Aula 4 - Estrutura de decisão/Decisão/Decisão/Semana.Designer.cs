﻿namespace Decisão
{
    partial class Semana
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
            this.txtDia = new System.Windows.Forms.TextBox();
            this.bntMostrar = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Informe o dia:";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(98, 48);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(86, 20);
            this.txtDia.TabIndex = 1;
            // 
            // bntMostrar
            // 
            this.bntMostrar.Location = new System.Drawing.Point(191, 48);
            this.bntMostrar.Name = "bntMostrar";
            this.bntMostrar.Size = new System.Drawing.Size(75, 23);
            this.bntMostrar.TabIndex = 2;
            this.bntMostrar.Text = "Mostar";
            this.bntMostrar.UseVisualStyleBackColor = true;
            this.bntMostrar.Click += new System.EventHandler(this.bntMostrar_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(109, 93);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 3;
            this.lblResult.Text = "Resultado";
            // 
            // Semana
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 157);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.bntMostrar);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.label1);
            this.Name = "Semana";
            this.Text = "Semana";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Button bntMostrar;
        private System.Windows.Forms.Label lblResult;
    }
}