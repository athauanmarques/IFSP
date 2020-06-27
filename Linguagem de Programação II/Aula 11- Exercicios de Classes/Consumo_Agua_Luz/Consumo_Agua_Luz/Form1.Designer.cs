namespace Consumo_Agua_Luz
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
            this.components = new System.ComponentModel.Container();
            this.tbAbas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.bntSairA = new System.Windows.Forms.Button();
            this.bntLimparA = new System.Windows.Forms.Button();
            this.bntCalcularA = new System.Windows.Forms.Button();
            this.txtValorTotalA = new System.Windows.Forms.TextBox();
            this.txtValorIcmsA = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtConfinsA = new System.Windows.Forms.TextBox();
            this.txtValorPisA = new System.Windows.Forms.TextBox();
            this.txtConsumoRsA = new System.Windows.Forms.TextBox();
            this.txtConsumoKwhA = new System.Windows.Forms.TextBox();
            this.txtLeituraAtuA = new System.Windows.Forms.TextBox();
            this.txtLeituraAntA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bntSairB = new System.Windows.Forms.Button();
            this.bntCalcularB = new System.Windows.Forms.Button();
            this.bntLimparB = new System.Windows.Forms.Button();
            this.txtConsumoRsB = new System.Windows.Forms.TextBox();
            this.txtConsumoLitB = new System.Windows.Forms.TextBox();
            this.txtConsumo3mB = new System.Windows.Forms.TextBox();
            this.txtLeituraAtuB = new System.Windows.Forms.TextBox();
            this.txtLeituraAntB = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.tbAbas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbAbas
            // 
            this.tbAbas.Controls.Add(this.tabPage1);
            this.tbAbas.Controls.Add(this.tabPage2);
            this.tbAbas.Location = new System.Drawing.Point(12, 12);
            this.tbAbas.Name = "tbAbas";
            this.tbAbas.SelectedIndex = 0;
            this.tbAbas.Size = new System.Drawing.Size(344, 386);
            this.tbAbas.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.bntSairA);
            this.tabPage1.Controls.Add(this.bntLimparA);
            this.tabPage1.Controls.Add(this.bntCalcularA);
            this.tabPage1.Controls.Add(this.txtValorTotalA);
            this.tabPage1.Controls.Add(this.txtValorIcmsA);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txtConfinsA);
            this.tabPage1.Controls.Add(this.txtValorPisA);
            this.tabPage1.Controls.Add(this.txtConsumoRsA);
            this.tabPage1.Controls.Add(this.txtConsumoKwhA);
            this.tabPage1.Controls.Add(this.txtLeituraAtuA);
            this.tabPage1.Controls.Add(this.txtLeituraAntA);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(336, 360);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Energia";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // bntSairA
            // 
            this.bntSairA.Location = new System.Drawing.Point(245, 289);
            this.bntSairA.Name = "bntSairA";
            this.bntSairA.Size = new System.Drawing.Size(75, 23);
            this.bntSairA.TabIndex = 18;
            this.bntSairA.Text = "Sair";
            this.bntSairA.UseVisualStyleBackColor = true;
            // 
            // bntLimparA
            // 
            this.bntLimparA.Location = new System.Drawing.Point(245, 62);
            this.bntLimparA.Name = "bntLimparA";
            this.bntLimparA.Size = new System.Drawing.Size(75, 23);
            this.bntLimparA.TabIndex = 17;
            this.bntLimparA.Text = "Limpar";
            this.bntLimparA.UseVisualStyleBackColor = true;
            // 
            // bntCalcularA
            // 
            this.bntCalcularA.Location = new System.Drawing.Point(245, 21);
            this.bntCalcularA.Name = "bntCalcularA";
            this.bntCalcularA.Size = new System.Drawing.Size(75, 23);
            this.bntCalcularA.TabIndex = 16;
            this.bntCalcularA.Text = "Calcular";
            this.bntCalcularA.UseVisualStyleBackColor = true;
            this.bntCalcularA.Click += new System.EventHandler(this.bntCalcularA_Click);
            // 
            // txtValorTotalA
            // 
            this.txtValorTotalA.Location = new System.Drawing.Point(117, 292);
            this.txtValorTotalA.Name = "txtValorTotalA";
            this.txtValorTotalA.Size = new System.Drawing.Size(110, 20);
            this.txtValorTotalA.TabIndex = 15;
            // 
            // txtValorIcmsA
            // 
            this.txtValorIcmsA.Location = new System.Drawing.Point(117, 255);
            this.txtValorIcmsA.Name = "txtValorIcmsA";
            this.txtValorIcmsA.Size = new System.Drawing.Size(110, 20);
            this.txtValorIcmsA.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Valor Icms:";
            // 
            // txtConfinsA
            // 
            this.txtConfinsA.Location = new System.Drawing.Point(117, 211);
            this.txtConfinsA.Name = "txtConfinsA";
            this.txtConfinsA.Size = new System.Drawing.Size(110, 20);
            this.txtConfinsA.TabIndex = 12;
            // 
            // txtValorPisA
            // 
            this.txtValorPisA.Location = new System.Drawing.Point(117, 168);
            this.txtValorPisA.Name = "txtValorPisA";
            this.txtValorPisA.Size = new System.Drawing.Size(110, 20);
            this.txtValorPisA.TabIndex = 11;
            // 
            // txtConsumoRsA
            // 
            this.txtConsumoRsA.Location = new System.Drawing.Point(117, 124);
            this.txtConsumoRsA.Name = "txtConsumoRsA";
            this.txtConsumoRsA.Size = new System.Drawing.Size(110, 20);
            this.txtConsumoRsA.TabIndex = 10;
            // 
            // txtConsumoKwhA
            // 
            this.txtConsumoKwhA.Location = new System.Drawing.Point(117, 92);
            this.txtConsumoKwhA.Name = "txtConsumoKwhA";
            this.txtConsumoKwhA.Size = new System.Drawing.Size(110, 20);
            this.txtConsumoKwhA.TabIndex = 9;
            // 
            // txtLeituraAtuA
            // 
            this.txtLeituraAtuA.Location = new System.Drawing.Point(117, 47);
            this.txtLeituraAtuA.Name = "txtLeituraAtuA";
            this.txtLeituraAtuA.Size = new System.Drawing.Size(110, 20);
            this.txtLeituraAtuA.TabIndex = 8;
            // 
            // txtLeituraAntA
            // 
            this.txtLeituraAntA.Location = new System.Drawing.Point(117, 21);
            this.txtLeituraAntA.Name = "txtLeituraAntA";
            this.txtLeituraAntA.Size = new System.Drawing.Size(110, 20);
            this.txtLeituraAntA.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Valor Total:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Confins:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Valor do Pis:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Consumo(R$):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Consumo(Kwh):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Leitura Atual:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Leitura Anterior:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bntSairB);
            this.tabPage2.Controls.Add(this.bntCalcularB);
            this.tabPage2.Controls.Add(this.bntLimparB);
            this.tabPage2.Controls.Add(this.txtConsumoRsB);
            this.tabPage2.Controls.Add(this.txtConsumoLitB);
            this.tabPage2.Controls.Add(this.txtConsumo3mB);
            this.tabPage2.Controls.Add(this.txtLeituraAtuB);
            this.tabPage2.Controls.Add(this.txtLeituraAntB);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(336, 360);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agua";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bntSairB
            // 
            this.bntSairB.Location = new System.Drawing.Point(244, 279);
            this.bntSairB.Name = "bntSairB";
            this.bntSairB.Size = new System.Drawing.Size(75, 23);
            this.bntSairB.TabIndex = 12;
            this.bntSairB.Text = "Sair";
            this.bntSairB.UseVisualStyleBackColor = true;
            // 
            // bntCalcularB
            // 
            this.bntCalcularB.Location = new System.Drawing.Point(244, 57);
            this.bntCalcularB.Name = "bntCalcularB";
            this.bntCalcularB.Size = new System.Drawing.Size(75, 23);
            this.bntCalcularB.TabIndex = 11;
            this.bntCalcularB.Text = "Calcular";
            this.bntCalcularB.UseVisualStyleBackColor = true;
            this.bntCalcularB.Click += new System.EventHandler(this.bntCalcularB_Click);
            // 
            // bntLimparB
            // 
            this.bntLimparB.Location = new System.Drawing.Point(244, 110);
            this.bntLimparB.Name = "bntLimparB";
            this.bntLimparB.Size = new System.Drawing.Size(75, 23);
            this.bntLimparB.TabIndex = 10;
            this.bntLimparB.Text = "Limpar";
            this.bntLimparB.UseVisualStyleBackColor = true;
            // 
            // txtConsumoRsB
            // 
            this.txtConsumoRsB.Location = new System.Drawing.Point(124, 276);
            this.txtConsumoRsB.Name = "txtConsumoRsB";
            this.txtConsumoRsB.Size = new System.Drawing.Size(100, 20);
            this.txtConsumoRsB.TabIndex = 9;
            // 
            // txtConsumoLitB
            // 
            this.txtConsumoLitB.Location = new System.Drawing.Point(124, 219);
            this.txtConsumoLitB.Name = "txtConsumoLitB";
            this.txtConsumoLitB.Size = new System.Drawing.Size(100, 20);
            this.txtConsumoLitB.TabIndex = 8;
            // 
            // txtConsumo3mB
            // 
            this.txtConsumo3mB.Location = new System.Drawing.Point(124, 158);
            this.txtConsumo3mB.Name = "txtConsumo3mB";
            this.txtConsumo3mB.Size = new System.Drawing.Size(100, 20);
            this.txtConsumo3mB.TabIndex = 7;
            // 
            // txtLeituraAtuB
            // 
            this.txtLeituraAtuB.Location = new System.Drawing.Point(124, 107);
            this.txtLeituraAtuB.Name = "txtLeituraAtuB";
            this.txtLeituraAtuB.Size = new System.Drawing.Size(100, 20);
            this.txtLeituraAtuB.TabIndex = 6;
            // 
            // txtLeituraAntB
            // 
            this.txtLeituraAntB.Location = new System.Drawing.Point(124, 56);
            this.txtLeituraAntB.Name = "txtLeituraAntB";
            this.txtLeituraAntB.Size = new System.Drawing.Size(100, 20);
            this.txtLeituraAntB.TabIndex = 5;
            this.txtLeituraAntB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLeituraAntB_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(32, 279);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 4;
            this.label13.Text = "Consumo(R$):";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(32, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Consumo (Litro):";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(32, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(74, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Consumo(m3):";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(32, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Leitura Atual:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(32, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Leitura Anterior:";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 410);
            this.Controls.Add(this.tbAbas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tbAbas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbAbas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox txtValorIcmsA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtConfinsA;
        private System.Windows.Forms.TextBox txtValorPisA;
        private System.Windows.Forms.TextBox txtConsumoRsA;
        private System.Windows.Forms.TextBox txtConsumoKwhA;
        private System.Windows.Forms.TextBox txtLeituraAtuA;
        private System.Windows.Forms.TextBox txtLeituraAntA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bntSairA;
        private System.Windows.Forms.Button bntLimparA;
        private System.Windows.Forms.Button bntCalcularA;
        private System.Windows.Forms.TextBox txtValorTotalA;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Button bntSairB;
        private System.Windows.Forms.Button bntCalcularB;
        private System.Windows.Forms.Button bntLimparB;
        private System.Windows.Forms.TextBox txtConsumoRsB;
        private System.Windows.Forms.TextBox txtConsumoLitB;
        private System.Windows.Forms.TextBox txtConsumo3mB;
        private System.Windows.Forms.TextBox txtLeituraAtuB;
        private System.Windows.Forms.TextBox txtLeituraAntB;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;

    }
}

