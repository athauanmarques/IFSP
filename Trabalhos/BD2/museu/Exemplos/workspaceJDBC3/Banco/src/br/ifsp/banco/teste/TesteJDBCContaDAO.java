package br.ifsp.banco.teste;
import br.ifsp.banco.bd.ClienteDAO;
import br.ifsp.banco.bd.ContaDAO;
import br.ifsp.banco.bd.JDBCClienteDAO;
import br.ifsp.banco.bd.JDBCContaDAO;
import br.ifsp.modelo.Cliente;
import br.ifsp.modelo.Conta;
import java.util.ArrayList;

public class TesteJDBCContaDAO {

	public static void main(String[] args) {
		ClienteDAO cdao = new JDBCClienteDAO();
		Cliente cliente = cdao.obterCliente(1);
		
		Conta conta = new Conta();
		conta.setNumero("1234-5");
		conta.setSaldo(1200.0);
		conta.setCliente(cliente);
		
		ContaDAO cd = new JDBCContaDAO();
		
		cd.gravaConta(conta);
		
		ArrayList<Conta> listaContas = new ArrayList<Conta>();
		
		listaContas = cd.oberContas();
		
		for (Conta c : listaContas)
		{
			System.out.println("CPF: " + c.getNumero());
			System.out.println("Saldo: " + c.getSaldo());
			System.out.println("Cliente: " + c.getCliente().getId());
		}
	}

}
