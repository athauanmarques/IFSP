int main(){
    float nota1, nota2, nota3, media;
    
    printf("Nota 1: ");
    scanf("%f",&nota1);

    printf("Nota 2: ");
    scanf("%f",&nota2);
    
    printf("Nota 3: ");
    scanf("%f",&nota3);
    
    media=(nota1+nota2+nota3)/3;
    printf("\nMedia: %f",media);
    if(media>=9){
        printf("\nConceito A");
    }else{
        if(media>=7.5){
            printf("\nConceito B");
        }else{
            if(media>=6){
                printf("\nConceito C");
            }else{
                if(media>=4){
                    printf("\nConceito D");
                }else{
                    printf("\nConceito E");
                }
            }
        }
    } 

    getch();
    return 0;

}
