using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnVermelho_Click(object sender, EventArgs e)
        {
            lblCor.Text = "Vermelho";
        }

        private void btnVerde_Click(object sender, EventArgs e)
        {
            lblCor.Text = "Verde";
        }
    }
}
