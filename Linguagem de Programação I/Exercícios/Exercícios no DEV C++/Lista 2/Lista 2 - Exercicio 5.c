#include <math.h>
#include <stdlib.h>
#include <stdio.h>
int main(){
    float saldoMedio,credito;
    
    printf("Informe o valor do saldo m�dio no �ltimo ano: ");
    scanf("%f",&saldoMedio);
    
    if(saldoMedio<=200){
    credito=0;
    }
    if(saldoMedio>=201&&saldoMedio<=400){
    credito=saldoMedio*0.2;
    }
    if(saldoMedio>=401&&saldoMedio<=600){
    credito=saldoMedio*0.3;
    }
    if(saldoMedio>=601){
    credito=saldoMedio*0.4;
    }
    
    printf("\nO seu saldo m�dio do �ltimo ano foi: %.2f",saldoMedio);
    printf("\nO valor do seu cr�dito foi de: %.2f",credito);
    printf("\n\nProva real\nA porcentagem = %.2f",credito/saldoMedio);//desnecess�rio,nesse caso foi para verificar uma fun��o
    
    getch();
    return 0;

}
