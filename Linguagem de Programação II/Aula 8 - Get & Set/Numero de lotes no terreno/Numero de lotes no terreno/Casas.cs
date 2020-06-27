using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Casas
    {
        //atributos
        private double areaLote;
        private double numeroLote;
        private double casa;
        private double quarto;
        private double sala;
        private double banheiro;
        private double cozinha;
        private double servico;

        //propriedades (letra maiuscula em cada palavras exe: AreaLote, no caso se for uma palavra só seria:  'Tesouro') --------------------------
        public double AreaLote
        {

            get 
            { 
                return areaLote;
            }

            set 
            { 
                areaLote = value; 
            }
        
        }

         public double NumeroLote
        {

            get { return numeroLote; }
            set {numeroLote = value;}
        
        }
      

         public double Casa
        {

            get { return casa;}
            set { casa = value; }
        
        }

         public double Quarto
        {

            get { return quarto;}
            set { quarto = value; }
        
        }
         public double Sala
        {

            get { return sala;}
            set { sala = value; }
        
        }
         public double Banheiro
        {

            get { return banheiro;}
            set { banheiro = value; }
        
        }


         public double Cozinha
        {

            get { return cozinha;}
            set { cozinha = value; }
        
        }

         public double Servico
        {

            get { return servico;}
            set { servico = value; }
        
        }

        
        //Método -----------------------------------

         public double AreaLotes(double lateralLote, double frenteLote)
         {

             areaLote = lateralLote * frenteLote;
             return areaLote;
         
         }


         public double NumLote(double areaTerreno)
         {

             numeroLote = areaTerreno / areaLote;
             return numeroLote;
         
         }

         public double CalSala()
         {

             sala = areaLote * 1.8;
             return sala;
         
         
         }



         public double CalCasa()
         {

             casa = areaLote * 0.80;
             return casa;
         
         }

         public double QuartoCal()
         {

             quarto = areaLote * 0.20;
             return quarto;
         
         }

         public double CalBanheiro()
         {

             banheiro = areaLote * 0.25;
             return banheiro;

         }
         public double CalCozinha()
         {

             cozinha = areaLote * 0.14;
             return cozinha;
         }

         public double CalServico()
         {

             servico = areaLote * 0.5;
             return servico;
         }


    }
}
