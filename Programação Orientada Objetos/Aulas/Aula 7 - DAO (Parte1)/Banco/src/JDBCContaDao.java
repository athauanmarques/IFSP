import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.util.ArrayList;

public class JDBCContaDao implements ContaDAO {

	@Override
	public void gravaConta(Conta conta) {
		try {
			System.out.println("Abrindo conexão");
			Connection conexao = ConnectionFactory.createConnection();
			
			String sql = "INSERT INTO conta (numero, saldo, cliente_id) VALUES (?, ?, ?)";
			
			PreparedStatement comando = conexao.prepareStatement(sql);
			
			comando.setString(1, conta.getNumero());
			comando.setDouble(2, conta.getSaldo());
			comando.setInt(3, conta.getCliente().getId());
			
			System.out.println("Executando comando...");
			comando.execute();
			
			System.out.println("Fechando conexao...");
			comando.close();
				
		}catch(Exception e) {
			e.printStackTrace();
		}
					
	}

	@Override
	public ArrayList<Conta> obterContas() {
		try{
			System.out.println("Abrindo conexão");
			Connection conexao = ConnectionFactory.createConnection();
			
			String sql= "SELECT * from conta";
			PreparedStatement comando = conexao.prepareStatement(sql);
			System.out.println("Executando comando...");
			ResultSet resultado = comando.executeQuery();
			
			ArrayList<Conta> listaContas = new ArrayList<Conta>();
			ClienteDAO cd = ClienteDAO();
			
			System.out.println("Resultados encontrados: \n");
			
			while (resultado.next()) {
				System.out.printf("%d: %s - %.2f - %d\n", 
						resultado.getInt("id"),
						resultado.getString("numero"),
						resultado.getDouble("saldo"),
						resultado.getInt("cliente_id"));
			Conta c =new Conta();
			c.setId(resultado.getInt("id"));
			c.setNumero(resultado.getString("numero"));
			c.setSaldo(resultado.getDouble("saldo"));
			
			//Obtendo clientes
			Cliente cliente = cd.obterCliente(resultado.getInt("cliente_id"));
			c.setCliente(cliente);
			
			listaContas.add(c);
			}
			
			System.out.println("\n Fechando conexao...");
			conexao.close();
			
		
		return listaContas;
	
		}catch(Exception e) {
			e.printStackTrace();
			return null;
		}
	}
}