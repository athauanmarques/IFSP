using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula_Revisão
{
    public partial class exer3 : Form
    {
        public exer3()
        {
            InitializeComponent();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtJurosResult.Text = "";
            txtParcelas.Text = "";
            txtPrestencaoResult.Text = "";
            txtPreco.Text = "";
            txtPrecoFinal.Text = "";
            txtTaxaJuros.Text = "";
            ccbProduto.Items.Add("");
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            //Calculo
// PF = preço * (1 + taxa)N
//Onde N é o número de parcelas do financiamento.
//Juros = PF - preço
//Prestação = PF/nº parcelas


            try
            {
                double preco = Convert.ToDouble(txtPreco.Text);
                double taxa = Convert.ToDouble(txtTaxaJuros.Text);
                double n = Convert.ToDouble(txtParcelas.Text);
                double precoFinal = 0, tx= 0, juros = 0, prestacao=0;

                tx = Math.Pow((1 + taxa), n);
                txtPrecoFinal.Text = Convert.ToString(precoFinal= preco * tx);
                // não se esqueça do Math.Pow(base,expoente);

                txtJurosResult.Text = Convert.ToString(juros = precoFinal - preco);
                txtPrestencaoResult.Text = Convert.ToString(prestacao = precoFinal / n);
            }
            catch
            {

                MessageBox.Show("Informe números", "Erro na digitação");
            
            }
    

        }

        private void exer3_Load(object sender, EventArgs e)
        {
            ccbProduto.Items.Add("PlayStadio 4");
            ccbProduto.Items.Add("Ultrabook");
            ccbProduto.Items.Add("Notebook");
            ccbProduto.Items.Add("Smartphones");
            ccbProduto.Items.Add("Hd externo");
            ccbProduto.Items.Add("Pendrive");

        }

        
    }
}
