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
    public partial class frmOrdenacao : Form
    {
        public frmOrdenacao()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtNumero1.Text = " ";
            txtNumero2.Text = " ";
            txtResultMenor.Text = " ";
            txtResutMaior.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
            double numero1 = Convert.ToDouble(txtNumero1.Text),
                   numero2 = Convert.ToDouble(txtNumero2.Text);
            
            
                if (numero1 > numero2)
                {
                    txtResutMaior.Text = Convert.ToString(numero1);
                    txtResultMenor.Text = Convert.ToString(numero2);

                }
                else
                {
                    txtResutMaior.Text = Convert.ToString(numero2);
                    txtResultMenor.Text = Convert.ToString(numero1);

                }

            }
            catch
            {

                MessageBox.Show("Valor inválido");
            
            }

        } 

        
    }
}
