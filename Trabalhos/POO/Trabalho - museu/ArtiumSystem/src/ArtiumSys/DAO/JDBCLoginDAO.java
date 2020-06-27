package ArtiumSys.DAO;

import ArtiumSys.Model.Login;


import java.sql.CallableStatement;// para stored procedure

import java.sql.Connection;
import java.sql.*;


public class JDBCLoginDAO implements LoginDAO{

	@Override
	public String verificarLogin(Login login) {
		
		try {
		
		System.out.println("Abrindo Conexão ArtiumSys");
		Connection conexao = ConnectionFactory.createConnection();
		String sql = "{call prVerificarLogin(?,?,?,?)}";
		
		CallableStatement myCall = conexao.prepareCall(sql);
		// myCall.setString(3, login.getTipoAcesso());
		
		myCall.setString(1, login.getCodCartao());
		myCall.setString(2, login.getSenha());
		myCall.setString(3, login.getTipoAcesso());
		myCall.registerOutParameter(4, Types.VARCHAR);
		myCall.execute();
		
		System.out.println("Executando a verificação");
		
		String jMsg = myCall.getString(4);
		System.out.println("Verificando usuário...");
		System.out.println("Resposta: " + jMsg);
		
		conexao.close();
		
		return jMsg;
		
		}
		catch(Exception ex) {
			ex.printStackTrace();
			return null;
		}
		
		
	}

	@Override
	public String redefinirSenha(Login login) {
		// TODO Auto-generated method stub
		return null;
	}

}
