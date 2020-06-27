#include <stdio.h>
int main(){
	/*Faça um programa que receba duas notas,
	E apresenta a média dada por:	
	media (nota1+nota2)/2 */
	
	float n1,
		  n2,
		  media;
		  
	printf ("informe o valor nota 1: ");
	scanf ("%f", &n1);
	
	printf ("informe o valor nota 2: ");
	scanf ("%f", &n2);
	
	media = (n1+n2)/2;
	
	printf ("o valor da media: %f", media);
	
	getch ();
	return 0;
	
}
