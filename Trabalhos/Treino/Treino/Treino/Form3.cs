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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            linkLabel1.Visible = false;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("http://localhost:50000/");
         
        }

        private void bntOk_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text;

            if (codigo == "Athauan Gostoso" || codigo == "295")
            {

                lblStatus.Text = "Você liberou o jogo - Spartan of Spirit";
                linkLabel1.Visible = true;


                

            }
            else 
            {

                lblStatus.Text = "Cheats incorreto tente novamente";
            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

       
    }
}
