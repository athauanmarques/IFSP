using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojaWin.Modelos
{
    public class ModeloClientes
    {
        private int idcliente;
        public int IdCliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        private string email;
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        private string telefone;
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
    }
}
