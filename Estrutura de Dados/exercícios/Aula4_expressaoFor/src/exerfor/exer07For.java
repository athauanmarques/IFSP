package exerfor;

public class exer07For {

	public static void main(String[] args) {
		/*
		 *  Este programa deve exibir o valor
		 *  de uma vari�vel, para o caso da vari�vel
		 *  ser igual a 5. Se n�o, exibe uma mensagem:
		 *  "Pr�xima linha loop..."
		 */
		
		for(int i = 1; i < 11; ++i) // i++ incrementar. ++i somar mais ele mesmos
		{
			if (i == 5)
			{
				
				System.out.println("Valor de i e: " + i);
				break; //interrompe a execu��o do loop
			}
			System.out.println("Pr�xima linha loop: " + i);
		}

	}

}
