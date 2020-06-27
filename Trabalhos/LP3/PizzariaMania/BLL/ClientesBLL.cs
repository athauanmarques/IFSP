using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pizzaria.DAL;
using Pizzaria.Modelos;


namespace Pizzaria.BLL
{
    public class ClientesBLL
    {
        ClientesDAL objCliente = new ClientesDAL();

        private string mensagem;
        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public bool ExcluirClientes(ModelosClientes cliente)
        {
            try
            {
                bool resposta = false;
                if (cliente.IdClientes < 1)
                {
                    mensagem = "Selecione o cliente antes de excluí-lo";
                }
                else
                {
                    resposta = objCliente.ExcluirClientes(cliente);
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
      
        public ModelosLista Listragem(string filtro)
        {

            return objCliente.Listragem(filtro);
        }

        public ModelosLista ListragemNome()
        {
            return objCliente.ListragemNome();
        }

        public string AlterarClientes(ModelosClientes cliente)
        { 
        
            try{

                if (cliente.Nome.Trim().Length == 0 && cliente.Endereco.Trim().Length == 0 && cliente.Telefone.Trim().Length == 0
                   && cliente.Cidade.Trim().Length == 0 && cliente.Uf.Trim().Length == 0)
                {

                    mensagem = "Campos de inclusão de clientes vazios.";
                }

                else if (cliente.Nome.Length > 60)
                {
                    mensagem = "Que nome comprido que vocÊ tem, só são permetidos até 60 caracteres";
                    
                    
                }
                else if (cliente.Telefone.Length > 15)
                {

                    mensagem = "O número de telefone é muito longo.";
                }

             
              else if (cliente.Endereco.Trim().Length == 0)
              {
                  mensagem = "Campos endereço se encontra vazio";
              }


              else if (cliente.Nome.Trim().Length == 0)
              {

                  mensagem = "Campo nome se encontra vazio.";
              }
              else if (cliente.Endereco.Trim().Length == 0)
              {
                  mensagem = "Campo endereço se encontra vazio.";
              }

             
              else if (cliente.Uf.Trim().Length == 0)
              {

                  mensagem = "Selecione a opção UF.";
              }

                else 
                {
                  
                    cliente.Cidade = cliente.Cidade.ToLower();
                    cliente.Endereco = cliente.Endereco.ToLower();
                    cliente.Nome = cliente.Nome.ToLower();
                    cliente.Referencias = cliente.Referencias.ToLower();
                    cliente.Telefone = cliente.Telefone.ToLower();
                    cliente.Uf = Convert.ToString(cliente.Uf.ToLower());
                    objCliente.AlterarClientes(cliente);
                    mensagem = "Cliente alterado com êxito.";
                    
                }

              return mensagem;
                
            }
            
            catch
            {
                throw new Exception("Não foi possível incluir o cliente no cadastro!");
            }

        }

        public string IncluirClientes(ModelosClientes cliente)
        {
           
                try
                {

                    if (cliente.Nome.Trim().Length == 0 && cliente.Endereco.Trim().Length == 0 && cliente.Telefone.Trim().Length == 0
                       && cliente.Cidade.Trim().Length == 0 && cliente.Uf.Trim().Length == 0)
                    {

                        mensagem = "Campos de inclusão de clientes vazios.";
                    }

                    else if (cliente.Nome.Length > 60)
                    {
                        mensagem = "Que nome comprido que vocÊ tem, só são permetidos até 60 caracteres";


                    }
                    else if (cliente.Telefone.Length > 15)
                    {

                        mensagem = "O número de telefone é muito longo.";
                    }


                    else if (cliente.Endereco.Trim().Length == 0)
                    {
                        mensagem = "Campos endereço se encontra vazio";
                    }


                    else if (cliente.Nome.Trim().Length == 0)
                    {

                        mensagem = "Campo nome se encontra vazio.";
                    }
                    else if (cliente.Endereco.Trim().Length == 0)
                    {
                        mensagem = "Campo endereço se encontra vazio.";
                    }


                    else if (cliente.Uf.Trim().Length == 0)
                    {

                        mensagem = "Selecione a opção UF.";
                    }
                    else
                    {
                        // int id = 2;
                        cliente.Cidade = cliente.Cidade.ToLower();
                        cliente.Endereco = cliente.Endereco.ToLower();
                        cliente.Nome = cliente.Nome.ToLower();
                        cliente.Referencias = cliente.Referencias.ToLower();
                        cliente.Telefone = cliente.Telefone.ToLower();
                        cliente.Uf = Convert.ToString(cliente.Uf.ToLower());
                        objCliente.IncluirCliente(cliente);
                        mensagem = "Cliente inserido com êxito.";

                    }
                    return mensagem;

                }

                catch
                {
                    throw new Exception("Não foi possível incluir o cliente no cadastro!");
                }

            }

        
    }
}
