/*

exer4

Ler um vetor A de 10 números. Após, ler mais um número e guardar em uma variável X. 
Armazenar em um vetor M o resultado de cada elemento de A multiplicado pelo valor X. 
Logo após, imprimir o vetor M. 


*/
#include <stdio.h>
int main (){
	int a[10], x;
	int m[10],i;
	
	for (i=0; i<10; i++){
		printf ("informe valor: ");
		scanf ("%i", &a[i]);
	}
	
	printf ("informe outro valor: ");
	scanf ("%i", &x);
	
	for (i=0; i<10; i++){
		m[i]=a[i]*x;
	
		printf ("\nos valores sao: %i", m[i]);
	}

getch();
return 0;

}
