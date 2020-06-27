using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mensalidade
{
    class Doutorado
    {
        public double resultado;

        public double doutorado(double valor)
        {
            resultado = valor * 0.20 + valor;
            return resultado;
        }
    }
}
