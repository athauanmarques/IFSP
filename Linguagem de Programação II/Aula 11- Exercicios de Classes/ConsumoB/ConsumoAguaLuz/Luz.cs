using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsumoAguaLuz
{
    public class Luz
    {
        //atributos
        private int anterior;
        private int atual;
        private double tarifa = 0.36;

        public int Anterior
        {
            get { return anterior; }
            set { anterior = value; }
        }
        public int Atual
        {
            get { return atual; }
            set { atual = value; }
        }
        public double Tarifa
        {
            get { return tarifa; }
            set { tarifa = value; }
        }

        //Construtor
        public Luz(int anterior, int atual)
        {
            this.anterior = anterior;
            this.atual = atual;
        }

        public double ConsumoLuz()
        {
            return atual - anterior;
        }
        public double ConsumoReais()
        {
            return ConsumoLuz() * tarifa;
        }
        public double CalculaPis()
        {
            return ConsumoReais() * 0.0136;
        }
        public double CalculaCofins()
        {
            return ConsumoReais() * 0.0625;
        }
        public double CalculaIcms()
        {
            return ConsumoReais() * 0.365;
        }
        public double CalculaTotal()
        {
            return ConsumoReais() + CalculaPis() 
                + CalculaCofins() + CalculaIcms();
        }

    }
}
