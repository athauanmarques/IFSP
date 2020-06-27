using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProvaTreino.Modelos
{
    public class ModelosAluno
    {
        private int codigo;
        private string nome;
        private int idade;
        private string endereco;
        private string cidade;
        private string prontuario;

        public int Codigo{ get {return codigo;} set {codigo = value;} }
        public string Nome { get { return nome; } set { nome = value; } }
        public int Idade { get { return idade; } set { idade = value; } }
        public string Endereco { get { return endereco; } set { endereco = value; } }
        public string Cidade { get { return cidade; } set { cidade = value; } }
        public string Prontuario { get { return prontuario; } set { prontuario = value; } }



    }
}
