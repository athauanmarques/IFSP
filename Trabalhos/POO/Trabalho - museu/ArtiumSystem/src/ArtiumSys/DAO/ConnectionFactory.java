package ArtiumSys.DAO;

import java.sql.Connection;
import java.sql.DriverManager;

public class ConnectionFactory {
	public static Connection createConnection(){
		String strConnection = "jdbc:mysql://localhost:3306/artiumsystem";
		String user = "root";
		String pass = "123456";
		Connection con = null;
		try{
			con = DriverManager.getConnection(strConnection,user,pass);
		}
		catch(Exception ex) {
			ex.printStackTrace();
		}
		return con;
		
	}

}
