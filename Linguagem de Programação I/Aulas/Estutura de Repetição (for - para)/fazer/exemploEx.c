/*

Programador: Athauan Marques da Cunha
Prontu�rio: 136246-1 
Data:  03/10/2013
Assunto: Repeti��o - FOR 
			
Exerc�cios

1. [Farrer et al. 1989] Supondo que a popula��o de um pa�s A seja de ordem de 90.000.000 de habitantes 
com uma taxa anual de crescimento de 3% e que a popula��o de um pa�s B seja, 
aproximadamente, de 200.000.000 de habitantes com uma taxa anual de crescimento de 1,5%, 
fazer um programa,
 que calcule e escreva o n�mero de anos necess�rios para que a popula��o do pa�s,
  A ultrapasse ou iguale a popula��o do pa�s B, 
mantidas essas taxas de crescimento.

*/
#include <stadio.h>
int main() {
    float paisA=90.00, paisB=200.00, i;
    
    for (paisA=90.00, paisB=200.00; i==paisB; i++){
        paisA*1.03;
        paisB*1.05;
}
    
  printf ("o resultado � n: %.2f m: %.2f");
  
  getch ();
  return 0;   
    
    
    
    }
