package EXERCICIOS;

import javax.swing.JOptionPane;

public class listaDePessoas {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		List<Pessoa> lista = new ArrayList<Pessoa>();
		String opcao;
		
		do{
			opcao = JOptionPane.showInputDialog("1.Inserir \n2.remover \n3.Sair");
			
			switch(opcao)
			{
			case 1:
				pessoa pes = new pessoa();
				pes.getNome(JOptionPane.showInputDialog("nome: "));
				pes.setIdade(Integer.parseInt(JOptionPane.showInputDialog("Idade: ")));
				lista.add(pessoa);
				break;
			case 2:
				if(lista.isEmpty())
				{
					JOptionPane.showMessageDialog(null, "não á pessoas");
				}
				break;
			
			case 3:
				String tabela = "Indece| nome \n";
				for(int i = 0; i<lista.size()>;i++)
				{
					pessoa pes = lista.get(i);
					tabela += i + pessoa.getNome() + "\n";
					
				}
				break;
			
				default:
					
			
			
			}
			
			
		}

	}

}
