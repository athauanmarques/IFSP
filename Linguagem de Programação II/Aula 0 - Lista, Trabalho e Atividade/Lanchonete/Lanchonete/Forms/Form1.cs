using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lanchonete.Entities;
using System.Text.RegularExpressions;

namespace Lanchonete
{
    public partial class Form1 : Form
    {
        /*******************************************************************\
         *              PROPRIEDADES, ATRIBUTOS E CONSTANTES
        \* *****************************************************************/
        
        /// <summary>
        /// Objeto que armazena o caixa da lanchonete
        /// </summary>
        private Caixa caixa;

        /// <summary>
        /// Armazena o pedido sendo atualmente editado no 
        /// formulário
        /// </summary>
        private Pedido pedidoAtual;

        /// <summary>
        /// O cardápio da lanchonete.
        /// </summary>
        private Produto[] cardapio;

        /// <summary>
        /// Altura inicial do GroupBox que contém os 
        /// itens do pedido
        /// </summary>
        const int ALTURA_INICIAL_GRP_PEDIDO = 326;

        /// <summary>
        /// Altura do GroupBox que contém os 
        /// itens do pedido após ser marcada a
        /// opção de fechar pedido
        /// </summary>
        const int ALTURA_FINAL_GRP_PEDIDO = 385;

        /// <summary>
        /// Altura inicial do formulário
        /// </summary>
        const int ALTURA_INICIAL_FORM = 408;

        /// <summary>
        /// Altura do formulário após ser marcada a
        /// opção de fechar pedido
        /// </summary>
        const int ALTURA_FINAL_FORM = 474;

        /*******************************************************************\
         *                          CONSTRUTORES
        \* *****************************************************************/

        public Form1()
        {
            InitializeComponent();
        }

        /*******************************************************************\
         *                          MÉTODOS OUVINTES
        \* *****************************************************************/

        /// <summary>
        /// Configura os dados e o layout inicial da aplicação
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            // O caixa é iniciado
            this.caixa = new Caixa();
            this.txtCaixa.Text = caixa.ValorCaixa.ToString("C");

            // As alturas iniciais são ajustadas
            this.grpPedido.Height = ALTURA_INICIAL_GRP_PEDIDO;
            this.Height = ALTURA_INICIAL_FORM;

            // O cardápio é preenchido com produtos
            this.cardapio = new Produto[] 
            {
                new Produto(100, "Cachorro Quente", 2.5M),
                new Produto(101, "Baurú", 3M),
                new Produto(102, "Americano", 3.5M),
                new Produto(103, "Hambúrguer", 2.5M),
                new Produto(104, "Cheeseburguer", 3.5M),
                new Produto(200, "Refrigerante", 2M),
                new Produto(201, "Suco Natural", 2.5M),
                new Produto(202, "Cerveja (lata)", 2.5M)
            };

            // O listBox do cardápio é configurado para
            // mostrar os itens do objeto do cardápio
            this.lstCardapio.DataSource = cardapio;

            // Configuração da lista do pedido atual
            this.pedidoAtual = new Pedido();
            this.lstPedido.DataSource = pedidoAtual.Itens;

            // O radioButton com a opção de fechar o pedido
            // começa desativado, até algum item ser 
            // adicionado ao pedido
            this.rdbFecharPedido.Enabled = false;
        }

        /// <summary>
        /// Adiciona um item ao pedido atual
        /// </summary>
        private void btnAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtém o produto selecionado no cardápio
                Produto produtoPedido = lstCardapio.SelectedItem as Produto;
                int quantidadePedida = validarInteiro(txtQtdDoItem);

                // Cria o item e adiciona ao pedido
                Item itemAtual = new Item(produtoPedido, quantidadePedida);
                this.pedidoAtual.adicionarItem(itemAtual);

                // Atualiza a lista de itens do pedido
                this.lstPedido.DataSource = null;
                this.lstPedido.DataSource = pedidoAtual.Itens;

                // Atualiza o valor total do pedido
                this.txtTotalDoPedido.Text = this.pedidoAtual.ValorTotal.ToString("C");

                // Limpa os controles referentes ao produto selecionado
                // no cardápio, pois ele já foi adicionado ao pedido
                // e um novo produto deverá ser selecionado
                txtQtdDoItem.Clear();
                txtValorItem.Clear();
                lstCardapio.Focus();

