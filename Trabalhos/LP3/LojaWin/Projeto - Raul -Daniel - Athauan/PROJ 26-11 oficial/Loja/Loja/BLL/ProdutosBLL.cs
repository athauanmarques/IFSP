using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using Loja.Modelos;
using Loja.DAL;

namespace Loja.BLL
{
    public class ProdutosBLL
    {
       
        public void IncluirP(ProdutoInformation produto)
        {
            // Nome do produto é obrigatório
            if (produto.Nome.Trim().Length == 0)
            {
                throw new Exception("O nome do produto é obrigatório.");
            }
            // O preço do produto não pode ser negativo
            if (produto.Preco < 0)
            {
                throw new Exception("Preço do produto não pode ser negativo.");
            }
            // O estoque do produto não pode ser negativo
            if (produto.Estoque < 0)
            {
                throw new Exception("Estoque do produto não pode ser negativo.");
            }
            //Se tudo estiver ok, chama a rotina de gravação
            ProdutosDAL obj = new ProdutosDAL();
            obj.IncluirP(produto);
        }
        public void AlterarP(ProdutoInformation produto)
        {
            ProdutosDAL obj = new ProdutosDAL();
            obj.AlterarP(produto);
        }
        public void ExcluirP(int codigo)
        {
            ProdutosDAL obj = new ProdutosDAL();
            obj.ExcluirP(codigo);
        }
        public DataTable ListagemP()
        {
            ProdutosDAL obj = new ProdutosDAL();
            return obj.ListagemP();
        }
    }
}
