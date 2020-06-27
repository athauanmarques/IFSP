using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
    interface IDenderco
    {
        string Stauts
        { get; }
        string Endereco
        { set; get; }
        string Cep
        { get; }
        string Cidade
        { set; get; }
        string Estado
        { set; get; }
    }
}
