using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mensalidade
{
    public class Mestrado
    {
        public double resultado;

        public double mestrado(double valor) 
        {
            resultado = valor * 0.10 + valor;
            return resultado;
        }
    }
}
