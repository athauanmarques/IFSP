using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exer2_nota
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double nota;
            nota = Convert.ToDouble(txtNotas.Text);
            if (nota < 0 || nota > 10)
            {

                lblMostrar.Text = "Erro nota invalida";
                txtNotas.Text = " ";
                txtNotas.Focus();

            }
            else
            {
                if (nota < 5)
                {

                    lblMostrar.Text = "Resultado: Reprovado";
                    txtNotas.Focus();
                }
                if (nota < 7)
                {

                    lblMostrar.Text = "Resultado: Recuperação";
                    txtNotas.Focus();
                }

                if (nota >= 7 && nota <= 10)
                {

                    lblMostrar.Text = "Resultado: Aprovado";
                    txtNotas.Focus();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
