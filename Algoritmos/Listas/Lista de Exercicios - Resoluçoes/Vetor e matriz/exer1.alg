algoritmo "semnome"
// Função :
// Autor :
// Data : 01/05/2013
// Seção de Declarações
var
VertA: vetor [1..10] de Caractere
qualq: Caractere
i,j, NaoAchou: inteiro

inicio
// Seção de Comandos


Para i de 1 ate 10 faca
escreval ("informe um nome")
leia (VertA[i])

fimpara

Escreval ("Digite outro nome")
leia (qualq)

para i de 1 ate 10 faca
Se (qualq = VertA[i]) entao
   NaoAchou <-0
senao
   NaoAchou <- 10

fimse
   fimpara
   Se (NaoAchou = 10) entao
     escreval ("NAO ACHEI")
     Senao
     se (NaoAchou = 0) entao
     escreval ("ACHEI")
   FIMSE
          fimse


fimalgoritmo
