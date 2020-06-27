package ArtiumSys.DAO;

import java.sql.CallableStatement;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.Connection;
import java.util.ArrayList;

import ArtiumSys.Model.Acervo;
import ArtiumSys.Model.Usuario;

public class JBDCAcervoDAO implements AcervoDAO{

	@Override
	public void ReservarEvento(Acervo acervo, Usuario usuario) {
		try {
			System.out.println("Abrindo Conexão ArtiumSys");
			Connection conexao = ConnectionFactory.createConnection();
			String sql = "{call prReservarEvento(?,?)}";
			CallableStatement myCall = conexao.prepareCall(sql);
			
			myCall.setInt(1, acervo.getIdAcevo());
			myCall.setInt(2, usuario.getIdUsuario());
			myCall.execute();
			
			System.out.println("reserva executado...");
			
			conexao.close();
			
		}
		catch(Exception ex) {
			ex.printStackTrace();
			
		}
	
		
	}

	@Override
	public void CancelarReserva(Acervo acervo, Usuario usuario) {
		try {
			System.out.println("Abrindo Conexão ArtiumSys");
			Connection conexao = ConnectionFactory.createConnection();
			String sql = "{call prCancelarReserva(?,?)}";
			CallableStatement myCall = conexao.prepareCall(sql);
			
			myCall.setInt(1, acervo.getIdAcevo());
			myCall.setInt(2, usuario.getIdUsuario());
			myCall.execute();
			
			System.out.println("reserva cancelado...");
			
			conexao.close();
			
			
		}
		catch(Exception ex) {
			ex.printStackTrace();
			
		}
	
		
	}

	@Override
	public void ExcluirAcervo(Acervo acervo) {
	try {
		System.out.println("Abrindo Conexão ArtiumSys");
		Connection conexao = ConnectionFactory.createConnection();
		String sql = "{call prExcluirAcervo(?)}";
		CallableStatement myCall = conexao.prepareCall(sql);
		
		myCall.setInt(1, acervo.getIdAcevo());
		System.out.println("reserva cancelado...");
		
		conexao.close();
			
		}
		catch(Exception ex) {
			ex.printStackTrace();
			
		}
		
	}

	@Override
	public String AdicionarAcervo(Acervo acervo) {
		try {
			System.out.println("Abrindo Conexão ArtiumSys");
			Connection conexao = ConnectionFactory.createConnection();
			String sql = "{call prAdicionarAcervo(?,?,?,?,?,?,?,?,?,?,?,?,?,?)}";
			
			CallableStatement myCall = conexao.prepareCall(sql);
			
			myCall.setString(1, acervo.getTitulo());
			myCall.setString(2, acervo.getDescricao());
			myCall.setString(3, acervo.getPeriodo());
			myCall.setString(4, acervo.getDataInicio());
			myCall.setString(5, acervo.getDataFinal());
			myCall.setString(6, acervo.getCidade());
			myCall.setString(7, acervo.getEndereco());
			myCall.setString(8, acervo.getEstado());
			myCall.setString(9, acervo.getCep());
			myCall.setString(10, acervo.getResponsavel());
			myCall.setString(11, acervo.getTelResponvel());
			myCall.setInt(12, acervo.getLimiteReserva());
			myCall.setInt(13, acervo.getMaxVisitante());
			myCall.setBoolean(14, acervo.isEnviarConvites());
			myCall.execute();
		
			System.out.println("Executando o cadastro..");
			
			String jMsg = "Cadastro de evento cadastrado";
			System.out.println("Resposta: " + jMsg);
			
			conexao.close();
			
			return jMsg;
			
		}
		catch(Exception ex) {
			ex.printStackTrace();
		
		}
	
		return null;
	}

	@Override
	public ArrayList<Acervo> obterAcervo() {
		try{
			
			Connection conexao = ConnectionFactory.createConnection();
			String sql = "select * from artiumsystem.acervo";
			PreparedStatement command = conexao.prepareStatement(sql);
			ResultSet result = command.executeQuery();
			ArrayList<Acervo> listarTabela = new ArrayList<Acervo> ();
			System.out.println("Resultados encontrados");
		
			while(result.next()){
			
				Acervo acervo = new Acervo();
				acervo.setIdAcevo(result.getInt("idAcervo"));
				acervo.setTitulo(result.getString("titulo"));
				acervo.setDescricao(result.getString("descricao"));
				acervo.setPeriodo(result.getString("periodo"));
				acervo.setDataInicio(result.getString("dataInicio"));
				acervo.setDataFinal(result.getString("dataFinal"));
				acervo.setCidade(result.getString("cidade"));
				acervo.setEndereco(result.getString("endereco"));
				acervo.setEstado(result.getString("estado"));
				acervo.setCep(result.getString("cep"));
				acervo.setResponsavel(result.getString("responsavel"));
				acervo.setTelResponvel(result.getString("telResponvel"));
				acervo.setLimiteReserva(result.getInt("limiteReserva"));
				acervo.setMaxVisitante(result.getInt("maxVisitante"));
				acervo.setEnviarConvites(result.getBoolean("enviarConvites"));
			
				listarTabela.add(acervo);
			
			}
		System.out.println("Conexão fechado...");
		conexao.close();
		return listarTabela;
		}
		catch(Exception ex) {
			ex.printStackTrace();
			return null;
				
		}
		
	}

