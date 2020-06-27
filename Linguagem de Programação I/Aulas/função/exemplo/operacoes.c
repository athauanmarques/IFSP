#include "operacoes.h"

int soma(int a, int b){
    return a+b;    
}

int subtracao(int a, int b){
    return a-b;
}

int multiplicacao(int a, int b){
    return a*b;
}

float divisao(int a, int b){
    return a/b;    
}

void menu(){
    printf("\n* => Multiplicar");  
    printf("\n/ => Dividir"); 
    printf("\n+ => Somar");    
    printf("\n- => Subtrair");     
}
