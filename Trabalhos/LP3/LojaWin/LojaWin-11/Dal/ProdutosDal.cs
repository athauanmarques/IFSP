using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using LojaWin.Modelos;

namespace LojaWin.Dal
{
    public class ProdutosDal
    {
        MySqlConnection connProdutos = new MySqlConnection();
        MySqlCommand cmdProdutos = new MySqlCommand();

        private bool resposta = false;
        public bool Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }

        public DataTable listaProdutosEmFalta()
        {
            try
            {
                connProdutos.ConnectionString = Dados.conexao;
                string sqlListaProdutoEmFalta;
                // O objeto da classe DataTable representa os dados lidos pelo
                // comando SQL.
                DataTable dtPFalta = new DataTable();
                sqlListaProdutoEmFalta = "select * from produtos where estoque < 10";
                // O objeto da clase DataAdapter é responsável por abrir e fechar 
                // o banco automaticamente; 
                MySqlDataAdapter da = new MySqlDataAdapter(sqlListaProdutoEmFalta, connProdutos);
                // O método Fill do DataAdapter lê os dados do comando SQL e
                // os armazena no objeto DataAdapter
                da.Fill(dtPFalta);
                return dtPFalta;
            }
            catch
            {
                throw new Exception("Não foi possível a conexão com o banco de dados!");
            }
        }

        public void inserir(ModeloProdutos produto)
        {
            try
            {
                connProdutos.ConnectionString = Dados.conexao;
                cmdProdutos.CommandType = CommandType.StoredProcedure;
                cmdProdutos.CommandText = "InserirProduto";
                cmdProdutos.Parameters.AddWithValue("pproduto", produto.Produto);
                cmdProdutos.Parameters.AddWithValue("ppreco", produto.Preco);
                cmdProdutos.Parameters.AddWithValue("pestoque", produto.Estoque);
                cmdProdutos.Connection = connProdutos;
                connProdutos.Open();
                produto.Idproduto = Convert.ToInt32(cmdProdutos.ExecuteScalar());
            }
            catch
            {
                throw new Exception("Não foi possível conexão com o banco de dados!");
            }
            finally
            {
                connProdutos.Close();
            }
        }

        public void alterar(ModeloProdutos produto)
        {
            try
            {
                connProdutos.ConnectionString = Dados.conexao;
                cmdProdutos.CommandType = CommandType.StoredProcedure;
                cmdProdutos.CommandText = "AlterarProduto";
                cmdProdutos.Parameters.AddWithValue("pidproduto", produto.Idproduto);
                cmdProdutos.Parameters.AddWithValue("pproduto", produto.Produto);
                cmdProdutos.Parameters.AddWithValue("ppreco", produto.Preco);
                cmdProdutos.Parameters.AddWithValue("pestoque", produto.Estoque);
                cmdProdutos.Connection = connProdutos;
                connProdutos.Open();
                cmdProdutos.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Não foi possível conexão com o banco de dados!");
            }
            finally
            {
                connProdutos.Close();
            }
        }

        public bool excluir(ModeloProdutos produto)
        {
            int resultado;
            try
            {
                connProdutos.ConnectionString = Dados.conexao;
                cmdProdutos.CommandType = CommandType.StoredProcedure;
                cmdProdutos.CommandText = "ExcluirProduto";
                cmdProdutos.Parameters.AddWithValue("pidproduto", produto.Idproduto);
                cmdProdutos.Connection = connProdutos;
                connProdutos.Open();
                resultado = cmdProdutos.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o produto");
                }
                else
                {
                    resposta = true;
                }
                return resposta;
            }
            catch
            {
                throw new Exception("Não foi possível conectar-se ao banco de dados");
            }
            finally
            {
                connProdutos.Close();
            }
        }

        public ListaProdutos listagem(string filtro)
        {
            try
            {
                ListaProdutos listarProdutos = new ListaProdutos();
                connProdutos.ConnectionString = Dados.conexao;
                cmdProdutos.Connection = connProdutos;
                cmdProdutos.CommandType = CommandType.StoredProcedure;
                cmdProdutos.CommandText = "SelecionarProduto";
                cmdProdutos.Parameters.AddWithValue("pfiltro", filtro);
                connProdutos.Open();
                MySqlDataReader dr = cmdProdutos.ExecuteReader();
                cmdProdutos.Parameters.Clear();
                while (dr.Read())
                {
                    ModeloProdutos produto = new ModeloProdutos();
                    produto.Idproduto = int.Parse(dr["idproduto"].ToString());
                    produto.Produto = dr["produto"].ToString();
                    produto.Preco = decimal.Parse(dr["preco"].ToString());
                    produto.Estoque = int.Parse(dr["estoque"].ToString());
                    listarProdutos.Add(produto);
                }
                return listarProdutos;
            }
            catch
            {
                throw new Exception("Não foi possível conectar-se ao banco de dados");
            }
            finally
            {
                connProdutos.Close();
            }
        }

        public decimal Preco(int idproduto)
        {
            try
            {
                ModeloProdutos produto = new ModeloProdutos();
                connProdutos.ConnectionString = Dados.conexao;
                string sqlprodutoPreco = "select preco from produtos where idproduto = " + idproduto;
                cmdProdutos.CommandText = sqlprodutoPreco;
                cmdProdutos.Connection = connProdutos;
                connProdutos.Open();
                MySqlDataReader dr = cmdProdutos.ExecuteReader();
                while (dr.Read())
                {
                    produto.Preco = decimal.Parse(dr["preco"].ToString());
                }
                return produto.Preco;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connProdutos.Close();
            }
        }
    }
}
