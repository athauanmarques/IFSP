using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revisão___Aula___11
{
    public class Luz
    {
        private int anteriorL;
        private int atualL;
        private double tarifaL = 0.36;

        public int AnteriorL
        {

            get { return anteriorL; }
            set { anteriorL = value;  }
        
        }

        public int AtualL
        {

            get { return atualL; }
            set { atualL = value; }

        }

        public double TarifaL
        {

            get { return tarifaL; }
            set { tarifaL = value; }

        }

        public Luz(int antL, int atual)
        {

            this.anteriorL = antL;
            this.atualL = atual;
     
        }

        public double Reais()
        { 
        
            return ConsumoKwh() * tarifaL;
        
        }


        public double ConsumoKwh()
        {

            return anteriorL - atualL;
        
        }

        public double Pis()
        {

            return ConsumoKwh() * 0.0136;
        
        }

        public double Confins()
        {

            return ConsumoKwh() * 0.0625;
        
        
        }

        public double Icms()
        {


            return ConsumoKwh() * 0.365;
        
        
        }

        public double TotalLuz()
        {

            return Pis() + Confins() + Icms() + Reais();
        
        
        }





    }
}
