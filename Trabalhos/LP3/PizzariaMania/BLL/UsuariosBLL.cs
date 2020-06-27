using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pizzaria.Modelos;
using System.Data;
using Pizzaria.DAL;


namespace Pizzaria.BLL
{
    public class UsuariosBLL
    {
        UsuarioDAL objUsuario = new UsuarioDAL();

        public UsuarioListar Listragem(string pfiltro)
        {

            return objUsuario.ListragemUsuario(pfiltro);
        }

        public bool AutenticarAcessos(string nome)
        {
            
            return objUsuario.AutenticarAcessos(nome);
        }

        private string mensagem;
        public string Mensagem { get {return mensagem; }  set {mensagem = value;}}

        public string AlterarUsuario(ModelosUsuarios usuario)
        {

            if (usuario.Senha.Trim().Length > 12)
            {

                mensagem = "A senha é muito longo, por gentileza digite novamente";
            }
            else 
            {
                objUsuario.AlterarUsuario(usuario);
            
            }
            return mensagem;
        }

        public bool Excluir_Conta(ModelosUsuarios usuario)
        {
            
           
            try
            {
                bool resposta = false;
                if (usuario.IdUsuarios < 1)
                {
                    mensagem = "Selecione o cliente antes de excluí-lo";
                }
                else
                {

                    resposta = objUsuario.ExcluirConta(usuario);
                    mensagem = "Conta removida";
                }
                return resposta;
            }
            catch
                 {
                mensagem = "não pode ser excluído!";
                throw new Exception(mensagem);
                
                 }
            }

        

        public bool Login(ModelosUsuarios usuario)
        {

            if (usuario.Usuario.Length > 15 || usuario.Senha.Length < 6 || usuario.Senha.Length > 10)
            {
                return false;
            }
            else
            {
                return objUsuario.Login(usuario);
               
            }

        }

        public void CadastrarUsuarios(ModelosUsuarios usuarios)
        { 
        
            try{
                if (usuarios.Senha.Trim().Length == 0)
                {
                    mensagem = "Por favor informe a sua senha";
                }
                else
                {
                    objUsuario.CadastrarUsuario(usuarios);
                    mensagem = "Usuário Cadastrado com êxito.";
                        
                }
            
            }
             catch
            {
                mensagem = "Usuario não pode ser incluido!";
                throw new Exception(mensagem);
            }
        
        }


    }
}
