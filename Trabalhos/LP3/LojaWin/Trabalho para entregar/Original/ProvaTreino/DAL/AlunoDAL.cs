using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using ProvaTreino.Modelos;
using ProvaTreino.DAL;

namespace ProvaTreino.DAL
{
 
    public class AlunoDAL
    {
        MySqlConnection cx = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();

        public void Incluir(ModelosAluno aluno)
        {
            try
            {
                cx.ConnectionString = Dados.Conectar;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "IncluirAluno";
                cmd.Parameters.AddWithValue("pnome", aluno.Nome);
                cmd.Parameters.AddWithValue("cidade", aluno.Cidade);
                cmd.Parameters.AddWithValue("pendereco", aluno.Endereco);
                cmd.Parameters.AddWithValue("pidade", aluno.Idade);
                cmd.Parameters.AddWithValue("pprotuario", aluno.Prontuario);
                cmd.Connection = cx;
                cx.Open();
                aluno.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (MySqlException Msg)
            {
                throw new Exception(Msg.Message);
            }
            finally
            {

                cx.Close();
            }

        }

        public void Alterar(ModelosAluno aluno)
        {

            try {
                cx.ConnectionString = Dados.Conectar;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "AlterarAluno";
                cmd.Parameters.AddWithValue("pcodigo", aluno.Codigo);
                cmd.Parameters.AddWithValue("pnome", aluno.Nome);
                cmd.Parameters.AddWithValue("cidade", aluno.Cidade);
                cmd.Parameters.AddWithValue("pendereco", aluno.Endereco);
                cmd.Parameters.AddWithValue("pidade", aluno.Idade);
                cmd.Parameters.AddWithValue("pprotuario", aluno.Prontuario);
                cmd.Connection = cx;
                cx.Open();
                cmd.ExecuteNonQuery();
            
            }
            catch (MySqlException msg) 
            {
                throw new Exception(msg.Message); 
            }
            finally 
            { 
                cx.Close(); 
            }

        }

        public bool RemoverAluno(ModelosAluno aluno)
        {
            int resultado;
            bool resposta;

            try 
            {

                cx.ConnectionString = Dados.Conectar;
                cmd.Connection = cx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "RemoverAluno";
                cmd.Parameters.AddWithValue("pcodigo", aluno.Codigo);
                cx.Open();
                resultado = cmd.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possivel remover aluno");
                }
                else 
                {
                    resposta = true;
                }
                return resposta;
                

            }
            catch (MySqlException msg)
            {
                throw new Exception(msg.Message);
            }
            finally 
            {
                cx.Close();
            }

        }

        public ModelosAluno Selecionar(string filtro)
        {
            ListarAluno objAluno = new ListarAluno();

            try 
            {
                cx.ConnectionString = Dados.Conectar;
                cmd.Connection = cx;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "SelecionarAluno";
                cmd.Parameters.AddWithValue("pfiltro", filtro);
                cx.Open();
                MySqlDataReader dr = cmd.ExecuteReader();
                cmd.Parameters.Clear(); 
                while (dr.Read())
                {

                    ModelosAluno aluno = new ModelosAluno();
                    aluno.Codigo = int.Parse(dr["codigo"].ToString());
                    aluno.Nome = dr["nome"].ToString();
                    aluno.Cidade = dr["cidade"].ToString();
                    aluno.Endereco = dr["endereco"].ToString();
                    aluno.Idade = int.Parse(dr["idade"].ToString());
                    aluno.Prontuario = dr["prontuario"].ToString();
                    objAluno.Add(aluno);

                }
                return objAluno;
            
            }
            catch (MySqlException msg)
            {
               throw new Exception(msg.Message);
            }
            finally 
            {

                cx.Close();
            }

        }


    }
}
