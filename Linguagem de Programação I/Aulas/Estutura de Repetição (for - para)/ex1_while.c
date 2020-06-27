int main(){
    float soma=0, numerador, denominador, n;
    
    printf("Digite o valor de n: ");
    scanf("%f",&n);
    
    numerador=1;
    denominador=100;
    while(numerador <= n){
        soma=soma+numerador/denominador;
        numerador++;
        denominador--;
    }
    
    printf("Soma: %f",soma);
    getch();
    return 0;


}
