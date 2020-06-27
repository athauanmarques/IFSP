using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Modelos
{
    public class ModelosUsuarios
    {
        private int idUsuarios;
        public int IdUsuarios { get { return idUsuarios; } set { idUsuarios = value; } }

        private string usuario;
        public string Usuario {get {return usuario;} set {usuario = value;}}

        private string funcao;
        public string Funcao { get { return funcao; } set { funcao = value; } }

        private string senha;
        public string Senha {get {return senha;} set {senha = value;}}

        private string tipoAcesso;
        public string TipoAcesso{get {return tipoAcesso;} set {tipoAcesso = value;}}

        private string foto;
        public string Foto
        {
            get { return foto; }
            set { foto = value; }



        }
    }
}
