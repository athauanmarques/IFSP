package br.ifsp.banco.teste;
import java.util.ArrayList;

import br.ifsp.banco.bd.ClienteDAO;
import br.ifsp.banco.bd.JDBCClienteDAO;
import br.ifsp.modelo.Cliente;
public class TesteJDBCClienteDao {

	public static void main(String[] args) {
		Cliente cliente = new Cliente();
		cliente.setCPF("123.456.789-12");
		cliente.setNome("Athauan Marques");
		
		ClienteDAO cd = new JDBCClienteDAO();
		
		cd.gravaCliente(cliente);
		
		ArrayList<Cliente> listaClientes = new ArrayList<Cliente>();
		listaClientes = cd.obterCliente();
		
		listaClientes = cd.obterCliente();
		
		for(Cliente c : listaClientes) {
			
			System.out.println("CPF: " + c.getCPF());
			System.out.println("Nome: " + c.getNome());
			
		}
		

	}

}
