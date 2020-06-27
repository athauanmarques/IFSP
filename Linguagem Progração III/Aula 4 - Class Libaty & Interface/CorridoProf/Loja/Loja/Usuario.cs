using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja
{
    class Usuario
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
            get { return status; }
        }

        public void Incluir()
        {
            status = "Codigo: " + codigo
                + " Nome: " + nome
                + " incluido!!";
        }
    }
}
