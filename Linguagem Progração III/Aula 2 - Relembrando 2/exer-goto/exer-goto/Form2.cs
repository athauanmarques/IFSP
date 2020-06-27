using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exer_goto
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bntMostrar_Click(object sender, EventArgs e)
        {
           int n = Convert.ToInt32(txtN.Text);
          

           switch (n)
           { 
           
               case 1:
                   lblResult.Text = "Sengunda - feira";
                   break;

               case 2:
                   lblResult.Text = "Terça - feira";
                   break;

               case 3:
                   lblResult.Text = "Quarta - feira";
                   break;

               case 4:
                   lblResult.Text = "Quinta - feira";
                   break;

               case 5:
                   lblResult.Text = "Sexta - feira";
                   break;

               case 6:
                   lblResult.Text = "Sábado";
                   break;

               case 7:
                   lblResult.Text = "Domingo";
                   break;

               default:
                   lblResult.Text = "valor infálido";
                   txtN.Clear();
                   txtN.Focus();
                   break;
           }


        }
    }
}
