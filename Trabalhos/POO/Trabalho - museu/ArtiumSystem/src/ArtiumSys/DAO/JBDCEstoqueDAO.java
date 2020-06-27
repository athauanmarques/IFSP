package ArtiumSys.DAO;

import java.sql.CallableStatement;
import java.sql.Connection;

import ArtiumSys.Model.Estoque;

public class JBDCEstoqueDAO implements EstoqueDAO{

	@Override
	public void EntradaProduto(Estoque estoque) {
		try{
		System.out.println("Abrindo Conexão ArtiumSys");
		Connection conexao = ConnectionFactory.createConnection();
		String sql = "{call prEntradaProduto(?,?,?,?,?,?)}";
		CallableStatement myCall = conexao.prepareCall(sql);
		
		myCall.setString(1, estoque.getCodProduto());
		myCall.setString(2, estoque.getProduto());
		myCall.setString(3, estoque.getMarca());
		myCall.setString(4, estoque.getDescricaoProduto());
		myCall.setFloat(5, estoque.getPreco());
		myCall.setInt(6, estoque.getQtsEstoque());
		myCall.execute();
		
		System.out.println("Inserção de produto concluido");
		
		conexao.close();
		}
		catch(Exception ex) {
			ex.printStackTrace();
				
		}
		
	}

	@Override
	public void EditarProduto(Estoque estoque) {
	    try {
			
	    	System.out.println("Abrindo Conexão ArtiumSys");
			Connection conexao = ConnectionFactory.createConnection();
			String sql = "{call prEditarProduto(?,?,?,?,?,?,?)}";
			CallableStatement myCall = conexao.prepareCall(sql);
			
			myCall.setInt(1, estoque.getIdEstoque());
			myCall.setString(2, estoque.getCodProduto());
			myCall.setString(3, estoque.getProduto());
			myCall.setString(4, estoque.getMarca());
			myCall.setString(5, estoque.getDescricaoProduto());
			myCall.setFloat(6, estoque.getPreco());
			myCall.setInt(7, estoque.getQtsEstoque());
			myCall.execute();
			
			System.out.println("Aleração de produto concluido");
			
			conexao.close();
			
		}
		catch(Exception ex) {
			ex.printStackTrace();
				
		}
		
	}

	@Override
	public void DeletarProduto(Estoque estoque) {
	    try {
	    	System.out.println("Abrindo Conexão ArtiumSys");
			Connection conexao = ConnectionFactory.createConnection();
			String sql = "{call prDeletarProduto(?)}";
			CallableStatement myCall = conexao.prepareCall(sql);
			
			myCall.setInt(1, estoque.getIdEstoque());
			myCall.execute();
			
			System.out.println("Produto removido");
			
			conexao.close();
			
		}
		catch(Exception ex) {
			ex.printStackTrace();
				
		}
		
	}
	

}
