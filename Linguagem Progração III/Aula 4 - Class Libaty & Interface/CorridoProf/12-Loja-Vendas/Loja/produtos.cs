using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loja
{
    class produtos
    {
        private int codigo;
        private string produto;
        private int estoque;
        private double preco;
        private string status;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Produto
        {
            get { return produto; }
            set { produto = value; }
        }
        public int Estoque
        {
            get { return estoque; }
            set { estoque = value; }
        }
        public double Preco 
        {
            get { return preco; }
            set { preco = value; }
        }
        public string Status 
        {
            get { return status; }
        }

        //método da classe
        public void Incluir()
        {
            status = "Código: " + codigo + ", Produto: " + produto + ", Estoque: " + estoque + ", Preço: " + preco.ToString("0.00") + " INCLUIDO!";
        }

        public void Alterar()
        {
            status = "Código: " + codigo + ", Produto: " + produto + ", Estoque: " + estoque + ", Preço: " + preco.ToString("0.00") + " ALTERADO!";
        }

        public void Excluir()
        {
            status = "Código: " + codigo + ", Produto: " + produto + ", Estoque: " + estoque + ", Preço: " + preco.ToString("0.00") + " EXCLUIDO!";
        }

    }
}
