/*

CORES

Podemos alterar as cores de fundo e de texto de nossas janelas de programas em C, 
existem mais de um comando para esta fun��o.
Um comando que pode ser usado para trocar a cor de fundo e de texto de um programa em C 
� o:

Veja a tabela a abaixo:
	
	----------Cores dispon�veis------------ 
	0 = Preto 			8 = Cinza 
	1 = Azul 			9 = Azul claro 
	2 = Verde 			10 = Verde claro 
	3 = Verde-�gua 		11 = Verde-�gua claro 
	4 = Vermelho 		12 = Vermelho claro 
	5 = Roxo 			13 = Lil�s 
	6 = Amarelo 		14 = Amarelo claro 
	7 = Branco 			15 = Branco brilhante


system(�color corfundocortexto);

Esse comando altera para todo um programa em C, a cor de fundo da janela e do texto mostrado, essa altera��o vale para toda a execu��o do comando.
Para us�-lo devemos ter inclu�do a biblioteca stdlib.h.
Exemplo:

*/

#include <stdlib.h> 
#include <stdio.h>
int main(){

  
system("color 60"); //coloca a cor de fundo como preto e de texto em azul

//system ("color f0") //fundo brando, letra preta
// 1� posi��o do caracter ou do numero (no caso f) define O fundo
// 2� posi��o do caracter ou do numero (no caso ZERO) define a letra
//OBS: n�o � necessidade  de chamar alguma biblioteca para manipular cores
//em alguns casos pode ocorrer a Necessidade de incluir #include <stdlib.h> 

printf("Meu texto na cor azul");
system("pause");



return(0);

}

