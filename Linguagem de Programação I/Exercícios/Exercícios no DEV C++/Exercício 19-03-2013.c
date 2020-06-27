#include <math.h>
int main(){
    float peso, altura, imc,pesoIdeal;
    char sexo;
    printf ("Digite seu peso,please? ");
    scanf("%f",&peso);
    printf ("Digite sua altura: ");
    scanf ("%f",&altura);
    
    printf("Informe seu Sexo M/F: ");
    sexo = getche();
    imc=peso/pow(altura,2);
    printf("\nSeu IMC: %.2f",imc);
    
    if (sexo=='M'||sexo=='m'){
        pesoIdeal=72+7*altura-58;                      
     }else{
        if (sexo=='F'||sexo=='f'){ 
        pesoIdeal=62.1*altura-44.7;
    } else{
           printf ("\nSexo Inválido! ");
           }
       }
    
    if (peso > pesoIdeal){
        printf ("\nVoce esta acima do peso.");
    }else{
          printf ("\nSeu peso esta ok ou abaixo");
          } 
    
    getch ();
    return 0;                
}                 
