using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Consumo_Agua_Luz
{
    public partial class Form1 : Form
    {
      
        

        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalcularB_Click(object sender, EventArgs e)
        {
            int anteriorB = Convert.ToInt32(txtLeituraAntB.Text);
            int atualB = Convert.ToInt32(txtLeituraAtuB.Text);

            Agua a = new Agua (anteriorB, atualB);

            txtConsumo3mB.Text = a.ConsumoB().ToString();
            txtConsumoRsB.Text = a.ResultadoB().ToString();
            txtConsumoLitB.Text = a.ConsumoLitro().ToString();


        }

        private void bntCalcularA_Click(object sender, EventArgs e)
        {
            int anterior = Convert.ToInt32(txtLeituraAntA.Text);
            int atual = Convert.ToInt32(txtLeituraAtuA.Text);

            Eletrica e = new Eletrica();

            txtConsumoKwhA.Text = e.Luz(anterior, atual).ToString("#,##0.00");
            txtConsumoRsA.Text = e.ConsumoReais().ToString("#,##0.00");
            txtConfinsA.Text = e.CalcularConfins().ToString("#,##0.00");
            txtValorPisA.Text = e.ConsumoPis().ToString("#,##0.00");
            txtValorTotalA.Text = e.CalcularTotal().ToString("#,##0.00");
            txtValorIcmsA.Text = e.CalculaIcms().ToString("#,##0.00");
        }

        private void txtLeituraAntB_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

    
        
    }
}
