/*

Programador: Athauan Marques da Cunha
Prontu�rio: 136246-1 
Data:  19/11/2013
Assunto: Malloc (Aloca��o de Din�mica de vetor) 
			
Exerc�cio

Crie um tipo estruturado para representar um endere�o, com ruas, numeros, CEP, estado.
Crie um vetor do tipo endere�o para armazenar N endere�os informados pelo usu�rio. 
	
	
	
*/
#include <stdio.h>
#include <boole.h>
int main(){
	
	int * vetor;
	char ruas, estados, numeros, cep, i, n;
	
	
	printf ("infome numero do endereco: ");
	scanf ("%i", &n);
	/*
	printf ("informe enderco de ruas: ");
	scanf ("%c", &ruas);
	printf ("informe estado: ");
	scanf ("%c", &estados);
	printf ("informe numero: ");
	scanf ("%i", &numeros);
	printf ("CEP: ");
	scanf ("%i", &cep);
	*/
	
	vetor = (int*)malloc(n*sizeof(char*));
		if (vetor == NULL){
			printf ("Erro na alocacao");
			exit (1);
		}
		
		
	
		




	
}
