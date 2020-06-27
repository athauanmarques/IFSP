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
    public partial class Exerc2 : Form
    {
        public Exerc2()
        {
            InitializeComponent();
        }       

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double quantPintada;
                quantPintada = Convert.ToDouble(txtQtd.Text);

                if (rdbJuca.Checked)
                {
                    double preco = 90;
                    double rendimento = 145;

                    double qtdeTinta = quantPintada /rendimento;
                    double gasto = preco * qtdeTinta;                                       

                    //2 tipos de formatação para numero real n
                    lblQuantidade.Text = qtdeTinta.ToString("#,##0");
                    lblTotal.Text = String.Format("{0:F2}",gasto);
                   
                }
                else if (rdbTuca.Checked)
                {
                    double preco = 145;
                    double rendimento = 180;
 
                    lblQuantidade.Text = (quantPintada / rendimento).
                        ToString("#,##0");
                    
                    lblTotal.Text = (preco * (quantPintada / rendimento)).
                        ToString("#,##0.00");
                }
                else
                {
                    throw new InvalidOperationException("Selecione o tipo de Tinta");
                }
            }
            catch (InvalidOperationException ioEx)
            {
                MessageBox.Show(ioEx.Message);
            }
        }
        

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtQtd.Text = "";
            lblQuantidade.Text = "";
            lblTotal.Text = "";
            rdbJuca.Checked = false;
            rdbTuca.Checked = false;
            txtQtd.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
