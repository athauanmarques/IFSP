algoritmo "Exerc 4 12/03"

var
       nome: caracter
       salAtual, vlrReajuste, salNovo: real
       

inicio
// Entrada de Dados

Escreva ("Digite o Nome ")
Leia (nome)
Escreva ("Digite o salario Atual ")
Leia (salAtual)


// Processamento
vlrReajuste <- 0.15 * salAtual

salNovo <- vlrReajuste + salAtual
// Saida de Dados

Escreva ("O valor do salario novo é igual a " , salNovo)

fimalgoritmo
