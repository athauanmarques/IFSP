algoritmo "semnome"
// Função :
// Autor :
// Data : 25/06/2013
// Seção de Declarações 
var
cotacao, dolares, resultReal: real
n1, n2, n3, n4: inteiro
r1, r2, r3, r4, soma: real
iv, codigo: caracter
preco, vendida, resultVendas: real

inicio
escreval ("Exercício 1")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Construa um diagrama de blocos que :")
escreval
escreval ("Leia a cotação do dólar")
escreval ("Leia um valor em dólares")
escreval ("Converta esse valor para Real")
escreval ("Mostre o resultado")
escreval
escreval("------------------------------------------------")
escreval
escreva ("informe a cotação do dólar: ")
leia (cotacao)
escreva ("informe o valor do dólares: ")
leia (dolares)

resultReal <- cotacao/dolares


limpatela
escreval ("Exercício 2")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Desenvolva um diagrama que: :")
escreval
escreval ("Leia 4 (quatro) números")
escreval ("Calcule o quadrado para cada um")
escreval ("Somem todos e")
escreval ("Mostre o resultado")
escreval
escreval("------------------------------------------------")
escreval
escreva (" digite nª 1: ")
leia (n1)
escreva (" digite nª 2: ")
leia (n2)
escreva (" digite nª 3: ")
leia (n3)
escreva (" digite nª 4: ")
leia (n4)

r1 <- (n1*n1)
r2 <- (n2*n2)
r3 <- (n3*n3)
r4 <- (n4*n4)

soma <- (r1+r2+r3+r4)

limpatela
escreval ("Exercício 3")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Construa um algoritmo para pagamento de comissão de ")
escreval ("vendedores de peças, levando-se em consideração que sua ")
escreval ("comissão será de 5% do total da venda e que você tem os ")
escreval ("seguintes dados:")
escreval
escreval ("Identificação do vendedor")
escreval ("Código da peça")
escreval ("Preço unitário da peça")
escreval ("Quantidade vendida")
escreval
escreval("------------------------------------------------")
escreval
escreva ("informe a identificação do vendedor: ")
leia (iv)
escreva ("informe codigo da peca: ")
leia (codigo)
escreva ("informe o preco da peca: ")
leia (preco)
escreval ("inforeme a quantidade vendida: ")
leia (vendida)

resultVendas <-  (preco*vendida)*5/100
limpatela
escreval ("Resultados")
escreval
escreval ("=== exer1 ===")
escreva ("valor em reais - ", resultReal, " R$")
escreval
escreval ("=== exer2 ===")
escreval("o resultado é : ", soma)
escreval
escreval ("=== exer3 ===")
escreval ("o resultado da comissão é:  ", resultVendas, " R$")
escreval
fimalgoritmo
