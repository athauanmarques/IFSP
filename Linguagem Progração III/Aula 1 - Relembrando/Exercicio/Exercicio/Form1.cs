using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Exercicio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntSoma_Click(object sender, EventArgs e)
        {
            try
            {
                double n1 = Convert.ToDouble(txtN1.Text), n2 = Convert.ToDouble(txtN2.Text), total;

                total = n1 + n2;

                txtResultado.Text = Convert.ToString(total);
            }
            catch 
            {

                MessageBox.Show("Por favor informe números");
            }

        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();
            txtN1.Clear();
            txtN2.Clear();
            txtN1.Focus();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtN1.Focus();
        }
    }
}
