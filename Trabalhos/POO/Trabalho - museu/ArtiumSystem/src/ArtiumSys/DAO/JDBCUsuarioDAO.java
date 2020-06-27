package ArtiumSys.DAO;

import ArtiumSys.Model.Usuario;
import ArtiumSys.Model.Login;

import java.sql.CallableStatement;
import java.sql.Connection;



public class JDBCUsuarioDAO implements UsuarioDAO{

	@Override
	public String CadastrarVistante(Usuario usuario, Login login) {
		try{
			System.out.println("Abrindo conexão...");
			Connection conexao = ConnectionFactory.createConnection();
			String sql = "{call prCadastrarVistante(?,?,?,?,?,?,?,?,?)}";
			CallableStatement myCall = conexao.prepareCall(sql);
			System.out.println("Efetuando Cadastro..");
			myCall.setString(1, login.getNome());
			myCall.setString(2, login.getTipoAcesso());
			myCall.setString(3, login.getCodCartao());
			myCall.setString(4, login.getSenha());
			myCall.setString(5, usuario.getTelefone());
			myCall.setString(6, usuario.getDataNascimento());
			myCall.setString(7, usuario.getSexo());
			myCall.setString(8, usuario.getEmail());
			myCall.setBoolean(9, usuario.isReceberConvite());
			myCall.execute();
			
			conexao.close();
			
			String msg = "Cadastro efetuado com sucesso";
			return msg;
			
		}catch(Exception ex){
			ex.printStackTrace();
		}
		return null;
		
	}

	@Override
	public String CadastrarFuncionario(Usuario usuario, Login login) {
		try{
			System.out.println("Abrindo conexão...");
			Connection conexao = ConnectionFactory.createConnection();
			String sql = "{call prCadastrarFuncionario(?,?,?,?,?,?,?,?,?,?)}";
			CallableStatement myCall = conexao.prepareCall(sql);
			System.out.println("Efetuando Cadastro..");
			myCall.setString(1, login.getNome());
			myCall.setString(2, login.getTipoAcesso());
			myCall.setString(3, login.getCodCartao());
			myCall.setString(4, login.getSenha());
			myCall.setString(5, usuario.getTelefone());
			myCall.setString(6, usuario.getDataNascimento());
			myCall.setString(7, usuario.getSexo());
			myCall.setString(8, usuario.getEmail());
			myCall.setString(9, usuario.getCargo());
			myCall.setString(10, usuario.getNumeroRA());
			myCall.execute();
			
			conexao.close();
			String msg = "Cadastro efetuado com sucesso";
			return msg;
		}catch(Exception ex){
			ex.printStackTrace();
		}
		return null;
		
		
	}

	@Override
	public String ExcluirConta(Usuario usuario) {
		try{
			System.out.println("Abrindo conexão...");
			Connection conexao = ConnectionFactory.createConnection();
			String sql = "{call prCadastrarVistante(?)}";
			CallableStatement myCall = conexao.prepareCall(sql);
			System.out.println("Efetuando Cadastro..");
			myCall.setInt(1, usuario.getIdUsuario());
			myCall.execute();
			
			conexao.close();
			String msg = "Conta deletado com sucesso";
			return msg;
			
		}catch(Exception ex){
			ex.printStackTrace();
		}
		
		return null;
		
	}

}
