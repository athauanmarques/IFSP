# include <math.h>


int main (){
    int idVendedor;
        float salarioFixo, totalDeVendas, percentual, salarioTotal;
    
    printf("idVendedor:");
    scanf ("%i",&idVendedor);
    printf("salarioFixo:");
    scanf("%f", &salarioFixo);
    printf("totalDeVendas");
    scanf ("%f",&totalDeVendas);
    printf("percentual");
    scanf ("%f",&percentual);
    salarioTotal = salarioFixo + totalDeVendas * percentual /100;
    printf("salarioTotal: %f", salarioTotal);
    getch();
    return 0;
}
