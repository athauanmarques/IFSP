using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios
{
    public class Produtos
    {
        public int codigo;
        public string status;


        public void Incluir()
        {

            status = "Codigo: " + codigo + " Incluindo";
        }

    }
}
