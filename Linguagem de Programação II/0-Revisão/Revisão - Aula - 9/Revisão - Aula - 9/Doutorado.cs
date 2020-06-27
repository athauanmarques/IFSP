using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revisão___Aula___9
{
    public class Doutorado : Graduacao
    {
        public double resultado;

        public double DouCal()
        {

            resultado = vlGraduacao * 0.20 + vlGraduacao;
            return resultado;
        
        }
    }
}
