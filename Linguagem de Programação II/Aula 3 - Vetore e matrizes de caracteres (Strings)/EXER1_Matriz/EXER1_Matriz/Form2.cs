using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EXER1_Matriz
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string email = txtMensagem.Text;

            int tamanho = email.Length; // Length é um contador em numero de caracteres 
            lblTamanho.Text = "Tamanho= " + Convert.ToString(tamanho); 
       
            int result = email.IndexOf("@");

            if(result == -1)
            {
                lblDomi.Text = "Email invalido";
                txtMensagem.Text = "";
                txtMensagem.Focus();
            
            }
            else
            {
                lblNome.Text = "Nome: " + email.Substring(0, result); // Substring cria uma string a parti de uma outra
                lblDomi.Text = "Dominio: " + email.Substring(result + 1);// ele começa a criar uma string apos do @, exe: oisdad@gmail.com - o result seria " oisdad", o + 1 seria o "@"
                lblStatus.Text = "Status: Email valido";
            }
        
        }

        
    }
}
