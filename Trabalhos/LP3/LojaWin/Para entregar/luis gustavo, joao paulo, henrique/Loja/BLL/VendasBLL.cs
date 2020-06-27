using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Loja.DAL;
using Loja.Modelos;


namespace Loja.BLL
{
    public class VendasBLL
    {

        //Este é um campo privado para armazenar uma instância da classe DAL.
        private VendasDAL objDAL;

        //Esse é o construtor da classe VendasBLL
        public VendasBLL()
        {
            objDAL = new VendasDAL();
        }

        public DataTable ListaDeProdutos
        {
            get
            {
                return objDAL.ListaDeProdutos;
            }
        }

        public DataTable ListaDeClientes
        {
            get
            {
                return objDAL.ListaDeClientes;
            }
        }

        public void Incluir(VendaInformation venda)
        {
            //a venda não pode ser negativa
            if (venda.Quantidade < 0)
            {
                throw new Exception("A quantidade não pode ser negativa.");
            }
            
            //a venda não pode ser de zero produtos
            if (venda.Quantidade == 0)
            {
                throw new Exception("A venda não pode conter \"zero produtos\".");
            }

            // O estoque do produto não pode ser negativo
            int quantEstoque = objDAL.QuantidadeEstoque(venda);

            if (quantEstoque < venda.Quantidade)
            {
               throw new Exception("A quantidade no estoque não é suficiente para a venda.");
            }
            else
                objDAL.Incluir(venda);

        }
    }
}
