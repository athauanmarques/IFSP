using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ExercFixacao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Exerc1 e1 = new Exerc1();
            e1.ShowDialog();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Exerc2 e2 = new Exerc2();
            e2.ShowDialog();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Exerc3 e3 = new Exerc3();
            e3.ShowDialog();

        }

    }
}
