/*

As cores devem ser definidas pelos seu números em Hexadecimal (ex. Verde claro = A)
Outros comandos disponíveis para trabalhar com cores estão em uma biblioteca chamada conio.c,
nela temos os comandos textbackground(corfundo); e textcolor(cortexto)
A vantagem destes comandos em relação ao system(“color”) 
é que com eles podemos mudar a cor do texto e de fundo várias vezes durante o mesmo programa.
Aceitam as mesmas variações de cores, 
e elas podem ser definidas por números de 0 a 15 ou pelo nome da cor.
Exemplo:
*/

#include <stdlib.h> 
#include <stdio.h> 
#include <conio.c>

int main() { 

textbackground(3); //define a cor de fundo como verde água

textcolor(1);
printf("Meu texto na cor azul ");
textcolor(4);

printf("Meu texto na cor vermelho ");
system("pause");

getch ();
return(0);
}




