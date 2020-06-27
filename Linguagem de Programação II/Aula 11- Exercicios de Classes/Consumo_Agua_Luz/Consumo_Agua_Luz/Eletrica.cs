using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Consumo_Agua_Luz
{
    public class Eletrica
    {
        private int anteriorA;
        private int atualA;
        private double tarifa = 0.36;


        public double AnteriorA
        {

            
            get { return anteriorA; }
            set { anteriorA = value; }
        
        }

        public double AtualA
        {

            get { return atualA; }
            set { atualA = value; }
        
        
        }

        public double TarifaA
        {


            get { return tarifa; }
            set { tarifa = value; }

        }
        //Construtor
        public double Luz (int ant, int atualA)
        {
           this.anteriorA = ant; // jogando valor que esta no metodo int ant
           this.atualA = atualA;

        }

        public double ConsumoLuz()
        {

            return atualA - anteriorA;
        
        }

        public double ConsumoReais()
        {
            return ConsumoLuz() * tarifa;

        }

        public double ConsumoPis()
        {

            return ConsumoReais() * 0.0136;
        
        }

        public double CalcularConfins()
        {

            return ConsumoReais() * 0.0625;
        
        }

        public double CalculaIcms()
        {

            return ConsumoReais() * 0.365;
        
        }

        public double CalcularTotal()
        {

            return ConsumoReais() * ConsumoPis() + CalcularConfins() + CalculaIcms();
            
        
        }








    }
}
