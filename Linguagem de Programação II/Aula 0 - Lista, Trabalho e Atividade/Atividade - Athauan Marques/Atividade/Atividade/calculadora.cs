using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = " ";
            txtNumero2.Text = " ";
            txtResultado.Text = " ";
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txtNumero1.Text), total,
                       n2 = Convert.ToDouble(txtNumero2.Text);


                if (rbtSoma.Checked)
                {
                    txtResultado.Text = Convert.ToString(total = n1 + n2);

                }

                else if (rbtMult.Checked)
                {
                    txtResultado.Text = Convert.ToString(total = n1 * n2);

                }

                else if (rbtSubtracao.Checked)
                {

                    txtResultado.Text = Convert.ToString(total = n1 - n2);
                   

                }
                else if (rbtDivisao.Checked)
                {
                    txtResultado.Text = Convert.ToString(total = n1 / n2);

                }
                else if (rbtResto.Checked)
                {
                    txtResultado.Text = Convert.ToString(total = n1 % n2);

                }
                else if (rbtPonten.Checked)
                {

                    txtResultado.Text = Convert.ToString(total = Math.Pow(n1, n2));
                    //Math é uma biblioteca de funções, o pow é o comando que vai fazer a ponteciação 

                }
            }
            catch
            {

                MessageBox.Show("Valor inválido");

            }


        
        }

        
    }
}
