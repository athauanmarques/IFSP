int main(){
    //Introdu��o e Declara��o de Vari�veis
    
    int anoNascimento, anoAtual/*Vari�veis de Ent*/, idadeAnos, idadeMeses, idadeSemanas,idadeDias;
     //Vari�veis de Processamento
     
    printf("Digite o ano em que voc� nasceu ");
    scanf("%i",&anoNascimento);
    
    printf("Digite o ano atual ");
    scanf("%i",&anoAtual);
    //Processamento Total
    
    idadeAnos=anoAtual-anoNascimento;
    
    idadeMeses=idadeAnos*12;
    
    idadeSemanas=idadeAnos*52;
    
    idadeDias=idadeAnos*365;
    
    //Sa�da de Todos os Resultados
           
    printf("\nSua idade em anos: %i\n", idadeAnos);
    
    printf("Sua idade em meses: %i\n", idadeMeses);
    
    printf("Sua idade em semanas: %i\n", idadeSemanas);
    
    printf("Sua idade em dias: %i\n", idadeDias);
     
    getch();
    
    return 0;
    
    }
