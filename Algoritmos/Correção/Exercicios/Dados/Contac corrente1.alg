algoritmo "semnome"
// Função :
// Autor :
// Data : 14/05/2013
// Seção de Declarações 

arquivo "C:\Users\Athauan Marques\Desktop\ADS\Algoritmos-Class\Dados\conta.txt"

var
cc,nome: caracter
total, saldo: real
numpg:inteiro
x, i, posi,inicial, final: inteiro
Cliente: vetor [1..20,1..2] de caracter
Saldos:  vetor [1..20] de real

inicio

posi <- 1

para i de 1 ate 20 faca
leia (cc)
leia(nome)
leia (saldo)

Se (saldo >= 1500) entao
cliente [posii,1] <- cc
cliente [posii,2] <- nome
Saldos[posi] <- saldo

posi <- posi+1
fimse
fimpara

posi <- posi-1

Se (posi%5=0) entao
nunmpg <- int(posi/5)
Senao
numpg <- int(posi/5)+1
fimse
 incial <- 1
 final <- 5
para i de 1 ate numpg faca
escreval (" - Relacao de cliente/Saldo..................PG", i)
escreval("")

total<- 0

para x de inicial


