int main(){
    //Introdução e Declaração de Variáveis
    
    int anoNascimento, anoAtual/*Variáveis de Ent*/, idadeAnos, idadeMeses, idadeSemanas,idadeDias;
     //Variáveis de Processamento
     
    printf("Digite o ano em que você nasceu ");
    scanf("%i",&anoNascimento);
    
    printf("Digite o ano atual ");
    scanf("%i",&anoAtual);
    //Processamento Total
    
    idadeAnos=anoAtual-anoNascimento;
    
    idadeMeses=idadeAnos*12;
    
    idadeSemanas=idadeAnos*52;
    
    idadeDias=idadeAnos*365;
    
    //Saída de Todos os Resultados
           
    printf("\nSua idade em anos: %i\n", idadeAnos);
    
    printf("Sua idade em meses: %i\n", idadeMeses);
    
    printf("Sua idade em semanas: %i\n", idadeSemanas);
    
    printf("Sua idade em dias: %i\n", idadeDias);
     
    getch();
    
    return 0;
    
    }
