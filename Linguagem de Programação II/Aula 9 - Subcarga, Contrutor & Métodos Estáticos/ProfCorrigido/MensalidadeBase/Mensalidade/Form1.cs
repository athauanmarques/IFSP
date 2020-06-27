using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mensalidade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try 
            {
                double valorGraduacao = Convert.ToDouble(txtMenGraduacao.Text);

                if (rdbMestrado.Checked) 
                {
                    Mestrado mes = new Mestrado();
                    mes.mestrado(valorGraduacao);

                    txtMensFinal.Text = "R$" + mes.resultado.ToString();

                }
                if (rdbDoutorado.Checked) 
                {
                    Doutorado dot= new Doutorado();
                    dot.doutorado(valorGraduacao);

                    txtMensFinal.Text = "R$" + dot.resultado.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Digite Apenas Numeros", "ERRO!!!!!");

            }
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCurso.Clear();
            txtMenGraduacao.Clear();
            txtMensFinal.Clear();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
