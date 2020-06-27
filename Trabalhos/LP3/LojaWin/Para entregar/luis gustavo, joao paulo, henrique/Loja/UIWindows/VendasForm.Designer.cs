namespace UIWindows
{
    partial class VendasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VendasForm));
            this.clienteComboBox = new System.Windows.Forms.ComboBox();
            this.produtoComboBox = new System.Windows.Forms.ComboBox();
            this.quantidadeTextBox = new System.Windows.Forms.TextBox();
            this.incluirVendaButton = new System.Windows.Forms.Button();
            this.produtoLabel = new System.Windows.Forms.Label();
            this.clienteLabel = new System.Windows.Forms.Label();
            this.quantidadeLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clienteComboBox
            // 
            this.clienteComboBox.DisplayMember = "nome";
            this.clienteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.clienteComboBox.FormattingEnabled = true;
            this.clienteComboBox.Location = new System.Drawing.Point(147, 36);
            this.clienteComboBox.Name = "clienteComboBox";
            this.clienteComboBox.Size = new System.Drawing.Size(280, 21);
            this.clienteComboBox.TabIndex = 0;
            this.clienteComboBox.ValueMember = "codigo";
            // 
            // produtoComboBox
            // 
            this.produtoComboBox.DisplayMember = "nome";
            this.produtoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.produtoComboBox.FormattingEnabled = true;
            this.produtoComboBox.Location = new System.Drawing.Point(147, 95);
            this.produtoComboBox.Name = "produtoComboBox";
            this.produtoComboBox.Size = new System.Drawing.Size(280, 21);
            this.produtoComboBox.TabIndex = 1;
            this.produtoComboBox.ValueMember = "codigo";
            // 
            // quantidadeTextBox
            // 
            this.quantidadeTextBox.Location = new System.Drawing.Point(147, 157);
            this.quantidadeTextBox.Name = "quantidadeTextBox";
            this.quantidadeTextBox.Size = new System.Drawing.Size(65, 20);
            this.quantidadeTextBox.TabIndex = 2;
            // 
            // incluirVendaButton
            // 
            this.incluirVendaButton.Location = new System.Drawing.Point(281, 148);
            this.incluirVendaButton.Name = "incluirVendaButton";
            this.incluirVendaButton.Size = new System.Drawing.Size(146, 36);
            this.incluirVendaButton.TabIndex = 3;
            this.incluirVendaButton.Text = "Incluir Venda";
            this.incluirVendaButton.UseVisualStyleBackColor = true;
            this.incluirVendaButton.Click += new System.EventHandler(this.incluirVendaButton_Click);
            // 
            // produtoLabel
            // 
            this.produtoLabel.AutoSize = true;
            this.produtoLabel.Location = new System.Drawing.Point(37, 98);
            this.produtoLabel.Name = "produtoLabel";
            this.produtoLabel.Size = new System.Drawing.Size(47, 13);
            this.produtoLabel.TabIndex = 4;
            this.produtoLabel.Text = "Produto:";
            // 
            // clienteLabel
            // 
            this.clienteLabel.AutoSize = true;
            this.clienteLabel.Location = new System.Drawing.Point(37, 39);
            this.clienteLabel.Name = "clienteLabel";
            this.clienteLabel.Size = new System.Drawing.Size(39, 13);
            this.clienteLabel.TabIndex = 5;
            this.clienteLabel.Text = "Cliente";
            // 
            // quantidadeLabel
            // 
            this.quantidadeLabel.AutoSize = true;
            this.quantidadeLabel.Location = new System.Drawing.Point(37, 160);
            this.quantidadeLabel.Name = "quantidadeLabel";
            this.quantidadeLabel.Size = new System.Drawing.Size(62, 13);
            this.quantidadeLabel.TabIndex = 6;
            this.quantidadeLabel.Text = "Quantidade";
            // 
            // VendasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 205);
            this.Controls.Add(this.quantidadeLabel);
            this.Controls.Add(this.clienteLabel);
            this.Controls.Add(this.produtoLabel);
            this.Controls.Add(this.incluirVendaButton);
            this.Controls.Add(this.quantidadeTextBox);
            this.Controls.Add(this.produtoComboBox);
            this.Controls.Add(this.clienteComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "VendasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VendasForm";
            this.Load += new System.EventHandler(this.VendasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox clienteComboBox;
        private System.Windows.Forms.ComboBox produtoComboBox;
        private System.Windows.Forms.TextBox quantidadeTextBox;
        private System.Windows.Forms.Button incluirVendaButton;
        private System.Windows.Forms.Label produtoLabel;
        private System.Windows.Forms.Label clienteLabel;
        private System.Windows.Forms.Label quantidadeLabel;
    }
}