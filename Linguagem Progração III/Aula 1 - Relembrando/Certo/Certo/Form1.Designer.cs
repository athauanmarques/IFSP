namespace Certo
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
            this.rdbBrasil = new System.Windows.Forms.RadioButton();
            this.rdbGringo = new System.Windows.Forms.RadioButton();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.lblRes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbBrasil
            // 
            this.rdbBrasil.AutoSize = true;
            this.rdbBrasil.Location = new System.Drawing.Point(62, 71);
            this.rdbBrasil.Name = "rdbBrasil";
            this.rdbBrasil.Size = new System.Drawing.Size(50, 17);
            this.rdbBrasil.TabIndex = 0;
            this.rdbBrasil.TabStop = true;
            this.rdbBrasil.Text = "Brasil";
            this.rdbBrasil.UseVisualStyleBackColor = true;
            this.rdbBrasil.CheckedChanged += new System.EventHandler(this.rdbBrasil_CheckedChanged);
            // 
            // rdbGringo
            // 
            this.rdbGringo.AutoSize = true;
            this.rdbGringo.Location = new System.Drawing.Point(154, 71);
            this.rdbGringo.Name = "rdbGringo";
            this.rdbGringo.Size = new System.Drawing.Size(56, 17);
            this.rdbGringo.TabIndex = 1;
            this.rdbGringo.TabStop = true;
            this.rdbGringo.Text = "Gringo";
            this.rdbGringo.UseVisualStyleBackColor = true;
            this.rdbGringo.CheckedChanged += new System.EventHandler(this.rdbGringo_CheckedChanged);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(62, 24);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 2;
            // 
            // lblRes
            // 
            this.lblRes.AutoSize = true;
            this.lblRes.Location = new System.Drawing.Point(62, 125);
            this.lblRes.Name = "lblRes";
            this.lblRes.Size = new System.Drawing.Size(55, 13);
            this.lblRes.TabIndex = 3;
            this.lblRes.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 282);
            this.Controls.Add(this.lblRes);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.rdbGringo);
            this.Controls.Add(this.rdbBrasil);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbBrasil;
        private System.Windows.Forms.RadioButton rdbGringo;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Label lblRes;
    }
}

