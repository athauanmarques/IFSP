using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Venda
{
    public class Vendas
    {
        private double quantidade;
        private double preco;
        private double desconto = 0.95;
        private double vista;
        private double prazo;



        public double Prazo
        {

            get { return prazo; }
            set { prazo = value; }

        }

        public double Vista
        {

            get { return vista; }
            set { vista = value; }

        }

        public double Quantidade
        {

            get { return quantidade; }
            set { quantidade = value; }
        
        }

        public double Preco
        {

            get { return preco;}
            set { preco = value; }

        }

        public double Desconto
        {

            get { return desconto; }
            set { desconto = value; }

        }


        public Vendas(double qts, double pre)
        {
            quantidade = qts;
            preco = pre;
        
        }


        public double  ValorVista()
        { 
            vista = quantidade * preco * desconto;
            return vista;
            
        }


        public double  ValorPrazo()
        { 
            vista = quantidade * preco * desconto;
            return vista;
            
        }


    }
}
