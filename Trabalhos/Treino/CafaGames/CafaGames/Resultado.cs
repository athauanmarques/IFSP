using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
   public  class Resultado
    {
        private double resposta;
        private double total;



        public double Resposta
        {

            get { return resposta; }
            set { resposta = value; }
        
        }

        public double Total
        {

            get { return total; }
            set { total = value; }

        }
      

        public double ResultadoA1(double resposta)
        {
            this.resposta = resposta;
            return total + resposta;
        
        }
        public double ResultadoA2(double resposta)
        {
            this.resposta = resposta;
            return total + resposta;

        }
       // //public double TesteTotal()
       //// {

       //  //   return ResultadoA1() + ResultadoA2();

       // }

    }
}
