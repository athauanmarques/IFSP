using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;

namespace PizzariaMania
{
    public partial class frmAjuda : MetroForm
    {
        public frmAjuda()
        {
            InitializeComponent();
        }
        private void CheatClienteVen()
        {
            listNotificacao.Items.Add(Globais.strUsuario +" Diz: " + txtMensagem.Text);

            if (txtMensagem.Text == "Olá")
            {
               
                listNotificacao.Items.Add("\nChefinho diz: Olá Tudo bem? o que posso te ajudar?");

            }
            else if (txtMensagem.Text == "Babaca")
            {

                listNotificacao.Items.Add("\nChefinho diz: Vai cagar aprende mexer no computador?");
            }

            else if (txtMensagem.Text == "Sei mexer")
            {

                listNotificacao.Items.Add("\nChefinho diz: Você é tão burro, mas tão burro até da vontade de chorar. ");
            }

            else if (txtMensagem.Text == "Tonto")
            {

                listNotificacao.Items.Add("\nChefinho diz:É a sua mãe gorda em cima da pia.");
            }
            
            else
            {

                listNotificacao.Items.Add("\nChefinho diz: Infelizmente não posso te ajudar, \n pois eu não sei. ");
            }
        }
        private void frmAjuda_Load(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bntEnviar_Click(object sender, EventArgs e)
        {
            CheatClienteVen();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            listNotificacao.Items.Clear();
        }

        private void bntCadastro_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado: Uma boa pergunda, eu também não sei, fera.";
        }

        private void bntPedidos_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado: Se você não sabe imagine eu. ";
        }

        private void bntRelatorios_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "Resultado: hum...É um relatório (eu acho).";
        }

        private void listNotificacao_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
