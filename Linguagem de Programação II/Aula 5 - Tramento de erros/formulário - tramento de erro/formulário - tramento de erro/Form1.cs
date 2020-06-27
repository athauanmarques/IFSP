using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace formulário
{
    public partial class frmFormulario : Form
    {
        public frmFormulario()
        {
            InitializeComponent();
        }

        private static void validaNome(string nome)
        {

            if (nome.Trim().Length < 3)
            {
                string msg = " O nome deve conter no minimo 3 caracteres";
                ApplicationException e = new ApplicationException(msg); // explicação do erro visual studio
                throw e;
            
            }
        
        }


        private static void validaSenha(string senha)
        {

            if (senha.Trim().Length < 4)
            {
                string msg = " O nome deve conter no minimo 4 caracteres";
                ApplicationException e = new ApplicationException(msg);
                throw e;
            }
        }
        
         private static void TestaSenha(string senha, string repete)
        {          
                
            if (senha!= repete)
            {
                string msg = " O nome deve ser igual repete";
                ApplicationException e = new ApplicationException(msg);
                throw e;
            }

        }


         private static void validaData(DateTime data)
         {
             //Sempre for manipular data devemos usar ("date")

             DateTime dtInicial = Convert.ToDateTime("01/01/1960"); 
             DateTime dtFinal = Convert.ToDateTime("31/12/2000");
             DateTime dtNasc = Convert.ToDateTime("01/01/1960");

             if (dtNasc.Date < dtInicial.Date || dtNasc.Date > dtFinal.Date)
             {
                 string msg = " Data inválida";
                 ApplicationException e = new ApplicationException(msg);
                 throw e;
             }
        
         }


        private void bntOK_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                validaNome(nome); // chama a função de nome


                string senha = txtSenha.Text;
                validaSenha(senha); // chama a função valida senha

                string repete = txtRepetir.Text;
                TestaSenha(senha, repete); // são duas parâmetro de funções

                DateTime data = Convert.ToDateTime(txtData.Text); // convert para ToDateTime
                validaData(data);

                lblStatus.Text = "incluido com sucesso";

            }
            catch (ApplicationException a) // mensagem do aplicativo que vc criou
            {
                lblStatus.Text = a.Message;
            }
            catch (Exception x) // mensagem do aplicativo
            {
                lblStatus.Text = x.Message;

            }



        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            lblStatus.Text = " ";
           
        }

       
        
    }
}