	@Override
	public ArrayList<Acervo> listarTabela() {
		try {
			Connection conexao = ConnectionFactory.createConnection();
			String sql = "select * from artiumsystem.acervo";
			PreparedStatement command = conexao.prepareStatement(sql);
			ResultSet result = command.executeQuery();
			ArrayList<Acervo> listramento = new ArrayList<Acervo>();
			System.out.println("Resultados encontrados");
			
			while(result.next()){
				Acervo c = new Acervo();
				c.setIdAcevo(result.getInt("idAcervo"));
				c.setTitulo(result.getString("titulo"));
				c.setDescricao(result.getString("descricao"));
				c.setPeriodo(result.getString("periodo"));
				c.setDataInicio(result.getString("dataInicio"));
				c.setDataFinal(result.getString("dataFinal"));
				c.setCidade(result.getString("cidade"));
				c.setEndereco(result.getString("endereco"));
				c.setEstado(result.getString("estado"));
				c.setCep(result.getString("cep"));
				c.setResponsavel(result.getString("responsavel"));
				c.setTelResponvel(result.getString("telResponvel"));
				c.setLimiteReserva(result.getInt("limiteReserva"));
				c.setMaxVisitante(result.getInt("maxVisitante"));
				c.setEnviarConvites(result.getBoolean("enviarConvites"));
				listramento.add(c);
			}
			
			System.out.println("fechado");
			conexao.close();
			return listramento;
			
		}
		catch(Exception ex) {
			ex.printStackTrace();
			return null;
				
		}
		
		
	}

	@Override
	public void editar(int tituloSelecionado) {
		try{
		Connection conexao = ConnectionFactory.createConnection();
		String sql = "select * from acervo where idAcervo = ?";
		PreparedStatement command = conexao.prepareStatement(sql);
		ResultSet result = command.executeQuery();
		command.setInt(1, tituloSelecionado);
		result = command.executeQuery();
		if(result.next()) {
			Acervo c = new Acervo();
			c.setIdAcevo(result.getInt("idAcervo"));
			c.setTitulo(result.getString("titulo"));
			c.setDescricao(result.getString("descricao"));
			c.setPeriodo(result.getString("periodo"));
			c.setDataInicio(result.getString("dataInicio"));
			c.setDataFinal(result.getString("dataFinal"));
			c.setCidade(result.getString("cidade"));
			c.setEndereco(result.getString("endereco"));
			c.setEstado(result.getString("estado"));
			c.setCep(result.getString("cep"));
			c.setResponsavel(result.getString("responsavel"));
			c.setTelResponvel(result.getString("telResponvel"));
			c.setLimiteReserva(result.getInt("limiteReserva"));
			c.setMaxVisitante(result.getInt("maxVisitante"));
			c.setEnviarConvites(result.getBoolean("enviarConvites"));
		
			System.out.println("Resultados encontrados");
			
			
		} else {

		}
		
	
		System.out.println("fechado");
		conexao.close();

		
	}
	catch(Exception ex) {
		ex.printStackTrace();
			
	}
		
	}


	@Override
	public ArrayList<Acervo> read() {
		try {
			Connection conexao = ConnectionFactory.createConnection();
			String sql = "select * from acervo";
			PreparedStatement stmt = conexao.prepareStatement(sql);
			ResultSet result = stmt.executeQuery();
			ArrayList<Acervo> listarAcervo = new ArrayList<Acervo>();
			
			while(result.next())
			{
				Acervo c = new Acervo();
				c.setIdAcevo(result.getInt("idAcervo"));
				c.setTitulo(result.getString("titulo"));
				c.setDescricao(result.getString("descricao"));
				c.setPeriodo(result.getString("periodo"));
				c.setDataInicio(result.getString("dataInicio"));
				c.setDataFinal(result.getString("dataFinal"));
				c.setCidade(result.getString("cidade"));
				c.setEndereco(result.getString("endereco"));
				c.setEstado(result.getString("estado"));
				c.setCep(result.getString("cep"));
				c.setResponsavel(result.getString("responsavel"));
				c.setTelResponvel(result.getString("telResponvel"));
				c.setLimiteReserva(result.getInt("limiteReserva"));
				c.setMaxVisitante(result.getInt("maxVisitante"));
				c.setEnviarConvites(result.getBoolean("enviarConvites"));
				listarAcervo.add(c);
				
				
			}
			System.out.println("Resultados encontrados");
			conexao.close();
			return listarAcervo;
			
		}
			catch(Exception ex) {
				ex.printStackTrace();
				return null;
			}
	
	}

	
	

}








