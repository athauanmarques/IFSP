#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h> //Biblioteca para acentuação em portugues
#include "operacao.h" // Biblioteca que faz as operações e mostra os menus

int main (){
	setlocale(LC_ALL, "Portuguese"); //sintaxe do locale.h 
	
	char menu, codigoR;
	system ("color 0e"); //sistema de colores
	
	logo(); // logo do Programa
	system ("pause"); // pausa na execução
	
	do{ 
		
		mPrincipal (); //menu principal
		menu=getche(); // ler o valor do menu
		system ("cls"); //limpa tela
		switch (menu){
			
	// Case 0 - menu principal valendo 0 (ira o correr se a opção do menu segundario (case1) for menu=0)				   	
		   case '0':
		        logo (); // demonstração do logo
				mPrincipal (); // mostra as opçoes do menu
				menu=getche();
				system ("cls");   //limpa tela
			
	// Case 1 - menu Segundario		
		   case '1':        
               	 mPrincipal2 ();// mostra as opcões do tipo de codigo 
                 menu=getche ();
           while(menu!='c' && menu!='r' && menu!='f' && menu!='0'){ // verificar erro de digitação
           		printf ("\ncomando invalido!");
           		menu=getche ();
           }         
             if(menu=='c'){ 	//opção "a"=cesar 
				system ("cls");
			    codificaCesar();// a função do cesar
			    menu=getche ();
			    system ("cls");
		              }
			 if (menu=='r'){ // opção "r = rot13"
			 	system ("cls");
			 	setlocale(LC_ALL, "Portuguese");
			 	printf ("\nOpção Rot13"
			 			"\n=== a === - codificar:"
			 			"\n=== b === - decoficar: \n");
			 	printf ("\n\n\n\n\n\n\n\n\n\n\n\n\n_________________________________________________________________________");
				printf ("\n\nOBS: \nPara criptografar corretamente,");
				printf ("digite a mensagem no arquivo ""dados.txt"",");
				printf ("\nQue se encontra dentro da pasta do programa.");
				printf ("\n\n_________________________________________________________________________\n");			 
			 	scanf ("%c", &codigoR);
			 			while (codigoR !='a' && codigoR != 'b'){ // verificar erros do digito
			 				 printf ("\nErro! digite a ou b: ");
			 			 	 codigoR=getche ();
			 					}
			 			if (codigoR=='a'){ // opção de codificação
			 	   		    codificaRot ();
			 	   		    menu=getche ();
						 }
						 if (codigoR=='b'){ // opção descodificação
				 		 	decodificaRot ();
				 			menu=getche ();
						 		}	
						 }//------------------fim rot				
			 if(menu=='f'){ 	//opção "f"=fatias 
				system ("cls");
			    codificarFatias(); //função da fatias
			    menu=getche ();
			    system ("cls");
		              }	
				break;
			 
	
	// Case 2 - opcão do sobre (mostra as pessoas responsaves pelo programa)
           case '2': 
                sobre ();		
                menu=getche ();
                system ("cls");
                while (menu!='0'){ //verificar erros
                	menu=getche ();
                	system ("cls");
                	printf ("\n\nDigitou ""%c"" Opcao invalida, digite 0 para voltar ao menu: ", menu);
                }
               
                break;
	//Case 3 - mensagem de agradecimento e finalização do programa
		   case '3': 	
		   		setlocale(LC_ALL, "Portuguese");
		   		printf ("\n\n");
		   		
				printf ("\n\n\n\n________________________________________________________________________________");
				printf ("\n\n                     Obrigado por utiliza CriptoTop. "
						"\n                  Para maiores informações entre em contado:"
						"\n\n                            amc_ksk@hotmail.com\n"
						"\n                               Volte sempre");
				printf ("\n\n________________________________________________________________________________\n");
				break;
			       
           default: // verificar erros
                printf("\n\nOpcao invalida, pressione enter\n\n");
                getch();
                system("cls");
       
         }
	}while(menu != '1' && menu != '2' && menu != '3' && menu != 'r' && menu != 'c' && menu != 'd');
	
	

        
	getch ();
	return 0;

}

