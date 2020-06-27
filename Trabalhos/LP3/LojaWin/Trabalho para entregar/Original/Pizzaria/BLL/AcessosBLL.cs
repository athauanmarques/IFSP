using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using Pizzaria.DAL;
using Pizzaria.Modelos;

namespace Pizzaria.BLL
{
    public class AcessosBLL
    {
        AcessoDAL objAcessos = new AcessoDAL();
        ModelosAcesso acesso = new ModelosAcesso();

        public DataTable ListarAcessos()
        {
            return objAcessos.ListaAcesso();
        }

        public void IncluirAcesso(ModelosAcesso acesso)
        {
            objAcessos.IncluirAcesso(acesso);      
        }

     
    }
}
