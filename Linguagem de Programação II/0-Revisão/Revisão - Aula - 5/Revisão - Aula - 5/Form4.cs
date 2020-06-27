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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private static void validaNome(string nome)
        {
            try
            {
                if (nome.Trim().Length < 3)
                {

                    string mensagem = " o nome de conter o minino 3 caractéres ";
                    ApplicationException e = new ApplicationException(mensagem);
                    throw e;

                }
            }
            catch
            {

                MessageBox.Show("Ocorreu um erro na valiação de nome", "Erro Validade", MessageBoxButtons.RetryCancel);
            
            }
        }

        private static void TestaSenha(string senha, string repete)
    {
        try
        {
            if (senha != repete)
            {
                string mensagem = " a senha tem que ser igual ";
                ApplicationException e = new ApplicationException(mensagem);
                throw e;
            }
        }
        catch
        {

            MessageBox.Show("Ocorreu um errado no tratamento de senha", "Senha erro", MessageBoxButtons.YesNo);
        
        }
     }
        private static void validaSenha(string senha)
        {

            if (senha.Trim().Length < 4)
            {
                string mensagem = " O nome deve conter no minimo 4 caracteres";
                ApplicationException e = new ApplicationException(mensagem);
                throw e;
            }
        
        }


        private static void validaData(DateTime data)

        {

            DateTime dtInicial = Convert.ToDateTime("01/01/1960"),
                     dtFinal = Convert.ToDateTime("01/01/2000"),
                     dtNasc = Convert.ToDateTime("05/2/1962");

            if (dtNasc.Date < dtInicial.Date || dtNasc.Date > dtFinal.Date)
            {
                string mensagem = "Data inválida ";
                ApplicationException e = new ApplicationException(mensagem);
                throw e;
            }
        
        
        }


        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtNascimento.Text = " ";
            txtNome.Text = " ";
            txtRepetir.Text = " ";
            txtSenha.Text = " ";
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                validaNome(nome);


                string senha = txtSenha.Text;
                validaSenha(senha); // chama a função valida senha

                string repete = txtRepetir.Text;
                TestaSenha(senha, repete); // são duas parâmetro de funções

                DateTime data = Convert.ToDateTime(txtNascimento.Text); // convert para ToDateTime
                validaData(data);

                lblMensagem.Text = "incluido com sucesso";
            }
            catch
            {

                MessageBox.Show("Erro");
            
            
            }
        }

       
    }
}
