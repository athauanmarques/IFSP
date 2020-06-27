using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExercFixacao
{
    public partial class Exerc3 : Form
    {
        public Exerc3()
        {
            InitializeComponent();
        }

        //private double Preco(string produto)
        //{ 
        //    double preco;
        //    if(cbxProd.SelectedIndex[0])
        //    {
        //        preco = 1.200,00;
        //    }
        //    return preco;
        //}

        private void Exerc3_Load(object sender, EventArgs e)
        {
            cbxProd.Items.Add("Notebook");
            cbxProd.Items.Add("Ultrabook");
            cbxProd.Items.Add("Tablet");
            cbxProd.Items.Add("Celular");
            cbxProd.Items.Add("Hd Externo");
            cbxProd.Items.Add("Pendrive");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /*PF = preço * (1 + taxa)N
            Onde N é o número de parcelas do financiamento.
            Juros = PF - preço
            Prestação = PF/nº parcelas
             */
            double preco = Convert.ToDouble(txtPreco.Text);
            double parcelas = Convert.ToDouble(txtParcelas.Text);
            double taxa = Convert.ToDouble(txtTaxa.Text);
            double juros = 0;
            double valorPrest = 0;
            double valorFinal = 0;

            double tx = Math.Pow((1 + taxa),parcelas);
            valorFinal = preco * tx;
            juros = valorFinal - preco;
            valorPrest = valorFinal / parcelas;

            txtPreFinal.Text = valorFinal.ToString();
            txtJuros.Text = juros.ToString();
            txtValPres.Text = valorPrest.ToString();
            lblStatus.Text = tx.ToString();


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
