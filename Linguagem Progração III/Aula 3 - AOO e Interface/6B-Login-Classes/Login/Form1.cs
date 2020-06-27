using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1 : Form
    {
        login l = new login();
        public Form1()
        {
            InitializeComponent();
        }

        private static void ValidaNome(string nome)
        {
            if (nome.Trim().Length < 3)
            {
                string msg = "O nome deve ter no minimo 3 caracter";
                ApplicationException e = new ApplicationException(msg);
                throw e;
            }
        }

        private static void TestaSenha(string senha)
        {           
            if (senha.Trim().Length < 4)
            {
                string msg = "A senha deve ter no minimo 4 caracter";
                ApplicationException e = new ApplicationException(msg);
                throw e;
            }
        }

        private static void ValidaSenha(string senha, string repeat)
        {            
            if (repeat != senha)
            {
                string msg = "A duas senhas devem ser iguais";
                ApplicationException e = new ApplicationException(msg);
                throw e;
            }

        }
                
        private static void ValidaData(DateTime data)
        {
            DateTime dataInicial = Convert.ToDateTime("01/01/1960");
            DateTime dataFinal = Convert.ToDateTime("31/12/1990");
            DateTime dataNasc = Convert.ToDateTime(data);

            if (dataNasc.Date < dataInicial.Date || dataNasc.Date > dataFinal.Date)
            {
                string msg = "Data Nascimento inválida!";
                ApplicationException e = new ApplicationException(msg);
                throw e;

            }            
        }


        private void btnIncluir_Click(object sender, EventArgs e)
        {
            try
            {
                string nome = txtNome.Text;
                ValidaNome(nome);

                string senha = txtSenha.Text;
                TestaSenha(senha);
                
                string repete = txtRepetir.Text;
                ValidaSenha(senha, repete);
                
                DateTime data = Convert.ToDateTime(txtNasc.Text);
                ValidaData(data);

                lblStatus.Text = "Nota Registrada";

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

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            l.Codigo = Convert.ToInt32(txtCodigo.Text);
            l.Nome = txtNome.Text;

            l.Buscar(l.Codigo);
         //   l.Buscar(l.Nome);

            lblStatus.Text = l.Status;

        }
    }
}
