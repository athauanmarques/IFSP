package pilhas;

import java.util.ArrayDeque;
import java.util.Deque;
import java.util.Stack;

// importe sempre as os tipos de pilhas

public class exer2 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Deque<String> pilha = new ArrayDeque<String>();
		
		pilha.push("Batata");
		pilha.push("Mamão");
		pilha.push("peixe");
		
		while (!pilha.isEmpty()){
			String elemento = pilha.pop();
			System.out.println(elemento);
			
		}

	}

}
