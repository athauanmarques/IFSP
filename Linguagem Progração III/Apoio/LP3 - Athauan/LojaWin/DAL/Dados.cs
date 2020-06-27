using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojaWin.DAL
{
    public class Dados
    {
        public static string conexao
        {

            get { return "server=localhost; Database=loja; Uid=root; Connect Timeout=30;"; }
             
        }
    }
}
