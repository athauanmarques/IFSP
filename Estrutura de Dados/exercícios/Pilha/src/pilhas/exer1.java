package pilhas;

import java.util.Stack; // importar stack (pilha)

import javax.swing.JOptionPane;
public class exer1 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

	
		// pop = retira da pilha
		//push = colocar na pilha
		// empty = pilha vazia
		
		Stack<String> pilha = new Stack<String>();
		pilha.push("uva");
		pilha.push("Batata");
		pilha.push("Mamão");
		pilha.push("peixe");
		
		while(!pilha.isEmpty())    //se não estiver vazia 
		{
			String elementoPilha = pilha.pop();
			JOptionPane.showMessageDialog(null, elementoPilha);
			//JOptionPane.showMessageDialog(null, pilha.pop());
			
		}
		
	}

}
