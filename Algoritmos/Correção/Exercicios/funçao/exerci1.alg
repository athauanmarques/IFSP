algoritmo "semnome"
// Função :
// Autor :
// Data : 21/05/2013
// Seção de Declarações 
var

A, B, C, Maior: inteiro

funcao ValorMaior (x, y, z: inteiro): inteiro

 inicio
 
Se (x>y) e (x>z) entao
retorne x

fimse

Se (y>x) e (y>z) entao
retorne y

fimse

Se (z>x) e (z>y) entao
retorne z

fimse
  fimFuncao
          inicio
// Seção de Comandos 
escreva ("A: ")
leia (A)

escreva("B: ")
leia (B)

escreva("C: ")
leia (C)

Maior <- ValorMaior (A, B, C)

Escreval ("Maior valor é ", Maior)

fimalgoritmo
