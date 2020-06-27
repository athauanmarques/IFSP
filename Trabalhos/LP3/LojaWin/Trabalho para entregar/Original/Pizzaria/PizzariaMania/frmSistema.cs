using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Layout;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Pizzaria.BLL;
using Pizzaria.Modelos;
using System.Data;

/** Programador
         * 
         * Nome do autor: Athauan Marques da Cunha.
         * Prontuário: 136246-1
         * Disciplina: Linguagem de Programação III
         * 
         * */

namespace PizzariaMania
{
    public partial class frmSistema : MetroForm
    {
        

        public frmSistema()
        {
            InitializeComponent();
            
        }

        #region Inicializações e verificações

        private void frmSistema_Load(object sender, EventArgs e)
        {
            dgvAcesso.DataSource = objAcesso.ListarAcessos();
     
            txtNomePedido.Text = Globais.nomeProcura;
            txtTelefonePedido.Text = Globais.telefoneProcura;
            cbConsultas.SelectedIndex = 0;

            timer1.Start();
            this.Opacity = 0.1;
            ListarDGV();
            txtAdiNomeCliente.Focus();
            mtpGerenciador.SelectedTab = tpClientes;
            tbsClientes.SelectedTab = mtpAdicionar;
            txtDataPedido.Text = DateTime.Now.ToShortDateString();
            lblTipoAcesso.Text += " " + Globais.tipoAcessoLogi;
            lblUsuario.Text += " " + Globais.strUsuario;

            Listar();
            if (Globais.tipoAcessoLogi == "Administrador")
            {
                lblAvisoRegistro.Visible = false;
                dgvAcesso.Visible = true;
                bntEditar.Enabled = true;
                cbPizzaEditar.Enabled = true;
                bntPizzasEditar.Enabled = true;
                tbsClientes.Visible = true;
                bntFiltrar.Visible = true;
                txtFiltar.Visible = true;
                lblPermissao.Visible = false;
                dgvClientes.Visible = true;
                lblFiltrarCadastro.Visible = true;
                
            }
            else 
            {
                lblAvisoRegistro.Visible = true;
                dgvAcesso.Visible = false;
                bntEditar.Enabled = false;
                cbPizzaEditar.Enabled = false;
                bntPizzasEditar.Enabled = false;
                tbsClientes.Visible = false;
                bntFiltrar.Visible = false;
                txtFiltar.Visible = false;
                lblPermissao.Visible = true;
                dgvClientes.Visible = false;
                lblFiltrarCadastro.Visible = false;
            }

           
        }
            #endregion

