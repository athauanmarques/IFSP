package br.ifsp.banco.bd;
import java.util.ArrayList;

import br.ifsp.modelo.Conta;
public interface ContaDAO {
	public void gravaConta(Conta conta);
	public ArrayList<Conta> oberContas();
}
