using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojaWin.Modelos
{
    public class ModeloProdutos
    {
        private int idproduto;
        public int Idproduto
        {
            get { return idproduto; }
            set { idproduto = value; }
        }
        private string produto;
        public string Produto
        {
            get { return produto; }
            set { produto = value; }
        }
        private decimal preco;
        public decimal Preco
        {
            get { return preco; }
            set { preco = value; }
        }
        private int estoque;
        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }
    }
}
