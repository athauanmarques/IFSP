using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojaWin.Modelos
{
    public class ModeloUsuarios
    {
        private int idUsuario;
        public int IdUsuario
        {
            get { return idUsuario; }
            set { idUsuario = value; }
        }

        private string nome;
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        private string senha;
        public string Senha
        {
            get { return senha; }
            set { senha = value; }
        }
    }
}
