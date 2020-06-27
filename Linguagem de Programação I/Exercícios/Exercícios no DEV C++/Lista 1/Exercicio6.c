#include <math.h>
int main(){
    int a,b,c,d,e,f,x,y;
    printf("Informe o coeficiente A: \a\a\a\a\a\a\a\a\a\a");
    scanf("%i",&a);
    printf("Informe o coeficiente B: ");
    scanf("%i",&b);
    printf("Informe o coeficiente C: ");
    scanf("%i",&c);
    printf("Informe o coeficiente D: ");
    scanf("%i",&d);
    printf("Informe o coeficiente E: ");
    scanf("%i",&e);
    printf("Informe o coeficiente F: ");
    scanf("%i",&f);
    
    x=(c*e-b*f)/(a*e-b*d);
    y=(a*f-c*d)/(a*e-b*d);
    
    printf("\nO valor de X resulta em: %i",x);
    printf("\nO valor de Y resulta em: %i",y);
    
    getch();
    return 0;
    
    
    }
