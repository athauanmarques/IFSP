algoritmo "semnome"
// Função :
// Autor :
// Data : 12/06/2013
// Seção de Declarações 
var

   jogo: Vetor [1..5,1..5] de Caracter
   jogador, jogar, opcao, l, c, campeao, empate, op, auxc, aux1, aux2, aux3, aux4, aux5: Inteiro
   jogador1, jogador2, i, menu: Caracter
   comece : caracter

   // Sub-programa do Sobre (é o Conteúdo do jogo)

 procedimento SobreMenu
       inicio
   limpatela
Escreval ("                                   ")
eSCREVAL ("=====================================================")
ESCREVAL ("================== *** |LIG 5|*** ===================")
ESCREVAL ("================================(Versão - 1.0)=======")
ESCREVAL ("=====================================================")
ESCREVAL ("")
eSCREVAL ("           Athauan Marques   -    136246-1            ")
Escreval
eSCREVAL ("           Patrick Reis      -    136223-2              ")
Escreval
Escreval ("           Paulo Roberto     -    136226-7                       ")
Escreval
Escreval ("           Otávio Sávio      -    136248-8               ")
 ESCREVAL("")
ESCREVAL ("===============================| 02/06/2013 |========")
   escreval
Escreval("========== Digite (0) para volta ao Menu ============")
ESCREVAL("                    ")
       leia (op)
       Enquanto (op <> 0) faca
       Escreval ("Erro! Digite o valor (0) para volta ao Menu")
       leia (op)
       fimenquanto

fimprocedimento

inicio

