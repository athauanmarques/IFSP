using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LojaWin.Modelos
{
    public class ModeloVendas
    {
        private int idvenda;
        public int Idvenda
        {
            get { return idvenda; }
            set { idvenda = value; }
        }

        private int idcliente;
        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        private DateTime data;
        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        private decimal valor;
        public decimal Valor
        {
            get { return valor; }
            set { valor = value; }
        }
    }
}
