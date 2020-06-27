int main(){
    float a, b, c, delta, x1, x2;
        
    printf("Digite o valor de a: ");
    scanf("%f",&a);
    
    printf("Digite o valor de b: ");
    scanf("%f",&b);
    
    printf("Digite o valor de c: ");
    scanf("%f",&c);
    
    if(a!=0){
        delta=pow(b,2)-4*a*c; 
        printf("Delta: %f",delta);        
        if(delta<0){
            printf("\nNao existe raiz real");         
        }else{
              if(delta==0){
                  x1=(-1)*b/2*a;     
                  printf("\nRaiz: %f",x1);
              }else{
                  x1=( (-1)*b+sqrt(delta) )/2.0*a;
                  x2=( (-1)*b-sqrt(delta) )/2.0*a;
                   printf("\nRaiz1: %f",x1);
                   printf("\nRaiz2: %f",x2);                  
              }
        }
    
    }
    getch();
    return 0;

}
