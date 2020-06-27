algoritmo "matriz exerc1"
// Função :
// Autor :
// Data : 25/04/2013
// Seção de Declarações 
var
notas: vetor: [1..2, 1..5] de real
lin, col: inteiro
totaldeNotas1, totaldeNotas2, media1, media2, maior1, maior2, pert1, pert2: real
qtd1, qtd2: inteiro

Para lin de 1 ate 2 faca
para col de 1 ate 5 faca
     escreval ("informe a nota ", lin, "-", col,": ")
     leia (notas[lin,col])

     se(lin=1) entao
          totalNotas1 <- totalNotas1 + notas [lin,col]
     senao
          totalNotas2 <- totalNotas2 + notas [lin,col]
     fimse
     
fimpara
fimpara

media1 <- totalNota1 / 5
media2 <- totalNota2 / 5

       Para lin de 1 ate 2 faca
            para col de 1 ate 5 faca
            
            se (lin=1) entao
            se (notas[lin,col] < media1) entao
            escreval ("nota[",lin,"-",col,"]= " notas [lin,col]
            qtd1 <- qtd1 + 1
            fimse
       senao
           se (notas[lin,col] < media2) entao
            escreval ("nota[",lin,"-",col,"]= " notas [lin,col]
            qtd1 <- qtd2 + 2
            fimse




fimalgoritmo
