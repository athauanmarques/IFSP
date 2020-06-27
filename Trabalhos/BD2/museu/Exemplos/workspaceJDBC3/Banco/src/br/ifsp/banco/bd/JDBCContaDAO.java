package br.ifsp.banco.bd;
import java.util.ArrayList;

import br.ifsp.modelo.Cliente;
import br.ifsp.modelo.Conta;

import java.sql.Connection;

import java.sql.PreparedStatement;
import java.sql.ResultSet;
public class JDBCContaDAO implements ContaDAO{

	@Override
	public void gravaConta(Conta conta) {
		try {
			System.out.println("Abrindo a conexão...");
			Connection con= ConnectionFactory.createConnection();
			String sql = "insert into conta (numero,saldo,cliente_id) values (?,?,?)";
			PreparedStatement command = con.prepareStatement(sql);
			command.setString(1,conta.getNumero());
			command.setDouble(2, conta.getSaldo());
			command.setInt(3,conta.getCliente().getId());
			System.out.println("Executando comando...");
			command.execute();
			con.close();
		}
		catch(Exception ex) {
			ex.printStackTrace();
		}
	}

	@Override
	public ArrayList<Conta> oberContas() {
		try {
			Connection con = ConnectionFactory.createConnection();
			String sql = "select * from conta";
			PreparedStatement command = con.prepareStatement(sql);
			ResultSet result = command.executeQuery();
			ArrayList<Conta> listaContas = new ArrayList<Conta>();
			ClienteDAO cd = new JDBCClienteDAO();
			System.out.println("Resultados encontrados");
			while(result.next()) {
				System.out.printf("%d - %s - %2.f - %d\n",
						result.getInt("id"),
						result.getString("numero"),
						result.getDouble("saldo"),
						result.getInt("cliente_id"));
				Conta c = new Conta();
				c.setId(result.getInt("id"));
				c.setNumero(result.getString("numero"));
				c.setSaldo(result.getDouble("saldo"));
				//Obtendo o cliente
				Cliente cliente = cd.obterCliente(result.getInt("cliente_id"));
				c.setCliente(cliente);
				listaContas.add(c);
				
			}
		}
		catch(Exception ex) {
			ex.printStackTrace();
		}
		return null;
	}
	
}
