
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;


namespace Pizzaria.DAL
{
    public class Conexao
    {


        public static string Conectar
        {

            get { return "server=localhost; Database=pizzaria; Uid=root; Pwd='123456'; Connect Timeout = 30;"; }
        }


        
      
    }
}
