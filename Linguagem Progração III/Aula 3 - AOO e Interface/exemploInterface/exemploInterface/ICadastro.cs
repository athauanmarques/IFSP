using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemploInterface
{
    //por padrão devemos colocar "I" no nome da interface ex : INome
    // o interface só serve para modelo 
    // Estes são atributos 
    interface ICadastro
    {


        int Codigo
        {

            get;
            set;

        }

        int Nome
        {

            get;
            set;

        }

        string Status
        {

            get;
            set;
        }
    }
}
