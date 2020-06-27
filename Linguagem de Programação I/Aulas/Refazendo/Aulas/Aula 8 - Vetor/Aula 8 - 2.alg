algoritmo "semnome"
// Função :
// Autor :
// Data : 27/06/2013
// Seção de Declarações
var
A2 : vetor [1..5] de inteiro
total : inteiro
x2: inteiro

inicio
// Seção de Comandos

PARA x2 de 1 ate 5 faca
   escreval ("informe os valores do vetor: ")
   leia (A2[x2])

   se (A2[x2] % 2 <> 0) entao
   total <- total + A2[x2]
   fimse
fimpara

escreval ("O valor impar", total)
fimalgoritmo
