using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula_3
{
    public partial class R3 : Form
    {
        public R3()
        {
            InitializeComponent();
        }

        private void bntVer1_Click(object sender, EventArgs e)
        {
            char c = txtMens1.Text[0];

            if (char.IsLetter(c)) {

                if (char.IsLower(c))
                {

                    lblStatus1.Text = "é Minuscula";

                }
                else 
                {

                    lblStatus1.Text = "é Maiuscula";
                
                } 
            
            
            
            }
        }

        private void bntVerf2_Click(object sender, EventArgs e)
        {
            char ca = txtMens2.Text[0];

            lblTam.Text= Convert.ToString(txtMens2.Text.Length);

            if (char.IsLetter(ca))
            {

                lblStatus2.Text = "é letra";

            }

            else if (char.IsNumber(ca))
            {

                lblStatus2.Text = "É numero";

            }

            else if (char.IsPunctuation(ca))
            {
                lblStatus2.Text = "é uma pontuação";
            }

            else if (char.IsSymbol(ca))
            {

                lblStatus2.Text = "é um simbolo";
            }


            else if (char.IsWhiteSpace(ca))
            {
                lblStatus2.Text = "espaço";
            }



        }
       
    }
}
