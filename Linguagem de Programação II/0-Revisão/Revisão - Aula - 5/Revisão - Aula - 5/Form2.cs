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
    public partial class frmConsulta : Form
    {
        public frmConsulta()
        {
            InitializeComponent();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = " ";
            rtxResult.Text = " ";
            lblSexo.Text = " ";

        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {

            if (chkAlterar.Checked)
            {
                rtxResult.Text += "\nUsuário: " + txtNome.Text + "\nStatus: Alterar. \n";
            
            }

            if (chkConsultar.Checked)
            {

                rtxResult.Text += "\nUsuário: " + txtNome.Text + "\nStatus: Consultar. \n";
            
            }

            if (chkExcluir.Checked)
            {

                rtxResult.Text += "\nUsuário: " + txtNome.Text + "\nStatus: Excluir. \n";
            
            
            }

            if (chkIncluir.Checked)
            {

                rtxResult.Text += "\nUsuário: " + txtNome.Text + "\nStatus: Incluir. \n";
            
            
            }

            if (rbFeminino.Checked)
            {

                lblSexo.Text = "Feminino \n";

            }
            else 
            {

                lblSexo.Text = "Masculino \n";
            
            }

        }

      

        
    }
}
