using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo1
{
   public class Vendas: Empregado
    {
       private double salario;
       private double comissao;
       private int quantidade;


       public double SalarioMensal // pode colocar  mesmo nome 
        {

            get { return salario; }
            set {
                if (value > 0) // aceita valores positivos
                {
                    salario = value;
                }
            
            
                }
       }

       public double Comissao
       {

           get { return comissao; }
           set
           {
               if (value > 0) // aceita valores positivos
               {
                   comissao = value;
               }

           }

       }
               public int Quantidade
                    {

            get { return quantidade; }
            set {
                if (value > 0) // aceita valores positivos
                {
                    quantidade = value;
                }
            
            
                }

               }

          public Vendas(string nome, string sobrenome, double salario, double comissao, int quantidade)
                : base(nome, sobrenome) // base ta vindo da classe herdada
            {
            
                SalarioMensal = salario;
                Comissao = comissao;
                Quantidade = quantidade;
            
            }
        // metodo 
            public override double  Ganhos()
{
 	    return SalarioMensal + Comissao * Quantidade;
}
   
   

    }
}
