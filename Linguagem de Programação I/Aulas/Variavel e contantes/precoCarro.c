/*             

Programador : Athauan Marques - 136246-1
Data: 29/08/2013

                               Exercicio 
      
      o custo ao consumidor de um carro novo � a soma de pre�o de f�brica,
      com o percentual de lucro do distribuidor,
       e dos impostos aplicados ao pre�o de f�brica.
      fa�a um programa que receba o pre�o de f�brica de um veiculo,
      o percetual dos impostos, 
      o percentual de lucro do distribuidor, calcule e mostre:
                   
                   a) o valor correspondente ao lucro do distribuidor,
                   b) o valor correspontente aos impostos.
                   c)o pre�o final do viculo.
                                */
                                
#include <stdio.h>
#include <math.h>
int main (){
    
    float custoConsumidor, resultado, percetualLucro,
          percentualDistribuirdor,
          percetualImpostos,
          precoFabrica;
          
    printf ("informe preco Fabrica");
    scanf ("%f" ,&precoFabrica);
    
     printf ("informe percetual Impostos");
    scanf ("%f" ,&percetualImpostos);
    
    printf ("informe percentual Distribuirdor");
    scanf ("%f" ,&percentualDistribuirdor);
    
    custoConsumidor = precoFabrica*percetualImpostos/100;
    
    percetualLucro = precoFabrica*percentualDistribuirdor/100;
    
    resultado = custoConsumidor+percetualLucro+;
    
    printf ("O pre�o final do veiculo e de: %f", resultado);
    
    getch ();
    
    return 0;
    
}
    
