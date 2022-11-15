using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai08
{
    public partial class Bai08 : Form
    {
        public Bai08()
        {
            InitializeComponent();
            listView1.HideSelection = false;
        }

       

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void UpdateListView()
        {
            int index = 1;
            foreach (ListViewItem item in listView1.Items)
                item.SubItems[0].Text = (index++).ToString();
        }

        private void btNewOrUpdate_Click(object sender, EventArgs e)
        {
            int money = 0;
            try
            {
                if (!int.TryParse(tbMoneyInAccount.Text, out money))
                    throw new FormatException("Số tiền trong ví phải là số nguyên vui lòng nhập lại.");
                else if (tbAccountNumber.Text != "" && tbCustomerAddress.Text != "" && tbCustomerName.Text != "" && tbMoneyInAccount.Text != "")
                {
                    bool haveInListView = false;
                    ListViewItem NewItem = new ListViewItem("");
                    foreach (ListViewItem item in listView1.Items)
                        if (item.SubItems[1].Text == tbAccountNumber.Text)
                        {
                            item.SubItems[2].Text = tbCustomerName.Text;
                            item.SubItems[3].Text = tbCustomerAddress.Text;
                            item.SubItems[4].Text = tbMoneyInAccount.Text;
                            haveInListView = true;
                            MessageBox.Show("Cập nhập thông tin của tài khoản có số tài khoản : " + tbAccountNumber.Text + " thành công.");
                            break;

                        }
                    if (!haveInListView)
                    {
                        NewItem.SubItems.Add(tbAccountNumber.Text);
                        NewItem.SubItems.Add(tbCustomerName.Text);
                        NewItem.SubItems.Add(tbCustomerAddress.Text);
                        NewItem.SubItems.Add(tbMoneyInAccount.Text);
                        listView1.Items.Add(NewItem);
                        MessageBox.Show("Thêm mới dữ liệu có số tài khoản: " + tbAccountNumber.Text + " thành công.");
                    }
                    tbAccountNumber.Text = tbCustomerAddress.Text = tbCustomerName.Text = tbMoneyInAccount.Text = "";
                    UpdateListView();
                }
                else
                    throw new Exception("Input all boxes, Please!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                ListViewItem item = listView1.SelectedItems[0];
                tbAccountNumber.Text = item.SubItems[1].Text;

                tbCustomerName.Text = item.SubItems[2].Text;

                tbCustomerAddress.Text = item.SubItems[3].Text;

                tbMoneyInAccount.Text = item.SubItems[4].Text;
            }
            catch { }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            try {
                Boolean HaveInListView = false;
                foreach (ListViewItem item in listView1.Items)
                    if (item.SubItems[1].Text == tbAccountNumber.Text)
                    {
                        DialogResult dialogResult= MessageBox.Show("Bạn có muốn xóa tài khoản có số tài khoản: " + tbAccountNumber.Text, "Xác nhận xóa tài khoản", MessageBoxButtons.YesNo);
                        if(dialogResult == DialogResult.Yes)
                        {
                            listView1.Items.Remove(item);
                            tbAccountNumber.Text = tbCustomerAddress.Text = tbCustomerName.Text = tbMoneyInAccount.Text = "";
                            UpdateListView();
                        }    
                        HaveInListView = true;
                        break;
                    }
                if (!HaveInListView)
                    MessageBox.Show("Không tìm thấy tài khoản có số tài khoản : " + tbAccountNumber.Text, "Lỗi không tìm thấy tài khoản");
            }
            catch { }
        }

        private void btClose_Click(object sender, FormClosingEventArgs e)
        {

            DialogResult = MessageBox.Show("Do you want to close this Application?", "Close Application", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.No)
                e.Cancel = true;
        }
    }
}
