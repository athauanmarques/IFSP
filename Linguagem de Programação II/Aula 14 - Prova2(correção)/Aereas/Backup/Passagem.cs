using System;
using System.Collections.Generic;
using System.Text;

namespace Aereas
{
    public class Passagem
    {
        private float precoKm = 2.50F;

        public float PrecoKm
        {
            get { return precoKm; }
            set { precoKm = value; }
        }
        protected string origem;
        protected string destino;
        protected float distancia;
        protected bool classe;

        public Passagem(string origem, string destino, bool classe)
        {
            this.origem = origem;
            this.destino = destino;
            this.classe = classe;
        }

        public float calculaDistancia()
        {
            if ((origem == "Belo Horizonte" && destino == "Brasilia")|| (origem =="Brasilia"  && destino == "Belo Horizonte")) 
            {
                distancia = 800F;
                          
            }
            else if ((origem == "Belo Horizonte" && destino == "Rio de Janeiro") || (origem == "Rio de Janeiro" && destino == "Belo Horizonte")) 
            {
                distancia = 300F;
            }
            else if ((origem == "Belo Horizonte" && destino == "São Paulo") || (origem == "São Paulo" && destino == "Belo Horizonte")) 
            {
                distancia = 450F;

            }
            else if ((origem == "Brasilia" && destino == "Rio de Janeiro") || (origem == "Rio de Janeiro" && destino == "Brasilia")) 
            {
                distancia = 1100F;
            }
            else if ((origem == "Brasilia" && destino == "São Paulo") || (origem == "São Paulo" && destino == "Brasilia"))
            {
                distancia = 1000F;
            }
            else if ((origem == "Rio de Janeiro" && destino == "São Paulo") || (origem == "São Paulo" && destino == "Rio de Janeiro"))
            {
                distancia = 250F;
            }
            else 
            {
                distancia = 0F;
            }
            return distancia;
        }

        public virtual float calculoPassagem()
        {
            float precoPassagem;
            precoPassagem = distancia * precoKm;
            return precoPassagem;
        }
    }
}
