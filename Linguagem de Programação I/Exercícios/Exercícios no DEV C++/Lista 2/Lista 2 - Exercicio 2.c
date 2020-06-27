#include <math.h>
#include <stdio.h>

int main(){
    int n1,n2,n3;
    
    printf("Digite o numero 1: ");
    scanf("%i",&n1);
    printf("Digite o numero 2: ");
    scanf("%i",&n2);
    printf("Digite o numero 3: ");
    scanf("%i",&n3);
    
    if(n1>n2&&n1>n3){
    printf("\nO maior numero N1 = %i",n1);
     }else{
     if(n2>n1&&n2>n3){
     printf("\nO maior numero N2 = %i",n2);
     }else{
     printf("\nO maior numero N3 = %i",n3);
       } 
     }    
    
    getch();
    return 0;
    
}      
