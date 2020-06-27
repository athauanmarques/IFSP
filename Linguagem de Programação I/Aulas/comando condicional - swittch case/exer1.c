/*

Programador: Athauan Marques da Cunha
Prontuário: 136246-1 
Data:  10/09/2013
Assunto: Comando Condicional 

Exercicio

Faça um programa que receba o codigo do produto,
e quantidade e mostre o valor final.
Sabendo
     _____________________________________________
     |  codigo|valor unitário    |    descrisão   |
	 |   100  |	   10.00	     | capa de celular|
	 |   201  |	   20.00	     |  fone de ouvido|
	 |   306  |	   10.00	     |    pelicula    |
	 |   407  |	   30.00	     |    suporte     |
	 ______________________________________________
*/
#include <stdio.h>	
int main (){
	int codigo,qtde;
	
	printf ("digite aquantidade: ");
	scanf ("i%", &qtde);
	printf ("digite o codigo: ");
	scanf ("i%", &codigo);
	
	switch(codigo){
		case 100: case 306:
        printf ("o valor final: %i", qtde*10);
		break;   
		
		/* outro tipo:
		case 'l': use aspas no caso de char
        printf ("o valor 10.00");
		break;*/  
		
		case 201:
        printf ("o valor final: %i", qtde*20);
		break;    
		
		case 407:
        printf ("o valor final: %i", qtde*30);
		break;  
		
		default: 
		printf ("operador invalido RAPAZ");
		break;
	}
	getch (); // coloque pois vc ta trabahando com numeros ,tem que despresar os chars
	return 0;	
}	

