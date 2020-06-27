int main (){
	
	int dezena, unidade, soma, numero;
	
	printf ("informe o numero de 1 a 99: ");
	scanf ("%i" ,&numero);
	
	dezena = numero/10;
	unidade = numero%10;
	soma = dezena+unidade;
	
	printf ("o resultado foi: %i", soma);
	
	getch ();
	return 0;
	
}
