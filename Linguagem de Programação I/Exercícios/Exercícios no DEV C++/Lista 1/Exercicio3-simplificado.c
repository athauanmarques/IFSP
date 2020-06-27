#include <stdio.h>
#include <stdlib.h>
int main(){
    
    float custoFabrica, imposto=1.45, distribuidor=1.28, custoConsumidor; //Declaração de Variáveis(float pois há números que não são inteiros)
    
    printf("Digite o custo de Fabrica do Carro: ");
    scanf("%f", &custoFabrica);
    
    custoConsumidor=custoFabrica*imposto*distribuidor;
    
    printf("\nO Valor total do Carro: %.2f", custoConsumidor);
    
    getch();
    
    return 0;
 
    
}
