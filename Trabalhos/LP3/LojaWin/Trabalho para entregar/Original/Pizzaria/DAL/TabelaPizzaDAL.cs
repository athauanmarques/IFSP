using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using Pizzaria.Modelos;
using Pizzaria.DAL;

namespace Pizzaria.DAL
{
    public class TabelaPizzaDAL
    {
        MySqlCommand cmdPizza = new MySqlCommand();
        MySqlConnection cx = new MySqlConnection();

        public ListarTabelaPizza ListarTabela(string filtro)
        {

            try
            {
                // Instância do objeto da lista genérica ListaUsuarios
                ListarTabelaPizza objPizzas = new ListarTabelaPizza();

                // Configura as informaçõessore o banco
                cx.ConnectionString = Conexao.Conectar;
                cmdPizza.Connection = cx;
                cmdPizza.CommandType = CommandType.StoredProcedure;
                cmdPizza.CommandText = "ListarTabelarPizza";
                cmdPizza.Parameters.AddWithValue("pfiltro", filtro);
                cx.Open();
                MySqlDataReader dr = cmdPizza.ExecuteReader();
                cmdPizza.Parameters.Clear();
                while (dr.Read())
                {
                    ModelosTabelaPizza pizza = new ModelosTabelaPizza();
                    pizza.IdPizzas = int.Parse(dr["idPizzas"].ToString());
                    pizza.Informacoes = dr["informacoes"].ToString();
                    pizza.Sabor = dr["sabor"].ToString();
                    pizza.PrecoP = Convert.ToDecimal(dr["precoP"].ToString());
                    pizza.PrecoM = Convert.ToDecimal(dr["precoM"].ToString());
                    pizza.PrecoG = Convert.ToDecimal(dr["precoG"].ToString());
                    objPizzas.Add(pizza);
                }
                return objPizzas;
            }
            catch
            {
                throw new Exception("Não foi possível estabelecer a conexão com o banco de dados");
            }
            finally
            {
                cx.Close();
            }
        }


        public void AddTabela(ModelosTabelaPizza pizza)
        {
            try
            {
                cx.ConnectionString = Conexao.Conectar;
                cmdPizza.Connection = cx;
                cmdPizza.CommandType = CommandType.StoredProcedure;
                cmdPizza.CommandText = "InserirTabelarPizza";
                cmdPizza.Parameters.AddWithValue("psabor", pizza.Sabor);
                cmdPizza.Parameters.AddWithValue("pinformacoes", pizza.Informacoes);
                cmdPizza.Parameters.AddWithValue("pprecoP", pizza.PrecoP);
                cmdPizza.Parameters.AddWithValue("pprecoM", pizza.PrecoM);
                cmdPizza.Parameters.AddWithValue("pprecoG", pizza.PrecoG);
                cx.Open();
                pizza.IdPizzas = Convert.ToInt32(cmdPizza.ExecuteScalar());
            }
            catch (MySqlException sEx)
            {
                throw new Exception(sEx.Message);
            }
            catch
            {
                throw new InvalidOperationException("Ocorreu um problema de conexão ao Bando de Dados.");
            }
            finally
            {
                cx.Close();
            }
            
        }


        
            public void AlterarTabelaPizza(ModelosTabelaPizza pizzas) 
            {
                try
                {
                    cx.ConnectionString = Conexao.Conectar;
                    cmdPizza.Connection = cx;
                    cmdPizza.CommandType = CommandType.StoredProcedure;
                    cmdPizza.CommandText = "AlterarTabelarPizza";
                    cmdPizza.Parameters.AddWithValue("pidPizzas", pizzas.IdPizzas);
                    cmdPizza.Parameters.AddWithValue("psabor", pizzas.Sabor);
                    cmdPizza.Parameters.AddWithValue("pinformacoes", pizzas.Informacoes);
                    cmdPizza.Parameters.AddWithValue("pprecoP", pizzas.PrecoP);
                    cmdPizza.Parameters.AddWithValue("pprecoM", pizzas.PrecoM);
                    cmdPizza.Parameters.AddWithValue("pprecoG", pizzas.PrecoG);
                    cx.Open();
                    cmdPizza.ExecuteNonQuery();
                }
                catch (MySqlException sEx)
                {
                    throw new Exception(sEx.Message);
                }
                catch
                {
                    throw new InvalidOperationException("O banco não foi fechado ou foi alterado");
                }
            finally
            {
                cx.Close();
            }


            }


        public bool ExcTabelaPizza(ModelosTabelaPizza pizzas)
        {

            int resultado;
            bool resposta;
            try
            {
                cx.ConnectionString = Conexao.Conectar;
                cmdPizza.Connection = cx;
                cmdPizza.CommandType = CommandType.StoredProcedure;
                cmdPizza.CommandText = "ExcluirTabelarPizza";
                cmdPizza.Parameters.AddWithValue("pidPizzas", pizzas.IdPizzas);
                cx.Open();
                resultado = cmdPizza.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir!");
                }
                else
                {
                    resposta = true;
                }
                return resposta;
            }
            catch (MySqlException sEx)
            {
                throw new Exception(sEx.Message);
            }
            catch
            {
                throw new InvalidOperationException("O banco não foi fechado ou foi excluído");
            }
            finally
            {
                cx.Close();
            }
        }

     }
}
