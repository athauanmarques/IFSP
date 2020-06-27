using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using Pizzaria.Modelos;
using Pizzaria.BLL;


namespace PizzariaMania
{
    public partial class frmTabelaPreco : MetroForm
    {
        public frmTabelaPreco()
        {
            InitializeComponent(); 
           
           
        }

        ModelosTabelaPizza pizzas = new ModelosTabelaPizza();
        TabelaPizzaBLL objPizzas = new TabelaPizzaBLL();
        //string mensagem = ;

        private void Form1_Load(object sender, EventArgs e)
        {
            ListarTabela();
            tbMenuTabela.SelectedIndex = 0;

            txtExcPizza.Text = dgvPizzas[0, dgvPizzas.CurrentRow.Index].Value.ToString();
            txtExcSabor.Text = dgvPizzas[1, dgvPizzas.CurrentRow.Index].Value.ToString();

            txtAltSabor.Text = dgvPizzas[1, dgvPizzas.CurrentRow.Index].Value.ToString();
            txtAltPequena.Text = dgvPizzas[3, dgvPizzas.CurrentRow.Index].Value.ToString();
            txtAltMedia.Text = dgvPizzas[4, dgvPizzas.CurrentRow.Index].Value.ToString();
            txtAltGrande.Text = dgvPizzas[5, dgvPizzas.CurrentRow.Index].Value.ToString();
            txtAltInformacoes.Text = dgvPizzas[2, dgvPizzas.CurrentRow.Index].Value.ToString();
           
            if (Globais.opEditarPizza == 0)
            {
                tbMenuTabela.SelectedTab = tpAdicionar;
            }
            else if (Globais.opEditarPizza == 1)
            {
                tbMenuTabela.SelectedTab = tpAlterar;
            }
            else
            {

                tbMenuTabela.SelectedTab = tbRemover;
            }
            
        }

        public void LimparCampos()
        {

             txtAltSabor.Clear();
             txtAltPequena.Clear();
             txtAltMedia.Clear();
             txtAltGrande.Clear();
             txtAltInformacoes.Clear();

             txtAdiSabores.Clear();
             txtAdiPequena.Clear();
             txtAdiMedia.Clear();
             txtAdiGrande.Clear();
             txtAdiInfomacoes.Clear();
              
           }
        

        public void ListarTabela()
        { 
        string filtro = "";
            try  
            {
                

                    dgvPizzas.DataSource = objPizzas.ListarTabela(filtro);
   

            }
            catch
            {
                MessageBox.Show("Não foi possível a conexão com o banco de dados!", "Erro");
               
            }
    
            finally
            {
                Formata();
            }
            
            }
         
    
    public void Formata()
        {

            try
            {
                dgvPizzas.Columns[0].HeaderText = "Código";
                dgvPizzas.Columns[0].Width = 70;
                dgvPizzas.Columns[1].HeaderText = "Sabor";
                dgvPizzas.Columns[1].Width = 80;
                dgvPizzas.Columns[2].HeaderText = "Informações";
                dgvPizzas.Columns[2].Width = 180;
                dgvPizzas.Columns[3].HeaderText = "Preço Pequena";
                dgvPizzas.Columns[3].Width = 80;
                dgvPizzas.Columns[4].HeaderText = "Preço Média";
                dgvPizzas.Columns[4].Width = 80;
                dgvPizzas.Columns[5].HeaderText = "Preço Grande";
                dgvPizzas.Columns[5].Width = 80;
                

            }
              catch
                {
                    txtAltSabor.Clear();
                    txtAdiPequena.Clear();
                    txtAdiMedia.Clear();
                    txtAdiGrande.Clear();
                    txtAdiInfomacoes.Clear();
                   
                }

        }

    //função Asc - não permite o usuário digitar caracteres
    private int Asc(string letra) // vai pegar o que o usário digitou
    {

        return (int)(Convert.ToChar(letra));

    }
    //função Chr()
    private char Chr(int codigo) // pega um nuémro e transforma em caracter, faz um processo contrário do Asc.
    {

        return (char)codigo; // retona 0 e "trava a tela" não parece nada tela

    }

