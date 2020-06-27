#include <stdio.h>
#include <stdlib.h>
#include <conio.h>
#include <locale.h> //Biblioteca para acentuação em portugues
#include "operacao.h"

//---------------|Menus|-----------------

//desenho do logo
void logo(){ 
	printf (""
"\n"
"\n"
"\n"
"\n	 ____                       __           ______ "				                  
"\n	/\\  _`\\          __        /\\ \\__       /\\__  _\\ "                 
"\n	\\ \\ \\/\\_\\  _ __ /\\_\\  _____\\ \\ ,_\\   ___\\/_/\\ \\/   ___   _____  "  
"\n	 \\ \\ \\/_/_/\\`'__\\/\\ \\/\\ '__`\\ \\ \\/  / __`\\ \\ \\ \\  / __`\\/\\ '__`\\ "								 
"\n	  \\ \\ \\_\\ \\ \\ \\/ \\ \\ \\ \\ \\_\\ \\ \\ \\_/\\ \\_\\ \\ \\ \\ \\/\\ \\_\\ \\ \\ \\_\\ \\ "
"\n	   \\ \\____/\\ \\_\\  \\ \\_\\ \\ ,__/\\ \\__\\ \\____/  \\ \\_\\ \\____/\\ \\ ,__/ "
"\n	    \\/___/  \\/_/   \\/_/\\ \\ \\/  \\/__/\\/___/    \\/_/\\/___/  \\ \\ \\/ "
"\n	                        \\ \\_\\                              \\ \\_\\ " 
"\n	                         \\/_/                               \\/_/ " 
"\n									"
"\n\n");					
}

//Menu principal
void mPrincipal(){
	setlocale(LC_ALL, "Portuguese"); 
	system ("cls");
	system ("color 0f");
	printf ("\n\n  ___________________________________________________________ 		"
	"\n (___________________________________________________________)" );
	
printf ("\n  __________________________        _________________________   "
	"\n (__________________________) MENU (_________________________)"
	" 											"
"\n		   ____"
"\n		  ||1 ||"
"\n		  ||__|| = Criptografar"
"\n		  |/__\\|"

"\n\n   	     		      ____"
"\n		  	     ||2 ||"
"\n		  	     ||__|| = Sobre" 
"\n		  	     |/__\\|"

"\n\n		 			   ____"
"\n				   	  ||3 ||"
"\n				          ||__|| = Sair"
"\n					  |/__\\|"
	"\n\n  ___________________________________________________________ 		"
	"\n (___________________________________________________________)" );
	
}
//Menu segundário mostras as opções dos codigos
void mPrincipal2 (){
	setlocale(LC_ALL, "Portuguese"); 
	system ("color 0e");
	printf ("informe o tipo de codificação: ");
	printf ("\n\n(r) - Rot13");
	printf ("\n(c) - Cesar");
	printf ("\n(f) - Fatias");
	printf ("\n(0) - Menu Principal\n");
	

}
//Sobre (informaçoes do programadores)
void sobre (){
	setlocale(LC_ALL, "Portuguese"); 
	system ("color 0c");
	printf ("\n                                  "
"\n ====================================================="
"\n ==================       CriptoTop    ==============="
"\n =============================== (Versão - 1.0) ======"
"\n ====================================================="
"\n"
"\n           Athauan Marques    -    136246-1            "
"\n	   Viviane Domingues  -	   136284-4			  "
"\n"
"\n"
"\n===============================| 27/11/2013 |========"
"\n"
"\n========== Digite (0) para volta ao Menu ============"
" \n                   ");
}

//---------------| codificações|-----------------


