using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Modelos;
using AcessaDados;
using System.Data;

namespace RegraNegocio
{
    /// <summary>
    /// Regra de Negocios são as definções e as funcionaridades que poderá fazer ou não. 
    /// </summary>

    public class ClienteBLL
    {
        //chama metodo do select
        public DataTable Listagem()
        {
            ClienteDAL obj = new ClienteDAL();
            return obj.Listagem(); // podera listrar
        }

        //chama metodo do filtro
        public DataTable Listagem(string filtro)
        {
            ClienteDAL obj = new ClienteDAL();
            return obj.Listagem(filtro);
        }

        //inserir dados
        public string Inserir(InfoCliente ic)
        {
            ClienteDAL obj = new ClienteDAL();
            return obj.Inserir(ic);
        }

        //alterar dados
        public string Alterar(int Id, string cliente, string telefone, string end)
        {
            ClienteDAL obj = new ClienteDAL();
            return obj.Alterar(Id, cliente, telefone, end);
        }

        //excluir dados
        public string Excluir(int Id)
        {
            ClienteDAL obj = new ClienteDAL();
            return obj.Excluir(Id);
        }
    }
}
