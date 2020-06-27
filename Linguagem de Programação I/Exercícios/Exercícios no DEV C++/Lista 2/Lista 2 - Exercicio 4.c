#include <stdio.h>
#include <stdlib.h>
int main(){
    int quantidade,codigo;;
    float valor;
    printf("Digite o codigo do item pedido: ");
    scanf("%i",&codigo);
    printf("\nForam quantas unidades? ");
    scanf("%i",&quantidade);
    
    switch(codigo){
             case 100:valor=quantidade*2.00;                     /*neste caso o valor da variável do switch é colocada sem aspas,pois */ 
             printf("\nO valor total do cachorro quente foi:%.2f",valor);/*é um VALOR NUMÉRICO,e não um caractere */
             break;
             case 101:valor=quantidade*2.50;
             printf("\nO valor total do bauru simples foi:%.2f",valor);
             break;
             case 102:valor=quantidade*3.00;
             printf("\nOvalor total do bauru com ovo foi:%2.f",valor);
             break;
             case 103:valor=quantidade*2.70;
             printf("\nO valor total do hamburger foi:%.2f",valor);
             break;
             case 104:valor=quantidade*3.00;
             printf("\nO valor total do cheeseburger foi:%.2f",valor);
             break;
             case 105:valor=quantidade*2.50;
             printf("\nO valor total do refrigerante foi:%.2f",valor);
             break;
             default : printf("\n O codigo informado está incorreto!"); 
                   
    }     
    getch ();
    
    return 0;



}
 