    private void bntAdicionar_Click(object sender, EventArgs e)
    {
        errorProvider1.Clear();
            if (txtAdiSabores.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtAdiSabores, "Campo Sabor se encontra vazio");
                MessageBox.Show("Por gentileza informe o nome da pizza");
                txtAdiSabores.Focus();
                
            }

            else if (txtAdiGrande.Text.Trim().Length == 0 && txtAdiMedia.Text.Trim().Length == 0 && txtAdiPequena.Text.Trim().Length == 0)
            {

                DialogResult confirm = MessageBox.Show("O campos preço será prechindo como valores 0,tem certeza deseja continuar ?", "Campo de preço vazio.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);


                if (confirm.ToString().ToUpper() == "YES")
                {
                    if (txtAdiSabores.Text.Trim().Length == 0)
                    {
                        errorProvider1.SetError(txtAdiSabores, "Campo Sabor se encontra vazio");
                        MessageBox.Show("Por gentileza informe o nome da pizza");
                        txtAdiSabores.Focus();

                    }
                    else
                    {
                        txtAdiPequena.Text = "0";
                        txtAdiMedia.Text = "0";
                        txtAdiGrande.Text = "0";
                        pizzas.Sabor = txtAdiSabores.Text;
                        pizzas.PrecoP = decimal.Parse(txtAdiPequena.Text);
                        pizzas.PrecoM = decimal.Parse(txtAdiMedia.Text);
                        pizzas.PrecoG = decimal.Parse(txtAdiGrande.Text);
                        pizzas.Informacoes = txtAdiInfomacoes.Text;
                        objPizzas.IncluirPizza(pizzas);
                        MessageBox.Show("Adicionado com sucesso.");
                        dgvPizzas.Focus();
                        LimparCampos();
                        ListarTabela();

                    }


                }

            }

            else if (txtAdiPequena.Text.Trim().Length == 0)
            {
                txtAdiPequena.Focus();
                DialogResult confirm = MessageBox.Show("O campo preço Pequena será prechindo como valor 0, \ntem certeza deseja continuar ?", "Campo de preço vazio.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);


                if (confirm.ToString().ToUpper() == "YES")
                {
                    if (txtAdiSabores.Text.Trim().Length == 0)
                    {
                        errorProvider1.SetError(txtAdiSabores, "Campo Sabor se encontra vazio");
                        MessageBox.Show("Por gentileza informe o nome da pizza");
                        txtAdiSabores.Focus();

                    }
                    else
                    {
                        txtAdiPequena.Text = "0";
                        pizzas.Sabor = txtAdiSabores.Text;
                        pizzas.PrecoP = decimal.Parse(txtAdiPequena.Text);
                        pizzas.PrecoM = decimal.Parse(txtAdiMedia.Text);
                        pizzas.PrecoG = decimal.Parse(txtAdiGrande.Text);
                        pizzas.Informacoes = txtAdiInfomacoes.Text;
                        objPizzas.IncluirPizza(pizzas);
                        MessageBox.Show("Adicionado com sucesso.");
                        dgvPizzas.Focus();
                        LimparCampos();
                        ListarTabela();

                    }


                }
            }

            else if (txtAdiMedia.Text.Trim().Length == 0)
            {
                txtAdiMedia.Focus();
                DialogResult confirm = MessageBox.Show("O campo preço Média será prechindo como valor 0, \ntem certeza deseja continuar ?", "Campo de preço vazio.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);


                if (confirm.ToString().ToUpper() == "YES")
                {
                    if (txtAdiSabores.Text.Trim().Length == 0)
                    {
                        errorProvider1.SetError(txtAdiSabores, "Campo Sabor se encontra vazio");
                        MessageBox.Show("Por gentileza informe o nome da pizza");
                        txtAdiSabores.Focus();

                    }
                    else
                    {
                        txtAdiMedia.Text = "0";
                        pizzas.Sabor = txtAdiSabores.Text;
                        pizzas.PrecoP = decimal.Parse(txtAdiPequena.Text);
                        pizzas.PrecoM = decimal.Parse(txtAdiMedia.Text);
                        pizzas.PrecoG = decimal.Parse(txtAdiGrande.Text);
                        pizzas.Informacoes = txtAdiInfomacoes.Text;
                        objPizzas.IncluirPizza(pizzas);
                        MessageBox.Show("Adicionado com sucesso.");
                        dgvPizzas.Focus();
                        LimparCampos();
                        ListarTabela();

                    }


                }
            }


            else if (txtAdiGrande.Text.Trim().Length == 0)
            {
                txtAdiGrande.Focus();

                DialogResult confirm = MessageBox.Show("O campo preço Grande será prechindo como valor 0, \ntem certeza deseja continuar ?", "Campo de preço vazio.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);


                if (confirm.ToString().ToUpper() == "YES")
                {
                    if (txtAdiSabores.Text.Trim().Length == 0)
                    {
                        errorProvider1.SetError(txtAdiSabores, "Campo Sabor se encontra vazio");
                        MessageBox.Show("Por gentileza informe o nome da pizza");
                        txtAdiSabores.Focus();

                    }
                    else
                    {
                        txtAdiGrande.Text = "0";
                        pizzas.Sabor = txtAdiSabores.Text;
                        pizzas.PrecoP = decimal.Parse(txtAdiPequena.Text);
                        pizzas.PrecoM = decimal.Parse(txtAdiMedia.Text);
                        pizzas.PrecoG = decimal.Parse(txtAdiGrande.Text);
                        pizzas.Informacoes = txtAdiInfomacoes.Text;
                        objPizzas.IncluirPizza(pizzas);
                        MessageBox.Show("Adicionado com sucesso.");
                        dgvPizzas.Focus();
                        LimparCampos();
                        ListarTabela();

                    }


                }

            }

            

            else
            {

                pizzas.Sabor = txtAdiSabores.Text;
                pizzas.PrecoP = decimal.Parse(txtAdiPequena.Text);
                pizzas.PrecoM = decimal.Parse(txtAdiMedia.Text);
                pizzas.PrecoG = decimal.Parse(txtAdiGrande.Text);
                pizzas.Informacoes = txtAdiInfomacoes.Text;
                objPizzas.IncluirPizza(pizzas);
                MessageBox.Show("Adicionado com sucesso.");
                dgvPizzas.Focus();
                LimparCampos();
                ListarTabela();
            }
        }

        private void bntRemover_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool resposta = false;
             DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir Pizza\n" + txtExcSabor.Text + " ?", "Excluir cliente.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
          

            if (confirm.ToString().ToUpper() == "YES")
            {
                if (txtExcPizza.Text.Trim().Length == 0 || txtExcSabor.Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(txtAdiSabores, "Selecione o Sabor para ser removido");
                    MessageBox.Show("Por gentileza selecione o elemento para ser removido.");
                    dgvPizzas.Focus();
                }
                else
                {
                    pizzas.IdPizzas = int.Parse(txtExcPizza.Text);
                    resposta = objPizzas.ExcluirPizza(pizzas);
                    if (resposta == true)
                    {
                        MessageBox.Show("Removido com Êxito");
                        dgvPizzas.Focus();
                        ListarTabela();
                        LimparCampos();
                    }
                    else
                    {
                        MessageBox.Show("Ocorre um erro, tente novamente.");
                    }
                }

                
             }

            }

      

        private void dgvPizzas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtExcPizza.Text = dgvPizzas[0, dgvPizzas.CurrentRow.Index].Value.ToString();
            txtExcSabor.Text = dgvPizzas[1, dgvPizzas.CurrentRow.Index].Value.ToString();

            txtAltSabor.Text = dgvPizzas[1, dgvPizzas.CurrentRow.Index].Value.ToString();
            txtAltPequena.Text = dgvPizzas[3, dgvPizzas.CurrentRow.Index].Value.ToString();
            txtAltMedia.Text = dgvPizzas[4, dgvPizzas.CurrentRow.Index].Value.ToString();
            txtAltGrande.Text = dgvPizzas[5, dgvPizzas.CurrentRow.Index].Value.ToString();
            txtAltInformacoes.Text = dgvPizzas[2, dgvPizzas.CurrentRow.Index].Value.ToString();

        }

        private void bntLimparRemover_Click(object sender, EventArgs e)
        {
            LimparCampos();
            errorProvider1.Clear();
        }

        private void bntLimparAlterar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            errorProvider1.Clear();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            errorProvider1.Clear();
        }

