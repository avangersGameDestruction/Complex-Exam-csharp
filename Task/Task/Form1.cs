using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtSplitNumber.Text)
                && IsValidString(txtSplitNumber.Text))
            {
                string[] numbers = txtSplitNumber.Text.Split(',');
                txtFirstNumber.Text = numbers[0].Replace("(", "").Replace(")", "");
                txtSecondNumber.Text = numbers[1].Replace("(", "").Replace(")", "");
                
            }
            else
                MessageBox.Show("pattern isn't correct");
        }

        private bool IsValidString(string text) =>
            !Regex.IsMatch(text.Trim(),
                @"^$\([0-9]{1,5}\-|\+[0-9]{1,5} [i] \)\,\([0-9]{1,5}\+|\-[0-9]{1,5} [i] \)");
        private string Add(string firstNumber , string secondNumber)
        {
            string result = "";
            string a, b, c, d;
            a = firstNumber.Substring(0, (firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-'));
            b = firstNumber.Substring((firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-') , firstNumber.Length - 2);
            c = secondNumber.Substring(0, (secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-'));
            d = secondNumber.Substring((secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-'), secondNumber.Length - 2);
            result = $"{double.Parse(a) + double.Parse(c.Replace("i",""))} + {double.Parse(b.Replace("i", "")) - double.Parse(d.Replace("i", ""))}i";
            return result;
        }
        private string Sub(string firstNumber, string secondNumber)
        {
            string result = "";
            string a, b, c, d;
            a = firstNumber.Substring(0, (firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-'));
            b = firstNumber.Substring((firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-'), firstNumber.Length - 2);
            c = secondNumber.Substring(0, (secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-'));
            d = secondNumber.Substring((secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-'), secondNumber.Length - 2);
            result = $"{double.Parse(a) - double.Parse(c.Replace("i", ""))} + {double.Parse(b.Replace("i", "")) - Math.Abs(double.Parse(d.Replace("i", "")))}i";
            return result;
        }
        private string Mul(string firstNumber, string secondNumber)
        {
            string result = "";
            double a, b, c, d;
            a = double.Parse(firstNumber.Substring(0, (firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-')));
            b = double.Parse(firstNumber.Substring((firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-'), firstNumber.Length - 2).Replace("i", ""));
            c = double.Parse(secondNumber.Substring(0, (secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-')));
            d = double.Parse(secondNumber.Substring((secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-'), secondNumber.Length - 2).Replace("i", ""));
            result =$"{a * c - Math.Abs(b * d) } + { (b * c) - Math.Abs(a * d)}i";
            return result;
        }
        private string Div(string firstNumber, string secondNumber)
        {
            string result = "";
            double a, b, c, d;
            a = double.Parse(firstNumber.Substring(0, (firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-')));
            b = double.Parse(firstNumber.Substring((firstNumber.IndexOf('+') >= 0) ? firstNumber.IndexOf('+') : firstNumber.IndexOf('-'), firstNumber.Length - 2).Replace("i",""));
            c = double.Parse(secondNumber.Substring(0, (secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-')));
            d = double.Parse(secondNumber.Substring((secondNumber.IndexOf('+') >= 0) ? secondNumber.IndexOf('+') : secondNumber.IndexOf('-'), secondNumber.Length - 2).Replace("i", ""));
            result = $"{Math.Round(( (a * c + b * d) / (c * c - Math.Abs(a * d)) ) , 2)} + { Math.Round( (b * c - Math.Abs((a * d))) / (c * c + d * d) , 2)}i ";
            return result;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstNumber.Text) && !string.IsNullOrEmpty(txtSecondNumber.Text))
                 txtResult.Text = Add(txtFirstNumber.Text, txtSecondNumber.Text);
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstNumber.Text) && !string.IsNullOrEmpty(txtSecondNumber.Text))
                txtResult.Text = Sub(txtFirstNumber.Text, txtSecondNumber.Text);
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstNumber.Text) && !string.IsNullOrEmpty(txtSecondNumber.Text))
                txtResult.Text = Mul(txtFirstNumber.Text, txtSecondNumber.Text);
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtFirstNumber.Text) && !string.IsNullOrEmpty(txtSecondNumber.Text))
                txtResult.Text = Div(txtFirstNumber.Text, txtSecondNumber.Text);
        }
    }
}
