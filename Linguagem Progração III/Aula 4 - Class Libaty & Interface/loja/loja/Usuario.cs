using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace loja
{
    public class Usuario
    {
        private int codigo;
        private string nome;
        private string status;

        public int Codigo
        {

            get { return codigo; }
            set { codigo = value; }

        }

        public string Nome
        {

            get { return nome; }
            set { nome = value; }
            
        }

        public string Status
        {

            get { return this.status; } //this(seleciona tudo dentro desse metodo) vai ser utilizado apenas nessa classe
        }


        public void Incluir()
        {
            status = "codigo: " + codigo + " - Nome: " + nome;
        
        }

    
    
    
    }
}
