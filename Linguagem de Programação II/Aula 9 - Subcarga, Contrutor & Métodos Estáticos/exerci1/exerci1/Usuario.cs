using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
    public class Usuario
    {

        private string nome;
        private int cod;
        private string status;

        public int Codigo
        {

            get 
            { 
                
                return cod;
            }
            set 
            { 
                cod = value; 
            }
        
        
        }

        public string Nome
        {

            get
            {

                return nome;
            }
            set
            {
                nome = value;
            }


        }
        public string Status
        {

            get
            {

                return status;
            }
            set
            {
                status = value;
            }


        }



       public void Buscar(int cod)
       {

        status = "Código :" + cod + " encontrado";
    
    
        }


       public void Buscar(string nome) // buscar tem o mesmo nome mas, com parametros diferentes (isso chama subcarga)
       {

           status = "Nome :" + cod + " encontrado";


       }



    
    }
}
