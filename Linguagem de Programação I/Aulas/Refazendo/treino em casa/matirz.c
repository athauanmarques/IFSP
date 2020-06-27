#include <stdio.h>
int main (){
	int c[0][0], a[0][0], b[0][0];
	int i, j, ai, aj, bi, bj;
	char ope;
	
	
	printf ("Der valores das matrizes para ser determinadas\ninforme linha da matriz A: ");
	scanf ("%i", &ai);
	
	printf ("informe colunas da matriz A: ");
	scanf ("%i", &aj);
	
	a[0][0]=a[ai][aj];
	
	printf ("informe linha da matriz B: ");
	scanf ("%i", &bi);
	
	printf ("informe colunas da matriz B: ");
	scanf ("%i", &bj);
	
	b[0][0]=b[bi][bj];
	
	if (ai==aj){
		printf ("\nmatriz A quadrada de %i x %i", ai, aj);
	
	}else{
		printf ("\nmatriz A de %i x %i", ai, aj);

		
	}
		if (bi==bj){
		printf ("\nmatriz B quadrada de %ix%i", ai, aj);
	
	}else{
		printf ("\nmatriz B de %ix%i", ai, aj);

	}
	
		printf ("\n\ninforme que tipo de operacao desaja fazer,\n escolha que tipo de resultado deseja (+,-,* ou /): ");
		scanf ("%c", &ope);
ope = getch ();
	switch (ope){
		
		case '+':
					
			  	  for (i=0; i<ai; i++){
			  	  }
			  	  for (j=0; j<aj; j++){
			  	  }
			  	   for (i=0; i<bi; i++){
			  	  }
			  	  for (j=0; j<bj; j++){
			  	  }
			  	  c[j][i]=a[ai][aj]+b[bi][bj];
			  	  printf ("\nA soma das matrizes foi: %i", c[i][j]);
			  	  break;

			
	}


getch ();
return 0;

}
