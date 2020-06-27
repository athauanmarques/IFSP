int main(){
    char caractere;
    
    printf("Digite um caractere: ");
    caractere=getche();
    
    switch(caractere){
        case 'a': case 'e': case 'i': case 'o': case 'u':
             printf("Vogal minuscula!");
             break;
        case '0': case '1': case '2': case '3': case '4':
        case '5': case '6': case '7': case '8': case '9':
             printf("Digito!");
             break;
        default:
             printf("Caractere nao identificado!");                      
    
    }    

    getch();
    return 0;

}
