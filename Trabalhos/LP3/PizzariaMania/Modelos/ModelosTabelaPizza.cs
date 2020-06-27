using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pizzaria.Modelos
{
    public class ModelosTabelaPizza
    {
   private int idPizzas;
   public int IdPizzas { get {return idPizzas;} set{idPizzas= value;}}
   private string sabor;
   public string Sabor { get { return sabor; } set { sabor = value; } }
   private string informacoes;
   public string Informacoes { get { return informacoes; } set { informacoes = value; } }
   private decimal precoG;
   public decimal PrecoG { get { return precoG; } set { precoG = value; } }
   private decimal precoM;
   public decimal PrecoM { get { return precoM; } set { precoM = value; } }
   private decimal precoP;
   public decimal PrecoP { get { return precoP; } set { precoP = value; } }
    }
}
