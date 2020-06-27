int main(){
    int n;
    int i;
    int j=1;
    
    
    
    while(j<=10){
    
        printf("\nDigite um numero n: ");
        scanf("%i",&n);
        
        i=1;
    
        while(i<=n){
            printf("\n %i * %i = %i ", i, n, i*n);  
            i++;          
        }
        
        j++;
     
    }
    
    getch();
    return 0;
        
    


}
