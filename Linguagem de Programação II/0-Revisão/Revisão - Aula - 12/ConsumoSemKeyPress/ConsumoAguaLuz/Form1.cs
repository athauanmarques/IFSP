using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConsumoAguaLuz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Calcula Energia
        private void btnCalcularE_Click(object sender, EventArgs e)
        {
           
        }

        private void btnLimparE_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSairE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcularA_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLimparA_Click(object sender, EventArgs e)
        {
            txtAnteriorA.Text = "";
            txtAtualA.Text = "";
            txtMetrosA.Text = "";
            txtLitroA.Text = "";
            lblValorA.Text = "";
        }

        private void btnSairA_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void txtAnteriorE_KeyPress(object sender, KeyPressEventArgs e)
        {
            
     
        }

       

        private void txtAnteriorA_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            
                
        }







    }
}
