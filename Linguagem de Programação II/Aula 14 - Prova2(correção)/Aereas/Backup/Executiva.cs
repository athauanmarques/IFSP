using System;
using System.Collections.Generic;
using System.Text;

namespace Aereas
{
    public class Executiva : Passagem
    {
        public Executiva(string origem, string destino, bool classe)
            :base(origem,destino,classe)
        {
        }

        public override float calculoPassagem()
        {
            return base.calculoPassagem() * 1.2F;
        }
    }
}
