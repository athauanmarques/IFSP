/*             

Programador : Athauan Marques - 136246-1
Data: 29/08/2013

                               Exercicio
      
      Para converte a temperatura de graus Celsius para Fahvrenheut
      Usa-se a express�o:
     
                                    
                               F =  9 C * 32
                                    5
                                    
       Fa�a um programa que efetue essa convers�o,
       a parti de uma temperatura dada pelo usu�rio        */
       
#include<stdio.h>
#include<math.h>
int main (){

       float celsius, fahrenheit;
       
       printf ("Digite o grau de Celsius: ");
       scanf ("%f", &celsius);
       
       fahrenheit = 9.0/5*celsius+32; // ou : fa�a isso sempre nesta caso de de fra��o;
       
       printf ("o resultado foi: %0.2f", fahrenheit); 
       
       /* obs: quando for declara a quantidade de numeros pos da virgula, exemplo:
        printf ("o resultado foi: %0.3f", resultado); 
       o numero "3" e a quantidade de numeros apos da virgula do resultado,
        Este numero pode ser mudado de acordo com o programador. */
       
       getch ();
       
       return 0;
       
       } 
