algoritmo "semnome"
// Função :
// Autor :
// Data : 04/07/2013
// Seção de Declarações 
var
Reajuste, atualSal, Salnovo: real
nome : caracter
custoC, custoFabrica: real
aux, A, B: inteiro
N1, N2, mediafinal: real
soma, V1, V2, produto, quociente: real

inicio
// Seção de Comandos
escreval ("Exercício 4")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Sabendo-se que José tem direito a 15% de reajuste de salário ")
escreval  ("Faça um algoritmo que permita ler os seguinter termos: ")
escreval
escreval ("Leia o nome")
escreval ("Leia o salario atual")
escreval ("Mostre o resultado")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Informe o nome: ")
leia (nome)

escreval ("informe o seu salario atual: ")
leia (atualSal)

Reajuste <- 1.15

Salnovo <- atualSal * Reajuste

escreval (nome ," - o seu salario novo é : ", Salnovo, " R$")

limpatela
escreval ("Exercício 5")
escreval
escreval("------------------------------------------------")
escreval
escreval ("O custo ao consumidor de um carro novo é a soma")
escreval ("do custo de fábrica com a percentagem do")
escreval ("distribuidor e dos impostos (aplicados, primeiro os")
escreval ("impostos sobre o custo de fábrica, e depois a")
escreval ("impostos sobre o custo de fábrica, e depois a")
escreval ("Supondo que a percentagem do distribuidor seja de")
escreval ("28% e os impostos 45 %. Escrever uma algoritmo")
escreval ("que leia o custo de fábrica de um carro e informe o")
escreval ("custo ao consumidor")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Informe o custo de fabrica: ")
leia (custoFabrica)

custoC <- custoFabrica*1.28*1.45

escreval ("O custo ao consumidor é de: ", custoC, " R$")

limpatela
escreval ("Exercício 6")
escreval
escreval("------------------------------------------------")
escreval
escreval("Ler dois valores para as variáveis A e B, e efetuar as")
escreval("trocas dos valores de forma que a variável A passe a")
escreval("possuir o valor da variável B e a variável B passa a")
escreval("possuir o valor da variável A. Apresentar os valores")
escreval("trocados.")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Digite o valor de A ")
leia (A)
escreval ("Digte o valor de B ")
leia (B)

aux <- A
A <- B
B <- aux

limpatela

escreval ("Exercício 7")
escreval
escreval("------------------------------------------------")
escreval
escreval("escreva um Algoritmo que leia duas notas de um ")
escreval("aluno, calcule e escreva a média final deste aluno. ")
escreval("Considerar que a média é ponderada e que o peso ")
escreval("das notas é 3 e 7. Fórmula para o cálculo da média ")
escreval("final é: ")
escreval
escreval("                   n1 * 3 + n2 * 7")
escreval("mediafinal = ----------------------------")
escreval("                           10")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Digite a 1ª nota: ")
leia (N1)
escreval ("digite a 2ª nota: ")
leia (N2)

  mediafinal <- (N1*3+N2*7)/10
  
   limpatela
escreval ("Exercício 8")
escreval
escreval("------------------------------------------------")
escreval
escreval("escreva um Algoritmo que leia dois valores reais ")
escreval("do teclado, calcule e imprima na tela: ")
escreval
escreval("a) A soma destes valores")
escreval("b) O produto deles")
escreval("c) O quociente entre eles")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Digite o 1ª valor: ")
leia (V1)
escreval ("Digite o 2ª valor: ")
leia (V2)

soma <- V1+V2
produto <- V1*V2
quociente <- V1/V2
       limpatela
escreval (" --- Resultados ---")
escreval
escreval ("=== exer4 ===")
escreval (nome ," - o seu salario novo é : ", Salnovo, " R$")
escreval
escreval ("=== exer5 ===")
escreval ("O custo ao consumidor é de: ", custoC, " R$")
escreval
escreval ("=== exer6 ===")
escreval (" A Vale: ", A)
escreval ("B Vlae: ", B)
escreval
escreval ("=== exer7 ===")
escreval ("Media final: ", mediafinal)
escreval
escreval ("=== exer8 ===")
escreval ("a soma é : ", soma)
escreval ("o produto : ", produto)
escreval ("quociente : ", quociente)
escreval
escreval("------------------------------------------------")
escreval
fimalgoritmo
