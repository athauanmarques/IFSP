using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mensalidade
{
    public class Doutorado: Graduacao
    {
        public double resultado;

        public double CalcDout()
        {
            resultado = MensGrad * 0.20 + MensGrad;
            return resultado;
        }
    }
}
