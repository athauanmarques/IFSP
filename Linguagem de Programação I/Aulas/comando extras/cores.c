/*

CORES

Podemos alterar as cores de fundo e de texto de nossas janelas de programas em C, 
existem mais de um comando para esta função.
Um comando que pode ser usado para trocar a cor de fundo e de texto de um programa em C 
é o:

Veja a tabela a abaixo:
	
	----------Cores disponíveis------------ 
	0 = Preto 			8 = Cinza 
	1 = Azul 			9 = Azul claro 
	2 = Verde 			10 = Verde claro 
	3 = Verde-água 		11 = Verde-água claro 
	4 = Vermelho 		12 = Vermelho claro 
	5 = Roxo 			13 = Lilás 
	6 = Amarelo 		14 = Amarelo claro 
	7 = Branco 			15 = Branco brilhante


system(“color corfundocortexto);

Esse comando altera para todo um programa em C, a cor de fundo da janela e do texto mostrado, essa alteração vale para toda a execução do comando.
Para usá-lo devemos ter incluído a biblioteca stdlib.h.
Exemplo:

*/

#include <stdlib.h> 
#include <stdio.h>
int main(){

  
system("color 60"); //coloca a cor de fundo como preto e de texto em azul

//system ("color f0") //fundo brando, letra preta
// 1ª posição do caracter ou do numero (no caso f) define O fundo
// 2ª posição do caracter ou do numero (no caso ZERO) define a letra
//OBS: não á necessidade  de chamar alguma biblioteca para manipular cores
//em alguns casos pode ocorrer a Necessidade de incluir #include <stdlib.h> 

printf("Meu texto na cor azul");
system("pause");



return(0);

}

