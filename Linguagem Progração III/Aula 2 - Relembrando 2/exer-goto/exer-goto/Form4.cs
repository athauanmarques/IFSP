using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace exer_goto
    //Terminar o execicios
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public static void validaNome(string nome)
        {

            if (nome.Trim().Length < 3)
            {
                string msg = "Nome invalido";
                ApplicationException e = new ApplicationException(msg);
                throw e;
             
            }
        
        }

        public static void validaSenha(string senha)
        {

            if (senha.Trim().Length < 4)
            {
                string msg = "Senha invalido";
                ApplicationException e = new ApplicationException(msg);
                throw e;

            }
        }
            
            public static void Data(DateTime data)
            {
            
                DateTime dtInicial = Convert.ToDateTime("01/01/1960");
                DateTime dtFinal = Convert.ToDateTime("31/12/1990");
                DateTime dtNasc = Convert.ToDateTime(data);

                if (data.Date < dtInicial.Date || data.Date > dtFinal)
                {
                
                 string msg = "Data invalido";
                ApplicationException e = new ApplicationException(msg);
                throw e;
                
                }
            
            
            }

        public static void validaSenhaR(string senha, string repitir)
        {

            if (senha != repitir)
            {
                string msg = "Senha invalido senha diferentes";
                ApplicationException e = new ApplicationException(msg);
                throw e;

            }
             
        }


        private void bntIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text, senha = txtSenha.Text, repitir = txtRepetir.Text;
                DateTime data = Convert.ToDateTime(txtData.Text);

                validaNome(nome);
                validaSenha(senha);
                validaSenhaR(senha, repitir);
                Data(data);

            }
            catch (ApplicationException x)
            {
                lblStatus.Text = x.Message;
            }
            catch (Exception x)
            {
                lblStatus.Text = x.Message;
            }
        }
    }
}
