namespace Aula_7_Revisão
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCurso = new System.Windows.Forms.TextBox();
            this.txtMensalidade = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.rtbMensalidada = new System.Windows.Forms.RadioButton();
            this.rtbDoutorado = new System.Windows.Forms.RadioButton();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.bntLimpar = new System.Windows.Forms.Button();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mesalidade graduação:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mensalidade";
            // 
            // txtCurso
            // 
            this.txtCurso.Location = new System.Drawing.Point(119, 42);
            this.txtCurso.Name = "txtCurso";
            this.txtCurso.Size = new System.Drawing.Size(138, 20);
            this.txtCurso.TabIndex = 3;
            // 
            // txtMensalidade
            // 
            this.txtMensalidade.Location = new System.Drawing.Point(165, 75);
            this.txtMensalidade.Name = "txtMensalidade";
            this.txtMensalidade.Size = new System.Drawing.Size(100, 20);
            this.txtMensalidade.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(157, 227);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 5;
            // 
            // rtbMensalidada
            // 
            this.rtbMensalidada.AutoSize = true;
            this.rtbMensalidada.Location = new System.Drawing.Point(52, 141);
            this.rtbMensalidada.Name = "rtbMensalidada";
            this.rtbMensalidada.Size = new System.Drawing.Size(69, 17);
            this.rtbMensalidada.TabIndex = 6;
            this.rtbMensalidada.TabStop = true;
            this.rtbMensalidada.Text = "Mestrado";
            this.rtbMensalidada.UseVisualStyleBackColor = true;
            // 
            // rtbDoutorado
            // 
            this.rtbDoutorado.AutoSize = true;
            this.rtbDoutorado.Location = new System.Drawing.Point(157, 141);
            this.rtbDoutorado.Name = "rtbDoutorado";
            this.rtbDoutorado.Size = new System.Drawing.Size(75, 17);
            this.rtbDoutorado.TabIndex = 7;
            this.rtbDoutorado.TabStop = true;
            this.rtbDoutorado.Text = "Doutorado";
            this.rtbDoutorado.UseVisualStyleBackColor = true;
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(43, 269);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(75, 23);
            this.bntCalcular.TabIndex = 8;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // bntLimpar
            // 
            this.bntLimpar.Location = new System.Drawing.Point(157, 269);
            this.bntLimpar.Name = "bntLimpar";
            this.bntLimpar.Size = new System.Drawing.Size(75, 23);
            this.bntLimpar.TabIndex = 9;
            this.bntLimpar.Text = "Limpar";
            this.bntLimpar.UseVisualStyleBackColor = true;
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(267, 268);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 10;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 341);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.bntLimpar);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.rtbDoutorado);
            this.Controls.Add(this.rtbMensalidada);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtMensalidade);
            this.Controls.Add(this.txtCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCurso;
        private System.Windows.Forms.TextBox txtMensalidade;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.RadioButton rtbMensalidada;
        private System.Windows.Forms.RadioButton rtbDoutorado;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Button bntLimpar;
        private System.Windows.Forms.Button bntSair;
    }
}

