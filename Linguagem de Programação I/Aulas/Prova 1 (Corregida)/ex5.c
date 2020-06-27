int main(){
     int cor;
     
     printf("Informe a cor: ");
     scanf("%i",&cor);
     
     switch(cor){
        case 1:
              printf("Verde  R$10,00");
              break;
        case 2:
              printf("Azul  R$20,00");
              break;
        case 3:
              printf("Amarelo R$30,00");
              break;
        case 4:
              printf("Vermelho  R$40,00");
              break;
        default:
              printf("Cor invalida!");
     
     }   
     getch();
     return 0;
    
}
