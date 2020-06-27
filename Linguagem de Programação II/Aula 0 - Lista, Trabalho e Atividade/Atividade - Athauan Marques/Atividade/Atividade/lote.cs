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
    public partial class lote : Form
    {
        public lote()
        {
            InitializeComponent();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtArea.Text = " ";
            txtFrontal.Text = " ";
            txtLateral.Text = " ";
            txtN_de_lote.Text = " ";
            txtTotalArea.Text = " ";

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double valorArea = Convert.ToDouble(txtArea.Text),
                        valorFrontal = Convert.ToDouble(txtFrontal.Text),
                        valorLateral = Convert.ToDouble(txtLateral.Text),
                        loteTotal, areaResult;

                areaResult = valorFrontal * valorLateral;
                txtTotalArea.Text = Convert.ToString(areaResult);


                loteTotal = areaResult / valorArea;
                txtN_de_lote.Text = Convert.ToString(loteTotal);
            }
            catch 
            
            {

                MessageBox.Show("Valor inválido");
            
            }

        }

       

       
    }
}
