int main (){
    
    int numero, dezena, unidade, soma;
    
    printf ("infor um numero de 1 ate 99: ");
    scanf ("%i" ,&numero);
    
    dezena = numero/10;
    unidade = numero%10;
    soma = dezena+unidade;
    
    printf ("o resultado foi: %i", soma);
    
    getch ();
    
    return 0;
    
}
