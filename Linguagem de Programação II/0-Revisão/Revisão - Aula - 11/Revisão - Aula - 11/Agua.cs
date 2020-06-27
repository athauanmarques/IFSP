using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revisão___Aula___11
{
    public class Agua
    {

        private int anteriorA;
        private int atualA;
        private double tarifaA ;


        public int AnteriorA 
        {

            get { return anteriorA; }
            set { anteriorA = value;  }
        
        }

        public int AtualA
        {

            get { return atualA;  }
            set { atualA = value; }


        }

        public double TarifaA
        {

            get { return tarifaA; }
            set { tarifaA = value; }
       }


        public Agua(int anteriorA, int atualA)
        { 
        
            this.anteriorA = anteriorA;
            this.atualA = atualA;
        
        }

        public double ConsumoA()
        {

            return anteriorA - atualA;

        }

        public double ConsumoLitros()
        {

            return ConsumoA() * 1000;
        
        
        }

        public double ConsumoRs()
        {

            if (ConsumoA() >= 0 && ConsumoA() <= 10)
            {
               tarifaA = 14.19;
            }
            else if (ConsumoA() >= 11 && ConsumoA() <= 20)

            {

                tarifaA = ConsumoA() * 1.98;
            
            }
        
             else if (ConsumoA() >= 21 && ConsumoA() <= 50)

            {
                tarifaA = ConsumoA() * 3.04;

            }

            else if (ConsumoA() > 50)
            {
                tarifaA = ConsumoA() * 3.63;

            }
            return tarifaA;

        }

    }
}
