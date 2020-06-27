using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemploInterface
{

    interface IEndereco // Inteface tbm é modelo do que o programa vai precisar para ser criada
    {
        string Endereco
        { get; set; }

        string Cep
        { get; set; }

        string Cidade
        { get; set; }

        string Estado
        { get; set; }

        string Status
        { get; set; }
    }
}
