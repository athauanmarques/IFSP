using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Matriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            //int[,] transito1 = new int[5,12];
            int[,] transito = {{05,12,20},{05,23,40},{10,10,45}, {22,19,70}, {31,02,10}};

            lblMatriz.Text = "Dia " + transito[0, 0] + " às " + transito[0, 1] + ":00  -> trânsito: " + transito[0, 2] + " Km. \n";
            lblMatriz.Text += "Dia " + transito[1, 0] + " às " + transito[1, 1] + ":00  -> trânsito: " + transito[1, 2] + " Km. \n";
            lblMatriz.Text += "Dia " + transito[2, 0] + " às " + transito[2, 1] + ":00  -> trânsito: " + transito[2, 2] + " Km. \n";
            lblMatriz.Text += "Dia " + transito[3, 0] + " às " + transito[3, 1] + ":00  -> trânsito: " + transito[3, 2] + " Km. \n";

            //int j = transito.Length;

            
        }
    }
}

/*Duvidas matriz: O que quer dizer esse valor 20 em --> transito[5][12]=20? 
Descrevi todas as posições para visualizar, mas sei que deveria ser feito com FORENCH. Não consegui fazer em matriz de 2 dimensões. Como faço??
 * 
 * Pense numa matriz de 2 dimensões como uma tabela contendo linhas e colunas 
Veja o exemplo abaixo onde foi definido uma array de 2 dimensões contendo 32 linhas 
Logo abaixo há um loop onde para cada linha estamos definindo que terá 25 colunas 

Depois foi atribuído alguns valores e por ultimo uma lógica para listar todas as linhas (primeiro for) 
e para cada linha listar todas as colunas (for aninhado) e ler os valores das mesmas 



 private void cmdListar_Click(object sender, EventArgs e) 
 { 

 int[][] transito = new int[32][]; 
 for (int i = 0; i < transito.Length; i++) 
 { 
 transito[i] = new int[25]; 
 } 
 transito[5][12] = 20; 
 transito[5][23] = 40; 
 transito[10][10] = 45; 
 transito[22][19] = 70; 
 transito[31][2] = 10; 
 string s = ""; 
 for (int i = 0; i < transito.Length; i++) 
 { 

 for (int j = 0; j < transito[i].Length; j++) 
 { 

 if (transito[i][j] > 0) 
 { 
 s += transito[i][j] + " "; 
 s += "\n"; 
 } 
 } 
 } 
 lblResultado.Text = s; 
 } 


 } 

 */