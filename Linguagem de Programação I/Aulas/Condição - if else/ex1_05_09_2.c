/*
Faça um programa que receba 3 valores e informe se esses valores 
formam os lados de um triângulo.
Para formarem os lados de um triângulo cada valor deve ser menor do que 
a soma dos outros dois.
Autora: Elisandra Silva
Data: 05/09/2013
*/

int main(){
    int lado1, lado2, lado3;
    
    printf("Digite o valor para o lado1:");
    scanf("%i",&lado1);
    
    printf("Digite o valor para o lado2:");
    scanf("%i",&lado2);
    
    printf("Digite o valor para o lado3:");
    scanf("%i",&lado3);
    
    if(lado1<lado2+lado3 && lado2<lado1+lado3 && lado3<lado1+lado2){
                         
        if(lado1==lado2 && lado2==lado3){
            printf("\nTriangulo Equilatero!");       
        }
        
        if(lado1==lado2 || lado1==lado3 || lado2==lado3){
            printf("\nTriangulo Isoceles!");
        }
        
        if(lado1!=lado2 && lado2!=lado3 && lado1!=lado3){
            printf("\nTriangulo Escaleno!");            
        }     
                       
                         
    }else{
        printf("Nao forma um triangulo!");
    }
    getch();
    return 0;
    
}
