using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lanchonete.Entities
{
    /// <summary>
    /// Esta classe representa uma ordem de compra feita pelo consumidor,
    /// que é constituída de uma lista de itens que o consumidor deseja
    /// adquirir.
    /// </summary>
    public class Pedido
    {
        /// <summary>
        /// Quais itens o consumidor deseja adquirir
        /// </summary>
        public Item[] Itens { get; set; }

        /// <summary>
        /// O valor total do pedido
        /// </summary>
        public Decimal ValorTotal 
        {
            get 
            {
                Decimal valorTotal = 0M;
                // Percorre-se a lista de itens e...
                for (int i = 0; i < Itens.Length; i++)
                {
                    /// ...se há algum item na posição atual da lista...
                    if (Itens[i] != null) 
                    {
                        /// ... o somador do valor total do pedido
                        /// é incrementado com o preço total do item
                        valorTotal += Itens[i].Produto.Preco * Itens[i].Quantidade;
                    }
                }

                return valorTotal;
            } 
        }

        /// <summary>
        /// Valor que foi entregue pelo consumidor ao vendedor
        /// da lanchonete
        /// </summary>
        public Decimal ValorPago { get; set; }

        /// <summary>
        /// Valor que o vendedor da lanchonete deve devolver ao 
        /// consumidor
        /// </summary>
        public Decimal Troco 
        {
            get { return ValorPago - ValorTotal; }
        }

        /// <summary>
        /// Contador que marca a posição do item atual no formulário
        /// no vetor de itens
        /// </summary>
        private int nroDeItens;

        public Pedido() 
        {
            nroDeItens = 0;
            this.Itens = new Item[100];
        }

        /// <summary>
        /// Adiciona um item ao vetor de itens
        /// </summary>
        /// <param name="item">O item a ser adicionado</param>
        public void adicionarItem(Item item)
        {
            Itens[nroDeItens] = item;
            nroDeItens++;
        }
    }
}
