using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace ProvaTreino.DAL
{
    public class Dados
    {
        public static string Conectar
        {

            get { return "serve=localhost; Database=treinoProva; Uid=roor; Pwd='', Connect Timeout = 30"; }
        }
    }
}
