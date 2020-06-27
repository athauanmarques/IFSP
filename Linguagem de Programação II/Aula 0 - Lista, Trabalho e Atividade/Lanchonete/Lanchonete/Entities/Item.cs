using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lanchonete.Entities
{
    /// <summary>
    /// Esta classe representa um item de pedido da lanchonete. O item é
    /// composto por um produto qualquer (que o consumidor escolherá no cardápio),
    /// e uma quantidade representando quantos daquele produto o consumidor deseja.
    /// </summary>
    public class Item
    {
        /// <summary>
        /// O produto escolhido pelo consumidor
        /// </summary>
        public Produto Produto { get; set; }
        /// <summary>
        /// Quantidade de produtos que o consumidor deseja adquirir
        /// </summary>
        public int Quantidade { get; set; }

        /// <summary>
        /// Construtor do item que injeta o produto e a quantidade
        /// </summary>
        /// <param name="produto">O produto escolhido pelo consumidor</param>
        /// <param name="quantidade">Quantidade de produtos que o consumidor deseja adquirir</param>
        public Item(Produto produto, int quantidade)
        {
            this.Produto = produto;
            this.Quantidade = quantidade;
        }

        /// <summary>
        /// Converte o item numa String contendo a descrição do produto e
        /// a quantidade desejada.
        /// </summary>
        /// <returns>Uma String contendo a descrição do produto e a quantidade desejada.</returns>
        public override string ToString()
        {
            // A seguir é criada uma string de espaços em branco
            // que será concatenada após a descrição do produto,
            // para fins de alinhamento na lista de itens do pedido.
            String espacoEmBranco = "";
            int nroEspacos = 23 - this.Produto.Descricao.Length;
            for (int i = 0; i < nroEspacos; i++)
            {
                espacoEmBranco += " ";
            }
            return this.Produto.Descricao + espacoEmBranco + "- " + this.Quantidade.ToString();
        }
    }
}
