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
            this.btRemoveInformation = new System.Windows.Forms.Button();
            this.btSaveInformation = new System.Windows.Forms.Button();
            this.btAddSubject = new System.Windows.Forms.Button();
            this.btRemoveSubject = new System.Windows.Forms.Button();
            this.lwSeletedSubjects = new System.Windows.Forms.ListView();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.cbMajor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbMajor = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbStudentCode = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lwAllSubjects = new System.Windows.Forms.ListView();
            this.lbGender = new System.Windows.Forms.Label();
            this.lbStudentCode = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btRemoveInformation
            // 
            this.btRemoveInformation.Location = new System.Drawing.Point(476, 437);
            this.btRemoveInformation.Name = "btRemoveInformation";
            this.btRemoveInformation.Size = new System.Drawing.Size(107, 33);
            this.btRemoveInformation.TabIndex = 5;
            this.btRemoveInformation.Text = "Remove";
            this.btRemoveInformation.UseVisualStyleBackColor = true;
            // 
            // btSaveInformation
            // 
            this.btSaveInformation.Location = new System.Drawing.Point(310, 437);
            this.btSaveInformation.Name = "btSaveInformation";
            this.btSaveInformation.Size = new System.Drawing.Size(72, 33);
            this.btSaveInformation.TabIndex = 5;
            this.btSaveInformation.Text = "Save";
            this.btSaveInformation.UseVisualStyleBackColor = true;
            this.btSaveInformation.Click += new System.EventHandler(this.btSaveInformation_Click);
            // 
            // btAddSubject
            // 
            this.btAddSubject.Location = new System.Drawing.Point(411, 305);
            this.btAddSubject.Name = "btAddSubject";
            this.btAddSubject.Size = new System.Drawing.Size(28, 33);
            this.btAddSubject.TabIndex = 5;
            this.btAddSubject.Text = ">";
            this.btAddSubject.UseVisualStyleBackColor = true;
            this.btAddSubject.Click += new System.EventHandler(this.btAddSubject_Click);
            // 
            // btRemoveSubject
            // 
            this.btRemoveSubject.Location = new System.Drawing.Point(411, 362);
            this.btRemoveSubject.Name = "btRemoveSubject";
            this.btRemoveSubject.Size = new System.Drawing.Size(28, 33);
            this.btRemoveSubject.TabIndex = 5;
            this.btRemoveSubject.Text = "<";
            this.btRemoveSubject.UseVisualStyleBackColor = true;
            this.btRemoveSubject.Click += new System.EventHandler(this.btRemoveSubject_Click);
            // 
            // lwSeletedSubjects
            // 
            this.lwSeletedSubjects.HideSelection = false;
            this.lwSeletedSubjects.Location = new System.Drawing.Point(476, 288);
            this.lwSeletedSubjects.Name = "lwSeletedSubjects";
            this.lwSeletedSubjects.Size = new System.Drawing.Size(362, 124);
            this.lwSeletedSubjects.TabIndex = 4;
            this.lwSeletedSubjects.UseCompatibleStateImageBehavior = false;
            this.lwSeletedSubjects.View = System.Windows.Forms.View.Tile;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(352, 197);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(87, 24);
            this.rbFemale.TabIndex = 3;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(225, 197);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(68, 24);
            this.rbMale.TabIndex = 3;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // cbMajor
            // 
            this.cbMajor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMajor.FormattingEnabled = true;
            this.cbMajor.Location = new System.Drawing.Point(225, 140);
            this.cbMajor.Name = "cbMajor";
            this.cbMajor.Size = new System.Drawing.Size(371, 28);
            this.cbMajor.TabIndex = 2;
            this.cbMajor.SelectedIndexChanged += new System.EventHandler(this.cbMajor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subjects participated";
            // 
            // lbMajor
            // 
            this.lbMajor.AutoSize = true;
            this.lbMajor.Location = new System.Drawing.Point(116, 148);
            this.lbMajor.Name = "lbMajor";
            this.lbMajor.Size = new System.Drawing.Size(48, 20);
            this.lbMajor.TabIndex = 1;
            this.lbMajor.Text = "Major";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(116, 97);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(51, 20);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Name";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(225, 91);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(135, 26);
            this.tbName.TabIndex = 1;
            // 
            // tbStudentCode
            // 
            this.tbStudentCode.Location = new System.Drawing.Point(225, 36);
            this.tbStudentCode.Name = "tbStudentCode";
            this.tbStudentCode.Size = new System.Drawing.Size(135, 26);
            this.tbStudentCode.TabIndex = 0;
            this.tbStudentCode.TextChanged += new System.EventHandler(this.tbStudentCode_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btRemoveInformation);
            this.groupBox2.Controls.Add(this.btSaveInformation);
            this.groupBox2.Controls.Add(this.btAddSubject);
            this.groupBox2.Controls.Add(this.btRemoveSubject);
            this.groupBox2.Controls.Add(this.lwAllSubjects);
            this.groupBox2.Controls.Add(this.lwSeletedSubjects);
            this.groupBox2.Controls.Add(this.rbFemale);
            this.groupBox2.Controls.Add(this.rbMale);
            this.groupBox2.Controls.Add(this.cbMajor);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbGender);
            this.groupBox2.Controls.Add(this.lbMajor);
            this.groupBox2.Controls.Add(this.lbName);
            this.groupBox2.Controls.Add(this.tbName);
            this.groupBox2.Controls.Add(this.lbStudentCode);
            this.groupBox2.Controls.Add(this.tbStudentCode);
            this.groupBox2.Location = new System.Drawing.Point(3, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(873, 489);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Student Information";
            // 
            // lwAllSubjects
            // 
            this.lwAllSubjects.FullRowSelect = true;
            this.lwAllSubjects.HideSelection = false;
            this.lwAllSubjects.Location = new System.Drawing.Point(38, 288);
            this.lwAllSubjects.Name = "lwAllSubjects";
            this.lwAllSubjects.Size = new System.Drawing.Size(344, 124);
            this.lwAllSubjects.TabIndex = 4;
            this.lwAllSubjects.UseCompatibleStateImageBehavior = false;
            this.lwAllSubjects.View = System.Windows.Forms.View.Tile;
            // 
            // lbGender
            // 
            this.lbGender.AutoSize = true;
            this.lbGender.Location = new System.Drawing.Point(116, 197);
            this.lbGender.Name = "lbGender";
            this.lbGender.Size = new System.Drawing.Size(63, 20);
            this.lbGender.TabIndex = 1;
            this.lbGender.Text = "Gender";
            // 
            // lbStudentCode
            // 
            this.lbStudentCode.AutoSize = true;
            this.lbStudentCode.Location = new System.Drawing.Point(116, 42);
            this.lbStudentCode.Name = "lbStudentCode";
            this.lbStudentCode.Size = new System.Drawing.Size(55, 20);
            this.lbStudentCode.TabIndex = 1;
            this.lbStudentCode.Text = "MSSV";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(3, 507);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 62;
            this.dataGridView.RowTemplate.Height = 28;
            this.dataGridView.Size = new System.Drawing.Size(838, 341);
            this.dataGridView.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 853);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormClosing1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRemoveInformation;
        private System.Windows.Forms.Button btSaveInformation;
        private System.Windows.Forms.Button btAddSubject;
        private System.Windows.Forms.Button btRemoveSubject;
        private System.Windows.Forms.ListView lwSeletedSubjects;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.ComboBox cbMajor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbMajor;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbStudentCode;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lbGender;
        private System.Windows.Forms.Label lbStudentCode;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ListView lwAllSubjects;
    }
}