// Apresentação inicial com animação


               timer 500
               timer 0
               Escreval ("                                                     ")
               escreval ("         _____                                        " )
               Escreval ("  _lIG5_| |_| \___                                             ")
               escreval (" |____------- ____|                                       ")
               Escreval ("     (__)    (__)                              ")
               Escreval ("                                                       ")
               timer 500
               timer 0
               LIMPATELA
                   Escreval ("                                                     ")
               escreval ("              _____                                        " )
               Escreval ("       _lIG5_| |_| \___                                             ")
               escreval ("      |____------- ____|                                       ")
               Escreval ("          (__)    (__)                              ")
               Escreval ("                                                       ")
               timer 500
               timer 0
               LIMPATELA
                   Escreval ("                                                     ")
               escreval ("                   _____                                        " )
               Escreval ("            _lIG5_| |_| \___                                             ")
               escreval ("           |____------- ____|                                       ")
               Escreval ("              (__)    (__)                              ")
               Escreval ("                                                     ")
               timer 500
               timer 0
               LIMPATELA
                      Escreval ("                                                     ")
               escreval ("                          _____                                        " )
               Escreval ("                   _lIG5_| |_| \___                                             ")
               escreval ("                  |____------- ____|                                       ")
               Escreval ("                     (__)    (__)                              ")
               Escreval ("                                                       ")
               timer 500
               timer 0
               LIMPATELA
               Escreval ("                                                     ")
               escreval ("                                 _____                                        " )
               Escreval ("                          _lIG5_| |_| \___                                             ")
               escreval ("                         |____------- ____|                                       ")
               Escreval ("                            (__)    (__)                              ")
               Escreval ("                                                    ")
               timer 500
               timer 0
                 LIMPATELA
               Escreval ("                                                     ")
               escreval ("                                      _____                                        " )
               Escreval ("                               _lIG5_| |_| \___                                             ")
               escreval ("                              |____------- ____|                                       ")
               Escreval ("                                 (__)    (__)                              ")
               Escreval ("                                                       ")
               timer 500
               timer 0
               LIMPATELA
                Escreval ("                                                     ")
               escreval ("                                          _____                                         " )
               Escreval ("                                   _lIG5_| |_| \___                                            ")
               escreval ("                                  |____------- ____|                                      ")
               Escreval ("                                     (__)    (__)                              ")
               Escreval ("                                                       ")
               timer 500
               timer 0
               limpatela
                Escreval ("                                                     ")
               escreval ("                                             _____                                        " )
               Escreval ("                                      _lIG5_| |_| \___                                          ")
               escreval ("                                     |____------- ____|                                   ")
               Escreval ("                                        (__)    (__)                           ")
               Escreval ("                                                                       ")
               timer 500
               timer 0
               limpatela
                Escreval ("                                                     ")
               escreval ("                                                       _____                                        " )
               Escreval ("                                                _lIG5_| |_| \___                                             ")
               escreval ("                                               |____------- ____|                                       ")
               Escreval ("                                                  (__)    (__)                              ")
               Escreval ("                                                       ")
            timer 300

  LIMPATELA
  eSCREVAL
  eSCREVAL
  escreval
  escreval
  eSCREVAL("                            _      _  ____   __ ")
  eSCREVAL("                           | |    |\||  __| |  |")
  eSCREVAL("                           | |___ |/|| |_ | |__ ")
  eSCREVAL("  	                   |_____||_||____|  __)")
  eSCREVAL			
    timer 0
    
   // Menu Principal
   
              Enquanto (opcao = 0) faca
                LIMPATELA
  eSCREVAL
  eSCREVAL
  escreval
  escreval
  eSCREVAL("                            _      _  ____   __ ")
  eSCREVAL("                           | |    |\||  __| |  |")
  eSCREVAL("                           | |___ |/|| |_ | |__ ")
  eSCREVAL("  	                   |_____||_||____|  __)")
  eSCREVAL
               escreval ("                       ____________________________                               ")
               Escreval ("                      |                            | ")
               Escreval("                      | ***** Menu Principal ***** |")
               Escreval ("                      |                            |    ")
               Escreval("                      |       1 - Novo Jogo        |")
               Escreval("                      |       2 - Sobre            |")
               Escreval("                      |       3 - Sair             |")
               Escreval("                      ______________________________      ")
               Escreval ("                                                          ")
               EscrevaL("                     === Escolha a opcao desejada === ")
               escreva ("                                     ")
               Leia(op)

               Escolha op
                       caso (1)
                       menu <- "-> Novo Jogo <-"
                       caso (2)
                       SobreMenu
                       caso (3)
                       menu <- "Sair:"
                       outrocaso
                       menu <- "Opcao nao existe!!!"
               FimEscolha

               Se (op = 1) Entao
                  jogar <- 1
                  opcao <- 1
                  Escreval(menu)
                  Escreval("")
               Senao
                    Se (op = 3) Entao
                       jogar <- 0
                       opcao <- 1
                    senao
                         Se (op > 3) ou (op < 1) Entao
                            Limpatela
                            opcao <- 0
                            Escreval(menu)
                            Escreval("")
                         senao
                              Se (op = 2) Entao
                                 Limpatela
                                 opcao <- 0
                                 Escreval(menu)
                              Fimse
                         Fimse
                    Fimse
               Fimse
      FimEnquanto

      //******************************************************************************
//Entrar com os nomes dos Jogadores
         Se (jogar = 1) Entao
            Escreva("Informe o nome do jogador 1: ")
            Leia(jogador1)
            Escreva("Informe o nome do jogador 2: ")
            Leia(jogador2)
         Fimse
//******************************************************************************
//Inicio do Jogo
         jogador <- 1
         Limpatela
//Recebe os valores dentro da matriz
         Para l de 1 ate 5 faca
              Para c de 1 ate 5 faca
                   jogo[l,c] <- " "
              Fimpara
         Fimpara
                Enquanto (jogar = 1) faca
                         Limpatela
                         Escreval(" ***** Jogo Lig5 *****")
                         Escreval(" | 1 | 2 | 3 | 4 | 5 |")
                         Escreval(" ---------------------")

                         Para l de 1 ate 5 faca
                              Para c de 1 ate 5 faca
                                   Escreva(" | ", jogo[l,c])
                              Fimpara
                              Escreval(" |")
                              Escreval(" ---------------------")
                         Fimpara
//Verifica se tem algum campeão no jogo
                         Se (campeao = 1) e (jogar = 1) Entao
                            jogar <- 0
                            opcao <- 0
                            l <- 7
                            c <- auxc
                         Fimse
//Inicia o jogo com jogador 1 informando a coluna
                         Se (jogador = 1) e (opcao = 1) Entao
                            Escreval ("Vez jogador 1:",jogador1)
                            Escreva ("Informe a coluna: ")
                            Leia(c)
