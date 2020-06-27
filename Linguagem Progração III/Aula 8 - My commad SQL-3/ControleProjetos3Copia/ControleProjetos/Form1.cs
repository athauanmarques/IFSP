using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ControleProjetos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntCadastro_Click(object sender, EventArgs e)
        {
            CadastroEmpresa cd = new CadastroEmpresa();
            cd.Show();
        }

        private void btnCadContato_Click(object sender, EventArgs e)
        {
            CadastroContato cc = new CadastroContato();
            cc.Show();
        }

        private void btnCadControle_Click(object sender, EventArgs e)
        {
            CadastroControle cont = new CadastroControle();
            cont.Show();
        }
    }
}
