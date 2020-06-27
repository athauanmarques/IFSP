#include<math.h>
#include<stdio.h>
#include<stdlib.h>
int main(){
    int codigo;
    float salAntigo,salNovo;
    
    printf("\n\n\tInforme o seu salario: ");
    scanf("%f",&salAntigo);
    printf("\n\tDigite o codigo de sua funcao:\n\n\t\t101=Gerente\n\t\t102=Engenheiro\n\t\t103=tecnico\n\n\tFuncao: ");
    scanf("%i",&codigo);
    
    switch(codigo){
    case 101: salNovo=salAntigo*1.10;
    break;
    case 102: salNovo=salAntigo*1.20;
    break;
    case 103: salNovo=salAntigo*1.30;
    break;
    default: salNovo=salAntigo*1.40;
    }
    
    printf("\n\tO seu salario antigo foi: %.2f",salAntigo);
    printf("\n\tO seu novo salario foi: %.2f",salNovo);
    printf("\n\n\tA diferenca(aumento) foi: %.2f",salNovo-salAntigo);
    //printf("\n\n\n\tProva real,pra confirmar...%.2f POR CENTO DE AUMENTO",(salNovo-salAntigo)/salAntigo*100);//densnecessário para o exercício
    
    getch();
    return 0;
}
