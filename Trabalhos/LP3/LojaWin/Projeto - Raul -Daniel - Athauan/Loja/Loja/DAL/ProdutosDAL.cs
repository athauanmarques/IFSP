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


        public void IncluirP(ProdutoInformation produto)
        {

            //conexao
            MySqlConnection cn = new MySqlConnection();

            try
            {

                cn.ConnectionString = Dados.StringDeConexao;

                //command

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = "call insere_produto('" + produto.Nome + "','" + produto.Preco + "','" + produto.Estoque + "');";

                
                cn.Open();

                produto.Codigo = Convert.ToInt32(cmd.ExecuteScalar());


            }

            catch (MySqlException ex)
            {

                throw new Exception("Servidor SQL Erro: " + ex.Number);

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


        public void AlterarP(ProdutoInformation produto)
        {

            //conexao

            MySqlConnection cn = new MySqlConnection();

            try
            {

                cn.ConnectionString = Dados.StringDeConexao;

                //command

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = "call altera_produto('" + produto.Codigo + "','" + produto.Nome + "','" + produto.Preco + "','" + produto.Estoque + "');";


                cn.Open();


                int resultadoP = cmd.ExecuteNonQuery();

                if (resultadoP != 1)
                {

                    throw new Exception("Não foi possível alterar o produto " + produto.Codigo);

                }
                
                
                



                


            }

            catch (MySqlException ex)
            {

                throw new Exception("Servidor SQL Erro: " + ex.Number);

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


        public void ExcluirP(int codigo)
        {
            //conexao

            MySqlConnection cn = new MySqlConnection();

            try
            {

                cn.ConnectionString = Dados.StringDeConexao;

                //command

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = "call exclui_produto(" + codigo + ");";


                cn.Open();

                int resultadoP = cmd.ExecuteNonQuery();

                if (resultadoP != 1)
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


        public DataTable ListagemP()
        {
            DataTable tabelaP = new DataTable();

            MySqlDataAdapter daP = new MySqlDataAdapter("select * from produtos", Dados.StringDeConexao);

            daP.Fill(tabelaP);

            return tabelaP;

        }


    }

}


/***
 * namespace Loja.DAL
{

    public class ClientesDAL
    {
        //Tentativa de usar string de conexão da classe do mesmo projeto
        //Dados objDados = new Dados();   

       
        public void Incluir(ClienteInformation cliente)
        {

            //conexao
            

            MySqlConnection cn = new MySqlConnection();

            try
            {


                cn.ConnectionString = Dados.StringDeConexao;
                

                //command - chamará a procedure, já implementada no banco de dados

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = "call insere_cliente('" + cliente.Nome + "','" + cliente.Email + "','" + cliente.Telefone + "');";

                


                cn.Open();


                cliente.Codigo = Convert.ToInt32(cmd.ExecuteScalar());

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
                

                //command - chamará a procedure, já implementada no banco de dados

                MySqlCommand cmd = new MySqlCommand();

                cmd.Connection = cn;

                cmd.CommandText = "call altera_cliente('" + cliente.Codigo + "','" + cliente.Nome + "','" + cliente.Email + "','" + cliente.Telefone + "');";


                
                cn.Open();

                
                int resultado = cmd.ExecuteNonQuery();

                if (resultado != 1)
                {

                    throw new Exception("Não foi possível alterar o cliente " + cliente.Codigo);

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

                cmd.CommandText = "call exclui_cliente(" + codigo + ");";


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


        public DataTable Listagem()
        {

            DataTable tabela = new DataTable();

            MySqlDataAdapter da = new MySqlDataAdapter("select * from clientes;", Dados.StringDeConexao);

            da.Fill(tabela);

            return tabela;

        }

    }
}

 */
