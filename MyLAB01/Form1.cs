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
            lblOut1.Text = "";
            lblOut2.Text = "";
            lblOut3.Text = "";
            ////This is for GITHUB
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            string str1 = "";
            string str2 = "";
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

            ////////////////////////////////
            ///
            //switch (num1)
            //{
            //    case 1:
            //        lblOut1.Text = "January";
            //        break;
            //    case 2:
            //        lblOut1.Text = "February";
            //        break;
            //    case 3:
            //        lblOut1.Text = "March";
            //        break;
            //    case 4:
            //        lblOut1.Text = "April";
            //        break;
            //    case 7:
            //    case 8:
            //    case 9:
            //        lblOut1.Text = "Autumn";
            //        break;

            //    default: lblOut1.Text = "Not Exist";
            //        break;
            //}

            //while (4<10)
            //{
            //    lblOut1.Text += " Test\n";

            //}

            //for (int i = 0; i < 6; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        lblOut1.Text += "*";
            //    }
            //    lblOut1.Text += "\n";
            //}

            //Continue
            //for (int i = 0; i < 10; i++)
            //{
            //    if (i==5 || i==9)
            //    {
            //        continue;
            //    }
            //    lblOut1.Text += ("\nLine" + i);
            //}

            //array fill by input
            //int[] arr = new int[3];
            //arr[0] = num1;
            //arr[1] = num2;
            //arr[2] = num3;

            //foreach (var item in arr)
            //{
            //    lblOut1.Text += (item.ToString() + "-");
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    lblOut2.Text += (arr[i].ToString() + "-");
            //}

            //VAR Data Type
            //var tst1 = "";
            //var tst2 = 0;

            //tst1 = str1;
            //tst2 = num1;

            //lblOut1.Text = tst1;
            //lblOut2.Text = tst2.ToString();

            //2D Array
            //int[,] arr2d = new int[3, 2] {{ 1, 2 }, { 4, 5 }, { 7, 8} };
            //foreach (var item in arr2d)
            //{
            //    lblOut1.Text += (item.ToString() + "\n");
            //}

            //Average of 3 students for 4 lesson

            //int[,] arr2d = new int[3, 4] {{ 10, 17, 16, 14 }, { 18, 9, 19, 17}, { 15, 11, 12, 14} };
            //int[] sum = new int[4];

            //for (int i = 0; i < arr2d.GetLength(0); i++)
            //{

            //    for (int j = 0; j < arr2d.GetLength(1); j++)
            //    {

            //        lblOut2.Text += arr2d[i, j].ToString()+ "  ";
            //        sum[i] += arr2d[i, j];

            //    } 
            //    lblOut1.Text += "Student "+ (i+1) + " average is "+sum[i];
            //    lblOut1.Text += "\n";
            //    lblOut2.Text += "\n";
            //}
            //foreach (var item in sum)
            //{
            //    lblOut3.Text += item.ToString();
            //}          

            //Jagged 2D array
            //int[][] jaArr = new int[3][];
            //jaArr[0] = new int[2] { 11, 22 };
            //jaArr[1] = new int[4] { 33, 44, 55, 66 };
            //jaArr[2] = new int[3] { 77, 88, 99 };

            //for (int i = 0; i < jaArr.Length; i++)
            //{
            //    for (int j = 0; j < jaArr[i].Length; j++)
            //    {
            //        lblOut1.Text += jaArr[i][j].ToString()+ "-";
            //    }
            //}

            //Return Value
            //lblOut1.Text = myMethods.SumFunc1(b:num1, a:num2).ToString();



        }
    }
}
