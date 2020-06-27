using System;
using System.Collections.Generic;
using System.Text;

namespace Aereas
{
    public class PrimeiraClasse : Passagem
    {      
        public PrimeiraClasse(string origem, string destino, bool classe)
            : base(origem, destino, classe)
        {
        }

        public override double CalculoPassagem()
        {
            return base.CalculoPassagem() * 1.3F;
        }
    }
}
