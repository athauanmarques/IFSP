/*

Programador: Athauan Marques da Cunha
Prontu�rio: 136246-1 
Data:  19/09/2013
Assunto: Repedi��o\while
			
Exerc�cios

Escrever um programa que leia 10 valores para uma vari�vel n e, 
para cada um deles, calcule a tabuada de 1 at� n. Mostre a tabuada na forma:
1 * n = n
2 * n = 2n
3 * n = 3n
.......
n * n = n2
*/
#include <stdio.h>
int main (){
    int tabuada=0;
    int tabu=1;
    int numero, result;
    
    while (tabuada<=10){
          while (tabu){
                printf ("informe um valor: ");
                scanf ("%i", &numero);
                result=numero*tabuada;
