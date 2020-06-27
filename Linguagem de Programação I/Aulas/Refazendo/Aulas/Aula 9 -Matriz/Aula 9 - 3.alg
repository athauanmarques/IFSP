algoritmo "semnome"
// Função :
// Autor :
// Data : 23/07/2013
// Seção de Declarações 
var
N: vetor [1..3,1..3] de inteiro
C: vetor [1..3,1..3] de caracter
lin, col: inteiro

inicio
// Seção de Comandos 

para lin de 1 ate 3 faca
 para col de 1 ate 3 faca
 escreval (" informe numeros: ")
 leia (N[lin,col])
 
 fimpara
 fimpara
 para lin de 1 ate 3 faca
 para col de 1 ate 3 faca
 
 se (N[lin,col]%2=0) entao
   C[lin,col] <- "p"
   senao
    C[lin,col] <- "I"
    
    fimse
    fimpara
    fimpara
     para lin de 1 ate 3 faca
 para col de 1 ate 3 faca
    escreval ("resultado ", C[lin,col])
 
   fimpara
    fimpara

fimalgoritmo
