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
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtEntrada0.Text = " ";
            txtEntrada1.Text = " ";
            txtEntrada2.Text = " ";
            txtEntrada3.Text = " ";
            txtEntrada4.Text = " ";
            txtEntrada5.Text = " ";
            txtMaiorPreco.Text = " ";
            txtMenorPreco.Text = " ";
            
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                double[] vetPreco;
                double maior = 0, menor = 0;

                vetPreco = new double[6]; // quantidades não se esqueça veio dessa sintaxe

                vetPreco[0] = Convert.ToDouble(txtEntrada0.Text);
                vetPreco[1] = Convert.ToDouble(txtEntrada1.Text);
                vetPreco[2] = Convert.ToDouble(txtEntrada2.Text);
                vetPreco[3] = Convert.ToDouble(txtEntrada3.Text);
                vetPreco[4] = Convert.ToDouble(txtEntrada4.Text);
                vetPreco[5] = Convert.ToDouble(txtEntrada5.Text);

                for (int i = 0; i < 6; i++)
                {
                    if (vetPreco[i] > maior)
                    {
                        maior = vetPreco[i];
                        txtMaiorPreco.Text = Convert.ToString(maior);

                    }
                    else
                    {

                        menor = vetPreco[i];
                        txtMenorPreco.Text = Convert.ToString(menor);
                    }

                }
            }
            catch
            {
                MessageBox.Show("Coloque número", "Erro na digitação");



            }
        
        }

        
    }
}
