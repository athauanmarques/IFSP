/*

escreval ("Exercício 1")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Faça um algoritmo que determine o maior entre N ")
escreval ("números. A condição de parada é a entrada de um ")
escreval ("valor 0, ou seja, o algoritmo deve ficar calculando o ")
escreval ("maior até que a entrada seja igual a 0 (ZERO).")
escreval
escreval("------------------------------------------------")



*/
#include <stdio.h>
int main (){
	int n, maiorN;
	
	while (n!=0){
		printf ("informe um numero: ");
	    scanf ("%i", &n);
	if (n>maiorN){
		
		maiorN=n;
	}
		
	}
	
	printf ("o maior numero foi digitado foi: %i", maiorN);
	
	getch ();
	return 0;
	
	
}
