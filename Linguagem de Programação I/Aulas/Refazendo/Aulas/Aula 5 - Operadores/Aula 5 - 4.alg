algoritmo "semnome"
// Função :
// Autor :
// Data : 08/07/2013
// Seção de Declarações 
var
h, result: real
sexo: caracter
inicio
escreval ("informe o sexo (M) ou (F): ")
leia (sexo)
escreval ("Informe altura: ")
leia (h)

se (sexo= "m") entao
result <- (72.7*h)-58
escreval ("O peso ideal Masculino é de: ", result)
senao
result <- (62.1*h)-44.7
escreval ("O peso ideal Femenino é de: ", result)
fimse


fimalgoritmo
