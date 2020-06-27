package aula2_operadores;

import javax.swing.JOptionPane;

public class operadorTernario {

	public static void main(String[] args) {
		// ternário tem a mesma função do "if", 
		// o ternário é muito prático para economiza linhas de comando

		int x = 55, y = 100;
		
		System.out.println(x + y <= y - x ? "Não" : "Sim"); 
		//a condiçãovem antes do simbolo "?"
		// o simbolo ":" é true e false (if / else), em outras palavras Se/Se não
		
		/*
		 * exer 1
		 * Faça um programa que encontre a media de duas notas,
		 * e verifique se a média for >= 7, então, deverá exibir o valor
		 *"aprovado" senão "reprovado"
		 
		 */
		
		
		
		int n1 = Integer.parseInt(JOptionPane.showInputDialog("Digite a nota 1: "));
		// tá convertendo para int, tudo que o usuário digitar no Dialog
		int n2 = Integer.parseInt(JOptionPane.showInputDialog("Digite a nota 2: "));
		int media = (n1 + n2)/2;
		
		JOptionPane.showMessageDialog(null, media >= 6 ? "Aprovado" : "reprovado");
		
	}

}
