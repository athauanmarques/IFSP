using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LojaWin.Dal;
using LojaWin.Modelos;
using System.Data;

namespace LojaWin.Bll
{
    public class ProdutosBLL
    {
         
        ProdutosDAL objProdutosDal = new ProdutosDAL();

        private bool resposta;

        private string mensagem;

        public string Mensagem
        {
            get { return mensagem; }
        }
        
      
        public string Inserir(ModelosProdutos produto)
        {
            try
            {
                if (produto.Produto.Trim().Length == 0)
                {
                    mensagem = "O nome é obrigatório";
                }
                else if (produto.Produto.Trim().Length > 50)
                {
                    mensagem = "O nome do produto é muito extenso!";
                }
                else if (produto.Produto.Trim().Length < 0)
                {
                    mensagem = "Errado Burro";
                }
                else
                {
                    produto.Produto = produto.Produto.ToLower();
                    objProdutosDal.InserirProdutos(produto);
                    mensagem = "Usuário incluído com sucesso!";
                }
                return mensagem;
            }
            catch
            {
                throw new Exception("Não foi possível incluir o usuário no cadastro!");
            }
        }

        public string Alterar(ModelosProdutos produto)
        {
            try
            {
                if (produto.IdProdutos < 1)
                {
                    mensagem = "O nome do IdProduto é obrigatório";
                }
                else if (produto.Produto.Trim().Length > 50)
                {
                    mensagem = "O nome do produto é muito extenso!";
                }
                else if (produto.Produto.Trim().Length < 0)
                {
                    mensagem = "Errado Burro";
                }
                else
                {
                    produto.Produto = produto.Produto.ToLower();
                    objProdutosDal.AlterarProdutos(produto);
                    mensagem = "Ptoduto incluído com sucesso!";
                }
                return mensagem;
            }
            catch
            {
                throw new Exception("Não foi possível incluir o usuário no cadastro!");
            }
        }

              public bool Excluir(ModelosProdutos produto)
        {
            try
            {
                if (produto.IdProdutos < 1)
                {
                    mensagem = "O nome do IdProduto é obrigatório";
                }
                
                else
                {
                  
                   resposta = objProdutosDal.ExcluirProdutos(produto);
                    mensagem = "Ptoduto exluido com sucesso!";
                }
               return resposta;
            }
            catch
            {
                throw new Exception("Não foi possível incluir o usuário no cadastro!");
            }
        }
              public ListaProdutos Listagem(string filtro)
              {
                  return objProdutosDal.Listagem(filtro);
              }

              public DataTable produtosListagemEmFalta()
              {
                  return objProdutosDal.listaProdutosEmFalta();
              }


    }
}
