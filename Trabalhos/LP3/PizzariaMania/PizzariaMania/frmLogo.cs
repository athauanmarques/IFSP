using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PizzariaMania
{
    public partial class frmLogo : Form
    {
        public frmLogo()
        {
            InitializeComponent();
        }

        private void frmLogo_Load(object sender, EventArgs e)
        {
             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (circularProgress1.Value < 100)
            {
                circularProgress1.Value = circularProgress1.Value + 2;
            }
            else
            {

                timer1.Enabled = false;
                this.Visible = false;
                frmLogin menu = new frmLogin();
                menu.ShowDialog();
                Application.Exit();


            }
        }
    }
}
