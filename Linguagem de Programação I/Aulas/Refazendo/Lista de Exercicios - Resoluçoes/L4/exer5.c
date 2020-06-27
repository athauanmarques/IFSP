/*

exer5 (sei lá)

Faça um algoritmo para ler 20 números e armazenar em um vetor. 
Após a leitura total dos 20 números, 
o algoritmo deve escrever esses 20 números lidos na ordem inversa. 


*/
#include <stdio.h>
int main(){
	int vetor[5], i;
	
	
	for (i=0; i<5; i++){
		printf ("infome valor no vetor[%i]: ", i);
		scanf ("%i", &vetor[i]);
	}
	
	for (i=5; i<0; i--
	){
		printf ("o valores inversa são: [%i]", vetor[i]);
		
	}
	getch ();
	return 0;
	
}
