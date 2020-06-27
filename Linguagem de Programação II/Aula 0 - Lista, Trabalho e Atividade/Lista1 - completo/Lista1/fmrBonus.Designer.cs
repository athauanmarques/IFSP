namespace Lista1
{
    partial class fmrBonus
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
            this.bntBonus = new System.Windows.Forms.Button();
            this.txtServiço = new System.Windows.Forms.TextBox();
            this.txtFilho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bntBonus
            // 
            this.bntBonus.Location = new System.Drawing.Point(197, 47);
            this.bntBonus.Name = "bntBonus";
            this.bntBonus.Size = new System.Drawing.Size(75, 41);
            this.bntBonus.TabIndex = 0;
            this.bntBonus.Text = "Calclular bonus";
            this.bntBonus.UseVisualStyleBackColor = true;
            this.bntBonus.Click += new System.EventHandler(this.bntBonus_Click);
            // 
            // txtServiço
            // 
            this.txtServiço.Location = new System.Drawing.Point(112, 31);
            this.txtServiço.Name = "txtServiço";
            this.txtServiço.Size = new System.Drawing.Size(55, 20);
            this.txtServiço.TabIndex = 1;
            // 
            // txtFilho
            // 
            this.txtFilho.Location = new System.Drawing.Point(112, 72);
            this.txtFilho.Name = "txtFilho";
            this.txtFilho.Size = new System.Drawing.Size(55, 20);
            this.txtFilho.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Anos de serviço:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nª de filho:";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(109, 150);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(55, 13);
            this.lblResult.TabIndex = 5;
            this.lblResult.Text = "Resultado";
            // 
            // fmrBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFilho);
            this.Controls.Add(this.txtServiço);
            this.Controls.Add(this.bntBonus);
            this.Name = "fmrBonus";
            this.Text = "fmrBonus";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntBonus;
        private System.Windows.Forms.TextBox txtServiço;
        private System.Windows.Forms.TextBox txtFilho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResult;
    }
}