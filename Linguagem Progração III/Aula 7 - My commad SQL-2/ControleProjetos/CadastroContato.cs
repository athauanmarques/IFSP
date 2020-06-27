using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ControleProjetos
{
    public partial class CadastroContato : Form
    {
        public CadastroContato()
        {
            InitializeComponent();
        }

        private void CadastroContato_Load(object sender, EventArgs e)
        {
            //string de conexão

            //variavel armazena a string de conexão
            String strConn;
          /*strConn = @"Data Source = .\SQLEXPRESS; 
                       AttachDbFilename = C:\Users\Aluno\Desktop\Aula 7 - My commad SQL\ControleProjetos.mdf;
                       Integrated Security = True; User Instance = True";
            
      */     
            //VERIFICAR CONEXÃO COM ERRO
           strConn = ControleProjetos.Properties.Settings.Default["ProjetosConnectionString"].ToString();

            

            //inicia e atribui valor da string de conexão
            //SqlConnection conn = new SqlConnection();
            SqlConnection conn;
            conn = new SqlConnection();
            conn.ConnectionString = strConn;

            //SQLCommand - executa comandos SQL
            SqlCommand cmd = new SqlCommand();

            //CommandText - recebe os comandos SQL
            //Count retorna o numero de registro da tabela
            cmd.CommandText = "Select count(*) from Contato";
            
            //objeto de conexão Connection - executa comando
            //e recebe qual conexão é utilizada
            cmd.Connection = conn;

            //Abre - executa comando e fecha o Banco de dados
            conn.Open();
            label1.Text = cmd.ExecuteScalar().ToString();
            conn.Close();

        }
    }
}
