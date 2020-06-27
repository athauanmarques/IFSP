using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Revisão___Aula___9
{
    public partial class Mensalidade : Form
    {
        public Mensalidade()
        {
            InitializeComponent();
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtCurso.Clear();
            txtGraduacao.Clear();
            txtMensalidade.Clear();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                
                double valorGraduação = Convert.ToDouble(txtGraduacao.Text);

                if (rdbMestrado.Checked)
                {

                    Mestrado mes = new Mestrado();
                    mes.VlrGraduacao = Convert.ToDouble(txtMensalidade.Text); // tá mandando para classe Mestrado o valor
                    mes.MestradoCal(); // vai fazer o calculo no classe mestrado(mes), metodo MestradoCal()

                    txtMensalidade.Text = mes.resultado.ToString();
                
                }
            
            
                if(rdbDoutorado.Checked)
                {

                    Doutorado dou = new Doutorado();
                    dou.VlrGraduacao = Convert.ToDouble(txtGraduacao.Text);
                    dou.DouCal();

                    txtMensalidade.Text = dou.resultado.ToString();

                
                }
            
            
 
            }
            catch
            {

                MessageBox.Show("Informe valores corretamente","Erro na digitação");
            
            }




        }
    }
}
