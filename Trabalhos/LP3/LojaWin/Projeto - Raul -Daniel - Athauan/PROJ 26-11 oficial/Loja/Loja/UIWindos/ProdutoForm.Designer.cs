namespace Loja.UIWindows
{
    partial class ProdutoForm
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
            this.produtoDataGridView = new System.Windows.Forms.DataGridView();
            this.btnExcluirP = new System.Windows.Forms.Button();
            this.btnAlterarP = new System.Windows.Forms.Button();
            this.btnIncluirP = new System.Windows.Forms.Button();
            this.btnLimparP = new System.Windows.Forms.Button();
            this.estoqueTextBox = new System.Windows.Forms.TextBox();
            this.nomePTextBox = new System.Windows.Forms.TextBox();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.codigoPTextBox = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.precoTextBox = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // produtoDataGridView
            // 
            this.produtoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.produtoDataGridView.Location = new System.Drawing.Point(49, 209);
            this.produtoDataGridView.Name = "produtoDataGridView";
            this.produtoDataGridView.Size = new System.Drawing.Size(240, 150);
            this.produtoDataGridView.TabIndex = 26;
            // 
            // btnExcluirP
            // 
            this.btnExcluirP.Location = new System.Drawing.Point(333, 141);
            this.btnExcluirP.Name = "btnExcluirP";
            this.btnExcluirP.Size = new System.Drawing.Size(75, 23);
            this.btnExcluirP.TabIndex = 25;
            this.btnExcluirP.Text = "Excluir";
            this.btnExcluirP.UseVisualStyleBackColor = true;
            this.btnExcluirP.Click += new System.EventHandler(this.btnExcluirP_Click);
            // 
            // btnAlterarP
            // 
            this.btnAlterarP.Location = new System.Drawing.Point(252, 141);
            this.btnAlterarP.Name = "btnAlterarP";
            this.btnAlterarP.Size = new System.Drawing.Size(75, 23);
            this.btnAlterarP.TabIndex = 24;
            this.btnAlterarP.Text = "Alterar";
            this.btnAlterarP.UseVisualStyleBackColor = true;
            this.btnAlterarP.Click += new System.EventHandler(this.btnAlterarP_Click);
            // 
            // btnIncluirP
            // 
            this.btnIncluirP.Location = new System.Drawing.Point(171, 141);
            this.btnIncluirP.Name = "btnIncluirP";
            this.btnIncluirP.Size = new System.Drawing.Size(75, 23);
            this.btnIncluirP.TabIndex = 23;
            this.btnIncluirP.Text = "Inlcuir";
            this.btnIncluirP.UseVisualStyleBackColor = true;
            this.btnIncluirP.Click += new System.EventHandler(this.btnIncluirP_Click);
            // 
            // btnLimparP
            // 
            this.btnLimparP.Location = new System.Drawing.Point(90, 141);
            this.btnLimparP.Name = "btnLimparP";
            this.btnLimparP.Size = new System.Drawing.Size(75, 23);
            this.btnLimparP.TabIndex = 22;
            this.btnLimparP.Text = "Limpar";
            this.btnLimparP.UseVisualStyleBackColor = true;
            this.btnLimparP.Click += new System.EventHandler(this.btnLimparP_Click);
            // 
            // estoqueTextBox
            // 
            this.estoqueTextBox.Location = new System.Drawing.Point(65, 101);
            this.estoqueTextBox.Name = "estoqueTextBox";
            this.estoqueTextBox.Size = new System.Drawing.Size(100, 20);
            this.estoqueTextBox.TabIndex = 21;
            // 
            // nomePTextBox
            // 
            this.nomePTextBox.Location = new System.Drawing.Point(65, 38);
            this.nomePTextBox.Name = "nomePTextBox";
            this.nomePTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomePTextBox.TabIndex = 19;
            // 
            // lblEstoque
            // 
            this.lblEstoque.AutoSize = true;
            this.lblEstoque.Location = new System.Drawing.Point(4, 104);
            this.lblEstoque.Name = "lblEstoque";
            this.lblEstoque.Size = new System.Drawing.Size(46, 13);
            this.lblEstoque.TabIndex = 17;
            this.lblEstoque.Text = "Estoque";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Location = new System.Drawing.Point(4, 72);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(35, 13);
            this.lblPreco.TabIndex = 16;
            this.lblPreco.Text = "Preço";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(4, 41);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 14;
            this.lblNome.Text = "Nome";
            // 
            // codigoPTextBox
            // 
            this.codigoPTextBox.Location = new System.Drawing.Point(63, 6);
            this.codigoPTextBox.Name = "codigoPTextBox";
            this.codigoPTextBox.Size = new System.Drawing.Size(100, 20);
            this.codigoPTextBox.TabIndex = 28;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(4, 9);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(40, 13);
            this.lblCodigo.TabIndex = 27;
            this.lblCodigo.Text = "Codigo";
            // 
            // precoTextBox
            // 
            this.precoTextBox.Location = new System.Drawing.Point(65, 65);
            this.precoTextBox.Mask = "#,###.00";
            this.precoTextBox.Name = "precoTextBox";
            this.precoTextBox.Size = new System.Drawing.Size(100, 20);
            this.precoTextBox.TabIndex = 29;
            // 
            // ProdutoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 365);
            this.Controls.Add(this.precoTextBox);
            this.Controls.Add(this.codigoPTextBox);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.produtoDataGridView);
            this.Controls.Add(this.btnExcluirP);
            this.Controls.Add(this.btnAlterarP);
            this.Controls.Add(this.btnIncluirP);
            this.Controls.Add(this.btnLimparP);
            this.Controls.Add(this.estoqueTextBox);
            this.Controls.Add(this.nomePTextBox);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.lblNome);
            this.Name = "ProdutoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProdutoForm";
            this.Load += new System.EventHandler(this.ProdutoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.produtoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView produtoDataGridView;
        private System.Windows.Forms.Button btnExcluirP;
        private System.Windows.Forms.Button btnAlterarP;
        private System.Windows.Forms.Button btnIncluirP;
        private System.Windows.Forms.Button btnLimparP;
        private System.Windows.Forms.TextBox estoqueTextBox;
        private System.Windows.Forms.TextBox nomePTextBox;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox codigoPTextBox;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.MaskedTextBox precoTextBox;

    }
}