#include<stdio.h>
int main(){
   FILE *entrada;
   FILE *saida;
   short int ch;
   
   entrada=fopen("teste.txt","r");
   saida=fopen("resultado.txt","w");
   
   while( (ch=fgetc(entrada)) != EOF){
        fputc(ch+1,saida);   
   }
   
   fclose(entrada);
   fclose(saida);
   
   
   getch();
   return 0;
}
