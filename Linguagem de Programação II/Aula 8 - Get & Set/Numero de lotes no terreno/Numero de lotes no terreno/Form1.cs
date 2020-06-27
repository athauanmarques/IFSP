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

                //instancia a classe - criando objeto

                Casas ClaCasa = new Casas();
               
                //visualizar valores
                txtAreaLote.Text = ClaCasa.AreaLotes(lateralLote, frenteLote).ToString();
                txtTotalLotes.Text = " " + ClaCasa.NumLote(areaTerreno).ToString();
                txtCasa.Text = " " + ClaCasa.CalCasa();
                txtBanheiro.Text = "" + ClaCasa.CalBanheiro();
                txtCozinha.Text = " " + ClaCasa.CalCozinha();
                txtQuarto.Text = " " + ClaCasa.QuartoCal();
                txtServico.Text = " " + ClaCasa.CalServico();
                txtSala.Text = " " + ClaCasa.CalSala();
                
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

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
    }
}
