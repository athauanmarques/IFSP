using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cursos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int ContaCurso()
        {
            int qtde=0;
            //loop para contar quantos cursos tem na lista
            for (int i = 0; i <= lbCursos.Items.Count; i++)
            {
                qtde = i;
            }

            return qtde;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "Total: " + ContaCurso().ToString(); 
        }



        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int indice = 0;
                indice = lbCursos.SelectedIndex;
                lbCursos.Items.RemoveAt(indice);

                lblTotal.Text = "Total: " + ContaCurso().ToString();
            }
            catch
            { MessageBox.Show("Selecione"); }
        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lbCursos.Items.Clear();
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {   
            //propriedade SORTED da ListBox is TRUE
            if (!lbCursos.Items.Contains(txtCurso.Text))
            {
                lbCursos.Items.Add(txtCurso.Text);
            }
            else
            {
                MessageBox.Show("Curso existente !");
            }
        }
    }
}
