using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data.MySqlClient;
using LojaWin.Modelos; // referencia

namespace LojaWin.DAL
{
    public class usuariosDal
    {
        MySqlConnection connUsuario = new MySqlConnection(); // estancia objeto de conexão

        //Instancia Command que executa os comando de de SQL
        MySqlCommand cmsUsuario = new MySqlCommand();

        //Método de autenticação do usuário e sua senha
        
        public bool Login(ModeloUsuarios usuario) // Método - declarando paramentros obtendo informações da classe Modelos
        {

            bool validadUsuario = false, validaSenha = false, resposta = false; //iniciando as variáveis false

            try
            {
                //Pegando a configuração da camada Dados.conexao
                connUsuario.ConnectionString = Dados.conexao;

                //Determina acesso ao banco por StoredProcedure
                cmsUsuario.CommandType = CommandType.StoredProcedure;
                cmsUsuario.CommandText = "autenticarUsuario"; // o nome do procedure que sera executado
                
                //informar paramentros para StoredProcedure
                cmsUsuario.Parameters.AddWithValue("pnome", usuario.Nome);
                cmsUsuario.Parameters.AddWithValue("psenha", usuario.Senha);

                //Ojeto cmdUsuario recebe a configuração do banco
                cmsUsuario.Connection = connUsuario;

                //Abertura de conexão com o banco
                connUsuario.Open();

                // vai ativar a leitura dos dados no banco de dados
                MySqlDataReader drUsuario = cmsUsuario.ExecuteReader();
  
                //Se contém linhas de registro
                if (drUsuario.HasRows == true)
                {

                    while (drUsuario.Read())
                    {

                        if (drUsuario["nome"].ToString() == usuario.Nome)
                        {

                            validadUsuario = true;
                            if (drUsuario["senha"].ToString() == usuario.Senha)
                            {

                                validaSenha = true;
                            }
                        }
                    }
                }
                drUsuario.Close();
                if (validadUsuario == true && validaSenha == true)
                {

                    resposta = true;
                }
                return resposta;

            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.Message);        //Messagem box não funciona pois é um DLL

            }
            finally
            { 
            
                    connUsuario.Clone();
            }


        }

    }
}
