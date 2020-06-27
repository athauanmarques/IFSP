using System;
using System.Collections.Generic;
using System.Text;
using Loja.Modelos;
using MySql.Data.MySqlClient;
using System.Data;

namespace Loja.DAL
{
    public class ClientesDAL
    {
        public void Incluir(ClienteInformation cliente)
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
                cmd.CommandText = "insere_cliente";

                //parâmetros da stored procedure
                //MySqlParameter pcodigo = new MySqlParameter("@codigo", SqlDbType.Int);
                //pcodigo.Direction = ParameterDirection.Output;
                //cmd.Parameters.Add(pcodigo);
                MySqlParameter pnome = new MySqlParameter("@nome", MySqlDbType.VarChar, 100);
                pnome.Value = cliente.Nome;
                cmd.Parameters.Add(pnome);
                MySqlParameter pemail = new MySqlParameter("@email", MySqlDbType.VarChar, 100);
                pemail.Value = cliente.Email;
                cmd.Parameters.Add(pemail);
                MySqlParameter ptelefone = new MySqlParameter("@telefone", MySqlDbType.VarChar, 80);
                ptelefone.Value = cliente.Telefone;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

                //cliente.Codigo = (Int32)cmd.Parameters["@codigo"].Value;

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

        public void Alterar(ClienteInformation cliente)
        {
            // conexao
            MySqlConnection cn = new MySqlConnection();
            try
            {

                cn.ConnectionString = Dados.StringDeConexao;
                //command
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = cn;

                cmd.CommandType = CommandType.StoredProcedure;
                //nome da stored procedure
                cmd.CommandText = "altera_cliente";

                //parâmetros da stored procedure
                MySqlParameter pcodigo = new MySqlParameter("@cod", MySqlDbType.Int32);
                pcodigo.Value = cliente.Codigo;
                cmd.Parameters.Add(pcodigo);
                MySqlParameter pnome = new MySqlParameter("@nome", MySqlDbType.VarChar, 100);
                pnome.Value = cliente.Nome;
                cmd.Parameters.Add(pnome);
                MySqlParameter pemail = new MySqlParameter("@email", MySqlDbType.VarChar, 100);
                pemail.Value = cliente.Email;
                cmd.Parameters.Add(pemail);
                MySqlParameter ptelefone = new MySqlParameter("@telefone", MySqlDbType.VarChar, 80);
                ptelefone.Value = cliente.Telefone;
                cmd.Parameters.Add(ptelefone);

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

        public void Excluir(int codigo)
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
                cmd.CommandText = "exclui_cliente";

                //parâmetros da stored procedure
                MySqlParameter pcodigo = new MySqlParameter("@cod", MySqlDbType.Int32);
                pcodigo.Value = codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o cliente " + codigo);
                }
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

        public DataTable Listagem(string filtro)
        {
            MySqlConnection cn = new MySqlConnection();
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();

            try
            {
                cn.ConnectionString = Dados.StringDeConexao;
                //adapter
                da.SelectCommand = new MySqlCommand();
                da.SelectCommand.CommandText = "seleciona_cliente";
                da.SelectCommand.Connection = cn;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //parâmetros da stored procedure
                MySqlParameter pfiltro;
                pfiltro = da.SelectCommand.Parameters.Add("@filtro", MySqlDbType.Text);
                pfiltro.Value = filtro;

                da.Fill(dt);

                return dt;
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
