using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojaWin.Modelos
{
    public class ModeloItensVendas
    {
        private int idvenda;
        public int Idvenda
        {
            get { return idvenda; }
            set { idvenda = value; }
        }
        private int idproduto;
        public int Idproduto
        {
            get { return idproduto; }
            set { idproduto = value; }
        }
        private decimal valorProduto;
        public decimal ValorProduto
        {
            get { return valorProduto; }
            set { valorProduto = value; }
        }

        private int quantidade;
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
    }
}
