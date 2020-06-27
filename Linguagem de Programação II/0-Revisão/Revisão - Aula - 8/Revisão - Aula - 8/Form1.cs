using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula___8
{
    public partial class AreaLote : Form
    {
        Calcular c = new Calcular();

        public AreaLote()
        {
            InitializeComponent();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtBanheiro.Text = " ";
            txtCasa.Text = " ";
            txtCozinha.Text = " ";
            txtFrente.Text = " ";
            txtLateral.Text = " ";
            txtLoteamento.Text = " ";
            txtQuarto.Text = " ";
            txtResultLote.Text = " ";
            txtSala.Text = " ";
            txtServico.Text = " ";
            txtTotalTerreno.Text = " ";
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double terreno = Convert.ToDouble(txtTotalTerreno.Text),
                       frente = Convert.ToDouble(txtFrente.Text),
                       lateral = Convert.ToDouble(txtLateral.Text);

                txtResultLote.Text = " " + c.AreaTotal(frente, lateral); // sempre tem mandar as variaveis do calculo
                txtLoteamento.Text = " " + c.LoteTotal(terreno);
                txtSala.Text = " " + c.AreaSala();
                txtServico.Text = " " + c.AreaServico();
                txtQuarto.Text = " " + c.AreaQuarto();
                txtCozinha.Text = " " + c.AreaCozinha();
                txtCasa.Text = " " + c.AreaCasa();
                txtBanheiro.Text = " " + c.AreaBanheiro();
                




            }
            catch
            {

                MessageBox.Show("Erro entrada de valores", "Informe Números");



            }


        }

       

       
    }
}
