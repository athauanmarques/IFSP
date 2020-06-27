using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Text;


namespace Loja.DAL
{
    class Dados
    {

        public static string StringDeConexao
        {
            get
            {
                return "Server='localhost';Database='loja';Uid ='root';Pwd=''";
            }
        }

    }
}
