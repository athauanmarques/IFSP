/*
Faça um programa que lê um caractere e informe se é uma letra ou
um dígito
*/
int main(){
    char caractere;
    
    printf("Digite um caractere: ");
    caractere=getche();
    
    if(caractere >= 'a' && caractere <='z' || 
       caractere>='A' && caractere<='Z'){
         printf("\nLetra!");
    }else{
        if(caractere>='0'&& caractere<='9'){
            printf("\nDigito!");
        }else{
            printf("\nCaractere nao identificado!");
        }
    }

    getch();
    return 0;

}
