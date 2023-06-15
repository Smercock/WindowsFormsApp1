using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            btnOK.Text = "OK";
            lblResult.Text = "";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtX.Text);
            double y = Convert.ToDouble(txtY.Text);
            double pi = Math.PI; 
            double result = (Math.Cos(x / pi - 2 * x) + 16 * x * Math.Cos(x * y) - 2);
            lblResult.Text = ("Результат: " + result);
        }
private void lblResult2_Click(object sender, EventArgs e)
        {
            btnOk2.Text = "OK";
            lblResult2.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA.Text);
            double b = Convert.ToDouble(txtB.Text);
            double g = Convert.ToDouble(txtG.Text);
            double h = ((a - b) / 2) * Math.Tan(g * Math.PI / 180 / 2);
            double area = ((a + b) / 2) * h;
            lblResult2.Text = ("Площа трапеції: " + area + " Висота:" + h);
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lblResult4_Click(object sender, EventArgs e)
        {
            btnOk4.Text = "OK";
            lblResult4.Text = "";
        }

        private void btnOk4_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txtA4.Text);
            double b = Convert.ToDouble(txtB4.Text);
            double x = Convert.ToDouble(txtX4.Text);
            double y = Convert.ToDouble(txtY4.Text);
            double z = Convert.ToDouble(txtZ4.Text);
            if ((x <= a && y <= b) || (x <= a && y <= b) || (z <= a && y <= b) || (z <= b && y <= a) || (z <= a && x <= b) || (z <= b && x <= a))
            {
                lblResult4.Text = ("Цегла пройде через отвір.");
            }
            else
            {
                lblResult4.Text = ("Цегла не пройде через отвір.");
            }
        }

        private void lblResult3_Click(object sender, EventArgs e)
        {
            btnOk3.Text = "OK";
            lblResult3.Text = "";
        }

        private void btnOk3_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(txtX3.Text);
            double y = Convert.ToDouble(txtY3.Text);
            if (x > 0 && y > 0)
            {
                lblResult3.Text = ("true");
            }
            else
            {
                lblResult3.Text = ("false");
            }
        }

        private void lblResult5_Click(object sender, EventArgs e)
        {
            btnOk5.Text = "OK";
            lblResult5.Text = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double n = Convert.ToDouble(txtN.Text); ;
            int maxDivisorSum = 0;
            int numberWithMaxDivisorSum = 0;

            for (int i = 2; i <= n; i++)
            {
                int divisorSum = 0;

                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divisorSum += j;
                    }
                }

                if (divisorSum > maxDivisorSum)
                {
                    maxDivisorSum = divisorSum;
                    numberWithMaxDivisorSum = i;
                }
            }

            lblResult5.Text = ($"Число з максимальною сумою дільника: {numberWithMaxDivisorSum}");
            lblResult5_5.Text = ($"Сума дільників: {maxDivisorSum}");
        }

        private void label19_Click(object sender, EventArgs e)
        {
            btnOk6.Text = "OK";
            lblResult6.Text = "";
        }
        private void btnOk6_Click_1(object sender, EventArgs e)
        {
            int l;
            l = Convert.ToInt32(txtMasive.Text);
            int[] arr;
            arr = new int[l];
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                arr[i] = i+1;
            }

                int j = 0;

            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    arr[j] = arr[i];
                    j++;
                }
            }

            Array.Resize(ref arr, n / 2);

            lblResult6.Text = (string.Join(", ", arr));
        }

        private void lblResult7_Click(object sender, EventArgs e)
        {
            btnOk7.Text = "OK";
            lblResult7.Text = "";
        }

        private void btnOk7_Click(object sender, EventArgs e)
        {
            string input = txt7.Text;
            int startIndex = input.IndexOf('('); 
            int endIndex = input.IndexOf(')');
            if (startIndex != -1 && endIndex != -1 && endIndex > startIndex)
            {
                string substring = input.Substring(startIndex + 1, endIndex - startIndex - 1);
                lblResult7.Text = substring; 
            }
            else
            {
                lblResult7.Text = "Рядок не містить правильну послідовність дужок.";
            }
        }
    }
}