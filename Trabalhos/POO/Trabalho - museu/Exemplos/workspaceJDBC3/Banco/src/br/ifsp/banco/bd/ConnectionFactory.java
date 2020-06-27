package br.ifsp.banco.bd;
import java.sql.Connection;
import java.sql.DriverManager;
public class ConnectionFactory {
	public static Connection createConnection() {
		String strConnection = "jdbc:mysql://localhost:3306/banco";
		String user = "root";
		String pass = "ifsp";
		Connection con = null;
		try {
			con = DriverManager.getConnection(strConnection,user,pass);
		}
		catch(Exception ex) {
			ex.printStackTrace();
		}
		return con;
	}
}
