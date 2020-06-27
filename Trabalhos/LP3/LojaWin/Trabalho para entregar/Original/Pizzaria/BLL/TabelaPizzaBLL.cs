using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Pizzaria.Modelos;
using Pizzaria.DAL;

namespace Pizzaria.BLL
{
    
    public class TabelaPizzaBLL
    {
        ModelosTabelaPizza pizzas = new ModelosTabelaPizza();
        TabelaPizzaDAL objPizza = new TabelaPizzaDAL();

        private string mensagem;
        public string Mensagem
        {
            get { return mensagem; }
            set { mensagem = value; }
        }

        public ListarTabelaPizza ListarTabela(string filtro)
        {

            return objPizza.ListarTabela(filtro);
        }



        public string IncluirPizza(ModelosTabelaPizza pizzas)
        {

            try
            {
                if (pizzas.Sabor.Length > 25)
                {
                    mensagem = "Que nome comprido que vocÊ tem, só são permetidos até 25 caracteres";


                }
                else if (pizzas.PrecoP.ToString().Length == 0 || pizzas.PrecoM.ToString().Length == 0 || pizzas.PrecoG.ToString().Length == 0)
                {

                    mensagem = "Por favor informe o preço dos tamnhos de pizzas";
                }
                else
                {

                    objPizza.AddTabela(pizzas);
                    mensagem = "Inserido com êxito.";

                }
                return mensagem;

                
            }

            catch
            {
                throw new Exception("Não foi possível incluir o cliente no cadastro!");
            }

        }

        public string AlterarPizza(ModelosTabelaPizza pizzas)
        {

            try
            {
                if (pizzas.Sabor.Length > 25)
                {
                    mensagem = "Que nome comprido que vocÊ tem, só são permetidos até 25 caracteres";


                }
                else if (pizzas.PrecoP.ToString().Length == 0 || pizzas.PrecoM.ToString().Length == 0 || pizzas.PrecoG.ToString().Length == 0)
                {

                    mensagem = "Por favor informe o preço dos tamnhos de pizzas";
                }
                else
                {

                    objPizza.AlterarTabelaPizza(pizzas);
                    mensagem = "Alterado com êxito.";

                }
                return mensagem;


            }

            catch
            {
                throw new Exception("Não foi possível incluir o cliente no cadastro!");
            }

        }

        


        public bool ExcluirPizza(ModelosTabelaPizza pizza)
        {
            try
            {
                bool resposta = false;
                if (pizza.IdPizzas < 1)
                {
                    mensagem = "Selecione o cliente antes de excluí-lo";
                }
                else
                {
                    resposta = objPizza.ExcTabelaPizza(pizza);
                    mensagem = "Excluído com sucesso!";
                }
                return resposta;
            }
            catch
            {
                mensagem = "Não foi possível excluir tente novamente!";
                throw new Exception(mensagem);
            }


        }


    }
}
