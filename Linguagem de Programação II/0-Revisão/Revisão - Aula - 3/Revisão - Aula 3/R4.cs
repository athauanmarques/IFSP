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
    public partial class R4 : Form
    {
        public R4()
        {
            InitializeComponent();
        }

        private void bntMaius_Click(object sender, EventArgs e)
        {
            lblMaiuscula.Text = txtLetra.Text.ToUpper();
        }

        private void bntMini_Click(object sender, EventArgs e)
        {
            lblMinuscula.Text = txtLetra.Text.ToLower();
        }

        private void bntContar_Click(object sender, EventArgs e)
        {

            lblQuant.Text = "";
            lblQuant.Text = Convert.ToString(txtLetra.Text.Length);
          
        }

        private void bntReplace_Click(object sender, EventArgs e)
        {
            lblReplace.Text = txtLetra.Text.Replace("p", "g");
        }

        private void bntSub_Click(object sender, EventArgs e)
        {
            lblSub.Text = txtLetra.Text.Substring(5, 3);
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

      
       
    }
}
