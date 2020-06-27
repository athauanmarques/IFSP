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
    public partial class Semana : Form
    {
        public Semana()
        {
            InitializeComponent();
        }

        private void bntMostrar_Click(object sender, EventArgs e)
        {
            int dia = Convert.ToInt32(txtDia.Text);

            switch (dia) 
            
            { 
                case 1:
                    lblResult.Text = "Domingo";
                    break;
                case 2:
                    lblResult.Text = "Segunda-feira";
                    break;
                case 3:
                    lblResult.Text = "Terça-feira";
                    break;
                case 4:
                    lblResult.Text = "Quarta-feira";
                    break;
                case 5:
                    lblResult.Text = "Quinta-feira";
                    break;
                case 6:
                    lblResult.Text = "Sexta-feira";
                    break;
                case 7:
                    lblResult.Text = "Sabádo";
                    break;
                default:
                    MessageBox.Show("Numero inválido informe outro numero");
                    break;
            
            }


        }
    }
}
