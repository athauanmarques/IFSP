package aula2_operadores;

import javax.swing.JOptionPane;

public class operadorTernario {

	public static void main(String[] args) {
		// tern�rio tem a mesma fun��o do "if", 
		// o tern�rio � muito pr�tico para economiza linhas de comando

		int x = 55, y = 100;
		
		System.out.println(x + y <= y - x ? "N�o" : "Sim"); 
		//a condi��ovem antes do simbolo "?"
		// o simbolo ":" � true e false (if / else), em outras palavras Se/Se n�o
		
		/*
		 * exer 1
		 * Fa�a um programa que encontre a media de duas notas,
		 * e verifique se a m�dia for >= 7, ent�o, dever� exibir o valor
		 *"aprovado" sen�o "reprovado"
		 
		 */
		
		
		
		int n1 = Integer.parseInt(JOptionPane.showInputDialog("Digite a nota 1: "));
		// t� convertendo para int, tudo que o usu�rio digitar no Dialog
		int n2 = Integer.parseInt(JOptionPane.showInputDialog("Digite a nota 2: "));
		int media = (n1 + n2)/2;
		
		JOptionPane.showMessageDialog(null, media >= 6 ? "Aprovado" : "reprovado");
		
	}

}
