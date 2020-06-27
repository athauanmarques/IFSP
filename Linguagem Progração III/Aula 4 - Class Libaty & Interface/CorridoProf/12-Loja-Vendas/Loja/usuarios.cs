using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja
{
    class usuarios
    {
        //atributos tipos de campos
        private int codigo;
        private string nome;
        private string status;

        

        //propriedades
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

        //método da classe
        public void Incluir()
        {
            status = "Código: " + codigo + ", Nome: " + nome + " INCLUIDO!";
        }
    }
}
