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
    public class AcessoDAL
    {
        ModelosAcesso acesso = new ModelosAcesso();
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection cx = new MySqlConnection();

        public DataTable ListaAcesso()
        {
            try
            {
                cx.ConnectionString = Conexao.Conectar;

                DataTable tbAcesso = new DataTable();
                string sqlListaAcesso;
                sqlListaAcesso = "select * from pizzaria.Acessos;";

                MySqlDataAdapter da = new MySqlDataAdapter(sqlListaAcesso, cx);
                cx.Open();
                da.Fill(tbAcesso);
                return tbAcesso;
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

        public void IncluirAcesso(ModelosAcesso acesso)
        {
            try
            {
                cx.ConnectionString = Conexao.Conectar;


                string comandoSQL = "insert into pizzaria.Acessos(acessos) value(@acessos);";

                cmd.CommandText = comandoSQL;
                cmd.Parameters.Clear();
                cmd.Parameters.AddWithValue("@acessos", acesso.Acesso);
                cmd.Connection = cx;
                cx.Open();
                acesso.IdAcessos = Convert.ToInt32(cmd.ExecuteScalar());
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
