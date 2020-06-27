using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraSimples
{
    public class Calcula
    {
        public double n1=0;
        public double n2=0;
        public double result=0;

        public double Soma(double n1, double n2) //parametro para retorna para o usuário
        {
            result = n1 + n2;
            return result;
        
        }
        public double divisao(double n1, double n2)
        {

            result = n1 / n2;
            return result;
        
        }

        public double subtracao(double n1, double n2)
        {

            result = n1 - n2;
            return result;
        
        }
        public double mutiplicacao(double n1, double n2)
        {

            result = n1 * n2;
            return result;
        
        }

        public double resto(double n1, double n2)
        {

            result = n1 % n2;
            return result;
        
        }



    }
}
