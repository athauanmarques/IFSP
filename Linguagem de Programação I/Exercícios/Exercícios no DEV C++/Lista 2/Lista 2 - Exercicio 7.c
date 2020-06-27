#include<math.h>
#include<stdio.h>
#include<stdlib.h>
int main(){
    int i;
    float a,b,c,maior,meio,menor;
    
    printf("\nDigite o numero 'i': ");
    scanf("%i",&i);
    printf("\nDigite o numero 'a': ");
    scanf("%f",&a);
    printf("\nDigite o numero 'b': ");
    scanf("%f",&b);
    printf("\nDigite o numero 'c': ");
    scanf("%f",&c);
    
    
    if(a<b&&a<c){
    menor=a;
    }
    if((a<b&&a>c)||(a>b&&a<c)){
    meio=a;
    }
    if(a>b&&a>c){
    maior=a;
    }
    
    if(b<a&&b<c){
    menor=b;
    }
    if((b<a&&b>c)||(b>a&&b<c)){
    meio=b;
    }
    if(b>a&&b>c){
    maior=b;
    }
    
    if(c<a&&c<b){
    menor=c;
    }
    if((c<a&&c>b)||(c>a&&c<b)){
    meio=c;
    }
    if(c>a&&c>b){
    maior=c;
    }
    switch(i){
              case 1: printf("\n\nOs tres valores em ORDEM CRESCENTE:\n\t%.2f\n\t%.2f\n\t%.2f\n",menor,meio,maior);
              break;    
              case 2: printf("\n\nOs tres valores em ORDEM DECRESCENTE:\n\t%.2f\n\t%.2f\n\t%.2f\n\t",maior,meio,menor);
              break;
              case 3: printf("\n\nOs tres valores em ORDEM 'MAIOR NO MEIO':\n\t%.2f\n\t%.2f\n\t%.2f\n\t",menor,maior,meio); 
              break;
    }    
    getch();
    
    return 0;

}
