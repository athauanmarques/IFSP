/*

escreval ("Exerc�cio 1")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Jo�o Papo-de-Pescador, homem de bem, comprou um ")
escreval ("microcomputador para controlar o rendimento di�rio de seu ")
escreval ("trabalho. Toda vez que ele traz um peso de peixes maior que o ")
escreval ("estabelecido pelo regulamento de pesca do estado de S�o ")
escreval ("Paulo (50 quilos) deve pagar um multa de R$ 4,00 por quilo ")
escreval ("excedente. Jo�o precisa que voc� fa�a um diagrama de blocos ")
escreval ("que leia a vari�vel P (peso de peixes) e verifique se h� excesso")
escreval ("Se houver, gravar na vari�vel E (Excesso) e na vari�vel M o ")
escreval ("valor da multa que Jo�o dever� pagar. Casocontr�rio mostrar ")
escreval ("tais vari�veis com o conte�do ZERO.")
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
	
	
