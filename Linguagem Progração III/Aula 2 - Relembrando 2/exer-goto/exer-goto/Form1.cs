using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exer_goto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCal_Click(object sender, EventArgs e)
        {
            try
            {
                double nota = Convert.ToDouble(txtNota.Text);

                if (nota < 0 || nota > 10)
                {

                    lblStatus.Text = "nota invalida";
                    txtNota.Clear();
                    txtNota.Focus();
                }
                else if (nota >= 0 && nota <= 5)
                {

                    lblStatus.Text = "Resultado: reprovado";

                }

                else if (nota > 5 && nota < 7)
                {

                    lblStatus.Text = "Resultado: recuperação";

                }
                else if (nota >= 7 && nota <= 10)
                {

                    lblStatus.Text = "Resultado: aprovado";

                }

            }
            catch
            {

                MessageBox.Show("Por favor informe somente números");
                txtNota.Clear();
                txtNota.Focus();
            
            }
        }
    }
}
