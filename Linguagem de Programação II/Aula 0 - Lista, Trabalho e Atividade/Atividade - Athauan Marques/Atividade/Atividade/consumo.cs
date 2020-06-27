using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade
{
    public partial class consumo : Form
    {
        public consumo()
        {
            InitializeComponent();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtConsumo.Text = " ";
            txtDistanciaResult.Text = " ";
            txtfinal.Text = " ";
            txtGastoResult.Text = " ";
            txtInicial.Text = " ";

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double kiloIncial = Convert.ToDouble(txtInicial.Text),
                       kiloFinal = Convert.ToDouble(txtfinal.Text),
                       consumo = Convert.ToDouble(txtConsumo.Text),
                       distancia_percorrida, gasto_Resultado;



                txtDistanciaResult.Text = Convert.ToString(distancia_percorrida = kiloFinal - kiloIncial);
                txtGastoResult.Text = Convert.ToString(gasto_Resultado = distancia_percorrida * consumo);

            }
            catch 
            {

                MessageBox.Show("Valor inválido");

            
            
            }
           
           
           
           
           }


       
    }
}
