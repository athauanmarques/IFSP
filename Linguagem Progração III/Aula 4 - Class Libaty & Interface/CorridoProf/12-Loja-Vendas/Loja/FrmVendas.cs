using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios;

namespace Loja
{
    public partial class frmVendas : Form
    {
        public frmVendas()
        {
            InitializeComponent();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            Negocios.NotasFiscais n = new Negocios.NotasFiscais();
            
            n.Razao = txtRazao.Text;
            n.Data =Convert.ToDateTime(txtData.Text);
            n.Endereco = txtEnd.Text;
            n.Cidade = txtCidade.Text;
            n.Cnpj = Convert.ToInt32(txtCnpj.Text);
            n.Valor = Convert.ToDouble(txtValor.Text);
            n.Cep =Convert.ToInt32(txtCep.Text);
            n.Estado = txtEstado.Text;

            n.Gerar();
            lblStatus.Text = n.Status;

        }
    }
}
