package Pilha_Vetor;

import java.util

public class Demonstracao {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		public static final int valorFixo = 1000;
		//o variável valorFixo sempre sera o mesmo valor
		
		private int capacidade;
		
		private Object P[];
		
		private topo = -1;  //inicializará -1 significar o topo sera um valor "vazio", pois para o vetor 0 será o valor 1
		
		
		public PilhaComVetor() 
		{
			this(CapacidadeMax); 
			} 
		//utilizando o vetor com o tamanho máximo
		
		/* inicia a pilha para um arranjo com o tamanho fornecido; o paraˆmetro ´e o tamanho do vetor */ 
		public PilhaComVetor(int tam) 
		{ 
			Capacidade = tam;
			P = new Object[Capacidade];
		} 
		public int tamanho() 
		{ 
			return(topo + 1);
			
		} 
		public boolean vazia()
		{ 
			return(topo < 0); 
			}
		public void empilha(Object obj) throws StackFullException
		{
			if (tamanho() == Capacidade) throw new StackFullException(‘‘Pilha cheia!’’); P[++topo] = obj;
			}

		public Object desempilha() throws StackEmptyException
		{
			Object elemento; if (vazia()) throw new StackEmptyException(‘‘Pilha vazia!’’); 
			elemento = P[topo]; 
			P[topo] = null; 
			// Libera P[topo] para a // coleta de lixo topo--; return elemento; }
		}
//============================================================================================================
		public static Integer[] inverte(Integer[] a)
		{
			PilhaComVetor P = new PilhaComVetor(a.length);
			Integer[] b = new Integer[a.length]; for (int i = 0;
					i < a.length; i++) P.empilha(a[i]);
			for (int i = 0; i < a.length; i++) b[i] = (Integer) (P.desempilha()); return b;
			}
		
		
		
		
		

	}

}
