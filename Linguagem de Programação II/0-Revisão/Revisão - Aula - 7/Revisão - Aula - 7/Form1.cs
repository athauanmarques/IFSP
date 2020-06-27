using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aula_7_Revisão
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            double men = Convert.ToDouble(txtMensalidade.Text);

            if (rtbDoutorado.Checked)
            {

                calcular dou = new calcular();

                dou.dr(men);
                txtResult.Text = dou.resultado.ToString();


            }

            if (rtbMensalidada.Checked)
            {

                CalculaMestre mes = new CalculaMestre();
                mes.mestreC(men);
                txtResult.Text = mes.resultado.ToString();
            
            
            }


        }
    }
}
