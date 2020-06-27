#include<stdio.h>
int main(){
   FILE *entrada;
   FILE *saida;
   
   short int ch;
   
   if((entrada=fopen("resultado.txt","r"))==NULL){
       printf("Erro de abertura do arquivo resultado.txt");
       getch();
       exit(1);
   }
   
   
   if((saida=fopen("entrada2.txt","w"))==NULL){
       printf("Erro na criacao do arquivo entrada2.txt");
       getch();
       exit(1);
   }
   
   while( (ch=fgetc(entrada)) != EOF){
        fputc(ch-1,saida);
   }
   
   fclose(entrada);
   fclose(saida);
   
   
   getch();
   return 0;
}
