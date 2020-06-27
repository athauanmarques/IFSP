int main (){
	
	//Faça uma programa que recebe uma idade em anos
	//e mostre a idade em dias
	
	int anos, resultadoIdade;
	
	printf ("informe idade: ");
	scanf ("%i", &anos);

	resultadoIdade = anos * 365;
	
	printf ("A sua idade em dias e: %i", resultadoIdade);
	
	getch ();
	return 0;
	
}
