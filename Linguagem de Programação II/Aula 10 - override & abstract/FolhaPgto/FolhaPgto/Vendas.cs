using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FolhaPgto
{
    public class Vendas:Empregado
    {
        private double salario;
        private double comissao;
        private int quantidade;

        public double SalarioMensal
        {
            get { return salario; }
            set
            {
                if (value > 0)
                    salario = value;
            }
        }
        public double Comissao
        {
            get { return comissao; }
            set
            {
                if (value > 0)
                    comissao = value;
            }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set
            {
                if (value > 0)
                    quantidade = value;
            }
        }
        public Vendas(string nome, string sobrenome, double salario, double comissao, int quantidade)
            :base(nome, sobrenome)
        {
            SalarioMensal = salario;
            Comissao = comissao;
            Quantidade = quantidade;
        }
        //metodo polifórmico para retornar salario do chefe
        public override double Ganhos()
        {
            return SalarioMensal + Comissao * Quantidade;
        }

    }
}