//Verifica se a coluna informada nao esta completa e se a mesma existe na matriz
                            Enquanto (c=1) e (aux1>=5) ou (c>5) ou (c<1) faca
                                     Escreval ("ERRO AO INFORMAR O NUMERO DA COLUNA!!!")
                                     Escreval ("")
                                     Escreva ("Informe novamente a coluna: ")
                                     Leia(c)
                            Fimenquanto

                            Enquanto (c=2) e (aux2>=5) ou (c>5) ou (c<1) faca
                                     Escreval ("ERRO AO INFORMAR O NUMERO DA COLUNA!!!")
                                     Escreval ("")
                                     Escreva ("Informe novamente a coluna: ")
                                     Leia(c)
                            Fimenquanto

                            Enquanto (c=3) e (aux3>=5) ou (c>5) ou (c<1) faca
                                     Escreval ("ERRO AO INFORMAR O NUMERO DA COLUNA!!!")
                                     Escreval ("")
                                     Escreva ("Informe novamente a coluna: ")
                                     Leia(c)
                            Fimenquanto

                            Enquanto (c=4) e (aux4>=5) ou (c>5) ou (c<1) faca
                                     Escreval ("ERRO AO INFORMAR O NUMERO DA COLUNA!!!")
                                     Escreval ("")
                                     Escreva ("Informe novamente a coluna: ")
                                     Leia(c)
                            Fimenquanto

                            Enquanto (c=5) e (aux5>=5) ou (c>5) ou (c<1) faca
                                     Escreval ("ERRO AO INFORMAR O NUMERO DA COLUNA!!!")
                                     Escreval ("")
                                     Escreva ("Informe novamente a coluna: ")
                                     Leia(c)
                            Fimenquanto

                            i <- "x"
                            auxc <- c
                            jogador <- 2
//Vez do Jogador 2 informar a coluna
                         Senao
                              Se (jogador = 2) e (opcao = 1) Entao
                                 Escreval ("Vez jogador 2:", jogador2)
                                 Escreva ("Informe a coluna: ")
                                 Leia(c)
//Verifica se a coluna informada nao esta completa e se a mesma existe na matriz
                                 Enquanto (c=1) e (aux1>=5) ou (c>5) ou (c<1) faca
                                          Escreval ("ERRO AO INFORMAR O NUMERO DA COLUNA!!!")
                                          Escreval ("")
                                          Escreva ("Informe novamente a coluna: ")
                                          Leia(c)
                                 Fimenquanto

                                 Enquanto (c=2) e (aux2>=5) ou (c>5) ou (c<1) faca
                                          Escreval ("ERRO AO INFORMAR O NUMERO DA COLUNA!!!")
                                          Escreval ("")
                                          Escreva ("Informe novamente a coluna: ")
                                          Leia(c)
                                 Fimenquanto

                                 Enquanto (c=3) e (aux3>=5) ou (c>5) ou (c<1) faca
                                          Escreval ("ERRO AO INFORMAR O NUMERO DA COLUNA!!!")
                                          Escreval ("")
                                          Escreva ("Informe novamente a coluna: ")
                                          Leia(c)
                                 Fimenquanto

                                 Enquanto (c=4) e (aux4>=5) ou (c>5) ou (c<1) faca
                                          Escreval ("ERRO AO INFORMAR O NUMERO DA COLUNA!!!")
                                          Escreval ("")
                                          Escreva ("Informe novamente a coluna: ")
                                          Leia(c)
                                 Fimenquanto

                                 Enquanto (c=5) e (aux5>=5) ou (c>5) ou (c<1) faca
                                          Escreval ("ERRO AO INFORMAR O NUMERO DA COLUNA!!!")
                                          Escreval ("")
                                          Escreva ("Informe novamente a coluna: ")
                                          Leia(c)
                                 Fimenquanto

                                 i <- "o"
                                 auxc <- c
                                 jogador <- 1
                              Fimse
                         Fimse
