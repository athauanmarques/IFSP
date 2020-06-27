using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; // referencia do Banco de Dados
/* clikar com botão esquerdo no Projeto.df
    copie o endereço de memoria Full path 
 */

namespace ControleProjetos
{
    public partial class cadastroContato : Form
    {
        public cadastroContato()
        {
            InitializeComponent();
        }

        private void cadastroContato_Load(object sender, EventArgs e)
        {
            //string conexão

            //variavel armazena a string de conexão
            String strConn;

            // colocar o endereço de projeto
            strConn = @"Data Source = .\SQLEXPRESS; 
                       AttachDbFilename = C:\Users\Aluno\Desktop\ControleProjetos - 2\ControleProjetos\Projetos.mdf;
                       Integrated Security = True; User Instance = True";

            //para verificar se deu erro no banco
            //strConn = ControleProjetos.Properties.Settings.Default["ProjetosConnectionString"].ToString();
            /*
             * 
              entre no app config e copie no 1ª add name = ControleProjetos.Properties.Settings.ProjetosConnectionString
                e acrescente Default como esta descrito a cima.
             * /
         
            /*
             inicia a atribui valor de string de conexão
             * SqlConnection conn = new SqlConnection();
             */
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = strConn;


            //Executa os comandos do SqlCommand
            SqlCommand cmd = new SqlCommand();
            //cmd.CommandText = recebe os comandos do sql

            //Count retorna o numero de registro da tabela
            cmd.CommandText = "Select count(*) from Contato"; 
            // no caso este um dos comandos do sql, vai contar os numeros de registros da tabela
           
            //objeto de conexão Connection - executa comando
            //e recebe qual conexão é utilizado
            cmd.Connection = conn;

            //Abre - executa comando e fecha o Banco de Dados
            conn.Open();
            label1.Text = cmd.ExecuteScalar().ToString();
            conn.Close();      
        }
    }
}