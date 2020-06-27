namespace PousadaFoz
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblClientes = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.lblArrecadacao = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.lblValor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.gpbPacotes = new System.Windows.Forms.GroupBox();
            this.rbt3 = new System.Windows.Forms.RadioButton();
            this.rbt2 = new System.Windows.Forms.RadioButton();
            this.rbt1 = new System.Windows.Forms.RadioButton();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.gpbPacotes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblClientes);
            this.groupBox1.Controls.Add(this.Label6);
            this.groupBox1.Controls.Add(this.lblArrecadacao);
            this.groupBox1.Controls.Add(this.Label5);
            this.groupBox1.Controls.Add(this.btnAdicionar);
            this.groupBox1.Location = new System.Drawing.Point(15, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(375, 156);
            this.groupBox1.TabIndex = 78;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Relatorio Pousada";
            // 
            // lblClientes
            // 
            this.lblClientes.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblClientes.Location = new System.Drawing.Point(238, 64);
            this.lblClientes.Name = "lblClientes";
            this.lblClientes.Size = new System.Drawing.Size(121, 23);
            this.lblClientes.TabIndex = 39;
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(13, 74);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(206, 13);
            this.Label6.TabIndex = 38;
            this.Label6.Text = "Cliente que ficou um maior numero de dias";
            // 
            // lblArrecadacao
            // 
            this.lblArrecadacao.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblArrecadacao.Location = new System.Drawing.Point(238, 24);
            this.lblArrecadacao.Name = "lblArrecadacao";
            this.lblArrecadacao.Size = new System.Drawing.Size(120, 23);
            this.lblArrecadacao.TabIndex = 29;
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(13, 34);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(159, 13);
            this.Label5.TabIndex = 28;
            this.Label5.Text = "Total Arrecadado pela pousada:";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(160, 112);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(131, 23);
            this.btnAdicionar.TabIndex = 75;
            this.btnAdicionar.Text = "&Adicionar Hospedes";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(417, 411);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 77;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(451, 179);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 76;
            this.btnLimpar.Text = "&LimparTudo";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // lblValor
            // 
            this.lblValor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblValor.Location = new System.Drawing.Point(359, 69);
            this.lblValor.Name = "lblValor";
            this.lblValor.Size = new System.Drawing.Size(121, 23);
            this.lblValor.TabIndex = 74;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "Valor do Quarto:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(115, 71);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(121, 21);
            this.cbxTipo.TabIndex = 71;
            this.cbxTipo.SelectedIndexChanged += new System.EventHandler(this.cbxTipo_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 72;
            this.label7.Text = "Tipo de Quarto";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(334, 179);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 70;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Location = new System.Drawing.Point(469, 223);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(120, 23);
            this.lblTotal.TabIndex = 69;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(331, 233);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(130, 13);
            this.Label3.TabIndex = 68;
            this.Label3.Text = "Total a pagar pelo cliente:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(456, 36);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(70, 13);
            this.Label2.TabIndex = 66;
            this.Label2.Text = "Qtde de dias:";
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(115, 29);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(321, 20);
            this.txtCliente.TabIndex = 65;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(11, 29);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(99, 13);
            this.Label1.TabIndex = 64;
            this.Label1.Text = "Nome do Hospede:";
            // 
            // gpbPacotes
            // 
            this.gpbPacotes.Controls.Add(this.rbt3);
            this.gpbPacotes.Controls.Add(this.rbt2);
            this.gpbPacotes.Controls.Add(this.rbt1);
            this.gpbPacotes.Location = new System.Drawing.Point(15, 115);
            this.gpbPacotes.Name = "gpbPacotes";
            this.gpbPacotes.Size = new System.Drawing.Size(291, 141);
            this.gpbPacotes.TabIndex = 81;
            this.gpbPacotes.TabStop = false;
            this.gpbPacotes.Text = "Pacotes";
            // 
            // rbt3
            // 
            this.rbt3.AutoSize = true;
            this.rbt3.Location = new System.Drawing.Point(15, 102);
            this.rbt3.Name = "rbt3";
            this.rbt3.Size = new System.Drawing.Size(249, 17);
            this.rbt3.TabIndex = 2;
            this.rbt3.TabStop = true;
            this.rbt3.Text = "Cafe da manha + Café Colonial + Jantar Italiano";
            this.rbt3.UseVisualStyleBackColor = true;
            // 
            // rbt2
            // 
            this.rbt2.AutoSize = true;
            this.rbt2.Location = new System.Drawing.Point(15, 64);
            this.rbt2.Name = "rbt2";
            this.rbt2.Size = new System.Drawing.Size(171, 17);
            this.rbt2.TabIndex = 1;
            this.rbt2.TabStop = true;
            this.rbt2.Text = "Cafe da manha + Café Colonial";
            this.rbt2.UseVisualStyleBackColor = true;
            // 
            // rbt1
            // 
            this.rbt1.AutoSize = true;
            this.rbt1.Location = new System.Drawing.Point(15, 30);
            this.rbt1.Name = "rbt1";
            this.rbt1.Size = new System.Drawing.Size(97, 17);
            this.rbt1.TabIndex = 0;
            this.rbt1.TabStop = true;
            this.rbt1.Text = "Cafe da manha";
            this.rbt1.UseVisualStyleBackColor = true;
            // 
            // txtDias
            // 
            this.txtDias.Location = new System.Drawing.Point(533, 28);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(56, 20);
            this.txtDias.TabIndex = 82;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(601, 447);
            this.Controls.Add(this.txtDias);
            this.Controls.Add(this.gpbPacotes);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.lblValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.Text = "Pousada Foz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbPacotes.ResumeLayout(false);
            this.gpbPacotes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Label lblClientes;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label lblArrecadacao;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Button btnSair;
        internal System.Windows.Forms.Button btnLimpar;
        internal System.Windows.Forms.Button btnAdicionar;
        internal System.Windows.Forms.Label lblValor;
        internal System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label7;
        internal System.Windows.Forms.Button btnCalcular;
        internal System.Windows.Forms.Label lblTotal;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txtCliente;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.GroupBox gpbPacotes;
        private System.Windows.Forms.RadioButton rbt3;
        private System.Windows.Forms.RadioButton rbt2;
        private System.Windows.Forms.RadioButton rbt1;
        private System.Windows.Forms.TextBox txtDias;
    }
}

