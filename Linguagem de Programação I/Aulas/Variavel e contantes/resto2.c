int main (){
	
	// Faça um programa que receba um numero de 1 a 99
	//apresente a soma da dezena com a unidade.
	
	int numero,
		unidade,
		dezena,
		soma;
	
	printf ("informe um numero: ");
	scanf ("%i" ,&numero);
	
	dezena = numero/10;
	unidade = numero%10;
	soma = dezena+unidade;
	
	printf ("o resultado foi: %i", soma);
	
	getch ();
	return 0;
	
}
