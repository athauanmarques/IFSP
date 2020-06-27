using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loja
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void btnIcluir_Click(object sender, EventArgs e)
        {
            Negocios.Produtos p = new Negocios.Produtos();
            p.Codigo = Convert.ToInt32(txtCodigo.Text);
            p.Incluir();
            lblStatus.Text = p.Status;
        }
    }
}
