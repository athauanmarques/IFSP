using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemploInterface
{
    public abstract class Conexao
    {
        private string status;
        
        public string Staus
        {

            get { return status; }
            set { value = status; }
        
        }

        public void Conectar()
        { }
        public void Desconectar()
        { }
        public abstract void Alterar();
        public abstract void Incluir();
        public abstract void Excluir();
    }
}
