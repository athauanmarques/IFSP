#include <stdio.h>
int main (){
    float a, b, c, x, x1, x2,
		  quadrado, delta=0, grau=1;
	
	printf("informe os valores de a: ");
	scanf("%f", &a);
	
	printf("informe os valores de b\n");
	scanf("%f", &b);
	
	printf("informe os valores de c: \n");
	scanf("%f", &c);
	
	quadrado=b*b;
	delta=quadrado-(4*a*c);
	
	if (a==0){
		printf ("valor do a tem ser diferente que 0");
	}else{
	
	switch(delta){
	  case 0:
			 x=(-b+delta)/2*a;
			 printf (" delta tem uma raiz o valor e : %0.2", x);
			 break;
	   /*case delta>0:
			x1=(-b+delta)/2*a;
			x2=(-b-delta)/2*a;
			printf ("delta tem duas raizes: valor de x1: %0.2f, x2: %0.2f", x1, x2);
			break;
	   default:
	   	     printf ("nao tem raiz");
	   	     break;*/
		
	}
             }
	
	/*
     if(a==0){
      printf ("valor de a tem ser diferente que 0");
	  }if (delta>0){
		x1=(-b+delta)/2*a;
		x2=(-b-delta)/2*a;
		printf ("delta tem duas raizes: valor de x1: %0.2f, x2: %0.2f", x1, x2);
	     }if(delta<0){	
	        printf ("nao tem raiz");
		    }else{
		 	x=(-b+delta)/2*a;
		 	printf ("delta tem uma raiz: o valor de x: %f", x);
		 	 
	 }
	  */
		         
           

		getch ();
		return 0;

}
		
		
			  
			  










