using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Negocios;

namespace loja
{
    interface INotafiscal : Notafiscal
    {

        private DateTime dt = new DateTime();
        private string endereco;
        private string razao;
        private string estado;
        private string cnpj;
        private string cep;
        private double valor;
        private string cidade;

        public DateTime Dt
        {

            get { return dt; }
            set { dt = value; }

        }

        public string Endereco
        {

            get { return endereco; }
            set { endereco = value; }

        }

        public string Razao
        {

            get { return razao; }
            set { razao = value; }

        }

        public string Cidade
        {

            get { return cidade; }
            set { cidade = value; }

        }

        public string Cnpj
        {

            get { return cnpj; }
            set { cnpj = value; }

        }

        public string Cep
        {

            get { return cep; }
            set { cep = value; }

        }

        public double Valor
        {

            get { return valor; }
            set { valor = value; }

        }

        public string Estado
        {

            get { return estado; }
            set { estado = value; }

        }




    }
}
