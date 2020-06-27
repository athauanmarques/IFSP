int main(){
    float  rendimentos, previdenciaOficial, dependente, totalDependente, pensao, deducoes, deducoesTotais, baseTotal, imposto;
    
    printf ("Digite Rendimento Tributaveis: ");
    scanf ("%f" ,&rendimentos);

    printf ("Digite Previdência Oficial: ");
    scanf ("%f" ,&previdenciaOficial);

    printf ("Dependente (quantidade): ");
    scanf ("%f" ,&dependente);

    printf ("Pensão alimentícia: ");
    scanf ("%f" ,&pensao);

    printf ("Outras deduções: ");
    scanf ("%f" ,&deducoes);
    
   totalDependente=dependente * 171,97;
   printf ("%f" , totalDependente); 
   
   deducoesTotais=totalDependente+previdenciaOficial+pensao+deducoes;
   printf ("%f" , deducoesTotais); 
   
   baseTotal=rendimentos-deducoesTotais;
   printf ("%f" , baseTotal); 
   
   
   
   
   
   
    
    
   



}

