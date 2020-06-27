namespace Exercicio
{
    partial class verdadeiro
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
            this.rdbGrinco = new System.Windows.Forms.RadioButton();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.bntResultar = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdbBrasil
            // 
            this.rdbBrasil.AutoSize = true;
            this.rdbBrasil.Location = new System.Drawing.Point(41, 122);
            this.rdbBrasil.Name = "rdbBrasil";
            this.rdbBrasil.Size = new System.Drawing.Size(67, 17);
            this.rdbBrasil.TabIndex = 0;
            this.rdbBrasil.TabStop = true;
            this.rdbBrasil.Text = "Brasileira";
            this.rdbBrasil.UseVisualStyleBackColor = true;
            this.rdbBrasil.CheckedChanged += new System.EventHandler(this.rdbBrasil_CheckedChanged);
            // 
            // rdbGrinco
            // 
            this.rdbGrinco.AutoSize = true;
            this.rdbGrinco.Location = new System.Drawing.Point(157, 122);
            this.rdbGrinco.Name = "rdbGrinco";
            this.rdbGrinco.Size = new System.Drawing.Size(56, 17);
            this.rdbGrinco.TabIndex = 1;
            this.rdbGrinco.TabStop = true;
            this.rdbGrinco.Text = "Gringo";
            this.rdbGrinco.UseVisualStyleBackColor = true;
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(41, 59);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(100, 20);
            this.txtIdade.TabIndex = 2;
            // 
            // bntResultar
            // 
            this.bntResultar.Location = new System.Drawing.Point(33, 254);
            this.bntResultar.Name = "bntResultar";
            this.bntResultar.Size = new System.Drawing.Size(75, 23);
            this.bntResultar.TabIndex = 3;
            this.bntResultar.Text = "Resultar";
            this.bntResultar.UseVisualStyleBackColor = true;
            this.bntResultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(38, 171);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resultado";
            // 
            // verdadeiro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 298);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.bntResultar);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.rdbGrinco);
            this.Controls.Add(this.rdbBrasil);
            this.Name = "verdadeiro";
            this.Text = "verdadeiro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbBrasil;
        private System.Windows.Forms.RadioButton rdbGrinco;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.Button bntResultar;
        private System.Windows.Forms.Label lblResultado;
    }
}