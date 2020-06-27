namespace ConsumoAguaLuz
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSairE = new System.Windows.Forms.Button();
            this.btnLimparE = new System.Windows.Forms.Button();
            this.btnCalcularE = new System.Windows.Forms.Button();
            this.txtAtualE = new System.Windows.Forms.TextBox();
            this.txtAnteriorE = new System.Windows.Forms.TextBox();
            this.lblValorE = new System.Windows.Forms.Label();
            this.lblIcms = new System.Windows.Forms.Label();
            this.lblConfins = new System.Windows.Forms.Label();
            this.lblPis = new System.Windows.Forms.Label();
            this.lblReais = new System.Windows.Forms.Label();
            this.lblKwh = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSairA = new System.Windows.Forms.Button();
            this.btnLimparA = new System.Windows.Forms.Button();
            this.btnCalcularA = new System.Windows.Forms.Button();
            this.txtAtualA = new System.Windows.Forms.TextBox();
            this.txtAnteriorA = new System.Windows.Forms.TextBox();
            this.lblValor = new System.Windows.Forms.Label();
            this.lblLitro = new System.Windows.Forms.Label();
            this.lblMetros = new System.Windows.Forms.Label();
            this.lblValorA = new System.Windows.Forms.Label();
            this.lblLt = new System.Windows.Forms.Label();
            this.lblM3 = new System.Windows.Forms.Label();
            this.lblAtualA = new System.Windows.Forms.Label();
            this.lblAnteriorA = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(328, 283);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSairE);
            this.tabPage1.Controls.Add(this.btnLimparE);
            this.tabPage1.Controls.Add(this.btnCalcularE);
            this.tabPage1.Controls.Add(this.txtAtualE);
            this.tabPage1.Controls.Add(this.txtAnteriorE);
            this.tabPage1.Controls.Add(this.lblValorE);
            this.tabPage1.Controls.Add(this.lblIcms);
            this.tabPage1.Controls.Add(this.lblConfins);
            this.tabPage1.Controls.Add(this.lblPis);
            this.tabPage1.Controls.Add(this.lblReais);
            this.tabPage1.Controls.Add(this.lblKwh);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(320, 257);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Energia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSairE
            // 
            this.btnSairE.Location = new System.Drawing.Point(227, 220);
            this.btnSairE.Name = "btnSairE";
            this.btnSairE.Size = new System.Drawing.Size(75, 23);
            this.btnSairE.TabIndex = 37;
            this.btnSairE.Text = "Sair";
            this.btnSairE.UseVisualStyleBackColor = true;
            this.btnSairE.Click += new System.EventHandler(this.btnSairE_Click);
            // 
            // btnLimparE
            // 
            this.btnLimparE.Location = new System.Drawing.Point(227, 41);
            this.btnLimparE.Name = "btnLimparE";
            this.btnLimparE.Size = new System.Drawing.Size(75, 23);
            this.btnLimparE.TabIndex = 36;
            this.btnLimparE.Text = "Limpar";
            this.btnLimparE.UseVisualStyleBackColor = true;
            this.btnLimparE.Click += new System.EventHandler(this.btnLimparE_Click);
            // 
            // btnCalcularE
            // 
            this.btnCalcularE.Location = new System.Drawing.Point(227, 9);
            this.btnCalcularE.Name = "btnCalcularE";
            this.btnCalcularE.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularE.TabIndex = 35;
            this.btnCalcularE.Text = "Calcular";
            this.btnCalcularE.UseVisualStyleBackColor = true;
            this.btnCalcularE.Click += new System.EventHandler(this.btnCalcularE_Click);
            // 
            // txtAtualE
            // 
            this.txtAtualE.Location = new System.Drawing.Point(97, 41);
            this.txtAtualE.Name = "txtAtualE";
            this.txtAtualE.Size = new System.Drawing.Size(100, 20);
            this.txtAtualE.TabIndex = 34;
            // 
            // txtAnteriorE
            // 
            this.txtAnteriorE.Location = new System.Drawing.Point(97, 12);
            this.txtAnteriorE.Name = "txtAnteriorE";
            this.txtAnteriorE.Size = new System.Drawing.Size(100, 20);
            this.txtAnteriorE.TabIndex = 33;
            // 
            // lblValorE
            // 
            this.lblValorE.AutoSize = true;
            this.lblValorE.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValorE.Location = new System.Drawing.Point(97, 225);
            this.lblValorE.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblValorE.Name = "lblValorE";
            this.lblValorE.Size = new System.Drawing.Size(100, 15);
            this.lblValorE.TabIndex = 32;
            // 
            // lblIcms
            // 
            this.lblIcms.AutoSize = true;
            this.lblIcms.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblIcms.Location = new System.Drawing.Point(97, 194);
            this.lblIcms.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblIcms.Name = "lblIcms";
            this.lblIcms.Size = new System.Drawing.Size(100, 15);
            this.lblIcms.TabIndex = 31;
            // 
            // lblConfins
            // 
            this.lblConfins.AutoSize = true;
            this.lblConfins.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblConfins.Location = new System.Drawing.Point(97, 165);
            this.lblConfins.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblConfins.Name = "lblConfins";
            this.lblConfins.Size = new System.Drawing.Size(100, 15);
            this.lblConfins.TabIndex = 30;
            // 
            // lblPis
            // 
            this.lblPis.AutoSize = true;
            this.lblPis.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPis.Location = new System.Drawing.Point(97, 133);
            this.lblPis.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblPis.Name = "lblPis";
            this.lblPis.Size = new System.Drawing.Size(100, 15);
            this.lblPis.TabIndex = 29;
            // 
            // lblReais
            // 
            this.lblReais.AutoSize = true;
            this.lblReais.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReais.Location = new System.Drawing.Point(97, 107);
            this.lblReais.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblReais.Name = "lblReais";
            this.lblReais.Size = new System.Drawing.Size(100, 15);
            this.lblReais.TabIndex = 28;
            // 
            // lblKwh
            // 
            this.lblKwh.AutoSize = true;
            this.lblKwh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblKwh.Location = new System.Drawing.Point(97, 80);
            this.lblKwh.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblKwh.Name = "lblKwh";
            this.lblKwh.Size = new System.Drawing.Size(100, 15);
            this.lblKwh.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 225);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Valor Total:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Valor do Icms:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Cofins:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Valor do Pis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Consumo(R$):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Consumo(Kwh):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Leitura Atual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Leitura Anterior:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSairA);
            this.tabPage2.Controls.Add(this.btnLimparA);
            this.tabPage2.Controls.Add(this.btnCalcularA);
            this.tabPage2.Controls.Add(this.txtAtualA);
            this.tabPage2.Controls.Add(this.txtAnteriorA);
            this.tabPage2.Controls.Add(this.lblValor);
            this.tabPage2.Controls.Add(this.lblLitro);
            this.tabPage2.Controls.Add(this.lblMetros);
            this.tabPage2.Controls.Add(this.lblValorA);
            this.tabPage2.Controls.Add(this.lblLt);
            this.tabPage2.Controls.Add(this.lblM3);
            this.tabPage2.Controls.Add(this.lblAtualA);
            this.tabPage2.Controls.Add(this.lblAnteriorA);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(320, 257);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agua";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSairA
            // 
            this.btnSairA.Location = new System.Drawing.Point(227, 148);
            this.btnSairA.Name = "btnSairA";
            this.btnSairA.Size = new System.Drawing.Size(75, 23);
            this.btnSairA.TabIndex = 26;
            this.btnSairA.Text = "Sair";
            this.btnSairA.UseVisualStyleBackColor = true;
            this.btnSairA.Click += new System.EventHandler(this.btnSairA_Click);
            // 
            // btnLimparA
            // 
            this.btnLimparA.Location = new System.Drawing.Point(227, 46);
            this.btnLimparA.Name = "btnLimparA";
            this.btnLimparA.Size = new System.Drawing.Size(75, 23);
            this.btnLimparA.TabIndex = 25;
            this.btnLimparA.Text = "Limpar";
            this.btnLimparA.UseVisualStyleBackColor = true;
            this.btnLimparA.Click += new System.EventHandler(this.btnLimparA_Click);
            // 
            // btnCalcularA
            // 
            this.btnCalcularA.Location = new System.Drawing.Point(227, 11);
            this.btnCalcularA.Name = "btnCalcularA";
            this.btnCalcularA.Size = new System.Drawing.Size(75, 23);
            this.btnCalcularA.TabIndex = 24;
            this.btnCalcularA.Text = "Calcular";
            this.btnCalcularA.UseVisualStyleBackColor = true;
            this.btnCalcularA.Click += new System.EventHandler(this.btnCalcularA_Click);
            // 
            // txtAtualA
            // 
            this.txtAtualA.Location = new System.Drawing.Point(105, 46);
            this.txtAtualA.Name = "txtAtualA";
            this.txtAtualA.Size = new System.Drawing.Size(100, 20);
            this.txtAtualA.TabIndex = 23;
            // 
            // txtAnteriorA
            // 
            this.txtAnteriorA.Location = new System.Drawing.Point(105, 13);
            this.txtAnteriorA.Name = "txtAnteriorA";
            this.txtAnteriorA.Size = new System.Drawing.Size(100, 20);
            this.txtAnteriorA.TabIndex = 22;
            this.txtAnteriorA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAnteriorA_KeyPress);
            // 
            // lblValor
            // 
            this.lblValor.AutoSize = true;
            this.lblValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValor.Location = new System.Drawing.Point(105, 158);
            this.lblValor.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(100, 15);
            this.lblValor.TabIndex = 21;
            // 
            // lblLitro
            // 
            this.lblLitro.AutoSize = true;
            this.lblLitro.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblLitro.Location = new System.Drawing.Point(105, 121);
            this.lblLitro.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblLitro.Name = "lblLitro";
            this.lblLitro.Size = new System.Drawing.Size(100, 15);
            this.lblLitro.TabIndex = 20;
            // 
            // lblMetros
            // 
            this.lblMetros.AutoSize = true;
            this.lblMetros.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMetros.Location = new System.Drawing.Point(105, 89);
            this.lblMetros.MinimumSize = new System.Drawing.Size(100, 0);
            this.lblMetros.Name = "lblMetros";
            this.lblMetros.Size = new System.Drawing.Size(100, 15);
            this.lblMetros.TabIndex = 19;
            // 
            // lblValorA
            // 
            this.lblValorA.AutoSize = true;
            this.lblValorA.Location = new System.Drawing.Point(6, 158);
            this.lblValorA.Name = "lblValorA";
            this.lblValorA.Size = new System.Drawing.Size(80, 13);
            this.lblValorA.TabIndex = 18;
            this.lblValorA.Text = "Consumo (R$): ";
            // 
            // lblLt
            // 
            this.lblLt.AutoSize = true;
            this.lblLt.Location = new System.Drawing.Point(6, 123);
            this.lblLt.Name = "lblLt";
            this.lblLt.Size = new System.Drawing.Size(86, 13);
            this.lblLt.TabIndex = 17;
            this.lblLt.Text = "Consumo (Litro): ";
            // 
            // lblM3
            // 
            this.lblM3.AutoSize = true;
            this.lblM3.Location = new System.Drawing.Point(6, 89);
            this.lblM3.Name = "lblM3";
            this.lblM3.Size = new System.Drawing.Size(77, 13);
            this.lblM3.TabIndex = 16;
            this.lblM3.Text = "Consumo(m3): ";
            // 
            // lblAtualA
            // 
            this.lblAtualA.AutoSize = true;
            this.lblAtualA.Location = new System.Drawing.Point(6, 46);
            this.lblAtualA.Name = "lblAtualA";
            this.lblAtualA.Size = new System.Drawing.Size(72, 13);
            this.lblAtualA.TabIndex = 15;
            this.lblAtualA.Text = "Leitura Atual: ";
            // 
            // lblAnteriorA
            // 
            this.lblAnteriorA.AutoSize = true;
            this.lblAnteriorA.Location = new System.Drawing.Point(6, 15);
            this.lblAnteriorA.Name = "lblAnteriorA";
            this.lblAnteriorA.Size = new System.Drawing.Size(81, 13);
            this.lblAnteriorA.TabIndex = 14;
            this.lblAnteriorA.Text = "Leitura Anterior:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 290);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Calculo de Consumo Mensal:";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSairE;
        private System.Windows.Forms.Button btnLimparE;
        private System.Windows.Forms.Button btnCalcularE;
        private System.Windows.Forms.TextBox txtAtualE;
        private System.Windows.Forms.TextBox txtAnteriorE;
        private System.Windows.Forms.Label lblValorE;
        private System.Windows.Forms.Label lblIcms;
        private System.Windows.Forms.Label lblConfins;
        private System.Windows.Forms.Label lblPis;
        private System.Windows.Forms.Label lblReais;
        private System.Windows.Forms.Label lblKwh;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSairA;
        private System.Windows.Forms.Button btnLimparA;
        private System.Windows.Forms.Button btnCalcularA;
        private System.Windows.Forms.TextBox txtAtualA;
        private System.Windows.Forms.TextBox txtAnteriorA;
        private System.Windows.Forms.Label lblValor;
        private System.Windows.Forms.Label lblLitro;
        private System.Windows.Forms.Label lblMetros;
        private System.Windows.Forms.Label lblValorA;
        private System.Windows.Forms.Label lblLt;
        private System.Windows.Forms.Label lblM3;
        private System.Windows.Forms.Label lblAtualA;
        private System.Windows.Forms.Label lblAnteriorA;
    }
}

