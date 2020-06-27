using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exemplo1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                string sobrenome = txtSobrenome.Text;
                
                if (rbtChefe.Checked)
                {

                    double salChefe;
                    label3.Text = "Salario Semanal";
                    label3.Visible = true; // Visible verdadeiro
                    txt3.Visible = true;
                    salChefe = Convert.ToDouble(txt3.Text);
                    
                    Chefe cf = new Chefe(nome, sobrenome, salChefe);    // tem colocar parametro da classe chefe            

                    label4.Text = "Salario do Chefe: ";
                    label4.Visible = true; // tornando visivel
                    txt4.Visible = true;
                    txt4.Text = cf.Ganhos().ToString();


                    label5.Visible = false; // tornando visivel
                    txt5.Visible = false;

                    label6.Visible = false; // tornando visivel
                    txt6.Visible = false;

                }


                if (rbtComissao.Checked)
                {
                    double salMensal;
                    label3.Text = "Salario Mensanal";
                    label3.Visible = true;
                    txt3.Visible = true;
                    salMensal = Convert.ToDouble(txt3.Text);

                    double salComissao;
                    label4.Text = "Comissão ";
                    label4.Visible = true;
                    txt4.Visible = true;
                   salComissao = Convert.ToDouble(txt4.Text);

                    int salQuantidade;
                    label5.Text = "Quantidade ";
                    label5.Visible = true;
                    txt5.Visible = true;
                    salQuantidade = Convert.ToInt32(txt5.Text);

                    
                    label6.Text = "Total salario ";
                    label6.Visible = true;
                    txt6.Visible = true;


                    Vendas ven = new Vendas(nome, sobrenome, salMensal, salComissao, salQuantidade); // mandar para classes para calcular

                    txt6.Text = ven.Ganhos().ToString();
                
                
                }

                if(rbtProducao.Checked)
                {

                    double salPeca;
                    label3.Text = "Salario peça";
                    label3.Visible = true;
                    txt3.Visible = true;
                    salPeca = Convert.ToDouble(txt3.Text);

                    double salQuantidade;
                    label4.Text = "quantidade ";
                    label4.Visible = true;
                    txt4.Visible = true;
                    salQuantidade = Convert.ToDouble(txt4.Text);

                    
                    label5.Text = " ";
                    label5.Visible = false;
                    txt5.Visible = false;
                  


                    label6.Text = "Total salario ";
                    label6.Visible = true;
                    txt6.Visible = true;


                    Producao pro = new Producao(nome, sobrenome, salPeca, salQuantidade);

                    txt6.Text = pro.Ganhos().ToString();


                }



            }
            catch(Exception ex)
            {

                MessageBox.Show(ex.Message);
            
            }
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txt3.Visible = false;
            txt4.Visible = false;
            txt5.Visible = false;
            txt6.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            txt3.Text = " ";
            txt4.Text = " ";
            txt5.Text = " ";
            txt6.Text = " ";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txt3.Visible = false;
            txt4.Visible = false;
            txt5.Visible = false;
            txt6.Visible = false;

            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;

           

        }

        private void rbtChefe_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Salario Semanal";
            label3.Visible = true; // Visible verdadeiro
            txt3.Visible = true;
          
            label4.Text = "";
            label4.Visible = false; 
            txt4.Visible = false;


            label5.Visible = false; 
            txt5.Visible = false;

            label6.Visible = false; // tornando visivel
            txt6.Visible = false;
        }

        private void rbtComissao_CheckedChanged(object sender, EventArgs e)
        {
            
            label3.Text = "Salario Mensanal";
            label3.Visible = true;
            txt3.Visible = true;
          

            
            label4.Text = "Comissão ";
            label4.Visible = true;
            txt4.Visible = true;
         
      
            label5.Text = "Quantidade ";
            label5.Visible = true;
            txt5.Visible = true;
           


       

        }

        private void rbtProducao_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Salario peça";
            label3.Visible = true;
            txt3.Visible = true;
          
            label4.Text = "quantidade ";
            label4.Visible = true;
            txt4.Visible = true;
           
            label5.Text = " ";
            label5.Visible = false;
            txt5.Visible = false;

        }

        
    }
}
