/*

fa�a um programa que l� um caracter e diga se e uma letra ou um digito.


*/
#include <stdio.h>
int main(){
    char caracter;
    
    printf ("informe uma letra");
    scanf ("%i", &caracter);

    if (caracter >= 'a' && caracter <= 'z' || caracter >= 'A' && caracter <= 'a'){
        printf ("letra");
    }else{
          if (caracter >= '0' && caracter <= '9'){ 
              printf ("digito");
          }else{
               printf(" caracter n�o indentificado");
         }
    } 
    getche();
    
    return 0;
           }   
