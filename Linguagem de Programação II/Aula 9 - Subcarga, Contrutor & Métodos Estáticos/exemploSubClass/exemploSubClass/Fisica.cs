using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemploSubClass
{
    class Fisica : Cliente // Fisica esta erdando Cliente
    {
        private int cpf;

        public int Cpf
        {

            get {return cpf; }
            set { cpf = value; }
        }

        public void Incluir()
        {

            Status = "Codigo: " + Cod;
            Status += "\n Nome: " + Nome;
            Status += "\n Codigo: " + cpf + " incluido";
        
        
        }

    }
}
