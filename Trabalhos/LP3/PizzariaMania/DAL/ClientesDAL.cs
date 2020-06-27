using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using Pizzaria.Modelos;

namespace Pizzaria.DAL
{
    public class ClientesDAL
    {
        MySqlConnection cx = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        Conexao conn = new Conexao();

        public bool ExcluirClientes(ModelosClientes clientes)
        {
            int resultado;
            bool resposta;
            try
            {
                cx.ConnectionString = Conexao.Conectar;
                cmd.Connection = cx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ExcluirCliente";
                cmd.Parameters.AddWithValue("pidClientes", clientes.IdClientes);
                cx.Open();
                resultado = cmd.ExecuteNonQuery();
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
                cx.Close();
            }
            
           }

        


        public void AlterarClientes(ModelosClientes clientes)
        {
            try
            {
            cx.ConnectionString = Conexao.Conectar;
            cmd.Connection = cx;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "AlterarCliente";
            cmd.Parameters.AddWithValue("pidCliente", clientes.IdClientes);
            cmd.Parameters.AddWithValue("pnome", clientes.Nome);
            cmd.Parameters.AddWithValue("pendereco", clientes.Endereco);
            cmd.Parameters.AddWithValue("ptelefone", clientes.Telefone);
            cmd.Parameters.AddWithValue("pcidade", clientes.Cidade);
            cmd.Parameters.AddWithValue("puf", clientes.Uf);
            cmd.Parameters.AddWithValue("preferencias", clientes.Referencias);
            cx.Open();
            cmd.ExecuteNonQuery();

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

        public Modelos.ModelosLista ListragemNome()
        {
            Modelos.ModelosLista objClientes = new ModelosLista();
            try
            {
                cx.ConnectionString = Conexao.Conectar;
                // a letra "c" é o MySqlConnection da classe Conexão que ta pegando a string de conexão
                cmd.Connection = cx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "ListragemNome";
                cx.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd.Parameters.Clear();
                while (dr.Read())
                {
                    ModelosClientes clientes = new ModelosClientes();
                    clientes.Nome = dr["nome"].ToString();
                   
                    objClientes.Add(clientes);
                }

                return objClientes;
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

      
        public Modelos.ModelosLista Listragem(string filtro)
        {
            Modelos.ModelosLista objClientes = new  ModelosLista();
            try
            {
                cx.ConnectionString = Conexao.Conectar;
                // a letra "c" é o MySqlConnection da classe Conexão que ta pegando a string de conexão
                cmd.Connection = cx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelecionarClientes";
                cmd.Parameters.AddWithValue("pfiltro", filtro);
                cx.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd.Parameters.Clear(); 
                while(dr.Read())
                {
                    ModelosClientes clientes = new ModelosClientes();
                    clientes.IdClientes = int.Parse(dr["idClientes"].ToString());
                    clientes.Nome = dr["nome"].ToString();
                    clientes.Endereco = dr["endereco"].ToString();
                    clientes.Telefone = dr["telefone"].ToString();
                    clientes.Cidade = dr["cidade"].ToString();
                    clientes.Uf = dr["uf"].ToString();
                    clientes.Referencias = dr["referencias"].ToString();
                    objClientes.Add(clientes);
                }

                return objClientes;
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

        public void IncluirCliente(ModelosClientes clientes)
        {
            try
            {
               // int usu = 1;
                cx.ConnectionString = Conexao.Conectar;

                cmd.Connection = cx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InserirClientes";
                cmd.Parameters.AddWithValue("pnome", clientes.Nome);
                cmd.Parameters.AddWithValue("pendereco", clientes.Endereco);
                cmd.Parameters.AddWithValue("ptelefone", clientes.Telefone);
                cmd.Parameters.AddWithValue("pcidade", clientes.Cidade);
                cmd.Parameters.AddWithValue("puf", clientes.Uf);
                cmd.Parameters.AddWithValue("preferencias", clientes.Referencias);

                cx.Open();
                clientes.IdClientes = Convert.ToInt32(cmd.ExecuteScalar());

            }
            catch
            {
                throw new Exception("Não foi possível a conexão com  o banco de dados");
            }
            finally
            {
                cx.Close();
            }


        }

       


    }
}
