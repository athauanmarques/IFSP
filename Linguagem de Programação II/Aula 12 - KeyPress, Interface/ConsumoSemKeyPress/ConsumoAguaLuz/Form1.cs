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
            if (txtAnteriorE.Text == "")
            {
                MessageBox.Show("Campo Leitura Anterior Vazio");
                txtAnteriorE.Focus();
            }
            else if (txtAtualE.Text == "")
            {
                MessageBox.Show("Campo Leitura Atual Vazio");
                txtAtualE.Focus();
            }
            else
            {
                int ant = Convert.ToInt32(txtAnteriorE.Text);
                int atual = Convert.ToInt32(txtAtualE.Text);

                Luz l = new Luz(ant, atual);
                lblKwh.Text = l.ConsumoLuz().ToString("#,##0.00");
                lblReais.Text = l.ConsumoReais().ToString("#,##0.00");
                lblPis.Text = l.CalculaPis().ToString("#,##0.00");
                lblConfins.Text = l.CalculaCofins().ToString("#,##0.00");
                lblIcms.Text = l.CalculaIcms().ToString("#,##0.00");
                lblValorE.Text = l.CalculaTotal().ToString("#,##0.00");
            }
        }

        private void btnLimparE_Click(object sender, EventArgs e)
        {
            txtAnteriorE.Text = "";
            txtAtualE.Text = "";
            lblKwh.Text = "";
            lblReais.Text = "";
            lblPis.Text = "";
            lblConfins.Text = "";
            lblIcms.Text = "";
            lblValorE.Text = "";
            txtAnteriorE.Focus();
        }

        private void btnSairE_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCalcularA_Click(object sender, EventArgs e)
        {
            if (txtAnteriorA.Text == "")
            {
                MessageBox.Show("Campo Leitura Anterior Vazio");
                txtAnteriorA.Focus();
            }
            else if (txtAtualA.Text == "")
            {
                MessageBox.Show("Campo Leitura Atual Vazio");
                txtAtualA.Focus();
            }
            else
            {
                int ant = Convert.ToInt32(txtAnteriorA.Text);
                int atual = Convert.ToInt32(txtAtualA.Text);

                Agua a = new Agua(ant, atual);
                lblMetros.Text = a.ConsumoAgua().ToString("#,##0.00");
                lblLitro.Text = a.ConsumoLitros().ToString("#,##0.00");
                lblValorA.Text = a.ConsumoReais().ToString("#,##0.00");
            }
        }

        private void btnLimparA_Click(object sender, EventArgs e)
        {
            txtAnteriorA.Text = "";
            txtAtualA.Text = "";
            lblMetros.Text = "";
            lblLitro.Text = "";
            lblValorA.Text = "";
        }

        private void btnSairA_Click(object sender, EventArgs e)
        {
            Close();
        }



        private void txtAnteriorE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(Asc(e.KeyChar.ToString()) < Asc("0") || // 0 = 48 na tabela
                Asc(e.KeyChar.ToString()) > Asc("9")) // 9 = 57 na tabela
            {
                if (Asc(e.KeyChar.ToString()) != 8)
                {
                
                    e.KeyChar = Chr(0);
                
                }
            }
     
        }

        //função Asc - não permite o usuário digitar caracteres
        private int Asc(string letra) // vai pegar o que o usário digitou
        {

            return (int)(Convert.ToChar(letra));
        
        }
        //função Chr()
        private char Chr(int codigo) // pega um nuémro e transforma em caracter, faz um processo contrário do Asc.
        {

            return (char)codigo; // retona 0 e "trava a tela" não parece nada tela

        }

        private void txtAnteriorA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Asc(e.KeyChar.ToString()) < Asc("0") || // 0 = 48 na tabela
               Asc(e.KeyChar.ToString()) > Asc("9")) // 9 = 57 na tabela
            {
                if (Asc(e.KeyChar.ToString()) != 8)
                {

                    e.KeyChar = Chr(0);

                }
            }
                
        }







    }
}
