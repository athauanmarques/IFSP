#include <stdio.h>
#include <stdlib.h>
int main(){
    
    float custoFabrica, imposto=1.45, distribuidor=1.28, custoConsumidor; //Declara��o de Vari�veis(float pois h� n�meros que n�o s�o inteiros)
    
    printf("Digite o custo de Fabrica do Carro: ");
    scanf("%f", &custoFabrica);
    
    custoConsumidor=custoFabrica*imposto*distribuidor;
    
    printf("\nO Valor total do Carro: %.2f", custoConsumidor);
    
    getch();
    
    return 0;
 
    
}
