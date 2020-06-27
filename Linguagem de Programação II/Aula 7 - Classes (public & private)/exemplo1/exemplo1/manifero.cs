using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo1
{
    public class manifero
    {
        //Atributos
        public string nome;
        public int idade;
        public string sexo;
        public string Status;
        //Métoro
        public void andar() // é uma função 
        {
            Status = "incluindo " + nome + " " + idade + " " + sexo;


        }


    }
}
