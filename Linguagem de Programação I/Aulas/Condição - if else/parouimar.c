/*

    Programador : Athauan Marques - 136246-1
    Data: 05/09/2013

                               Exercicio
    
    Faca um programa que receba numero, E diga se e par ou impar.
    

*/


#include <stdio.h>
int main (){
    int numero; 
    
    printf ("informo valor: ");   
    scanf ("%i", &numero);
    
    if (numero%2==0){
      printf ("e par");
      
    }else{
    printf ("impar");                 
    }
             
         getch ();
         return 0;        
}
