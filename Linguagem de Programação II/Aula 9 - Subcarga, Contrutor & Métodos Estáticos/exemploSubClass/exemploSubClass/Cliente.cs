using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemploSubClass
{
   public class Cliente
    {
       private string nome;
       private int cod;
       private string status;

       public string Status
       {

           get { return status; }
           set { status = value; }

       }


       public int Cod
       {

           get { return cod; }
           set { cod = value; }
       
       }

       public string Nome
       {

           get { return nome; }
           set { nome = value; }

       }


       public void Excluir()
       {

           status = "Status: Excluido com sucesso";
       
       
       }
    }
}
