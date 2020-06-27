using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Aereas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblPreco.Text = "R$ 2,50";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboOrigem.Items.Add("Belo Horizonte");
            cboOrigem.Items.Add("Brasilia");
            cboOrigem.Items.Add("Rio de Janeiro");
            cboOrigem.Items.Add("São Paulo");

            cboDestino.Items.Add("Belo Horizonte");
            cboDestino.Items.Add("Brasilia");
            cboDestino.Items.Add("Rio de Janeiro");
            cboDestino.Items.Add("São Paulo");
        }

        public void Limpa()
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
            Limpa();
        }


        private void btnCalcular_Click(object sender, EventArgs e)
        {            
            string origem = cboOrigem.Text;
            string destino = cboDestino.Text;

            try
            {                
                    if (rdbEconomica.Checked)
                    {
                        Economica eco = new Economica(origem,destino,rdbEconomica.Checked);
                        lblDistancia.Text = eco.CalculaDistancia().ToString("#,##0");
                        lblPassagem.Text = eco.CalculoPassagem().ToString("R$ #,##0.00");
                    }
                    else if (rdbExecutiva.Checked)
                    {
                        Executiva exe = new Executiva(origem,destino,rdbExecutiva.Checked);
                        lblDistancia.Text = exe.CalculaDistancia().ToString("#,##0");
                        lblPassagem.Text = exe.CalculoPassagem().ToString("R$ #,##0.00");
                    }
                    else if (rdbPrimeiraClasse.Checked)
                    {
                        PrimeiraClasse prime = new PrimeiraClasse(origem,destino,rdbPrimeiraClasse.Checked);
                        lblDistancia.Text = prime.CalculaDistancia().ToString("#,##0");
                        lblPassagem.Text = prime.CalculoPassagem().ToString("R$ #,##0.00");
                    }
                    else
                    {
                        MessageBox.Show("Selecione um tipo de Classe");
                    }
                
            }
            catch(Exception Ex) 
            {
                MessageBox.Show(Ex.Message);
                Limpa();
            }
        }
    }
}
