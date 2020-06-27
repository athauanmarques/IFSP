algoritmo "semnome"
// Função :
// Autor :
// Data : 07/05/2013
// Seção de Declarações
var
VetorA: vetor [1..5] de inteiro
VetorM: vetor [1..5] de inteiro
x: inteiro
i: inteiro
resultado: inteiro

inicio

para i de 1 ate 5 faca
   escreval ("Digite 10 numeros na posição ", i)
   leia (VetorA[i])

fimpara

Escreval ("digite o valor de X")
leia (x)

para i de 1 ate 5 faca
   VetorM[i]<-VetorA[i]*x

Escreval ("Valor da posição é: " ,VetorM[i])

fimpara


// Seção de Comandos
fimalgoritmo
