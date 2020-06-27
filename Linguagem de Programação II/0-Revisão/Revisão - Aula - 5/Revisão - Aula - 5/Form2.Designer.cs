namespace Revisão___Aula___5
{
    partial class frmConsulta
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
            this.txtNome = new System.Windows.Forms.TextBox();
            this.bntIncluir = new System.Windows.Forms.Button();
            this.chkAlterar = new System.Windows.Forms.CheckBox();
            this.chkConsultar = new System.Windows.Forms.CheckBox();
            this.chkExcluir = new System.Windows.Forms.CheckBox();
            this.chkIncluir = new System.Windows.Forms.CheckBox();
            this.rbMascuino = new System.Windows.Forms.RadioButton();
            this.rbFeminino = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Status = new System.Windows.Forms.GroupBox();
            this.lblS = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rtxResult = new System.Windows.Forms.RichTextBox();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.lblSexo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(52, 52);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 20);
            this.txtNome.TabIndex = 0;
            // 
            // bntIncluir
            // 
            this.bntIncluir.Location = new System.Drawing.Point(233, 52);
            this.bntIncluir.Name = "bntIncluir";
            this.bntIncluir.Size = new System.Drawing.Size(75, 23);
            this.bntIncluir.TabIndex = 1;
            this.bntIncluir.Text = "Incluir";
            this.bntIncluir.UseVisualStyleBackColor = true;
            this.bntIncluir.Click += new System.EventHandler(this.bntIncluir_Click);
            // 
            // chkAlterar
            // 
            this.chkAlterar.AutoSize = true;
            this.chkAlterar.Location = new System.Drawing.Point(6, 19);
            this.chkAlterar.Name = "chkAlterar";
            this.chkAlterar.Size = new System.Drawing.Size(56, 17);
            this.chkAlterar.TabIndex = 2;
            this.chkAlterar.Text = "Alterar";
            this.chkAlterar.UseVisualStyleBackColor = true;
            // 
            // chkConsultar
            // 
            this.chkConsultar.AutoSize = true;
            this.chkConsultar.Location = new System.Drawing.Point(6, 42);
            this.chkConsultar.Name = "chkConsultar";
            this.chkConsultar.Size = new System.Drawing.Size(70, 17);
            this.chkConsultar.TabIndex = 3;
            this.chkConsultar.Text = "Consultar";
            this.chkConsultar.UseVisualStyleBackColor = true;
            // 
            // chkExcluir
            // 
            this.chkExcluir.AutoSize = true;
            this.chkExcluir.Location = new System.Drawing.Point(5, 65);
            this.chkExcluir.Name = "chkExcluir";
            this.chkExcluir.Size = new System.Drawing.Size(57, 17);
            this.chkExcluir.TabIndex = 4;
            this.chkExcluir.Text = "Excluir";
            this.chkExcluir.UseVisualStyleBackColor = true;
            // 
            // chkIncluir
            // 
            this.chkIncluir.AutoSize = true;
            this.chkIncluir.Location = new System.Drawing.Point(6, 88);
            this.chkIncluir.Name = "chkIncluir";
            this.chkIncluir.Size = new System.Drawing.Size(54, 17);
            this.chkIncluir.TabIndex = 5;
            this.chkIncluir.Text = "Incluir";
            this.chkIncluir.UseVisualStyleBackColor = true;
            // 
            // rbMascuino
            // 
            this.rbMascuino.AutoSize = true;
            this.rbMascuino.Location = new System.Drawing.Point(9, 12);
            this.rbMascuino.Name = "rbMascuino";
            this.rbMascuino.Size = new System.Drawing.Size(73, 17);
            this.rbMascuino.TabIndex = 7;
            this.rbMascuino.TabStop = true;
            this.rbMascuino.Text = "Masculino";
            this.rbMascuino.UseVisualStyleBackColor = true;
            // 
            // rbFeminino
            // 
            this.rbFeminino.AutoSize = true;
            this.rbFeminino.Location = new System.Drawing.Point(9, 35);
            this.rbFeminino.Name = "rbFeminino";
            this.rbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rbFeminino.TabIndex = 8;
            this.rbFeminino.TabStop = true;
            this.rbFeminino.Text = "Feminino";
            this.rbFeminino.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkIncluir);
            this.groupBox1.Controls.Add(this.chkExcluir);
            this.groupBox1.Controls.Add(this.chkConsultar);
            this.groupBox1.Controls.Add(this.chkAlterar);
            this.groupBox1.Location = new System.Drawing.Point(44, 102);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(92, 117);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permissões";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbFeminino);
            this.groupBox2.Controls.Add(this.rbMascuino);
            this.groupBox2.Location = new System.Drawing.Point(45, 242);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(105, 58);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sexo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Informe nome";
            // 
            // Status
            // 
            this.Status.Controls.Add(this.lblSexo);
            this.Status.Controls.Add(this.lblS);
            this.Status.Controls.Add(this.label2);
            this.Status.Controls.Add(this.rtxResult);
            this.Status.Location = new System.Drawing.Point(186, 108);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(285, 276);
            this.Status.TabIndex = 13;
            this.Status.TabStop = false;
            this.Status.Text = "Status";
            // 
            // lblS
            // 
            this.lblS.AutoSize = true;
            this.lblS.Location = new System.Drawing.Point(24, 214);
            this.lblS.Name = "lblS";
            this.lblS.Size = new System.Drawing.Size(34, 13);
            this.lblS.TabIndex = 2;
            this.lblS.Text = "Sexo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Permissões de status";
            // 
            // rtxResult
            // 
            this.rtxResult.Location = new System.Drawing.Point(24, 39);
            this.rtxResult.Name = "rtxResult";
            this.rtxResult.Size = new System.Drawing.Size(215, 153);
            this.rtxResult.TabIndex = 0;
            this.rtxResult.Text = "";
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(338, 52);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 14;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(54, 322);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 62);
            this.bntSair.TabIndex = 15;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(64, 214);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(0, 13);
            this.lblSexo.TabIndex = 3;
            // 
            // frmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 440);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bntIncluir);
            this.Controls.Add(this.txtNome);
            this.Name = "frmConsulta";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Status.ResumeLayout(false);
            this.Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button bntIncluir;
        private System.Windows.Forms.CheckBox chkAlterar;
        private System.Windows.Forms.CheckBox chkConsultar;
        private System.Windows.Forms.CheckBox chkExcluir;
        private System.Windows.Forms.CheckBox chkIncluir;
        private System.Windows.Forms.RadioButton rbMascuino;
        private System.Windows.Forms.RadioButton rbFeminino;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Status;
        private System.Windows.Forms.Label lblS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox rtxResult;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
        private System.Windows.Forms.Label lblSexo;
    }
}