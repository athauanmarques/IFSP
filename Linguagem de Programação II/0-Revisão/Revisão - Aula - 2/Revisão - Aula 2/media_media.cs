using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula_2
{
    public partial class media_media : Form
    {
        public media_media()
        {
            InitializeComponent();
        }

        private void media_media_Load(object sender, EventArgs e)
        {

        }

        private void bntM1_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(txtV1.Text);
            double v2 = Convert.ToDouble(txtV2.Text);
            double v3 = Convert.ToDouble(txtV3.Text);
            double v4 = Convert.ToDouble(txtV4.Text);

            double total = (v1 + v2 + v3 + v4)/4;

            rtbResultado.Text = total.ToString();
        }

        private void bntM2_Click(object sender, EventArgs e)
        {
            double v1 = Convert.ToDouble(txtV1.Text);
            double v2 = Convert.ToDouble(txtV2.Text);
            double v3 = Convert.ToDouble(txtV3.Text);
            double v4 = Convert.ToDouble(txtV4.Text);

            double total = (v1 + (v2*v2) + (v3*v3) + (v4*v4)) / 10;

            rtbResultado.Text = total.ToString();
        }

        
    }
}
