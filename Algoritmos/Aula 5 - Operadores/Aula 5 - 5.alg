algoritmo "semnome"
// Função :
// Autor :
// Data : 08/07/2013
// Seção de Declarações 
var
  salbase, gratif, salbruto, ir, salliq: real
inicio
Escreval ("informe o seu salario base: ")
leia (salbase)
escreval ("inforeme a gratificação: ")
leia (gratif)

salbruto <- salbase + gratif

se (salbruto <1000) entao
ir <- salbruto*(15/100)
senao
ir <- salbruto*(20/100)
fimse

salliq <- salbruto - ir

escreval ("seu salario liquido é: ", salliq, " R$")

fimalgoritmo
