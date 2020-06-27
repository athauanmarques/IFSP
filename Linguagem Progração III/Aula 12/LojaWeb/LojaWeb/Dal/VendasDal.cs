using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using LojaWin.Modelos;

namespace LojaWin.Dal
{
    public class VendasDal
    {
        MySqlConnection conn = new MySqlConnection(Dados.conexao);
        MySqlCommand cmdVendas = new MySqlCommand();
        MySqlCommand cmdItensVenda = new MySqlCommand();
        MySqlCommand cmdAtualizaVendas = new MySqlCommand();
        MySqlCommand cmdProdutos = new MySqlCommand();

        public DataTable ListaProdutos
        {
            get
            {
                DataTable tbListaProdutos = new DataTable();
                string sqlListaProdutos;
                sqlListaProdutos = "select * from produtos";
                MySqlDataAdapter daProdutos = new MySqlDataAdapter(sqlListaProdutos, conn);
                daProdutos.Fill(tbListaProdutos);
                return tbListaProdutos;
            }
        }

        public DataTable ListaClientes
        {
            get
            {
                DataTable tbListaClientes = new DataTable();
                string sqlListaClientes;
                sqlListaClientes = "select* from clientes";
                MySqlDataAdapter daClientes = new MySqlDataAdapter(sqlListaClientes, conn);
                daClientes.Fill(tbListaClientes);
                return tbListaClientes;
            }
        }