        #region Evento Time
/**
 * Evento Time faz o efeito de entrada do aplicativo
 */
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.050;
            }
            else
            {
                timer1.Stop();

            }
        }
        #endregion 

        #region Objetos e variaveis globais

        /// <summary> Objetos de camadas 
        /// 
        /// Aqui se encontra todos os objetos estânciados das camadas BLL e Modelos.
        /// 
        /// </summary>
        
        //Objetos da camada BLL
        ClientesBLL objClientes = new ClientesBLL();
        PedidosBLL objPedidos = new PedidosBLL();
        TabelaPizzaBLL objPizzas = new TabelaPizzaBLL();
        AcessosBLL objAcesso = new AcessosBLL();
        
        //Objetos da Camada Modelos
        ModelosClientes clientes = new ModelosClientes();
        ModelosPedidos pedidos = new ModelosPedidos();
       

        /// <summary> Variáveis Globais
        /// 
        /// Todos estas variáveis são utilizados na operação de incluir pedidos. 
        /// O motivo de serem globais é que os botões (Efetuar Pedido e Efetuar Itens) utilizam as mesmas variáveis,
        /// Isso contrubui muito para realizar os tratamentos de erros do mesmo.
        /// 
        /// </summary>
        /// <param name="vlr">Armazena os valores do sabor de pizza selecionados</param>
        /// <param name="qtsPedido">Armazena a quantidade de pedido que será multiplicado</param>
        /// <param name="precoP">Armazena valores do Preço Pequeno</param>
        /// <param name="precoM">Armazena valores do Preço Média</param>
        /// <param name="precoG">Armazena valores do Preço Grande</param>
        /// <param name="resultPedido">É a soma total dos preços calculados</param>
        /// <param name="[] itensVetor">Vetor que guarda todos os itens que é inserido e movido da ListBox(lbxItens)</param>
        /// <param name="contarLista">É um contador de itens que estão na ListBox(lbxItens)</param>
        /// <param name="itensTotal">Verifica se tem itens armazendo para ser incluindo no Banco de Dados.</param>

        //Variáveis da opção Pedidos
        int vlr, qtsPedido;
        double precoP = 0, precoM = 0, precoG = 0, resultPedido = 0;
        double[] itensVetor = new double[5];
        int contarLista = 0;
        string itensTotal;

        #endregion

        #region Funções

        /// <summary> Funções
        /// 
        /// Estão todas as funções que são utilizado para listar todas as data grid view, 
        /// o cálculo de realização de pedido e do limpamento dos campos(TextBox) e algum variáveis.
        /// 
        /// </summary>
        /// <param name="Limpar(int tipoLimpeza)">Limpa os campos de TextBox de acordo com a variavel que receber</param>
        /// <param name="FormataGrid()">Formata Data Grid View</param>
        /// <param name="Listar()">Insere as informações da Data Grid View quando evento evento CellClik é utilizado </param>
        /// <param name="ListarDGV()">Lista as informações do Bando de Dados para data grid view</param>
        /// <param name="ConsultarPedidos(int op)">Lista e formata a data grid view de acordo do tipo de consulta que foi escolhido,utilzando a variável op.</param>
        /// <param name="CalculoPedido()">Realiza o Cálculo do pedido.</param>
        /// <param name="Asc(string letra) e  Chr(int codigo)">Faz a função não permitir letras nos TextBox</param>
    

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

        public void Limpar(int tipoLimpeza)
        {
            ListarDGV();
            errorProvider1.Clear();
            

            switch (tipoLimpeza)
            {
                //Limpando todos os Campos do Aplicativo
                case 0:
                    txtPedidos.Clear();
                    txtAdiCidadeCliente.Clear(); txtAdiEnderecoCliente.Clear(); txtAdiNomeCliente.Clear();
                    txtAdiReferenciasCliente.Clear(); txtAdiTelefoneCliente.Clear();

                    txtAltCidadeCliente.Clear(); txtAltEnderecoCliente.Clear(); txtAltNomeCliente.Clear(); txtAltReferenciasCliente.Clear();
                    txtAltTelefoneCliente.Clear(); txtNomePedido.Clear(); txtTelefonePedido.Clear();

                    txtExcIdCliente.Clear();
                    txtExcNomeCliente.Clear();

                    txtFiltar.Clear();

                    txtSaborPedido.Clear(); txtInfoPedido.Clear(); txtQuantidade.Clear(); txtCustoTotal.Clear(); txtCaixa.Clear();
                    txtDataPedido.Text = DateTime.Now.ToShortDateString();
                    lbxItens.Items.Clear();
                    rbtPequenaP.Text = "Pequena: "; rbtMediaP.Text = "Média: "; rbtGrandeP.Text = "Grande: ";
                    break;

                //Limpando Campos Adicionar clientes
                case 1:
                    
                    txtAdiCidadeCliente.Clear();txtAdiEnderecoCliente.Clear();txtAdiNomeCliente.Clear();txtAdiReferenciasCliente.Clear();
                    txtAdiTelefoneCliente.Clear();
                    break;

                //Limpando Campos Alterar Clientes
                case 2:
                    txtAltCidadeCliente.Clear(); txtAltEnderecoCliente.Clear();txtAltNomeCliente.Clear();txtAltReferenciasCliente.Clear();
                    txtAltTelefoneCliente.Clear();
                    break;

                //Limpando Campos Exluir Clientes
                case 3:

                    txtExcIdCliente.Clear();
                    txtExcNomeCliente.Clear();
                    break;

                //Limpando Campos Pedidos 
                case 4:
                    Globais.nomeProcura = "";
                    Globais.telefoneProcura = "";
                    lblIDClienteTs.Text = "";
                    txtNomePedido.Clear();txtTelefonePedido.Clear();txtSaborPedido.Clear();txtInfoPedido.Clear();
                    txtQuantidade.Clear();txtCustoTotal.Clear();txtCaixa.Clear();
                    txtDataPedido.Text = DateTime.Now.ToShortDateString();
                    lbxItens.Items.Clear(); rbtPequenaP.Text = "Pequena: "; rbtMediaP.Text = "Média: "; rbtGrandeP.Text = "Grande: ";
                    for (int i = 0; i < itensVetor.Length; i++)
                    itensVetor[i] = 0;
                    break;
                 

            }
        }


        private void FormataGrid()
        {
            

            try
            {
                //Formatando informações da Tabela Cliente
                dgvClientes.Columns[0].HeaderText = "Código";
                dgvClientes.Columns[0].Width = 120;
                dgvClientes.Columns[1].HeaderText = "Nome";
                dgvClientes.Columns[1].Width = 120;
                dgvClientes.Columns[2].HeaderText = "Endereco";
                dgvClientes.Columns[2].Width = 120;
                dgvClientes.Columns[3].HeaderText = "Telefone";
                dgvClientes.Columns[3].Width = 120;
                dgvClientes.Columns[4].HeaderText = "Cidade";
                dgvClientes.Columns[4].Width = 120;
                dgvClientes.Columns[5].HeaderText = "UF";
                dgvClientes.Columns[5].Width = 80;
                dgvClientes.Columns[6].HeaderText = "Referencias";
                dgvClientes.Columns[6].Width = 160;

                //Formatando informações da Tabela Pedido
                dgvPedidos.Columns[0].HeaderText = "Código do Pedido";
                dgvPedidos.Columns[0].Width = 50;
                dgvPedidos.Columns[1].HeaderText = "Data Realizado";
                dgvPedidos.Columns[1].Width = 80;
                dgvPedidos.Columns[2].HeaderText = "Custo Total";
                dgvPedidos.Columns[2].Width = 50;
                dgvPedidos.Columns[3].HeaderText = "Caixa";
                dgvPedidos.Columns[3].Width = 80;
                dgvPedidos.Columns[4].HeaderText = "Lista de sabores e valores";
                dgvPedidos.Columns[4].Width =400;
                dgvPedidos.Columns[5].Visible = false;

                //Formatando informações da Tabela Acesso de Registro de uso
                dgvAcesso.Columns[0].HeaderText = "Código de Acesso";
                dgvAcesso.Columns[0].Width = 100;
                dgvAcesso.Columns[1].HeaderText = "Registro";
                dgvAcesso.Columns[1].Width = 800;

                //Formatando informações da Tabela Pizzas
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
                    //Limando os campos Cliente
                   txtAdiNomeCliente.Clear();
                   txtAdiCidadeCliente.Clear();
                   txtAdiEnderecoCliente.Clear();
                   txtAdiReferenciasCliente.Clear();
                   txtAdiTelefoneCliente.Clear();
                   
                }

        }

        private void Listar()
        {
            //Lista para excluir o id
            lblIdCliente.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
            
            //Campos para excluir clientes
            txtExcIdCliente.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
            txtExcNomeCliente.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
            
            //Campos para alterar dados dos clientes
            txtAltNomeCliente.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
            txtAltEnderecoCliente.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
            txtAltTelefoneCliente.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
            txtAltCidadeCliente.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
            cbbAltUfCliente.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
            txtAltReferenciasCliente.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();

        
        }
        private void ListarDGV()
        {
            /// <summary> Lista Data Grid View explicação mais detalhada sobre as variáveis
            /// 
            /// Este sumário esta detalhado as utilidas das variáveis desta função.
            /// Estou utilizando a sigla DGV para referencia a propriedade data grid view.
            /// 
            /// </summary>
            /// <param name="filtro">armazena digitação do usuário incluiu para procura um consulta de acordo de cada DGV </param>
            /// <param name="errorProvider1.Clear()">Limpar a função errorProvider1</param>
            /// <param name="lblMensagem.Text">Mensagem de status que sera exibida </param>
            /// <param name=" lblStatus.Text">Mensagem que será exibida na barra de status</param>
            
            string filtro = "";
            errorProvider1.Clear();
            lblMensagem.Text = "Olá eu sou o chefinho,\nVou te ajudar oferecendo dicas, \nte alertando,e contando algumas piadas,\nMas não se preocupe...\nPizzariaMania é fácil de mexe.\nMama Mia.";
            lblStatus.Text = "Status";

            try  
            {
                
                    dgvClientes.DataSource = objClientes.Listragem(filtro);
                    dgvPedidos.DataSource = objPedidos.GeraRelatorio(filtro);
                    dgvPizzas.DataSource = objPizzas.ListarTabela(filtro);
                    dgvPizzas2.DataSource = objPizzas.ListarTabela(filtro);
                   

            }
            catch
            {
                MessageBox.Show("Não foi possível a conexão com o banco de dados!", "Erro");
               
            }
    
            finally
            {
                FormataGrid();
            }
            
         }
        
        
        public void ConsultarPedidos(int op)
        {
            /// <summary>ConsultarPedidos
            ///
            /// Esta função esta utilizando o switch case para lista e formatar de acordo da seleção de consulta pelo usuário,
            /// 
            /// </summary>
            /// <param name="op">Vai Ativar opção de consulta que será exibido.</param>
            /// 
            switch (op)
            { 
                case 0:
                    //Apenas vai listar as função iniciais da DGV.
                    ListarDGV();

                    break;
                case 1:
                    //Consulta "Listar por Cliente"
                    dgvPedidos.DataSource = objPedidos.ListaPedidos();

                    dgvPedidos.Columns[0].HeaderText = "Nome do Cliente";
                    dgvPedidos.Columns[0].Width = 150;
                    dgvPedidos.Columns[1].HeaderText = "Data Realizado";
                    dgvPedidos.Columns[1].Width = 80;
                    dgvPedidos.Columns[2].HeaderText = "Lista de sabores";
                    dgvPedidos.Columns[2].Width = 300;
                    dgvPedidos.Columns[3].HeaderText = "Valor Total Pago";
                    dgvPedidos.Columns[3].Width = 50;
               
                    

                    break;
                case 2:
                    //Consulta "Listar por Data"
                    dgvPedidos.DataSource = objPedidos.ListarSomarPorData();
                    dgvPedidos.Columns[0].HeaderText = "Data";
                    dgvPedidos.Columns[0].Width = 150;
                    dgvPedidos.Columns[1].HeaderText = "Soma Total";
                    dgvPedidos.Columns[1].Width = 500;
                   
                    break;
               
            }
        }

 

        public void CalculoPedido(int indicador)
        {
            /// <summary> Explicando a função CalculoPedido
            /// 
            /// verifica a quantidade que estão armazenadas na listBox, remove do mesmo  dependendo do caso ,
            /// Cada case é o resultado da verificação de itens no listBox que o usuário escolheu.
            /// Para entender melhor analise a situação 11 (Case 11).
            /// 
            /// Consulte O summary "Objetos e variaveis globais" para obter maiores informações das variaveis que estão globarizadas nesta função.
            ///
            /// </summary>
            

            switch (indicador)
            {
                    
                case 11:
                    /**
                     * o indicador receber o valor 11, neste caso o usuário removeu itens que faz referencia do vetor (itensVetor[4] = 0),
                     * o valor desse vetor será removido lbxItens (listBox), e subtraido o número de contagem (lblTesteListBox que verifica a quantidade que esta armazenda na listBox),
                
                     * */
                    lblTesteListBox.Text = Convert.ToString(contarLista = contarLista - 1);
                    txtCustoTotal.Text = Convert.ToString(itensVetor[4]);
                    resultPedido = itensVetor[4];
                    itensVetor[4] = 0;
                    lbxItens.Items.Remove(lbxItens.SelectedItem);
                    break;

                case 12:
                    lblTesteListBox.Text = Convert.ToString(contarLista = contarLista - 1);
                    txtCustoTotal.Text = Convert.ToString(resultPedido = itensVetor[0] + itensVetor[3]);
                    itensVetor[3] = 0;
                    lbxItens.Items.Remove(lbxItens.SelectedItem);
                    break;

                case 13:
                    lblTesteListBox.Text = Convert.ToString(contarLista = contarLista - 1);
                    txtCustoTotal.Text = Convert.ToString(resultPedido = resultPedido - itensVetor[4]);
                    itensVetor[4] = 0;
                    lbxItens.Items.Remove(lbxItens.SelectedItem);
                    break;

                case 1:
                    lblTesteListBox.Text = Convert.ToString(contarLista = contarLista - 1);
                    resultPedido = resultPedido - itensVetor[4];
                    txtCustoTotal.Text = "0";
                    itensVetor[4] = 0;
                    resultPedido = 0;
                    lbxItens.Items.Remove(lbxItens.SelectedItem);
                 break;
                
                case 2:
                     lblTesteListBox.Text = Convert.ToString(contarLista = contarLista - 1);
                     txtCustoTotal.Text = Convert.ToString(resultPedido = resultPedido - itensVetor[3]);
                     itensVetor[3] = 0;
                     lbxItens.Items.Remove(lbxItens.SelectedItem);
                 break;

                case 3:
                    lblTesteListBox.Text = Convert.ToString(contarLista = contarLista - 1);
                    txtCustoTotal.Text = Convert.ToString(resultPedido = resultPedido - itensVetor[2]);
                    itensVetor[2] = 0;
                    lbxItens.Items.Remove(lbxItens.SelectedItem);
                 break;
                
                case 4:
                    lblTesteListBox.Text = Convert.ToString(contarLista = contarLista - 1);
                    txtCustoTotal.Text = Convert.ToString(resultPedido = resultPedido - itensVetor[1]);
                    itensVetor[1] = 0;
                    lbxItens.Items.Remove(lbxItens.SelectedItem);
                 break;

                case 5:
                    lblTesteListBox.Text = Convert.ToString(contarLista = contarLista - 1);
                    txtCustoTotal.Text = Convert.ToString(resultPedido = resultPedido - itensVetor[0]);
                    itensVetor[0] = 0;
                    lbxItens.Items.Remove(lbxItens.SelectedItem);
                 break;
            }
        }

        #endregion
       
        #region Eventos de funcionalidade(evento Clik)
       
        private void metroButton3_Click(object sender, EventArgs e)
        {
            mtpGerenciador.SelectedTab = tpClientes;
        }

        private void bntAdicionarCliente_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

               if ( txtAdiNomeCliente.Text.Trim().Length == 0 && txtAdiEnderecoCliente.Text.Trim().Length == 0 && txtAdiTelefoneCliente.Text.Trim().Length == 0
                    && txtAdiCidadeCliente.Text.Trim().Length == 0 && txtAdiReferenciasCliente.Text.Trim().Length == 0 && cbbAdiUFCliente.Text.Trim().Length == 0)
                {

                    errorProvider1.SetError(txtAdiNomeCliente, "Campos se encontra vazios");
                    MessageBox.Show("Por favor preencha os campos do cliente.", "Campos Adicionar clientes estão vazios!!!");
                    lblMensagem.Text = "Hey á Algo muito errado... \n Fantasminha não existem.\nCadastre-se os dados do cliente.";
                    lblStatus.Text = "Campos Adicionar clientes estão vazios.";
                    txtAdiNomeCliente.Focus();
                }

               else if (txtAdiNomeCliente.Text.Trim().Length == 0)
               {


                   errorProvider1.SetError(txtAdiNomeCliente, "Campo Nome vazio");
                   lblMensagem.Text = "Hey á Algo de errado... \n por gentileza informe o nome do cliente\n ^^.";
                   lblStatus.Text = "Campo Nome se encontra vazio";
                   txtAdiNomeCliente.Focus();
               }
               
               

                else if (txtAdiCidadeCliente.Text.Trim().Length == 0)
                {
                    
                    errorProvider1.SetError(txtAdiCidadeCliente, "Campo cidade vazio");
                    lblMensagem.Text = "Hey á Algo de errado... \n Informe a Cidade corretamente.";
                    lblStatus.Text = "Campo Cidade se encontra vazio";
                    txtAdiCidadeCliente.Focus();
                }

                else if (txtAdiTelefoneCliente.Text.Trim().Length == 0)
                {
                    
                    errorProvider1.SetError(txtAdiTelefoneCliente, "Campo telefone vazio");
                    lblMensagem.Text = "Hey á Algo de errado... \n Informe o número de telefone.";
                    lblStatus.Text = "Campo telefone se encontra vazio";
                    txtAdiTelefoneCliente.Focus();
                }
               else if (txtAdiEnderecoCliente.Text.Trim().Length == 0)
               {
                   errorProvider1.SetError(txtAdiEnderecoCliente, "Campo endereço está vazio");
                   lblMensagem.Text = "Hey á Algo de errado... \n por gentileza informe o endereco.\n ^^.";
                   lblStatus.Text = "Campo endereço se encontra vazio";
                   txtAdiEnderecoCliente.Focus();
               }
                else if (cbbAdiUFCliente.Text.Trim().Length == 0)
                {
                    
                    errorProvider1.SetError(cbbAdiUFCliente, "Campo UF vazio");
                    lblMensagem.Text = "Hey á Algo de errado... \n Informe o UF do cliente";
                    lblStatus.Text = "Campo UF se encontra vazio";
                    cbbAdiUFCliente.Focus();
                }

            
                else
                {

                  
                    clientes.Nome = txtAdiNomeCliente.Text;
                    clientes.Endereco = txtAdiEnderecoCliente.Text;
                    clientes.Telefone = txtAdiTelefoneCliente.Text;
                    clientes.Cidade = txtAdiCidadeCliente.Text;
                    clientes.Uf = Convert.ToString(cbbAdiUFCliente.SelectedItem);
                    clientes.Referencias = txtAdiReferenciasCliente.Text;
                    lblMensagem.Text = objClientes.IncluirClientes(clientes);
                    ListarDGV();
                    lblStatus.Text = "Ulitma Ação: Cliente incluido";
                    MessageBox.Show("Inserção de cliente concluída com sucesso.", " Inserir Cliente");
                    errorProvider1.Clear();
                    if (txtAdiReferenciasCliente.Text.Trim().Length == 0)
                    {
                        MessageBox.Show("Inserção de cliente concluída com sucesso.", " Inserir Cliente");
                        lblStatus.Text = " Cliente incluido - Referencias: não declarado";
                        errorProvider1.SetError(txtAdiReferenciasCliente, "Foi inserido como: não declarado");
                    }
                    
                }

            
        }
        private void bntImprimir_Click(object sender, EventArgs e)
        {

            //O componete PrintDialog é responsável pela abertura da caixa de dialogo
            // para configuração de impressão.
            if (printDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDoc.DocumentName = "Relatório de pedidos";
                //o Método Print() envia o documento para impressora
                printDoc.Print();

            }
            else
            {
                MessageBox.Show("A impressão não é válida!", "Erro");

            }
        }

        private void bntVisualizaImp_Click(object sender, EventArgs e)
        {
            printPreview.ShowDialog();
        }

        private void printDoc_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            string strDadosCliente;
            Graphics objImpressao = e.Graphics;

            if (cbConsultas.SelectedIndex == 0)
            {


                objImpressao.DrawString("Todos Pedidos\n", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, 50, 50);
                strDadosCliente = "Identificação de Cliente: " + dgvPedidos.CurrentRow.Cells[0].Value.ToString() + Chr(10) + Chr(10);
                strDadosCliente += "Data Realizado: " + dgvPedidos.CurrentRow.Cells[1].Value.ToString() + Chr(10) + Chr(10);
                strDadosCliente += "Custo Total: " + dgvPedidos.CurrentRow.Cells[2].Value.ToString() + Chr(10) + Chr(10);
                strDadosCliente += "Caixa: " + dgvPedidos.CurrentRow.Cells[3].Value.ToString() + Chr(10) + Chr(10);
                strDadosCliente += "Lista de sabores e valores: " + dgvPedidos.CurrentRow.Cells[3].Value.ToString() + Chr(10) + Chr(10);
                //Configuração do tipo de fonte para ser impressa no documento e as distâncias em relação as margens.
                objImpressao.DrawString(strDadosCliente, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, 50, 50);


            }
            else if (cbConsultas.SelectedIndex == 1)
            {

                objImpressao.DrawString("Todos Pedidos\n", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, 50, 50);
                strDadosCliente = "Nome do Cliente: " + dgvPedidos.CurrentRow.Cells[0].Value.ToString() + Chr(10) + Chr(10);
                strDadosCliente += "Data Realizado: " + dgvPedidos.CurrentRow.Cells[1].Value.ToString() + Chr(10) + Chr(10);
                strDadosCliente += "Lista de sabores: " + dgvPedidos.CurrentRow.Cells[2].Value.ToString() + Chr(10) + Chr(10);
                strDadosCliente += "Valor Total Pago: " + dgvPedidos.CurrentRow.Cells[3].Value.ToString() + Chr(10) + Chr(10);
                objImpressao.DrawString(strDadosCliente, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, 50, 50);


            }
            else
            {
                objImpressao.DrawString("Todos Pedidos\n", new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, 50, 50);
                strDadosCliente = "Data: " + dgvPedidos.CurrentRow.Cells[0].Value.ToString() + Chr(10) + Chr(10);
                strDadosCliente += "Soma Total: " + dgvPedidos.CurrentRow.Cells[1].Value.ToString() + Chr(10) + Chr(10);

                objImpressao.DrawString(strDadosCliente, new System.Drawing.Font("Arial", 14, FontStyle.Bold), Brushes.Black, 50, 50);



            }



        }

        private void bntAdiLimparCliente_Click(object sender, EventArgs e)
        {
            
            Limpar(1);
        }

        private void metroTile6_Click(object sender, EventArgs e)
        {
            ListarDGV() ;
        }

        private void frmSobre_Click(object sender, EventArgs e)
        {
            frmSobre sobre = new frmSobre();
            sobre.ShowDialog();
        }

       

        private void bntOpAtualizar_Click(object sender, EventArgs e)
        {
            ListarDGV();
        }

        private void bntOpLimpar_Click(object sender, EventArgs e)
        {
            Limpar(0);
        }

        private void bntOpFiltrar_Click(object sender, EventArgs e)
        {

            if (mtpGerenciador.SelectedTab == tbRelatorios)
            {
                txtPedidos.Clear();
                txtPedidos.Focus();
            }
            else if(mtpGerenciador.SelectedTab == tpClientes)
            {
            txtFiltar.Clear();
            txtFiltar.Focus();
            }

        }

        private void bntOpSair_Click(object sender, EventArgs e)
        {

            DialogResult confirm = MessageBox.Show("Tem certeza que deseja sair do gerenciamento?", "Finalizar o gerenciamento", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                this.Close();
            }
            
        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Listar();
        }

        private void bntAlteraCliente_Click(object sender, EventArgs e)
        {
            try
            {
                errorProvider1.Clear();
                if (txtAltNomeCliente.Text.Trim().Length == 0 && txtAltEnderecoCliente.Text.Trim().Length == 0 && txtAltTelefoneCliente.Text.Trim().Length == 0
                    && txtAltCidadeCliente.Text.Trim().Length == 0 && txtAltReferenciasCliente.Text.Trim().Length == 0 && cbbAltUfCliente.Text.Trim().Length == 0)
                {


                    MessageBox.Show("Por favor preencha os campos do cliente.", "Campos Alterar clientes estão vazios!!!");
                    errorProvider1.SetError(txtAdiNomeCliente, "Campos se encontra vazios");
                    lblMensagem.Text = "Hey á algo muito errado... \nFantasminha não existe.\nSelecione o cliente na tela de exibição.";
                    lblStatus.Text = "Campos Adicionar clientes estão vazios.";
                    txtAdiNomeCliente.Focus();
                }
                else if (txtAltNomeCliente.Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(txtAltNomeCliente, "Campo Nome vazio");
                    lblMensagem.Text = "Hey á Algo de errado... \n por gentileza informe o nome do cliente.";
                    lblStatus.Text = "Campo Nome se encontra vazio";
                    txtAdiNomeCliente.Focus();
                }
                else if (txtAltCidadeCliente.Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(txtAltCidadeCliente, "Campo cidade vazio");
                    lblMensagem.Text = "Hey á Algo de errado... \n Informe a Cidade corretamente.";
                    lblStatus.Text = "Campo Cidade se encontra vazio";
                    txtAdiCidadeCliente.Focus();
                }

                else if (txtAltTelefoneCliente.Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(txtAltTelefoneCliente, "Campo telefone vazio");
                    lblMensagem.Text = "Hey á Algo de errado... \n Informe o número de telefone.";
                    lblStatus.Text = "Campo telefone se encontra vazio";
                    txtAdiTelefoneCliente.Focus();
                }
                else   if (txtAltEnderecoCliente.Text.Trim().Length == 0)
                {
                    errorProvider1.SetError(txtAltEnderecoCliente, "Campo endereço está vazio");
                    lblMensagem.Text = "Hey á Algo de errado... \n por gentileza informe o endereco.\n .";
                    lblStatus.Text = "Campo endereço se encontra vazio";
                    txtAdiEnderecoCliente.Focus();
                }


                else if (cbbAltUfCliente.Text.Trim().Length == 0)
                {
                   
                    errorProvider1.SetError(cbbAltUfCliente, "Campo UF vazio");
                    lblMensagem.Text = "Hey á Algo de errado... \n Informe o UF do cliente";
                    lblStatus.Text = "Campo UF se encontra vazio";
                    cbbAdiUFCliente.Focus();
                }
                else
                {

                    clientes.IdClientes = int.Parse(lblIdCliente.Text);
                    clientes.Nome = txtAltNomeCliente.Text;
                    clientes.Endereco = txtAltEnderecoCliente.Text;
                    clientes.Telefone = txtAltTelefoneCliente.Text;
                    clientes.Cidade = txtAltCidadeCliente.Text;
                    clientes.Uf = Convert.ToString(cbbAltUfCliente.SelectedItem);
                    clientes.Referencias = txtAltReferenciasCliente.Text;
                    lblMensagem.Text = "Cadastro efetuado com sucesso.";
                    lblStatus.Text = objClientes.AlterarClientes(clientes);
                    ListarDGV();
                    MessageBox.Show("Aleteração de cliente concluída com sucesso.", " Alterar Cliente");
                   

                    if (txtAltReferenciasCliente.Text.Trim().Length == 0)
                    {
                        
                        lblStatus.Text = " Cliente aletrado: Referencias: não declarado";
                        errorProvider1.SetError(txtAltReferenciasCliente, "Foi inserido como: não declarado");
                    }
                    
                }
            }
            catch
            {
                lblMensagem.Text = objClientes.Mensagem;
            }

        }

        private void bntVerPerfil_Click(object sender, EventArgs e)
        {
            frmUsuario usu = new frmUsuario();
            usu.ShowDialog();
        }

        private void bntPedidos_Click(object sender, EventArgs e)
        {
            mtpGerenciador.SelectedTab = tpPedidos;
        }

        private void bntPreco_Click(object sender, EventArgs e)
        {
            mtpGerenciador.SelectedTab = tbRelatorios;
            tbMenuRelatorio.SelectedTab = tbPedidosRealizados;
            
        }

        private void bntFiltrar_Click(object sender, EventArgs e)
        {
            string filtro = txtFiltar.Text;
            try
            {
                dgvClientes.DataSource = objClientes.Listragem(filtro);
                FormataGrid();
                Listar();
               
            }
            catch
            {
                txtAdiNomeCliente.Clear();
                txtAdiEnderecoCliente.Clear();
                txtAdiTelefoneCliente.Clear();
                txtAdiCidadeCliente.Clear();
                txtAdiReferenciasCliente.Clear();
            }
        }

        private void bntExluirCliente_Click(object sender, EventArgs e)
        {
            Listar();
            bool resposta = false;


            DialogResult confirm = MessageBox.Show("Tem certeza que deseja excluir cliente\n" + txtExcNomeCliente.Text + " ?", "Excluir cliente.", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
            {
                if (txtExcIdCliente.Text.Length == 0)
                {
                    MessageBox.Show("Um cliente deve ser selecionado para excluir!");
                }
                else
                {
                    clientes.IdClientes = int.Parse(txtExcIdCliente.Text);
                    resposta = objClientes.ExcluirClientes(clientes);
                    if (resposta == true)
                    {
                        lblMensagem.Text = objClientes.Mensagem;
                        lblStatus.Text = "Cliente excluído";
                    }
                    else
                    {
                        lblMensagem.Text = objClientes.Mensagem;
                    }
                 }


 
            }
            ListarDGV();
        }

        private void bntLimpaCliente_Click(object sender, EventArgs e)
        {
            
            Limpar(3);
        }


        private void bntProPedidos_Click(object sender, EventArgs e)
        {
             string filtro = txtProPedidos.Text;

             if (cbConsultas.SelectedIndex == 0)
             {
                 dgvPedidos.DataSource = objPedidos.GeraRelatorio(filtro);
               
             }
                else if (cbConsultas.SelectedIndex == 1)
                {
                    dgvPedidos.DataSource = objPedidos.PedidoPorCliente(filtro);
                  
                }

        }

   

        private void bntEditar_Click(object sender, EventArgs e)
        {
            ListarDGV();
            frmTabelaPreco preco = new frmTabelaPreco();
            preco.ShowDialog();
        }


        private void dgvPizzas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //Campos para tabela de pizza
            txtSaborPedido.Text = dgvPizzas[1, dgvPizzas.CurrentRow.Index].Value.ToString();
            txtInfoPedido.Text = dgvPizzas[2, dgvPizzas.CurrentRow.Index].Value.ToString();
            rbtPequenaP.Text = "Pequena: " + dgvPizzas[3, dgvPizzas.CurrentRow.Index].Value.ToString();
            rbtMediaP.Text = "Média: " + dgvPizzas[4, dgvPizzas.CurrentRow.Index].Value.ToString();
            rbtGrandeP.Text = "Grande: " + dgvPizzas[5, dgvPizzas.CurrentRow.Index].Value.ToString();

        }



        private void bntProcuraCliente_Click(object sender, EventArgs e)
        {

            if (bntProcuraCliente.Text == "Procurar")
            {
                bntProcuraCliente.Text = "Atualizar";
                bntProcuraCliente.Style = MetroFramework.MetroColorStyle.Red;
                frmSelecionarCliente sel = new frmSelecionarCliente();
                sel.ShowDialog();
            }
            else
            {
                bntProcuraCliente.Style = MetroFramework.MetroColorStyle.Black;
                bntProcuraCliente.Text = "Procurar";
                txtTelefonePedido.Text = Globais.telefoneProcura;
                txtNomePedido.Text = Globais.nomeProcura;
                lblIDClienteTs.Text = Convert.ToString(Globais.idCliente);
            }
        }


        private void bntIntesAdicionar_Click(object sender, EventArgs e)
        {
            
            precoP = Convert.ToDouble(dgvPizzas[3, dgvPizzas.CurrentRow.Index].Value.ToString());
            precoM = Convert.ToDouble(dgvPizzas[4, dgvPizzas.CurrentRow.Index].Value.ToString());
            precoG = Convert.ToDouble(dgvPizzas[5, dgvPizzas.CurrentRow.Index].Value.ToString());
            errorProvider1.Clear();

            double itens;

            if (txtQuantidade.Text.Trim().Length == 0 || txtQuantidade.Text.Trim().Length <= 0)
            {
                errorProvider1.SetError(txtQuantidade, "Informe quantidade de pizzas.");
                lblMensagem.Text = "Hey á Algo de errado... \n Informe a quantidade a ser inserido.";
                lblStatus.Text = "Informe a quantidade de pizza";
                txtQuantidade.Focus();
            }
            else if (txtQuantidade.Text == "0")
            {

                MessageBox.Show("São permitidos apenas valores maiores do que 0.", "Campo quantidade");
                errorProvider1.SetError(txtQuantidade, "Informe quantidade de pizzas.");
                txtQuantidade.Clear();
                txtQuantidade.Focus();
            }
            else if (txtSaborPedido.Text.Trim().Length == 0 || txtInfoPedido.Text.Trim().Length == 0 || precoP == 0 || precoM == 0 || precoG == 0)
                 {

                MessageBox.Show("Campo vazio por favor selecione a pizza desejada.","Aviso!");
                dgvPizzas.Focus();
                  }

            else if (lbxItens.Items.Count <= 4 && txtQuantidade.Text != "0")
            {
                vlr = Convert.ToInt32(txtQuantidade.Text);

                if (rbtPequenaP.Checked == true)
                {
                    resultPedido += vlr * precoP;
                    itens = vlr * precoP;
                    qtsPedido = vlr;
                    txtQuantidade.Focus();

                    if (contarLista == 0)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[0] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                        
                    }
                    else if (contarLista == 1)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[1] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }
                    else if (contarLista == 2)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[2] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }
                    else if (contarLista == 3)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[3] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }
                    else if (contarLista == 4)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[4] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }
                   
                    
                }
           

                else if (rbtMediaP.Checked == true)
                {
                    resultPedido += vlr * precoM;
                    itens = vlr * precoM;
                    qtsPedido = vlr;
                    txtQuantidade.Focus();

                    if (contarLista == 0)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[0] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }
                    else if (contarLista == 1)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[1] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }
                    else if (contarLista == 2)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[2] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }
                    else if (contarLista == 3)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[3] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }
                    else if (contarLista == 4)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[4] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }


                }

                else if (rbtGrandeP.Checked == true)
                {
                    resultPedido += vlr * precoG;
                    itens = vlr * precoG;
                    qtsPedido = vlr;
                    txtQuantidade.Focus();
                    if (contarLista == 0)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[0] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }
                    else if (contarLista == 1)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[1] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }
                    else if (contarLista == 2)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[2] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }
                    else if (contarLista == 3)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[3] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }
                    else if (contarLista == 4)
                    {
                        contarLista = contarLista + 1;
                        itensVetor[4] = itens;
                        lblTesteListBox.Text = Convert.ToString(contarLista);

                        lbxItens.Items.Add("Sabor: " + txtSaborPedido.Text + " | Quantidade: " + Convert.ToString(qtsPedido) + " | Valor: R$" + Convert.ToString(itens));
                    }
                }
            }
            else
            {
                MessageBox.Show("Só são permitidos até 5 itens adicionados no mesmo pedido.", "Aviso");
                
            }
           
            txtCustoTotal.Text = Convert.ToString(resultPedido);
            txtCaixa.Focus();
            
        }

        private void bntRemoverItens_Click(object sender, EventArgs e)
        {


            if (lbxItens.SelectedIndex == 0)
            {

                if (lblTesteListBox.Text == "1")
                {
                    CalculoPedido(1);
                }
                else if (lblTesteListBox.Text == "2")
                {
                    CalculoPedido(2);
                }
                else if (lblTesteListBox.Text == "3")
                {
                    CalculoPedido(3);
                }
                else if (lblTesteListBox.Text == "4")
                {
                    CalculoPedido(4);
                }
                else if (lblTesteListBox.Text == "5")
                {
                    CalculoPedido(5);
                }
            }


            if (lbxItens.SelectedIndex == 1)
            {
                
                if (lblTesteListBox.Text == "2")
                {
                    CalculoPedido(11);
                }
                else if (lblTesteListBox.Text == "3")
                {
                    CalculoPedido(2);
                }
                else if (lblTesteListBox.Text == "4")
                {
                    CalculoPedido(3);
                }
                else if (lblTesteListBox.Text == "5")
                {
                    CalculoPedido(4);
                }
            }

            if (lbxItens.SelectedIndex == 2)
            {
                
                if (lblTesteListBox.Text == "3")
                {
                    CalculoPedido(12);
                }
                else if (lblTesteListBox.Text == "4")
                {
                    CalculoPedido(3);
                }
                else if (lblTesteListBox.Text == "5")
                {
                    CalculoPedido(4);
                }
            }


            if (lbxItens.SelectedIndex == 3)
            {
              
                if (lblTesteListBox.Text == "4")
                {
                    CalculoPedido(13);
                }
                else if (lblTesteListBox.Text == "5")
                {
                    CalculoPedido(2);
                }
            }

            if (lbxItens.SelectedIndex == 4)
            {
                
                    CalculoPedido(5);
                
            }
            
       
        }

        private void bntCancelarPedidos_Click(object sender, EventArgs e)
        {
            
            Limpar(4);
            
        }

        private void bntLimparItens_Click(object sender, EventArgs e)
        {
            lbxItens.Items.Clear();
            txtCaixa.Clear();
            txtCustoTotal.Clear();
            resultPedido = 0;
            txtQuantidade.Clear();
            
            for (int i = 0; i < itensVetor.Length; i++)
            itensVetor[i] = 0;
        }

        private void txtAdiTelefoneCliente_KeyPress(object sender, KeyPressEventArgs e)
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


        private void bntAltLimparCliente_Click(object sender, EventArgs e)
        {
            Limpar(2);
        }

        private void bntAtualizaPizza_Click(object sender, EventArgs e)
        {
            ListarDGV();
        }

 
        private void bntExibirConsulta_Click(object sender, EventArgs e)
        {
            if(cbConsultas.SelectedIndex == 0)
            {
            ConsultarPedidos(0);
            }
            else if (cbConsultas.SelectedIndex == 1)
            {
                ConsultarPedidos(1);
            }
            else 
            {
                ConsultarPedidos(2);
            }
        }

        private void cbConsultas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbConsultas.SelectedIndex == 0)
            {
                ConsultarPedidos(0);
            }
            else if (cbConsultas.SelectedIndex == 1)
            {
                ConsultarPedidos(1);
            }
            else if (cbConsultas.SelectedIndex == 2)
            {
                ConsultarPedidos(2);
            }
        }
       
        private void bntAdicionarPedido_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            if (txtNomePedido.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtNomePedido, "Selecione ou Atualiza a opção Cliente.");
                lblMensagem.Text = "Para incluir o cliente no pedido, \nSelecione a opção Procura/Atualiza.";
                lblStatus.Text = "Selecione ou Atualiza Cliente";
            }
            else if (txtDataPedido.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtDataPedido, "Informe a Data de pedido.");
                lblMensagem.Text = "Por gentileza Informe a data do pedido.";
                lblStatus.Text = "Campo 'Data Pedido' se enconta vazio.";
                txtCaixa.Focus();
            }

            else if (txtSaborPedido.Text.Trim().Length == 0)
            {

                errorProvider1.SetError(dgvPizzas, "Campo vazio por favor selecione a pizza desejada.");
                lblMensagem.Text = "Selecione a pizza do cliente.";
                lblStatus.Text = "Selecione o sabor da pizza desejada";
                dgvPizzas.Focus();
            }


            else if (txtCustoTotal.Text.Trim().Length <= 0 || txtCustoTotal.Text.Trim().Length == 0 || txtCustoTotal.Text == "0")
            {

                errorProvider1.SetError(txtCustoTotal, "Campo 'custo total' se enconta vazio.");
                lblMensagem.Text = "Adicione itens de sabores de pizzas.";
                lblStatus.Text = "Campo 'custo total' se enconta vazio.";
                txtCustoTotal.Focus();
            }
            else if (txtCaixa.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtCaixa, "Campo 'caixa' se enconta vazio.");
                lblMensagem.Text = "Informe a quantidade de valor do caixa.";
                lblStatus.Text = "Campo 'caixa' se enconta vazio.";
                txtCaixa.Focus();
            }
            else if (lblTesteListBox.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(lbxItens, "Itens vazios.");
                lblMensagem.Text = "Selecione a pizza do cliente.";
                lblStatus.Text = "Itens vazios.";
                txtQuantidade.Focus();
            }
            else
            {

                for (int i = 0; i < lbxItens.Items.Count; i++)
                {
                    itensTotal += "\n" + lbxItens.Items[i].ToString();
                }

                pedidos.DataPedido = Convert.ToDateTime(txtDataPedido.Text);
                pedidos.CustoTotal = float.Parse(txtCustoTotal.Text);
                pedidos.Caixa = float.Parse(txtCaixa.Text);
                pedidos.QtsItens = itensTotal;
                pedidos.IdClientes = int.Parse(lblIDClienteTs.Text);
                lblStatus.Text = objPedidos.IncluirPedidos(pedidos);
                lblMensagem.Text = "Isso Muleque..Tá aprendendo,\nPedido realizado com sucesso";
                MessageBox.Show("Pedido efeutado com sucesso", "Efetuação de Pedido");
            }

        }


        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPizzaEditar.SelectedIndex == 0)
            {
                Globais.opEditarPizza = 0;
            }
            else if (cbPizzaEditar.SelectedIndex == 1)
            {
                Globais.opEditarPizza = 1;
            }
            else if (cbPizzaEditar.SelectedIndex == 2)
            {
                Globais.opEditarPizza = 2;
            }
            ListarDGV();

        }

        private void bntPizzasEditar_Click(object sender, EventArgs e)
        {
            ListarDGV();
            frmTabelaPreco preco = new frmTabelaPreco();
            preco.ShowDialog();
        }

        private void bntRemover_Click(object sender, EventArgs e)
        {
            dgvAcesso.DataSource = objAcesso.ListarAcessos();
        }

        private void bntCaculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void groupBox10_Enter(object sender, EventArgs e)
        {
            frmUsuario usu = new frmUsuario();
            usu.ShowDialog();
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {
            frmUsuario usu = new frmUsuario();
            usu.ShowDialog();
        }

        private void lblTipoAcesso_Click(object sender, EventArgs e)
        {
            frmUsuario usu = new frmUsuario();
            usu.ShowDialog();
        }

        private void metroButton14_Click(object sender, EventArgs e)
        {
            mtpGerenciador.SelectedTab = tbRelatorios;
            tbMenuRelatorio.SelectedTab = tbPedidosRealizados;
        }

        private void bntRelatorioPizza_Click(object sender, EventArgs e)
        {
            mtpGerenciador.SelectedTab = tbRelatorios;
            tbMenuRelatorio.SelectedTab = tbTabelaPizza;
        }

        private void bntRegistro_Click(object sender, EventArgs e)
        {
            mtpGerenciador.SelectedTab = tbRelatorios;
            tbMenuRelatorio.SelectedTab = tbRegistro;
        }

        private void bntAjuda_Click(object sender, EventArgs e)
        {
            frmAjuda ajd = new frmAjuda();
            ajd.ShowDialog();
        }
        #endregion

        #region Não utilizados

        private void bntAtualizar_Click(object sender, EventArgs e)
        {

        }

        private void txtNomePedido_Click(object sender, EventArgs e)
        {

        }
        private void htmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void tbRelatorios_Click(object sender, EventArgs e)
        {

        }
        private void tpPedidos_Click(object sender, EventArgs e)
        {

        }

        private void lblPermissao_Click(object sender, EventArgs e)
        {

        }

        private void pcbChefinho_Click(object sender, EventArgs e)
        {

        }

        private void nudQuantsPedido_KeyUp(object sender, KeyEventArgs e)
        {


        }

        private void nudQuantsPedido_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void lbxItens_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void radialMenu2_ItemClick(object sender, EventArgs e)
        {

        }

        private void rmMenu_TabIndexChanged(object sender, EventArgs e)
        {

        }

        private void rmMenu_MarginChanged(object sender, EventArgs e)
        {

        }

        private void tpClientes_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel16_Click(object sender, EventArgs e)
        {

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {


        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox4_Click(object sender, EventArgs e)
        {

        }

        #endregion

       

       
    }
}
