algoritmo "semnome"
// Função :
// Autor :
// Data : 08/07/2013
// Seção de Declarações 
var
a, b, n: inteiro
numero, I, P, N2: inteiro
sexo: caracter
ideal, h: real
salbase, gratif, salbruto, ir, salliq: real
inicio

escreval ("Exercício 1")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Elabore um diagrama de blocos que leia um número.")
escreval ("Se positivo armazene-o em A, se for negativo, em B")
escreval ("No final mostrar o resultado")
escreval
escreval("------------------------------------------------")
escreval
escreval ("informe numero: ")
leia (n)

limpatela
 
 escreval ("Exercício 2")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Ler um número e verificar se ele é par ou ímpar. ")
escreval ("Quando for par armazenar esse valor em P e ")
escreval ("quando for ímpar armazená-lo em I. Exibir P e I no ")
escreval ("final do processamento.")
escreval
escreval("------------------------------------------------")
escreval
escreval ("informe numero: ")
leia (numero)

limpatela


escreval ("Exercício 3")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Ler um número e verificar se ele é par ou ímpar. ")
escreval ("Quando for par armazenar esse valor em P e ")
escreval ("quando for ímpar armazená-lo em I. Exibir P e I no ")
escreval ("final do processamento.")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Digite o valor de N")
leia (N2)
limpatela

escreval ("Exercício 4")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Tendo como dados de entrada a altura e o sexo de  ")
escreval ("uma pessoa, construa um algoritmo que calcule seu ")
escreval ("peso ideal, utilizando as seguintes fórmulas:")
escreval
escreval ("Para homens: (72.7*h) - 58")
escreval ("Para mulheres: (62.1*h) - 44.7 ")
escreval
escreval ("(h = altura)")
escreval
escreval("------------------------------------------------")
escreval
escreval ("informe o sexo (M) ou (F): ")
leia (sexo)

escolha sexo
        caso "m"
        escreval ("informe altura: ")
        leia (h)
        ideal <- (72.7*h)-58
        escreval ("O peso ideal é: ", ideal)

        caso "f"
        escreval ("informe altura: ")
        leia (h)
        ideal <- (62.1*h)-44.7
        escreval ("o peso idea é: ", ideal)
        outrocaso
        ("variavel não conforme")
        fimescolha

limpatela

escreval ("Exercício 5")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Faça um algoritmo de acordo com os dados ")
escreval ("exibido no diagrama de blocos feito da aula 5")
escreval ("Do exercicio 5")
escreval
escreval("------------------------------------------------")
escreval

Escreval ("informe o seu salario base: ")
leia (salbase)
escreval ("inforeme a gratificação: ")
leia (gratif)

salbruto <- salbase + gratif

se (salbruto <1000) entao
ir <- salbruto*(15/100)
senao
ir <- salbruto*(20/100)
fimse

salliq <- salbruto - ir
      limpatela

escreval (" --- Resultados ---")
escreval
escreval ("=== exer1 ===")
Se (n>0) entao
a <- n
escreval ("é positivo", a)
senao
b <-n
escreval ("é negativo", b)
fimse
escreval
escreval ("=== exer2 ===")
Se (numero%2 = 0) entao
P <- numero
escreval("é par: ", P)
senao
I <- numero
escreval ("é impar: ", I)
fimse
escreval
escreval ("=== exer3 ===")
Se (N2>100) entao
escreval ("N é maior que 100, o valor dado: ", N2)
senao
escreval ("0")
fimse
escreval
escreval ("=== exer4 ===")
escreval ("O peso ideal é: ", ideal)
escreval
escreval ("=== exer5 ===")
escreval ("seu salario liquido é: ", salliq, " R$")
escreval
escreval("------------------------------------------------")
escreval
fimalgoritmo


