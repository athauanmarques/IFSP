/*

exer5 (sei l�)

Fa�a um algoritmo para ler 20 n�meros e armazenar em um vetor. 
Ap�s a leitura total dos 20 n�meros, 
o algoritmo deve escrever esses 20 n�meros lidos na ordem inversa. 


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
		printf ("o valores inversa s�o: [%i]", vetor[i]);
		
	}
	getch ();
	return 0;
	
}
