using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolhaPgto
{
    public class Producao:Empregado
    {
        private double salarioPorItem;
        private double quantidadeProduzida;

        public double SalarioPorItem
        {
            get { return salarioPorItem; }
            set
            {
                if (value > 0)
                    salarioPorItem = value;
            }
        }
        public double QuantidadeProduzida
        {
            get { return quantidadeProduzida; }
            set
            {
                if (value > 0)
                    quantidadeProduzida = value;
            }
        }

        public Producao(string nome, string sobrenome, double salarioPorItem,
            double quantidadeProduzida)
            :base(nome, sobrenome)
        {
            SalarioPorItem = salarioPorItem;
            QuantidadeProduzida = quantidadeProduzida;
        }
        //metodo polifórmico para retornar salario do chefe
        public override double Ganhos()
        {
            return QuantidadeProduzida * SalarioPorItem;
        }
    }
}
