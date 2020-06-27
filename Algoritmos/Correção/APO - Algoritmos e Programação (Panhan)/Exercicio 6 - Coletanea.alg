algoritmo "semnome"
// Função :
// Autor :
// Data : 22/3/2013
// Seção de Declarações 
var
    nome, sexo: caracter
    idade: inteiro

inicio
// Seção de Comandos
   escreva("Digite o seu nome ")
   leia(nome)
   escreva("Qual a sua idade? ")
   leia (idade)
   escreva ("Qual o seu sexo -m ou f- ")
   leia (sexo)
   
   se idade < 25  entao
      se sexo = "f" entao
          escreva ("ACEITA ",nome)
      senao
          escreva ("NÃO ACEITA")
      fimse
   senao
   escreva ("NÃO ACEITA")

   fimse
   
   

fimalgoritmo
