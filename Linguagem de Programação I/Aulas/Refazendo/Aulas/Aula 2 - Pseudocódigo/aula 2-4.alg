algoritmo "semnome"
// Exercício aula 2 - 4
//Elabore um algoritmo para calcular o IMC. Onde:
//IMC = Peso / Altura2

var
Peso, Altura, imc: real

inicio
escreval ("Digite o peso: ")
leia (Peso)

escreval ("digite a altura:")
leia (Altura)

imc <- (Peso / Altura * Altura)

escreval ("O seu IMC é : ", imc)


fimalgoritmo
