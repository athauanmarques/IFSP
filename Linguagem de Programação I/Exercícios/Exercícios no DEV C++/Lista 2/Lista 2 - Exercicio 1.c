#include <stdio.h>
#include <stdlib.h>
#include <math.h>
int main(){
    int numero1, numero2;
    
    printf("Digite o Numero 1: ");
    scanf("%i",&numero1);
    printf("Digite o Numero 2: ");
    scanf("%i",&numero2);
    if(numero1 < numero2){
    printf("\nNumero menor, num 1 = %i",numero1);           
    }else{
    printf("\nNumero menor, num 2 = %i",numero2);      
    }
    
    getch();
    return 0;
    }
