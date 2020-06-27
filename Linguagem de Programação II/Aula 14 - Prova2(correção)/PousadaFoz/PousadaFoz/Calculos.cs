using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PousadaFoz
{
    class Calculos
    {
        private string nomeCliente;
        private int numDias;
        private double valorQuarto;
        private double totalCliente;
        public static double totalArrecadado = 0;
        public static int diasClienteMaiorNumDias = 0;
        public static string clienteMaiorNumDias = "";

        //get - obtem/retorna o valor do campo
        //set - atribui um valor ao campo
        public double getValorQuarto()
        {
            return this.valorQuarto;
        }
        
        public double getTotalCliente()
        {
            return this.totalCliente;
        }

        //Construtor
        public Calculos(string nomeC, int numD, int idTipoQuarto)
        {

            this.nomeCliente = nomeC;
            this.numDias = numD;

            switch (idTipoQuarto)
            {
                case 0: this.valorQuarto = 200; break;
                case 1: this.valorQuarto = 300; break;
                case 2: this.valorQuarto = 250; break;
                case 3: this.valorQuarto = 450; break;

            }            


            this.calcularTotal();
            if (this.numDias > Calculos.diasClienteMaiorNumDias)
            {
                Calculos.diasClienteMaiorNumDias = this.numDias;
                Calculos.clienteMaiorNumDias = this.nomeCliente;
            }

        }

        private void calcularTotal()
        {
            this.totalCliente = (this.numDias * this.valorQuarto);
        }

    }
}
