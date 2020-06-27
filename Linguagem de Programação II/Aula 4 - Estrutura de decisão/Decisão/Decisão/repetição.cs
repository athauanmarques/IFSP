using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Decisão
{
    public partial class repetição : Form
    {
        public repetição()
        {
            InitializeComponent();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtNum.Text = " ";
            rtxTexto.Text = " ";
        }

        private void bntFor_Click(object sender, EventArgs e)
        {
            int i, num = Convert.ToInt32(txtNum.Text);

            if (num > 90) 
            
            {

                MessageBox.Show("numero inválido");
                rtxTexto.Text = " ";
            }

            else if (num <= 90)
            {

                for (i = num; i <= 100; i++)
                {
                    if (i % 2 == 0)
                    {
                        rtxTexto.Text += Convert.ToString(" " + i + " - ");
                    }

                }
            }
        }

        private void bntWhile_Click(object sender, EventArgs e)
        {
            
            int num = Convert.ToInt32(txtNum.Text);

            if (num > 90)
            {

                MessageBox.Show("numero inválido");
                rtxTexto.Text = " ";
            }

            else if (num <= 91)
            {

                while (num <= 100)
                {
                    if (num % 2 == 0)
                    {
                        rtxTexto.Text += Convert.ToString(" " + num + " - ");

                    }

                    num++;
                }

            }
        }

        private void bntDoWhile_Click(object sender, EventArgs e)
        {
            int i = Convert.ToInt32(txtNum.Text);

            if (i > 90)
            {

                MessageBox.Show("numero inválido");
                rtxTexto.Text = " ";
            }

            else if (i <= 90)
            {

                do
                {
                    if (i % 2 == 0)
                    {
                        rtxTexto.Text += Convert.ToString(" " + i + " - ");

                    }

                    i++;

                } while (i <= 100);

            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
