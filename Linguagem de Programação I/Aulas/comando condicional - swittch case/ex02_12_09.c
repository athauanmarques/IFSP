/*
Fa�a um programa que l� um caractere e informe se � uma letra ou
um d�gito
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
