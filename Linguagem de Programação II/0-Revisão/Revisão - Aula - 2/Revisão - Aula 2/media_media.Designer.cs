namespace Revisão___Aula_2
{
    partial class media_media
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
            this.txtV1 = new System.Windows.Forms.TextBox();
            this.txtV2 = new System.Windows.Forms.TextBox();
            this.txtV3 = new System.Windows.Forms.TextBox();
            this.txtV4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbResultado = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bntM1 = new System.Windows.Forms.Button();
            this.bntM2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtV1
            // 
            this.txtV1.Location = new System.Drawing.Point(93, 30);
            this.txtV1.Name = "txtV1";
            this.txtV1.Size = new System.Drawing.Size(52, 20);
            this.txtV1.TabIndex = 0;
            // 
            // txtV2
            // 
            this.txtV2.Location = new System.Drawing.Point(93, 56);
            this.txtV2.Name = "txtV2";
            this.txtV2.Size = new System.Drawing.Size(52, 20);
            this.txtV2.TabIndex = 1;
            // 
            // txtV3
            // 
            this.txtV3.Location = new System.Drawing.Point(93, 82);
            this.txtV3.Name = "txtV3";
            this.txtV3.Size = new System.Drawing.Size(52, 20);
            this.txtV3.TabIndex = 2;
            // 
            // txtV4
            // 
            this.txtV4.Location = new System.Drawing.Point(93, 108);
            this.txtV4.Name = "txtV4";
            this.txtV4.Size = new System.Drawing.Size(52, 20);
            this.txtV4.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Valor1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Valor2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor3:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Valor4:";
            // 
            // rtbResultado
            // 
            this.rtbResultado.Location = new System.Drawing.Point(93, 152);
            this.rtbResultado.Name = "rtbResultado";
            this.rtbResultado.ReadOnly = true;
            this.rtbResultado.Size = new System.Drawing.Size(114, 22);
            this.rtbResultado.TabIndex = 8;
            this.rtbResultado.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Resultado:";
            // 
            // bntM1
            // 
            this.bntM1.Location = new System.Drawing.Point(202, 45);
            this.bntM1.Name = "bntM1";
            this.bntM1.Size = new System.Drawing.Size(55, 32);
            this.bntM1.TabIndex = 10;
            this.bntM1.Text = "Media1";
            this.bntM1.UseVisualStyleBackColor = true;
            this.bntM1.Click += new System.EventHandler(this.bntM1_Click);
            // 
            // bntM2
            // 
            this.bntM2.Location = new System.Drawing.Point(202, 89);
            this.bntM2.Name = "bntM2";
            this.bntM2.Size = new System.Drawing.Size(55, 32);
            this.bntM2.TabIndex = 11;
            this.bntM2.Text = "Media2";
            this.bntM2.UseVisualStyleBackColor = true;
            this.bntM2.Click += new System.EventHandler(this.bntM2_Click);
            // 
            // media_media
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bntM2);
            this.Controls.Add(this.bntM1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rtbResultado);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtV4);
            this.Controls.Add(this.txtV3);
            this.Controls.Add(this.txtV2);
            this.Controls.Add(this.txtV1);
            this.Name = "media_media";
            this.Text = "media_media";
            this.Load += new System.EventHandler(this.media_media_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtV1;
        private System.Windows.Forms.TextBox txtV2;
        private System.Windows.Forms.TextBox txtV3;
        private System.Windows.Forms.TextBox txtV4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbResultado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bntM1;
        private System.Windows.Forms.Button bntM2;
    }
}