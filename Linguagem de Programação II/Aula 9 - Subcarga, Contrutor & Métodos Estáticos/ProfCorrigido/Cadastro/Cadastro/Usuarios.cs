using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cadastro
{
    class Usuarios
    {
        private string nome;
        private int codigo;
        private string status;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Status
        {
            get { return status; }
            set { value = status; }
        }

        public void Buscar(int codigo)
        {
            status = "Código: " + codigo + " encontrado";
        }
        public void Buscar(string nome)
        {
            status = "Nome: " + nome + " encontrado";
        }
    }
}
