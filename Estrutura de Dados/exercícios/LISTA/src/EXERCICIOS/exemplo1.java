package EXERCICIOS;

import java.awt.List;
import java.util.ArrayList;;

public class exemplo1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
	 java.util.List<String> lista = new ArrayList<String>();
		//list<tipo>  nomeVariável = new ArrayList<tipoVáriavel>();
		lista.add("Estrutura de dados");
		lista.add("Disciplina");
		lista.add("IFSP");
		
		for(int i =0; i < lista.size(); i++)
		{
			String elemento = lista.get(i);
			System.out.println(elemento);
		}
				
		
		
	
		for(int i =0; i < lista.size(); i++)
		{
			String elemento = lista.get(i);
			System.out.println(elemento);
		}
				
				
		//removendo um elemento do meio da lista
		lista.remove(2);
		System.out.println();
		for(int i =0; i < lista.size(); i++)
		{
			String elemento = lista.get(i);
			System.out.println(elemento);
		}
			

	}

}
