using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lanchonete.Entities
{
    /// <summary>
    /// Esta classe representa um produto qualquer, que será listado
    /// no cardápio da lanchonete.
    /// </summary>
    public class Produto
    {
        /// <summary>
        /// Código do produto
        /// </summary>
        public int Codigo { get; set; }
        /// <summary>
        /// Descrição do produto que aparecerá no cardápio
        /// </summary>
        public String Descricao { get; set; }
        /// <summary>
        /// O valor que será pago pelo consumidor 
        /// por uma unidade deste produto
        /// </summary>
        public Decimal Preco { get; set; }

        /// <summary>
        /// Construtor do produto, que injeta: o código do produto,
        /// a descrição do produto e o preço do produto
        /// </summary>
        /// <param name="cod">O código do produto</param>
        /// <param name="descricao">Descrição do produto</param>
        /// <param name="preco">Preço do produto</param>
        public Produto(int cod, String descricao, Decimal preco) 
        {
            this.Codigo = cod;
            this.Descricao = descricao;
            this.Preco = preco;
        }

        /// <summary>
        /// Converte um produto numa String que mostra seu código, sua descrição e seu preço.
        /// </summary>
        /// <returns>Uma String que mostra o código, a descrição e o preço do produto.</returns>
        public override string ToString()
        {
            // A seguir é criada uma string de espaços em branco
            // que será concatenada após a descrição do produto,
            // para fins de alinhamento no cardápio.
            String espacoEmBranco = ""; 
            int nroEspacos = 20 - this.Descricao.Length;
            for (int i = 0; i < nroEspacos; i++)
            {
                espacoEmBranco += " ";
            }

            return this.Codigo.ToString() + " - " + this.Descricao + espacoEmBranco + "- " + this.Preco.ToString("C");
        }

    }
}
