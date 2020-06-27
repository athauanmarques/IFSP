/*


   escreval ("Exercício 6")
         escreval
         escreval("------------------------------------------------")
         escreval
         escreval ("Elabore um algoritmo que dada a idade de um ")
         escreval ("nadador classifique-o em uma das seguintes ")
         escreval ("categorias:")
         escreval
         escreval ("Infantil A = 5 a 7 anos")
         escreval ("Infantil B = 8 a 11 anos")
         escreval ("Juvenil A = 12 a 13 anos")
         escreval ("Juvenil B = 14 a 17 anos")
         escreval ("Adultos = Maiores de 18 anos")
         escreval
         escreval("------------------------------------------------")


*/
#include <stdio.h>
int main(){
	int idade;
	
	printf ("informe a idade: ");	
	scanf ("%i", &idade);
	
	switch (idade){
		case 5: case 7: case 6:
				printf ("infantil A");
				break;
		case 8:case 9:case 10:case 11:
				printf ("infantil B");
				break;
		case 12: case 13:
				printf ("juvinil A");
				break;
		case 14: case 15: case 16: case 17:
				printf ("juvinil B");
				break;
		case 4:case 3: case 2: case 1:
				printf ("idade insuficiente");
				break;
		default:
			 printf ("Aduto");
	}
	
	getch();
	return 0;

}

