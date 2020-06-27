using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Interfaces
{
     public class Funcionario : Conexao, ICadastro
    {
         // os valores que vai se jogado no ICadastro

        private string stauts;
        private int codigo;
        private string nome;
         
        string Stauts
        { get {return status;} }
         
         int Codigo
         {
         set { codigo = value; }
         get { return codigo;}
            }

         public string Nome
         {
             set { nome = value; }
             get { return nome; }
         }
    }
}
