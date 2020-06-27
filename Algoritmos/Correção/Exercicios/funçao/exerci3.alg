algoritmo "semnome"
// Função :
// Autor :
// Data : 21/05/2013
// Seção de Declarações 
var
n1,n2, mp,ns, media: real

funcao media (x, y: real): real

inicio notan1 (nota: real); real

retorne (x + y*2)/3
fimfuncao

inicio

Escreval ("digite nota 1: ")
leia (n1)

Escreval ("digite nota 2: ")
leia (n2)

mp <- media (n1, n2)

se (mp < 6) entao
     se (n1 < n2)
      ns <- notan1 (n2)
     senao
     ns <- notan2 (n1)
            fimse
            
            escreval ("Nota sugeria ", ns)
            
            fimse

fimalgoritmo
