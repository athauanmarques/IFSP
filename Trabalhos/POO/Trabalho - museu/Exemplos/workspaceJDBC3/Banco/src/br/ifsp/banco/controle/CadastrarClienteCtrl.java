package br.ifsp.banco.controle;
import br.ifsp.banco.bd.ClienteDAO;
import br.ifsp.banco.bd.JDBCClienteDAO;
import br.ifsp.modelo.Cliente;

public class CadastrarClienteCtrl {
	
	public void gravarCliente(Cliente cliente) {
		ClienteDAO cd = new JDBCClienteDAO();
		cd.gravaCliente(cliente);
	}

}
