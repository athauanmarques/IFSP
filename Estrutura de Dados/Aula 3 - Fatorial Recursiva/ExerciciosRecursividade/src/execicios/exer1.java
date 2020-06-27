package execicios;

public class exer1 {

	public static void main(String[] args) 
	{
		/*
		 * 1>Crie um vetor de inteiros e construa um método recursivo para somar os valores do vetor. 
		 *
		 * */
		int fat = 1;
		
		for(int i = 0; i<fat;i++)
		{
			System.out.print(fnFatorial(fat));
			
		}

	}

	private static int fnFatorial(int fat2) 
	{
		return fat2 * (fat2-1); 
		
	}
}
