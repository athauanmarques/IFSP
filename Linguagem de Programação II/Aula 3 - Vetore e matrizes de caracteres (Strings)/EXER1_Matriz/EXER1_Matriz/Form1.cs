using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXER1_Matriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntListar_Click(object sender, EventArgs e)
        {
            int [,] x = {{5,10,20},
                        {05,14,15},
                        {10,11,25},
                        {15,21,35},
                        {20,19,55}};

            lblStatus.Text = "\nDia: " + x[0, 0]
                            + " às " + x[0, 1]
                            + " :00 --> " + x[0, 2]
                            + "km. \n";
            lblStatus.Text += "Dia: " + x[1, 0]
                            + " às " + x[1, 1]
                            + " :00 --> " + x[1, 2]
                            + "km. \n";
            lblStatus.Text += "Dia: " + x[2, 0]
                            + " às " + x[2, 1]
                            + " :00 --> " + x[2, 2]
                            + "km. \n";
            lblStatus.Text += "Dia: " + x[3, 0]
                            + " às " + x[3, 1]
                            + " :00 --> " + x[3, 2]
                            + "km. \n";
            lblStatus.Text += "Dia: " + x[4, 0]
                            + " às " + x[4, 1]
                            + " :00 --> " + x[4, 2]
                            + "km. \n";
        
        
        }
    }
}
