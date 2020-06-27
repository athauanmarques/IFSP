
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.util.Scanner;


public class InsereCliente {

	public static void main(String[] args) {
		Scanner entrada = new Scanner(System.in);
		
		String stringDeConexao ="jdbc:mysql://localhost:3306/banco";
		String usuario="root";
		String senha= "ifsp";
		
		try
		{
			System.out.println("Abrindo conexão");
			
			//Connection conexao = DriverManager.getConnection(stringDeConexao,usuario,senha);
			//usando clase ConnectionFactory
			Connection conexao = ConnectionFactory.createConnection();
			
			System.out.println("Informe o seu nome: ");
			String nome = entrada.nextLine();
			
			System.out.println("Informe o seu cpf");
			String cpf = entrada.nextLine();
			
			//String sql = "INSERT INTO cliente(nome, cpf) VALUES " + "('"+nome+"','"+cpf+"')"; // jeito errado
			String sql = "INSERT INTO cliente(nome, cpf) VALUES (?,?)";
			
			PreparedStatement comando = conexao.prepareStatement(sql);
			//sempre importar java.sql
			
			//Tratamento de sql injection
			comando.setString(1, nome);
			comando.setString(2, cpf);
			
			System.out.println("Executando comando...");
			comando.execute();
			
			System.out.println("Fechando conexao...");
			comando.close();
				
		}
		catch(Exception e) {e.printStackTrace();}
		

	}

}
