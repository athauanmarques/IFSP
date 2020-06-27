using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace industria
{
    class Produto2
    {
        // todos deve atributos static, os metodos static só aceita atributos static, e nos atribuições (get set) são normais 
        private static int codigo;
        private static string produtos;
        private static double estoque;
        private static string status;
        private static int preco;

        public int Codigo
        {

            get { return codigo; }
            set { value = codigo; }


        }

        public  string Produtos
        {

            get { return produtos; }
            set { value = produtos; }

        }

        public  double Estoque
        {

            get { return estoque; }
            set { value = estoque; }
        }

        public  int Preco
        {

            get { return preco; }
            set { value = preco; }
        }

        public string Status
        {

            get { return status; }

        }

        public  void Alterar()
        {


            status = "Foi alterado com sucesso os seguites dados: \n Codigo:" + codigo +
                "\n Produto" + produtos + "\n Estoque: " + estoque + "\n Preco: " + preco;


        }

        public static void Excluir()
        {

            status = "Foi Excluido com sucesso os seguites dados: \n Codigo:" + codigo +
             "\n Produto" + produtos + "\n Estoque: " + estoque + "\n Preco: " + preco;

        }

        public static void Incluir()
        {

            status = "Foi incluido com sucesso os seguites dados: \n Codigo:" + codigo +
             "\n Produto" + produtos + "\n Estoque: " + estoque + "\n Preco: " + preco;

            
        }

        



    }
}
