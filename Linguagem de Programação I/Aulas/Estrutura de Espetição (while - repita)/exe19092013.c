#include<stdio.h>
#include<stdlib.h>

int mina ()
{
    float nota, media, somanota;
    int cont;
    
    printf("Digite a nota de um aluno: ");
    scanf("%f", &nota);
    
    while (cont < 10){
          somanota = somanota + nota;
          cont = cont++;
          }
          media = somanota/10;
          
          printf("A media das notas dessa sala \220: ", media);
          
       
getch();

return 0;
    
    
}
