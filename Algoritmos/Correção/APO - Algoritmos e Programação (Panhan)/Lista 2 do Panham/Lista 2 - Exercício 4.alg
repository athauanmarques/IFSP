algoritmo "Exercício 4 da Lista 2"

var
   n1,n2,n3:caractere
   i1,i2,i3:inteiro
inicio
   escreva("Digite o Nome1: ")
   leia(n1)
   escreval("Qual a Idade1? ")
   leia(i1)
   escreval("Digite o Nome2: ")
   leia(n2)
   escreval("Qual a Idade2? ")
   leia(i2)
   escreval("Digite o Nome3: ")
   leia(n3)
   escreval("Qual a Idade3? ")
   leia(i3)
   
   se i1>i2 entao
      se i1>i3 entao
      escreval("O nome da pessoa mais velha é: ",n1)
      fimse
   fimse
   
   se i1<i2 entao
      se i1<i3 entao
      escreval("O nome da pessoa mais nova é: ",n1)
      fimse
   fimse
   //conferir daki pra baixo OK
   se i2>i1 entao
      se i2>i3 entao
      escreval("O nome da pessoa mais velha é: ",n2)
      fimse
   fimse

   se i2<i1 entao
      se i2<i3 entao
      escreval("O nome da pessoa mais nova é: ",n2)
      fimse
   fimse
   //conferir daki pra baixo  OK
   se i3>i1 entao
      se i3>i2 entao
      escreval("O nome da pessoa mais velha é: ",n3)
      fimse
   fimse

   se i3<i1 entao
      se i3<i2 entao
      escreval("O nome da pessoa mais nova é: ",n3)
      fimse
   fimse
   
   fimalgoritmo
   

