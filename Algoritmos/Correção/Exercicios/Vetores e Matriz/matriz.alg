algoritmo "exxermatriz"
// Função :
// Autor :
// Data : 30/04/2013
// Seção de Declarações 
var
N: vetor [1..2,1..3] de inteiro
C: vetor [1..2,1..3] de caracter
lin, col: inteiro

inicio
para lin de 1 ate 2 faca
para col de 1 ate 3 faca
escreval("N[",lin,"-",col,"]: ")
leia (N[lin,col])

se (N[lin,col]%2=0) entao
    C[lin,col] <- "P"
senao
     C[lin,col] <- "I"
     
     fimse
     fimpara
     fimpara





fimalgoritmo
