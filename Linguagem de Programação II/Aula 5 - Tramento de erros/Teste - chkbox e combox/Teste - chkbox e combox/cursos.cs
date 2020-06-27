using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Teste
{
    public partial class cursos : Form
    {
        public cursos()
        {
            InitializeComponent();
        }

        int ContaCurso()
        {
            int qtde = 0;
            // loop para contar quantos cursos tem na lista
            for(int i = 0; i <=lbVariosCursos.Items.Count; i++)
            {
                
                qtde = i;

            }

            return qtde;
        }

        private void cursos_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "Total: " + ContaCurso().ToString(); 
            // vai conta qts itens que esta no listBox
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            if (!lbVariosCursos.Items.Contains(txtCurso.Text))
            {

                lbVariosCursos.Items.Add(txtCurso.Text);
                //vai adicionar 

            }

            else 
            {

                MessageBox.Show("Curso existente !");
            
            }

        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            int indice = 0;
            indice = lbVariosCursos.SelectedIndex;
            lbVariosCursos.Items.RemoveAt(indice);
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            lbVariosCursos.Text = " ";
            txtCurso.Text = " ";
            lblTotal.Text = "Total: ";
        }
    }
}
