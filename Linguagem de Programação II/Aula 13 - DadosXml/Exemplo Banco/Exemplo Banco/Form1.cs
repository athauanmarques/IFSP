using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO; // acrescentar estas biblioteca
using System.Xml; // acrescentar estas biblioteca

namespace Exemplo_Banco
{
    public partial class Form1 : Form
    {
        DataSet ds = new DataSet(); // criando objetos globais um classe de banco
        DataTable dt;

        const string NOME_DA_PASTA = "C:/DadosXml/Clientes.xml"; // constante NÃO 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // criando uma condição para verificar que existe tabelas existe ou não (Try & Catch)
            try
            {
                ds.ReadXml("C:/DadosXml/Clientes.xml"); // vai ler o arquivo do direitório
                dt = ds.Tables[("clientes")]; //  vai criar tabela do nome "clientes"
            }
            catch
            {
                dt = new DataTable("clientes"); // estancia dataTable (classe da tabela)

                dt.Columns.Add("Codigo");    // classe.Coluna.adicionar = codigo
                dt.Columns.Add("Nome");
                dt.Columns.Add("Endereco");
                dt.Columns.Add("Cidade");
                dt.Columns.Add("Cep");
                dt.Columns.Add("Teledone");
                dt.Columns.Add("Email");

                
                ds.Tables.Add(dt); // vai criar tabelas com s informações citados   
            }

            dgvCadastrodos.DataSource = dt; // pegar os comandos try ou cath vai jogar no DataView


        }

        private void bntSalvar_Click(object sender, EventArgs e)
        {
            DataRow dr = dt.NewRow(); //estanciando DataRow (criando linhas novas)
            dr[0] = txtCodigo.Text;
            dr[1] = txtNome.Text;
            dr[2] = txtEndereco.Text;
            dr[3] = txtTelefone.Text;
            dr[4] = txtCidade.Text;
            dr[5] = txtCep.Text;
            dr[6] = txtEmail.Text;

            dt.Rows.Add(dr); // vai adicionar linha na classe dr
            ds.WriteXml("C:/DadosXml/Clientes.xml"); // vai escreve no diretório
            MessageBox.Show("Dados foram inserido com sucesso");
            Limpar();
            txtCodigo.Focus();

        }

        private void Limpar() // um metedo para limpar os dados digitados
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
            DataView dv = dt.DefaultView;
            dv.Sort = "nome asc"; // deixando em ordem alfabética crescente ("asc")
            dgvCadastrodos.DataSource = dt;


        }

        
    }
}
