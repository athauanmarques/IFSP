/*

    Programador : Athauan Marques - 136246-1
    Data: 05/09/2013

                               Exercicio - parte 1    
                               
    Faca um programa que receba 3 valores,
    E informe se esses valores formam os lados de um triangulo.
    
    Para forma os lados de um triangilo cada valor deve ser menor do que a soma,
    outros dois.
                               Exercicio - parte 2

    Verficar qual � o tipo de triangulo:
             
             Equil�tero: Dever ter os 3 lados iguais
             Isoceles:  Dever ter os 2 lados iguais
             Escaleno:  Dever ter os 3 lados diferente                            

*/
#include <stdio.h>

int main (){
    float valores1,valores2, valores3, resultado; 
    
    printf ("informe primeiro valor: ");   
    scanf ("%f", &valores1);
    
    printf ("informe primeiro valor: ");   
    scanf ("%f", &valores2);
    
    printf ("informe primeiro valor: ");   
    scanf ("%f", &valores3);    
  
   
   if (valores1<valores2+valores3 && valores2<valores1+valores3 && valores3<valores1+valores2); 
       printf ("e triangulo");
              if (valores1==valores2 && valores3==valores2 && valores1==valores3){
              printf ("equil�tero");
              }
                     if (valores1==valores2=!valores3 && valores2==valores3=!valores1 && valores3==valores1=!valores2){
                     printf ("isoceles");
                     }
                            if (valores1=!valores2 && valores3=!valores2 && valores1=!valores3){
                            printf ("escaleno");
                            }
     }else{  
     printf ("nao e triangulo");   
     }
     
     /*OBS:  n�o coloque "()" a cada condicao exemplo : 
           
           if (valores1<valores2+valores3) && (valores2<valores1+valores3)....
           � uma maneira completamente ERRADO. fique ligeiro com isso rapaz.*/
             
         getch ();
         return 0;        
}

