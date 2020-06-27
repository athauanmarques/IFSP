using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Atividade
{
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void bntExer1_Click(object sender, EventArgs e)
        {
            
            frmOrdenacao exercicio1 = new frmOrdenacao();
            exercicio1.ShowDialog();
           
            
            
        }

        private void bntExer2_Click(object sender, EventArgs e)
        {
            calculadora exercicio2 = new calculadora();
            exercicio2.ShowDialog();

        }

        private void bntExer3_Click(object sender, EventArgs e)
        {
            lote exercicio3 = new lote();
            exercicio3.ShowDialog();
        }

        private void bntExer4_Click(object sender, EventArgs e)
        {
            consumo exercicio4 = new consumo();
            exercicio4.ShowDialog();
        }

        private void bntDesen_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Athauan Marques da Cunha - 136246-1 ");
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

       
        

       
    }
}
