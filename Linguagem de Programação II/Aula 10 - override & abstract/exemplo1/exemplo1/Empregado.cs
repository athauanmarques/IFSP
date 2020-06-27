using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo1
{
   public abstract class Empregado
    {
       //atributos
       private string nome;
       private string sobrenome;

       //propriedades
       public string Nome
       {

           get { return nome; }
           set { nome = value;  }

       }
       public string Sobrenome
       {

           get { return sobrenome; }
           set { sobrenome = value; }
       }
   
       //Contrutor - tem sempre mesmo nome da classe neste é Empregado
       //ele atribui valor é mudar os valores, então sempre usa parametros
       public Empregado(string nome, string sobrenome)
       {

           nome = Nome;
           // está recebendo a palavra 'Nome' para variavel 'nome', então este é modificação
           sobrenome = Sobrenome;
       
       }

       // metedo
       public abstract double Ganhos(); 

   
   
   
   
   
   }


}
