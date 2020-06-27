using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exer1
{
    public class Calcular
    {
        public double num1;
        public double result;


        public double mestrado(double num1)
        {
            result = num1 * 1.20;
            return result;
        }
        public double doutoradoCal(double num1)
        {

            result = num1 * 1.10;
            return result;

        }
    }
}
