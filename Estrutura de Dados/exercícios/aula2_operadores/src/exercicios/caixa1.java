package exercicios;

import javax.swing.JOptionPane;

public class caixa1 {

	public static void main(String[] args) {
		/*
		 * O programa recebeo valor do saque, que aceitar� apenas m�ltiplos de 5
		 * Exibir al�m do valor do saque, a quantidade de notas para c�lula
		 */
		final int valor = 1000; // final � um valor est�tica, que s� vai funcionar nesta classe
		int saque = valor; // valor atribui��o de qual quer valores
		
		int c5 = 0, c10 = 0, c20 = 0, c50 = 0;
			
		c50 = saque/50;
		saque %= 50;
		
		c10 = saque/10;
		saque %= 10;

		c20 = saque/20;
		saque %= 20;
		
		c5 = saque/5;
		saque %= 5;
		
		System.out.println("notas 50: " + c50);
		System.out.println("notas 20: " + c20);
		System.out.println("notas 10: " + c10);
		System.out.println("notas 5: " + c5);
		

	}

}
