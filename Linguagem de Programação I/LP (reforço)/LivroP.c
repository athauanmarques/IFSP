int main(){
	float prestacao, valor, taxa, tempo;
	
	printf ("digite a prestacao: ");
	scanf ("f%", &prestacao);
	
	printf ("digite a valor: ");
	scanf ("f%", &valor);
	
	printf ("digite a taxa: ");
	scanf ("f%", &taxa);
	
	printf ("digite atraso  valor: ");
	scanf ("f%", &tempo);
	
	prestacao=valor+(valor*(taxa/100)*tempo);
	
	getch();
	return 0;
	
	
	
	
}

