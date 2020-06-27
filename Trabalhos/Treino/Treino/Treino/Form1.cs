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
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSegunda.Visible = false;
            lblTerca.Visible = false;
            lblQuarta.Visible = false;
            lblQuinta.Visible = false;
            lblSexta.Visible = false;
            lblSabado.Visible = false;
            bntMostrar.Visible = false;
            lblMen.Visible = true;

            //Form2 fr2 = new Form2();
            //fr2.Close();

        }

        private void cbbDias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            

            if (cbbDias.SelectedIndex == 0)
            {
                bntMostrar.Visible = true;
                lblSegunda.Visible = true;
                lblMen.Visible = false;
                lblTerca.Visible = false;
                lblQuarta.Visible = false;
                lblQuinta.Visible = false;
                lblSexta.Visible = false;
                lblSabado.Visible = false;
            

            }

            if (cbbDias.SelectedIndex == 1)
            {
                bntMostrar.Visible = true;
                lblTerca.Visible = true;
                lblMen.Visible = false;
                lblQuarta.Visible = false;
                lblQuinta.Visible = false;
                lblSexta.Visible = false;
                lblSabado.Visible = false;
                lblSegunda.Visible = false;
            }

            if (cbbDias.SelectedIndex == 2)
            {

                bntMostrar.Visible = true;
                lblQuarta.Visible = true;
                lblMen.Visible = false;
                lblTerca.Visible = false;
                lblQuinta.Visible = false;
                lblSexta.Visible = false;
                lblSabado.Visible = false;
                lblSegunda.Visible = false;
            }
            if (cbbDias.SelectedIndex == 3)
            {

                bntMostrar.Visible = true;
                lblQuinta.Visible = true;
                lblMen.Visible = false;
                lblTerca.Visible = false;
                lblQuarta.Visible = false;
                lblSexta.Visible = false;
                lblSabado.Visible = false;
                lblSegunda.Visible = false;
            }
            
            if (cbbDias.SelectedIndex == 4)
            {

                bntMostrar.Visible = false;
                lblSexta.Visible = true;
                lblMen.Visible = false;
                lblTerca.Visible = false;
                lblQuarta.Visible = false;
                lblQuinta.Visible = false;
                lblSabado.Visible = false;
                lblSegunda.Visible = false;
            }

            if (cbbDias.SelectedIndex == 5)
            {

                bntMostrar.Visible = true;
                lblSabado.Visible = true;
                lblMen.Visible = false;
                lblTerca.Visible = false;
                lblQuarta.Visible = false;
                lblQuinta.Visible = false;
                lblSexta.Visible = false;
                lblSegunda.Visible = false;
            }

        }

        private void bntMostrar_Click(object sender, EventArgs e)
        {
            

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
          
            Form2 fr2 = new Form2();
            fr2.Close();
            this.Close();
            
        }

      
    }
}
