using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exer_goto
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            // ccbConsultar.Checked ? lblMostra.Visiel = true : lblMostra.Visiel = false 


            if (ccbAlterar.Checked)
            {
                
                lblStatus.Text += "\nO nome: " + txtNome.Text + " - foi alterado com sucesso ";
                txtNome.Clear();
                txtNome.Focus();
            
            }

            if (ccbIncluir.Checked)
            {

                lblStatus.Text += "\nO nome: " + txtNome.Text + " - foi incluindo com sucesso ";
                txtNome.Clear();
                txtNome.Focus(); 

            }

            if (ccbExcluir.Checked)
            {

                lblStatus.Text += "\nO nome: " + txtNome.Text + " - foi excluido com sucesso ";
                txtNome.Clear();
                txtNome.Focus();

            }
            if (ccbConsultar.Checked)
            {

                lblStatus.Text += "\nO nome: " + txtNome.Text + " - foi consultado com sucesso ";
                txtNome.Clear();
                txtNome.Focus();

            }

            if (rdbFemenino.Checked)
            {

                lblStatus.Text += "\n - Sexo: Feminino";
                ptbHomem.Visible = false;
                ptbMulher.Visible = true;
            
            }
            if (rdbMasculino.Checked)
            {
            
                lblStatus.Text += "\n - Sexo: Masculino";
                ptbHomem.Visible = true;
                ptbMulher.Visible = false;
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            rdbFemenino.Checked = true;
            ptbHomem.Visible = false;
            ptbMulher.Visible = false;
        }
    }
}
