algoritmo "semnome"
// Função :
// Autor :
// Data : 25/06/2013
// Seção de Declarações 
var
unitario, quantiVendida, result, resultTotal: real
codigoPeca, IV: caracter
inicio
// Seção de Comandos
escreval ("Informe a identificação do vendedor: ")
leia (IV)

escreval ("Informe o codigo da peca: ")
leia (codigoPeca)

escreval ("Informe Preço unitário: ")
leia (unitario)

escreval ("Informe quantidade vendida: ")
leia (quantiVendida)

result <-(unitario * quantiVendida)
resultTotal <- (result*5/100)


escreval ("o vendedor: ", IV)
escreval ("Do Codigo da peca: ", codigoPeca)
escreval ("A comissão sera: ", resultTotal, " R$")
 
fimalgoritmo
