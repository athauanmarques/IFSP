namespace UIWindows
{
    partial class ProdutosEmFaltaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProdutosEmFaltaForm));
            this.ProdutosEmFaltaLabel = new System.Windows.Forms.Label();
            this.produtosEmFaltaDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.produtosEmFaltaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProdutosEmFaltaLabel
            // 
            this.ProdutosEmFaltaLabel.AutoSize = true;
            this.ProdutosEmFaltaLabel.Location = new System.Drawing.Point(9, 20);
            this.ProdutosEmFaltaLabel.Name = "ProdutosEmFaltaLabel";
            this.ProdutosEmFaltaLabel.Size = new System.Drawing.Size(155, 13);
            this.ProdutosEmFaltaLabel.TabIndex = 0;
            this.ProdutosEmFaltaLabel.Text = "Relatório de Produtos em Falta:";
            // 
            // produtosEmFaltaDataGridView
            // 
            this.produtosEmFaltaDataGridView.AllowUserToAddRows = false;
            this.produtosEmFaltaDataGridView.AllowUserToDeleteRows = false;
            this.produtosEmFaltaDataGridView.AllowUserToResizeColumns = false;
            this.produtosEmFaltaDataGridView.AllowUserToResizeRows = false;
            this.produtosEmFaltaDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.produtosEmFaltaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtosEmFaltaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.nome,
            this.preco,
            this.estoque});
            this.produtosEmFaltaDataGridView.Location = new System.Drawing.Point(12, 36);
            this.produtosEmFaltaDataGridView.Name = "produtosEmFaltaDataGridView";
            this.produtosEmFaltaDataGridView.ReadOnly = true;
            this.produtosEmFaltaDataGridView.RowHeadersVisible = false;
            this.produtosEmFaltaDataGridView.Size = new System.Drawing.Size(458, 221);
            this.produtosEmFaltaDataGridView.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(395, 279);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // codigo
            // 
            this.codigo.DataPropertyName = "codigo";
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 50;
            // 
            // nome
            // 
            this.nome.DataPropertyName = "nome";
            this.nome.HeaderText = "Nome";
            this.nome.Name = "nome";
            this.nome.ReadOnly = true;
            this.nome.Width = 250;
            // 
            // preco
            // 
            this.preco.DataPropertyName = "preco";
            this.preco.HeaderText = "Preço";
            this.preco.Name = "preco";
            this.preco.ReadOnly = true;
            this.preco.Width = 78;
            // 
            // estoque
            // 
            this.estoque.DataPropertyName = "estoque";
            this.estoque.HeaderText = "Estoque";
            this.estoque.Name = "estoque";
            this.estoque.ReadOnly = true;
            this.estoque.Width = 60;
            // 
            // ProdutosEmFaltaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 316);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.produtosEmFaltaDataGridView);
            this.Controls.Add(this.ProdutosEmFaltaLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProdutosEmFaltaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produtos em falta";
            this.Load += new System.EventHandler(this.ProdutosEmFaltaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtosEmFaltaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProdutosEmFaltaLabel;
        private System.Windows.Forms.DataGridView produtosEmFaltaDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn estoque;
    }
}