using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace cal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntSoma_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);

            Calcular cal = new Calcular();

            cal.soma(num1, num2);
            txtResultado.Text = cal.result.ToString();

        }

        private void bntSubtracao_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);

            Calcular cal = new Calcular();

            cal.sub(num1, num2);
            txtResultado.Text = cal.result.ToString();
        }

        private void bntMultiplicacao_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);

            Calcular cal = new Calcular();

            cal.mul(num1, num2);
            txtResultado.Text = cal.result.ToString();
        }

        private void bntDivisao_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);

            Calcular cal = new Calcular();

            cal.div(num1, num2);
            txtResultado.Text = cal.result.ToString();
        }

        private void bntResto_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);

            Calcular cal = new Calcular();

            cal.resto(num1, num2);
            txtResultado.Text = cal.result.ToString();
        }

        private void bntPotenciacao_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(txtNumero1.Text);
            double num2 = Convert.ToDouble(txtNumero2.Text);

            Calcular cal = new Calcular();

            cal.pot(num1, num2);
            txtResultado.Text = cal.result.ToString();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Text = " ";
            txtNumero2.Text = " ";
            txtNumero1.Text = " ";
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
