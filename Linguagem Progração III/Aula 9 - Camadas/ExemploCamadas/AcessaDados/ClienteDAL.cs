using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelos;
using System.Data;
using MySql.Data.MySqlClient;

/*
 Aqui utilizaremos comandos do MySql para acessar o banco de dados do Clientes
 
 */

namespace AcessaDados
{
    public class ClienteDAL
    {
        Conexao cx = new Conexao(); //pegando o método da classe Conexao

        //listagem com select
        public DataTable Listagem()
        {
            //DataAdapter--Faz a leitura do banco de dados, extrai todos os dados de acordo com o command e preenche o DataSet
            MySqlDataAdapter da = new MySqlDataAdapter();

            //DataTable-- representa uma ou mais tabelas de dados em memória. DataTable estão contidos no objeto DataSet
            DataTable dt = new DataTable();
            try
            {
                cx.Conectar();
                da.SelectCommand = new MySqlCommand(); // utilizando comando Select

                //chamar procedure
                //c-- objeto MySqlConnection da classe Conexao
                da.SelectCommand.CommandText = "selecionar"; // selecionar é um procedure que esta dentro do banco workbech
                da.SelectCommand.Connection = cx.c; // utilizar a conexão
                da.SelectCommand.CommandType = CommandType.StoredProcedure; //pegando o tipo do procedure
                
                //O Fill método recupera linhas da fonte de dados usando a instrução SELECT especificada por um associado SelectCommand propriedade. 
                da.Fill(dt); 
                return dt;
               
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                cx.Desconectar();
            }
        }

        //listagem com filtro
        public DataTable Listagem(string filtro) // filtro
        {
            //DataAdapter--Faz a leitura do banco de dados, extrai todos os dados de acordo com o command e preenche o DataSet
            MySqlDataAdapter da = new MySqlDataAdapter();

            //DataTable-- representa uma ou mais tabelas de dados em memória. DataTable estão contidos no objeto DataSet
            DataTable dt = new DataTable();
            try
            {
                cx.Conectar();
                da.SelectCommand = new MySqlCommand();

                //chamar procedure
                //c-- objeto MySqlConnection da classe Conexao
                da.SelectCommand.CommandText = "filtro";
                da.SelectCommand.Connection = cx.c;
                da.SelectCommand.CommandType = CommandType.StoredProcedure;

                //parametros stored
                MySqlParameter pfiltro;
                pfiltro = da.SelectCommand.Parameters.Add("filtro", MySqlDbType.Text);
                pfiltro.Value = filtro;

                da.Fill(dt);
                return dt;
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                cx.Desconectar();
            }
        }

        //inserir dados
        //public string Inserir(string cliente, string telefone, string endereco)
        public string Inserir(InfoCliente ic)
        {
             
            string msg;
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cx.Conectar();
                da.SelectCommand = new MySqlCommand();
                
                //chama procedure de outra forma: com parametros concatenados
                //ExecuteNonQuery – executa comando que não tem retorno (insert, update, delete)
                da.SelectCommand.CommandText = "call inserir('" + ic.Cliente + "','" + ic.Telefone + "','" + ic.Endereco + "' )";
                da.SelectCommand.Connection = cx.c;
                da.SelectCommand.ExecuteNonQuery();

                msg = "Inserido com sucesso";
                return msg;
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                cx.Desconectar();
            }
        }

        //alterar dados
        public string Alterar(int Id, string cliente, string telefone, string end)
        {
            string msg;
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cx.Conectar();
                da.SelectCommand = new MySqlCommand();

                //CommandText com campos do tipo Int e String
                //As aspas duplas " " são utilizadas para delimitar uma string no C# 
                //Ja as aspas simples (apóstrofo) ' ' são utilizadas para delimitar uma string no SQL Server 
                da.SelectCommand.CommandText = "call alterar('" + Id + "','" 
                    + cliente + "','" 
                    + telefone + "','" 
                    + end + "')";
                da.SelectCommand.Connection = cx.c;
                da.SelectCommand.ExecuteNonQuery();

                msg = "Alterado com sucesso";
                return msg;
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                cx.Desconectar();
            }
        }

        //Excluir dados
        public string Excluir(int Id)
        {
            string msg;
            MySqlDataAdapter da = new MySqlDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cx.Conectar();
                da.SelectCommand = new MySqlCommand();
                da.SelectCommand.CommandText = "call excluir (" + Id + ")";
                da.SelectCommand.Connection = cx.c;
                da.SelectCommand.ExecuteNonQuery();

                msg = "Excluido com sucesso";
                return msg;
            }
            catch (Exception x)
            {
                throw new Exception(x.Message);
            }
            finally
            {
                cx.Desconectar();
            }
        }

    }
}
