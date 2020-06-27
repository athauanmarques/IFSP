using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FolhaPgto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string sobrenome = txtSobre.Text;

                if (rdbChefe.Checked)
                {
                    double salChefe;
                    label3.Text = "Salario Semanal: ";
                    label3.Visible = true;
                    textBox3.Visible = true;
                    salChefe = Convert.ToDouble(textBox3.Text);

                    Chefe cf = new Chefe(nome, sobrenome, salChefe);

                    label4.Visible = true;
                    label4.Text = "Salario do Chefe: ";
                    textBox4.Visible = true;
                    textBox4.Text = cf.Ganhos().ToString("#,  ##0.00");
                }
                else if (rdbVendas.Checked)
                {
                    double salVendas, comVendas, porcent;
                    int quant;
                    label3.Text = "Salário Semanal";
                    label3.Visible = true;
                    textBox3.Visible = true;
                    salVendas = Convert.ToDouble(textBox3.Text);
                    porcent = salVendas / 100;
                    label4.Text = "Comissão = ";
                    textBox4.Visible = true;
                    comVendas = Convert.ToDouble(textBox4.Text);
                    label6.Text = "Quantidade";
                    label6.Visible = true;
                    textBox5.Visible = true;
                    quant = Convert.ToInt32(textBox5.Text);
                    Vendas vd = new Vendas(nome, sobrenome, salVendas,porcent, quant);
                    
                    label5.Text = "Salário Total";
                    label5.Visible = true;
                    textBox6.Visible = true;
                    textBox6.Text = vd.Ganhos().ToString("#,##0.00");
                }
                else if(rdbProducao.Checked)
                {
                    double salPorItem;
                    int quantProduzida;

                    label3.Text = "Salário por Peça";
                    label3.Visible = true;
                    textBox3.Visible = true;
                    salPorItem = Convert.ToDouble(textBox3.Text);
                    label4.Visible = true;
                    textBox4.Visible = true;
                    quantProduzida = Convert.ToInt32(textBox4.Text);
                    Producao pd = new Producao(nome, sobrenome, salPorItem,quantProduzida);
                    
                    label5.Text = "Salário Total";
                    label5.Visible = true;
                    textBox6.Visible = true;
                    textBox6.Text = pd.Ganhos().ToString("#,##0.00");
                 }
                 else
                    throw new InvalidOperationException("Operador não selecionado");               

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSobre.Clear();
            textBox3.Clear();
            textBox3.Visible = false;
            label3.Text = "";
            label3.Visible = false;
            label4.Text = "";
            label4.Visible = false;
            textBox4.Clear();
            textBox4.Visible = false;
            textBox5.Clear();
            textBox5.Visible = false;
            label5.Text = "";
            label5.Visible = false;
            label6.Text = "";
            label6.Visible = false;
            textBox6.Clear();
            textBox6.Visible = false;
            rdbChefe.Checked = false;
            rdbProducao.Checked = false;
            rdbVendas.Checked = false;
        }

        public void desabilita()
        {
            textBox3.Clear();
            textBox3.Visible = false;
            label3.Text = "";
            label3.Visible = false;
            label4.Text = "";
            label4.Visible = false;
            textBox4.Clear();
            textBox4.Visible = false;
            label6.Text = "";
            label6.Visible = false;
            textBox5.Clear();
            textBox5.Visible = false;
            label5.Text = "";
            label5.Visible = false;
            textBox6.Visible = false;
        }

        private void rdbChefe_CheckedChanged(object sender, EventArgs e)
        {
            desabilita();
            textBox3.Clear();
            textBox3.Visible = true;
            label3.Text = "Salário Semanal:";
            label3.Visible = true;            
            rdbProducao.Checked = false;
            rdbVendas.Checked = false;
        }

        private void rdbVendas_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdbProducao_CheckedChanged(object sender, EventArgs e)
        {

        }


    }
}
