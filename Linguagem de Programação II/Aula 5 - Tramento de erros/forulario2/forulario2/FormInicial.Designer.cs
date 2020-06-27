namespace forulario2
{
    partial class FormInicial
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
            this.bntExemplos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bntExemplos
            // 
            this.bntExemplos.Location = new System.Drawing.Point(49, 59);
            this.bntExemplos.Name = "bntExemplos";
            this.bntExemplos.Size = new System.Drawing.Size(154, 23);
            this.bntExemplos.TabIndex = 0;
            this.bntExemplos.Text = "Exemplos Mensagem";
            this.bntExemplos.UseVisualStyleBackColor = true;
            this.bntExemplos.Click += new System.EventHandler(this.bntExemplos_Click);
            // 
            // FormInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.bntExemplos);
            this.Name = "FormInicial";
            this.Text = "FormInicial";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bntExemplos;
    }
}