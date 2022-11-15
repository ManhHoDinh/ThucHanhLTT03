using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai06
{
    public partial class Bai06 : Form
    {
        public Bai06()
        {
            InitializeComponent();
        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(lbSub.Text.Contains("="))
                lbInputText.Text = lbSub.Text = "0";
            
            if(lbInputText.Text.Length<16)
            {
                if (lbInputText.Text == "0")
                    lbInputText.Text = button.Text;
                else
                    lbInputText.Text += button.Text;
                FixFontInputText();
            }
            else
            {
                MessageBox.Show("Number must less than 9,999,999,999","OverFlow");
            }
        }

        private void btPercent_Click(object sender, EventArgs e)
        {
            double result = double.Parse(lbInputText.Text)/100;
            lbSub.Text = lbInputText.Text +"%";
            lbInputText.Text = result.ToString();
            FixFontInputText();
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            lbInputText.Text = "0";
        }

        private void btC_Click(object sender, EventArgs e)
        {
            lbInputText.Text = lbSub.Text="0";
        }

        private void btDel_Click(object sender, EventArgs e)
        {
            if(lbInputText.Text!="0")
                lbInputText.Text=lbInputText.Text.Remove(lbInputText.Text.Length - 1);
            if(lbInputText.Text=="")
                lbInputText.Text="0";
        }

        private void btInverse_Click(object sender, EventArgs e)
        {
            lbSub.Text = "1/(" + lbInputText.Text + ")=";
            double result = 1/double.Parse(lbInputText.Text);
            lbInputText.Text = result.ToString();
            FixFontInputText();
        }

        private void btSquare_Click(object sender, EventArgs e)
        {
            lbSub.Text = "(" + lbInputText.Text + ")^2=";
            double result = double.Parse(lbInputText.Text)* double.Parse(lbInputText.Text);
            lbInputText.Text = result.ToString();
            FixFontInputText();
        }

        private void btSqrt_Click(object sender, EventArgs e)
        {
            lbSub.Text = "sqrt("+lbInputText.Text + ")=";
            double result = Math.Sqrt(double.Parse(lbInputText.Text));
            lbInputText.Text = result.ToString();
            FixFontInputText();
        }

        private void FixFontInputText()
        {
            if (lbInputText.Text.Length < 12)
                lbInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            else if (lbInputText.Text.Length <= 16)
                lbInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            else
                lbInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
        }

        private void btNevigate_Click(object sender, EventArgs e)
        {
            double result = -double.Parse(lbInputText.Text);
            lbInputText.Text = result.ToString();
            FixFontInputText();
        }

        private void btMultiplicationDot_Click(object sender, EventArgs e)
        {
            if (!lbInputText.Text.Contains("."))
                lbInputText.Text += ".";
        }

        private void btEqual_Click(object sender, EventArgs e)
        {
            if (lbSub.Text == "0" || lbSub.Text == "")
            {
                lbSub.Text = lbInputText.Text + "=";
            }
            else
            {
                double number1 = double.Parse(lbSub.Text.Remove(lbSub.Text.Length - 1));

                double number2 = double.Parse(lbInputText.Text);
                string TextNumber1 = number1.ToString();
                string TextNumber2 = number2.ToString();
                if (number1 < 0)
                    TextNumber1 = "(" + number1 + ")";
                if (number2 < 0)
                    TextNumber2 = "(" + number2 + ")";

                if (lbSub.Text.Contains("+"))
                {
                    lbSub.Text = TextNumber1 + "+" + TextNumber2 + "=";
                    lbInputText.Text = (number1 + number2).ToString();
                }
                else if (lbSub.Text[lbSub.Text.Length - 1] == '-')
                {
                    lbSub.Text = TextNumber1 + "-" + TextNumber2 + "=";
                    lbInputText.Text = (number1 - number2).ToString();
                }
                else if (lbSub.Text.Contains("x"))
                {
                    lbSub.Text = TextNumber1 + "x" + TextNumber2 + "=";
                    lbInputText.Text = (number1 * number2).ToString();
                }
                else if (lbSub.Text.Contains("/"))
                {
                    lbSub.Text = TextNumber1 + "/" + TextNumber2 + "=";
                    lbInputText.Text = (number1 / number2).ToString();
                }
            }
            
        }

        private void btMethodOfCalculationClick(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if(lbSub.Text=="0" || lbSub.Text == ""||lbSub.Text.Contains("="))
            {
                lbSub.Text=lbInputText.Text+button.Text;
                lbInputText.Text = "0";
            }
            else
            {
                

                if (lbSub.Text.Contains("+"))
                {
                    double number1 = double.Parse(lbSub.Text.Replace("+", ""));
                    double number2 = double.Parse(lbInputText.Text);

                    lbSub.Text=(number1+number2).ToString() + button.Text;
                }
                else if (lbSub.Text.Contains("-"))
                {

                    double number1 = double.Parse(lbSub.Text.Replace("-", ""));
                    double number2 = double.Parse(lbInputText.Text);

                    lbSub.Text = (number1 - number2).ToString() + button.Text;
                }
                else if (lbSub.Text.Contains("x"))
                {

                    double number1 = double.Parse(lbSub.Text.Replace("x", ""));
                    double number2 = double.Parse(lbInputText.Text);

                    lbSub.Text = (number1 * number2).ToString() + button.Text;
                }
                else if (lbSub.Text.Contains("/"))
                {

                    double number1 = double.Parse(lbSub.Text.Replace("/", ""));
                    double number2 = double.Parse(lbInputText.Text);

                    lbSub.Text = (number1 / number2).ToString() + button.Text;
                }
                lbInputText.Text = "0";
            }
        }
    }
}
