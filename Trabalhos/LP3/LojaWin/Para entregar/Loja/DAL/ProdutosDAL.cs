using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using System.Collections;
using Loja.Modelos;

namespace Loja.DAL
{
    public class ProdutosDAL
    {
        public ArrayList ProdutosEmFalta()
        {

            MySqlConnection cn = new MySqlConnection(Dados.StringDeConexao);
            MySqlCommand cmd = new MySqlCommand("Select * from Produtos Where Estoque < 10", cn);

            cn.Open();

            MySqlDataReader dr = cmd.ExecuteReader();
            ArrayList lista = new ArrayList();
            while (dr.Read())
            {
                ProdutoInformation produto = new ProdutoInformation();
                produto.Codigo = Convert.ToInt32(dr["codigo"]);
                produto.Nome = dr["nome"].ToString();
                produto.Estoque = Convert.ToInt32(dr["estoque"]);
                produto.Preco = Convert.ToDecimal(dr["preco"]);
                lista.Add(produto);

            }

            dr.Close();
            cn.Close();

            return lista;
        }


        public void Incluir(ProdutoInformation produto)
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
                cmd.CommandText = "insere_produto";

                //parâmetros da stored procedure
                MySqlParameter pnome = new MySqlParameter("@nome", MySqlDbType.VarChar, 100);
                pnome.Value = produto.Nome;
                cmd.Parameters.Add(pnome);
                MySqlParameter ppreco = new MySqlParameter("@preco", MySqlDbType.Decimal);
                ppreco.Value = produto.Preco;
                cmd.Parameters.Add(ppreco);
                MySqlParameter pestoque = new MySqlParameter("@estoque", MySqlDbType.Int32);
                pestoque.Value = produto.Estoque;
                cmd.Parameters.Add(pestoque);

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


        public void Alterar(ProdutoInformation produto)
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
                cmd.CommandText = "altera_produto";

                //parâmetros da stored procedure
                MySqlParameter pcodigo = new MySqlParameter("@cod", MySqlDbType.Int32);
                pcodigo.Value = produto.Codigo;
                cmd.Parameters.Add(pcodigo);
                MySqlParameter pnome = new MySqlParameter("@nome", MySqlDbType.VarChar, 100);
                pnome.Value = produto.Nome;
                cmd.Parameters.Add(pnome);
                MySqlParameter ppreco = new MySqlParameter("@preco", MySqlDbType.Decimal);
                ppreco.Value = produto.Preco;
                cmd.Parameters.Add(ppreco);
                MySqlParameter pestoque = new MySqlParameter("@Estoque", MySqlDbType.Int32);
                pestoque.Value = produto.Estoque;
                cmd.Parameters.Add(pestoque);

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
                cmd.CommandText = "exclui_produto";

                //parâmetros da stored procedure
                MySqlParameter pcodigo = new MySqlParameter("@cod", MySqlDbType.Int32);
                pcodigo.Value = codigo;
                cmd.Parameters.Add(pcodigo);

                cn.Open();

                int resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o produto " + codigo);
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
                da.SelectCommand.CommandText = "seleciona_produto";
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
