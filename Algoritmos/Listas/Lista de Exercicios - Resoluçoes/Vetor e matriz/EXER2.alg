algoritmo "semnome"
// Função :
// Autor :
// Data : 03/05/2013
// Seção de Declarações
var
VertA: vetor [1..20] de inteiro
i,contagem: inteiro
media,soma: real

inicio
// Seção de Comandos
Para i de 1 ate 20 faca
   Escreval ("Digite a nota do aluno ")
   leia (VertA[i])
         soma<-soma+verta[i]
fimpara

media <-soma/20

para i de 1 ate 20 faca
     Se (VertA[i]>media ) entao
      contagem<-contagem+1

fimse
Fimpara
    escreval("A media turma foi:",media)
     escreval("Os alunos q obtiveram nota acima foi:",contagem)


fimalgoritmo
