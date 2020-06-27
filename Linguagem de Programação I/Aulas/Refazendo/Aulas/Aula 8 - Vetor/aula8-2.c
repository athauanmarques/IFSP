/*

escreval ("Exercício 2")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Desenvolver o Diagrama de Blocos e um Algoritmo ")
escreval ("que leia 5 elementos do vetor A. ")
escreval ("No final apresente o total de todos os elementos que ")
escreval ("sejam ímpares.")
escreval
escreval("------------------------------------------------")
escreval

*/
#include <stdio.h>
int main (){
	int vetor[5];
	int i, soma;
	
	for (i=0; i<5; i++){
		printf ("informer os valore do vetor: [%i]: ", i);
		scanf ("%i", &vetor[i]);
	}
	for (i=0; i<5; i++){
		if (vetor[i]%2 !=0){
			soma=soma+vetor[i];
				
		}
	}
	
	printf ("total: %i", soma);
	
	getch ();
	return 0;
	
}
