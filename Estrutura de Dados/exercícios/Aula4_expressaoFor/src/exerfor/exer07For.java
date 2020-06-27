package exerfor;

public class exer07For {

	public static void main(String[] args) {
		/*
		 *  Este programa deve exibir o valor
		 *  de uma variável, para o caso da variável
		 *  ser igual a 5. Se não, exibe uma mensagem:
		 *  "Próxima linha loop..."
		 */
		
		for(int i = 1; i < 11; ++i) // i++ incrementar. ++i somar mais ele mesmos
		{
			if (i == 5)
			{
				
				System.out.println("Valor de i e: " + i);
				break; //interrompe a execução do loop
			}
			System.out.println("Próxima linha loop: " + i);
		}

	}

}
