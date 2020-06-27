using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios
{
    //não esqueça de fazer a referencia antes de 
    //usar no form do projeto Loja

    // adicione a palavra chave "public" antes da classe
     public class Produtos
    {
        private int codigo;
        private string status;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public void Incluir()
        {
            Status = "Codigo: " + codigo + " incluido";
        }
    }
}
