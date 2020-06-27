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
    public partial class TesteComeco : Form
    {
        public TesteComeco()
        {
            InitializeComponent();
        }

        private void bntInicial_Click(object sender, EventArgs e)
        {
            
            Form1 voltar = new Form1();
           
            voltar.ShowDialog();
            this.Close();
            
        }

        private void TesteComeco_Load(object sender, EventArgs e)
        {

        }

       

      
    }
}
