using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace forulario2
{
    public partial class FormInicial : Form
    {
        public FormInicial()
        {
            InitializeComponent();
        }

        private void bntExemplos_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.Show(); // pode mexer as 2 janelas
           // frm.ShowDialog();
        }
    }
}
