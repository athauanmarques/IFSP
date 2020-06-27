using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Resultado res = new Resultado();

       
       
        public Form1()
        {
            InitializeComponent();
            
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
            lblNumero.Visible = false;
            lblPontuacao.Visible = false;
            bntExibir.Visible = false;

            bntRecomecar.Visible = false;

            txtResultado.Visible = false;

            lblPergunta1.Visible = false;
            rbt1B.Visible = false;
            rbt1A.Visible = false;
            rbt1C.Visible = false;
            

            lblPergunta2.Visible = false;
            rbt2A.Visible = false;
            rbt2B.Visible = false;
            rbt2C.Visible = false;
            bntConfima1.Visible = false;

            lblPergunta3.Visible = false;
            rbt3A.Visible = false;
            rbt3B.Visible = false;
            rbt3C.Visible = false;
            bntConfirma3.Visible = false;

            lblPergunta4.Visible = false;
            rbt4A.Visible = false;
            rbt4B.Visible = false;
            rbt4C.Visible = false;
            bntConfirma4.Visible = false;

            lblPergunta5.Visible = false;
            rbt5A.Visible = false;
            rbt5B.Visible = false;
            rbt5C.Visible = false;
            bntConfirma5.Visible = false;

            lblPergunta6.Visible = false;
            rbt6A.Visible = false;
            rbt6B.Visible = false;
            rbt6C.Visible = false;
            bntConfirma6.Visible = false;

            lblPergunta7.Visible = false;
            rbt7A.Visible = false;
            rbt7B.Visible = false;
            rbt7C.Visible = false;
            bntConfirma7.Visible = false;

            lblPergunta8.Visible = false;
            rbt8A.Visible = false;
            rbt8B.Visible = false;
            rbt8C.Visible = false;
            bntConfirma8.Visible = false;

            lblPergunta9.Visible = false;
            rbt9A.Visible = false;
            rbt9B.Visible = false;
            rbt9C.Visible = false;
            bntConfirma9.Visible = false;

            lblPergunta10.Visible = false;
            rbt10A.Visible = false;
            rbt10B.Visible = false;
            rbt10C.Visible = false;
            bntConfirma10.Visible = false;

           
            bntResultado.Visible = false;
        }

        private void bntInicial_Click(object sender, EventArgs e)
        {
            
             txtResultado.Text += "" + 0;
             lblNumero.Text += "" + 0;

             if (bntRecomecar.Text == "Novo Teste")
             {
                 bntRecomecar.Text = "Recomeçar";
                 bntRecomecar.BackColor = Color.DimGray;
             
             }
             

             bntRecomecar.Visible = true;
            lblPergunta1.Visible = true;
            rbt1B.Visible = true;
            rbt1A.Visible = true;
            rbt1C.Visible = true;
          bntConfima1.Visible = true;

          
            bntInicial.Visible = false;
            txtNome.Enabled = false;




        }

        private void bntConfima1_Click(object sender, EventArgs e)
        {

            bntRecomecar.Visible = true;

            if (rbt1A.Checked)
            {
                txtResultado.Clear();
                txtResultado.Text += " " + 10;

            }

            if (rbt1B.Checked)
            {
                txtResultado.Clear();
                txtResultado.Text += " " + 5;

            }

            lblPergunta2.Visible = true;
            rbt2A.Visible = true;
            rbt2B.Visible = true;
            rbt2C.Visible = true;
          bntConfirma3.Visible = true;
            // ocultar 
            lblPergunta1.Visible = false;
            rbt1B.Visible = false;
            rbt1A.Visible = false;
            rbt1C.Visible = false;
            bntConfima1.Visible = false;


        }


        private void bntConfirma3_Click(object sender, EventArgs e)
        {
      
            //---------------------- Calculo pergunda 1 e 2 ---------------------------

            double resPer1 = Convert.ToDouble(txtResultado.Text);
            

            if (rbt2A.Checked)
            {
                double respostaA = 10, soma;

                soma = respostaA + resPer1;

               txtResultado.Text = Convert.ToString(soma);
            
            }

            if (rbt2B.Checked)
            {
                double respostaA = 5, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }

        



    // ----------------------- Propriedade de para ocultar perguntas ---------------------------------------




            bntRecomecar.Visible = true;
            lblPergunta3.Visible = true;
            rbt3A.Visible = true;
            rbt3B.Visible = true;
            rbt3C.Visible = true;
          bntConfirma4.Visible = true;
            // ocultar
            bntConfirma3.Visible = false;
            lblPergunta2.Visible = false;
            rbt2A.Visible = false;
            rbt2B.Visible = false;
            rbt2C.Visible = false;
            bntConfima1.Visible = false;
            lblPergunta1.Visible = false;
            rbt1B.Visible = false;
            rbt1A.Visible = false;
            rbt1C.Visible = false;
            bntConfima1.Visible = false;
        }

        private void bntConfirma4_Click(object sender, EventArgs e)
        {

            double resPer1 = Convert.ToDouble(txtResultado.Text);

            if (rbt3A.Checked)
            {
                double respostaA = 10, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }

            if (rbt3B.Checked)
            {
                double respostaA = 5, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }
            bntRecomecar.Visible = true;

            lblPergunta4.Visible = true;
            rbt4A.Visible = true;
            rbt4B.Visible = true;
            rbt4C.Visible = true;
            bntConfirma5.Visible = true;
            // ocultar
            bntConfirma4.Visible = false;
            lblPergunta3.Visible = false;
            rbt3A.Visible = false;
            rbt3B.Visible = false;
            rbt3C.Visible = false;
            bntConfirma3.Visible = false;
            lblPergunta2.Visible = false;
            rbt2A.Visible = false;
            rbt2B.Visible = false;
            rbt2C.Visible = false;
            bntConfima1.Visible = false;
            lblPergunta1.Visible = false;
            rbt1B.Visible = false;
            rbt1A.Visible = false;
            rbt1C.Visible = false;
            bntConfima1.Visible = false;
        }

        private void bntConfirma5_Click(object sender, EventArgs e)
        {
            

            double resPer1 = Convert.ToDouble(txtResultado.Text);

            if (rbt4A.Checked)
            {
                double respostaA = 10, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }

            if (rbt4B.Checked)
            {
                double respostaA = 5, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }
            bntRecomecar.Visible = true;
            lblPergunta5.Visible = true;
            rbt5A.Visible = true;
            rbt5B.Visible = true;
            rbt5C.Visible = true;
            bntConfirma6.Visible = true;
            // ocultar
            bntConfirma5.Visible = false;
            lblPergunta4.Visible = false;
            rbt4A.Visible = false;
            rbt4B.Visible = false;
            rbt4C.Visible = false;
            bntConfirma4.Visible = false;
            lblPergunta3.Visible = false;
            rbt3A.Visible = false;
            rbt3B.Visible = false;
            rbt3C.Visible = false;
            bntConfirma3.Visible = false;
            lblPergunta2.Visible = false;
            rbt2A.Visible = false;
            rbt2B.Visible = false;
            rbt2C.Visible = false;
            bntConfima1.Visible = false;
            lblPergunta1.Visible = false;
            rbt1B.Visible = false;
            rbt1A.Visible = false;
            rbt1C.Visible = false;
            bntConfima1.Visible = false;
        }

        private void bntConfirma6_Click(object sender, EventArgs e)
        {
            double resPer1 = Convert.ToDouble(txtResultado.Text);

            if (rbt5A.Checked)
            {
                double respostaA = 10, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }

            if (rbt5B.Checked)
            {
                double respostaA = 5, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }
            bntRecomecar.Visible = true;

            lblPergunta6.Visible = true;
            rbt6A.Visible = true;
            rbt6B.Visible = true;
            rbt6C.Visible = true;
            bntConfirma7.Visible = true;
            // ocultar
            bntConfirma6.Visible = false;
            lblPergunta5.Visible = false;
            rbt5A.Visible = false;
            rbt5B.Visible = false;
            rbt5C.Visible = false;
            bntConfirma5.Visible = false;
            lblPergunta4.Visible = false;
            rbt4A.Visible = false;
            rbt4B.Visible = false;
            rbt4C.Visible = false;
            bntConfirma4.Visible = false;
            lblPergunta3.Visible = false;
            rbt3A.Visible = false;
            rbt3B.Visible = false;
            rbt3C.Visible = false;
            bntConfirma3.Visible = false;
            lblPergunta2.Visible = false;
            rbt2A.Visible = false;
            rbt2B.Visible = false;
            rbt2C.Visible = false;
            bntConfima1.Visible = false;
            lblPergunta1.Visible = false;
            rbt1B.Visible = false;
            rbt1A.Visible = false;
            rbt1C.Visible = false;
            bntConfima1.Visible = false;
        }

        private void bntConfirma7_Click(object sender, EventArgs e)
        {
            double resPer1 = Convert.ToDouble(txtResultado.Text);

            if (rbt6A.Checked)
            {
                double respostaA = 10, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }

            if (rbt6B.Checked)
            {
                double respostaA = 5, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }
            bntRecomecar.Visible = true;


            lblPergunta7.Visible = true;
            rbt7A.Visible = true;
            rbt7B.Visible = true;
            rbt7C.Visible = true;
            bntConfirma8.Visible = true;
            //ocultar
            bntConfirma7.Visible = false;
            lblPergunta6.Visible = false;
            rbt6A.Visible = false;
            rbt6B.Visible = false;
            rbt6C.Visible = false;
            bntConfirma6.Visible = false;
            lblPergunta5.Visible = false;
            rbt5A.Visible = false;
            rbt5B.Visible = false;
            rbt5C.Visible = false;
            bntConfirma5.Visible = false;
            lblPergunta4.Visible = false;
            rbt4A.Visible = false;
            rbt4B.Visible = false;
            rbt4C.Visible = false;
            bntConfirma4.Visible = false;
            lblPergunta3.Visible = false;
            rbt3A.Visible = false;
            rbt3B.Visible = false;
            rbt3C.Visible = false;
            bntConfirma3.Visible = false;
            lblPergunta2.Visible = false;
            rbt2A.Visible = false;
            rbt2B.Visible = false;
            rbt2C.Visible = false;
            bntConfima1.Visible = false;
            lblPergunta1.Visible = false;
            rbt1B.Visible = false;
            rbt1A.Visible = false;
            rbt1C.Visible = false;
            bntConfima1.Visible = false;
        }

        private void bntConfirma8_Click(object sender, EventArgs e)
        {

            double resPer1 = Convert.ToDouble(txtResultado.Text);

            if (rbt7A.Checked)
            {
                double respostaA = 10, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }

            if (rbt7B.Checked)
            {
                double respostaA = 5, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }
            bntRecomecar.Visible = true;

            lblPergunta8.Visible = true;
            rbt8A.Visible = true;
            rbt8B.Visible = true;
            rbt8C.Visible = true;
            bntConfirma9.Visible = true;
            //oculta
            bntConfirma8.Visible = false;
            lblPergunta7.Visible = false;
            rbt7A.Visible = false;
            rbt7B.Visible = false;
            rbt7C.Visible = false;
            bntConfirma7.Visible = false;
            lblPergunta6.Visible = false;
            rbt6A.Visible = false;
            rbt6B.Visible = false;
            rbt6C.Visible = false;
            bntConfirma6.Visible = false;
            lblPergunta5.Visible = false;
            rbt5A.Visible = false;
            rbt5B.Visible = false;
            rbt5C.Visible = false;
            bntConfirma5.Visible = false;
            lblPergunta4.Visible = false;
            rbt4A.Visible = false;
            rbt4B.Visible = false;
            rbt4C.Visible = false;
            bntConfirma4.Visible = false;
            lblPergunta3.Visible = false;
            rbt3A.Visible = false;
            rbt3B.Visible = false;
            rbt3C.Visible = false;
            bntConfirma3.Visible = false;
            lblPergunta2.Visible = false;
            rbt2A.Visible = false;
            rbt2B.Visible = false;
            rbt2C.Visible = false;
            bntConfima1.Visible = false;
            lblPergunta1.Visible = false;
            rbt1B.Visible = false;
            rbt1A.Visible = false;
            rbt1C.Visible = false;
            bntConfima1.Visible = false;
        }

        private void bntConfirma9_Click(object sender, EventArgs e)
        {

            double resPer1 = Convert.ToDouble(txtResultado.Text);

            if (rbt8A.Checked)
            {
                double respostaA = 10, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }

            if (rbt8B.Checked)
            {
                double respostaA = 5, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }
            bntRecomecar.Visible = true;

            lblPergunta9.Visible = true;
            rbt9A.Visible = true;
            rbt9B.Visible = true;
            rbt9C.Visible = true;
            bntConfirma10.Visible = true;
            //oculta
            bntConfirma9.Visible = false;
            lblPergunta8.Visible = false;
            rbt8A.Visible = false;
            rbt8B.Visible = false;
            rbt8C.Visible = false;
            bntConfirma8.Visible = false;
            lblPergunta7.Visible = false;
            rbt7A.Visible = false;
            rbt7B.Visible = false;
            rbt7C.Visible = false;
            bntConfirma7.Visible = false;
            lblPergunta6.Visible = false;
            rbt6A.Visible = false;
            rbt6B.Visible = false;
            rbt6C.Visible = false;
            bntConfirma6.Visible = false;
            lblPergunta5.Visible = false;
            rbt5A.Visible = false;
            rbt5B.Visible = false;
            rbt5C.Visible = false;
            bntConfirma5.Visible = false;
            lblPergunta4.Visible = false;
            rbt4A.Visible = false;
            rbt4B.Visible = false;
            rbt4C.Visible = false;
            bntConfirma4.Visible = false;
            lblPergunta3.Visible = false;
            rbt3A.Visible = false;
            rbt3B.Visible = false;
            rbt3C.Visible = false;
            bntConfirma3.Visible = false;
            lblPergunta2.Visible = false;
            rbt2A.Visible = false;
            rbt2B.Visible = false;
            rbt2C.Visible = false;
            bntConfima1.Visible = false;
            lblPergunta1.Visible = false;
            rbt1B.Visible = false;
            rbt1A.Visible = false;
            rbt1C.Visible = false;
            bntConfima1.Visible = false;
        }

        private void bntConfirma10_Click(object sender, EventArgs e)
        {
            double resPer1 = Convert.ToDouble(txtResultado.Text);

            if (rbt9A.Checked)
            {
                double respostaA = 10, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }

            if (rbt9B.Checked)
            {
                double respostaA = 5, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);

            }
            bntRecomecar.Visible = true;

            lblPergunta10.Visible = true;
            rbt10A.Visible = true;
            rbt10B.Visible = true;
            rbt10C.Visible = true;
            bntResultado.Visible = true;
            //ocultar
            bntConfirma10.Visible = false;
            lblPergunta9.Visible = false;
            rbt9A.Visible = false;
            rbt9B.Visible = false;
            rbt9C.Visible = false;
            bntConfirma9.Visible = false;
            lblPergunta8.Visible = false;
            rbt8A.Visible = false;
            rbt8B.Visible = false;
            rbt8C.Visible = false;
            bntConfirma8.Visible = false;
            lblPergunta7.Visible = false;
            rbt7A.Visible = false;
            rbt7B.Visible = false;
            rbt7C.Visible = false;
            bntConfirma7.Visible = false;
            lblPergunta6.Visible = false;
            rbt6A.Visible = false;
            rbt6B.Visible = false;
            rbt6C.Visible = false;
            bntConfirma6.Visible = false;
            lblPergunta5.Visible = false;
            rbt5A.Visible = false;
            rbt5B.Visible = false;
            rbt5C.Visible = false;
            bntConfirma5.Visible = false;
            lblPergunta4.Visible = false;
            rbt4A.Visible = false;
            rbt4B.Visible = false;
            rbt4C.Visible = false;
            bntConfirma4.Visible = false;
            lblPergunta3.Visible = false;
            rbt3A.Visible = false;
            rbt3B.Visible = false;
            rbt3C.Visible = false;
            bntConfirma3.Visible = false;
            lblPergunta2.Visible = false;
            rbt2A.Visible = false;
            rbt2B.Visible = false;
            rbt2C.Visible = false;
            bntConfima1.Visible = false;
            lblPergunta1.Visible = false;
            rbt1B.Visible = false;
            rbt1A.Visible = false;
            rbt1C.Visible = false;
            bntConfima1.Visible = false;
        }

        private void bntResultado_Click(object sender, EventArgs e)
        {
            double resPer1 = Convert.ToDouble(txtResultado.Text);

            if (rbt10A.Checked)
            {
                double respostaA = 10, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);
                lblNumero.Text = txtResultado.Text;

            }

            if (rbt10B.Checked)
            {
                double respostaA = 5, soma;

                soma = respostaA + resPer1;

                txtResultado.Text = Convert.ToString(soma);
                lblNumero.Text = txtResultado.Text;

            }
            lblNumero.Text = txtResultado.Text;

            
            lblNumero.Visible = true;
            lblPontuacao.Visible = true;
            bntRecomecar.Visible = true;
            bntRecomecar.Text = "Novo Teste";
            bntRecomecar.BackColor = Color.Yellow;
            bntInicial.Visible = false;
            txtNome.Enabled = false;

            lblNumero.Visible = true;
            lblPontuacao.Visible = true;
            bntExibir.Visible = true;

          
                //ocultado
                lblPergunta10.Visible = false;
            rbt10A.Visible = false;
            rbt10B.Visible = false;
            rbt10C.Visible = false;
            bntResultado.Visible = false;
            bntConfirma10.Visible = false;
            lblPergunta9.Visible = false;
            rbt9A.Visible = false;
            rbt9B.Visible = false;
            rbt9C.Visible = false;
            bntConfirma9.Visible = false;
            lblPergunta8.Visible = false;
            rbt8A.Visible = false;
            rbt8B.Visible = false;
            rbt8C.Visible = false;
            bntConfirma8.Visible = false;
            lblPergunta7.Visible = false;
            rbt7A.Visible = false;
            rbt7B.Visible = false;
            rbt7C.Visible = false;
            bntConfirma7.Visible = false;
            lblPergunta6.Visible = false;
            rbt6A.Visible = false;
            rbt6B.Visible = false;
            rbt6C.Visible = false;
            bntConfirma6.Visible = false;
            lblPergunta5.Visible = false;
            rbt5A.Visible = false;
            rbt5B.Visible = false;
            rbt5C.Visible = false;
            bntConfirma5.Visible = false;
            lblPergunta4.Visible = false;
            rbt4A.Visible = false;
            rbt4B.Visible = false;
            rbt4C.Visible = false;
            bntConfirma4.Visible = false;
            lblPergunta3.Visible = false;
            rbt3A.Visible = false;
            rbt3B.Visible = false;
            rbt3C.Visible = false;
            bntConfirma3.Visible = false;
            lblPergunta2.Visible = false;
            rbt2A.Visible = false;
            rbt2B.Visible = false;
            rbt2C.Visible = false;
            bntConfima1.Visible = false;
            lblPergunta1.Visible = false;
            rbt1B.Visible = false;
            rbt1A.Visible = false;
            rbt1C.Visible = false;
            bntConfima1.Visible = false;
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            
            TesteComeco teste = new TesteComeco();
            teste.Close();
            this.Close();
        }

        private void bntRecomecar_Click(object sender, EventArgs e)
        {
            txtResultado.Clear();

            lblNumero.Text = " ";
            txtNome.Clear();
            txtNome.Enabled = true;
            bntInicial.Visible = true;
            bntRecomecar.Visible = false;
            
            lblNumero.Visible = false;
            lblPontuacao.Visible = false;
            bntExibir.Visible = false;

            // -------------------------------

            lblPergunta1.Visible = false;
            rbt1B.Visible = false;
            rbt1A.Visible = false;
            rbt1C.Visible = false;


            lblPergunta2.Visible = false;
            rbt2A.Visible = false;
            rbt2B.Visible = false;
            rbt2C.Visible = false;
            bntConfima1.Visible = false;

            lblPergunta3.Visible = false;
            rbt3A.Visible = false;
            rbt3B.Visible = false;
            rbt3C.Visible = false;
            bntConfirma3.Visible = false;

            lblPergunta4.Visible = false;
            rbt4A.Visible = false;
            rbt4B.Visible = false;
            rbt4C.Visible = false;
            bntConfirma4.Visible = false;

            lblPergunta5.Visible = false;
            rbt5A.Visible = false;
            rbt5B.Visible = false;
            rbt5C.Visible = false;
            bntConfirma5.Visible = false;

            lblPergunta6.Visible = false;
            rbt6A.Visible = false;
            rbt6B.Visible = false;
            rbt6C.Visible = false;
            bntConfirma6.Visible = false;

            lblPergunta7.Visible = false;
            rbt7A.Visible = false;
            rbt7B.Visible = false;
            rbt7C.Visible = false;
            bntConfirma7.Visible = false;

            lblPergunta8.Visible = false;
            rbt8A.Visible = false;
            rbt8B.Visible = false;
            rbt8C.Visible = false;
            bntConfirma8.Visible = false;

            lblPergunta9.Visible = false;
            rbt9A.Visible = false;
            rbt9B.Visible = false;
            rbt9C.Visible = false;
            bntConfirma9.Visible = false;

            lblPergunta10.Visible = false;
            rbt10A.Visible = false;
            rbt10B.Visible = false;
            rbt10C.Visible = false;
            bntConfirma10.Visible = false;

        }

        private void bntExibir_Click(object sender, EventArgs e)
        {
            double totalTeste = Convert.ToDouble(lblNumero.Text);

            if(totalTeste <= 20)
            {
            
                //frmResultado1 formDestino = new frmResultado1(txtNome.Text);
                frmResultado1 formDestino = new frmResultado1();
              //  formDestino.Show();
                formDestino.ShowDialog();
            
            }

            else if (totalTeste >= 25 && totalTeste <= 50)
            {

                //frmResultado1 formDestino = new frmResultado1(txtNome.Text);
                frmResultado2 formDestino = new frmResultado2();
                //  formDestino.Show();
                formDestino.ShowDialog();

            }

            else if (totalTeste >= 55 && totalTeste <= 80)
            {

                //frmResultado1 formDestino = new frmResultado1(txtNome.Text);
                frmResultado3 formDestino = new frmResultado3();
                //  formDestino.Show();
                formDestino.ShowDialog();

            }

            else if (totalTeste >= 85)
            {

                //frmResultado1 formDestino = new frmResultado1(txtNome.Text);
                frmResultado4 formDestino = new frmResultado4();
                //  formDestino.Show();
                formDestino.ShowDialog();

            }


        }

       

        
        
         
    }
}
