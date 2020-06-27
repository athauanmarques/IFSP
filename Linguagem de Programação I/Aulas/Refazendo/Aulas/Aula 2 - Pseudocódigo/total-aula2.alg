algoritmo "semnome"
// Função :
// Autor :
// Data : 24/06/2013
// Seção de Declarações
var
//exer1
CodigoPeca : Caracter
QuantPeca, ValorPeca, ResultPeca: inteiro
//exer2
QuantMin, QuantMax, EstoqueMedio: real
//exer3
imc, peso, altura: real

inicio
     escreval("Exercicio 1")
     escreval
 escreval("-----------------------------------------------------------------")
 escreval
escreval ("Identifique os dados de entrada, processamento e saída no algoritmo abaixo: ")
escreval
escreval ("Receba código da peça")
escreval ("Receba valor da peça")
escreval ("Receba Quantidade de peças")
escreval ("Calcule o valor total da peça (Quantidade * Valor da peça)")
escreval ("Mostre o código da peça e seu valor total")
escreval
escreval("-----------------------------------------------------------------")
escreval

//---------------- exer1 ---------------------------

escreval ("Digite Codigo da peca: ")
leia (CodigoPeca)

escreval ("Digite Valor da peca: ")
leia (ValorPeca)

escreval ("Digite quantidade de pecas: ")
leia (QuantPeca)

ResultPeca <- (QuantPeca * ValorPeca)
    limpatela
escreval
escreval(" Exercício 2 ")
escreval
escreval("-----------------------------------------------------------------")
escreval
escreval ("Faça um algoritmo para “Calcular o estoque médio de uma peça”, sendo que: ")
escreval ("")
escreval ("ESTOQUEMÉDIO = (QUANTIDADE MÍNIMA + QUANTIDADE MÁXIMA) /2)")
escreval
escreval("-----------------------------------------------------------------")
escreval

//---------------- exer2 ---------------------------

escreval ("Digite quantidade Minima: ")
leia (QuantMin)

escreval ("Digite Quantidade Maxima: ")
leia (QuantMax)

EstoqueMedio <- ( QuantMin+QuantMax ) /2
             limpatela
escreval
escreval ("Exercício 4")
escreval
escreval("-----------------------------------------------------------------")
escreval
escreval ("Elabore um algoritmo para calcular o IMC. Onde: ")
escreval
escreval ("IMC = Peso / Altura2")
escreval
escreval("-----------------------------------------------------------------")
escreval
escreval ("digite peso: ")
leia (peso)

escreval ("digite altura: ")
leia (altura)

imc <- (peso / altura * altura)

limpatela
escreval("Resultados")
escreval
escreval("-----------------------------------------------------------------")
escreval
escreval ("Codigo da Peca: " , CodigoPeca, " - Valor", ResultPeca, " R$")
escreval
escreval ("Estoque médio é: ", EstoqueMedio)
escreval
escreval ("o seu imc é: ", imc)
escreval
escreval("-----------------------------------------------------------------")


fimalgoritmo
