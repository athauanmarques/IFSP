using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lista1
{
    public partial class Media2 : Form
    {
        public Media2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double mediaTeoria = Convert.ToDouble(txtTeste1.Text), resultTeoria, mediaFinalT,
                   mediaTeoria2 = Convert.ToDouble(txtTeste2.Text),
                   tra1 = Convert.ToDouble(txtTra1.Text), resultPratica, mediaFinaP, mediaTotal,
                   tra2 = Convert.ToDouble(txtTra2.Text),
                   tra3 = Convert.ToDouble(txtTra3.Text),
                   tra4 = Convert.ToDouble(txtTra4.Text);

            if (mediaTeoria2 <= 10 && mediaTeoria <= 10 && tra1 <= 10 && tra2 <= 10 && tra3 <= 10 && tra4 <= 10)
            {


            resultTeoria = (mediaTeoria + mediaTeoria2) / 2;
            mediaFinalT = resultTeoria * 1.7;

            resultPratica = (tra1 + tra2 + tra3 + tra4) / 4;
            mediaFinaP = resultPratica * 1.3;


            mediaTotal = mediaFinaP + mediaFinalT;

            txtResul.Text = Convert.ToString(mediaTotal);
            }
            else
            {
            
                MessageBox.Show("Valor inválido - Informe valores a baixo de 10");
                txtResul.Text = " ";
                txtTeste1.Text = " ";
                txtTeste2.Text = " ";
                txtTra1.Text = " ";
                txtTra2.Text = " ";
                txtTra3.Text = " ";
                txtTra4.Text = " ";
                
            }

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtResul.Text = " ";
            txtTeste1.Text = " ";
            txtTeste2.Text = " ";
            txtTra1.Text = " ";
            txtTra2.Text = " ";
            txtTra3.Text = " ";
            txtTra4.Text = " ";
        }
    }
}
