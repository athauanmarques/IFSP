using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula_3
{
    public partial class R5 : Form
    {
        public R5()
        {
            InitializeComponent();
        }

        private void bntMostrar_Click(object sender, EventArgs e)
        {
            double notas = Convert.ToDouble(txtNotas.Text);

            if (notas < 0 || notas > 10)
            {

                lblResultado.Text = "Erro";

            }
            else if (notas <= 4)
            {
                lblResultado.Text = "Reprovado";

            }

            else if (notas > 4 && notas < 7)
            {

                lblResultado.Text = "Recuperação";

            }

            else if (notas >= 7)
            {

                lblResultado.Text = "Aprovado";
                
            }
        }
    }
}
