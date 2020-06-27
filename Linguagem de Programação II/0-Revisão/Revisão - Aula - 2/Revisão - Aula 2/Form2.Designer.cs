namespace Revisão___Aula_2
{
    partial class media
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
            this.txtPri = new System.Windows.Forms.TextBox();
            this.txtSeg = new System.Windows.Forms.TextBox();
            this.TxtTer = new System.Windows.Forms.TextBox();
            this.txtQua = new System.Windows.Forms.TextBox();
            this.bntCal = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPri
            // 
            this.txtPri.Location = new System.Drawing.Point(124, 36);
            this.txtPri.Name = "txtPri";
            this.txtPri.Size = new System.Drawing.Size(71, 20);
            this.txtPri.TabIndex = 0;
            // 
            // txtSeg
            // 
            this.txtSeg.Location = new System.Drawing.Point(124, 74);
            this.txtSeg.Name = "txtSeg";
            this.txtSeg.Size = new System.Drawing.Size(71, 20);
            this.txtSeg.TabIndex = 1;
            // 
            // TxtTer
            // 
            this.TxtTer.Location = new System.Drawing.Point(124, 109);
            this.TxtTer.Name = "TxtTer";
            this.TxtTer.Size = new System.Drawing.Size(71, 20);
            this.TxtTer.TabIndex = 2;
            // 
            // txtQua
            // 
            this.txtQua.Location = new System.Drawing.Point(124, 145);
            this.txtQua.Name = "txtQua";
            this.txtQua.Size = new System.Drawing.Size(71, 20);
            this.txtQua.TabIndex = 3;
            // 
            // bntCal
            // 
            this.bntCal.Location = new System.Drawing.Point(75, 180);
            this.bntCal.Name = "bntCal";
            this.bntCal.Size = new System.Drawing.Size(119, 29);
            this.bntCal.TabIndex = 4;
            this.bntCal.Text = "Calcular";
            this.bntCal.UseVisualStyleBackColor = true;
            this.bntCal.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(79, 230);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(61, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Resultado: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Primeiro :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Segundo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Terceiro :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 152);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Quarto :";
            // 
            // media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.bntCal);
            this.Controls.Add(this.txtQua);
            this.Controls.Add(this.TxtTer);
            this.Controls.Add(this.txtSeg);
            this.Controls.Add(this.txtPri);
            this.Name = "media";
            this.Text = "Media";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPri;
        private System.Windows.Forms.TextBox txtSeg;
        private System.Windows.Forms.TextBox TxtTer;
        private System.Windows.Forms.TextBox txtQua;
        private System.Windows.Forms.Button bntCal;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}