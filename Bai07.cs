using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanh3
{
    public partial class Bai07 : Form
    {
        public Bai07()
        {
            InitializeComponent();
        }
        Color SelectedColor = Color.Red;
        Color BookedColor = Color.Gray;
        Color AvalibleColor = Color.White;
        List  <Button> SelectedChairs = new List<Button>();
        
        private void ClickChair(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor == BookedColor)
            {
                MessageBox.Show("Chỗ ngồi " + button.Text+" đã được đặt.");
            }
            else if(button.BackColor == AvalibleColor)
            {
                SelectedChairs.Add(button);
               button.BackColor = SelectedColor;
                int TotalPrice = int.Parse(labelResult.Text);
                int Price = 0;
                if (int.Parse(button.Text) <= 5)
                    Price = 5000;
                else if (int.Parse(button.Text) <= 10 && int.Parse(button.Text) >= 5)
                    Price = 6500;
                else
                    Price = 8000;
                TotalPrice+= Price;
                labelResult.Text  = TotalPrice.ToString();
            }   
            else
            {
                SelectedChairs.Remove(button);
                button.BackColor = AvalibleColor;
                int TotalPrice = int.Parse(labelResult.Text);
                int Price = 0;
                if (int.Parse(button.Text) <= 5)
                    Price = 5000;
                else if (int.Parse(button.Text) <= 10 && int.Parse(button.Text) >= 5)
                    Price = 6500;
                else
                    Price = 8000;
                TotalPrice -= Price;
                labelResult.Text = TotalPrice.ToString();
            }    
        }

        private void ClickSelect(object sender, EventArgs e)
        {
            try
            {
                foreach (Button bt in SelectedChairs){
                    bt.BackColor = BookedColor;
                }
                SelectedChairs = new List<Button>();
                labelResult.Text = "0";

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (Button bt in SelectedChairs)
                {
                    bt.BackColor = AvalibleColor;
                }
                SelectedChairs = new List<Button>();
                labelResult.Text = "0";
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