        private void bntAlterar_Click(object sender, EventArgs e)
        {
            if (txtAltSabor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Por gentileza informe o nome da pizza");
                txtAltSabor.Focus();

            }
            else if (txtAltGrande.Text.Trim().Length == 0 && txtAltMedia.Text.Trim().Length == 0 && txtAltPequena.Text.Trim().Length == 0)
            {
                MessageBox.Show("Pelo menos algum campo de valor de preço deve ser preenchido.","Campos de preço vazio.");
                txtAltSabor.Focus();

            }

            else
            {
                if (txtAltGrande.Text.Trim().Length == 0 && txtAltMedia.Text.Trim().Length == 0)
                {

                    txtAltMedia.Text = "0";
                    txtAltGrande.Text = "0";
                    pizzas.IdPizzas = Convert.ToInt32(txtExcPizza.Text);
                    pizzas.Sabor = txtAltSabor.Text;
                    pizzas.PrecoP = decimal.Parse(txtAltPequena.Text);
                    pizzas.PrecoM = decimal.Parse(txtAltMedia.Text);
                    pizzas.PrecoG = decimal.Parse(txtAltGrande.Text);
                    pizzas.Informacoes = txtAltInformacoes.Text;
                    objPizzas.AlterarPizza(pizzas);
                    MessageBox.Show("Alterado com sucesso.");
                    dgvPizzas.Focus();
                    ListarTabela();
                }
                else if (txtAltGrande.Text.Trim().Length == 0 && txtAltPequena.Text.Trim().Length == 0)
                {

                    txtAltPequena.Text = "0";
                    txtAltGrande.Text = "0";
                    pizzas.IdPizzas = Convert.ToInt32(txtExcPizza.Text);
                    pizzas.Sabor = txtAltSabor.Text;
                    pizzas.PrecoP = decimal.Parse(txtAltPequena.Text);
                    pizzas.PrecoM = decimal.Parse(txtAltMedia.Text);
                    pizzas.PrecoG = decimal.Parse(txtAltGrande.Text);
                    pizzas.Informacoes = txtAltInformacoes.Text;
                    objPizzas.AlterarPizza(pizzas);
                    MessageBox.Show("Alterado com sucesso.");
                    dgvPizzas.Focus();
                    ListarTabela();
                }

                else if (txtAltMedia.Text.Trim().Length == 0 && txtAltPequena.Text.Trim().Length == 0)
                {

                    txtAltPequena.Text = "0";
                    txtAltMedia.Text = "0";
                    pizzas.IdPizzas = Convert.ToInt32(txtExcPizza.Text);
                    pizzas.Sabor = txtAltSabor.Text;
                    pizzas.PrecoP = decimal.Parse(txtAltPequena.Text);
                    pizzas.PrecoM = decimal.Parse(txtAltMedia.Text);
                    pizzas.PrecoG = decimal.Parse(txtAltGrande.Text);
                    pizzas.Informacoes = txtAltInformacoes.Text;
                    objPizzas.AlterarPizza(pizzas);
                    MessageBox.Show("Alterado com sucesso.");
                    dgvPizzas.Focus();
                    ListarTabela();
                }
                  else if (txtAltGrande.Text.Trim().Length == 0 && txtAltMedia.Text.Trim().Length == 0 && txtAltPequena.Text.Trim().Length == 0)
                {

                    txtAltPequena.Text = "0";
                    txtAltMedia.Text = "0";
                    txtAltGrande.Text = "0";
                    pizzas.IdPizzas = Convert.ToInt32(txtExcPizza.Text);
                    pizzas.Sabor = txtAltSabor.Text;
                    pizzas.PrecoP = decimal.Parse(txtAltPequena.Text);
                    pizzas.PrecoM = decimal.Parse(txtAltMedia.Text);
                    pizzas.PrecoG = decimal.Parse(txtAltGrande.Text);
                    pizzas.Informacoes = txtAltInformacoes.Text;
                    objPizzas.AlterarPizza(pizzas);
                    MessageBox.Show("Alterado com sucesso.");
                    dgvPizzas.Focus();
                    ListarTabela();
                }

                else if (txtAltPequena.Text.Trim().Length == 0)
                {
                    txtAltPequena.Text = "0";
                    pizzas.IdPizzas = Convert.ToInt32(txtExcPizza.Text);
                    pizzas.Sabor = txtAltSabor.Text;
                    pizzas.PrecoP = decimal.Parse(txtAltPequena.Text);
                    pizzas.PrecoM = decimal.Parse(txtAltMedia.Text);
                    pizzas.PrecoG = decimal.Parse(txtAltGrande.Text);
                    pizzas.Informacoes = txtAltInformacoes.Text;
                    objPizzas.AlterarPizza(pizzas);
                    MessageBox.Show("Alterado com sucesso.");
                    dgvPizzas.Focus();
                    ListarTabela();
                }
                else if (txtAltMedia.Text.Trim().Length == 0)
                {
                    txtAltMedia.Text = "0";
                    pizzas.IdPizzas = Convert.ToInt32(txtExcPizza.Text);
                    pizzas.Sabor = txtAltSabor.Text;
                    pizzas.PrecoP = decimal.Parse(txtAltPequena.Text);
                    pizzas.PrecoM = decimal.Parse(txtAltMedia.Text);
                    pizzas.PrecoG = decimal.Parse(txtAltGrande.Text);
                    pizzas.Informacoes = txtAltInformacoes.Text;
                    objPizzas.AlterarPizza(pizzas);
                    MessageBox.Show("Alterado com sucesso.");
                    dgvPizzas.Focus();
                    ListarTabela();
                }
                else if (txtAltGrande.Text.Trim().Length == 0)
                {
                    txtAltGrande.Text = "0";
                    pizzas.IdPizzas = Convert.ToInt32(txtExcPizza.Text);
                    pizzas.Sabor = txtAltSabor.Text;
                    pizzas.PrecoP = decimal.Parse(txtAltPequena.Text);
                    pizzas.PrecoM = decimal.Parse(txtAltMedia.Text);
                    pizzas.PrecoG = decimal.Parse(txtAltGrande.Text);
                    pizzas.Informacoes = txtAltInformacoes.Text;
                    objPizzas.AlterarPizza(pizzas);
                    MessageBox.Show("Alterado com sucesso.");
                    dgvPizzas.Focus();
                    ListarTabela();
                }
                
              
                else
                {

                    pizzas.IdPizzas = Convert.ToInt32(txtExcPizza.Text);
                    pizzas.Sabor = txtAltSabor.Text;
                    pizzas.PrecoP = decimal.Parse(txtAltPequena.Text);
                    pizzas.PrecoM = decimal.Parse(txtAltMedia.Text);
                    pizzas.PrecoG = decimal.Parse(txtAltGrande.Text);
                    pizzas.Informacoes = txtAltInformacoes.Text;
                    objPizzas.AlterarPizza(pizzas);
                    MessageBox.Show("Alterado com sucesso.");
                    dgvPizzas.Focus();
                    ListarTabela();
                }
            }
        }

        private void txtAdiPequena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Asc(e.KeyChar.ToString()) < Asc("0") || // 0 = 48 na tabela
               Asc(e.KeyChar.ToString()) > Asc("9")) // 9 = 57 na tabela
            {
                if (Asc(e.KeyChar.ToString()) != 8)
                {

                    e.KeyChar = Chr(0);

                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void txtAdiInfomacoes_TextChanged(object sender, EventArgs e)
        {

        }
        

    
    }
}
