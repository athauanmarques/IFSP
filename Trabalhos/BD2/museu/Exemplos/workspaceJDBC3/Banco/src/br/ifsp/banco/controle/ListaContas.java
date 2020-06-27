package br.ifsp.banco.controle;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;

import br.ifsp.banco.bd.ConnectionFactory;
public class ListaContas {

	public static void main(String[] args) {
		/*String strConnection = "jdbc:mysql://localhost:3306/banco";
		String user = "root";
		String pass = "ifsp";*/
		try {
			System.out.println("Abrindo a conexão...");
			//Connection con = DriverManager.getConnection(strConnection,user,pass);
			Connection con = ConnectionFactory.createConnection();
			String sql = "select * from conta";
			PreparedStatement comando = con.prepareStatement(sql);
			System.out.println("Executando");
			ResultSet result = comando.executeQuery();
			System.out.println("Resultados encontrados");
			while(result.next()) {
				System.out.printf("%d : %s - %.2f - %d\n",
				result.getInt("id"),
				result.getString("numero"),
				result.getDouble("saldo"),
				result.getInt("cliente_id"));
			}
			System.out.println("Fechando a connection");
			con.close();
		}
		catch(Exception ex) {
			ex.printStackTrace();
		}
	}

}
