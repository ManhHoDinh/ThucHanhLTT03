namespace Bai09
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btUnselectedSubjects = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btSaveInformation = new System.Windows.Forms.Button();
            this.btAddSubjects = new System.Windows.Forms.Button();
            this.lwUnselectedSubject = new System.Windows.Forms.ListView();
            this.lwSelectedSubject = new System.Windows.Forms.ListView();
            this.rbWomen = new System.Windows.Forms.RadioButton();
            this.rbMen = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbMSSV = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMajor = new System.Windows.Forms.Label();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.lbMSSV = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentManagementDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new DataSet1();
            this.dataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentAndCountSubjectsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentAndCountSubjectsTableAdapter = new DataSet1TableAdapters.StudentAndCountSubjectsTableAdapter();
            this.mSSVDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.majorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subjectCountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAndCountSubjectsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btUnselectedSubjects
            // 
            this.btUnselectedSubjects.Location = new System.Drawing.Point(374, 402);
            this.btUnselectedSubjects.Name = "btUnselectedSubjects";
            this.btUnselectedSubjects.Size = new System.Drawing.Size(54, 42);
            this.btUnselectedSubjects.TabIndex = 5;
            this.btUnselectedSubjects.Text = ">";
            this.btUnselectedSubjects.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(412, 471);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 42);
            this.button2.TabIndex = 5;
            this.button2.Text = "Xóa chọn";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btSaveInformation
            // 
            this.btSaveInformation.Location = new System.Drawing.Point(234, 471);
            this.btSaveInformation.Name = "btSaveInformation";
            this.btSaveInformation.Size = new System.Drawing.Size(134, 42);
            this.btSaveInformation.TabIndex = 5;
            this.btSaveInformation.Text = "Lưu thông tin";
            this.btSaveInformation.UseVisualStyleBackColor = true;
            // 
            // btAddSubjects
            // 
            this.btAddSubjects.Location = new System.Drawing.Point(374, 328);
            this.btAddSubjects.Name = "btAddSubjects";
            this.btAddSubjects.Size = new System.Drawing.Size(54, 42);
            this.btAddSubjects.TabIndex = 5;
            this.btAddSubjects.Text = "<";
            this.btAddSubjects.UseVisualStyleBackColor = true;
            // 
            // lwUnselectedSubject
            // 
            this.lwUnselectedSubject.HideSelection = false;
            this.lwUnselectedSubject.Location = new System.Drawing.Point(479, 318);
            this.lwUnselectedSubject.Name = "lwUnselectedSubject";
            this.lwUnselectedSubject.Size = new System.Drawing.Size(247, 136);
            this.lwUnselectedSubject.TabIndex = 4;
            this.lwUnselectedSubject.UseCompatibleStateImageBehavior = false;
            // 
            // lwSelectedSubject
            // 
            this.lwSelectedSubject.HideSelection = false;
            this.lwSelectedSubject.Location = new System.Drawing.Point(87, 318);
            this.lwSelectedSubject.Name = "lwSelectedSubject";
            this.lwSelectedSubject.Size = new System.Drawing.Size(247, 136);
            this.lwSelectedSubject.TabIndex = 4;
            this.lwSelectedSubject.UseCompatibleStateImageBehavior = false;
            // 
            // rbWomen
            // 
            this.rbWomen.AutoSize = true;
            this.rbWomen.Location = new System.Drawing.Point(361, 219);
            this.rbWomen.Name = "rbWomen";
            this.rbWomen.Size = new System.Drawing.Size(54, 24);
            this.rbWomen.TabIndex = 4;
            this.rbWomen.TabStop = true;
            this.rbWomen.Text = "Nữ";
            this.rbWomen.UseVisualStyleBackColor = true;
            // 
            // rbMen
            // 
            this.rbMen.AutoSize = true;
            this.rbMen.Location = new System.Drawing.Point(234, 217);
            this.rbMen.Name = "rbMen";
            this.rbMen.Size = new System.Drawing.Size(67, 24);
            this.rbMen.TabIndex = 3;
            this.rbMen.TabStop = true;
            this.rbMen.Text = "Nam";
            this.rbMen.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btUnselectedSubjects);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.btSaveInformation);
            this.groupBox1.Controls.Add(this.btAddSubjects);
            this.groupBox1.Controls.Add(this.lwUnselectedSubject);
            this.groupBox1.Controls.Add(this.lwSelectedSubject);
            this.groupBox1.Controls.Add(this.rbWomen);
            this.groupBox1.Controls.Add(this.rbMen);
            this.groupBox1.Controls.Add(this.cbMajor);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.tbMSSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lbMajor);
            this.groupBox1.Controls.Add(this.lbGender);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.lbMSSV);
            this.groupBox1.Location = new System.Drawing.Point(12, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(911, 528);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // cbMajor
            // 
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Location = new System.Drawing.Point(234, 163);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(280, 28);
            this.cbMajor.TabIndex = 2;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(234, 111);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(280, 26);
            this.tbName.TabIndex = 1;
            // 
            // tbMSSV
            // 
            this.tbMSSV.Location = new System.Drawing.Point(234, 61);
            this.tbMSSV.Name = "tbMSSV";
            this.tbMSSV.Size = new System.Drawing.Size(232, 26);
            this.tbMSSV.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Các môn học đã tham gia";
            // 
            // lbMajor
            // 
            this.lbMajor.AutoSize = true;
            this.lbMajor.Location = new System.Drawing.Point(83, 166);
            this.lbMajor.Name = "lbMajor";
            this.lbMajor.Size = new System.Drawing.Size(114, 20);
            this.lbMajor.TabIndex = 0;
            this.lbMajor.Text = "Chuyên Ngành";
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(83, 219);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(71, 20);
            this.lbGender.TabIndex = 0;
            this.lbGender.Text = "Giới Tính";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(83, 117);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(61, 20);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Họ Tên";
            // 
            // lbMSSV
            // 
            this.lbMSSV.AutoSize = true;
            this.lbMSSV.Location = new System.Drawing.Point(83, 61);
            this.lbMSSV.Name = "lbMSSV";
            this.lbMSSV.Size = new System.Drawing.Size(103, 20);
            this.lbMSSV.TabIndex = 0;
            this.lbMSSV.Text = "Mã Sinh Viên";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.mSSVDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.majorDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.subjectCountDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentAndCountSubjectsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 535);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(911, 251);
            this.dataGridView1.TabIndex = 2;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataSet1BindingSource
            // 
            this.dataSet1BindingSource.DataSource = this.dataSet1;
            this.dataSet1BindingSource.Position = 0;
            // 
            // studentAndCountSubjectsBindingSource
            // 
            this.studentAndCountSubjectsBindingSource.DataMember = "StudentAndCountSubjects";
            this.studentAndCountSubjectsBindingSource.DataSource = this.dataSet1;
            // 
            // studentAndCountSubjectsTableAdapter
            // 
            this.studentAndCountSubjectsTableAdapter.ClearBeforeFill = true;
            // 
            // mSSVDataGridViewTextBoxColumn
            // 
            this.mSSVDataGridViewTextBoxColumn.DataPropertyName = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.HeaderText = "MSSV";
            this.mSSVDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.mSSVDataGridViewTextBoxColumn.Name = "mSSVDataGridViewTextBoxColumn";
            this.mSSVDataGridViewTextBoxColumn.ReadOnly = true;
            this.mSSVDataGridViewTextBoxColumn.Width = 150;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Họ Tên";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
            // 
            // majorDataGridViewTextBoxColumn
            // 
            this.majorDataGridViewTextBoxColumn.DataPropertyName = "Major";
            this.majorDataGridViewTextBoxColumn.HeaderText = "Chuyên Ngành";
            this.majorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.majorDataGridViewTextBoxColumn.Name = "majorDataGridViewTextBoxColumn";
            this.majorDataGridViewTextBoxColumn.ReadOnly = true;
            this.majorDataGridViewTextBoxColumn.Width = 150;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Giới Tính";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            this.genderDataGridViewTextBoxColumn.Width = 150;
            // 
            // subjectCountDataGridViewTextBoxColumn
            // 
            this.subjectCountDataGridViewTextBoxColumn.DataPropertyName = "SubjectCount";
            this.subjectCountDataGridViewTextBoxColumn.HeaderText = "Số Môn";
            this.subjectCountDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.subjectCountDataGridViewTextBoxColumn.Name = "subjectCountDataGridViewTextBoxColumn";
            this.subjectCountDataGridViewTextBoxColumn.ReadOnly = true;
            this.subjectCountDataGridViewTextBoxColumn.Width = 150;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 804);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentManagementDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentAndCountSubjectsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btUnselectedSubjects;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btSaveInformation;
        private System.Windows.Forms.Button btAddSubjects;
        private System.Windows.Forms.ListView lwUnselectedSubject;
        private System.Windows.Forms.ListView lwSelectedSubject;
        private System.Windows.Forms.RadioButton rbWomen;
        private System.Windows.Forms.RadioButton rbMen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbMSSV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMajor;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbMSSV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource studentManagementDBDataSetBindingSource;
        private System.Windows.Forms.BindingSource dataSet1BindingSource;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource studentAndCountSubjectsBindingSource;
        private DataSet1TableAdapters.StudentAndCountSubjectsTableAdapter studentAndCountSubjectsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn mSSVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn majorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subjectCountDataGridViewTextBoxColumn;
    }
}