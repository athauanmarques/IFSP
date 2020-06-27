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

        private void button1_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            //variavel armazena a string de conexão
            String strConn = ControleProjetos.Properties.Settings.Default["ProjetosConnectionString"].ToString();

            SqlConnection conn = new SqlConnection(strConn);
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Contato", conn);

            da.Fill(ds);
            dgvControle.DataSource = ds.Tables[0];

        }
    }
}
