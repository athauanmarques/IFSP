algoritmo "exerc1"

var
notas: vetor[1..2, 1..5] de real
lin, col: inteiro
totalNotas1, totalNotas2, media1,media2, maior1, maior2, per1, per2: real
qtd1, qtd2: inteiro
inicio

para lin de 1 ate 2 faca
     para col de 1 ate 5 faca
          escreva("informe nota ", lin, " - ", col, ": ")
          leia(notas[lin,col])
              se (lin=1) entao
                  totalNotas1 <- totalNotas1 + notas[lin,col]
                    se (notas[lin,col] > maior1) entao
                          maior1 <- notas[lin,col]
                    fimse

              senao
                   totalNotas2 <- totalNotas2 + notas[lin,col]
                     se (notas[lin,col] > maior2) entao
                         maior2 <- notas[lin,col]
                     fimse
              fimse
     FimPara
FimPara
      media1 <- totalNotas1 / 5
      media2 <- totalNotas2 / 5
para lin de 1 ate 2 faca
     para col de 1 ate 5 faca
          se (lin = 1)entao
                  se (notas[lin,col] < media1) entao
                        escreval("nota[", lin, "-", col,"]= ", notas[lin,col])
                        qtd1 <- qtd1 + 1
                  fimse
           senao
                 se (notas[lin,col] < media2) entao
                           escreval("nota[", lin, "-", col,"]= ", notas[lin,col])
                           qtd2 <- qtd2 + 1
                fimse
           fimse

     FimPara
     fimpara

     per1 <- qtd1 * 100 /5
     per2 <- qtd2 * 100 /5
     
     escreval("perc1 = ", per1)
     escreval("perc2 = ", per2)
     
     escreval("maior1 = ", maior1)
     escreval("maior2 = ", maior2)
fimalgoritmo
