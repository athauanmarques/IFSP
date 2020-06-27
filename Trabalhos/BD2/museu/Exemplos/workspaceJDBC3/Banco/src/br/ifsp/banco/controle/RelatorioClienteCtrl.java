package br.ifsp.banco.controle;

import java.util.ArrayList;

import br.ifsp.banco.bd.ClienteDAO;
import br.ifsp.banco.bd.JDBCClienteDAO;
import br.ifsp.modelo.Cliente;

public class RelatorioClienteCtrl {
	public ArrayList<Cliente> obterClientes(){
		
		ClienteDAO cd = new JDBCClienteDAO();
		return cd.obterCliente();
		
	}
}
