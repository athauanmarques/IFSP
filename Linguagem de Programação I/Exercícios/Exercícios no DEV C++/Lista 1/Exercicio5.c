#include <math.h>
int main(){
    
    int a,b,c,r,s,d;
    printf("Digite o numero A: ");
    scanf("%i",&a);
    printf("Digite o numero B: ");
    scanf("%i",&b);
    printf("Digite o numero C: ");
    scanf("%i",&c);
    
    r=pow((a+b),2);
    s=pow((b+c),2);
    
    d=(r+s)/2;
    printf("\nO resultado atingiu: %i",d);//com a=3,b=6,c=5 => Ocorreu erro,resultado foi 100,e não 101
    printf("\nO resultado r fica:%i",r);
    printf("\nO resultado s fica:%i",s);
    
    getch();
    
    return 0;
    
    
    }
