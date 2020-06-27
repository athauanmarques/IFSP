using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LojaWin.Modelos;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace LojaWin.Dal
{
    public class UsuariosDal
    {
        // Instancia do objeto Connectio que faz a conexão com o banco
        MySqlConnection connUsuario = new MySqlConnection();

        // Instancia do objeto Command qque é o responsável em executar comandos
        // SQL. Executa comandos SQL na instancia da conexão com o banco.
        MySqlCommand cmdUsuario = new MySqlCommand();

        // Método de autenticação do usuário e sua senha
        // O objeto usuario trará encapsulado as informações referentes
        // ao nome do usuário e sua senha
        public bool Login(ModeloUsuarios usuario)
        {
            bool validaUsuario = false, validaSenha = false, resposta = false;
            try
            {
                // Configuração do banco de dados MySql
                connUsuario.ConnectionString = Dados.conexao;

                // Determina que será utilizado o acesso ao banco 
                // por StoredProcedure
                cmdUsuario.CommandType = CommandType.StoredProcedure;

                // Informar o nome da StoredProcedure que será acessada no banco
                cmdUsuario.CommandText = "AutenticarUsuario";

                // Configuração dos parâmetros da StoredProcedure 
                cmdUsuario.Parameters.AddWithValue("pnome", usuario.Nome);
                cmdUsuario.Parameters.AddWithValue("psenha", usuario.Senha);

                // Objeto cmdUsuario recebe a configuração do banco
                cmdUsuario.Connection = connUsuario;

                // Abertura da conexão com o banco
                connUsuario.Open();

                // Objeto DataReader executa a leitura dos dados no banco
                MySqlDataReader drUsuario = cmdUsuario.ExecuteReader();

                if (drUsuario.HasRows == true)
                {
                    while (drUsuario.Read())
                    {
                        if (drUsuario["nome"].ToString() == usuario.Nome)
                        {
                            validaUsuario = true;
                            if (drUsuario["senha"].ToString() == usuario.Senha)
                            {
                                validaSenha = true;
                            }
                        }
                    }
                }
                drUsuario.Close();
                if (validaUsuario == true && validaSenha == true)
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
                connUsuario.Close();
            }
        }

        public void Incluir(ModeloUsuarios usuario)
        {
            try
            {
                connUsuario.ConnectionString = Dados.conexao;
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.CommandText = "InserirUsuario";
                cmdUsuario.Parameters.AddWithValue("pnome", usuario.Nome);
                cmdUsuario.Parameters.AddWithValue("psenha", usuario.Senha);
                cmdUsuario.Connection = connUsuario;
                connUsuario.Open();
                // Resgata o IdUsuario gerado automaticamente pelo banco.
                // O método ExecuteScalar() retorna apenas uma única informaçao e numérica.
                usuario.IdUsuario = Convert.ToInt32(cmdUsuario.ExecuteScalar());
            }
            catch
            {
                throw new Exception("Não foi possível a conexão com  o banco de dados");
            }
            finally
            {
                connUsuario.Close();
            }
        }

        public void Alterar(ModeloUsuarios usuario)
        {
            try
            {
                connUsuario.ConnectionString = Dados.conexao;
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.CommandText = "AlterarUsuario";
                cmdUsuario.Parameters.AddWithValue("pidusuario", usuario.IdUsuario);
                cmdUsuario.Parameters.AddWithValue("pnome", usuario.Nome);
                cmdUsuario.Parameters.AddWithValue("psenha", usuario.Senha);
                cmdUsuario.Connection = connUsuario;
                connUsuario.Open();
                // Executa a Stored Procedure "AlterarUsuario" e não retorna nada.
                cmdUsuario.ExecuteNonQuery();
            }
            catch
            {
                throw new Exception("Não foi possível a conexão com  o banco de dados");
            }
            finally
            {
                connUsuario.Close();
            }
        }

        public bool Excluir(ModeloUsuarios usuario)
        {
            int resultado = 0;
            bool resposta = false;
            try
            {
                connUsuario.ConnectionString = Dados.conexao;
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.CommandText = "ExcluirUsuario";
                cmdUsuario.Parameters.AddWithValue("pidusuario", usuario.IdUsuario);
                cmdUsuario.Connection = connUsuario;
                connUsuario.Open();
                resultado = cmdUsuario.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir o usuário: " + usuario.Nome);
                }
                else
                {
                    resposta = true;
                }
                return resposta;
            }
            catch
            {
                throw new Exception("Não foi possível estabelecer a conexão com o banco de dados!");
            }
            finally
            {
                connUsuario.Close();
            }
        }

        public Modelos.ListaUsuarios Listagem(string filtro)
        {
            try
            {
                // Instância do objeto da lista genérica ListaUsuarios
                Modelos.ListaUsuarios objListaUsuarios = new ListaUsuarios();

                // Configura as informaçõessore o banco
                connUsuario.ConnectionString = Dados.conexao;
                cmdUsuario.Connection = connUsuario;
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.CommandText = "SelecionarUsuario";
                cmdUsuario.Parameters.AddWithValue("pfiltro", filtro);
                connUsuario.Open();
                MySqlDataReader dr = cmdUsuario.ExecuteReader();
                cmdUsuario.Parameters.Clear();
                while (dr.Read())
                {
                    ModeloUsuarios usuario = new ModeloUsuarios();
                    usuario.IdUsuario = int.Parse(dr["idusuario"].ToString());
                    usuario.Nome = dr["nome"].ToString();
                    // Adiciona o objeto usuário à lista
                    objListaUsuarios.Add(usuario);
                }
                return objListaUsuarios;
            }
            catch
            {
                throw new Exception("Não foi possível estabelecer a conexão com o banco de dados");
            }
            finally
            {
                connUsuario.Close();
            }
        }

     
    }
}
