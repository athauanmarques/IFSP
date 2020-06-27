

int main(){
    int idade;
    printf ("digite sua idade: ");
    scanf ("%i",&idade);
    if (idade < 30){
    printf ("\nVoce e jovem");          
    }else{
      if (idade == 30){
      printf ("\nParabens");
                
      }else{
        printf ("\nVoce e velho");
       }     
           
    }         
       
    getch ();
    return 0;  


}
