algoritmo "semnome"
// Função :
// Autor :
// Data : 25/06/2013
// Seção de Declarações 
var
nome: caracter
salarioAtual, reajuste, valorReajuste, salnovo: real

inicio
// Seção de Comandos 
escreval ("informe o nome: ")
leia (nome)
escreval ("informe salario atual: ")
leia (salarioAtual)

valorReajuste <- salarioAtual * 0.15
salnovo <- valorReajuste + salarioAtual

escreval ("Senhor(a) : ", nome, " - novo salario: ", salnovo, " R$")



fimalgoritmo
