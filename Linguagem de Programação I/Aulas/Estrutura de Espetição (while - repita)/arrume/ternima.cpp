/*

Programador: Athauan Marques da Cunha
Prontuário: 136246-1 
Data:  19/09/2013
Assunto: Repedição\while
			
Exercícios

Faça um programa que receba as 10 notas e apresente a media final da turma

media fina = soma das nota
             _______________
               media

*/
#include <stdio.h>
int aluno=1;
    float nota, soma=0, media;
    
    while(aluno<=10){
        printf("\nDigite uma nota: ");
        scanf("%f",&nota);
        soma+=nota; // igual a => soma=soma+nota;
       // printf("\naluno: %i soma: %f", aluno, soma);
        aluno++;
    }    
    
    media=soma/10;
    printf("\nMedia da turma: %f",media);
    
    getch();
    return 0;
}




















}
