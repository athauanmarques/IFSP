using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolhaPgto
{
    public abstract class Empregado
    {
        //atributos
        private string nome;
        private string sobrenome;

        //propriedades
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Sobrenome
        {
            get { return sobrenome; }
            set { sobrenome = value; }
        }
        //construtor
        public Empregado(string nome, string sobrenome )
        {
            nome = Nome;
            sobrenome = Sobrenome;
        }
        //metodo
        public abstract double Ganhos();
    }
}
