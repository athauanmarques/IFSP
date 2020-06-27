using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql;
using MySql.Data;
using MySql.Data.MySqlClient;
using LojaWin.Modelos;

namespace LojaWin.Dal
{
    public class ClientesDal
    {
        MySqlConnection connCliente = new MySqlConnection();
        MySqlCommand cmdCliente = new MySqlCommand();

        public void incluir(ModeloClientes cliente)
        {
            try
            {
                connCliente.ConnectionString = Dados.conexao;
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.Connection = connCliente;
                cmdCliente.CommandText = "InserirCliente";
                cmdCliente.Parameters.AddWithValue("pnome", cliente.Nome);
                cmdCliente.Parameters.AddWithValue("pemail", cliente.Email);
                cmdCliente.Parameters.AddWithValue("ptelefone", cliente.Telefone);
                connCliente.Open();
                cliente.IdCliente = Convert.ToInt32(cmdCliente.ExecuteScalar());
            }
            catch
            {
                throw new Exception("Não foi possível a conexão com o banco de dados!");
            }
            finally
            {
                connCliente.Close();
            }
        }

        public void alterar(ModeloClientes cliente)
        {
            try
            {
                connCliente.ConnectionString = Dados.conexao;
                cmdCliente.Connection = connCliente;
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.CommandText = "AlterarCliente";
                cmdCliente.Parameters.AddWithValue("pidcliente", cliente.IdCliente);
                cmdCliente.Parameters.AddWithValue("pnome", cliente.Nome);
                cmdCliente.Parameters.AddWithValue("pemail", cliente.Email);
                cmdCliente.Parameters.AddWithValue("ptelefone", cliente.Telefone);
                connCliente.Open();
                cmdCliente.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Não foi possível a conexão com o banco de dados!");
            }
            finally
            {
                connCliente.Close();
            }
        }

        public bool Excluir(ModeloClientes cliente)
        {
            int resultado;
            bool resposta;
            try
            {
                connCliente.ConnectionString = Dados.conexao;
                cmdCliente.Connection = connCliente;
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.CommandText = "ExcluirCliente";
                cmdCliente.Parameters.AddWithValue("pidcliente", cliente.IdCliente);
                connCliente.Open();
                resultado = cmdCliente.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o cliente!");
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
                connCliente.Close();
            }
        }

        public Modelos.ListaClientes listagem(string filtro)
        {
            try
            {
                Modelos.ListaClientes listarClientes = new ListaClientes();
                connCliente.ConnectionString = Dados.conexao;
                cmdCliente.Connection = connCliente;
                cmdCliente.CommandType = CommandType.StoredProcedure;
                cmdCliente.CommandText = "SelecionarCliente";
                cmdCliente.Parameters.AddWithValue("pfiltro", filtro);
                connCliente.Open();
                MySqlDataReader dr = cmdCliente.ExecuteReader();
                cmdCliente.Parameters.Clear();
                if (dr.HasRows == true)
                {
                    while (dr.Read())
                    {
                        ModeloClientes cliente = new ModeloClientes();
                        cliente.IdCliente = int.Parse(dr["idcliente"].ToString());
                        cliente.Nome = dr["nome"].ToString();
                        cliente.Email = dr["email"].ToString();
                        cliente.Telefone = dr["telefone"].ToString();
                        listarClientes.Add(cliente);
                    }
                }
                return listarClientes;
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
                connCliente.Close();
            }
        }
    }
}
