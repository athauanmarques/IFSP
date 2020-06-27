namespace Treino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbbDias = new System.Windows.Forms.ComboBox();
            this.lblSegunda = new System.Windows.Forms.Label();
            this.bntMostrar = new System.Windows.Forms.Button();
            this.lblTerca = new System.Windows.Forms.Label();
            this.lblQuarta = new System.Windows.Forms.Label();
            this.lblQuinta = new System.Windows.Forms.Label();
            this.lblSexta = new System.Windows.Forms.Label();
            this.lblSabado = new System.Windows.Forms.Label();
            this.lblMen = new System.Windows.Forms.Label();
            this.bntSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbbDias
            // 
            this.cbbDias.FormattingEnabled = true;
            this.cbbDias.Items.AddRange(new object[] {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sabado"});
            this.cbbDias.Location = new System.Drawing.Point(11, 31);
            this.cbbDias.Margin = new System.Windows.Forms.Padding(2);
            this.cbbDias.Name = "cbbDias";
            this.cbbDias.Size = new System.Drawing.Size(261, 26);
            this.cbbDias.TabIndex = 0;
            this.cbbDias.SelectedIndexChanged += new System.EventHandler(this.cbbDias_SelectedIndexChanged);
            // 
            // lblSegunda
            // 
            this.lblSegunda.AutoSize = true;
            this.lblSegunda.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegunda.ForeColor = System.Drawing.Color.Yellow;
            this.lblSegunda.Location = new System.Drawing.Point(121, 97);
            this.lblSegunda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSegunda.Name = "lblSegunda";
            this.lblSegunda.Size = new System.Drawing.Size(566, 176);
            this.lblSegunda.TabIndex = 1;
            this.lblSegunda.Text = resources.GetString("lblSegunda.Text");
            // 
            // bntMostrar
            // 
            this.bntMostrar.BackColor = System.Drawing.Color.Black;
            this.bntMostrar.ForeColor = System.Drawing.Color.Red;
            this.bntMostrar.Location = new System.Drawing.Point(492, 352);
            this.bntMostrar.Margin = new System.Windows.Forms.Padding(2);
            this.bntMostrar.Name = "bntMostrar";
            this.bntMostrar.Size = new System.Drawing.Size(168, 32);
            this.bntMostrar.TabIndex = 2;
            this.bntMostrar.Text = "Exibir Exercicios";
            this.bntMostrar.UseVisualStyleBackColor = false;
            this.bntMostrar.Click += new System.EventHandler(this.bntMostrar_Click);
            // 
            // lblTerca
            // 
            this.lblTerca.AutoSize = true;
            this.lblTerca.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTerca.ForeColor = System.Drawing.Color.Yellow;
            this.lblTerca.Location = new System.Drawing.Point(121, 97);
            this.lblTerca.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTerca.Name = "lblTerca";
            this.lblTerca.Size = new System.Drawing.Size(340, 154);
            this.lblTerca.TabIndex = 3;
            this.lblTerca.Text = "Pernas\r\n\r\n4 séries de Agachamento, 8-10 reps\r\n3 séries de Lunges, 8-10 reps\r\n3 sé" +
    "ries de Leg Press, 8-10 reps\r\n3 séries de Cadeira Extensora, até a falha\r\n3 séri" +
    "es de Mesa Flexora, 8-10 reps";
            // 
            // lblQuarta
            // 
            this.lblQuarta.AutoSize = true;
            this.lblQuarta.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuarta.ForeColor = System.Drawing.Color.Yellow;
            this.lblQuarta.Location = new System.Drawing.Point(121, 97);
            this.lblQuarta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuarta.Name = "lblQuarta";
            this.lblQuarta.Size = new System.Drawing.Size(449, 154);
            this.lblQuarta.TabIndex = 4;
            this.lblQuarta.Text = resources.GetString("lblQuarta.Text");
            // 
            // lblQuinta
            // 
            this.lblQuinta.AutoSize = true;
            this.lblQuinta.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuinta.ForeColor = System.Drawing.Color.Yellow;
            this.lblQuinta.Location = new System.Drawing.Point(121, 97);
            this.lblQuinta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuinta.Name = "lblQuinta";
            this.lblQuinta.Size = new System.Drawing.Size(519, 220);
            this.lblQuinta.TabIndex = 5;
            this.lblQuinta.Text = resources.GetString("lblQuinta.Text");
            // 
            // lblSexta
            // 
            this.lblSexta.AutoSize = true;
            this.lblSexta.Font = new System.Drawing.Font("Poor Richard", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexta.ForeColor = System.Drawing.Color.White;
            this.lblSexta.Location = new System.Drawing.Point(168, 188);
            this.lblSexta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSexta.Name = "lblSexta";
            this.lblSexta.Size = new System.Drawing.Size(328, 41);
            this.lblSexta.TabIndex = 6;
            this.lblSexta.Text = "Descanço do guerreiro";
            // 
            // lblSabado
            // 
            this.lblSabado.AutoSize = true;
            this.lblSabado.Font = new System.Drawing.Font("Poor Richard", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSabado.ForeColor = System.Drawing.Color.Yellow;
            this.lblSabado.Location = new System.Drawing.Point(121, 97);
            this.lblSabado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSabado.Name = "lblSabado";
            this.lblSabado.Size = new System.Drawing.Size(375, 132);
            this.lblSabado.TabIndex = 7;
            this.lblSabado.Text = "Full Body\r\n\r\n3 séries de Levantamento Terra, 8-10 reps\r\n3 séries de Agachamento, " +
    "8-10 reps\r\n3 séries de Levantamento Olímpico, 8-10 reps\r\n3 séries de Barra Fixa " +
    "com peso, 8-10 reps\r\n";
            // 
            // lblMen
            // 
            this.lblMen.AutoSize = true;
            this.lblMen.Font = new System.Drawing.Font("Papyrus", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMen.ForeColor = System.Drawing.Color.Red;
            this.lblMen.Location = new System.Drawing.Point(170, 153);
            this.lblMen.Name = "lblMen";
            this.lblMen.Size = new System.Drawing.Size(480, 102);
            this.lblMen.TabIndex = 8;
            this.lblMen.Text = "                    DOR\r\nO maior motivo para superação";
            // 
            // bntSair
            // 
            this.bntSair.Location = new System.Drawing.Point(599, 31);
            this.bntSair.Name = "bntSair";
            this.bntSair.Size = new System.Drawing.Size(75, 23);
            this.bntSair.TabIndex = 9;
            this.bntSair.Text = "Sair";
            this.bntSair.UseVisualStyleBackColor = true;
            this.bntSair.Click += new System.EventHandler(this.bntSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(744, 429);
            this.Controls.Add(this.bntSair);
            this.Controls.Add(this.lblMen);
            this.Controls.Add(this.lblSabado);
            this.Controls.Add(this.lblSexta);
            this.Controls.Add(this.lblQuinta);
            this.Controls.Add(this.lblQuarta);
            this.Controls.Add(this.lblTerca);
            this.Controls.Add(this.bntMostrar);
            this.Controls.Add(this.lblSegunda);
            this.Controls.Add(this.cbbDias);
            this.Font = new System.Drawing.Font("Papyrus", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evolution Warrior";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbDias;
        private System.Windows.Forms.Label lblSegunda;
        private System.Windows.Forms.Button bntMostrar;
        private System.Windows.Forms.Label lblTerca;
        private System.Windows.Forms.Label lblQuarta;
        private System.Windows.Forms.Label lblQuinta;
        private System.Windows.Forms.Label lblSexta;
        private System.Windows.Forms.Label lblSabado;
        private System.Windows.Forms.Label lblMen;
        private System.Windows.Forms.Button bntSair;

    }
}

