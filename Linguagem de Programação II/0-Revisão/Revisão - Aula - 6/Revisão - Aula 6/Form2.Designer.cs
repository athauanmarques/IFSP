namespace Revisão___Aula_6
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
            this.txtEntradaQts = new System.Windows.Forms.TextBox();
            this.txtTotalgGasto = new System.Windows.Forms.TextBox();
            this.txtTotalQts = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rbtJuca = new System.Windows.Forms.RadioButton();
            this.rbtTuca = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEntradaQts
            // 
            this.txtEntradaQts.Location = new System.Drawing.Point(191, 27);
            this.txtEntradaQts.Name = "txtEntradaQts";
            this.txtEntradaQts.Size = new System.Drawing.Size(100, 20);
            this.txtEntradaQts.TabIndex = 0;
            // 
            // txtTotalgGasto
            // 
            this.txtTotalgGasto.Location = new System.Drawing.Point(179, 185);
            this.txtTotalgGasto.Name = "txtTotalgGasto";
            this.txtTotalgGasto.Size = new System.Drawing.Size(100, 20);
            this.txtTotalgGasto.TabIndex = 1;
            // 
            // txtTotalQts
            // 
            this.txtTotalQts.Location = new System.Drawing.Point(179, 139);
            this.txtTotalQts.Name = "txtTotalQts";
            this.txtTotalQts.Size = new System.Drawing.Size(100, 20);
            this.txtTotalQts.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quantidade de tinta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Total gasto:";
            // 
            // rbtJuca
            // 
            this.rbtJuca.AutoSize = true;
            this.rbtJuca.Location = new System.Drawing.Point(37, 13);
            this.rbtJuca.Name = "rbtJuca";
            this.rbtJuca.Size = new System.Drawing.Size(138, 17);
            this.rbtJuca.TabIndex = 5;
            this.rbtJuca.TabStop = true;
            this.rbtJuca.Text = " Juca tintas 145 por m2 ";
            this.rbtJuca.UseVisualStyleBackColor = true;
            // 
            // rbtTuca
            // 
            this.rbtTuca.AutoSize = true;
            this.rbtTuca.Location = new System.Drawing.Point(231, 13);
            this.rbtTuca.Name = "rbtTuca";
            this.rbtTuca.Size = new System.Drawing.Size(141, 17);
            this.rbtTuca.TabIndex = 6;
            this.rbtTuca.TabStop = true;
            this.rbtTuca.Text = "Tuca Tintas 180 por m2 ";
            this.rbtTuca.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Quantida a ser pintada:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(179, 239);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(75, 23);
            this.bntCalcular.TabIndex = 9;
            this.bntCalcular.Text = "Calcular";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.bntCalcular_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(300, 239);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Sair";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtTuca);
            this.groupBox1.Controls.Add(this.rbtJuca);
            this.groupBox1.Location = new System.Drawing.Point(18, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(389, 46);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 288);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotalQts);
            this.Controls.Add(this.txtTotalgGasto);
            this.Controls.Add(this.txtEntradaQts);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEntradaQts;
        private System.Windows.Forms.TextBox txtTotalgGasto;
        private System.Windows.Forms.TextBox txtTotalQts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbtJuca;
        private System.Windows.Forms.RadioButton rbtTuca;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}