algoritmo "semnome"
// Função :
// Autor :
// Data : 22/07/2013
// Seção de Declarações 
var
nx, maior, casa, contagem: inteiro
graotrigo : real
inicio
// Seção de Comandos
escreval ("Exercício 1")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Faça um algoritmo que determine o maior entre N ")
escreval ("números. A condição de parada é a entrada de um ")
escreval ("valor 0, ou seja, o algoritmo deve ficar calculando o ")
escreval ("maior até que a entrada seja igual a 0 (ZERO).")
escreval
escreval("------------------------------------------------")
escreval

nx <- 1
 enquanto (nx<>0) faca
escreval ("Informe o valor")
leia (nx)
 se (nx>=maior) entao
   maior<-nx
  fimse
  fimenquanto

escreval ("Exercício 2")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Uma rainha requisitou os serviços de um monge e")
escreval ("disse-lhe que pagaria qualquer preço. O monge, ")
escreval ("necessitando de alimentos , inganou à rainha sobre o ")
escreval ("pagamento, se poderia ser feito com grãos de trigo ")
escreval ("dispostos em um tabuleiro de xadrez, de tal forma ")
escreval ("que o primeiro quadro deveria conter apenas um grão ")
escreval ("e os quadros subsequentes , o dobro do quadro ")
escreval ("anterior. A rainha achou o trabalho barato e pediu ")
escreval ("que o serviço fosse executado, sem se dar conta de ")
escreval ("que seria impossível efetuar o pagamento. Faça um ")
escreval ("algoritmo para calcular o número de grãos que o ")
escreval ("monge esperava receber.")
escreval
escreval("------------------------------------------------")
escreval

graotrigo <- 1

para casa de 1 ate 62 faca
graotrigo <- graotrigo*2
fimpara

escreval ("Exercício 3")
escreval
escreval("------------------------------------------------")
escreval
escreval ("Faça um algoritmo que conte de 1 a 100 e a cada ")
escreval ("múltiplo de 10 emita uma mensagem: “Múltiplo de 10”")
escreval
escreval("------------------------------------------------")
escreval

  escreval (" --- Resultados ---")
escreval
escreval ("=== exer1 ===")
escreval
  escreval ("O maior numero foi: ", maior)
escreval
escreval ("=== exer2 ===")
escrevAL
escreval ("o numero de grãos de trigo foi: ", graotrigo)
escreval
escreval ("=== exer3 ===")
escreval
para contagem de 1 ate 100 faca
escreval ("múltiplo de 10 - ", contagem)
contagem <- contagem*10
fimpara
escreval
escreval("------------------------------------------------")
escreval
 
fimalgoritmo
