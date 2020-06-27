using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagrama
{
    public class Cursos : ICursos
    {
        private string codigo;
        private string curso;
        private string duracao;
        private string preco;

        public string Codigo
        {

            get { codigo = value; }
            set {return codigo;}
        
        }

        public string Curso
        {

            get { curso = value; }
            set { return curso; }

        }
        public string Duracao
        {

            get { duracao = value; }
            set { return duracao; }

        }

        public string Preco
        {

            get { preco = value; }
            set { return preco; }

        }
    }
}
