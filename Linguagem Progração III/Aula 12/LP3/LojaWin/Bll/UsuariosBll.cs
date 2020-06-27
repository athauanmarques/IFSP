using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LojaWin.Modelos;
using LojaWin.Dal;

namespace LojaWin.Bll
{
    public class UsuariosBll
    {
        // Cria uma instancia do objeto da classe UsuariosDal
        UsuariosDal objUsuariosDal = new UsuariosDal();

        private string mensagem;

        public string Mensagem
        {
            get { return mensagem; }
        }

        public bool Login(ModeloUsuarios usuario)
        {
            if (usuario.Nome.Length > 15 || usuario.Senha.Length < 6 || usuario.Senha.Length > 10)
            {
                return false;
            }
            else
            {
                // Converte caracteres para minúsculas
                usuario.Nome = usuario.Nome.ToLower();

                // retorno o resultado da autenticação do usuario, ou seja,
                // falso ou verdadeiro na camada Dal.
                return objUsuariosDal.Login(usuario);
            }
        }

        public string Incluir(ModeloUsuarios usuario)
        {
            try
            {
                if (usuario.Nome.Length > 15)
                {
                    mensagem = "O nome não pode ter mais que 15 caracteres";
                }
                else if (usuario.Senha.Length < 6 || usuario.Senha.Length > 10)
                {
                    mensagem = "A senha deverá ter no mínimo 6 e no máximo 10 caracteres!";
                }
                else
                {
                    usuario.Nome = usuario.Nome.ToLower();
                    objUsuariosDal.Incluir(usuario);
                    mensagem = "Usuário incluído com sucesso!";
                }
                return mensagem;
            }
            catch
            {
                throw new Exception("Não foi possível incluir o usuário no cadastro!");
            }
        }

        public string Alterar(ModeloUsuarios usuario)
        {
            try
            {
                if (usuario.Nome.Length == 0)
                {
                    mensagem = "O nome do usuario é obrigatório! Entre com o nome do usuário";
                }
                else if (usuario.Nome.Length > 15)
                {
                    mensagem = "O nome não pode ter mais que 15 caracteres!";
                }
                else if (usuario.Senha.Length < 6 || usuario.Senha.Length > 10)
                {
                    mensagem = "A senha deverá ter no mímino 6 e máximo 10 caracteres!";
                }
                else
                {
                    usuario.Nome = usuario.Nome.ToLower();
                    objUsuariosDal.Alterar(usuario);
                    mensagem = "Usuário alterado com sucesso!";
                }
                return mensagem;
            }
            catch
            {
                throw new Exception("Não foi possível alterar o usuário no cadastro!");
            }
        }

        public bool Excluir(ModeloUsuarios usuario)
        {
            try
            {
                bool resposta = false;
                if (usuario.IdUsuario < 1)
                {
                    mensagem = "Selecione um usuário antes de excluí-lo!";
                }
                else
                {
                    resposta = objUsuariosDal.Excluir(usuario);
                    mensagem = "Usuário excluído com sucesso!";
                }
                return resposta;
            }
            catch
            {
                throw new Exception("Não foi possível excluir o usuário no cadastro!");
            }
        }

        public ListaUsuarios Listagem(string filtro)
        {
            return objUsuariosDal.Listagem(filtro);
        }
    }
}
