
int main ();
{
    int anoNascimento, anoAtual, IdadeAnos, IdadeMeses, IdadeSemanas, IdadesDias;
    
    printf ("Digite ano de nascimento");
    scanf ("%i", anoNascimento);
    
    printf ("Digite ano atual");
    scanf ("%i", anoAtual);
    
          IdadeAnos= anoNascimento-anoAtual;
          scanf ("%i", IdadeAnos) 
          
          IdadeMeses= IdadeAnos*12;
          scanf ("%i", IdadeMeses);
          
          IdadeSemanas= IdadesMeses*4;
          scanf ("%i", IdadeSemanas);
          
          IdadesDias= IdadeSemanas*30;
          scanf ("%i", IdadesDias);
          
     printf ("Sua idade: ", IdadeAnos);
     printf ("Sua idade em meses: ", IdadeMeses);
     printf ("Sua idade em semanas; ", IdadeSemanas);
     printf ("Sua idade em dias: ", IdadesDias);
          
          getch ();
          return 0;
    
}
    
