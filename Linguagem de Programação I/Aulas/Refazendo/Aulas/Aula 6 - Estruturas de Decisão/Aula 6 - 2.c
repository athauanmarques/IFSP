/*

escreval ("Exerc�cio 2")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Elabore um diagrama de bloco que leia as vari�veis C e N,")
escreval ("respectivamente c�digo e n�mero de horas trabalhadas de um ")
escreval ("oper�rio. E calcule o sal�rio sabendo-se que ele ganha R$ ")
escreval ("10,00 por hora. Quando o n�mero de horas exceder a 50 calcule ")
escreval ("o excesso de pagamento armazenando-o na vari�vel E, caso ")
escreval ("contr�rio zerar tal vari�vel. A hora excedente de trabalho vale ")
escreval ("R$ 20,00. No final do processamento imprimir o sal�rio total e o ")
escreval ("sal�rio excedente.")
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
