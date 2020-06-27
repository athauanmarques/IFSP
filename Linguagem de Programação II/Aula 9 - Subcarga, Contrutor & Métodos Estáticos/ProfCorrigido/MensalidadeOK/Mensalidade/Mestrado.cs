using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mensalidade
{
    public class Mestrado : Graduacao
    {
        public double resultado;

        public double CalcMest() 
        {
            resultado = MensGrad * 0.10 + MensGrad;
            return resultado; 
        }   
    }
}
