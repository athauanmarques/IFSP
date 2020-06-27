package br.ifsp.banco.controle;

import br.ifsp.banco.bd.ContaDAO;
import br.ifsp.banco.bd.JDBCContaDAO;
import br.ifsp.modelo.Cliente;
import br.ifsp.modelo.Conta;

import java.util.ArrayList;

import br.ifsp.banco.bd.ClienteDAO;
import br.ifsp.banco.bd.JDBCClienteDAO;
public class CadastrarContaCtrl {
	
	public ArrayList<Cliente> obterClientes(){
		
		ClienteDAO cd = new JDBCClienteDAO();
		return cd.obterCliente();
	}
	
	public void gravarConta (Conta conta) {
		ContaDAO cd = new JDBCContaDAO();
		cd.gravaConta(conta);
	}

}
