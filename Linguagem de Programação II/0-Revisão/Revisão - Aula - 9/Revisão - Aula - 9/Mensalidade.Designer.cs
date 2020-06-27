namespace Revisão___Aula___9
{
    partial class Mensalidade
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtGraduacao = new System.Windows.Forms.TextBox();
            this.txtMensalidade = new System.Windows.Forms.TextBox();
            this.rdbMestrado = new System.Windows.Forms.RadioButton();
            this.rdbDoutorado = new System.Windows.Forms.RadioButton();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limparToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mensalidade de Graduação";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mensalidade";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(78, 45);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(185, 20);
            this.txtCurso.TabIndex = 3;
            // 
            // txtGraduacao
            // 
            this.txtGraduacao.Location = new System.Drawing.Point(172, 82);
            this.txtGraduacao.Name = "txtGraduacao";
            this.txtGraduacao.Size = new System.Drawing.Size(91, 20);
            this.txtGraduacao.TabIndex = 4;
            // 
            // txtMensalidade
            // 
            this.txtMensalidade.Location = new System.Drawing.Point(145, 189);
            this.txtMensalidade.Name = "txtMensalidade";
            this.txtMensalidade.Size = new System.Drawing.Size(118, 20);
            this.txtMensalidade.TabIndex = 5;
            // 
            // rdbMestrado
            // 
            this.rdbMestrado.AutoSize = true;
            this.rdbMestrado.Location = new System.Drawing.Point(31, 144);
            this.rdbMestrado.Name = "rdbMestrado";
            this.rdbMestrado.Size = new System.Drawing.Size(69, 17);
            this.rdbMestrado.TabIndex = 6;
            this.rdbMestrado.TabStop = true;
            this.rdbMestrado.Text = "Mestrado";
            this.rdbMestrado.UseVisualStyleBackColor = true;
            // 
            // rdbDoutorado
            // 
            this.rdbDoutorado.AutoSize = true;
            this.rdbDoutorado.Location = new System.Drawing.Point(142, 144);
            this.rdbDoutorado.Name = "rdbDoutorado";
            this.rdbDoutorado.Size = new System.Drawing.Size(75, 17);
            this.rdbDoutorado.TabIndex = 7;
            this.rdbDoutorado.TabStop = true;
            this.rdbDoutorado.Text = "Doutorado";
            this.rdbDoutorado.UseVisualStyleBackColor = true;
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(197, 226);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(75, 23);
            this.bntCalcular.TabIndex = 8;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.limparToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // limparToolStripMenuItem
            // 
            this.limparToolStripMenuItem.Name = "limparToolStripMenuItem";
            this.limparToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.limparToolStripMenuItem.Text = "Limpar";
            this.limparToolStripMenuItem.Click += new System.EventHandler(this.limparToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // Mensalidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.rdbDoutorado);
            this.Controls.Add(this.rdbMestrado);
            this.Controls.Add(this.txtMensalidade);
            this.Controls.Add(this.txtGraduacao);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Mensalidade";
            this.Text = "Mensalidade";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtGraduacao;
        private System.Windows.Forms.TextBox txtMensalidade;
        private System.Windows.Forms.RadioButton rdbMestrado;
        private System.Windows.Forms.RadioButton rdbDoutorado;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limparToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}