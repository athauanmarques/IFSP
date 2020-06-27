package br.ifsp.banco.bd;

import java.util.ArrayList;

import br.ifsp.modelo.Cliente;

public interface ClienteDAO {
	
	public void gravaCliente(Cliente cliente);
	public ArrayList<Cliente> obterCliente();
	public Cliente obterCliente(int idCliente);
	
}
