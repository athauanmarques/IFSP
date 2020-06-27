int main(){
    float soma=0, numerador, denominador, n;
    
    printf("Digite o valor de n: ");
    scanf("%f",&n);
    
    for(numerador=1, denominador=100; numerador <= n ; numerador++, denominador--){
        soma=soma+numerador/denominador;
    }
    
    printf("Soma: %f",soma);
    getch();
    return 0;


}
