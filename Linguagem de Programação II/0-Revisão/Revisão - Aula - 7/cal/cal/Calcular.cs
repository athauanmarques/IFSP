using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cal
{
    public class Calcular
    {
        public double n1;
        public double n2;
        public double result;

        public double soma(double n1, double n2)
        {
            result = n1 + n2;
            return result;
        
        }

        public double sub(double n1, double n2)
        {
            result = n1 - n2;
            return result;

        }

        public double div(double n1, double n2)
        {
            result = n1 / n2;
            return result;

        }
        public double mul(double n1, double n2)
        {
            result = n1 * n2;
            return result;

        }

        public double resto(double n1, double n2)
        {
            result = n1 % n2;
            return result;

        }
        public double pot(double n1, double n2)
        {
            result = Math.Pow(n1, n2);
            return result;

        }



    }
}
