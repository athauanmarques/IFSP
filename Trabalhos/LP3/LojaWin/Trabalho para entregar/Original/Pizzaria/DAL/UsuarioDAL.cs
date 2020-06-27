using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using Pizzaria.Modelos;


namespace Pizzaria.DAL
{
    public class UsuarioDAL
    {
        MySqlConnection cx = new MySqlConnection();
        MySqlCommand cmdUsuario = new MySqlCommand();

        public void AlterarUsuario(ModelosUsuarios usuario)
        {
           
            try
            {
                cx.ConnectionString = Conexao.Conectar;
                cmdUsuario.Connection = cx;
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.CommandText = "AlterarUsuario";
                cmdUsuario.Parameters.AddWithValue("pidUsuarios", usuario.IdUsuarios);
                cmdUsuario.Parameters.AddWithValue("pusuario", usuario.Usuario);
                cmdUsuario.Parameters.AddWithValue("pfuncao", usuario.Funcao);
                cmdUsuario.Parameters.AddWithValue("psenha", usuario.Senha);
                cmdUsuario.Parameters.AddWithValue("ptipoAcesso", usuario.TipoAcesso);
                cmdUsuario.Parameters.AddWithValue("pfoto", usuario.Foto);
                cx.Open();
                cmdUsuario.ExecuteNonQuery();
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

        public bool ExcluirConta(ModelosUsuarios usuario)
        {
            int resultado = 0;
            bool resposta;
            try 
            {

                cx.ConnectionString = Conexao.Conectar;
                cmdUsuario.Connection = cx;
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.CommandText = "ExcluirUsuario";
                cmdUsuario.Parameters.AddWithValue("pidusuario", usuario.IdUsuarios);
                cx.Open();
                resultado = cmdUsuario.ExecuteNonQuery();
                if (resultado != 1)
                {
                    throw new Exception("Não foi possível excluir a conta!");
                }
                else
                {
                    resposta = true;
                }
                return resposta;

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

        public void CadastrarUsuario(ModelosUsuarios usuario)
        {
            try
            {
                cx.ConnectionString = Conexao.Conectar;
                cmdUsuario.Connection = cx;
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.CommandText = "CadastrarUsuarios";
                cmdUsuario.Parameters.AddWithValue("pusuario", usuario.Usuario);
                cmdUsuario.Parameters.AddWithValue("pfuncao", usuario.Funcao);
                cmdUsuario.Parameters.AddWithValue("psenha", usuario.Senha);
                cmdUsuario.Parameters.AddWithValue("ptipoAcesso", usuario.TipoAcesso);
                cmdUsuario.Parameters.AddWithValue("pfoto", usuario.Foto);
                cx.Open();
                usuario.IdUsuarios = Convert.ToInt32(cmdUsuario.ExecuteScalar());
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

      

        public UsuarioListar ListragemUsuario(string filtro)
        {

            try
            {
                // Instância do objeto da lista genérica ListaUsuarios
                UsuarioListar objUsuario = new UsuarioListar();

                // Configura as informaçõessore o banco
                cx.ConnectionString = Conexao.Conectar;
                cmdUsuario.Connection = cx;
                cmdUsuario.CommandType = CommandType.StoredProcedure;
                cmdUsuario.CommandText = "Contas";
                cmdUsuario.Parameters.AddWithValue("pfiltro", filtro);
                cx.Open();
                MySqlDataReader dr = cmdUsuario.ExecuteReader();
                cmdUsuario.Parameters.Clear();
                while (dr.Read())
                {
                    ModelosUsuarios usuario = new ModelosUsuarios();
                    usuario.IdUsuarios = int.Parse(dr["idUsuarios"].ToString());
                    usuario.Usuario = dr["usuario"].ToString();
                    usuario.Funcao = dr["funcao"].ToString();
                    usuario.Senha = dr["senha"].ToString();
                    usuario.TipoAcesso = dr["tipoAcesso"].ToString();
                    usuario.Foto = dr["foto"].ToString();
                    objUsuario.Add(usuario);
                }
                return objUsuario;
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



        public bool AutenticarAcessos(string nome)
        {
            bool verificacao = false;

            try
            {

                // Configura as informaçõessore o banco
                cx.ConnectionString = Conexao.Conectar;
                cmdUsuario.Connection = cx;
                cmdUsuario.CommandType = CommandType.Text;
                cmdUsuario.CommandText = "Select tipoAcesso from pizzaria.usuarios where usuario = '" + nome + "';";
                cmdUsuario.Parameters.AddWithValue("@usuario", nome);
                cx.Open();
                MySqlDataReader drUsuario = cmdUsuario.ExecuteReader();

                if (drUsuario.HasRows == true)
                {
                    while (drUsuario.Read())
                    {
                        if (drUsuario["tipoAcesso"].ToString() == "Administrador")
                        {
                            verificacao = true;
                        }
                        else
                        {
                            verificacao = false;
                        }
                    }
                }
                drUsuario.Close();

                return verificacao;


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



        public bool Login(ModelosUsuarios usuario)
        {
        try
        {
        bool validaUsuario = false, validaSenha = false, resposta =false;

        cx.ConnectionString = Conexao.Conectar;
        cmdUsuario.CommandType = CommandType.StoredProcedure;
        cmdUsuario.CommandText = "AutenticarUsuarios";
        cmdUsuario.Parameters.AddWithValue("pusuario", usuario.Usuario);
        cmdUsuario.Parameters.AddWithValue("psenha", usuario.Senha);
        cmdUsuario.Parameters.AddWithValue("pidusuario", usuario.IdUsuarios);
        cmdUsuario.Connection = cx;
        cx.Open();
        MySqlDataReader drUsuario = cmdUsuario.ExecuteReader();

        if (drUsuario.HasRows == true)
        {
            while (drUsuario.Read())
            {
                if (drUsuario["usuario"].ToString() == usuario.Usuario)
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
                cx.Close();
            }
            
    
        }

       
    }
}
