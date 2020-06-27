namespace Atividade
{
    partial class lote
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
            this.txtArea = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFrontal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLateral = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalArea = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtN_de_lote = new System.Windows.Forms.TextBox();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtArea
            // 
            this.txtArea.Location = new System.Drawing.Point(170, 12);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(73, 20);
            this.txtArea.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(58, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Área total do terreno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(289, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dimensão frontal do terreno:";
            // 
            // txtFrontal
            // 
            this.txtFrontal.Location = new System.Drawing.Point(432, 12);
            this.txtFrontal.Name = "txtFrontal";
            this.txtFrontal.Size = new System.Drawing.Size(75, 20);
            this.txtFrontal.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(163, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Dimensão lateral do terreno:";
            // 
            // txtLateral
            // 
            this.txtLateral.Location = new System.Drawing.Point(305, 51);
            this.txtLateral.Name = "txtLateral";
            this.txtLateral.Size = new System.Drawing.Size(74, 20);
            this.txtLateral.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(118, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Área total:";
            // 
            // txtTotalArea
            // 
            this.txtTotalArea.Cursor = System.Windows.Forms.Cursors.No;
            this.txtTotalArea.Location = new System.Drawing.Point(193, 133);
            this.txtTotalArea.Name = "txtTotalArea";
            this.txtTotalArea.ReadOnly = true;
            this.txtTotalArea.Size = new System.Drawing.Size(118, 20);
            this.txtTotalArea.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(118, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Nª de lote:";
            // 
            // txtN_de_lote
            // 
            this.txtN_de_lote.Cursor = System.Windows.Forms.Cursors.No;
            this.txtN_de_lote.Location = new System.Drawing.Point(193, 169);
            this.txtN_de_lote.Name = "txtN_de_lote";
            this.txtN_de_lote.ReadOnly = true;
            this.txtN_de_lote.Size = new System.Drawing.Size(118, 20);
            this.txtN_de_lote.TabIndex = 8;
            // 
            // bntCalcular
            // 
            this.bntCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntCalcular.Location = new System.Drawing.Point(341, 136);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(68, 51);
            this.bntCalcular.TabIndex = 3;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntLimpar.Location = new System.Drawing.Point(171, 212);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 4;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            this.bntLimpar.Click += new System.EventHandler(this.bntLimpar_Click);
            // 
            // bntSair
            // 
            this.bntSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bntSair.Location = new System.Drawing.Point(285, 212);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 5;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // lote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Atividade.Properties.Resources._7;
            this.ClientSize = new System.Drawing.Size(555, 261);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtN_de_lote);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTotalArea);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtLateral);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFrontal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtArea);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "lote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Nª de lote de um terreno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtFrontal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLateral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalArea;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtN_de_lote;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
    }
}