                // Agora que o pedido já contém algum item, é possível
                // fechar o pedido. Portanto o radioButton "Fechar Pedido"
                // é habilitado
                this.rdbFecharPedido.Enabled = true;
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        /// <summary>
        /// Fecha o pedido atual. Depois de acionado este método,
        /// não poderão ser mais adicionados produtos ao pedido e o pagamento
        /// deverá ser realizado.
        /// </summary>
        private void rdbFecharPedido_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.rdbFecharPedido.Checked) 
                {
                    // Habilita os controles relativos ao pagamento do 
                    // pedido
                    this.pnlFecharPedido.Visible = true;
                    this.btnAdicionarProduto.Enabled = false;
                    this.btnLimpar.Enabled = false;

                    // Configura a altura do formulário para exibir os
                    // controles do pagamento
                    this.grpPedido.Height = ALTURA_FINAL_GRP_PEDIDO;
                    this.Height = ALTURA_FINAL_FORM;

                    this.txtPagamento.Focus();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        /// <summary>
        /// Conclui o pedido e o adiciona ao caixa da lanchonete
        /// </summary>
        private void btnConcluirPedido_Click(object sender, EventArgs e)
        {
            try
            {
                // adicionar o pedido ao caixa
                this.caixa.adicionarPedido(this.pedidoAtual);

                // atualizar o valor do caixa
                this.txtCaixa.Text = caixa.ValorCaixa.ToString("C");

                // resetar o pedido
                this.pedidoAtual = null;
                this.pedidoAtual = new Pedido();

                // reseta o formulário
                limparComponentes();

                MessageBox.Show("Pedido concluído com sucesso","Pedido concluído");
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        /// <summary>
        /// Fecha a aplicação
        /// </summary>
        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rdbFecharPedido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"(\r\n?|\n)"))
            {
                this.rdbFecharPedido.Checked = true;
                this.txtPagamento.Focus();
            }
        }

        /// <summary>
        /// Faz com que, ao se pressionar Enter em um produto no cardápio,
        /// o foco se mova para o próximo controle
        /// </summary>
        private void lstCardapio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (usuarioApertouEnter(e))
            {
                moverFocoParaProximoControle(sender as Control);
            }
        }

        /// <summary>
        /// Faz com que um duplo clique em um produto no cardápio
        /// mova o foco para o próximo controle
        /// </summary>
        private void lstCardapio_DoubleClick(object sender, EventArgs e)
        {
            moverFocoParaProximoControle(sender as Control);
        }

        /// <summary>
        /// Faz com que, a cada tecla pressionada no TextBox "Quantidade
        /// do Item", o valor do item se atualize
        /// </summary>
        private void txtQtdDoItem_KeyUp(object sender, KeyEventArgs e)
        {
            atualizarValorDoItem();
        }

        private void lstCardapio_SelectedIndexChanged(object sender, EventArgs e)
        {
            atualizarValorDoItem();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            // Limpa o formulário, menos o textBox do total do pedido
            limparComponentes(new List<Component>() { this.txtTotalDoPedido });
            if (this.txtTotalDoPedido.Text != "")
            {
                this.txtTotalDoPedido.Text = this.pedidoAtual.ValorTotal.ToString("C");
            }
        }

        private void txtQtdDoItem_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (!usuarioApertouEnter(e))
            {
                aceitarApenasValoresInteiros(sender, e);
            }
            else 
            {
                if (txtQtdDoItem.Text != "")
                {
                    moverFocoParaProximoControle(sender as Control);
                }
                else 
                {
                    lblMsg.Text = "Insira uma quantidade antes de prosseguir.";
                }
                
            }
            

        }

        /*******************************************************************\
         *                    MÉTODOS DE VALIDAÇÃO
        \* *****************************************************************/

        /// <summary>
        /// Previne caracteres não-numéricos (com exceção do backspace)
        /// ao acionar uma tecla no controle
        /// </summary>
        private void aceitarApenasValoresInteiros(object sender, KeyPressEventArgs e)
        {
            // Checa por algum caractere não-numérico (com exceção do backspace) ao acionar uma tecla no controle
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b]"))
            {
                // Previne o caractere de ser inserido no textBox já que é indesejado.
                e.Handled = true;
            }

            // Se foi digitado um caractere válido, o fundo do controle fica branco
            Control control = sender as Control;
            control.BackColor = Color.White;
        }

        /// <summary>
        /// Previne caracteres não-numéricos (com exceção do backspace e da vírgula)
        /// ao acionar uma tecla no controle
        /// </summary>
        private void aceitarApenasValoresReais(object sender, KeyPressEventArgs e)
        {
            // Checa por algum caractere não-numérico (com exceção do backspace e da vírgula) ao acionar uma tecla no controle
            if (!Regex.IsMatch(e.KeyChar.ToString(), @"[\d\b\,]"))
            {
                // Previne o caractere de ser inserido no textBox já que é indesejado.
                e.Handled = true;
            }
        }

        /// <summary>
        /// Valida o valor inserido no textBox Pagamento, que deve ser
        /// maior ou igual ao valor total do pedido
        /// </summary>
        private void txtPagamento_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (txtPagamento.Text == "")
                {
                    lblMsg.Text = "";
                    txtTroco.Clear();
                }
                else
                {
                    Decimal pagamento = Decimal.Parse(txtPagamento.Text);

                    // Verifica se o pagamento é maior que o valor total do pedido
                    if (pagamento < this.pedidoAtual.ValorTotal)
                    {
                        lblMsg.Text = "O pagamento deve ser maior ou igual ao valor total do pedido: " + this.pedidoAtual.ValorTotal.ToString("C");
                    }
                    else
                    {
                        lblMsg.Text = "";
                        txtTroco.Text = (pagamento - this.pedidoAtual.ValorTotal).ToString("C");
                    }
                }
            }
            catch (FormatException)
            {
                this.txtTroco.Clear();
            }
        }

        /// <summary>
        /// Valida um valor inteiro num TextBox
        /// </summary>
        /// <param name="txtBox">O TextBox a ser validado</param>
        /// <returns>Retorna o valor inteiro, validado</returns>
        private int validarInteiro(TextBox txtBox)
        {
            int resultado = 0;

            try
            {
                txtBox.BackColor = Color.White;
                resultado = int.Parse(txtBox.Text);
            }
            catch (Exception)
            {
                txtBox.Clear();
                txtBox.BackColor = Color.LightPink;
                txtBox.Focus();

                throw new FormatException("Insira apenas números inteiros");
            }

            return resultado;
        }



        /*******************************************************************\
         *                          MÉTODOS AUXILIARES
        \* *****************************************************************/

        /// <summary>
        /// Atualiza o valor do item de acordo com o produto escolhido
        /// pelo consumidor e a quantidade deste produto a ser adquirida
        /// </summary>
        private void atualizarValorDoItem()
        {
            try
            {
                Produto produtoSelecionado = lstCardapio.SelectedItem as Produto;
                if (txtQtdDoItem.Text != "")
                {
                    int quantidade = int.Parse(txtQtdDoItem.Text);
                    if (quantidade > 0)
                    {
                        lblMsg.Text = "";
                        txtQtdDoItem.BackColor = Color.White;
                        Decimal valorDoItem = produtoSelecionado.Preco * quantidade;
                        txtValorItem.Text = valorDoItem.ToString("C");
                    }
                    else 
                    {
                        txtQtdDoItem.BackColor = Color.LightPink;
                        lblMsg.Text = "Insira uma quantidade maior que 0";
                        txtValorItem.Clear();
                    }
                
                }
                else
                {
                    //txtQtdDoItem.BackColor = Color.White;
                    //lblMsg.Text = "";
                    txtValorItem.Clear();
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        /// <summary>
        /// Verifica se o usuário apertou Enter
        /// </summary>
        /// <param name="e">Evento a ser verificado</param>
        /// <returns>Retorna verdadeiro se o usuário apertou Enter, e falso caso contrário.</returns>
        private bool usuarioApertouEnter(KeyPressEventArgs e) 
        {
            if (Regex.IsMatch(e.KeyChar.ToString(), @"(\r\n?|\n)"))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Move o foco para o próximo controle
        /// </summary>
        /// <param name="controle">Controle a partir do qual o foco será movido</param>
        private void moverFocoParaProximoControle(Control controle) 
        {
            this.SelectNextControl(controle, true, true, true, true);
        }
        
        /// <summary>
        /// Reseta os componentes do formulário, com exceção dos
        /// componentes passados por parâmetro na lista "componentesExcluídos"
        /// </summary>
        /// <param name="componentesExcluidos">Lista de componentes que não serão resetados</param>
        private void limparComponentes(List<Component> componentesExcluidos = null)
        {
            if (componentesExcluidos == null) 
            {
                componentesExcluidos = new List<Component>() { };
            }

            if (!componentesExcluidos.Contains(this.lstPedido))
            {
                this.lstPedido.DataSource = null;
                this.lstPedido.DataSource = pedidoAtual.Itens;
            }

            if (!componentesExcluidos.Contains(this.txtQtdDoItem))
            {
                this.txtQtdDoItem.Clear();
            }

            if (!componentesExcluidos.Contains(this.txtValorItem))
            {
                this.txtValorItem.Clear();
            }

            if (!componentesExcluidos.Contains(this.txtTotalDoPedido))
            {
                this.txtTotalDoPedido.Clear();
            }

            if (!componentesExcluidos.Contains(this.txtPagamento))
            {
                this.txtPagamento.Clear();
            }

            if (!componentesExcluidos.Contains(this.txtTroco))
            {
                this.txtTroco.Clear();
            }

            if (!componentesExcluidos.Contains(this.lblMsg))
            {
                this.lblMsg.Text = "";
            }

            if (!componentesExcluidos.Contains(this.btnAdicionarProduto))
            {
                this.btnAdicionarProduto.Enabled = true;
            }

            if (!componentesExcluidos.Contains(this.btnLimpar))
            {
                this.btnLimpar.Enabled = true;
            }

            if (!componentesExcluidos.Contains(this.rdbFecharPedido))
            {
                this.rdbFecharPedido.Checked = false;
            }

            if (!componentesExcluidos.Contains(this.pnlFecharPedido))
            {
                this.pnlFecharPedido.Visible = false;
            }

            if (!componentesExcluidos.Contains(this.grpPedido))
            {
                this.grpPedido.Height = ALTURA_INICIAL_GRP_PEDIDO;
            }

            if (!componentesExcluidos.Contains(this))
            {
                this.Height = ALTURA_INICIAL_FORM;
            }

            this.lstCardapio.Focus();
        }
    }
}
