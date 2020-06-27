namespace ControleProjetos
{
    partial class CadastroControle
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
            this.dgvControle = new System.Windows.Forms.DataGridView();
            this.lbListaData = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.bntTabela = new System.Windows.Forms.Button();
            this.bntVisualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControle)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // dgvControle
            // 
            this.dgvControle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControle.Location = new System.Drawing.Point(13, 43);
            this.dgvControle.Name = "dgvControle";
            this.dgvControle.Size = new System.Drawing.Size(240, 150);
            this.dgvControle.TabIndex = 1;
            // 
            // lbListaData
            // 
            this.lbListaData.FormattingEnabled = true;
            this.lbListaData.Location = new System.Drawing.Point(281, 43);
            this.lbListaData.Name = "lbListaData";
            this.lbListaData.Size = new System.Drawing.Size(120, 95);
            this.lbListaData.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(120, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "listar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntTabela
            // 
            this.bntTabela.Location = new System.Drawing.Point(221, 217);
            this.bntTabela.Name = "bntTabela";
            this.bntTabela.Size = new System.Drawing.Size(75, 23);
            this.bntTabela.TabIndex = 4;
            this.bntTabela.Text = "tabela";
            this.bntTabela.UseVisualStyleBackColor = true;
            this.bntTabela.Click += new System.EventHandler(this.bntTabela_Click);
            // 
            // bntVisualizar
            // 
            this.bntVisualizar.Location = new System.Drawing.Point(314, 217);
            this.bntVisualizar.Name = "bntVisualizar";
            this.bntVisualizar.Size = new System.Drawing.Size(75, 23);
            this.bntVisualizar.TabIndex = 5;
            this.bntVisualizar.Text = "Visualizar";
            this.bntVisualizar.UseVisualStyleBackColor = true;
            this.bntVisualizar.Click += new System.EventHandler(this.bntVisualizar_Click);
            // 
            // CadastroControle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 262);
            this.Controls.Add(this.bntVisualizar);
            this.Controls.Add(this.bntTabela);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbListaData);
            this.Controls.Add(this.dgvControle);
            this.Controls.Add(this.label1);
            this.Name = "CadastroControle";
            this.Text = "CadastroControle";
            this.Load += new System.EventHandler(this.CadastroControle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvControle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvControle;
        private System.Windows.Forms.ListBox lbListaData;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bntTabela;
        private System.Windows.Forms.Button bntVisualizar;
    }
}