algoritmo "semnome"
//Exer aula 2-1
//Identifique os dados de entrada, processamento e saída no algoritmo abaixo:
//Receba código da peça
//Receba valor da peça
//Receba Quantidade de peças
//Calcule o valor total da peça (Quantidade * Valor da peça)
//Mostre o código da peça e seu valor total
var
ValorPeca, QuantPeca, result: inteiro
codigoPeca : Caracter

inicio
// Seção de Comandos 
escreval ("Digite codigo da peca: ")
leia (codigoPeca)

escreval ("Digite o Valor da Peca ")
leia (ValorPeca)

escreval ("Digite a quantidade de peca:  ")
leia (QuantPeca)

result<-(QuantPeca*ValorPeca)

  escreval ("o valor é ", result, " r$ - codigo da peca: ", codigoPeca)
fimalgoritmo
