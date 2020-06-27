/*

escreval ("Exercício 1")
escreval
escreval("------------------------------------------------")
escreval
escreval ("João Papo-de-Pescador, homem de bem, comprou um ")
escreval ("microcomputador para controlar o rendimento diário de seu ")
escreval ("trabalho. Toda vez que ele traz um peso de peixes maior que o ")
escreval ("estabelecido pelo regulamento de pesca do estado de São ")
escreval ("Paulo (50 quilos) deve pagar um multa de R$ 4,00 por quilo ")
escreval ("excedente. João precisa que você faça um diagrama de blocos ")
escreval ("que leia a variável P (peso de peixes) e verifique se há excesso")
escreval ("Se houver, gravar na variável E (Excesso) e na variável M o ")
escreval ("valor da multa que João deverá pagar. Casocontrário mostrar ")
escreval ("tais variáveis com o conteúdo ZERO.")
escreval
escreval("------------------------------------------------")

*/
#include <stdio.h>
int main () {
		float peixe, multa=4.00, excesso, valorMulta;
	
	printf ("inforeme o peso: ");
	scanf ("%f", &peixe);
	
	if (peixe>=50.00){
		printf ("o seu excesso de peso e: %.2f\n", excesso=peixe-50.00);
		printf ("o valor da multa e: %0.2f R$\n", valorMulta=peixe*multa);
	}else{
		
		printf ("o seu excesso de peso e: %.2f\n", excesso);
		printf ("o valor da multa e: %0.2f R$\n", valorMulta);	
	   
    }
	
	getch ();
	return 0;
}
	
	
