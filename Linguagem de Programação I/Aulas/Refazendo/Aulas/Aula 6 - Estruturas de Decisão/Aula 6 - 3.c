/*


escreval ("Exercício 3")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Desenvolva um diagrama que:")
escreval
escreval ("Leia 4 (quatro) números;")
escreval ("Calcule o quadrado de cada um;")
escreval ("Se o valor resultante do quadrado do terceiro for >= 1000, ")
escreval ("imprima-o e finalize.")
escreval ("Caso contrário, imprima os valores lidos e seus respectivos ")
escreval ("quadrados.")
escreval
escreval("------------------------------------------------")
escreval


*/

#include <stdio.h>
int main (){
	int n4, n3, n2, n1,
	    r4, r3, r2, r1;
	
	printf ("informe 4 numero:\n ");
	scanf ("%i %i %i %i", &n1, &n2, &n3, &n4);
	
	r4=n4*n4; 
	r3=n3*n3;
	r2=n2*n2; 
	r1=n1*n1;
	
	if(r3>=1000){
		printf ("o resultado foi: %i", r3);
		}else{
			printf ("r1: %i r2: %i r3: %i r4: %i", r1, r2, r3, r4);
	}
	
	getch ();
	return 0;

	
}

