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
    public partial class CadastroEmpresa : Form
    {
        public CadastroEmpresa()
        {
            InitializeComponent();
        }

        private void empresasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.empresasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetosDataSet);

        }

        private void empresasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.empresasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projetosDataSet);

        }

        private void CadastroEmpresa_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projetosDataSet1.TipoEmpresa' table. You can move, or remove it, as needed.
            this.tipoEmpresaTableAdapter.Fill(this.projetosDataSet1.TipoEmpresa);
            // TODO: This line of code loads data into the 'projetosDataSet.Empresas' table. You can move, or remove it, as needed.
            this.empresasTableAdapter.Fill(this.projetosDataSet.Empresas);

        }
    }
}
