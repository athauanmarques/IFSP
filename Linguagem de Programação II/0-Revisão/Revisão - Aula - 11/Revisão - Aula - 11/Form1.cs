using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula___11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalcularL_Click(object sender, EventArgs e)
        {


            if (txtLeituraAntL.Text == " ")
            {
                MessageBox.Show("Informe valor no campo leitura anterior", "Valor vazio");
               
                txtLeituraAntL.Focus();


            }

            else if (txtLeituraAtuL.Text == " ")
            {
                MessageBox.Show("Informe valor no campo leitura Atual", "Valor vazio");
                
                txtLeituraAtuL.Focus();


            }

            else
            {
                int anterior = Convert.ToInt32(txtLeituraAntL.Text);
                int atual = Convert.ToInt32(txtLeituraAtuL.Text);

                if (anterior < atual)
                {

                    MessageBox.Show("A leitura anterior deve maior do a Leitura Atual", "Erro de Leitura");
                    txtLeituraAntL.Clear();
                    txtLeituraAntL.Focus();

                }


                Luz l = new Luz(anterior, atual);

                txtConsumoKhwL.Text = l.ConsumoKwh().ToString("#,##0.00");
                txtConfinsL.Text = l.Confins().ToString("#,##0.00");
                txtCosumoRsL.Text = l.Reais().ToString("#,##0.00");
                txtIcmsL.Text = l.Icms().ToString("#,##0.00");
                txtPisL.Text = l.Pis().ToString("#,##0.00");
                txtTotalL.Text = l.TotalLuz().ToString("#,##0.00");

            }
           
        

        }

        private void bntLimparL_Click(object sender, EventArgs e)
        {
            txtConfinsL.Clear();
            txtConsumoKhwL.Clear();
            txtCosumoRsL.Clear();
            txtIcmsL.Clear();
            txtPisL.Clear();
            txtTotalL.Clear();
            txtLeituraAntL.Clear();
            txtLeituraAtuL.Clear();
            txtLeituraAntL.Focus();
        }

        private void bntSairL_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntCalcularA_Click(object sender, EventArgs e)
        {
            int anterior = Convert.ToInt32(txtAnteriorA.Text);
            int atual = Convert.ToInt32(txtAtualA.Text);

            Agua a = new Agua(anterior, atual);

            txtConsumoLitroA.Text = a.ConsumoLitros().ToString("#,##0.00");
            txtConsumoM3A.Text = a.ConsumoA().ToString("#,##0.00");
            txtConsumoRsA.Text = a.ConsumoRs().ToString("#,##0.00");


        }

        private void bntLimparA_Click(object sender, EventArgs e)
        {
            txtAnteriorA.Clear();
            txtAtualA.Clear();
            txtConsumoLitroA.Clear();
            txtConsumoM3A.Clear();
            txtConsumoRsA.Clear();

        }

        private void bntSairA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        
    }
}
