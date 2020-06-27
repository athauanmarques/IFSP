using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Calc : Form
    {
        public Calc()
        {
            InitializeComponent();
        }

        private void Calc_Load(object sender, EventArgs e)
        {

        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                double vlr1 = 0, vlr2 = 0;
                double result = 0;
                vlr1 = Convert.ToDouble(txtValor1.Text);
                vlr2 = Convert.ToDouble(txtValor2.Text);

                result = vlr1 / vlr2;

                lblResul.Text = "Resultado= " + result.ToString("0.00");
            }
            catch(Exception b) // Exception é mensagem de erro do Visual
            {

                MessageBox.Show(b.Message);

            }

            finally
            { 
            
                
            }

        }
    }
}
