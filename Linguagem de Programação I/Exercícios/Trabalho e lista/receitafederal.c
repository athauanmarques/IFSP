int main(){
    float  rendimentos, previdenciaOficial, dependente, totalDependente, pensao, deducoes, deducoesTotais, baseTotal, imposto;
    
    printf ("Digite Rendimento Tributaveis: ");
    scanf ("%f" ,&rendimentos);

    printf ("Digite Previd�ncia Oficial: ");
    scanf ("%f" ,&previdenciaOficial);

    printf ("Dependente (quantidade): ");
    scanf ("%f" ,&dependente);

    printf ("Pens�o aliment�cia: ");
    scanf ("%f" ,&pensao);

    printf ("Outras dedu��es: ");
    scanf ("%f" ,&deducoes);
    
   totalDependente=dependente * 171,97;
   printf ("%f" , totalDependente); 
   
   deducoesTotais=totalDependente+previdenciaOficial+pensao+deducoes;
   printf ("%f" , deducoesTotais); 
   
   baseTotal=rendimentos-deducoesTotais;
   printf ("%f" , baseTotal); 
   
   
   
   
   
   
    
    
   



}

