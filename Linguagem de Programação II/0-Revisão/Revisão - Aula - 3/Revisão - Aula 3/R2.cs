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
    public partial class R2 : Form
    {
        public R2()
        {
            InitializeComponent();
        }

        private void bntResult_Click(object sender, EventArgs e)
        {
            string email = txtSite.Text;

            int tamanho = email.Length;
            lblTamanho.Text = "Tamanho = " + Convert.ToString(tamanho);

            int result = email.IndexOf("@");//localicar um caracter especifico neste caso é "@"

            if (result == -1)
            {
                lblDomi.Text = "Email Invalido";
                txtSite.Text = " ";
                txtSite.Focus();

            } else {

                lblNome.Text = "Nome " + email.Substring(0, result);
                lblDomi.Text = "Domino:" + email.Substring(result + 1);
                lblstatus.Text = "Status invalido";

            }


        }

       
    }
}
