using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lista1
{
    public partial class frmTemperatura : Form
    {
        public frmTemperatura()
        {
            InitializeComponent();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            txtT1.Text = " ";
            txtT2.Text = " ";
            txtT3.Text = " ";
            txtT4.Text = " ";
            txtT5.Text = " ";
            txtT6.Text = " ";
            txtT7.Text = " ";
            txtT8.Text = " ";
            txtT9.Text = " ";
            txtT10.Text = " ";
            txtMedia.Text = " ";
            txtMaior.Text = " ";
            
        }

        private void bntCalcular_Click(object sender, EventArgs e)
        {
            double mediaT, 
                   t1 = Convert.ToDouble(txtT1.Text),
                   t2 = Convert.ToDouble(txtT2.Text),
                   t3 = Convert.ToDouble(txtT3.Text),
                   t4 = Convert.ToDouble(txtT4.Text),
                   t5 = Convert.ToDouble(txtT5.Text),
                   t6 = Convert.ToDouble(txtT6.Text),
                   t7 = Convert.ToDouble(txtT7.Text),
                   t8 = Convert.ToDouble(txtT8.Text),
                   t9 = Convert.ToDouble(txtT9.Text),
                   t10 = Convert.ToDouble(txtT10.Text);
   
            

            mediaT = (t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9 + t10) /10;

            if (t1 > t2 && t1 > t3 && t1 > t4 && t1 > t5 && t1 > t6 && t1 > t7 && t1 > t8 && t1 > t9 && t1 > t10)
            {

                txtMaior.Text = Convert.ToString("T1 =" + t1);
                txtMedia.Text = Convert.ToString(mediaT);
            }


            else if (t2 > t1 && t2 > t3 && t2 > t4 && t2 > t5 && t2 > t6 && t2 > t7 && t2 > t8 && t2 > t9 && t2 > t10)
            {

                txtMaior.Text = Convert.ToString("T2 =" + t2);
                txtMedia.Text = Convert.ToString(mediaT);
            }
            else if (t3 > t1 && t3 > t2 && t3 > t4 && t3 > t5 && t3 > t6 && t3 > t7 && t3 > t8 && t3 > t9 && t3 > t10)
            {

                txtMaior.Text = Convert.ToString("T3 =" + t3);
                txtMedia.Text = Convert.ToString(mediaT);
            }
            else if (t4 > t2 && t4 > t1 && t4 > t3 && t4 > t5 && t4 > t6 && t4 > t7 && t4 > t8 && t4 > t9 && t4 > t10)
            {

                txtMaior.Text = Convert.ToString("T4 =" + t4);
                txtMedia.Text = Convert.ToString(mediaT);
            }
            else if (t5 > t2 && t5 > t3 && t5 > t4 && t5 > t1 && t5 > t6 && t5 > t7 && t5 > t8 && t5 > t9 && t5 > t10)
            {

                txtMaior.Text = Convert.ToString("T5 =" + t5);
                txtMedia.Text = Convert.ToString(mediaT);
            }
            else if (t6 > t2 && t6 > t3 && t6 > t4 && t6 > t5 && t6 > t1 && t6 > t7 && t6 > t8 && t6 > t9 && t6 > t10)
            {

                txtMaior.Text = Convert.ToString("T6 =" + t6);
                txtMedia.Text = Convert.ToString(mediaT);
            }
            else if (t7 > t2 && t7 > t3 && t7 > t4 && t7 > t5 && t7 > t6 && t7 > t1 && t7 > t8 && t7 > t9 && t7 > t10)
            {

                txtMaior.Text = Convert.ToString("T7 =" + t7);
                txtMedia.Text = Convert.ToString(mediaT);
            }

            else if (t8 > t2 && t8 > t3 && t8 > t4 && t8 > t5 && t8 > t6 && t8 > t7 && t8 > t1 && t8 > t9 && t8 > t10)
            {

                txtMaior.Text = Convert.ToString("T8 =" + t8);
                txtMedia.Text = Convert.ToString(mediaT);
            }
            else if (t9 > t2 && t9 > t3 && t9 > t4 && t9 > t5 && t9 > t6 && t9 > t7 && t9 > t8 && t9 > t1 && t9 > t10)
            {

                txtMaior.Text = Convert.ToString("T9 =" + t9);
                txtMedia.Text = Convert.ToString(mediaT);
            }
            else if (t10 > t2 && t10 > t3 && t10 > t4 && t10 > t5 && t10 > t6 && t10 > t7 && t10 > t8 && t10 > t9 && t10 > t1)
            {

                txtMaior.Text = Convert.ToString("T10 =" + t10);
                txtMedia.Text = Convert.ToString(mediaT);
            }
            else
            {

                txtMaior.Text = Convert.ToString(t10);
                txtMedia.Text = Convert.ToString(mediaT);
            }
        
        }

       

       
       

        
        
       
        
    }
}
