using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using LojaWin.Dal;
using LojaWin.Modelos;

namespace LojaWin.Bll
{
    public class VendasBll
    {
        VendasDal objVendasDal = new VendasDal();
        public DataTable ListaProdutos
        {
            get
            {
                return objVendasDal.ListaProdutos;
            }
        }

        public DataTable ListaClientes
        {
            get
            {
                return objVendasDal.ListaClientes;
            }
        }

        public void inserir(ModeloVendas venda, ModeloItensVendas itens)
        {
            try
            {
                objVendasDal.inserir(venda, itens);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public void InserirItensVenda(ModeloVendas venda, ModeloItensVendas itens)
        {
            try
            {
                objVendasDal.inserirItensVenda(venda, itens);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public decimal MostrarValorVenda(ModeloVendas venda)
        {
            return objVendasDal.mostrarValorVenda(venda);
        }

        public DataTable ListarVendas()
        {
            return objVendasDal.listarVendas();
        }
    }
}
