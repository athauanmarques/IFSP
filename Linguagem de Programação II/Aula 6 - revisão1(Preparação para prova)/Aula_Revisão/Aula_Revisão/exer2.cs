using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula_Revisão
{
    public partial class exer2 : Form
    {
        public exer2()
        {
            InitializeComponent();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtQtsEntrada.Text = " ";
            txtQtsResult.Text = " ";
            txtTotal.Text = " ";
            rdbJuca.Checked = false;
            rdbTuca.Checked = false;
            txtQtsEntrada.Focus();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                double quantidadeTinta = Convert.ToDouble(txtQtsEntrada.Text),
                        qtsTinta, totalGasto;

                if (rdbJuca.Checked)
                {

                    qtsTinta = 145 / quantidadeTinta;
                    totalGasto = 90 * qtsTinta;
                    txtQtsResult.Text = Convert.ToString(qtsTinta);
                    txtTotal.Text = Convert.ToString(totalGasto);

                }

                if (rdbTuca.Checked)
                {
                    qtsTinta = 180 / quantidadeTinta;
                    totalGasto = 145 * qtsTinta;
                    txtQtsResult.Text = Convert.ToString(qtsTinta);
                    txtTotal.Text = Convert.ToString(totalGasto);


                }
            }
            catch
            {

                MessageBox.Show("Informe numeros", "Erro na digitação");
            
            }



        }
    }
}
