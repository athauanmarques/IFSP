int main(){
    int identificacaoVendedor, salarioFixo, totalVendas, percentual, salarioTotal ;//Todas as Vari�veis(Entrada,Processamento,Sa�da)
    //Entrada de Dados   
    
    printf("Identifique Usuario: ");
    scanf("%i", &identificacaoVendedor);
    
    printf("Digite o salario fixo: ");
    scanf("%i", &salarioFixo);
    
    printf("Informe o Total de Vendas: ");
    scanf("%i", &totalVendas);
    
    printf("Informe o Percentual : ");
    scanf("%i", &percentual);
    
    //Processamento
    
    salarioTotal=totalVendas*percentual/100+salarioFixo;
    
    //Sa�da
    
    printf("\nSalario Total = %i", salarioTotal);
    printf("\nCodigo do Vendedor = %i", identificacaoVendedor);
    
    
    getch();
    return 0;
    
    
    }
