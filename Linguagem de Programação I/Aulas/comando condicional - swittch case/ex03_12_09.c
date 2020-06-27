int main(){
    int numero1, numero2, opcao;
    
    printf("\n1 - Imprime o maior numero");
    printf("\n2 - Imprime o menor numero");
    printf("\nEscolha uma opcao: ");
    scanf("%i",&opcao);
    printf("\nInforme o primeiro numero: ");
    scanf("%i",&numero1);
    printf("\nInforme o segundo numero: ");
    scanf("%i",&numero2);
    
    switch(opcao){
         case 1:
              if(numero1>numero2){
                  printf("Maior: %i",numero1);
              }else{
                  if(numero2>numero1){
                      printf("Maior: %i",numero2);
                  }else{
                      printf("Numeros iguais");
                  }
              }
              break;
         case 2:
              if(numero1<numero2){
                  printf("Menor: %i",numero1);
              }else{
                  if(numero2<numero1){
                      printf("Menor: %i",numero2);
                  }else{
                      printf("Numeros iguais");
                  }
              }
              break;
              
            default:  
                   printf("Opcao invalida!");  
    
    
    }
    
    getch();
    return 0;
    
    
}
