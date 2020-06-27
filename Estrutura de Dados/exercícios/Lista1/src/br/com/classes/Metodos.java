package br.com.classes;

public class Metodos {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		
		public static double calcularFatorial02(int n)
		{
			double x = 0;
			
			while (x >1)
			{
				n = n * (x - 1);
			}
			x--;
			
			return n;
			
		}
		
		public static double calcularPotencia(int base, int expoente)
		{
			double resultado = 0;
			
			resultado = Math.pow(base, expoente);
			
			return resultado;
			
			
			
		}
	}

}
