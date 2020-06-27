using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diagrama
{
    interface ICursos
    {
        // propriedades
        string Codigo
        { get; }
        string Curso
        { set; get; }
        string Duracao
        { get; }
        string Preco
        { set; get; }

        // Metodos

        public abstract void Alterar();
        public abstract void Buscar();
        public abstract void Excluir();
        public abstract void Incluir();




    }
}
