using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revisão___Aula___9
{
    public class Mestrado: Graduacao
    {
        public double resultado;

        public double MestradoCal ()
        {

            resultado = vlGraduacao * 0.10 + vlGraduacao;
            return resultado;
        
        }

    }
}
