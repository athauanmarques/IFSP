

int main(){
    int idade;
    printf ("digite sua idade: ");
    scanf ("%i",&idade);
    if (idade < 30){
    printf ("Voce e jovem");          
    }else{
      if (idade == 30){
      printf ("Parabens");
                
      }else{
        printf ("Voce e velho");
                      }     
           
     
       }
    getch ();
    return 0;  


}
