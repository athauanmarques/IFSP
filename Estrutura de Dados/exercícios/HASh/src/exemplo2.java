
import java.util.HashSet;

import java.util.Set;

public class exemplo2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Pessoa p1 = new Pessoa();
		p1.setCpf("123456789");
		p1.setNome("Fulano da Silva");
		
		Pessoa p2 = new Pessoa();
		p1.setCpf("123456789");
		p1.setNome("Fulano da Silva");
		
		Set<Pessoa> conjunto = new HashSet<Pessoa>();
		conjunto.add(p1);
		conjunto.add(p2);
		
		for(Pessoa pessoa : conjunto)
		{
			System.out.println(pessoa.getCpf() + "  - " + pessoa.getNome());
		}

	}

}
