using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula_6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            cbbProduto.Items.Add("Carro");
            cbbProduto.Items.Add("Avião");
            cbbProduto.Items.Add("oi");
        }

        private void bntCalular_Click(object sender, EventArgs e)
        {
            double preco = Convert.ToDouble(txtPreco.Text),
                   parcelas = Convert.ToDouble(txtParcelas.Text),
                   txJuros = Convert.ToDouble(txtTaxaJuros),
                   pf, totalPreco, Juros, prestacao;

            pf = Math.Pow((1+txJuros),parcelas);
            totalPreco = pf*preco;
            Juros = totalPreco - preco;
            prestacao = PF / parcelas;

            txtFinalPreco.Text = Convert.ToString(totalPreco);
            txtJurosTotal.Text = Convert.ToString(Juros);
            //txt










        }
    }
}
