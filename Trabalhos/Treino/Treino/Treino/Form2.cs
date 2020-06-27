using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Treino
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            progressBar1.Value += 2;

            if (progressBar1.Value <= 30)
            {

                label2.Text = "             Iniciando  o sistema...";
            
            
            }

            else if (progressBar1.Value <= 30)
            {

                label2.Text = "Preparando Bando de dados de exercicíos...";


            }

            else if (progressBar1.Value <= 70)
            {

                label2.Text = "Verificando Bando de dados dos Guerreiros...";


            }
            else if (progressBar1.Value < 100)
            {

                label2.Text = "               Aguarde para a batalha...";


            }

            if (progressBar1.Value == 100)
            {
              //  progressBar1.Value = 101;
              timer1.Enabled = false;
              progressBar1.Visible = true;
              bntComecar.Visible = true;
              panel3.Visible = true;

              label2.Text = "                           Pronto";
            //label2.Text = "Aguarde para a batalha...";

                  

            }
           
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel3.Visible = true;
            bntComecar.Visible = false;
           

        }

        private void bntComecar_Click(object sender, EventArgs e)
        {
            Form1 fr = new Form1();
            fr.ShowDialog();
            this.Close();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            fr3.ShowDialog();
        }

      
    }
}
