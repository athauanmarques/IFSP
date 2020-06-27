#include <stdio.h>
int soma (int a, int b){
	return a+b;
}
int sub (int a, int b){
	return a-b;
}
int div (int a, int b){
	return a/b;
}
int mult (int a, int b){
	return a*b;
}
int main (){
	int a, b, result;
	int op;
	
	printf ("Informe valores de A e B: ");
	printf ("\n\nA= ");
	scanf ("%i", &a);
	
	printf ("\nB= ");
	scanf ("%i", &b);
	
	printf ("\ninforme que tipo de operacao: ");
	printf ("\n\nSoma digite = 1");
	printf ("\nsubtracao digite = 2");
	printf ("\nDivicao digite = 3");
	printf ("\nmultiplicacao digite = 4");
	printf("\n");	
	scanf ("%i", &op);

	switch (op){
	
		
	case 1:    
	    result=soma(a, b);
	    printf ("\n\nA soma e: %i", result);
		break;
	
	case 2:    
	    result=sub(a, b);
	    printf ("\n\nA subtracacao e: %i", result);
		break;
		
	case 3:    
	    result=div(a, b);
	    printf ("\n\nA divisao e: %i", result);
		break;
		
	case 4:    
	    result=mult(a, b);
	    printf ("\n\nA multiplicacao e: %i", result);
		break;
	
	default:
		printf ("\n\n\ERRO MANO!");
		break;
}
	getch ();
	return 0;

}
