int main(){
    char caractere;
    
    printf("Digite um caractere: ");
    caractere=getche();
    //Verifica se o caractere ? a letra a min?scula
    //if(caractere=='a')
    
    //Verifica se o caractere ? uma vogal min?scula
    //if(caractere=='a'||caractere=='e'||caractere=='i'||caractere=='o'||caractere=='u')
    
    //Verifica se o caractere ? uma letra qualquer 
    //if(caractere>='a'&&caractere<='z'||caractere>='A'&&caractere<='Z')
    
    switch(caractere){
        case 'a': case'e': case 'i': case 'o': case 'u': printf("\nVOGAL");
                  break;
        case '0': case '1': case '2': case '3': case '4': case '5': case '6': printf("\nDIGITO");
        case '7': case '8': case '9':      printf("\nDIGITO");
                  break;
        default: printf("\nOutro caractere!");
    }
    
    getch();
}
