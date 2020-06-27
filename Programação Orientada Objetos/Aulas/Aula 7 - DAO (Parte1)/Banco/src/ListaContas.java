

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class ListaContas {

	public static void main(String[] args) {
		
		String stringDeConexao ="jdbc:mysql://localhost:3306/banco";
		String usuario="root";
		String senha= "ifsp";
		
		try
		{
			System.out.println("Abrindo conexão");
			
			//Connection conexao = DriverManager.getConnection(stringDeConexao,usuario,senha);
			Connection conexao = ConnectionFactory.createConnection();
			String sql = "SELECT * FROM conta;";
			
			PreparedStatement comando = conexao.prepareStatement(sql);
			
			System.out.println("Executando comando...");
			ResultSet resultado = comando.executeQuery();
			
			while(resultado.next())
			{
				System.out.printf("%d , %s - %.2f - %d\n",
				resultado.getInt("id"),
				resultado.getString("nome"),
				resultado.getString("saldo"),
				resultado.getInt("cliente_id"));
				
			}
			System.out.println("Fechando conexão");
			conexao.close();
		

		}catch(Exception e) {e.printStackTrace();}
		
		
	}

}
