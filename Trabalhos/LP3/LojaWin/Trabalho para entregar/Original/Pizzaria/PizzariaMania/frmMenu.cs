using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework.Forms;
using MetroFramework;
using Pizzaria.BLL;
using Pizzaria.Modelos;

namespace PizzariaMania
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }
        UsuariosBLL objUsuario = new UsuariosBLL();
        AcessosBLL objAcesso = new AcessosBLL();
        ModelosAcesso acesso = new ModelosAcesso();
        ModelosUsuarios usuarios = new ModelosUsuarios();

        string strRelogio, strHora, strMinuto, strSegundo;

        private void frmMenu_Load(object sender, EventArgs e)
        {

            lblSeja.Text = "Seja Bem-vindo, " + Globais.strUsuario;
            pcbBabaquinha.Visible = false;
            timer1.Start();
            this.Opacity = 0.1;

            bool verificar = false;
            string nome = Convert.ToString(Globais.strUsuario);
            verificar = objUsuario.AutenticarAcessos(nome);

            if (verificar == true)
            {

                Globais.tipoAcessoLogi = "Administrador";
            }
            else
            {

                
                Globais.tipoAcessoLogi = "Comum";
            }

            string strData, strDia, strMes, strAno, maquina,statusAcesso;
            strDia = DateTime.Now.Day.ToString("00");
            strMes = DateTime.Now.Month.ToString("00");
            strAno = DateTime.Now.Year.ToString("0000");
            strData = strDia + " / " + strMes + " / " + strAno + " | ";
            maquina = Environment.MachineName;
            statusAcesso = "Nome da Conta: " + Globais.strUsuario + " | Tipo de Acesso: " + Globais.tipoAcessoLogi + " | Maquina: " + maquina + " | Data:" + strData;
            acesso.Acesso = statusAcesso;
            objAcesso.IncluirAcesso(acesso);
        }

        private void bubbleButton3_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmLogin log = new frmLogin();
            log.Close();
            this.Close();
        }

        private void pcbChefinho_Click(object sender, EventArgs e)
        {
            pcbChefinho.Location = new Point(527, 315);
            pcbChefinho.Size = new Size(119, 124);
            pcbBabaquinha.Visible = true;
        }

        private void pcbChefinho_DoubleClick(object sender, EventArgs e)
        {
            pcbChefinho.Location = new Point(530, 405);
            pcbChefinho.Size = new Size(119, 53);
            pcbBabaquinha.Visible = false;
        }

        private void bubbleButton1_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmSistema sis = new frmSistema();
            sis.ShowDialog();
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
    
            if (this.Opacity <= 1.0)
            {
                this.Opacity += 0.025;
            }
            else
            {
                timer1.Stop();

            }
        }

        private void bubbleButton2_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmUsuario usu = new frmUsuario();
            usu.ShowDialog();
        }

        private void bubbleButton4_Click(object sender, DevComponents.DotNetBar.ClickEventArgs e)
        {
            frmSobre so = new frmSobre();
            so.ShowDialog();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void lblSeja_Click(object sender, EventArgs e)
        {

        }
    }
}
