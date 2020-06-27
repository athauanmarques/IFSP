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
            this.label6 = new System.Windows.Forms.Label();
            this.txtCasa = new System.Windows.Forms.TextBox();
            this.txtQuarto = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSala = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBanheiro = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCozinha = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtAreaServico = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
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
            this.btnCalcular.Location = new System.Drawing.Point(34, 399);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(178, 399);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(311, 399);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Área da casa:";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtCasa
            // 
            this.txtCasa.Location = new System.Drawing.Point(96, 236);
            this.txtCasa.Name = "txtCasa";
            this.txtCasa.Size = new System.Drawing.Size(112, 20);
            this.txtCasa.TabIndex = 15;
            // 
            // txtQuarto
            // 
            this.txtQuarto.Location = new System.Drawing.Point(96, 280);
            this.txtQuarto.Name = "txtQuarto";
            this.txtQuarto.Size = new System.Drawing.Size(112, 20);
            this.txtQuarto.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Área quarto:";
            // 
            // txtSala
            // 
            this.txtSala.Location = new System.Drawing.Point(96, 330);
            this.txtSala.Name = "txtSala";
            this.txtSala.Size = new System.Drawing.Size(112, 20);
            this.txtSala.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Área sala:";
            // 
            // txtBanheiro
            // 
            this.txtBanheiro.Location = new System.Drawing.Point(304, 236);
            this.txtBanheiro.Name = "txtBanheiro";
            this.txtBanheiro.Size = new System.Drawing.Size(112, 20);
            this.txtBanheiro.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(224, 236);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Área banheiro:";
            // 
            // txtCozinha
            // 
            this.txtCozinha.Location = new System.Drawing.Point(304, 280);
            this.txtCozinha.Name = "txtCozinha";
            this.txtCozinha.Size = new System.Drawing.Size(112, 20);
            this.txtCozinha.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(224, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Área cozinha:";
            // 
            // txtAreaServico
            // 
            this.txtAreaServico.Location = new System.Drawing.Point(323, 330);
            this.txtAreaServico.Name = "txtAreaServico";
            this.txtAreaServico.Size = new System.Drawing.Size(93, 20);
            this.txtAreaServico.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(224, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Área área serviço:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 438);
            this.Controls.Add(this.txtAreaServico);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCozinha);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtBanheiro);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSala);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtQuarto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCasa);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCasa;
        private System.Windows.Forms.TextBox txtQuarto;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSala;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBanheiro;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCozinha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtAreaServico;
        private System.Windows.Forms.Label label11;
    }
}

