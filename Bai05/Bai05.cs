using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void btCalculatorClick(object sender, EventArgs e)
        {
            try {
                Button button = sender as Button;
                double number1, number2;
                if (!Double.TryParse(tbNumber1.Text, out number1))
                    throw new Exception("Input TextBox Number1 is incorrect, Number1 is not number format");
                if (!Double.TryParse(tbNumber2.Text, out number2))
                    throw new Exception("Input TextBox Number2 is incorrect, Number2 is not number format");
                double result = 0;
                if (button.Text == "+")
                    result = number1 + number2;
                else if (button.Text == "-")
                    result = number1 - number2;
                else if (button.Text == "*")
                    result = number1 * number2;
                else if (button.Text == "/")
                {
                    if (number2 == 0)
                        throw new Exception("Number 2 must not equal 0");
                    result = number1 / number2;
                }
                tbAnswer.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormClosingEvent(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to close the form?", "Close this Form", MessageBoxButtons.YesNo);
            if (result == DialogResult.No)
                e.Cancel = true;
        }
    }
}
