/*

lista (Alo) vetor e matriz

exercicio 1

Escreva um algoritmo que permita a leitura dos nomes de 10 pessoas,
e armazene os nomes lidos em um vetor. 
Após isto, o algoritmo deve permitir a leitura de mais 1 nome qualquer de pessoa,
e depois escrever a mensagem ACHEI, 
se o nome estiver entre os 10 nomes lidos anteriormente (guardados no vetor), 
ou NÃO ACHEI caso contrário.

*/
#include <stdio.h>

int main (){
	char nomes[10], outroNome;
	char i=0;
	
	printf ("informe outro nome: ");
	scanf ("%c", &outroNome);
	
	for (i=0; i<10; i++){

	printf ("\ninforme nomes no vertor: ");
	scanf ("%c", &nomes[i]);
	//nomes[i]= getch();
}
	if (nomes[i]==outroNome){
		printf ("\n\nAchei");
	}else{
		printf ("\n\nNao achei");
	}
	
	getch ();
	return 0;
	
	
	
}
