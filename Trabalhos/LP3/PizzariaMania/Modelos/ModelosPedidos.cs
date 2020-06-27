using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Modelos
{
    public class ModelosPedidos
    {
        private int idPedidos;
        private DateTime dataPedido;
        private double custoTotal;
        private double caixa;
        private string qtsItens;
        private int idClientes;
       

        public int IdPedidos { get { return idPedidos; } set { idPedidos = value; } }
        public DateTime DataPedido { get { return dataPedido; } set { dataPedido = value; } }
        public double CustoTotal { get { return custoTotal; } set { custoTotal = value; } }
        public double Caixa { get { return caixa; } set { caixa = value; } }
        public string QtsItens { get { return qtsItens; } set { qtsItens = value; } }
        public int IdClientes { get { return idClientes; } set { idClientes = value; } }
        

    }
}
