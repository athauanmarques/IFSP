using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ControleProjetos
{
    public partial class CadastroControle : Form
    {
        public CadastroControle()
        {
            InitializeComponent();
        }
        
        DataSet ds = new DataSet();
        SqlDataAdapter da = new SqlDataAdapter();
                
        private void button1_Click(object sender, EventArgs e)
        {
            

            //variavel armazena a string de conexão
            String strConn = ControleProjetos.Properties.Settings.Default["ProjetosConnectionString"].ToString();

            SqlConnection conn = new SqlConnection(strConn);
            //SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Contato", conn);

            da.SelectCommand = new SqlCommand();
            da.SelectCommand.CommandText = "SELECT * FROM Contato";
            da.SelectCommand.Connection = conn;

            da.InsertCommand = new SqlCommand();
            da.InsertCommand.CommandText = "INSERT INTO Contato(EmpresaId, Nome, Cargo, Telefone, Celular, Endereco, Cidade, Uf,Cep, Email, DataNascimento, Observacao)Values (@EmpresaId, @Nome, @Cargo, @Telefone, @Celular, @Endereco, @Cidade, @Uf,@Cep, @Email, @DataNascimento, @Observacao)";

            //Qd usamos parametros -@-no comando SQLvamos adicionar os mesmos
            //na coleção do comando
            da.InsertCommand.Parameters.Add("@EmpresaId", SqlDbType.Int, 4, "EmpresaId");
            da.InsertCommand.Parameters.Add("@Nome", SqlDbType.VarChar, 50, "Nome");
            da.InsertCommand.Parameters.Add("@Cargo", SqlDbType.VarChar, 50, "Cargo");
            da.InsertCommand.Parameters.Add("@Telefone", SqlDbType.VarChar, 15, "Telefone");
            da.InsertCommand.Parameters.Add("@Celular", SqlDbType.VarChar, 15, "Celular");
            da.InsertCommand.Parameters.Add("@Endereco", SqlDbType.VarChar, 50, "Endereco");
            da.InsertCommand.Parameters.Add("@Cidade", SqlDbType.VarChar, 50, "Cidade");
            da.InsertCommand.Parameters.Add("@Uf", SqlDbType.VarChar, 2, "Uf");
            da.InsertCommand.Parameters.Add("@Cep", SqlDbType.VarChar, 9, "Cep");
            da.InsertCommand.Parameters.Add("@Email", SqlDbType.VarChar, 50, "Email");
            da.InsertCommand.Parameters.Add("@DataNascimento", SqlDbType.DateTime, 8, "DataNascimento");
            da.InsertCommand.Parameters.Add("@Observacao", SqlDbType.Text, 50, "Observacao");

            da.InsertCommand.Connection = conn;

            ////Atualização
            da.UpdateCommand = new SqlCommand();
            da.UpdateCommand.CommandText = "UPDATE Contato SET EmpresaId = @EmpresaId, Nome  = @Nome, Cargo = @Cargo, Telefone=@Telefone, Celular = @Celular, Endereco = @Endereco, Cidade = @Cidade, Uf = @Uf, Cep = @Cep, Email = @Email,DataNascimento = @DataNascimento, Observacao = @Observacao WHERE ContatoId = @ContatoId";

            da.UpdateCommand.Parameters.Add("@EmpresaId", SqlDbType.Int, 4, "EmpresaId");
            da.UpdateCommand.Parameters.Add("@Nome", SqlDbType.VarChar, 50, "Nome");
            da.UpdateCommand.Parameters.Add("@Cargo", SqlDbType.VarChar, 50, "Cargo");
            da.UpdateCommand.Parameters.Add("@Telefone", SqlDbType.VarChar, 15, "Telefone");
            da.UpdateCommand.Parameters.Add("@Celular", SqlDbType.VarChar, 15, "Celular");
            da.UpdateCommand.Parameters.Add("@Endereco", SqlDbType.VarChar, 50, "Endereco");
            da.UpdateCommand.Parameters.Add("@Cidade", SqlDbType.VarChar, 50, "Cidade");
            da.UpdateCommand.Parameters.Add("@Uf", SqlDbType.VarChar, 2, "Uf");
            da.UpdateCommand.Parameters.Add("@Cep", SqlDbType.VarChar, 9, "Cep");
            da.UpdateCommand.Parameters.Add("@Email", SqlDbType.VarChar, 50, "Email");
            da.UpdateCommand.Parameters.Add("@DataNascimento", SqlDbType.DateTime, 8, "DataNascimento");
            da.UpdateCommand.Parameters.Add("@Observacao", SqlDbType.Text, 50, "Observacao");
            //inserir contato
            da.UpdateCommand.Parameters.Add("@ContatoId", SqlDbType.Int, 4, "ContatoId");

            da.UpdateCommand.Connection = conn;


            //delete
            da.DeleteCommand = new SqlCommand();
            da.DeleteCommand.CommandText = "DELETE FROM Contato WHERE ContatoId = @ContatoId";
            da.DeleteCommand.Parameters.Add("@ContatoId", SqlDbType.Int, 4, "ContatoId");
            da.DeleteCommand.Connection = conn;

            da.Fill(ds,"Contato");
            dgvControle.DataSource = ds.Tables["Contato"];

            //Listar no Listbox
            listBox1.DataSource = ds.Tables["Contato"];
            listBox1.DisplayMember = "Nome";
            listBox1.ValueMember = "ContatoId";

        }

        private void btnAtualiza_Click(object sender, EventArgs e)
        {
            da.Update(ds.Tables["Contato"]); 
            
        }

        private void CadastroControle_Load(object sender, EventArgs e)
        {

        }
    }
}
