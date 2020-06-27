namespace exer_goto
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.ccbAlterar = new System.Windows.Forms.CheckBox();
            this.ccbConsultar = new System.Windows.Forms.CheckBox();
            this.ccbIncluir = new System.Windows.Forms.CheckBox();
            this.ccbExcluir = new System.Windows.Forms.CheckBox();
            this.rdbFemenino = new System.Windows.Forms.RadioButton();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.bntIncluir = new System.Windows.Forms.Button();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ptbMulher = new System.Windows.Forms.PictureBox();
            this.ptbHomem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbMulher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHomem)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 85);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(289, 20);
            this.txtNome.TabIndex = 0;
            // 
            // ccbAlterar
            // 
            this.ccbAlterar.AutoSize = true;
            this.ccbAlterar.Location = new System.Drawing.Point(64, 139);
            this.ccbAlterar.Name = "ccbAlterar";
            this.ccbAlterar.Size = new System.Drawing.Size(56, 17);
            this.ccbAlterar.TabIndex = 1;
            this.ccbAlterar.Text = "Alterar";
            this.ccbAlterar.UseVisualStyleBackColor = true;
            // 
            // ccbConsultar
            // 
            this.ccbConsultar.AutoSize = true;
            this.ccbConsultar.Location = new System.Drawing.Point(64, 163);
            this.ccbConsultar.Name = "ccbConsultar";
            this.ccbConsultar.Size = new System.Drawing.Size(70, 17);
            this.ccbConsultar.TabIndex = 2;
            this.ccbConsultar.Text = "Consultar";
            this.ccbConsultar.UseVisualStyleBackColor = true;
            // 
            // ccbIncluir
            // 
            this.ccbIncluir.AutoSize = true;
            this.ccbIncluir.Location = new System.Drawing.Point(64, 210);
            this.ccbIncluir.Name = "ccbIncluir";
            this.ccbIncluir.Size = new System.Drawing.Size(54, 17);
            this.ccbIncluir.TabIndex = 4;
            this.ccbIncluir.Text = "Incluir";
            this.ccbIncluir.UseVisualStyleBackColor = true;
            // 
            // ccbExcluir
            // 
            this.ccbExcluir.AutoSize = true;
            this.ccbExcluir.Location = new System.Drawing.Point(64, 186);
            this.ccbExcluir.Name = "ccbExcluir";
            this.ccbExcluir.Size = new System.Drawing.Size(57, 17);
            this.ccbExcluir.TabIndex = 3;
            this.ccbExcluir.Text = "Excluir";
            this.ccbExcluir.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            this.rdbFemenino.AutoSize = true;
            this.rdbFemenino.Location = new System.Drawing.Point(268, 163);
            this.rdbFemenino.Name = "rdbFemenino";
            this.rdbFemenino.Size = new System.Drawing.Size(67, 17);
            this.rdbFemenino.TabIndex = 5;
            this.rdbFemenino.TabStop = true;
            this.rdbFemenino.Text = "Feminino";
            this.rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(268, 187);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 6;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // bntIncluir
            // 
            this.bntIncluir.Location = new System.Drawing.Point(164, 252);
            this.bntIncluir.Name = "bntIncluir";
            this.bntIncluir.Size = new System.Drawing.Size(75, 23);
            this.bntIncluir.TabIndex = 7;
            this.bntIncluir.Text = "Incluir";
            this.bntIncluir.UseVisualStyleBackColor = true;
            this.bntIncluir.Click += new System.EventHandler(this.bntIncluir_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(26, 379);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 9;
            this.lblStatus.Text = "Status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nome do usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(136, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Incluir Novo Usuário";
            // 
            // ptbMulher
            // 
            this.ptbMulher.Image = ((System.Drawing.Image)(resources.GetObject("ptbMulher.Image")));
            this.ptbMulher.Location = new System.Drawing.Point(164, 281);
            this.ptbMulher.Name = "ptbMulher";
            this.ptbMulher.Size = new System.Drawing.Size(86, 67);
            this.ptbMulher.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbMulher.TabIndex = 12;
            this.ptbMulher.TabStop = false;
            // 
            // ptbHomem
            // 
            this.ptbHomem.Image = ((System.Drawing.Image)(resources.GetObject("ptbHomem.Image")));
            this.ptbHomem.Location = new System.Drawing.Point(164, 281);
            this.ptbHomem.Name = "ptbHomem";
            this.ptbHomem.Size = new System.Drawing.Size(86, 73);
            this.ptbHomem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbHomem.TabIndex = 13;
            this.ptbHomem.TabStop = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 531);
            this.Controls.Add(this.ptbHomem);
            this.Controls.Add(this.ptbMulher);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.bntIncluir);
            this.Controls.Add(this.rdbMasculino);
            this.Controls.Add(this.rdbFemenino);
            this.Controls.Add(this.ccbIncluir);
            this.Controls.Add(this.ccbExcluir);
            this.Controls.Add(this.ccbConsultar);
            this.Controls.Add(this.ccbAlterar);
            this.Controls.Add(this.txtNome);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbMulher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbHomem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.CheckBox ccbAlterar;
        private System.Windows.Forms.CheckBox ccbConsultar;
        private System.Windows.Forms.CheckBox ccbIncluir;
        private System.Windows.Forms.CheckBox ccbExcluir;
        private System.Windows.Forms.RadioButton rdbFemenino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.Button bntIncluir;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox ptbMulher;
        private System.Windows.Forms.PictureBox ptbHomem;
    }
}