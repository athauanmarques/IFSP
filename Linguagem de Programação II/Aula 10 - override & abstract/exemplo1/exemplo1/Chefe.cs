using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo1
{
    public class Chefe: Empregado
    {
        private double salario;

        public double SalarioMensal
        {

            get { return salario; }
            set {
                if (value > 0) // aceita valores positivos
                {
                    salario = value;
                }
            
            }
                }
            //Construtor
            public Chefe(string nome, string sobrenome, double salario)
                : base(nome, sobrenome) // base ta vindo da classe herdada
            {
            
                SalarioMensal = salario;
            
            }
        // metodo polifórmico para retornar salario do chefe
        public override double  Ganhos()
{
 	    return SalarioMensal * 1.1;
}

        
       
    }
}
