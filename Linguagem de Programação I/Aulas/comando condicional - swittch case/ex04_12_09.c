int main(){
    int numero1, numero2, opcao, menor, maior;
    int iguais=0;
    
    printf("\n1 - Imprime o maior numero");
    printf("\n2 - Imprime o menor numero");
    printf("\nEscolha uma opcao: ");
    scanf("%i",&opcao);
    printf("\nInforme o primeiro numero: ");
    scanf("%i",&numero1);
    printf("\nInforme o segundo numero: ");
    scanf("%i",&numero2);
    
    
    if(numero1>numero2){
        maior=numero1;
        menor=numero2;                    
    }else{
        if(numero2>numero1){
            maior=numero2;
            menor=numero1;
        }else{
            iguais=1;
        }
    }
    
    switch(opcao){
         case 1:
              
              if(!iguais){
                  printf("Maior: %i", maior);
              }else{
                  printf("Numeros iguais");
              }
              
              break;
         case 2:
              
              if(!iguais){
                  printf("Menor: %i", menor);
              }else{
                  printf("Numeros iguais");
              }
              
              break;
              
            default:  
                   printf("Opcao invalida!");  
    
    
    }
    
    getch();
    return 0;
    
    
}
