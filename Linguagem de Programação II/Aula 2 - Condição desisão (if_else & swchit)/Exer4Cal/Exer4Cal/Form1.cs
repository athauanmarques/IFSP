using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void bntSoma_Click(object sender, EventArgs e)
        {
            //double valor1 = 0, v2 = 0, soma = 0;

            //valor1 = Convert.ToDouble(txtValor1.Text);
            //v2 = Convert.ToDouble(txtValor2.Text);

            //soma = valor1 + v2;

            //lblResult.Text = soma.ToString();

            double valor1 = Convert.ToDouble(txtValor1.Text);
            double v2 = Convert.ToDouble(txtValor2.Text);
            double soma = valor1 + v2;

            lblResult.Text = string.Format("{0:F2}", soma);// sintaxe para converte em string, o resultado aparecendo com 2 numeros decimais
        }

        private void bntSub_Click(object sender, EventArgs e)
        {
            double valor1 = 0, v2 = 0, sub = 0;

            valor1 = Convert.ToDouble(txtValor1.Text);
            v2 = Convert.ToDouble(txtValor2.Text);

            sub = valor1 - v2;

            lblResult.Text = sub.ToString();
        }

        private void bntDividir_Click(object sender, EventArgs e)
        {
            double valor1 = 0, v2 = 0, div = 0;

            valor1 = Convert.ToDouble(txtValor1.Text);
            v2 = Convert.ToDouble(txtValor2.Text);

            div = valor1 / v2;

            lblResult.Text = div.ToString();
        }

        private void bntMult_Click(object sender, EventArgs e)
        {
            double valor1 = 0, v2 = 0, mult = 0;

            valor1 = Convert.ToDouble(txtValor1.Text);
            v2 = Convert.ToDouble(txtValor2.Text);

            mult = valor1 * v2;

            lblResult.Text = mult.ToString();
        
        } 
    }
}
