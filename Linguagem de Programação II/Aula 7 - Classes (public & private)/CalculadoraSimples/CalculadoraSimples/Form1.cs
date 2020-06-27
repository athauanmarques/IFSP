using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CalculadoraSimples
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            try
            {
                double num1 = Convert.ToDouble(txtNum1.Text);
                double num2 = Convert.ToDouble(txtNum2.Text);

                if()//especificar erro

                Calcula c = new Calcula(); //distanciar sempre para ultiza a classe

                c.Soma(num1, num2);//pegando valores dessa parametro

                txtRes.Text = c.result.ToString();// pegando o resultado da classe 'c' e convertendo para string
            }
            catch
            {

                MessageBox.Show("Erro Rapaz informe números", "Erro");
                txtNum1.Focus()
            
            }
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            try{
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            Calcula c = new Calcula();

            c.subtracao(num1, num2);

            txtRes.Text = c.result.ToString();
            }
            catch
            {

                MessageBox.Show("Erro Rapaz informe números", "Erro");

            }
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            try{
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);

            Calcula c = new Calcula();

            c.mutiplicacao(num1, num2);

            txtRes.Text = c.result.ToString();
            }
            catch
            {

                MessageBox.Show("Erro Rapaz informe números", "Erro");

            }
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            try{
            double num1 = Convert.ToDouble(txtNum1.Text);
            double num2 = Convert.ToDouble(txtNum2.Text);
            Calcula c = new Calcula();

            c.divisao(num1, num2);

            txtRes.Text = c.result.ToString();
            }
            catch
            {

                MessageBox.Show("Erro Rapaz informe números", "Erro");

            }


        }

        private void btnResto_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNum1.Text);
            double numero2 = Convert.ToDouble(txtNum2.Text);

            Calcula calcular = new Calcula();

            calcular.resto(numero1, numero2);
            txtRes.Text = calcular.result.ToString();
        }
    }
}
