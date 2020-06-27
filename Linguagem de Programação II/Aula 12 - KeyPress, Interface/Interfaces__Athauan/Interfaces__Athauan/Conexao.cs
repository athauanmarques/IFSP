using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    public abstract class Conexao // obrigando classe q herdam e implementa
    {
        private string status;
        public string Status
        {

            get { return status; }
        
        }

        public void Conectar()
        { }
        public void Desconectar()
        { }

        public abstract void Alterar();
        public abstract void Excluir();
        public abstract void Incluir();



    }
}
