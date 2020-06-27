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
    public partial class Exerc1 : Form
    {
        public Exerc1()
        {
            InitializeComponent();
        }
        private void btnLimpa_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
            txtMaior.Text = "";
            txtMenor.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            // double[] vetPreco= new double[5];
            double[] vetPreco;
            double maior=0, menor=0;

            vetPreco = new double[6];
                        
            vetPreco[0] = Convert.ToDouble(txt1.Text);
            vetPreco[1] = Convert.ToDouble(txt2.Text);
            vetPreco[2] = Convert.ToDouble(txt3.Text);
            vetPreco[3] = Convert.ToDouble(txt4.Text);
            vetPreco[4] = Convert.ToDouble(txt5.Text);
            vetPreco[5] = Convert.ToDouble(txt6.Text);

            for (int i = 0; i < 6; i++)
            {
                if ((menor > vetPreco[i]) || (i==0))
                {
                    menor = vetPreco[i];
                }
                if (maior < vetPreco[i])
                {
                    maior = vetPreco[i];
                }
            }
            txtMaior.Text = maior.ToString();
            txtMenor.Text = menor.ToString();
        }

        
    }
}
