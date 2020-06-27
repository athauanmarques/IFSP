package ArtiumSys.DAO;

import java.sql.CallableStatement;
import java.sql.Connection;
import java.sql.Date;

import ArtiumSys.Model.Acervo;
import ArtiumSys.Model.Restauracao;
import ArtiumSys.Model.Usuario;

public class JDBCRestauracaoDAO implements RestauracaoDAO{

	@Override
	public String SolicitarRestauracao(Acervo acervo, Usuario usuario, Restauracao restauracao) {
		 try {
		    	System.out.println("Abrindo Conexão ArtiumSys");
				Connection conexao = ConnectionFactory.createConnection();
				String sql = "{call prSolicitarRestauracao(?,?,?)}";
				System.out.println("Enviando solicitação...");
				CallableStatement myCall = conexao.prepareCall(sql);
				myCall.setDate(1,(Date) restauracao.getPrazoFinal());
				myCall.setInt(2, acervo.getIdAcevo());
				myCall.setInt(3, usuario.getIdUsuario());
				myCall.execute();
				
				conexao.close();
				String msg = "Solicitacao enviada com sucesso.";
				System.out.println(msg);
				return msg;
			}
			catch(Exception ex) {
				ex.printStackTrace();
					
			}
			return null;
	}

	@Override
	public void AlterarStatus(Acervo acervo, Usuario usuario, Restauracao restauracao) {
		
		try{
			System.out.println("Abrindo Conexão ArtiumSys");
		
		Connection conexao = ConnectionFactory.createConnection();
		String sql = "{call prAlterarStatus(?,?,?)}";
		System.out.println("Enviando solicitação...");
		CallableStatement myCall = conexao.prepareCall(sql);
		myCall.setString(1, restauracao.getStatusRestaurar());;
		myCall.setInt(2, acervo.getIdAcevo());
		myCall.setInt(3, usuario.getIdUsuario());
		myCall.execute();

		conexao.close();
		System.out.println("Alteração enviada com sucesso.");
		
		}
	catch(Exception ex) {
		ex.printStackTrace();
	}
	
		
	}

}
