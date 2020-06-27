#include <stdio.h>
#include "operacoes.h"


int main()
{
    int x, y;
    char opcao;
    
    printf("Digite o valor de x: ");
    scanf("%i",&x);
    printf("Digite o valor de y: ");
    scanf("%i",&y);
    
    menu();
    
    printf("\n\nDigite a opcao desejada: ");
    opcao=getche();
    
    switch(opcao){
        case '+':
             printf("\nSoma: %i",soma(x,y));             
             break;
        case '-':
             printf("\nSubtracao: %i",subtracao(x,y));
             break;
        case '/':
             if(y!=0){
                  printf("\nDivisao: %i",divisao(x,y));
             }else{
                  printf("\nNao existe divisao por zero!");
             }
             break;
        case '*':
             printf("\nMultiplicacao: %i",multiplicacao(x,y));
             break;
        default:
             printf("Operador invalido!");
    }
    
  getch();
  return 0;
}
