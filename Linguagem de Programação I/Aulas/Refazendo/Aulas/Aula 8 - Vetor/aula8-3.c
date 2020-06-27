/*

sei lá

escreval ("Exercício 3")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Desenvolver um Algoritmo que leia 5 elementos do ")
escreval ("vetor A.  ")
escreval ("No final apresente o Vetor A com os valores ")
escreval ("invertidos, os seja, os valores dos elementos 1 – 5 e ")
escreval ("2 – 4 devem ser trocados de posição.")
escreval
escreval("------------------------------------------------")
escreval

*/
#include <stdio.h>
int main (){
	int  vetorA[5];
	int j, i, aux;
	
	for (i=0; i<5; i++){
		printf ("digite valore de [%i]: ", i);
		scanf ("%i", &vetorA[i]);
	}
	
	j=6;
	
	for (i=0; i<3; i++){
	
	 aux=vetorA[i];
	 vetorA[i]=vetorA[j-i];
	 vetorA[j-i]=aux;
	 	
	}
	

            for (i=0; i<5; i++){
            	printf ("\n invertidos [%i]=[%i]", i, vetorA[i]);
            }
            
            
            getch ();
            return 0;
	
	
	
}
