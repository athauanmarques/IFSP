using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LojaWin.Modelos;
using LojaWin.DAL;

namespace LoginWin.BLL
{
    public class usuariosBll
    {
        //camada dal
        usuariosDal objUsuariosDal = new usuariosDal();

        public bool Login(ModeloUsuarios usuario)
        {

            if (usuario.Nome.Length > 15 || usuario.Senha.Length < 6 || usuario.Senha.Length > 10)
            {

                return false;
            }
            else 
            {
                //convertendo para minúsculas
                usuario.Nome = usuario.Nome.ToLower();

                //retorna o resultado da autenticação do usuário, ou seja falso ou verdadeiro da camada DAL
                return objUsuariosDal.Login(usuario);

            }
        }
    }
}
