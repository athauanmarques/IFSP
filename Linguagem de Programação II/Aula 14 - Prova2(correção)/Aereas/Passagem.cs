using System;
using System.Collections.Generic;
using System.Text;

namespace Aereas
{
    public class Passagem
    {
        private double precoKm = 2.50;
        private string origem;
        private string destino;
        private double distancia;
        private bool classe;

        //get - obtem/retorna o valor do campo
        //set - atribui um valor ao campo
        public double PrecoKm
        {
            get { return precoKm; }
            set { precoKm = value; }
        }
        
        public string Origem
        {
            get { return origem; }
            set { origem = value; }
        }
        public string Destino
        {
            get { return destino; }
            set { destino = value; }
        }
        public double Distancia
        {
            get { return distancia; }
            set { distancia = value; }
        }
        public bool Classe
        {
            get { return classe; }
            set { classe = value; }
        }

        //Construtor
        public Passagem(string origem, string destino, bool classe)
        {
            this.origem = origem;
            this.destino = destino;
            this.classe = classe;
        }


        public double CalculaDistancia()
        {
            if ((origem == "Belo Horizonte" && destino == "Brasilia")|| (origem =="Brasilia"  && destino == "Belo Horizonte")) 
            {
                distancia = 800;
                          
            }
            else if ((origem == "Belo Horizonte" && destino == "Rio de Janeiro") || (origem == "Rio de Janeiro" && destino == "Belo Horizonte")) 
            {
                distancia = 300;
            }
            else if ((origem == "Belo Horizonte" && destino == "São Paulo") || (origem == "São Paulo" && destino == "Belo Horizonte")) 
            {
                distancia = 450;

            }
            else if ((origem == "Brasilia" && destino == "Rio de Janeiro") || (origem == "Rio de Janeiro" && destino == "Brasilia")) 
            {
                distancia = 1100;
            }
            else if ((origem == "Brasilia" && destino == "São Paulo") || (origem == "São Paulo" && destino == "Brasilia"))
            {
                distancia = 1000;
            }
            else if ((origem == "Rio de Janeiro" && destino == "São Paulo") || (origem == "São Paulo" && destino == "Rio de Janeiro"))
            {
                distancia = 250;
            }
            else 
            {
                distancia = 0;
            }
            return distancia;
        }


        public virtual double CalculoPassagem()
        {
            double precoPassagem;
            precoPassagem = distancia * precoKm;
            return precoPassagem;
        }
    }
}
