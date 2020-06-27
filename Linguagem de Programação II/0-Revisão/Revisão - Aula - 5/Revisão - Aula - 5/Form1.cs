using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula___5
{
    public partial class frmCurso : Form
    {
        public frmCurso()
        {
            InitializeComponent();
        }

        int ContaCurso()
        {
            int qts = 0;

            for(int i = 0; i <= lbLista.Items.Count; i++)
            {
                qts = i;
            
            }
            
            return qts;
        
        
        }


        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtCurso.Text = " ";
            lbLista.Text = " ";

        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            if (!lbLista.Items.Contains(txtCurso.Text)) // vai pega e conta itens no txtCurso 
            {

                lbLista.Items.Add(txtCurso.Text);

            }
            else
            {

                MessageBox.Show("Já existe");
            }
        
        
        
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            int indece = 0;
            indece = lbLista.SelectedIndex;
            lbLista.Items.RemoveAt(indece);
            


        }

        private void frmCurso_Load(object sender, EventArgs e)
        {
            lblTotal.Text = "Total: " + ContaCurso().ToString();
            // via receber a palavra "Total: " mais função contaCurso e vai converter para string
        }
    }
}
