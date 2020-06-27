package pilhas;

import java.util.ArrayDeque;
import java.util.Deque;

import javax.swing.JOptionPane;

public class exer3 {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Deque<String> pilha = new ArrayDeque<String>();
		
		String opcao;
		
		do{
			String nome  = JOptionPane.showInputDialog("Infome o nome: ");
			pilha.push(nome + " ");
			opcao = JOptionPane.showInputDialog("Deseja inserir mais um nome? \nSim = 1\nNão = 2");
			
		}while(opcao.equals("1"));
		 
		String resultado = "";
		while (!pilha.isEmpty()){
			resultado += pilha.pop();
		}
		
		JOptionPane.showMessageDialog(null, " " + resultado + " ");
		

	}

}
