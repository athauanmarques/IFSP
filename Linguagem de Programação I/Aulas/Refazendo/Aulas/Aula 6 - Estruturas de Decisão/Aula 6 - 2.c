/*

escreval ("Exercício 2")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Elabore um diagrama de bloco que leia as variáveis C e N,")
escreval ("respectivamente código e número de horas trabalhadas de um ")
escreval ("operário. E calcule o salário sabendo-se que ele ganha R$ ")
escreval ("10,00 por hora. Quando o número de horas exceder a 50 calcule ")
escreval ("o excesso de pagamento armazenando-o na variável E, caso ")
escreval ("contrário zerar tal variável. A hora excedente de trabalho vale ")
escreval ("R$ 20,00. No final do processamento imprimir o salário total e o ")
escreval ("salário excedente.")
escreval
escreval("------------------------------------------------")
escreval

*/
#include <stdio.h>
int main(){
	float nHoras, salario, execeder, exValor, salTotal, exhoras;
	
	
	printf ("informe o horas: \n");
	scanf ("%f", &nHoras);
	
	salario= nHoras*10.00;
	if (nHoras>=50){
	exhoras=nHoras-50;
	exValor=exhoras*20;
	salTotal=salario+exValor;
		
	printf ("o salario total e %0.2f R$\n", salTotal);
	printf ("o valor que execedeu foi %0.2f R$\n", exValor);
	}else{
		printf ("o salario total e %0.2f R$\n", salTotal=salario+exValor);
	    printf ("o valor que execedeu foi %0.2f R$\n", exValor=0);
	}
	
	getch ();
	return 0;
	
	
	
}
