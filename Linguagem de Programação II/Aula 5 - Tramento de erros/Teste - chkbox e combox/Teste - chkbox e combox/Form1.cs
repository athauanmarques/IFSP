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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            lblUsuario.Text = "Usuário: " + txtUsuario.Text;

            if (chkAlterar.Checked)
            {
                lblPerm.Text += "Permissões: Alterar"; 
            
            }
            if (chkConsultar.Checked)
            {

                lblPerm.Text += "Permissões: Consultar"; 
            
            }
            if (chkExcluir.Checked)
            { 
                lblPerm.Text += "Permissões: Excluir"; 
            
            }

            if (chkIncluir.Checked)
            {

                lblPerm.Text += "Permissões: Incluir"; 
            
            }

            if (rbMasculina.Checked)
            {

                lblSexo.Text = "Sexo: Masculino";

            }
            else
            {
                lblSexo.Text = "Sexo: Feminino";
            
            }


        }

       

      
    }
}
