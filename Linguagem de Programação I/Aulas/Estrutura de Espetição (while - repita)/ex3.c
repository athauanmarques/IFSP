/*

Chico tem 1,50 metro e cresce 2 cent�metros por ano, enquanto Z� tem 1,10 metro e cresce 3 cent�metros por ano. 
Construa um programa que calcule e imprima quantos anos ser�o necess�rios para que Z� seja maior que Chico. 
Autora: Elisandra
Data: 19/09/2013

*/

int main(){
    int anos=0;
    float alturaZe=1.1, alturaChico=1.5;
    
    while(alturaZe<=alturaChico){
        alturaZe=alturaZe+0.03;
        alturaChico=alturaChico+0.02;
        anos++; //anos=anos+1;
    }

    printf("Quantidade de anos para que Ze seja maior do que Chico: %i",anos);
    getch();
    return 0;

}