        // O método inserir fará operações que afetarão mais de uma tabela,
        // ou seja, inserção na tabela vendas e atualização na tabela produtos.
        public void inserir(ModeloVendas venda, ModeloItensVendas itens)
        {
            string sqlInserirVenda, sqlAtualizarEstoqueProduto;

            // Transação é uma operação que afeta duas ou mais tabelas simultâneas
            // no banco de dados. Neste caso, ocorrerão quatro operações:
            // A primeira fará inserção de dados na tabela vendas;
            // A segunda atualizará o estoque da tabela produtos;
            // A terceira armazenará dados (inserir) na tabela itens_venda;
            // A quarta calcula e atualiza o valor da venda.
            // Inicializa-se o objeto t com um valor nulo.
            MySqlTransaction t = null;
            try
            {
                // inserção de vendas. Modificar os parâmetros com prefixo p para @, porque
                // o .NET reconhece apenas o @ como configuração de parâmetro. Já as
                // stored procedures do MySql somente aceitam os parâmetros com prefixo p
                // ou qualquer letra do alfabeto exceto caracteres especiais como o @.
                cmdVendas.Connection = conn;
                sqlInserirVenda = @"insert into vendas(idcliente, data, valor)values
                                (@idcliente, @data, @valor);
                                 select idvenda from vendas where idvenda = LAST_INSERT_ID();";
                cmdVendas.CommandText = sqlInserirVenda;

                // Atualização do estoque
                cmdProdutos.Connection = conn;
                sqlAtualizarEstoqueProduto = @"update produtos set estoque = estoque - @quantidade
                                             where idproduto = @idproduto and estoque >= @quantidade";
                cmdProdutos.CommandText = sqlAtualizarEstoqueProduto;
                conn.Open();
                // O objeto Command inicia a primeira transação, configurando o ínicio
                // da transação com o nivel de isolamento serializable. Este é o tipo
                // mais restrito, não permite a leitura, a atualização, inclusão ou
                // exclusão de algum registro da tabela que está sendo lido, até que
                // se encontre o comando commit ou rollback.
                t = conn.BeginTransaction(IsolationLevel.Serializable);
                // O objeto t é vinculado à propriedade transaction do objeto command
                // cmdVendas.
                cmdVendas.Transaction = t;
                cmdProdutos.Transaction = t;

                // Parâmetros de inserção da tabela vendas
                cmdVendas.Parameters.Clear();
                cmdVendas.Parameters.AddWithValue("@idcliente", venda.Idcliente);
                cmdVendas.Parameters.AddWithValue("@data", venda.Data);
                cmdVendas.Parameters.AddWithValue("@valor", venda.Valor);

                // Parâmetros de atualização do produto
                cmdProdutos.Parameters.Clear();
                cmdProdutos.Parameters.AddWithValue("@idproduto", itens.Idproduto);
                cmdProdutos.Parameters.AddWithValue("@quantidade", itens.Quantidade);

                // O metodo ExecuteScalar retorna um único valor, no caso, idvenda
                // gerado automaticamente pelo banco.
                venda.Idvenda = Convert.ToInt32(cmdVendas.ExecuteScalar());

                // O método ExecuteNomQuery executa o comando update na tabela produtos.
                // Ele não efetua nenhum retorno do banco de dados.
                cmdProdutos.ExecuteNonQuery();

                // Validação da transação através do método Commit. Executa-se
                // a transação nas duas tabelas simultaneamente(vendas e produtos)
                t.Commit();
            }
            catch (MySqlException ex)
            {
                t.Rollback();
                throw new Exception(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        //Médodo de inserção de dados na tabela itens_venda e atualização
        // do valor da venda na tabela vendas.
        public void inserirItensVenda(ModeloVendas venda, ModeloItensVendas itens)
        {
            string sqlItensVenda, sqlAtualizarVenda;
            MySqlTransaction t = null;
            try
            {
                // Inserção da tabela itens_Venda
                cmdItensVenda.Connection = conn;
                sqlItensVenda = @"insert into itens_venda(idvenda, idproduto,
                                valor_produto, quantidade)values(@idvenda,
                                @idproduto, @valor_produto, @quantidade)";
                cmdItensVenda.CommandText = sqlItensVenda;

                // Atualização do valor da venda na tabela vendas
                cmdAtualizaVendas.Connection = conn;
                sqlAtualizarVenda = @"update vendas set valor = @quantidade * @preco
                                    where idvenda = @idvenda";
                cmdAtualizaVendas.CommandText = sqlAtualizarVenda;

                // Abertura do banco
                conn.Open();
                // Configuração da transação
                t = conn.BeginTransaction(IsolationLevel.Serializable);

                cmdItensVenda.Transaction = t;
                cmdAtualizaVendas.Transaction = t;

                // Parâmetros de Inserção da tabela itens_venda
                cmdItensVenda.Parameters.Clear();
                cmdItensVenda.Parameters.AddWithValue("@idvenda", venda.Idvenda);
                cmdItensVenda.Parameters.AddWithValue("@idproduto", itens.Idproduto);
                cmdItensVenda.Parameters.AddWithValue("@valor_produto", itens.ValorProduto);
                cmdItensVenda.Parameters.AddWithValue("@quantidade", itens.Quantidade);

                // Parâmetros de Atualização do valor da venda
                cmdAtualizaVendas.Parameters.AddWithValue("@idvenda", venda.Idvenda);
                cmdAtualizaVendas.Parameters.AddWithValue("@quantidade", itens.Quantidade);
                cmdAtualizaVendas.Parameters.AddWithValue("@preco", itens.ValorProduto);

                // Execução das transações
                cmdItensVenda.ExecuteNonQuery();
                cmdAtualizaVendas.ExecuteNonQuery();
                t.Commit();
            }
            catch (MySqlException ex)
            {
                t.Rollback();
                throw new Exception(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        public decimal mostrarValorVenda(ModeloVendas objVenda)
        {
            try
            {
                MySqlCommand cmdVendaTotal = new MySqlCommand();
                ModeloVendas venda = new ModeloVendas();
                string sqlVendaTotal;
                sqlVendaTotal = @"select valor from vendas where idvenda = @idvenda
                            and idcliente = @idcliente";
                cmdVendaTotal.CommandText = sqlVendaTotal;
                cmdVendaTotal.Parameters.Clear();
                cmdVendaTotal.Parameters.AddWithValue("@idvenda", objVenda.Idvenda);
                cmdVendaTotal.Parameters.AddWithValue("@idcliente", objVenda.Idcliente);
                cmdVendaTotal.Connection = conn;
                conn.Open();
                MySqlDataReader drVenda = cmdVendaTotal.ExecuteReader();
                while (drVenda.Read())
                {
                    venda.Valor = Convert.ToDecimal(drVenda["valor"].ToString());
                }
                return venda.Valor;
            }
            catch (MySqlException ex)
            {
                throw new Exception(ex.StackTrace);
            }
            finally
            {
                conn.Close();
            }
        }

        // Método ListarVendas
        public DataTable listarVendas()
        {
            DataTable tbVendas = new DataTable();
            string sqlListaVendas;
            sqlListaVendas = @"select vendas.idvenda, clientes.nome,vendas.data,
                             produtos.produto, itens_venda.valor_produto,
                             itens_venda.quantidade, vendas.valor, produtos.estoque
                             from vendas inner join itens_venda on
                             vendas.idvenda = itens_venda.idvenda
                             inner join produtos on 
                             itens_venda.idproduto = produtos.idproduto
                             inner join clientes on 
                             clientes.idcliente = vendas.idcliente";
            MySqlDataAdapter da = new MySqlDataAdapter(sqlListaVendas, conn);
            da.Fill(tbVendas);
            return tbVendas;
        }
    }
}
