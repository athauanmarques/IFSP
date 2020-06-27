using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolhaPgto
{
    public class Chefe:Empregado
    {
        //Atributos
        private double salario;

        //propriedades
        public double SalarioMensal
        {
            get { return salario; }
            set 
            { 
                if(value > 0)
                salario = value; 
            }
        }
        //Construtor
        public Chefe(string nome, string sobrenome, double salario)
            : base(nome, sobrenome)
        {
            SalarioMensal = salario;
        }
        //metodo polifórmico para retornar salario do chefe
        public override double Ganhos()
        {
            return SalarioMensal * 1.1;
        }
    }
}
