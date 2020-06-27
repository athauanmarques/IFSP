using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consumo_Agua_Luz
{
    public class Agua
    {

        private int anteriorB;
        private int atualB;
        private double tarifaB = 14.19;


        public int AnteriorB
        {
            get { return anteriorB; }
            set { anteriorB = value;  }
        
        }

        public int AtualB
        {
            get { return atualB; }
            set { atualB = value; }

        }

        public double TarifaB
        {
            get { return tarifaB; }
            set { tarifaB = value; }

        }

        public double H2o(int antB, int atualB)
        {
            this.anteriorB = antB;
            this.atualB = atualB;
        
        }

        public double ConsumoB()
        {

            return anteriorB - atualB;
        
        }

        public double ConsumoLitro()
        {

            return ConsumoB() * 1000;

        }

        public double ResultadoB()
        {

            if (ConsumoB() >= 0 && ConsumoB() <= 10)
            {
                return tarifaB = 14.19;
            }


            else if  (ConsumoB() >= 11 && ConsumoB() <= 20)
            {
                return tarifaB - ConsumoB() * 1.98;
            }

            else if (ConsumoB() >= 21 && ConsumoB() <= 50)
            {
                return tarifaB - ConsumoB() * 3.04;
            }

            else if (ConsumoB() >50)
            {

                return tarifaB - ConsumoB() * 3.63;
            
            }

        }

    }
}
