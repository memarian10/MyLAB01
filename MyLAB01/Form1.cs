using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyLAB01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            string str1 = "";
            string str2 = "" ;
            string str3 = "";

            num1 = Convert.ToInt32(txtNum1.Text);
            num2 = Convert.ToInt32(txtNum2.Text);
            num3 = Convert.ToInt32(txtNum3.Text);
            str1 = txtStr1.Text;
            str2 = txtStr2.Text;
            str3 = txtStr3.Text;

            /////////////////////////////////////////////////////////
            //IF_ELSE

            //if (num1 < 10) lblOut1.Text = "Less than 10"; else lblOut1.Text = "Grater than 10";

            //if (num1 < 10)
            //{
            //    lblOut2.Text = "Less than 10";
            //}
            //else if(num1>10)
            //{
            //    lblOut2.Text = "Grater than 10";
            //}
            //else
            //{
            //    lblOut2.Text = "Equal 10";
            //}

            //
        }
    }
}
