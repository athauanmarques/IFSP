/*


escreval ("Exercício 1")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Desenvolver o Diagrama de Blocos e um Algoritmo  ")
escreval ("que leia 10 elementos do vetor A.  ")
escreval ("Depois construir o vetor B com os dados do vetor A ")
escreval ("observando a seguinte regra:")
escreval
escreval ("Se índice for PAR o valor deve ser multiplicado por 5")
escreval ("Se índice for IMPAR o valor deve ser somado com 5.")
escrevAL
escreval ("Ao final apresentar o conteúdo do vetor B")
escreval
escreval("------------------------------------------------")
escreval


*/
#include <stdio.h>
int main (){
	int vetorA[10], vetorB[10];
	int i;
	
	for (i=0; i<10; i++){
		printf ("\n informe valor [%i]: ", i);
		scanf ("%i", &vetorA[i]);
	}
	
	
	for (i=0; i<10; i++){
		if (vetorA[i]%2==0){

			vetorB[i]=vetorA[i];
			
			printf ("\nvalor par: %i", vetorB[i]*5);
		
		}else{
			
			vetorB[i]=vetorA[i];
			
			printf ("\nvalor numero impar: %i", vetorB[i]+5);	
		
		}
	}
	
	getch ();
	return 0;
	
}
