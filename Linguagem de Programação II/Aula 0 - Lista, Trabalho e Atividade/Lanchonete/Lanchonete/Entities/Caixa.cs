using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lanchonete.Entities
{
    /// <summary>
    /// Esta classe representa o histórico de pedidos e
    /// o dinheiro movimentado no caixa da lanchonete
    /// </summary>
    public class Caixa
    {
        /// <summary>
        /// Vetor contendo os pedidos realizados pela lanchonete
        /// </summary>
        public Pedido[] Pedidos { get; set; }

        /// <summary>
        /// Retorna o valor total movimentado na lanchonete,
        /// o qual se inicia com RS 100,00 e sobe a cada 
        /// pedido realizado
        /// </summary>
        public Decimal ValorCaixa 
        {
            get 
            {
                Decimal valorCaixa = 100M;
                for (int i = 0; i < Pedidos.Length; i++)
                {
                    if (Pedidos[i] != null)
                    {
                        valorCaixa += Pedidos[i].ValorTotal;
                    }
                }

                return valorCaixa;
            }
        }

        /// <summary>
        /// Contador que marca a posição do pedido atual 
        /// do formulário no vetor de pedidos
        /// </summary>
        private int nroDePedidos;

        public Caixa() 
        {
            nroDePedidos = 0;
            this.Pedidos = new Pedido[100];
        }

        /// <summary>
        /// Adiciona um pedido ao vetor de pedidos
        /// </summary>
        /// <param name="pedido">O pedido a ser adicionado</param>
        public void adicionarPedido(Pedido pedido)
        {
            Pedidos[nroDePedidos] = pedido;
            nroDePedidos++;
        }
    }
}
