package br.com.programa;

import br.com.classes.Metodos;

public class TestaMetodos { // TestaMetodosRecursivos � uma palavra muito longa 

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		int n = 5; //o valor �5� est� sendo armazenado no vari�vel �n� do tipo int
		System.out.println("Fatorial de " + n + " � " + Metodos
				.calcularFatorial02(n));
		
		//potencia     
		int base = 2, expoente = 4;    

		/* os vari�vel do tipo int base receber 2 e expoente recebe4*/
		
		System.out.println(base + " elevado a " + expoente + " = " +
		                   Metodos.classcalcularPotencia(base, expoente));

		
		

	}

}
