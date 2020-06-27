/*

As cores devem ser definidas pelos seu n�meros em Hexadecimal (ex. Verde claro = A)
Outros comandos dispon�veis para trabalhar com cores est�o em uma biblioteca chamada conio.c,
nela temos os comandos textbackground(corfundo); e textcolor(cortexto)
A vantagem destes comandos em rela��o ao system(�color�) 
� que com eles podemos mudar a cor do texto e de fundo v�rias vezes durante o mesmo programa.
Aceitam as mesmas varia��es de cores, 
e elas podem ser definidas por n�meros de 0 a 15 ou pelo nome da cor.
Exemplo:
*/

#include <stdlib.h> 
#include <stdio.h> 
#include <conio.c>

int main() { 

textbackground(3); //define a cor de fundo como verde �gua

textcolor(1);
printf("Meu texto na cor azul ");
textcolor(4);

printf("Meu texto na cor vermelho ");
system("pause");

getch ();
return(0);
}




