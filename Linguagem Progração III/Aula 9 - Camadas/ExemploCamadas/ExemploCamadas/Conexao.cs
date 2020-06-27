using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Modelos;
using AcessaDados;
using RegraNegocio;
using MySql.Data.MySqlClient;

namespace ExemploCamadas
{
    public partial class Conexao : Form
    {
        public Conexao()
        {
            InitializeComponent();
        }

        public MySqlConnection c = new MySqlConnection();
        public string Status = "";

        public void Conectar()
        {
            string s = "Server='localhost';Database='pizzaria';Uid='root';Pwd='a0405'";
            c.ConnectionString = s;
            c.Open();
            Status = "Conexão aberta!!";
        }

        public void Desconectar()
        {
            c.Close();
            Status = "Conexão Fechada!!";
        }


        private void btnConecta_Click(object sender, EventArgs e)
        {
            Conectar();
            lblStatus.Text = "Mensagem DB: " + Status;
        }

        private void btnDesconecta_Click(object sender, EventArgs e)
        {
            Desconectar();
            lblStatus.Text = "Mensagem DB: " + Status;
        }

        private void Conexao_Load(object sender, EventArgs e)
        {

        }

        
       
    }
}
