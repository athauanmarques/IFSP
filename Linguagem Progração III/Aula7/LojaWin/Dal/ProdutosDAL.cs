using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using LojaWin.Modelos;

//trabalhando com método desconectado

namespace LojaWin.Dal
{
   public class ProdutosDAL
    {
       MySqlConnection connProdutos = new MySqlConnection();
       MySqlCommand cmdProdutos = new MySqlCommand();

       private bool resposta = false;
       private bool Resposta
       {
           get { return resposta; }
           set { resposta = value; }

       }

       public DataTable listaProdutosEmFalta()
       {
           try
           {
               connProdutos.ConnectionString = Dados.conexao;
               string sqlProdutosEmFalta;

               //DataTable  é o objeto que representa os dados lidos pelo comando sql
               DataTable dtFalta = new DataTable();
               sqlProdutosEmFalta = "select * from produtos where estoque  < 10";

               //Objeto da classe da DataAdapter é responsável por abrir e fechar o banco de dados automáticamente;
               MySqlDataAdapter da = new MySqlDataAdapter(sqlProdutosEmFalta, connProdutos);

               //O método Fill do DataAdapter le os Dados do comando SQL e os armazena no objeto Dataadapter
               da.Fill(dtFalta);
               return dtFalta;
           }
           catch (MySqlException ex)
           {
               throw new Exception(ex.Message);
           }


       }

       public void InserirProdutos(ModelosProdutos produto)
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
               produto.IdProdutos = Convert.ToInt32(cmdProdutos.ExecuteScalar());
           }
           catch (MySqlException ex)
           {
               throw new Exception(ex.Message);
           }
           finally
           {

               connProdutos.Clone();
           }

       }

       public void AlterarProdutos(ModelosProdutos produto)
       {
           try
           {
           connProdutos.ConnectionString = Dados.conexao;
           cmdProdutos.CommandType = CommandType.StoredProcedure;
           cmdProdutos.CommandText = "AlterarProduto";
           cmdProdutos.Parameters.AddWithValue("pidproduto", produto.IdProdutos);
           cmdProdutos.Parameters.AddWithValue("pproduto", produto.Produto);
           cmdProdutos.Parameters.AddWithValue("ppreco", produto.Preco);
           cmdProdutos.Parameters.AddWithValue("pestoque", produto.Estoque);
           cmdProdutos.Connection = connProdutos;
           connProdutos.Open();
           cmdProdutos.ExecuteNonQuery();
             }
           catch (MySqlException ex)
           {
               throw new Exception(ex.Message);
           }
           finally
           {

               connProdutos.Clone();
           }
       }

       public bool ExcluirProdutos(ModelosProdutos produto)
       {
           int resultado;
           try
           {
               connProdutos.ConnectionString = Dados.conexao;
               cmdProdutos.CommandType = CommandType.StoredProcedure;
               cmdProdutos.CommandText = "ExcluirProduto";
               cmdProdutos.Parameters.AddWithValue("pidproduto", produto.IdProdutos);
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
           catch (MySqlException ex)
           {
               throw new Exception(ex.Message);
           }

           finally
           {

               connProdutos.Clone();
           }
       }
       public ListaProdutos Listagem(string filtro)
       {
           try
           {
               // Instância do objeto da lista genérica ListaUsuarios
               ListaProdutos listraProduto = new ListaProdutos();

               // Configura as informaçõessore o banco
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
                   ModelosProdutos produtos = new ModelosProdutos();
                   produtos.IdProdutos = int.Parse(dr["idprodutos"].ToString());
                   produtos.Produto = dr["produto"].ToString();
                   produtos.Preco = decimal.Parse(dr["produto"].ToString());
                   produtos.Estoque = int.Parse(dr["estoque"].ToString());

                   // Adiciona o objeto usuário à lista
                   listraProduto.Add(produtos);
               }
               return listraProduto;
           }
           catch
           {
               throw new Exception("Não foi possível estabelecer a conexão com o banco de dados");
           }
           finally
           {
               connProdutos.Close();
           }
       }
    }
}
