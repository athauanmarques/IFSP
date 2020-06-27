/*

exercicios 

ordenados




*/
int main(){
    int numeros[10];
    int i, fim;
    int aux;
    
    for(i=0;i<10;i++){
       printf("numeros[%i]: ",i);
       scanf("%i",&numeros[i]);
    }    

    for(fim=9;fim>0;fim--){
                            
        for(i=0;i<=fim;i++){
                            
            if(numeros[i]>numeros[i+1]){
                aux=numeros[i];
                numeros[i]=numeros[i+1];
                numeros[i+1]=aux;       
            }
        }
    }
    
      
    for(i=0;i<10;i++){
       printf("\nnumeros[%i]=%i",i,numeros[i]);
    }    

    getch();
    return 0;

}
