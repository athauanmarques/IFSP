
//Podemos usar ao inv�s de um n�mero fixo para a cor, uma vari�vel do tipo inteira.

#include <stdlib.h> 
#include <stdio.h> 
#include <conio.c>

int cor=0;

int main(){
	
	textbackground(3); //define a cor de fundo como verde �gua 
	textcolor(cor);
	printf("Meu texto");
	cor++; 
	textcolor(cor);
	printf("Meu texto 2 ");
	system("pause");
	return(0);

} 
