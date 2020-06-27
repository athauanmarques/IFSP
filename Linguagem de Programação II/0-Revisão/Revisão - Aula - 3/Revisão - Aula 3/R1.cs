using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula_3
{
    public partial class R1 : Form
    {
        public R1()
        {
            InitializeComponent();
        }

        private void bntMostrar_Click(object sender, EventArgs e)
        {
           int [,] x = {{5, 10, 20},
                     {05, 20, 50},     
                     {10, 45, 70},
                     {20, 70, 120},
                     {30, 80, 200}};

           lblResult.Text = "\nDia: " + x[0, 0]
                           + " às " + x[0, 1]
                           + " :00 --> " + x[0, 2]
                           + "km. \n";

           lblResult.Text += "\nDia: " + x[1, 0] + " às " + x[1, 1] + " :00 --> " + x[1, 2]+ "km. \n";
        
           lblResult.Text += "\n Dia: " + x[2,0] + " às" + x[2,1] + " :00 -->" + x[2,2] + "km. \n";

           lblResult.Text += "\n Dia: " + x[3, 0] + " às" + x[3, 1] + " :00 -->" + x[3, 2] + "km. \n";

          lblResult.Text += "\n Dia: " + x[4,0] + " às" + x[4,1] + " :00 -->" + x[4,2] + "km. \n";
        }
    }
}
