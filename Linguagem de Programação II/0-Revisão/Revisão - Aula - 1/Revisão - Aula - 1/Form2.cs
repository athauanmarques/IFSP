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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            lblCursoMostra.Text = "Curso: " + txtCurso.Text;
            lblSiteMostrar.Text = "Site: " + txtSite.Text;
        }
    }
}
