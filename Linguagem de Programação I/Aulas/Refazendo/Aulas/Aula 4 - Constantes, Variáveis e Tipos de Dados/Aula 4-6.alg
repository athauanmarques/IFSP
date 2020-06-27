algoritmo "semnome"
// Função :
// Autor :
// Data : 30/06/2013
// Seção de Declarações 
var
ValorA, ValorB, aux: inteiro

inicio
// Seção de Comandos 
escreva ("Informe Valor de A: ")
leia (ValorA)
escreva ("Informe Valor de B: ")
leia (ValorB)

aux <- ValorA
ValorA <- ValorB
ValorB <- aux

escreval ("Valor trocado de A: ", ValorA)
escreval ("Valor trocado de B: ", ValorB)

fimalgoritmo
