using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lista1
{
    public partial class frmMedia : Form
    {
        public frmMedia()
        {
            InitializeComponent();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            double n1, n2, n3, n4, n5, media;

            n1 = Convert.ToDouble(txtN1.Text);
            n2 = Convert.ToDouble(txtN2.Text);
            n3 = Convert.ToDouble(txtN3.Text);
            n4 = Convert.ToDouble(txtN4.Text);
            n5 = Convert.ToDouble(txtN5.Text);

            media = (n1 + n2 + n3 + n4 + n5)/5;

            lblMedia.Text = "o resultado é: " + Convert.ToString(media);

        }

        
    }
}
