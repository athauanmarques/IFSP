using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LojaWin.Modelos;
using LojaWin.Dal;

namespace LojaWin.Bll
{
    public class ClientesBll
    {
        private string mensagem;
        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }
        private bool resposta;
        public bool Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }

        ClientesDal objClientesDal = new ClientesDal();

        public string incluir(ModeloClientes cliente)
        {
            try
            {
                if (cliente.Nome.Trim().Length == 0)
                {
                    mensagem = "O nome do cliente é obrigatório";
                }
                else if (cliente.Nome.Length > 50)
                {
                    mensagem = "O cliente não pode ter mais que 50 caracteres!";
                }
                else if (cliente.Email.Trim().Length == 0)
                {
                    mensagem = "O e-mail do cliente é obrigatório";
                }
                else if (cliente.Email.Length > 50)
                {
                    mensagem = "O e-mail não pode ter mais que 50 caracteres!";
                }
                else
                {
                    cliente.Nome = cliente.Nome.ToLower();
                    cliente.Email = cliente.Email.ToLower();
                    objClientesDal.incluir(cliente);
                    mensagem = "Cliente incluído com sucesso";
                }
                return mensagem;
            }
            catch
            {
                mensagem = "Não foi possível inserir o cliente!";
                throw new Exception(mensagem);
            }
        }

        public string alterar(ModeloClientes cliente)
        {
            try
            {
                if (cliente.Nome.Trim().Length == 0)
                {
                    mensagem = "O nome do cliente é obrigatório";
                }
                else if (cliente.Nome.Length > 50)
                {
                    mensagem = "O cliente não pode ter mais que 50 caracteres!";
                }
                else if (cliente.Email.Trim().Length == 0)
                {
                    mensagem = "O e-mail do cliente é obrigatório";
                }
                else if (cliente.Email.Length > 50)
                {
                    mensagem = "O e-mail não pode ter mais que 50 caracteres!";
                }
                else
                {
                    cliente.Nome = cliente.Nome.ToLower();
                    cliente.Email = cliente.Email.ToLower();
                    cliente.Telefone = cliente.Telefone;
                    objClientesDal.alterar(cliente);
                    mensagem = "Cliente alterado com sucesso";
                }
                return mensagem;
            }
            catch
            {
                mensagem = "Não foi possível alterar o cliente!";
                throw new Exception(mensagem);
            }
        }

        public bool excluir(ModeloClientes cliente)
        {
            try
            {
                bool resposta = false;
                if (cliente.IdCliente < 1)
                {
                    mensagem = "Selecione o cliente antes de excluí-lo";
                }
                else
                {
                    resposta = objClientesDal.Excluir(cliente);
                    mensagem = "Cliente excluído com sucesso!";
                }
                return resposta;
            }
            catch
            {
                mensagem = "Cliente não pode ser excluído!";
                throw new Exception(mensagem);
            }
        }

        public ListaClientes listagem(string filtro)
        {
            return objClientesDal.listagem(filtro);
        }
    }
}
