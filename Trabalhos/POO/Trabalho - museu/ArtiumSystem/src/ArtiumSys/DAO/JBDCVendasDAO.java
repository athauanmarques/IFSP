package ArtiumSys.DAO;

import ArtiumSys.Model.Estoque;
import ArtiumSys.Model.Usuario;
import ArtiumSys.Model.Vendas;

import java.sql.CallableStatement;
import java.sql.Connection;

public class JBDCVendasDAO implements VendasDAO{

	
	@Override
	public void EfetuarCompra(Usuario usuario, Estoque estoque, Vendas vendas) {
	 	try{
		System.out.println("Abrindo Conexão ArtiumSys");
		Connection conexao = ConnectionFactory.createConnection();
		String sql = "{call prEfetuarCompra(?,?,?)}";
		CallableStatement myCall = conexao.prepareCall(sql);
		myCall.setInt(1, estoque.getIdEstoque());
		myCall.setInt(2, usuario.getIdUsuario());
		myCall.setInt(3, vendas.getQuantidadeVendas());
		
	}
	catch(Exception ex) {
		ex.printStackTrace();
			
	}
		
	}
}