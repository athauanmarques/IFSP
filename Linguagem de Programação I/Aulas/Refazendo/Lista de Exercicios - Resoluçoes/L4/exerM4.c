/*

exer3

Ler um vetor Q de 20 posições (aceitar somente números positivos). 
Escrever a seguir o valor do maior elemento de Q e a respectiva posição que ele ocupa no vetor. 


*/
#include<stdio.h>
int main (){
	int q[5];
	int i, maior, posicao;
	
	for (i=0; i<5; i++){
		printf ("informe valor: ");
		scanf ("%i", &q[i]);
		
		if (q[i]<0){
			while (q[i]>=0){
			printf ("voce digitou - %i - valor tem ser positivo: ", i);
			scanf ("%i", &q[i]);	
		}
		       }
	}
	
	for (i=0; i<5; i++){
		if (q[i]>maior){
		
		maior=q[i];
		posicao=i;	
		}
	}
	
	printf ("o maior numero e: %i", maior);
	printf ("\na posicao: %i", posicao);
	
	getch ();
	return 0;
	
	
	
	
	
	
	
}
