/*

Programador: Athauan Marques da Cunha
Prontuário: 136246-1 
Data:  10/10/2013
Assunto: Repetição - FOR 
			
Exercícios

Faça um programa que armazene 10 numeros inteiros em vetor,
e um primos na ordem inversda da leitura


*/
#include <stdio.h>
int main() {
    
    int  vetor[10], i=0;
    
    for (i=0; i<10; i++){
        printf("informe numeros: ");
        scanf ("%i", &vetor[i]);
        //[0,1,2,3,4,5,6,7,8,9]
        //Para i começa com 0 do vetor 
        //até 10
        //i++ vai "anda para frente" somar a ordem) até dez o indicador
        } 
           
        
        for (i=9; i>=0; i--){
        printf("\n numeros: %i", vetor[i]);
        //[9,8,7,6,5,4,3,2,1,0]
        //Para i começa com 9 do vetor 
        //até 0
        //
        //i-- vai "andar para trás" (substrair a ordem) até dez o indicador
        
        }  
        
        
        getch ();
        return 0;
        
    
    
    
    
    }
