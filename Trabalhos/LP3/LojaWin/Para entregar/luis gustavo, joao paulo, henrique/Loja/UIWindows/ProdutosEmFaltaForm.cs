using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Loja.BLL;
using Loja.DAL;
using Loja.Modelos;

namespace UIWindows
{
    public partial class ProdutosEmFaltaForm : Form
    {
        public ProdutosEmFaltaForm()
        {
            InitializeComponent();
        }

        private void ProdutosEmFaltaForm_Load(object sender, EventArgs e)
        {
            ProdutosBLL produto = new ProdutosBLL();
            produtosEmFaltaDataGridView.DataSource = produto.ProdutosEmFalta();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}