namespace Bai08
{
    partial class Bai08
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbAccountNumber = new System.Windows.Forms.Label();
            this.tbAccountNumber = new System.Windows.Forms.TextBox();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.lbMoneyInAccount = new System.Windows.Forms.Label();
            this.tbMoneyInAccount = new System.Windows.Forms.TextBox();
            this.btNewOrUpdate = new System.Windows.Forms.Button();
            this.btRemove = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Indexcolumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AccountNumberColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerAddressColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.MoneyColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lbTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lbTitle.Location = new System.Drawing.Point(0, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(1100, 76);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Quản lý thông tin tài khoản";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbAccountNumber
            // 
            this.lbAccountNumber.Location = new System.Drawing.Point(-2, 104);
            this.lbAccountNumber.Name = "lbAccountNumber";
            this.lbAccountNumber.Size = new System.Drawing.Size(234, 31);
            this.lbAccountNumber.TabIndex = 1;
            this.lbAccountNumber.Text = "Số tài khoản";
            this.lbAccountNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbAccountNumber
            // 
            this.tbAccountNumber.Location = new System.Drawing.Point(312, 101);
            this.tbAccountNumber.Name = "tbAccountNumber";
            this.tbAccountNumber.Size = new System.Drawing.Size(496, 26);
            this.tbAccountNumber.TabIndex = 0;
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.Location = new System.Drawing.Point(-2, 155);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(234, 31);
            this.lbCustomerName.TabIndex = 1;
            this.lbCustomerName.Text = "Tên Khách Hàng";
            this.lbCustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(312, 152);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(496, 26);
            this.tbCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(-2, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Địa chỉ khách hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.Location = new System.Drawing.Point(312, 204);
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.Size = new System.Drawing.Size(496, 26);
            this.tbCustomerAddress.TabIndex = 2;
            // 
            // lbMoneyInAccount
            // 
            this.lbMoneyInAccount.Location = new System.Drawing.Point(-2, 261);
            this.lbMoneyInAccount.Name = "lbMoneyInAccount";
            this.lbMoneyInAccount.Size = new System.Drawing.Size(234, 31);
            this.lbMoneyInAccount.TabIndex = 1;
            this.lbMoneyInAccount.Text = "Số tiền trong tài khoản";
            this.lbMoneyInAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbMoneyInAccount
            // 
            this.tbMoneyInAccount.Location = new System.Drawing.Point(312, 258);
            this.tbMoneyInAccount.Name = "tbMoneyInAccount";
            this.tbMoneyInAccount.Size = new System.Drawing.Size(496, 26);
            this.tbMoneyInAccount.TabIndex = 3;
            // 
            // btNewOrUpdate
            // 
            this.btNewOrUpdate.Location = new System.Drawing.Point(405, 305);
            this.btNewOrUpdate.Name = "btNewOrUpdate";
            this.btNewOrUpdate.Size = new System.Drawing.Size(184, 35);
            this.btNewOrUpdate.TabIndex = 5;
            this.btNewOrUpdate.Text = "Thêm / Cập Nhập";
            this.btNewOrUpdate.UseVisualStyleBackColor = true;
            this.btNewOrUpdate.Click += new System.EventHandler(this.btNewOrUpdate_Click);
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(626, 305);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(150, 35);
            this.btRemove.TabIndex = 6;
            this.btRemove.Text = "Xóa";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // btClose
            // 
            this.btClose.Location = new System.Drawing.Point(801, 305);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(150, 35);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Thoát";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Indexcolumn,
            this.AccountNumberColumn,
            this.CustomerNameColumn,
            this.CustomerAddressColumn,
            this.MoneyColumn});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 346);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1098, 306);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Indexcolumn
            // 
            this.Indexcolumn.Text = "STT";
            // 
            // AccountNumberColumn
            // 
            this.AccountNumberColumn.Text = "Số tài khoản";
            this.AccountNumberColumn.Width = 150;
            // 
            // CustomerNameColumn
            // 
            this.CustomerNameColumn.Text = "Tên Khách hàng";
            this.CustomerNameColumn.Width = 250;
            // 
            // CustomerAddressColumn
            // 
            this.CustomerAddressColumn.Text = "Địa chỉ";
            this.CustomerAddressColumn.Width = 400;
            // 
            // MoneyColumn
            // 
            this.MoneyColumn.Text = "Số tiền";
            this.MoneyColumn.Width = 232;
            // 
            // Bai08
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 688);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.btNewOrUpdate);
            this.Controls.Add(this.tbMoneyInAccount);
            this.Controls.Add(this.tbCustomerAddress);
            this.Controls.Add(this.tbCustomerName);
            this.Controls.Add(this.tbAccountNumber);
            this.Controls.Add(this.lbMoneyInAccount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbCustomerName);
            this.Controls.Add(this.lbAccountNumber);
            this.Controls.Add(this.lbTitle);
            this.Name = "Bai08";
            this.Text = "Bai08";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.btClose_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbAccountNumber;
        private System.Windows.Forms.TextBox tbAccountNumber;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbCustomerAddress;
        private System.Windows.Forms.Label lbMoneyInAccount;
        private System.Windows.Forms.TextBox tbMoneyInAccount;
        private System.Windows.Forms.Button btNewOrUpdate;
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Indexcolumn;
        private System.Windows.Forms.ColumnHeader AccountNumberColumn;
        private System.Windows.Forms.ColumnHeader CustomerNameColumn;
        private System.Windows.Forms.ColumnHeader CustomerAddressColumn;
        private System.Windows.Forms.ColumnHeader MoneyColumn;
    }
}

