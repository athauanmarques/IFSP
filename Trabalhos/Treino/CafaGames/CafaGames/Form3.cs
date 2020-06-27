using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class frmResultado1 : Form
    {
        public frmResultado1()
        {
            InitializeComponent();
        }

        public frmResultado1(string valor)
    {
        InitializeComponent();
        lblNome1.Text = valor;
        
    }

       //  public string Propriedade { get; set; } // pegando e amazenando valores para jogar no outro form

        private void frmResultado1_Load(object sender, EventArgs e)
        {

            ////---------------------------------------------------------------
            //if (!this.Propriedade.Equals(""))
            //    lblNome1.Text = this.Propriedade;
            ////--------------------------- esta levando valores para outro form
            
        }
    }
}
