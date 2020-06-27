using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocios
{
    interface INotaFiscal
    {
        string Razao
        {
            get;
            set;
        }
        DateTime Data
        {
            get;
            set;
        }
        string Endereco
        {
            get;
            set;
        }
        string Cidade
        {
            get;
            set;
        }
        int Cnpj
        {
            get;
            set;
        }
        double Valor
        {
            get;
            set;
        }
        int Cep
        {
            get;
            set;
        }
        string Estado
        {
            get;
            set;
        }
        string Status
        { get;  set; }

        void Gerar();
    }
}
