/*             

Programador : Athauan Marques - 136246-1
Data: 29/08/2013

                               Exercicio 
      
      o custo ao consumidor de um carro novo é a soma de preço de fábrica,
      com o percentual de lucro do distribuidor,
       e dos impostos aplicados ao preço de fábrica.
      faça um programa que receba o preço de fábrica de um veiculo,
      o percetual dos impostos, 
      o percentual de lucro do distribuidor, calcule e mostre:
                   
                   a) o valor correspondente ao lucro do distribuidor,
                   b) o valor correspontente aos impostos.
                   c)o preço final do viculo.
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
    
    printf ("O preço final do veiculo e de: %f", resultado);
    
    getch ();
    
    return 0;
    
}
    
