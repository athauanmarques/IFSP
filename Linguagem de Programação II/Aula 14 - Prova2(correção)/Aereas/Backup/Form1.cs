using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*Desenvolva um programa orientado a objetos
 * com herança entre as classes, cujo objetivo
 * final é calcular o valor de uma passagem
 * aérea entre as cidades de Belo Horizonte,
 * Brasilia, Rio de Janeiro e São Paulo.
 * O programa deverá fornecer a distância
 * entre as cidades e calcular o preço da
 * passagem baseado no preço por Km, que deverá 
 * ser de R$2,50 e a distância entre as cidades.
 * O preço da passagem deverá ser calculado com 
 * base no tipo da classe escolhida pelo cliente.
 * A classe Econômica deverá ter um acréscimo de 
 * 10% sobre o preço de custo da passagem. A classe 
 * Executiva deverá ter um acréscimo de 20%
 * sobre o preço de custo e a Primeira Classe
 * deverá ter um acréscimo de 30% sobre o custo.
 * O preço de custo de custo é o produto da distância
 * entre duas cidades e o preço por Km.
 * Distância entre cidades:
 * Belo Horizonte - Brasilia = 800Km
 * Belo Horizonte - Rio de Janeiro = 300Km
 * Belo Horizonte - São Paulo = 450Km
 * Brasilia - Rio de Janeiro = 1100Km
 * Brasilia - São Paulo = 1000Km
 * Rio de Janeiro - São Paulo = 250Km
 * Obs: Se forem escolhidas duas cidades iguais na
 * origem e no destino, a distância deverá ser zero.
 * O programa deverá ter quatro classes:
 * Classe Base: Passagem
 * Classes Derivadas: Economica, Executiva e Primeira Classe.
 * 
*/


namespace Aereas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblPreco.Text = "R$ 2,50";
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            string orig,dest;
            orig = cboOrigem.Text;
            dest = cboDestino.Text;
            
            try
            {
                if (rdbEconomica.Checked)
                {
                    Economica objEconomica;
                    objEconomica = new Economica(orig, dest, rdbEconomica.Checked);
                    lblDistancia.Text = objEconomica.calculaDistancia().ToString("#,##0");
                    lblPassagem.Text = objEconomica.calculoPassagem().ToString("R$ #,##0.00");
                    
                    
                }
                else if (rdbExecutiva.Checked)
                {
                    Executiva objExecutiva;
                    objExecutiva = new Executiva(orig, dest, rdbExecutiva.Checked);
                    lblDistancia.Text = objExecutiva.calculaDistancia().ToString("#,##0");
                    lblPassagem.Text = objExecutiva.calculoPassagem().ToString("R$ #,##0.00");
                }
                else if (rdbPrimeiraClasse.Checked)
                {
                    PrimeiraClasse objPrimeiraClasse;
                    objPrimeiraClasse = new PrimeiraClasse(orig, dest, rdbPrimeiraClasse.Checked);
                    lblDistancia.Text = objPrimeiraClasse.calculaDistancia().ToString("#,##0");
                    lblPassagem.Text = objPrimeiraClasse.calculoPassagem().ToString("R$ #,##0.00");
                }
                else 
                {
                throw new InvalidOperationException();
                }
            }

            catch(InvalidOperationException ioEx)
            {
                MessageBox.Show(ioEx.Message);
                limpa();

            }
            catch(FormatException fEx) 
            {
                MessageBox.Show(fEx.Message);
                limpa();
            }
        }// Botão Calcular

        public void limpa() 
        {
            cboOrigem.SelectedIndex = -1;
            cboDestino.SelectedIndex = -1;
            rdbEconomica.Checked = false;
            rdbExecutiva.Checked = false;
            rdbPrimeiraClasse.Checked = false;
            lblDistancia.Text = "";
            lblPassagem.Text = "";
        
        }

        
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limpa();
        }
    }
}
