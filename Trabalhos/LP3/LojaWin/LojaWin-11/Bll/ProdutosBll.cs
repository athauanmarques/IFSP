using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using LojaWin.Modelos;
using LojaWin.Dal;

namespace LojaWin.Bll
{
    public class ProdutosBll
    {
        private bool resposta = false;
        ProdutosDal objProdutosDal = new ProdutosDal();
        private string mensagem;
        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public void inserir(ModeloProdutos produto)
        {
            if (produto.Produto.Trim().Length == 0)
            {
                mensagem = "O nome do produto é obrigatório!";
            }
            else if(produto.Produto.Trim().Length > 50)
            {
                mensagem = "O nome do produto é superior a 50 caracteres!";
            }
            else if(produto.Preco <= 0)
            {
                mensagem = "Verifique o preço do produto e veja se está em falta!";
            }
            else if (produto.Estoque <= 0)
            {
                mensagem = "Verifique o estoque do produto e veja se está em falta!";
            }
            else
            {
                objProdutosDal.inserir(produto);
                mensagem = "produto inserir com sucesso!";
            }
        }

        public void alterar(ModeloProdutos produto)
        {
            if (produto.Idproduto < 1)
            {
                mensagem = "O Idproduto é obrigatório!";
            }
            if (produto.Produto.Trim().Length == 0)
            {
                mensagem = "O nome do produto é obrigatório!";
            }
            else if (produto.Produto.Trim().Length > 50)
            {
                mensagem = "O nome do produto é superior a 50 caracteres!";
            }
            else if (produto.Preco <= 0)
            {
                mensagem = "Verifique o preço do produto e veja se está em falta!";
            }
            else if (produto.Estoque <= 0)
            {
                mensagem = "Verifique o estoque do produto e veja se está em falta!";
            }
            else
            {
                objProdutosDal.alterar(produto);
                mensagem = "produto alterar com sucesso!";
            }
        }

        public bool excluir(ModeloProdutos produto)
        {
            if (produto.Idproduto < 1)
            {
                mensagem = "Selecione Idproduto antes de excluí-lo!";
            }
            else
            {
                resposta = objProdutosDal.excluir(produto);
                mensagem = "produto inserir com sucesso!";
            }
            return resposta;
        }

        public ListaProdutos listarProdutos(string filtro)
        {
            return objProdutosDal.listagem(filtro);
        }

        public DataTable ListaProdutosEmFalta()
        {
            return objProdutosDal.listaProdutosEmFalta();
        }

        public decimal Preco(int idproduto)
        {
            return objProdutosDal.Preco(idproduto);
        }
    }
}
