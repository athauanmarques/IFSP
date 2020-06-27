using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsumoAguaLuz
{
    public  class Agua
    {
        //atributos
        private int anterior;
        private int atual;
        private double tarifa;

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
        public Agua(int anterior, int atual)
        {
            this.anterior = anterior;
            this.atual = atual;
        }
        public double ConsumoAgua()
        {
            return atual - anterior;
        }
        public double ConsumoLitros()
        {
            return ConsumoAgua() * 1000;
        }
        public double ConsumoReais()
        {
            if (ConsumoAgua() > 0 && ConsumoAgua() <=10)
            {
                tarifa = 14.19; 
            }
            else if (ConsumoAgua() >= 11 && ConsumoAgua() <= 20)
            {
                tarifa = ConsumoAgua() * 1.98;
            }
            else if (ConsumoAgua() >= 21 && ConsumoAgua() <= 50)
            {
                tarifa = ConsumoAgua() * 3.04;
            }
            else if (ConsumoAgua() > 50)
            {
                tarifa = ConsumoAgua() * 3.63;
            }
            return tarifa;
        }
    }
}
