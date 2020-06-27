using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pizzaria.Modelos;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;

namespace Pizzaria.DAL
{
    public class PedidosDAL
    {
        MySqlConnection cxPedido = new MySqlConnection();
        MySqlCommand cmdPedidos = new MySqlCommand();

        public DataTable ListaPedidos()
        {
            DataTable tbPedidos = new DataTable();
            string sqlListaPedidos;
            sqlListaPedidos = @"select clientes.nome, pedidos.dataPedido, pedidos.qtsItens, pedidos.custoTotal
                             from pedidos inner join clientes on
                             clientes.idClientes = pedidos.idPedidos;";
            MySqlDataAdapter da = new MySqlDataAdapter(sqlListaPedidos, cxPedido);
            da.Fill(tbPedidos);
            return tbPedidos;
        }

        public DataTable ProcuraPedidoPorCliente(string nome)
        {
            try
            {
            DataTable tbPedidos = new DataTable();
            cxPedido.ConnectionString = Conexao.Conectar;
            string sqlComando = @"select clientes.nome, pedidos.dataPedido, pedidos.qtsItens, pedidos.custoTotal
             from pedidos inner join clientes on clientes.idClientes = pedidos.idPedidos where clientes.nome LIKE CONCAT('%"+nome+"%');";
           
            cxPedido.Open();
            MySqlDataAdapter da = new MySqlDataAdapter(sqlComando, cxPedido);
            da.Fill(tbPedidos);
            return tbPedidos;
                
          }
            catch
            {
                throw new Exception("Não foi possível estabelecer a conexão com o banco de dados");
            }
            finally
            {
                cxPedido.Close();
            }

            
        }

        public DataTable ListarSomarPorData()
        {
            DataTable tbPedidos = new DataTable();
            string sqlListaPedidos;
            sqlListaPedidos = @"select pedidos.dataPedido, ROUND(SUM(pedidos.custoTotal), 2) 
                                as 'Total de custo por dia'FROM pizzaria.pedidos
                                GROUP BY pedidos.dataPedido;";
            MySqlDataAdapter da = new MySqlDataAdapter(sqlListaPedidos, cxPedido);
            da.Fill(tbPedidos);
            return tbPedidos;
        }

        public ListarPedidoRelatorio GerarRelatorioPedidos(string filtro)
        {

            ListarPedidoRelatorio objPedidos = new ListarPedidoRelatorio();
            try{
            cxPedido.ConnectionString = Conexao.Conectar;
            cmdPedidos.Connection = cxPedido;
            cmdPedidos.CommandType = CommandType.StoredProcedure;
            cmdPedidos.CommandText = "RelatorioPedidos";
            cmdPedidos.Parameters.AddWithValue("pfiltro", filtro);
            cxPedido.Open();
            MySqlDataReader dr = cmdPedidos.ExecuteReader();
            cmdPedidos.Parameters.Clear();
            while (dr.Read())
            { 
            ModelosPedidos pedidos = new ModelosPedidos();
                    pedidos.IdPedidos = Convert.ToInt32(dr["idPedidos"].ToString());
                    pedidos.DataPedido = Convert.ToDateTime(dr["dataPedido"].ToString());
                    pedidos.CustoTotal = Convert.ToDouble(dr["custoTotal"].ToString());
                    pedidos.Caixa = Convert.ToDouble(dr["caixa"].ToString());
                    pedidos.QtsItens = dr["qtsItens"].ToString();
                    pedidos.IdClientes= Convert.ToInt32(dr["idClientes"].ToString());
                   
                    objPedidos.Add(pedidos);
            }
            return objPedidos;
                
          }
            catch
            {
                throw new Exception("Não foi possível estabelecer a conexão com o banco de dados");
            }
            finally
            {
                cxPedido.Close();
            }

       }

        public void Incluir(ModelosPedidos pedidos)
        {
            try
            {

                cxPedido.ConnectionString = Conexao.Conectar;

               
                string comandoSQL = @"insert into pizzaria.pedidos(dataPedido,custoTotal,caixa,qtsItens,idClientes) 
                                                       values(@dataPedido,@custoTotal,@caixa,@qtsItens,@idClientes);";
                
                cmdPedidos.CommandText = comandoSQL;
                cmdPedidos.Parameters.Clear();
                cmdPedidos.Parameters.AddWithValue("@dataPedido", pedidos.DataPedido);
                cmdPedidos.Parameters.AddWithValue("@custoTotal", pedidos.CustoTotal);
                cmdPedidos.Parameters.AddWithValue("@caixa", pedidos.Caixa);
                cmdPedidos.Parameters.AddWithValue("@qtsItens", pedidos.QtsItens);
                cmdPedidos.Parameters.AddWithValue("@idClientes", pedidos.IdClientes);
                cmdPedidos.Connection = cxPedido;
                cxPedido.Open();
                pedidos.IdPedidos = Convert.ToInt32(cmdPedidos.ExecuteScalar());

            }
            catch
            {
                throw new Exception("Não foi possível a conexão com  o banco de dados");
            }
            finally
            {
                cxPedido.Close();
            }

        }

    }
}
