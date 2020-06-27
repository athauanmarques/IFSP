int main(){
    int aluno=1;
    float nota, soma=0, media;
    
    while(aluno<=10){
        printf("\nDigite uma nota: ");
        scanf("%f",&nota);
        soma+=nota; // igual a => soma=soma+nota;
       // printf("\naluno: %i soma: %f", aluno, soma);
        aluno++;
    }    
    
    media=soma/10;
    printf("\nMedia da turma: %f",media);
    
    getch();
    return 0;
}
