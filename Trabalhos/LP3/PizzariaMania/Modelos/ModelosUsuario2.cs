using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Modelos
{
    public class ModelosUsuario2
    {
         

        private string funcao;
        public string Funcao { get { return funcao; } set { funcao = value; } }

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
