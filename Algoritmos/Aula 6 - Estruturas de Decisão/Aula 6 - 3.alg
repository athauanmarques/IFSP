algoritmo "semnome"
// Função :
// Autor :
// Data : 10/07/2013
// Seção de Declarações 
var
n1, n2, n3, n4: inteiro
r1, r2, r3, r4 : real
inicio
escreval ("Digite valor n1: ")
leia (n1)
escreval ("Digite valor n2: ")
leia (n2)
escreval ("Digite valor n3: ")
leia (n3)
escreval ("Digite valor n4: ")
leia (n4)

r1 <- n1*n1
r2 <- n2*n2
r3 <- n3*n3
r4 <- n4*n4

se (r3>1000) entao
escreval
escreval ("o valor do terceiro foi: ", r3)
senao
escreval
escreval ("n1 ao quadrado: ", r1)
escreval ("n2 ao quadrado: ", r2)
escreval ("n3 ao quadrado: ", r3)
escreval ("n4 ao quadrado: ", r4)
fimse
fimalgoritmo
