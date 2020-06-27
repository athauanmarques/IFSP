using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PousadaFoz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbxTipo.Items.Add("SGL-apto Single");
            cbxTipo.Items.Add("STD-apto Standart");
            cbxTipo.Items.Add("DBL-apto Casal");
            cbxTipo.Items.Add("PSL-apto Luxo");            
        }

        private void cbxTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxTipo.SelectedIndex == 0)
            {
                lblValor.Text = "R$ 200,00";
            }
            else if (cbxTipo.SelectedIndex == 1)
            {
                lblValor.Text = "R$ 300,00";
            }
            else if (cbxTipo.SelectedIndex == 2)
            {
                lblValor.Text = "R$ 250,00";
            }
            else if (cbxTipo.SelectedIndex == 3)
            {
                lblValor.Text = "R$ 450,00";
            }
        }

        public void Limpar()
        {

            txtCliente.Text = "";
            txtDias.Text = "";
            lblValor.Text = "";
            lblTotal.Text = "";
            cbxTipo.SelectedIndex = -1;

            txtCliente.Focus();

        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (txtCliente.Text == "")
            {
                MessageBox.Show("Digite o nome do cliente.");

                txtCliente.Focus();

            }
            else if (txtDias.Text == "")
            {

                MessageBox.Show("Informe a quantidade de dias.");

                txtDias.Focus();

            }
            else if (cbxTipo.SelectedIndex == -1)
            {

                MessageBox.Show("Selecione o tipo de quarto.");

                cbxTipo.Focus();

            }
            
            else
            {
                Calculos calc = new Calculos(txtCliente.Text, int.Parse(txtDias.Text), cbxTipo.SelectedIndex);
                if (rbt3.Checked)
                { 
                    double total;
                    double pacote = 70;
                    total = calc.getTotalCliente() + pacote;
                    lblTotal.Text = total.ToString();
                     
                }
                else if (rbt2.Checked)
                {
                    double total;
                    double pacote = 29;
                    total = calc.getTotalCliente() + pacote;
                    lblTotal.Text = total.ToString();
                }
                else
                {
                     lblTotal.Text = calc.getTotalCliente().ToString();
                }                

            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            Calculos calc = new Calculos(txtCliente.Text, int.Parse(txtDias.Text), cbxTipo.SelectedIndex);
            Calculos.totalArrecadado += calc.getTotalCliente();

            lblArrecadacao.Text = Calculos.totalArrecadado.ToString();

            lblClientes.Text = Calculos.clienteMaiorNumDias.ToString();

            Limpar();
        }
    }
}
