algoritmo "semnome"
//exercicio aula 2 - 2\3
//Faça um algoritmo para “Calcular o estoque médio de uma peça”, sendo que
//ESTOQUEMÉDIO = (QUANTIDADE MÍNIMA + QUANTIDADE MÁXIMA) /2

var
QuantMin, QuantMax: inteiro
EstoqueM : real

inicio

Escreval ("Digite a Quantidade Minima: ")
leia (QuantMin)

Escreval ("Digite a quantidade maxima: ")
leia (QuantMax)

EstoqueM <- ( QuantMin+QuantMax )/2

escreval ("Estoque medio é: ", EstoqueM)


fimalgoritmo
