/*

Programador: Athauan Marques da Cunha
Prontuário: 136246-1 
Data:  19/11/2013
Assunto: Malloc (Alocação de Dinâmica de vetor) 
			
Exercício

Crie um tipo estruturado para representar um endereço, com ruas, numeros, CEP, estado.
Crie um vetor do tipo endereço para armazenar N endereços informados pelo usuário. 
	
	
	
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
