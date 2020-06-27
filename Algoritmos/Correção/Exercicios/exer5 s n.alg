algoritmo "semnome"
// Função :
// Autor :
// Data : 19/03/2013
// Seção de Declarações
var
salbase, gratif, salbruto,salliq , ir: real

inicio
// Seção de Comandos
escreval("salario bruto:")
leia (salbruto)
escreval ("salario gratificação:")
leia (gratif)

salbruto <- salbase + gratif

se (salbruto < 1000) entao
   ir <- salbruto * (15/100)
senao
ir <- salbruto * (20/100)
fimse

salliq <- salbruto - ir

escreva("Salario liquido = ", salliq)

fimalgoritmo
