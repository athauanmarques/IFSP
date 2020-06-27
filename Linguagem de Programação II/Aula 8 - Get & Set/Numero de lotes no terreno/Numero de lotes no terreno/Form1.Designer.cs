namespace WindowsFormsApplication1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAreaTerreno = new System.Windows.Forms.TextBox();
            this.txtLoteFrente = new System.Windows.Forms.TextBox();
            this.txtLateralLote = new System.Windows.Forms.TextBox();
            this.txtAreaLote = new System.Windows.Forms.TextBox();
            this.txtTotalLotes = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblErro = new System.Windows.Forms.Label();
            this.txtCasa = new System.Windows.Forms.TextBox();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.txtCozinha = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBanheiro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Entre com a area total do terreno:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Entre com a dimensão da frente do lote:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Entre com a dimensão lateral do lote:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Área de um lote:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "N° de lotes no loteamento:";
            // 
            // txtAreaTerreno
            // 
            this.txtAreaTerreno.Location = new System.Drawing.Point(245, 29);
            this.txtAreaTerreno.Name = "txtAreaTerreno";
            this.txtAreaTerreno.Size = new System.Drawing.Size(156, 20);
            this.txtAreaTerreno.TabIndex = 5;
            // 
            // txtLoteFrente
            // 
            this.txtLoteFrente.Location = new System.Drawing.Point(245, 70);
            this.txtLoteFrente.Name = "txtLoteFrente";
            this.txtLoteFrente.Size = new System.Drawing.Size(156, 20);
            this.txtLoteFrente.TabIndex = 6;
            // 
            // txtLateralLote
            // 
            this.txtLateralLote.Location = new System.Drawing.Point(245, 103);
            this.txtLateralLote.Name = "txtLateralLote";
            this.txtLateralLote.Size = new System.Drawing.Size(156, 20);
            this.txtLateralLote.TabIndex = 7;
            // 
            // txtAreaLote
            // 
            this.txtAreaLote.Location = new System.Drawing.Point(245, 140);
            this.txtAreaLote.Name = "txtAreaLote";
            this.txtAreaLote.ReadOnly = true;
            this.txtAreaLote.Size = new System.Drawing.Size(156, 20);
            this.txtAreaLote.TabIndex = 8;
            // 
            // txtTotalLotes
            // 
            this.txtTotalLotes.Location = new System.Drawing.Point(245, 177);
            this.txtTotalLotes.Name = "txtTotalLotes";
            this.txtTotalLotes.ReadOnly = true;
            this.txtTotalLotes.Size = new System.Drawing.Size(156, 20);
            this.txtTotalLotes.TabIndex = 9;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(73, 381);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(217, 381);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(350, 381);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lblErro
            // 
            this.lblErro.AutoSize = true;
            this.lblErro.Location = new System.Drawing.Point(112, 3);
            this.lblErro.Name = "lblErro";
            this.lblErro.Size = new System.Drawing.Size(0, 13);
            this.lblErro.TabIndex = 13;
            // 
            // txtCasa
            // 
            this.txtCasa.Enabled = false;
            this.txtCasa.Location = new System.Drawing.Point(52, 18);
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.ReadOnly = true;
            this.txtCasa.Size = new System.Drawing.Size(76, 20);
            this.txtCasa.TabIndex = 14;
            // 
            // txtQuarto
            // 
            this.txtQuarto.Enabled = false;
            this.txtQuarto.Location = new System.Drawing.Point(57, 54);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.ReadOnly = true;
            this.txtQuarto.Size = new System.Drawing.Size(71, 20);
            this.txtQuarto.TabIndex = 15;
            // 
            // txtSala
            // 
            this.txtSala.Enabled = false;
            this.txtSala.Location = new System.Drawing.Point(57, 84);
            this.txtSala.Name = "txtSala";
            this.txtSala.ReadOnly = true;
            this.txtSala.Size = new System.Drawing.Size(87, 20);
            this.txtSala.TabIndex = 16;
            // 
            // txtServico
            // 
            this.txtServico.Enabled = false;
            this.txtServico.Location = new System.Drawing.Point(330, 80);
            this.txtServico.Name = "txtServico";
            this.txtServico.ReadOnly = true;
            this.txtServico.Size = new System.Drawing.Size(73, 20);
            this.txtServico.TabIndex = 18;
            // 
            // txtCozinha
            // 
            this.txtCozinha.Enabled = false;
            this.txtCozinha.Location = new System.Drawing.Point(310, 54);
            this.txtCozinha.Name = "txtCozinha";
            this.txtCozinha.ReadOnly = true;
            this.txtCozinha.Size = new System.Drawing.Size(81, 20);
            this.txtCozinha.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Casa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Quarto";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 57);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Cozinha";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(28, 13);
            this.label9.TabIndex = 22;
            this.label9.Text = "Sala";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(238, 87);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Área de Serviço:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(238, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Banheiro";
            // 
            // txtBanheiro
            // 
            this.txtBanheiro.Enabled = false;
            this.txtBanheiro.Location = new System.Drawing.Point(312, 28);
            this.txtBanheiro.Name = "txtBanheiro";
            this.txtBanheiro.ReadOnly = true;
            this.txtBanheiro.Size = new System.Drawing.Size(73, 20);
            this.txtBanheiro.TabIndex = 26;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBanheiro);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtServico);
            this.groupBox1.Controls.Add(this.txtCozinha);
            this.groupBox1.Controls.Add(this.txtSala);
            this.groupBox1.Controls.Add(this.txtQuarto);
            this.groupBox1.Controls.Add(this.txtCasa);
            this.groupBox1.Location = new System.Drawing.Point(40, 217);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(429, 123);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Áreas de aposentos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 421);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblErro);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtTotalLotes);
            this.Controls.Add(this.txtAreaLote);
            this.Controls.Add(this.txtLateralLote);
            this.Controls.Add(this.txtLoteFrente);
            this.Controls.Add(this.txtAreaTerreno);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAreaTerreno;
        private System.Windows.Forms.TextBox txtLoteFrente;
        private System.Windows.Forms.TextBox txtLateralLote;
        private System.Windows.Forms.TextBox txtAreaLote;
        private System.Windows.Forms.TextBox txtTotalLotes;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblErro;
        private System.Windows.Forms.TextBox txtCasa;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.TextBox txtCozinha;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBanheiro;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

