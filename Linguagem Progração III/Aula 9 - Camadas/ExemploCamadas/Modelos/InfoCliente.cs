using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Modelos
{
    /// <summary>
    ///  São informações de variavel que seram utilizados, em outras palavras é um Interface.
    /// </summary>

    public class InfoCliente
    {
        private int idcliente;
        private string cliente;
        private string telefone;
        private string endereco;

        /// <summary>
        /// Os Métodos só vão pegar os valores
        /// </summary>

        public int Idcliente
        {
            get { return idcliente; }
            set { idcliente = value; }
        }
        public string Cliente
        {
            get { return cliente; }
            set { cliente = value; }
        }
        public string Telefone
        {
            get { return telefone; }
            set { telefone = value; }
        }
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
    }
}
