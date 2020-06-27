algoritmo "E:\texxte1.alg"
// Função :
// Autor :
// Data : 02/05/2013
// Seção de Declarações 

arquivo "C:\Users\Athauan Marques\Desktop\ADS\texxt.txt"

var
idade, maior, menor, qtdF, qtdM: inteiro
sexo: caracter
salario,total,media: real
i: inteiro
inicio
// Seção de Comandos 

para i de 1 ate 10 faca
     leia(idade)
     leia(sexo)
     leia(salario)
     
Se (maior < idade) entao
   maior <- idade
FimSe

Se (menor < idade) ou (i=1) entao
   qtdF <- qtdF + 1
FimSe

Se (menor > idade) ou (i=1) entao
   qtdF <- qtdF + 1
FimSe

     total <- total + salario

Se (sexo = "F") e (salario <= 100) entao
   qtdF <- qtdF + 1
fimse

Se (sexo = "M") entao
   qtdM <- qtdM + 1

   fimse
        Fimpara

media <- total/10

Escreval("a media salarial é ", media)
Escreval("A maior idade é ", maior)
Escreval("A menor idade é ", menor)
Escreval("A qtd de mulheres que recebem ate 100 e ", qtdF)
Escreval("A qtd de homens é ", qtdM)
fimalgoritmo
