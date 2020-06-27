using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisao2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            int[,] tabela = {{5,12,20}, {5,22,40}, {5,23,60}};

            for (int x = 0; x <= 2; x++)
            {
                for (int y = 0; y <= 2; y++)
                {
                    lblResultado.Text += "Dia ";
                    lblResultado.Text += tabela[x, y].ToString();
                    if (y == 0)
                    {
                        lblResultado.Text += " ás "; 
                    }
                    if (y == 1)
                    {
                        lblResultado.Text += ":00 => Trânsito: ";
                    }
                    if (y == 2)
                    {
                        lblResultado.Text += "km/h";
                    }
                }
                lblResultado.Text += "\n";
            }
            

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lblResultado.Text = ""; 
        }
    }
}
