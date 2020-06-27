using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula___5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bntIncluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incluindo Fera", "Incluir"); // mensaggem, titulo
        }

        private void bntAlterar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja alterar?", "Alteração", MessageBoxButtons.YesNo);
        }

        private void bntExcluir_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Deseja excluir?", "Excluir", MessageBoxButtons.YesNo);
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
          

                this.Close();
            
        }

      
    }
}
