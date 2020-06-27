using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Decisão
{
    public partial class reajuste : Form
    {
        public reajuste()
        {
            InitializeComponent();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtSal.Text = " ";
            cbbSalario.Text = " ";
            lblImposto.Text = "Imposto: ";
            lblAumento.Text = "Aumento:  ";
            lblNovoSal.Text = "Novo Salário: ";
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            MessageBox.Show("volte em Breve");
            this.Close();
        }

        private void cbbSalario_SelectedIndexChanged(object sender, EventArgs e)
        {

            int op = cbbSalario.SelectedIndex;
            double salario = Convert.ToDouble(txtSal.Text);

            switch (op)
            {
                case 0:
                    if (salario < 550.00)
                    {
                        lblNovoSal.Text = Convert.ToString("Novo Salario: " + salario * 1.25);
                    }
                    

                    else if (salario >= 550.00 || salario <1200.00)
                    {

                        lblNovoSal.Text = Convert.ToString("Novo Salario: " + salario * 1.15);

                    }
                    else
                    {
                        
                        lblNovoSal.Text = Convert.ToString("Novo Salario: " + salario * 1.05);
                    }
                    break;

                case 1:
                    if (salario < 550.00)
                    {

                        lblImposto.Text = Convert.ToString("Imposto: " + salario * 0.95);
                    
                    }
                    else if (salario >= 550.00 || salario < 1200.00)
                    {

                        lblImposto.Text = Convert.ToString("Imposto: " + salario * 0.90);

                    }

                    else
                    {

                        lblImposto.Text = Convert.ToString("Imposto: " + salario * 0.85);
                    
                    }

                    break;

                case 2:
                    if(salario < 550.00)
                    {
                        lblAumento.Text = Convert.ToString("Aumento: " + salario * 1.3);
                    
                    }
                    else if (salario >= 550.00 || salario < 1200)
                    {

                        lblAumento.Text = Convert.ToString("Aumento: " + salario * 1.25);

                    }

                    else
                    {

                        lblAumento.Text = Convert.ToString("Aumento: " + salario * 1.2);
                    }

                    break;


            }
        
        
        
        
        }

        

      

       

       
    }
}
