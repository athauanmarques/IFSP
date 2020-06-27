int main(){
    int numeros[10];
    int i;
    
    for(i=0;i<10;i++){
        printf("Digite o elemento: ");
        scanf("%i", &numeros[i]);
    }
    
    for(i=9;i>=0;i--){
        printf(" %i", numeros[i]);
    }

    getch();
    return 0;
}
