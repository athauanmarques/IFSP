namespace WindowsFormsApplication1
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
            this.txtPri = new System.Windows.Forms.TextBox();
            this.txtQua = new System.Windows.Forms.TextBox();
            this.txtTer = new System.Windows.Forms.TextBox();
            this.txtSeg = new System.Windows.Forms.TextBox();
            this.btnMostra = new System.Windows.Forms.Button();
            this.lblPrimeiro = new System.Windows.Forms.Label();
            this.lblquarto = new System.Windows.Forms.Label();
            this.lblTerceiro = new System.Windows.Forms.Label();
            this.lblSegundo = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtPri
            // 
            this.txtPri.Location = new System.Drawing.Point(124, 46);
            this.txtPri.Name = "txtPri";
            this.txtPri.Size = new System.Drawing.Size(64, 20);
            this.txtPri.TabIndex = 0;
            // 
            // txtQua
            // 
            this.txtQua.Location = new System.Drawing.Point(124, 124);
            this.txtQua.Name = "txtQua";
            this.txtQua.Size = new System.Drawing.Size(64, 20);
            this.txtQua.TabIndex = 1;
            // 
            // txtTer
            // 
            this.txtTer.Location = new System.Drawing.Point(124, 98);
            this.txtTer.Name = "txtTer";
            this.txtTer.Size = new System.Drawing.Size(64, 20);
            this.txtTer.TabIndex = 2;
            // 
            // txtSeg
            // 
            this.txtSeg.Location = new System.Drawing.Point(124, 72);
            this.txtSeg.Name = "txtSeg";
            this.txtSeg.Size = new System.Drawing.Size(64, 20);
            this.txtSeg.TabIndex = 3;
            // 
            // btnMostra
            // 
            this.btnMostra.Location = new System.Drawing.Point(72, 150);
            this.btnMostra.Name = "btnMostra";
            this.btnMostra.Size = new System.Drawing.Size(116, 23);
            this.btnMostra.TabIndex = 4;
            this.btnMostra.Text = "button1";
            this.btnMostra.UseVisualStyleBackColor = true;
            this.btnMostra.Click += new System.EventHandler(this.btnMostra_Click);
            // 
            // lblPrimeiro
            // 
            this.lblPrimeiro.AutoSize = true;
            this.lblPrimeiro.Location = new System.Drawing.Point(25, 49);
            this.lblPrimeiro.Name = "lblPrimeiro";
            this.lblPrimeiro.Size = new System.Drawing.Size(93, 13);
            this.lblPrimeiro.TabIndex = 5;
            this.lblPrimeiro.Text = "Primeiro Bimestre: ";
            // 
            // lblquarto
            // 
            this.lblquarto.AutoSize = true;
            this.lblquarto.Location = new System.Drawing.Point(30, 127);
            this.lblquarto.Name = "lblquarto";
            this.lblquarto.Size = new System.Drawing.Size(88, 13);
            this.lblquarto.TabIndex = 6;
            this.lblquarto.Text = "Quarto Bimestre: ";
            // 
            // lblTerceiro
            // 
            this.lblTerceiro.AutoSize = true;
            this.lblTerceiro.Location = new System.Drawing.Point(23, 105);
            this.lblTerceiro.Name = "lblTerceiro";
            this.lblTerceiro.Size = new System.Drawing.Size(95, 13);
            this.lblTerceiro.TabIndex = 7;
            this.lblTerceiro.Text = "Terceiro Bimestre: ";
            // 
            // lblSegundo
            // 
            this.lblSegundo.AutoSize = true;
            this.lblSegundo.Location = new System.Drawing.Point(19, 75);
            this.lblSegundo.Name = "lblSegundo";
            this.lblSegundo.Size = new System.Drawing.Size(99, 13);
            this.lblSegundo.TabIndex = 8;
            this.lblSegundo.Text = "Segundo Bimestre: ";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(69, 197);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 9;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblSegundo);
            this.Controls.Add(this.lblTerceiro);
            this.Controls.Add(this.lblquarto);
            this.Controls.Add(this.lblPrimeiro);
            this.Controls.Add(this.btnMostra);
            this.Controls.Add(this.txtSeg);
            this.Controls.Add(this.txtTer);
            this.Controls.Add(this.txtQua);
            this.Controls.Add(this.txtPri);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPri;
        private System.Windows.Forms.TextBox txtQua;
        private System.Windows.Forms.TextBox txtTer;
        private System.Windows.Forms.TextBox txtSeg;
        private System.Windows.Forms.Button btnMostra;
        private System.Windows.Forms.Label lblPrimeiro;
        private System.Windows.Forms.Label lblquarto;
        private System.Windows.Forms.Label lblTerceiro;
        private System.Windows.Forms.Label lblSegundo;
        private System.Windows.Forms.Label lblResultado;
    }
}