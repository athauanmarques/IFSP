algoritmo "Ex4 - meu"

var
   A: vetor[1..5] de inteiro

   i,maior: inteiro
   
inicio
   Para i de 1 ate 5 faca
        escreva("informe o valor ",i,": ")
        leia (A[i])
        enquanto  (A[i] < 0) faca
                  escreva("Valor NEGATIVO, favor informe um NUMERO POSITIVO: ")
                  leia (A[i])
        fimenquanto
        se (A[i] > maior) entao
           maior<-A[i]
        fimse
   fimPara
   Escreva("O maior numero POSITIVO digitado foi: ", maior)


fimalgoritmo
