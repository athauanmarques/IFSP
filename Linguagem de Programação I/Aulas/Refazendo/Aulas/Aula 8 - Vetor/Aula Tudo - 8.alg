algoritmo "semnome"
// Função :
// Autor :
// Data : 22/07/2013
// Seção de Declarações
var
A1 : vetor [1..10] de inteiro
B1 : vetor [1..10] de inteiro
A2 : vetor [1..5] de inteiro
A3 : vetor [1..5] de inteiro
total, j, aux : inteiro
x1, x2, x3: inteiro
inicio
// Seção de Comandos
escreval ("Exercício 1")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Desenvolver o Diagrama de Blocos e um Algoritmo  ")
escreval ("que leia 10 elementos do vetor A.  ")
escreval ("Depois construir o vetor B com os dados do vetor A ")
escreval ("observando a seguinte regra:")
escreval
escreval ("Se índice for PAR o valor deve ser multiplicado por 5")
escreval ("Se índice for IMPAR o valor deve ser somado com 5.")
escrevAL
escreval ("Ao final apresentar o conteúdo do vetor B")
escreval
escreval("------------------------------------------------")
escreval

PARA x1 de 1 ate 10 faca
   escreval ("informe os valores do vetor: ")
   leia (A1[x1])
fimpara

limpatela
escreval ("Exercício 2")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Desenvolver o Diagrama de Blocos e um Algoritmo ")
escreval ("que leia 5 elementos do vetor A. ")
escreval ("No final apresente o total de todos os elementos que ")
escreval ("sejam ímpares.")
escreval
escreval("------------------------------------------------")
escreval

PARA x2 de 1 ate 5 faca
   escreval ("informe os valores do vetor: ")
   leia (A2[x2])

   se (A2[x2] % 2 <> 0) entao
      total <- total + A2[x2]
   fimse
fimpara

 limpatela
escreval ("Exercício 3")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Desenvolver um Algoritmo que leia 5 elementos do ")
escreval ("vetor A.  ")
escreval ("No final apresente o Vetor A com os valores ")
escreval ("invertidos, os seja, os valores dos elementos 1 – 5 e ")
escreval ("2 – 4 devem ser trocados de posição.")
escreval
escreval("------------------------------------------------")
escreval

para x3 de 1 ate 5 faca
   escreval ("informe numero")
   leia (A3[x3])

fimpara

j <- 6

para x3 de 1 ate 5 faca
   aux <- A3[x3]
   A3[x3] <- A3[j-x3]
   A3[j-x3] <- aux

fimpara

limpatela
escreval
escreval (" --- Resultados ---")
escreval
escreval ("=== exer1 ===")
escreval

para x1 de 1 ate 10 faca
   se (A1[x1] % 2 = 0) entao
      B1[x1]  <- A1[x1]*5
      escreval ("O valor par multiplicado", B1[x1])
   senao
      B1[x1]  <- A1[x1]+5
      escreval ("o valor impar somado", B1[x1])
   fimse
fimpara

escreval
escreval ("=== exer2 ===")
escrevAL
escreval ("O valor impar", total)
escreval
escreval ("=== exer3 ===")
escreval
para x3 de 1 ate 5 faca
   escreval (" o elemento invertido de a[", x3, "]=", A3[x3])
fimpara
escreval
escreval("------------------------------------------------")
escreval









fimalgoritmo
