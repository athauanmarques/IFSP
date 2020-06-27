algoritmo "semnome"
// Função :
// Autor :
// Data : 19/03/2013
// Seção de Declarações 
var
  Altura, Peso: Real
  Sexo: Caractere
inicio
// Seção de Comandos 
Escreval ("**********PESO IDEAL**********")
Escreval ("Digite a sua altura: ")
Leia (Altura)
Escreval ("Digite seu Sexo..M ou F: ")
Leia (Sexo)

Se (Sexo = "M")Entao
peso <- 72.7 * Altura - 58
Senao
peso <- 62.1 * Altura - 44.7

FimSe

Escreval ("*************************")
Escreval ("O seu peso ideal é: ",Peso)
fimalgoritmo
