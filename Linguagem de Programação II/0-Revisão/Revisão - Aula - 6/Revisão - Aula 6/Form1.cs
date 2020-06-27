using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntMostrar_Click(object sender, EventArgs e)
        {
            try
            {
                double [] vetNumero;
                double maior, menor=0;

                vetNumero = new double[6];

                vetNumero[0] = Convert.ToDouble(txt0.Text);
                vetNumero[1] = Convert.ToDouble(txt1.Text);
                vetNumero[2] = Convert.ToDouble(txt2.Text);
                vetNumero[3] = Convert.ToDouble(txt3.Text);
                vetNumero[4] = Convert.ToDouble(txt4.Text);
                vetNumero[5] = Convert.ToDouble(txt5.Text);

                for (int i = 0; i < 6; i++)
                {

                    if (menor < vetNumero[i] || i == 0)
                    {

                        menor = vetNumero[i];
                        txtMenor.Text = Convert.ToString(menor);

                    }

                    else 
                    {

                        maior = vetNumero[i];
                        txtMenor.Text = Convert.ToString(maior);

                    
                    }
                
                }

                
              
            }
            catch
            {

                MessageBox.Show("erro");

            
            
            }



        }
    }
}
