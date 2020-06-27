int main(){
    int identificacaoVendedor, salarioFixo, totalVendas, percentual, salarioTotal ;//Todas as Variáveis(Entrada,Processamento,Saída)
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
    
    //Saída
    
    printf("\nSalario Total = %i", salarioTotal);
    printf("\nCodigo do Vendedor = %i", identificacaoVendedor);
    
    
    getch();
    return 0;
    
    
    }
