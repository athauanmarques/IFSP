using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;
using Loja.Modelos;

namespace Loja.DAL
{
    public class VendasDAL
    {
        
        //retorna a quantidade em estoque para a venda
        public int QuantidadeEstoque(VendaInformation venda) 
        {             
            

            //conexao
            MySqlConnection cn = new MySqlConnection();
            cn.ConnectionString = Dados.StringDeConexao;
            cn.Open();

            MySqlCommand com = default(MySqlCommand);

            com = new MySqlCommand("select estoque from produtos where codigo = " + venda.CodigoProduto , cn);
            Int32 quant = Convert.ToInt32(com.ExecuteScalar());
            com.Dispose();
            cn.Close();

            return quant;           
        }

        public DataTable ListaDeProdutos
        {
            get
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("select * from produtos", cn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }
        
        //Propriedade que retorna uma Lista de Clientes
        public DataTable ListaDeClientes
        {
            get
            {
                MySqlConnection cn = new MySqlConnection();
                cn.ConnectionString = Dados.StringDeConexao;
                cn.Open();

                MySqlDataAdapter da = new MySqlDataAdapter("select * from clientes", cn);

                DataTable dt = new DataTable();
                da.Fill(dt);
                cn.Close();
                return dt;
            }
        }

        public void Incluir(VendaInformation venda)
        {
            //conexao
            MySqlConnection cn = new MySqlConnection();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //command
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                //nome da stored procedure
                cmd.CommandText = "venda";

                //parâmetros da stored procedure
                MySqlParameter vquant = new MySqlParameter("@quant", MySqlDbType.Int32);
                vquant.Value = venda.Quantidade;
                cmd.Parameters.Add(vquant);
                MySqlParameter ccod = new MySqlParameter("@codCliente", MySqlDbType.Int32);
                ccod.Value = venda.CodigoCliente;
                cmd.Parameters.Add(ccod);
                MySqlParameter ccodp = new MySqlParameter("@codProduto", MySqlDbType.Int32);
                ccodp.Value = venda.CodigoProduto;
                cmd.Parameters.Add(ccodp);

                cn.Open();
                cmd.ExecuteNonQuery();

                
            }
            catch (MySqlException ex)
            {
                throw new Exception("Servidor SQL Erro:" + ex.Number);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                cn.Close();
            }
        }
        
    }
}
