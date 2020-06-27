package br.ifsp.banco.bd;
import java.util.ArrayList;

import br.ifsp.modelo.Cliente;

import java.sql.Connection;

import java.sql.PreparedStatement;
import java.sql.ResultSet;

public class JDBCClienteDAO implements ClienteDAO {


	@Override
	public void gravaCliente(Cliente cliente) {
		try {
		System.out.println("Abrinfo Conexão...");
		Connection conexao = ConnectionFactory.createConnection();
		
		String sql = "INSERT INTO cliente (nome, cpf) VALUES (?,?)";
		
		PreparedStatement comando = conexao.prepareStatement(sql);
		
		comando.setString(1, cliente.getNome());
		comando.setString(2, cliente.getCPF());
		
		System.out.println("Executando comando .. ");
		comando.execute();
		
		System.out.println("Executando comando .. ");
		conexao.close();
		
		
		}
		catch(Exception ex) {
			
		}
		
		
		
	}

	@Override
	public ArrayList<Cliente> obterCliente(){
		try {
			Connection con = ConnectionFactory.createConnection();
			String sql = "select * from cliente";
			PreparedStatement command = con.prepareStatement(sql);
			ResultSet result = command.executeQuery();
			ArrayList<Cliente> listaClientes = new ArrayList<Cliente>();
		//	ClienteDAO cd = new JDBCClienteDAO();
			
			System.out.println("Resultados encontrados");
			
			while(result.next()) {
				
				
				Cliente c = new Cliente();
				c.setId(result.getInt("id"));
				c.setNome(result.getString("nome"));
				c.setCPF(result.getString("cpf"));
				//Obtendo o cliente
				listaClientes.add(c);
				
			}
			
			System.out.println("fechado");
			con.close();
			return listaClientes;
			//con.closer();
		}
		catch(Exception ex) {
			ex.printStackTrace();
			return null;
		}
		
	}
	
	@Override
	public Cliente obterCliente(int idCliente) {
		try {
			Connection con = ConnectionFactory.createConnection();
			String sql = "select * from cliente where id = ?";
			PreparedStatement command = con.prepareStatement(sql);
			
			command.setInt(1, idCliente);
			
			System.out.println("Executando comando...\n");
			ResultSet resultado = command.executeQuery();

			System.out.println("Resultados encontrados");
			
			Cliente c = new Cliente();
			
			while(resultado.next()) {
				
				
				
				c.setId(resultado.getInt("id"));
				c.setNome(resultado.getString("nome"));
				c.setCPF(resultado.getString("cpf"));
				
			}
			
			System.out.println("fechado");
			con.close();
			//con.closer();
			
			return c;
		}
		catch(Exception ex) {
			ex.printStackTrace();
			return null;
		}
		
	}
	


}
