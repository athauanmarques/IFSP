algoritmo "semnome"
// Função :
// Autor :
// Data : 27/06/2013
// Seção de Declarações 
var
A: vetor [1..5] de inteiro
aux: inteiro
i, j: inteiro

inicio
para i de 1 ate 5 faca
escreval ("Digite os elemento: ", i)
leia (A[i])

fimpara

 j <- 6

       para i de 1 ate 3 faca
       aux <- A[i]
       A[i] <- A[j-i]
       A[j-i] <- aux

       fimpara

       para i de 1 ate 5 faca
            escreval (" o elemento invertido de a[", i, "]=", A[i])
                     fimpara
fimalgoritmo
