using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Venda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbbProduto.Items.Add("Mouse");
            cbbProduto.Items.Add("HD externo");
            cbbProduto.Items.Add("NetBook");
            cbbProduto.Items.Add("Ultrbook");
            cbbProduto.Items.Add("Pendrive 8 gb");
            cbbProduto.Items.Add("Pendrive 16 gb");
            cbbProduto.Items.Add("Pendrive 32 gb");

            nudParcelas.Visible = false;
            groupBox2.Visible = false;
            nudParcelas.Visible = false;
            txtValorParcela.Visible = false; ;
            txtJuros.Visible = false;
            txtFinal.Visible = false;
            lblFinal.Visible = false;
            bntCalcular.Visible = false;

            double quantidade = Convert.ToDouble(nudQuantidade.Text),
             preco = Convert.ToDouble(txtPreco.Text),
             taxa = Convert.ToDouble(txtTaxa.Text);

            if (rdbVista.Checked)
            {
                Vendas vds = new Vendas(preco, quantidade);
                txtTaxa.Text = " " + vds.ValorVista().ToString();

            }
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtFinal.Clear();
            txtJuros.Clear();
            txtPreco.Clear();
            txtTaxa.Clear();
            txtValorParcela.Clear();
            cbbProduto.ResetText();// não se esqueça
            rbtPrazo.Checked = false; //  não se esquerça
            rdbVista.Checked = false; // não se esquerça
            nudParcelas.Text = "0";
            nudQuantidade.Text = "0";

            


               
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rdbVista_CheckedChanged(object sender, EventArgs e)
        {
            txtFinal.Visible = true;
            lblFinal.Visible = true;
            groupBox2.Visible = false;
            
        }

        private void rbtPrazo_CheckedChanged(object sender, EventArgs e)
        {
            // aparecer
            groupBox2.Visible = true;
            nudParcelas.Visible = true;
            txtValorParcela.Visible = true; ;
            txtJuros.Visible = true;
            bntCalcular.Visible = true;

            // some outro
            txtFinal.Visible = false;
            lblFinal.Visible = false;
            
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            double quantidade = Convert.ToDouble(nudQuantidade.Text), 
                   preco = Convert.ToDouble(txtPreco.Text),
                   taxa = Convert.ToDouble(txtTaxa.Text);

            if (rbtPrazo.Checked)
            {
                Vendas vds = new Vendas(preco, quantidade);
                txtTaxa.Text = " " + vds.ValorPrazo().ToString();

            }

        }

    

        
    }
}
