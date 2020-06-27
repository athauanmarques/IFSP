using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXER1_Matriz
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnVerificaL_Click(object sender, EventArgs e)
        {
            char c = txtLetraUsa.Text[0];

            if (char.IsLetter(c)) //conta por caracter por caracter
            {
                if (char.IsLower(c)) // converte letras para Minusculas 
                {
                    lblStatusL.Text = "Letra minuscula";

                }
                    else
                {

                    lblStatusL.Text = "Letra maiscula";

                }
              }
               
            else

                {
                
                    lblStatusL.Text = "Redidige. Não é uma Letra";
                    txtCaracUsa.Text = "";
                    txtCaracUsa.Focus(); 
                    //vai foca o curso na propriedade: txtCaracUsa
                
                }

        }

        private void bntVerificaC_Click(object sender, EventArgs e)
        {
            
            char c = txtCaracUsa.Text[0];

            if (char.IsLetter(c)) 
            {
              //  lblStatus.Text = "É uma letra.";
                  lblStatusC.Text = "é uma Letra";
            }
            else if (char.IsNumber(c)) // verifica o char é Numero
            {
                //lblStatusCarac.Text = "É um número.";
                lblStatusC.Text = "É um número";
            }
            else if (char.IsPunctuation(c)) // verfiaca á pontuação
            {
                //lblStatusCarac.Text = "É uma pontuação.";
                lblStatusC.Text = "É uma pontuação";
            }
        }
        

    }
}
