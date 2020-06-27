algoritmo "semnome"
// Função :
// Autor :
// Data : 08/05/2013
// Seção de Declarações
var
Nome: vetor [1..5] de caracter
Notas: vetor [1..5,1..4] de real
lin, col: inteiro
MediaAlunoV: vetor [1..5] de real
media: real

inicio
// Seção de Comandos

para lin de 1 ate 5 faca
   escreval ("-----  Digite os nomes dos alunos  -------")
   leia(Nome[lin])
   
      para col de 1 ate 4 faca
         escreval("Digite Notas: ")
         leia (Notas[lin,col])
         
 media<-media+Notas[lin,col]
 MediaAlunoV[lin]<-MediaAlunoV[lin]+Notas[lin,col]
  fimpara
  MediaAlunoV[lin]<-MediaAlunoV[lin]/4
fimpara

media<-media/20

para lin de 1 ate 5 faca
se (MediaAlunoV [lin]>=media) entao
   escreval("A media do aluno: ",Nome[lin]," E a nota: ",MediaAlunoV[lin],": ")
       fimse
       fimpara
      fimalgoritmo
