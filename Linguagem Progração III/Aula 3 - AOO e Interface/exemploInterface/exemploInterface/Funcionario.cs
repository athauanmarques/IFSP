using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemploInterface
{
    class Funcionario: Conexao, ICadastro, IEndereco; // são heranças que classe Funcionario esta pegando
    {
        //criar os atributos das interfaces

    public void Conectar();
        {}

    public void Desconectar();
        {}

    public void Alterar();
        {}

    public void Excluir();
        {}

    public void Incluir();
        {}





    }
}
