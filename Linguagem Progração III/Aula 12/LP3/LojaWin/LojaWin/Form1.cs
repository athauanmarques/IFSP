using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LojaWin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void opcSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void opcCalculadora_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void opcCalendario_Click(object sender, EventArgs e)
        {
            frmCalendario objFrmCalendario = new frmCalendario();
            objFrmCalendario.Show();
        }

        private void opcBloco_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void opcInternet_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("chrome.exe", "http://bra.ifsp.edu.br");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string strData, strDia, strMes, strAno;
            strDia = DateTime.Now.Day.ToString("00");
            strMes = DateTime.Now.Month.ToString("00");
            strAno = DateTime.Now.Year.ToString("0000");
            strData = strDia + " / " + strMes + " / " + strAno;
            lblData.Text = strData;
            lblEquipamento.Text = Environment.MachineName;
            lblUsuario.Text = Globais.strUsuario;

            // Configuração do timer
            // A propriedade Enabled habilita o timer.
            timer1.Enabled = true;
            // A propriedade Interval determina o intervalo de tempo em milissegundos
            // 1000 ms = 1 s
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string strRelogio, strHora, strMinuto, strSegundo;
            strHora = DateTime.Now.Hour.ToString("00");
            strMinuto = DateTime.Now.Minute.ToString("00");
            strSegundo = DateTime.Now.Second.ToString("00");
            strRelogio = strHora + " : " + strMinuto + " : " + strSegundo;
            lblHora.Text = strRelogio;
        }

        private void opcUsuarios_Click(object sender, EventArgs e)
        {
            frmUsuarios objFrmUsuarios = new frmUsuarios();
            objFrmUsuarios.ShowDialog();
        }

        private void opcClientes_Click(object sender, EventArgs e)
        {
            frmClientes objFrmClientes = new frmClientes();
            objFrmClientes.ShowDialog();
        }

        private void opcProdutos_Click(object sender, EventArgs e)
        {
            frmProdutos objFrmProdutos = new frmProdutos();
            objFrmProdutos.ShowDialog();
        }

        private void opcVendas_Click(object sender, EventArgs e)
        {
            frmVendas objFrmVendas = new frmVendas();
            objFrmVendas.ShowDialog();
        }

        private void opcFichaCliente_Click(object sender, EventArgs e)
        {
            frmFichaClientes objFrmFichaCliente = new frmFichaClientes();
            objFrmFichaCliente.ShowDialog();
        }
    }
}
