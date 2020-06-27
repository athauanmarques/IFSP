/*             

Programador : Athauan Marques - 136246-1
Data: 29/08/2013

                               Exercicio
      
      Para converte a temperatura de graus Celsius para Fahvrenheut
      Usa-se a expressão:
     
                                    
                               F =  9 C * 32
                                    5
                                    
       Faça um programa que efetue essa conversão,
       a parti de uma temperatura dada pelo usuário        */
       
#include<stdio.h>
#include<math.h>
int main (){

       float celsius, fahrenheit;
       
       printf ("Digite o grau de Celsius: ");
       scanf ("%f", &celsius);
       
       fahrenheit = 9.0/5*celsius+32; // ou : faça isso sempre nesta caso de de fração;
       
       printf ("o resultado foi: %0.2f", fahrenheit); 
       
       /* obs: quando for declara a quantidade de numeros pos da virgula, exemplo:
        printf ("o resultado foi: %0.3f", resultado); 
       o numero "3" e a quantidade de numeros apos da virgula do resultado,
        Este numero pode ser mudado de acordo com o programador. */
       
       getch ();
       
       return 0;
       
       } 
