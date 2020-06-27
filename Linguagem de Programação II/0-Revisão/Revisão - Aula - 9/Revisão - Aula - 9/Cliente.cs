using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Revisão___Aula___9
{
    public class Cliente
    {
        private string nome;
        private int cod;
        private string status;

        public string Nome
        {

            get { return nome; }
            set { nome = value; }
        
        }

        public int Cod
        {

            get { return cod; }
            set { cod = value; }
        
        }

        public string Status
        {

            get { return status; }
            set { status = value; }
        }
        
        public void Excluir()
        {
        
            status = "Status: Excluido com successo ";

        
        }


        }
    }

