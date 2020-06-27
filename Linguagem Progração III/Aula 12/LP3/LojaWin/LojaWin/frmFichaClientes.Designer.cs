namespace LojaWin
{
    partial class frmFichaClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFichaClientes));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.bntVisualizar = new System.Windows.Forms.Button();
            this.bntCancelar = new System.Windows.Forms.Button();
            this.bntImprimir = new System.Windows.Forms.Button();
            this.printDlg = new System.Windows.Forms.PrintDialog();
            this.printDoc = new System.Drawing.Printing.PrintDocument();
            this.printPreview = new System.Windows.Forms.PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecione o cliente da apartir da lista:";
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(61, 47);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(465, 192);
            this.dgvClientes.TabIndex = 1;
            // 
            // bntVisualizar
            // 
            this.bntVisualizar.Image = ((System.Drawing.Image)(resources.GetObject("bntVisualizar.Image")));
            this.bntVisualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntVisualizar.Location = new System.Drawing.Point(61, 245);
            this.bntVisualizar.Name = "bntVisualizar";
            this.bntVisualizar.Size = new System.Drawing.Size(151, 39);
            this.bntVisualizar.TabIndex = 2;
            this.bntVisualizar.Text = "Visualizar Impressão";
            this.bntVisualizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bntVisualizar.UseVisualStyleBackColor = true;
            this.bntVisualizar.Click += new System.EventHandler(this.bntVisualizar_Click);
            // 
            // bntCancelar
            // 
            this.bntCancelar.Image = ((System.Drawing.Image)(resources.GetObject("bntCancelar.Image")));
            this.bntCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntCancelar.Location = new System.Drawing.Point(375, 245);
            this.bntCancelar.Name = "bntCancelar";
            this.bntCancelar.Size = new System.Drawing.Size(151, 39);
            this.bntCancelar.TabIndex = 3;
            this.bntCancelar.Text = "Cancelar";
            this.bntCancelar.UseVisualStyleBackColor = true;
            this.bntCancelar.Click += new System.EventHandler(this.bntCancelar_Click);
            // 
            // bntImprimir
            // 
            this.bntImprimir.Image = ((System.Drawing.Image)(resources.GetObject("bntImprimir.Image")));
            this.bntImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntImprimir.Location = new System.Drawing.Point(218, 245);
            this.bntImprimir.Name = "bntImprimir";
            this.bntImprimir.Size = new System.Drawing.Size(151, 39);
            this.bntImprimir.TabIndex = 4;
            this.bntImprimir.Text = "&Imprimir";
            this.bntImprimir.UseVisualStyleBackColor = true;
            this.bntImprimir.Click += new System.EventHandler(this.bntImprimir_Click);
            // 
            // printDlg
            // 
            this.printDlg.Document = this.printDoc;
            this.printDlg.UseEXDialog = true;
            // 
            // printDoc
            // 
            this.printDoc.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDoc_PrintPage);
            // 
            // printPreview
            // 
            this.printPreview.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreview.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreview.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreview.Document = this.printDoc;
            this.printPreview.Enabled = true;
            this.printPreview.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreview.Icon")));
            this.printPreview.Name = "printPreview";
            this.printPreview.Visible = false;
            // 
            // frmFichaClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 319);
            this.Controls.Add(this.bntImprimir);
            this.Controls.Add(this.bntCancelar);
            this.Controls.Add(this.bntVisualizar);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.label1);
            this.Name = "frmFichaClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ficha de Clientes";
            this.Load += new System.EventHandler(this.frmFichaClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button bntVisualizar;
        private System.Windows.Forms.Button bntCancelar;
        private System.Windows.Forms.Button bntImprimir;
        private System.Windows.Forms.PrintDialog printDlg;
        private System.Drawing.Printing.PrintDocument printDoc;
        private System.Windows.Forms.PrintPreviewDialog printPreview;
    }
}