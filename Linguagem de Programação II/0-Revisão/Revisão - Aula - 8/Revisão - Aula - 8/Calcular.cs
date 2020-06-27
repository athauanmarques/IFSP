using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revisão___Aula___8
{
   public class Calcular
    {
       private double areaLote;
       private double numLote;
       private double casa;
       private double banheiro;
       private double sala;
       private double cozinha;
       private double servico;
       private double quarto;

       public double AreaLote
       {

           get { return areaLote; }
           set { areaLote = value; }
       
       }

       public double NumLote
       {

           get { return numLote; }
           set { numLote = value; }

       }
       public double Servico
       {

           get { return servico; }
           set { servico = value; }

       }

       public double Casa
       {

           get { return casa; }
           set { casa = value; }

       }

       public double Banheiro
       {

           get { return banheiro; }
           set { banheiro = value; }

       }

       public double Cozinha
       {

           get { return cozinha; }
           set { cozinha = value; }

       }
       public double Sala
       {

           get { return sala; }
           set { sala = value; }

       }

       public double Quarto
       {

           get { return quarto; }
           set { quarto = value; }

       }

       public double AreaTotal(double lateral, double frente)
       {

           areaLote = lateral * frente;
           return areaLote;

       }

       public double  LoteTotal(double terreno)
       {
   
           numLote = areaLote / terreno;
           return numLote;
   
   
       }
       
       public double AreaCasa ()
       {

           casa = areaLote * 1.8;
           return casa;
       
   
       }

       public double AreaBanheiro()
       {

           banheiro = areaLote * 1.08;
           return banheiro;


       }

       public double AreaSala()
       {

           sala = areaLote * 1.25;
           return sala;


       }
       public double AreaCozinha()
       {

           cozinha = areaLote * 1.14;
           return cozinha;


       }

       public double AreaServico()
       {

           servico = areaLote * 1.05;
           return servico;


       }
       public double AreaQuarto()
       {

           quarto = areaLote * 1.20;
           return quarto;


       }



    }
}
