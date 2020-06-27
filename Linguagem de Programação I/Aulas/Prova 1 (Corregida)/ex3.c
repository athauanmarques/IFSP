int main(){
   int valor1, valor2;
   
   printf("Digite o valor1: ");
   scanf("%i",&valor1);
   
   printf("Digite o valor2: ");
   scanf("%i",&valor2);
   
   if(valor1>valor2){
        printf("Diferenca: %i",valor1-valor2);                  
   }else{
        printf("Diferenca: %i",valor2-valor1);
   }
   
   getch();
   return 0;
}