//Subtrai a linha menos o numero de vezes que a mesma coluna for escolhida
                         Se (auxc = 1) Entao
                            aux1 <- aux1 + 1
                            l <- l-aux1
                         senao
                              Se (auxc = 2) Entao
                                 aux2 <- aux2 + 1
                                 l <- l-aux2
                              senao
                                   Se (auxc = 3) Entao
                                      aux3 <- aux3 + 1
                                      l <- l-aux3
                                   senao
                                        Se (auxc = 4) Entao
                                           aux4 <- aux4 + 1
                                           l <- l-aux4
                                        senao
                                             Se (auxc = 5) Entao
                                                aux5 <- aux5 + 1
                                                l <- l-aux5
                                             Fimse
                                        Fimse
                                   Fimse
                              Fimse
                         Fimse
//Matriz jogo recebe o valor de I (O ou X)
                         jogo[l,c] <- i
//Verifica as linhas na matriz se com o valor recebido pode ter campeao
                         Se (jogo[l,5] = "x") e (jogo[l,4] = "x") e (jogo[l,3] = "x") e(jogo[l,2] = "x") e (jogo[l,1] = "x") Entao
                            campeao <- 1
                            Escreval("")
                            Escreval("Parabéns ", jogador1, " você é o Campeão!!!")
                         senao
                              Se (jogo[l,5] = "o") e (jogo[l,4] = "o") e (jogo[l,3] = "o") e(jogo[l,2] = "o") e (jogo[l,1] = "o") Entao
                                 campeao <- 1
                                 Escreval("")
                                 Escreval ("Parabéns ", jogador2, " você é o Campeão!!!")
                              Fimse
                         Fimse
//Verifica as colunas na matriz se com o valor recebido pode ter campeao
                         Se (jogo[5,c] = "x") e (jogo[4,c] = "x") e (jogo[3,c] = "x") e(jogo[2,c] = "x") e (jogo[1,c] = "x") Entao
                            campeao <- 1
                            Escreval("")
                            Escreval("Parabéns ", jogador1, " você é o Campeão!!!")
                         senao
                              Se (jogo[5,c] = "o") e (jogo[4,c] = "o") e (jogo[3,c] = "o") e(jogo[2,c] = "o") e (jogo[1,c] = "o") Entao
                                 campeao <- 1
                                 Escreval("")
                                 Escreval ("Parabéns ", jogador2, " você é o Campeão!!!")
                              Fimse
                         Fimse
//Verifica a diagonal principal na matriz se com o valor recebido pode ter campeao
                         Se (jogo[1,1] = "x") e (jogo[2,2] = "x") e (jogo[3,3] = "x") e(jogo[4,4] = "x") e (jogo[5,5] = "x") Entao
                            campeao <- 1
                            Escreval("")
                            Escreval("Parabéns ", jogador1, " você é o Campeão!!!")
                         senao
                              Se (jogo[1,1] = "o") e (jogo[2,2] = "o") e (jogo[3,3] = "o") e(jogo[4,4] = "o") e (jogo[5,5] = "o") Entao
                                 campeao <- 1
                                 Escreval("")
                                 Escreval ("Parabéns ", jogador2, " você é o Campeão!!!")
                              Fimse
                         Fimse
//Verifica a diagonal secundaria na matriz se com o valor recebido pode ter campeao
                         Se (jogo[5,1] = "x") e (jogo[4,2] = "x") e (jogo[3,3] = "x") e(jogo[2,4] = "x") e (jogo[1,5] = "x") Entao
                            campeao <- 1
                            Escreval("")
                            Escreval("Parabéns ", jogador1, " você é o Campeão!!!")
                         senao
                              Se (jogo[5,1] = "o") e (jogo[4,2] = "o") e (jogo[3,3] = "o") e(jogo[2,4] = "o") e (jogo[1,5] = "o") Entao
                                 campeao <- 1
                                 Escreval("")
                                 Escreval ("Parabéns ", jogador2, " você é o Campeão!!!")
                              Fimse
                         Fimse
//Verifica se houve empate
                         Se (aux1 = 5) e (aux2 = 5) e (aux3 = 5) e (aux4 = 5) e (aux5 = 5) e (campeao=0) Entao
                            jogar <- 0
                            opcao <- 0
                            Escreval("")
                            Escreval("Caro Jogadores houve um EMPATE!!!")
                            Escreval("")
                            Escreval("Tente Novamente!!!")
                         Fimse
                FimEnquanto
//Fim do jogo
//******************************************************************************
fimalgoritmo
