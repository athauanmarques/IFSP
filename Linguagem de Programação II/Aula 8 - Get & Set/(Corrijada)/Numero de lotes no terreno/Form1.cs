using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {

                double areaTerreno = Convert.ToDouble(txtAreaTerreno.Text);
                double frenteLote = Convert.ToDouble(txtLoteFrente.Text);
                double lateralLote = Convert.ToDouble(txtLateralLote.Text);

                Casas casas = new Casas();

                txtAreaLote.Text = "" + casas.AreaDoLote(lateralLote , frenteLote);

                txtTotalLotes.Text = "" + casas.NumeroLote(areaTerreno);

                txtCasa.Text = "" + casas.AreaCasa();
                txtCozinha.Text = "" + casas.AreaCozinha();
                txtSala.Text = "" + casas.AreaSala();
                txtQuarto.Text = "" + casas.AreaQuarto();
                txtBanheiro.Text = "" + casas.AreaBanheiro();
                txtAreaServico.Text = "" + casas.AreaDeServico();

            }
            catch 
            {
                lblErro.Text = "Preencha os dados corretamente!";
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAreaLote.Text = "";
            txtAreaTerreno.Text = "";
            txtLateralLote.Text = "";
            txtLoteFrente.Text = "";
            txtTotalLotes.Text = "";
            txtCasa.Text = "";
            txtCozinha.Text = "";
            txtQuarto.Text = "";
            txtSala.Text = "";
            txtAreaServico.Text = "";
            txtBanheiro.Text = "";
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

       
    }
}
