using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using LojaWin.Modelos;
using LojaWin.Bll;

namespace LojaWin
{
    public partial class frmFichaClientes : Form
    {
        ModeloClientes cliente = new ModeloClientes();
        ClientesBll objCliente = new ClientesBll();
        public frmFichaClientes()
        {
            InitializeComponent();
        }

        private void frmFichaClientes_Load(object sender, EventArgs e)
        {
            AtualizaGrid();
            FormataGrid();
        }

        private void AtualizaGrid()
        { 
            try
            {
            string filtro = "";
            dgvClientes.DataSource = objCliente.listagem(filtro);
            
            }
                catch 
            {
                MessageBox.Show("Não foi impossivel imprimir a ficha do cliente!");
            } 
           
        
        }
        private void FormataGrid()
        { 
        
            try
            {
            
                dgvClientes.Columns[0].HeaderText = "IdCliente";
                dgvClientes.Columns[0].Width = 60;
                dgvClientes.Columns[1].HeaderText = "Cliente";
                dgvClientes.Columns[1].Width = 60;
                dgvClientes.Columns[2].HeaderText = "e-mail";
                dgvClientes.Columns[2].Width = 60;
                dgvClientes.Columns[3].HeaderText = "Telefone";
                dgvClientes.Columns[3].Width = 60;
         
            } 

            catch 
            {
                MessageBox.Show("Não foi impossivel imprimir a ficha do cliente!");
            } 
           
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string strDadosCliente;
            //a Classe Graphics é responsável pela a exibição pela informações na tela
            //e na impressora.
            //Chr(10) pula para linha de baixo
            Graphics objImpressao = e.Graphics;
            objImpressao.DrawString("FICHA DO CLIENTE", new System.Drawing.Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, 50, 50);
            strDadosCliente = "Identificação de Cliente: " + dgvClientes.CurrentRow.Cells[0].Value.ToString() + Chr(10) + Chr(10); 
            strDadosCliente += "Nome do Cliente: " + dgvClientes.CurrentRow.Cells[1].Value.ToString() + Chr(10) + Chr(10);
            strDadosCliente += "E-mail: " + dgvClientes.CurrentRow.Cells[2].Value.ToString() + Chr(10) + Chr(10);
            strDadosCliente += "Telefone: " + dgvClientes.CurrentRow.Cells[3].Value.ToString() + Chr(10) + Chr(10);

            //Configuração do tipo de fonte para ser impressa no documento e as distâncias em relação as margens.
            objImpressao.DrawString(strDadosCliente, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, 50, 50);
       
            
        }

        public char Chr(int codigo)
            {
            
                return (char)codigo;
            }

        private void bntImprimir_Click(object sender, EventArgs e)
        {
            //O componete PrintDialog é responsável pela abertura da caixa de dialogo
            // para configuração de impressão.
            if(printDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDoc.DocumentName = "Ficha de Cadastro do cliente";
                //o Método Print() envia o documento para impressora
                printDoc.Print();

            }
            else 
            {
                MessageBox.Show("A impressão não é válida!", "Erro");
            
            }
        }

        private void bntVisualizar_Click(object sender, EventArgs e)
        {
            printPreview.ShowDialog();
        }

        private void bntCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
    
}
