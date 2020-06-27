using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocios; // Devemos add a classe negocios aqui na biblioteca (Negocio é ClassLibrary que é um projeto de Classe )

namespace loja
{
    public partial class FrmProdutos : Form // tem pega add referencias no Projeto loja
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            // Negocios.Produtos - é uma outra maneira de estanciar a Classe produto
             
            Produtos pd = new Produtos();
            pd.codigo = Convert.ToInt32(txtCodigo.Text);
            pd.Incluir(); // devemos colocar para excutar o metodo 

            lblStatusP.Text = pd.status; 
            

        }
    }
}
