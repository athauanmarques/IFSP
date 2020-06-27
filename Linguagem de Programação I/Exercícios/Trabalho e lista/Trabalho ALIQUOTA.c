int main(){
    float rendimentos,previdencia,totalDependente,pensao,outras,deducoes,base=0,totalImposto=0,aliquota=0; //as variáveis que serão usadas para comparação foram zeradas
    float faixa1=0,faixa2=0,faixa3=0,faixa4=0,faixa5=0,imposto1=0,imposto2=0,imposto3=0,imposto4=0,imposto5=0; //por motivo de precaução,foram zeradas as varáveis,pois pode conter qualquer coisa nelas
    int dependente; //única variável que pode ser do tipo inteiro
    
    printf("\t\t\tSIMULACAO DE ALIQUOTA EFETIVA\n\n\t\tImposto de Renda Mensal - Valores em Reais\t"); //Título do programa
    printf("\n\n1.Rendimentos tributaveis: ");
    scanf("%f",&rendimentos); //irá ler os rendimentos tributáveis
    printf("\n2.Deducoes\n2.1 Previdencia Oficial: ");
    scanf("%f",&previdencia); //lê a previdencia
    printf("\n2.2 Dependentes(quantidade): ");
    scanf("%i",&dependente); //lê numero de dependentes
    totalDependente=dependente*171.97; //multiplica o numero de dependentes pela constante '171.97'
    printf("\n(o valor da deducao e R$171,97 mensais por dependente)\t= %.2f",totalDependente); //exibe na tela o valor dos dependentes(resultado da multiplicação anterior)
    printf("\n\n2.3 Pensao Alimenticia: ");
    scanf("%f",&pensao); //lê o valor da pensão alimentícia
    printf("2.4 Outras deducoes \n\n\t(Previdencia Privada, FAPI e Parcela isenta de aposentadoria,\n"); //texto para auxiliar o usuário
    printf("\treserva remunerada, reforma e pensao para declarante com 65 anos \n\tou mais,caso nao tenha sido deduzida\n");  //texto para auxiliar o usuário
    printf("\tdos rendimentos tributaveis. Carne-Leao: Livro Caixa): "); //texto para auxiliar o usuário
    scanf("%f",&outras); //lê as outras deduções

    deducoes=previdencia+totalDependente+pensao+outras; //soma todas as deduções(que serão descontadas dos rendimentos tributáveis e armazena em 'deduções'
    base=rendimentos-deducoes; //calcula os rendimentos tributáveis,menos as deduções e armazena o resultado na Base de calculo
    
    printf("\n2.5 Total de Deducoes: %.2f ",deducoes); //exibe o total (soma) das deduções
    printf("\n3.Base de Calculo(1-2.5: %.2f",base); //exibe a base de cálculo,que é o resultado da subtração (RENDIMENTOS - TOTAL de DEUDUÇÕES
    if(base<=1710.78){ //compara a base de cálculo. Se a base for MENOR que 1710.78,a faixa1 recebe o valor da base. NESTE CASO É ISENTO DE IMPOSTO,ENTÃO NÃO REALIZA MAIS NENHUM CÁLCULO
                      faixa1=base;
    }
    if(base>1710.78){ 
                      faixa1=1710.78; //se a base é maior que este valor,a faixa1 exibirá o valor MÁXIMO possível para a faixa,ou seja, 1710.78
                      faixa2=base-1710.78;
    }   
    if(faixa2>853.13){ //a partir desse ponto,a comparação é feita com a faixa atual.Caso seja menor,o valor que sobrou da subtração no if anterior já estará armaenado na faixa2,já podendo ser exibida na tabela
                      faixa3=faixa2-853.13; //Caso faixa2 for MAIOR que o valor limite,o valor que sobra da subtração é armazenado na próxima faixa(faixa3),e assim sucessivamente 
                      faixa2=853.13; //se o valor que foi gravado na FAIXA2 é maior que o valor máximo da faixa(853.13),a faixa1 exibirá o valor MÁXIMO possível para a faixa,ou seja, 853.13
    }
    if(faixa3>854.68){ //Caso NÃO SEJA MAIOR, o valor que sobrou da subtração no if anterior já estará armaenado na faixa3,já podendo ser exibida na tabela
                      faixa4=faixa3-854.68;
                      faixa3=854.68;
    }
    if(faixa4>853.00){
                      faixa5=faixa4-853; //caso tenha chegado até aqui,o valor que sobra da faixa 4 é armazenado na faixa 5,e se encerram as comparações
                      faixa4=853;
    }
    imposto2=faixa2*0.075; //O valor contido na faixa2 é multiplicado pelo imposto devido dessa faixa, neste caso, 7,5%
    imposto3=faixa3*0.15; //O valor contido na faixa3 é multiplicado pelo imposto devido dessa faixa, neste caso, 15%
    imposto4=faixa4*0.225; //O valor contido na faixa4 é multiplicado pelo imposto devido dessa faixa, neste caso, 22,5%
    imposto5=faixa5*0.275; //O valor contido na faixa5 é multiplicado pelo imposto devido dessa faixa, neste caso, 27,5%
    totalImposto=imposto2+imposto3+imposto4+imposto5; //SOMA dos impostos da faixa2 até a faixa5 ( faixa1 não entra,pois o imposto é = 0% )
    aliquota=totalImposto*100/rendimentos; // alíquota é a divisão do Imposto Total pelos Rendimentos Tributáveis. ( multiplicado por 100 para ser representado em % )
    printf("\n4.Imposto:\t %.2f",totalImposto);
    printf("\n\n\tDEMONSTRARIVO DA APURACAO DO IMPOSTO\n\n\tFaixa da Base de Calculo\tAliquota\tValor do Imposto");
    printf("\n\n\t1a Faixa\t %.2f\t Isento\t\t\t 0,00\n\t2a Faixa\t %.2f\t\t 7.5\t\t\t %.2f\n\t3a Faixa\t %.2f\t\t 15\t\t\t %.2f\n\t4a Faixa\t %.2f\t\t 22.5\t\t\t %.2f\n\t5a Faixa\t %.2f\t\t 27.5\t\t\t %.2f\n\tTotal\t\t %.2f\t ----\t\t\t %.2f",faixa1,faixa2,imposto2,faixa3,imposto3,faixa4,imposto4,faixa5,imposto5,base,totalImposto);//,totalImposto);
    printf("\n\nAliquota Efetiva -  %.2f%c   Percentual do Imposto sobre os Rendimentos Tributaveis.",aliquota,'%');
    getch();
    return 0;

    
}
