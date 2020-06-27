/*

lista (Alo) vetor e matriz

exercicio 1

 
Escreva um algoritmo que permita a leitura das notas de uma turma de 20 alunos. 
Calcular a média da turma e contar quantos alunos obtiveram nota acima desta média calculada.
Escrever a média da turma e o resultado da contagem. 

*/
#include <stdio.h>
int main (){
	float nota[20], media, total;
	int i, alunos=0;
	
	for (i=0; i<20; i++){
	
	printf ("informe nota do aluno: ");
	scanf ("%f", &nota[i]);
	total=total+nota[i];
	}
	
	media=total/20;
	
	for (i=0; i<20; i++){
	
		if (nota[i]>=media){
			alunos=alunos+1;	
		}
	}
	
	printf ("\na media da turma foi: %.2f", media);
	printf ("\nalunos ficaram acima da media: %i", alunos);
	
	
	getch ();
	return 0;
	
	
	
}
