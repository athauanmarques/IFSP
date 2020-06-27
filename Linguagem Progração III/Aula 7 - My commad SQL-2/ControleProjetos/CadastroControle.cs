using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient; // usar a biblioteca SqlClient

namespace ControleProjetos
{
    public partial class CadastroControle : Form
    {
        DataSet ds = new DataSet(); // armazena todos os dados, é objeto que armazena
        SqlDataAdapter da = new SqlDataAdapter(); // consultando a tabela, utilizando objeto de connexão "conn"
        
        public CadastroControle()
        {
            InitializeComponent();
        
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region *Estanciando DataSet e Comando SQL*
            //variavel armazena a string de conexão
            // para é a sequencia verifica o caminho do App.config se não roda p banco
            String strConn = ControleProjetos.Properties.Settings.Default["ProjetosConnectionString"].ToString();
            
            //para manipular dados uso objetos Connection, objeto para chamar esta conexão
            SqlConnection conn = new SqlConnection(strConn);
            
            //objeto que recupera o registro do DataSet
            // SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Contato", conn); // consultando a tabela, utilizando objeto de connexão "conn"
            #endregion

            #region *Estanciando comando SqlCommand*
            da.SelectCommand = new SqlCommand(); // estanciando comando
            da.SelectCommand.CommandText = "SELETC * FROM Contatado"; //
            da.SelectCommand.Connection = conn;
            #endregion

            #region *Inserindo dados*
            da.InsertCommand = new SqlCommand();
            da.InsertCommand.CommandText = "INSERT INTO Contato (EmpresaID,Nome,Cargo,Telefone,Celular,Endereco,Cidade,UF,CEP,Email,DataNascimento,Observacao) values  (@EmpresaID,@Nome,@Cargo,@Telefone,@Celular,@Endereco,@Cidade,@UF,@CEP,@Email,@DataNascimento,@Observacao)";
//          @ é indicação do usuário vai digitar, Qd usamos parametros -@- comando SQL adicionar os mesmo Na coleção do comando

            da.InsertCommand.Parameters.Add("@EmpresaID", SqlDbType.Int,4, "EmpresaID"); //espeficicando os paramentros
            da.InsertCommand.Parameters.Add("@Nome", SqlDbType.VarChar, 50, "Nome");
            da.InsertCommand.Parameters.Add("@Cargo", SqlDbType.VarChar, 50, "Cargo");
            da.InsertCommand.Parameters.Add("@Telefone", SqlDbType.VarChar, 50, "Telefone");
            da.InsertCommand.Parameters.Add("@Celular", SqlDbType.VarChar, 15, "Celular");
            da.InsertCommand.Parameters.Add("@Endreco", SqlDbType.VarChar, 50, "Endreco");
            da.InsertCommand.Parameters.Add("@Cidade", SqlDbType.VarChar, 50, "Cidade");
            da.InsertCommand.Parameters.Add("@UF", SqlDbType.VarChar, 2, "UF");
            da.InsertCommand.Parameters.Add("@CEP", SqlDbType.VarChar, 9, "CEP");
            da.InsertCommand.Parameters.Add("@Email", SqlDbType.VarChar, 50, "Email");
            da.InsertCommand.Parameters.Add("@DataNascimento", SqlDbType.DateTime, 50, "DataNascimento");
            da.InsertCommand.Parameters.Add("@Observacao", SqlDbType.Text, 50, "Observacao");
            da.UpdateCommand.Parameters.Add("@ContatoID", SqlDbType.Int, 50, "Contato"); // inserindo o ID da tabela
            
            da.InsertCommand.Connection = conn; // connectando ao comando estanciado SqlCommand
            #endregion

            #region *Deletando Dados*
            da.DeleteCommand = new SqlCommand();
            da.DeleteCommand.CommandText = "DELETE FROM Contato WHERE ContatoID = @ContatoID";
            da.DeleteCommand.Parameters.Add("@ContatoID", SqlDbType.Int, 4, "ContatoID");
            da.DeleteCommand.Connection = conn;
            #endregion

            #region *Atualização - Update*
            da.UpdateCommand = new SqlCommand();
            da.UpdateCommand.CommandText = "UPDATE Contato SET EmpresaID = @EmpresaID, Nome = @Nome, Cargo = @Cargo, Telefone = @Telefone, Celular = @Celular, Endereco = @Endereco, Cidade = @Cidade, UF = @UF, CEP= @CEP,Email = @Email, DataNascimento = @DataNascimento, Observacao = @Observacao";
           
            //objeto do DataAdapter que preenche com objetos do dataSet
            da.Fill(ds); //Fill pega a seleção objeto "da(DataAdapter)" e joga no "ds (DataSet)"
            //da.Fill(ds, "Contatos"); poderemos fazer dessa forma somente para saber qual tabela que estamos manipulando
            //DataAdapter relariza consultas
            #endregion

            #region *Preenche o DataSet*
            /*
             Preenche o DataSet
              DataSet Tem indice 0 para 1ªtabela 1 para 2ª tabela
             */
            dgvControle.DataSource = ds.Tables[0];
            //dgvControle.DataSource = ds.Tables["Contatos"];

            #endregion
            
            #region *Listar no listbox*

            lbListaData.DataSource = ds.Tables[0]; //DataSource fonte do Banco
            lbListaData.DisplayMember = "Nome"; // exibir membro
            lbListaData.ValueMember = "ContatoId";// vai amazenar valor na tabela no id "ContatoId"
            
            #endregion 
        }

        private void bntTabela_Click(object sender, EventArgs e)
        {
            #region *Estanciando tabela*

            DataTable dt = new DataTable(); // estanciando objeto para amazena na tabela
            dt.TableName = "Estado"; // criando tabela com nome Estado
            
            #endregion

            #region *Criando colunas*
            //coluna 1
            DataColumn estadoId = new DataColumn();
            estadoId.ColumnName = "pkEstadoId";
            estadoId.DataType = System.Type.GetType("System.Int32"); // informando o tipo do dado
            estadoId.ReadOnly = true; // vai apenas ler o arquivo
            estadoId.AllowDBNull = false; // não se receber nulls
            estadoId.Unique = true;
            estadoId.AutoIncrement = true; // auto incremento para 
            estadoId.AutoIncrementSeed = 1;
            estadoId.AutoIncrementStep = 1;
            estadoId.Caption = "Codigo"; // vai aparecer na tela
            //coluna 2
            DataColumn estado = new DataColumn();
            estado.ColumnName = "Estado";
            estado.DataType = System.Type.GetType("System.String"); // informando o tipo
            estado.AllowDBNull = false;
            estado.Unique = true;
            #endregion

            // adicionar as colunas na tabela
            dt.Columns.Add(estadoId);
            dt.Columns.Add(estado);

            //popular tabela
            DataRow row; // criando linha
            row = dt.NewRow(); // criando uma nova linha da tabela do objeto dt
            row["Estado"] = "PR"; // inserindo a palavra PR
            dt.Rows.Add(row); //

            //criar dataset
            ds.Tables.Add(dt);

        }

        private void bntVisualizar_Click(object sender, EventArgs e)
        {
            //Mostrando a tabela
            lbListaData.DataSource = ds.Tables["Estado"];
            lbListaData.DisplayMember = "Estado";
            lbListaData.ValueMember = "pkEstadoId";

            da.Update(ds.Tables[0]);

        }

        private void CadastroControle_Load(object sender, EventArgs e)
        {

        }
    }
}
