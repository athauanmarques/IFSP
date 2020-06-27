algoritmo "Exercicio 5"
// Função : Calcula Salário
// Autor :
// Data : 19/03/2013
// Seção de Declarações 
var
  salBase, gratif, salBruto, salLiq, iR: Real
inicio
// Seção de Comandos 
Escreva ("Digite o seu Salário Base: ")
Leia (salBase)

Escreva ("Digite Gratificação: ")
Leia (gratif)

salBruto <- salBase + gratif

Se (salBruto < 1000) Entao
   IR <- salBruto * (15/100)
Senao
   IR <- salBruto * (20/100)
FimSe

SalLiq <- salBruto - iR

Escreval ("*******************************************")
Escreval ("O Salario Liquido é igual a: ", salLiq)

fimalgoritmo
