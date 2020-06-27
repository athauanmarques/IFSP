algoritmo "semnome"
// Função :
// Autor :
// Data : 21/05/2013
// Seção de Declarações 
var

x, y: inteiro
res: inteiro

funcao elevado (a,b: inteiro): inteiro

 var i, valor: inteiro

inicio
      valor <- 1
      para i de 1 ate b faca
      valor <- valor * a
fimpara

 retorne valor
 
 fimfuncao
inicio

escreva ("x: ")
leia (x)

escreva ("y: ")
leia(y)

res <- elevado (x, y)

escreval("Res", res)
// Seção de Comandos 
fimalgoritmo
