using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Modelos
{
    public class ModelosClientes
    {
        private int idClientes;
        public int IdClientes { get {return idClientes;} set {idClientes = value;} }

        private string nome;
        public string Nome { get { return nome; } set { nome = value; } }

        private string endereco;
        public string Endereco { get { return endereco; } set { endereco = value; } }

        private string telefone;
        public string Telefone { get { return telefone; } set { telefone = value; } }

        private string cidade;
        public string Cidade { get { return cidade; } set { cidade = value; } }

        private string uf;
        public string Uf { get { return uf; } set { uf = value; } }

        private string referencias;
        public string Referencias { get { return referencias; } set { referencias = value; } }



    }
}
