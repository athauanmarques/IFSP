using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revisão___Aula___9
{
    public class Fisica: Cliente
    {
        private double cpf;

        public double Cpf 
        {

            get { return cpf; }
            set { cpf = value;  }
        
        }

        public void Incluir()
        {

            Status = "Codigo: " + Cod;
            Status += "\n Nome: " + Nome;
            Status += "\n Codigo: " + cpf + " incluido";


        }

    }
}
