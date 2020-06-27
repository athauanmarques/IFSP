using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo1
{
    public class Producao : Empregado
    {
        private double salarioPorItem;
        private double qtsProduzida;


        public double SalarioPorItem // pode colocar  mesmo nome 
        {

            get { return salarioPorItem; }
            set
            {
                if (value > 0) // aceita valores positivos
                {
                    salarioPorItem = value;
                }


            }
        }

        public double QtsProduzida
        {

            get { return qtsProduzida; }
            set
            {
                if (value > 0) // aceita valores positivos
                {
                    qtsProduzida = value;
                }

            }

        }

        public Producao(string nome, string sobrenome, double salarioPorItem, double qtsProduzida)
                : base(nome, sobrenome) // base ta vindo da classe herdada
            {
            
                SalarioPorItem = salarioPorItem;
                QtsProduzida = qtsProduzida;
              
            
            }
        // polifórmico
        public override double Ganhos()
        {
            return QtsProduzida * SalarioPorItem;
        }






    }
}
