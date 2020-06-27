algoritmo "semnome"
// Função :
// Autor :
// Data : 26/03/2013
// Seção de Declarações 
var
c: caracter
n, he, st, salex: real

inicio

escreva ("entre com o codigo do opeerador: ")
leia (c)

escreva ("entre com o numero de horas trabalhadas: ")
leia (n)

se (n>50) entao

he<-n-50

salex<-he*20

st<-500+salex

senao (st<-n*10)

fimse

escreval (" Salario total: ", st)
escreval (" Salario excedente: ", salex)


// Seção de Comandos 
fimalgoritmo
