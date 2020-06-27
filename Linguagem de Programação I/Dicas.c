












/*

====================== Dica, sigficados, e outros =======================


*/














#define bufsize 1024;  //defini um variavel que sempre vai o mesmo valor neste caso é 1024
#include <math.h>  // necessária para pow() e sqrt()
#include <stdio.h> // necessária para printf() e getchar()
 #include <stdlib.h>
 #include <conio.h>

 int main() {
 	//-------------------------- variavel -----------------------------
 	//signficados...
 	
	  int variavel, variavel1; 	
	  /* varialvel tipo 'int',é um tipo que só trabalha com numeros inteiros exemplo: 1,2,10,15,1951,321616,-1,-2,-365...
	     Armazena 32 bits, ou qualquer inteiro entre -2.147.483.648 e 2.147.483.647*/
 	  float carteira; 
	   /*O tipo 'float', que armazena números decimais (quebrados, ou com vírgula) também armazenam 32 bits. 
	   Exemplo: 1,2554 1.05, etc...*/
	   
	//Modelos de organizar
	
	int variavel, variavel1, oi, tudoBem, issomlk;
	
	//Modelo 2	
		int variavel, 
		    variavel1, 
		    oi, 
		    tudoBem,
		    issomlk;
		    
	//Modelo 3
		int variavel, x, b,
		    variavel1, n2, cazinhaBaby, isso,
		    oi, variavel, variavel1, oi, tudoBem, issomlk
		    tudoBem,variavel, variavel1, oi, tudoBem, issomlk
		    issomlk;
		
//----------------------------exemplo ---------------
 printf("Informe quantos anos voce fuma: "); //Infome a quanto tempo fuma.
 scanf("%d", &anos);
 //Guarda informação na variavel anos.
 printf("\nInforme quantos cigarros fuma por dia: ");
 //Infome a quanto cigarros fuma por dia.
 scanf("%d", &cigarros);
 //Guarda informação de quanto cigarros é fumado por dia na variavel cigarros.
 printf("\nInforme o valor da carteira com 20 cigarros : R$ ");
 //Infome a ovalor da carteira de cigarros que contem vin\zaqte unidades.
 scanf("%f", &carteira);
 //Guarda informação na variavel valor da carteira.

 x = anos * 365; //Variavel x recebe anos vezes 365 que representa dias.
 y = (x * cigarros); //Variavel y recebe resultado da variavel x multiplicado por cigarros.
 valorgasto = (y / 20) * carteira; //Variavel valorgasto recebe a divisão do resultado y dividido por vinte unidade de cigarros que é multiplicado pela variavel carteira.

 //printf("\nO valor gasto em cigarros periudo de anos e de : R$ %.3f\n\n",valorgasto);
 printf("\Voce fumou um periudo de: %i",anos);
 printf(" anos e gastou valor de: R$ %.3f\n\n",valorgasto);

 //Infoma na tela o resultado dos calculos de quanto se gastou fumando a quantia de cigarros digitada pelo operadora.

 getch(); //Comando de pausar .
 return 0; //Comando serve para que o programa diga a quem o chamou que ele retornou sem erro o zero significa false e o 1 significa true
 }
