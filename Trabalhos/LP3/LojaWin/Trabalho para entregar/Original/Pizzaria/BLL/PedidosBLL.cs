using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pizzaria.DAL;
using Pizzaria.Modelos;

namespace Pizzaria.BLL
{
    public class PedidosBLL
    {
        PedidosDAL objPedidos = new PedidosDAL();
        PedidosDAL objPedidosIN = new PedidosDAL();


        private string mensagem;
        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public ListarPedidoRelatorio GeraRelatorio(string filtro)
        {

            return objPedidos.GerarRelatorioPedidos(filtro);

        }

        public DataTable PedidoPorCliente(string nome)
        {
             return objPedidos.ProcuraPedidoPorCliente(nome);
        }

        public DataTable ListaPedidos()
        {
            return objPedidos.ListaPedidos();
        }

          public DataTable ListarSomarPorData()
        {
            return objPedidos.ListarSomarPorData();
        }

        public string IncluirPedidos(ModelosPedidos pedidos)
        {
            try
            {
             
                 if (pedidos.CustoTotal == 0 )
                {

                    mensagem = "Campo 'custo total' se enconta vazio.";
                }
                  else if (pedidos.Caixa == 0 )
                {

                    mensagem = "Campo 'Caixa' se enconta vazio.";
                }
                        else if (pedidos.IdClientes == 0 )
                {

                    mensagem = "Selecione o cliente para ser incluido.";
                }
                        else if (pedidos.QtsItens == "" )
                {

                    mensagem = "Adicione sabores para ser incluido.";
                }

                else
                 {
                    objPedidosIN.Incluir(pedidos);
                    mensagem = "Pedido inserido com êxito.";
                    
                }

                     return mensagem;
        
            
           }

            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
          }
           
    }
}
