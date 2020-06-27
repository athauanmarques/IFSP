int main(){
    float saldo=0;
    float salario, cheque1, cheque2;
    
    printf("Digite o salario: ");
    scanf("%f",&salario);
    
    printf("Digite o valor do cheque1: ");
    scanf("%f",&cheque1);
    
    printf("Digite o valor do cheque2: ");
    scanf("%f",&cheque2);
     
    saldo=saldo+salario;
    
    saldo = saldo - (1.0038*cheque1);
    saldo = saldo - (1.0038*cheque2);
    
    printf("\nSaldo final: %.2f",saldo);
    
    getch();
    
    return 0;
        
}
