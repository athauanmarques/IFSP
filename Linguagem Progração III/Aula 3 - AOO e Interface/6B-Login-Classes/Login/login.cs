using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Login
{
    class login
    {
        private int codigo;
        private string nome;
        private string status;

        public string Nome
        {

            get { return nome; }
            set { value = nome;}
        
        }

        public string Status
        {

            get { return status; }
            set { value = status; }

        }

        public int Codigo
        {

            get { return codigo; }
            set { value = codigo; }

        }

        public void Buscar(int codigo)
        {

            status = "Codigo: " + codigo;
        
        }

        public void Buscar(string nome)
        {

            status = "Nome: " + nome;

        }





    }
}
