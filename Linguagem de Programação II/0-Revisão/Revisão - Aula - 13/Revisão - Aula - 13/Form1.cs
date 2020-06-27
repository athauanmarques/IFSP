using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // Banco de dados
using System.Xml; // arquivo em xml

namespace Revisão___Aula___13
{
    public partial class frmCadastro : Form
    {

        DataSet ds = new DataSet(); // estanciar o Bandco de dados
        DataTable dt; // Tabelas do banco de dados

        const string NOME_DA_PASTA = "C:/DadosXml/Clientes.xml"; 
        // Não é uma constante, vai direncionar e salvar neste diretório

        public frmCadastro()
        {
            
            InitializeComponent();
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            try
            {

                ds.ReadXml("C:/DadosXml/Clientes.xml"); // vai ler o diretório
                dt = ds.Tables[("clientes")]; //  vai criar tabela do nome "clientes"

            }

            catch
            {

                dt = new DataTable("clientes"); //Estanciando dataTable com o nome Clientes

                dt.Columns.Add("codigo"); // adicionando colunas na tabela e seus exceptivos nomes
                dt.Columns.Add("Nome");
                dt.Columns.Add("Endereco");
                dt.Columns.Add("Cidade");
                dt.Columns.Add("cep");
                dt.Columns.Add("telefone");
                dt.Columns.Add("email");

                ds.Tables.Add(dt); // vai criar tabelas com s informações citados   
            }

            dgvCadastro.DataSource = dt; // pegar os comandos try ou cath vai jogar no DataView

        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            //aqui esta inserindo dados para tabela do que o usuário informar

            DataRow dr = dt.NewRow(); //estanciando DataRow (criando linhas novas)
            dr[0] = txtCodigo.Text;
            dr[1] = txtNome.Text;
            dr[2] = txtEndereco.Text;
            dr[3] = txtEmail.Text;
            dr[4] = txtCidade.Text;
            dr[5] = txtCep.Text;
            dr[6] = txtTelefone.Text;

            dt.Rows.Add(dr); // vai adicionar linha na classe dr, que foi criando no contexto acima
            ds.WriteXml("C:/DadosXml/Clientes.xml"); // vai escreve no diretório
            MessageBox.Show("Dados foram inserido com sucesso");
            Limpar(); // função criado
            txtCodigo.Focus(); // focar no textBox Codigo;

        }

        private void Limpar() // um método para limpar os dados digitados
        {

            txtCodigo.Clear();
            txtNome.Clear();
            txtEndereco.Clear();
            txtTelefone.Clear();
            txtCidade.Clear();
            txtCep.Clear();
            txtEmail.Clear();

        }

        private void bntOrdenar_Click(object sender, EventArgs e)
        {
            ds.Clear(); // limpar a dataSet
            ds.ReadXml("C:/DadosXml/Clientes.xml");
            DataView dv = dt.DefaultView; // função para ordenar
            dv.Sort = "nome asc"; // deixando em ordem alfabética crescente ("asc")
            dgvCadastro.DataSource = dt;
        }

        
    }
}
