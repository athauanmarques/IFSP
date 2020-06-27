algoritmo "semnome"
// Função :
// Autor :
// Data : 05/05/2013
// Seção de Declarações
var
VetorQ: vetor [1..5] de inteiro
i: inteiro
maior: inteiro
Cara: caractere

inicio
// Seção de Comandos

para i de 1 ate 5 faca
   Escreval ("digite 20 posiçoes: ")
   leia (VetorQ[i])

   Enquanto VetorQ[i]<0 faca
      Escreval ("Numero Negado, digite uma posiçao positivo")
      leia (VetorQ[i])
      
      fimenquanto
      fimpara

para i de 1 ate 5 faca
   se (VetorQ[i]>maior) entao
      maior<-VetorQ[i]
   fimse


fimpara


            escreval("O maior posição é: ", maior)



fimalgoritmo