//---------------------Rot13------------------
void codificaRot (menu){
	system ("color 0c");
	FILE *entrada1; // variável entrada de texto
    FILE *saida;	// variável de saida de texto
    short int ch, chave;
    
    entrada1=fopen("entradaRot.txt","r"); //arquivo para ser lido
    saida=fopen("saidaRot.txt","w");		//arquivo para ser escrito
    
    
    
    // critografando palavras
    while ((ch = fgetc (entrada1)) != EOF)
    {
     
         if(ch >= 'A' && ch <= 'Z')
              {       
                   ch = ch +13;
            
                   if(ch > 'Z')
                            ch = ch - 26;
              }      
          
         if(ch >= 'a' && ch <= 'z')
              {       
                   ch = ch +13;
            
                   if(ch > 'z')
                            ch = ch - 26;
              }
    
    fputc (ch, saida);
    
    } 
    //finalizando a criptografia
    fclose(entrada1);
    fclose(saida); 
    system ("cls");
    printf ("\nMensagem foi codificada com sucesso...\n\n");
    system ("pause");
}
//decofificação Rot13
void decodificaRot (menu){
	system ("color 0d");
	FILE *entrada1;
    FILE *saida;
    short int ch, chave;
    
    entrada1=fopen("entradaRot.txt","r");
    saida=fopen("saidaRot.txt","w");
    
    
    // critografando palavras
    while ((ch = fgetc (entrada1)) != EOF)
    {
     
         if(ch <= 'A' && ch >= 'Z')
              {       
                   ch = ch -13;
            
                   if(ch < 'Z')
                            ch = ch + 26;
              }      
          
         if(ch <= 'a' && ch >= 'z')
              {       
                   ch = ch -13;
            
                   if(ch < 'z')
                            ch = ch + 26;
              }
    
    fputc (ch, saida);
    
    } 
    //finalizando
    fclose(entrada1);
    fclose(saida); 
    system ("cls");
    printf ("\nMensagem foi decodificada com sucesso...\n\n");
    system ("pause");

}


//--------------------------------Cesar----------------------------------
void codificaCesar(menu){
    system ("color f0");
	char frase[1000]; //quantidade palavras 
	char des[1000]; //quantidade para descodificar
	char op; //auxiliar de condição de escolha do usuário
    int chave, tamanho_frase, cont, i; //variavel inteiros para serem trabalhados
 
    system("cls");
 	printf ("=== Criptografia Cesar ===\n");
    printf("\nDigite a frase a ser criptografada : ");
    gets(frase);
    //criptografando
    for (i=0; i<25; i++){ 
    	des[i]=frase[i];
    }
    //chaves do codigo
    while(chave<1 || chave>25)
    {
        printf("Informe o numero da chave a ser utilizada (1 a 25) : ");
        scanf("%d",&chave);
        fflush(stdin);
    }
 
    tamanho_frase = strlen(frase);
    for(cont=0;cont<tamanho_frase;cont++)
        frase[cont] = frase[cont]+chave;
 
    printf("\n\nFrase Criptografada : %s",frase);
    getchar();
    
    printf ("\n Descodifica a frase digite (2), volta ao menu principal digite(1): ");
    op=getche();
   //condição de erros
    while (op != '1' && op != '2'){
    	system ("cls");
    	printf ("\n\nErro ! Descodifica digite (2), volta ao menu digite(1):"); 	
    	op=getche();
	}
  //condição do op  
	if (op=='1'){
		menu='1';
		return menu;
   }
   if (op=='2'){
    printf("\n\nFrase descriptografada : %s", des);
    getchar();
    system ("pause");
   
   }


}
//--------------------------------- Fatias -------------------------

void codificarFatias(menu){
	system("color 1f"); 
	FILE * saida; //variavel de saida do arquivo
    FILE * arquivo; //variavel de saida do arquivo
    
    short int   ch;
    int   quantChar=0;    
    char * string;
    //char quantErro;
    int  comprimento, j, i, k, quantFatias;
    
   
   		arquivo = fopen("lerFatias.txt","r"); 
   		saida= fopen("saidaFatias.txt","w");
    	printf ("=== Criptografia Fatias ===\n");
        printf("\n\nInforme a quantidade de fatias: ");
        scanf("%i", &quantFatias);
                      
     
    while((ch = fgetc(arquivo))!= EOF)
    {
              quantChar++;
    }
    
    for(i=quantFatias, comprimento=1; i <quantChar; i=i+quantFatias)
    {
             comprimento++;
    }
    
    
        
    string = (char *) malloc((i+1) * sizeof(char));
    
    for(j=0; j<=i; j++)
    {
          string[j] = ' ';   

    }    
    
    rewind(arquivo);
    
    j=0;
    
    while((ch = fgetc(arquivo))!= EOF)
    {          
          string[j] = ch;  
                    
             j++;           
    }
    
    saida= fopen("saidaFatias.txt","w");
                          
    for(k=0; k<quantFatias; k++)
    {
             for(j=k; j<i; j=j+quantFatias)
             {
                 fputc(string[j], saida);     
    
             }
    }        
    
    fclose(saida);
    printf ("\n\n\n\n\n\n\n\n\n\n\n\n\n_________________________________________________________________________");
    printf("\n\nCaso esteja criptografando, utilize codigo (%i) para descriptografar\n\n", comprimento);
    system ("pause");
    printf ("\n\n_________________________________________________________________________\n");
    
        
}
