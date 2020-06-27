using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exer1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalular_Click(object sender, EventArgs e)
        {
            try
            {
                double mensalidade = Convert.ToDouble(txtMensalidade.Text);

                Calcular cal = new Calcular();

                if (rdbMestrado.Checked)
                {
                    cal.mestrado(mensalidade);
                    txtResul.Text = cal.result.ToString();

                }

                if (rdnDoutorado.Checked)
                {
                    cal.doutoradoCal(mensalidade);
                    txtResul.Text = cal.result.ToString();


                }
            }
            catch
            {

                MessageBox.Show("Erro digitação", "Nada nica noca");
                txtMensalidade.Text = " ";
                txtMensalidade.Focus();
            
            }
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtCurso.Text = " ";
            txtMensalidade.Text = " ";
            txtResul.Text = " ";

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
