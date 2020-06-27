using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Casas
    {
        //artributos

        private double areaLote;
        private double numeroLotes;
        private double casa;
        private double quarto;
        private double sala;
        private double banheiro;
        private double cozinha;
        private double areaServico;

        //propriedades

        private double AreaLote
        {
            get{return areaLote;}
            set{areaLote = value;}
        }

        private double NumeroLotes
        {
            get { return numeroLotes; }
            set { numeroLotes = value; }
        }

        private double Casa
        {
            get { return casa; }
            set { casa = value; }
        }

        private double Quarto
        {
            get { return quarto; }
            set { quarto = value; }
        }

        private double Sala
        {
            get { return sala; }
            set { sala = value; }
        }

        private double Banheiro
        {
            get { return banheiro; }
            set { banheiro = value; }
        }

        private double Cozinha
        {
            get { return cozinha; }
            set { cozinha = value; }
        }

        private double AreaServico
        {
            get { return areaServico; }
            set { areaServico = value; }
        }

        //metodo

        public double AreaDoLote(double lateralLote , double frenteLote)
        {
            areaLote = lateralLote * frenteLote;
            return areaLote;
        }

        public double NumeroLote(double areaTerreno)
        {
            numeroLotes = areaTerreno / areaLote;
            return numeroLotes;
        }

        public double AreaCasa()
        {
            casa =  areaLote *0.8;
            return casa;
        }

        public double AreaQuarto()
        {
            quarto = (casa * 0.2) * 2;
            return quarto;
        }

        public double AreaSala()
        { 
            sala = casa * 0.25;
            return sala;
        }

        public double AreaBanheiro()
        {
            banheiro = (casa * 0.08) * 2;
            return banheiro;
        }

        public double AreaCozinha()
        {
            cozinha = casa * 0.14;
            return cozinha;
        }

        public double AreaDeServico()
        {
            areaServico = casa * 0.05;
            return areaServico;
        }
    }
}
