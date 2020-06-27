
//Podemos usar ao invés de um número fixo para a cor, uma variável do tipo inteira.

#include <stdlib.h> 
#include <stdio.h> 
#include <conio.c>

int cor=0;

int main(){
	
	textbackground(3); //define a cor de fundo como verde água 
	textcolor(cor);
	printf("Meu texto");
	cor++; 
	textcolor(cor);
	printf("Meu texto 2 ");
	system("pause");
	return(0);

} 
