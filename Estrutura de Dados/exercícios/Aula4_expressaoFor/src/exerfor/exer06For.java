package exerfor;

import javax.swing.JOptionPane;

public class exer06For {

	public static void main(String[] args) {
		/*
		 * o Programa deve considerar o n�mero
		 * 3025 que apresenta a seguinte caracter�stica:
		 * 30 + 25 = 55 e 55^2 = 3025.
		 * Escreva um program que encontre todos os n�meros (>999 e < 10000)
		 * que apresentem essa mesma caracteristica.
		 * 
		 */

		int  aux1, aux2, x, b;
		
		
		
		for (int i = 1000; i < 10000; i++)
		{
			x = i/100;
			b = i%100;
			
			aux1 = x + b;
			aux2 = aux1  * aux1;
			
					
			if (aux1 == 55 && aux2 == 3025)
			{
				
				JOptionPane.showMessageDialog(null, "o numero: " + i + "esta dentro da regra");
			}
		}
		
		
	}

}
