/*

faça um programa que lê um caracter e informe se é uma vogal minuscula ou um digito.


*/
int main (){
    char caracter;
    
    printf ("informe uma letra");
    caracter = getche(); // exibe o caracter na tela
  //palavra = getch(); // exibe o caracter na tela

    switch (caracter){
           case 'a': case 'e': case 'i': case 'o': case 'u':
                printf ("vogal minuscula");
                break;
           case '1': case '2': case '3': case '4': case '5':
           case '6': case '7': case '8': case '9': case '0':
                printf ("Digito");
                break;
                      }
    getch ();
    return 0;
           
           }   
              
                   
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

