using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;

//------- Ultilizaremos apenas os método para conexão do Banco -----------------

namespace AcessaDados
{
    public class Conexao
    {
        public MySqlConnection c = new MySqlConnection();
        public string Status = ""; //Iniciando a variavel Status; 

        public void Conectar() // método que conectará ao banco de dados
        {
            string s = "Server='localhost';Database='pizzaria';Uid='root';Pwd='a0405'"; // é o caminho que esta contido no workbech
            c.ConnectionString = s; // estanciado c utilizando o ConnectionString,  o 's' é o caminho do banco do workbeach
            c.Open(); // abrindo a estancia MySqlConnection
            Status = "Conexão aberta!!"; // variavel recebendo palavra que sera exibida
        }

        public void Desconectar() // Método que desconecta
        {
            c.Close();
            Status = "Conexão Fechada!!";
        }
    }
}
